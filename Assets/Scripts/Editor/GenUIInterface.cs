using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System;
using System.Text;
using System.IO;

public enum InterfaceType
{
    ByName,
    ByPath,
    ByOrgin,
}

public class MethodParam
{
    public Type paramType;
    public string name;
    public bool isOut;
    public bool isRef;

    public string Code
    {
        get
        {
            if (paramType.IsConstructedGenericType)
            {
                Type[] types = paramType.GenericTypeArguments;
                Type type = types[0];
                if (type.DeclaringType != null)
                {
                    return string.Format("List<{0}> ", string.Format("{0}.{1}", type.DeclaringType.FullName, type.Name)) + name;
                }

                return string.Format("List<{0}> ", type.FullName) + name;
            }

            if (paramType.DeclaringType != null)
            {
                return string.Format("{0}.{1} {2}", paramType.DeclaringType.FullName, paramType.Name, name);
            }

            if (isOut || isRef)
            {
                return string.Format("{0} {1}", paramType.FullName.Replace("&", string.Empty), name);
            }

            return string.Format("{0} {1}", paramType.FullName, name);
        }
    }

    public string Name
    {
        get
        {
            if (isOut)
                return "out " + name;
            else if(isRef)
                return "ref " + name;

            return name;
        }
    }

    public string NamespaceName
    {
        get
        {
            return paramType.Namespace;
        }
    }
}

public class Method
{
    public string name;
    public string thisName;
    public Type returnType;
    public List<MethodParam> methodParams;
    public List<string> namespaces;
    private string GET = "get_";
    private string SET = "set_";

    public Method()
    {
        methodParams = new List<MethodParam>();
        namespaces = new List<string>();
    }

    public string ReturnTypeName
    {
        get
        {
            string fullName = returnType.FullName;

            //泛型
            if (returnType.IsConstructedGenericType)
            {
                Type[] types = returnType.GenericTypeArguments;
                Type type = types[0];
                string genericsType = returnType.Name.Split('`')[0];

                if (type.DeclaringType != null)
                {
                    fullName = string.Format("{0}<{1}> ", genericsType, string.Format("{0}.{1}", type.DeclaringType.FullName, type.Name));
                }
                else
                {
                    fullName = string.Format("{0}<{1}> ", genericsType, type.FullName);
                }
            }

            if (returnType.DeclaringType != null)
            {
                fullName = string.Format("{0}.{1}", returnType.DeclaringType.FullName, returnType.Name);
            }

            string typeName = isVoid ? "void" : fullName;
            return typeName;
        }
    }

    public string FuncHead(InterfaceType interfaceType)
    {
        string format = "\tpublic static {0} {1}_{2}";
        string headName = name;

        if (isGet || isSet)
        {
            headName = isGet ? "Get" + thisName + CapitalizeFirstLetter(name.Replace(GET, string.Empty))
                : "Set" + thisName + CapitalizeFirstLetter(name.Replace(SET, string.Empty));
        }

        string head = string.Format(format, ReturnTypeName, headName, interfaceType.ToString());
        return head;
    }

    public string FuncParam(InterfaceType interfaceType)
    {
        StringBuilder builder = new StringBuilder();
        string format = "({0})";

        string param = string.Format(format, ParamCode(interfaceType));
        return param;
    }

    public string FuncBody(InterfaceType interfaceType)
    {
        StringBuilder builder = new StringBuilder();
        bool property = isGet || isSet;
        builder.AppendLine(string.Format("\t\t{0} {1} = {2};", thisName, thisName.ToLower(), GetInterfaceName(interfaceType)));
        builder.AppendLine(string.Format("\t\tif({0} != null)", thisName.ToLower()));
        builder.AppendLine("\t\t{");

        if (property)
        {
            string funcName = isGet ? name.Replace(GET, string.Empty) : name.Replace(SET, string.Empty);
            if (isGet)
            {
                builder.AppendLine(string.Format("\t\t\treturn {0}.{1};", thisName.ToLower(), funcName));
            }
            else
            {
                builder.AppendLine(string.Format("\t\t\t{0}.{1} = {2};", thisName.ToLower(), funcName, Param));
            }
        }
        else
        {
            if (isVoid)
            {
                builder.AppendLine(string.Format("\t\t\t{0}.{1}({2});", thisName.ToLower(), name, Param));
            }
            else
            {
                builder.AppendLine(string.Format("\t\t\treturn {0}.{1}({2});", thisName.ToLower(), name, Param));
            }
        }

        builder.AppendLine("\t\t}");
        if (isGet || !isVoid)
        {
            builder.AppendLine();
            if (returnType.IsClass)
            {
                builder.AppendLine("\t\treturn null;");
            }
            else
            {
                builder.AppendLine(string.Format("\t\treturn default({0});", ReturnTypeName));
            }
        }

        return builder.ToString();
    }

    public string GetInterfaceName(InterfaceType interfaceType)
    {
        switch (interfaceType)
        {
            case InterfaceType.ByName:
                return string.Format("Get{0}ByName(name)", thisName, thisName);
            case InterfaceType.ByPath:
                return string.Format("Get{0}ByPath(path)", thisName, thisName);
            case InterfaceType.ByOrgin:
                return string.Format("Get{0}ByOrgin(parentName, path)", thisName, thisName);
        }

        return "";
    }

    public string Code(InterfaceType interfaceType)
    {
        StringBuilder builder = new StringBuilder();
        string head = FuncHead(interfaceType);
        string param = FuncParam(interfaceType);
        string body = FuncBody(interfaceType);
        builder.AppendLine(head + param);
        builder.AppendLine("\t{");
        builder.AppendLine(body + "\t}");
        return builder.ToString();
    }

    public bool isVoid
    {
        get
        {
            return returnType == typeof(void);
        }
    }

    public bool isGet
    {
        get
        {
            return name.StartsWith(GET);
        }
    }

    public bool isSet
    {
        get
        {
            return name.StartsWith(SET);
        }
    }

    public string ParamCode(InterfaceType interfaceType)
    {
        StringBuilder builder = new StringBuilder();
        foreach (MethodParam methodParam in methodParams)
        {
            builder.Append(methodParam.Code);
            builder.Append(", ");

            if (!namespaces.Contains(methodParam.NamespaceName))
                namespaces.Add(methodParam.NamespaceName);
        }

        switch (interfaceType)
        {
            case InterfaceType.ByName:
                builder.Append("string name");
                break;
            case InterfaceType.ByPath:
                builder.Append("string path");
                break;
            case InterfaceType.ByOrgin:
                builder.Append("string parentName, string path");
                break;
        }

        string code = builder.ToString();
        return code;
    }

    public string Param
    {
        get
        {
            StringBuilder builder = new StringBuilder();
            foreach (MethodParam methodParam in methodParams)
            {
                builder.Append(methodParam.Name);
                builder.Append(", ");
            }

            string code = builder.ToString();
            if (string.IsNullOrEmpty(code))
                return code;

            code = code.Substring(0, code.Length - 2);
            return code;
        }
    }

    private string CapitalizeFirstLetter(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        return char.ToUpper(input[0]) + input.Substring(1);
    }
}

public class ClassInfo
{
    public string name;
    public List<Method> Methods;
    public List<string> namespaces;

    public ClassInfo()
    {
        Methods = new List<Method>();
        namespaces = new List<string>()
        {
            "UnityEngine",
            GenUIInterface.NAME,
            GenUIInterface.SYSTEM,
            GenUIInterface.GENERIC
        };
    }
    public string ByName
    {
        get
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("\tpublic static {0} Get{1}ByName(string name)", name, name));
            builder.AppendLine("\t{");
            builder.AppendLine(string.Format("\t\treturn UIManager.GetComponentByName<{0}>(name);", name));
            builder.AppendLine("\t}");
            return builder.ToString();
        }
    }

    public string ByPath
    {
        get
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("\tpublic static {0} Get{1}ByPath(string path)", name, name));
            builder.AppendLine("\t{");
            builder.AppendLine(string.Format("\t\treturn UIManager.GetComponentByPath<{0}>(path);", name));
            builder.AppendLine("\t}");
            return builder.ToString();
        }
    }

    public string ByOrigin
    {
        get
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("\tpublic static {0} Get{1}ByOrgin(string parentName, string path)", name, name));
            builder.AppendLine("\t{");
            builder.AppendLine(string.Format("\t\treturn UIManager.GetComponentByOrgin<{0}>(parentName, path);", name));
            builder.AppendLine("\t}");
            return builder.ToString();
        }
    }

    public string Code
    {
        get
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("public class " + ClassName);
            builder.AppendLine("{");
            builder.AppendLine(ByName);
            builder.AppendLine(ByPath);
            builder.AppendLine(ByOrigin);

            foreach (Method method in Methods)
            {
                builder.AppendLine(method.Code(InterfaceType.ByName));
                builder.AppendLine(method.Code(InterfaceType.ByPath));
                builder.AppendLine(method.Code(InterfaceType.ByOrgin));
                builder.AppendLine();
                Filter(method.namespaces);
            }
            builder.AppendLine("}");

            StringBuilder namespaceBuilder = new StringBuilder();
            foreach (string namespaceName in namespaces)
            {
                namespaceBuilder.AppendLine("using " + namespaceName + ";");
            }

            namespaceBuilder.AppendLine();
            namespaceBuilder.AppendLine("//It is generated automatically. Do not modify it!");
            namespaceBuilder.AppendLine(builder.ToString());
            string code = namespaceBuilder.ToString();
            return code;
        }
    }

    public void Filter(List<string> vals)
    {
        foreach(string val in vals)
        {
            if (namespaces.Contains(val))
                continue;

            namespaces.Add(val);
        }
    }

    public string ClassName
    {
        get { return "UI" + name + "Helper"; }
    }
}

public class GenUIInterface
{
    public static string NAME = "UnityEngine.UI";
    public static string SYSTEM = "System";
    public static string GENERIC = "System.Collections.Generic";

    private static List<ClassInfo> classInfos = new List<ClassInfo>();
    private static string ROOT_PATH = Application.dataPath;
    private static string UI_CS_OUT_PATH_ROOT = ROOT_PATH + "/Scripts/UI/Gen/";

    //忽略函数导出列表
    private static List<string> ignoreMothodExports = new List<string>()
    {
        "get_rigidbody",
        "get_rigidbody2D",
        "get_camera",
        "get_light",
        "get_animation",
        "get_constantForce",
        "get_renderer",
        "get_audio",
        "get_networkView",
        "get_collider",
        "get_collider2D",
        "get_hingeJoint",
        "get_particleSystem",
        "get_GetTextAnchorPivot",
        "GetTextAnchorPivot",
        "get_defaultETC1GraphicMaterial",
        "get_defaultGraphicMaterial",
        "get_caretSelectPosition",
        "get_allSelectablesArray",
        "AllSelectablesNoAlloc",
        "get_allSelectables",
        "get_allSelectableCount",
        "get_eventAlphaThreshold",
        "set_eventAlphaThreshold",
    };

    //忽略类导出列表
    private static List<string> ignoreClassExports = new List<string>()
    {
    };

    [MenuItem("Tools/Gen UI Interface")]
    public static void Find()
    {
        if (Directory.Exists(UI_CS_OUT_PATH_ROOT))
            Directory.CreateDirectory(UI_CS_OUT_PATH_ROOT);

        var classs = GetClasss(NAME);
        foreach (var uiClass in classs)
        {
            ClassInfo classInfo = new ClassInfo();
            classInfo.name = uiClass.Key;

            if (ignoreClassExports.Contains(uiClass.Key))
                continue;

            MethodInfo[] methodInfos = uiClass.Value;
            foreach (var methodInfo in methodInfos)
            {
                bool obsolete = methodInfo.IsDefined(typeof(ObsoleteAttribute), false);
                if (obsolete)
                    continue;

                if (methodInfo.IsGenericMethod)
                    continue;

                if (ignoreMothodExports.Contains(methodInfo.Name))
                    continue;

                Method method = new Method();
                method.name = methodInfo.Name;
                method.thisName = uiClass.Key;
                method.returnType = methodInfo.ReturnType;
                ParameterInfo[] parameters = GetParams(methodInfo);

                foreach (var param in parameters)
                {
                    MethodParam methodParam = new MethodParam();
                    methodParam.name = param.Name;
                    methodParam.paramType = param.ParameterType;
                    methodParam.isOut = param.IsOut;
                    methodParam.isRef = param.ParameterType.IsByRef;
                    method.methodParams.Add(methodParam);
                }

                classInfo.Methods.Add(method);
            }

            classInfos.Add(classInfo);
        }

        GenCode();
        Reset();
    }

    private static void GenCode()
    {
        if (!Directory.Exists(UI_CS_OUT_PATH_ROOT))
            Directory.CreateDirectory(UI_CS_OUT_PATH_ROOT);

        foreach (ClassInfo classInfo in classInfos)
        {
            string filePath = string.Format( "{0}{1}.cs", UI_CS_OUT_PATH_ROOT, classInfo.ClassName);
            if (File.Exists(filePath))
                File.Delete(filePath);

            File.WriteAllText(filePath, classInfo.Code);
        }

        AssetDatabase.Refresh();
    }

    private static ParameterInfo[] GetParams(MethodInfo methodInfo)
    {
        ParameterInfo[] parameters = methodInfo.GetParameters();
        return parameters;
    }

    private static Dictionary<string, MethodInfo[]> GetClasss(string name)
    {
        Dictionary<string, MethodInfo[]> classs = new Dictionary<string, MethodInfo[]>();
        Assembly assembly = Assembly.Load(name);
        Type[] types = assembly.GetTypes();

        foreach (Type type in types)
        {
            if (!type.IsClass || type.IsNested)
                continue;

            if (!type.IsSubclassOf(typeof(Component)))
                continue;

            if (string.IsNullOrEmpty(type.Namespace) || !type.Namespace.Equals(name))
                continue;

            MethodInfo[] methods = type.GetMethods();

            string className = type.Name;
            if (classs.ContainsKey(className))
            {
                Debug.LogError(type.Name);
            }
            else
            {
                classs.Add(className, methods);
            }
        }

        return classs;
    }

    private static void Reset()
    {
        classInfos.Clear();
    }
}
