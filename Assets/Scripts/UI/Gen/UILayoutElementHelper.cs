using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UILayoutElementHelper
{
	public static LayoutElement GetLayoutElementByName(string name)
	{
		return UIManager.GetComponentByName<LayoutElement>(name);
	}

	public static LayoutElement GetLayoutElementByPath(string path)
	{
		return UIManager.GetComponentByPath<LayoutElement>(path);
	}

	public static LayoutElement GetLayoutElementByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<LayoutElement>(parentName, path);
	}

	public static System.Boolean GetLayoutElementIgnoreLayout_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.ignoreLayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutElementIgnoreLayout_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.ignoreLayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutElementIgnoreLayout_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.ignoreLayout;
		}

		return default(System.Boolean);
	}


	public static void SetLayoutElementIgnoreLayout_ByName(System.Boolean value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.ignoreLayout = value;
		}
	}

	public static void SetLayoutElementIgnoreLayout_ByPath(System.Boolean value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.ignoreLayout = value;
		}
	}

	public static void SetLayoutElementIgnoreLayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.ignoreLayout = value;
		}
	}


	public static void CalculateLayoutInputHorizontal_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.CalculateLayoutInputHorizontal();
		}
	}


	public static void CalculateLayoutInputVertical_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.CalculateLayoutInputVertical();
		}
	}


	public static System.Single GetLayoutElementMinWidth_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutElementMinWidth_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutElementMinWidth_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.minWidth;
		}

		return default(System.Single);
	}


	public static void SetLayoutElementMinWidth_ByName(System.Single value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.minWidth = value;
		}
	}

	public static void SetLayoutElementMinWidth_ByPath(System.Single value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.minWidth = value;
		}
	}

	public static void SetLayoutElementMinWidth_ByOrgin(System.Single value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.minWidth = value;
		}
	}


	public static System.Single GetLayoutElementMinHeight_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutElementMinHeight_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutElementMinHeight_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.minHeight;
		}

		return default(System.Single);
	}


	public static void SetLayoutElementMinHeight_ByName(System.Single value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.minHeight = value;
		}
	}

	public static void SetLayoutElementMinHeight_ByPath(System.Single value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.minHeight = value;
		}
	}

	public static void SetLayoutElementMinHeight_ByOrgin(System.Single value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.minHeight = value;
		}
	}


	public static System.Single GetLayoutElementPreferredWidth_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutElementPreferredWidth_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutElementPreferredWidth_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.preferredWidth;
		}

		return default(System.Single);
	}


	public static void SetLayoutElementPreferredWidth_ByName(System.Single value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.preferredWidth = value;
		}
	}

	public static void SetLayoutElementPreferredWidth_ByPath(System.Single value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.preferredWidth = value;
		}
	}

	public static void SetLayoutElementPreferredWidth_ByOrgin(System.Single value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.preferredWidth = value;
		}
	}


	public static System.Single GetLayoutElementPreferredHeight_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutElementPreferredHeight_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutElementPreferredHeight_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.preferredHeight;
		}

		return default(System.Single);
	}


	public static void SetLayoutElementPreferredHeight_ByName(System.Single value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.preferredHeight = value;
		}
	}

	public static void SetLayoutElementPreferredHeight_ByPath(System.Single value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.preferredHeight = value;
		}
	}

	public static void SetLayoutElementPreferredHeight_ByOrgin(System.Single value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.preferredHeight = value;
		}
	}


	public static System.Single GetLayoutElementFlexibleWidth_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutElementFlexibleWidth_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutElementFlexibleWidth_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.flexibleWidth;
		}

		return default(System.Single);
	}


	public static void SetLayoutElementFlexibleWidth_ByName(System.Single value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.flexibleWidth = value;
		}
	}

	public static void SetLayoutElementFlexibleWidth_ByPath(System.Single value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.flexibleWidth = value;
		}
	}

	public static void SetLayoutElementFlexibleWidth_ByOrgin(System.Single value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.flexibleWidth = value;
		}
	}


	public static System.Single GetLayoutElementFlexibleHeight_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutElementFlexibleHeight_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutElementFlexibleHeight_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.flexibleHeight;
		}

		return default(System.Single);
	}


	public static void SetLayoutElementFlexibleHeight_ByName(System.Single value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.flexibleHeight = value;
		}
	}

	public static void SetLayoutElementFlexibleHeight_ByPath(System.Single value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.flexibleHeight = value;
		}
	}

	public static void SetLayoutElementFlexibleHeight_ByOrgin(System.Single value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.flexibleHeight = value;
		}
	}


	public static System.Int32 GetLayoutElementLayoutPriority_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetLayoutElementLayoutPriority_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetLayoutElementLayoutPriority_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.layoutPriority;
		}

		return default(System.Int32);
	}


	public static void SetLayoutElementLayoutPriority_ByName(System.Int32 value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.layoutPriority = value;
		}
	}

	public static void SetLayoutElementLayoutPriority_ByPath(System.Int32 value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.layoutPriority = value;
		}
	}

	public static void SetLayoutElementLayoutPriority_ByOrgin(System.Int32 value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.layoutPriority = value;
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.StopAllCoroutines();
		}
	}


	public static System.Boolean GetLayoutElementUseGUILayout_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutElementUseGUILayout_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutElementUseGUILayout_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetLayoutElementUseGUILayout_ByName(System.Boolean value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.useGUILayout = value;
		}
	}

	public static void SetLayoutElementUseGUILayout_ByPath(System.Boolean value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.useGUILayout = value;
		}
	}

	public static void SetLayoutElementUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.useGUILayout = value;
		}
	}


	public static System.Boolean GetLayoutElementRunInEditMode_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutElementRunInEditMode_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutElementRunInEditMode_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetLayoutElementRunInEditMode_ByName(System.Boolean value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.runInEditMode = value;
		}
	}

	public static void SetLayoutElementRunInEditMode_ByPath(System.Boolean value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.runInEditMode = value;
		}
	}

	public static void SetLayoutElementRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.runInEditMode = value;
		}
	}


	public static System.Boolean GetLayoutElementEnabled_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutElementEnabled_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutElementEnabled_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetLayoutElementEnabled_ByName(System.Boolean value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.enabled = value;
		}
	}

	public static void SetLayoutElementEnabled_ByPath(System.Boolean value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.enabled = value;
		}
	}

	public static void SetLayoutElementEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.enabled = value;
		}
	}


	public static System.Boolean GetLayoutElementIsActiveAndEnabled_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutElementIsActiveAndEnabled_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutElementIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetLayoutElementTransform_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetLayoutElementTransform_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetLayoutElementTransform_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetLayoutElementGameObject_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetLayoutElementGameObject_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetLayoutElementGameObject_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.GetComponents(type, results);
		}
	}


	public static System.String GetLayoutElementTag_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.tag;
		}

		return null;
	}

	public static System.String GetLayoutElementTag_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.tag;
		}

		return null;
	}

	public static System.String GetLayoutElementTag_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.tag;
		}

		return null;
	}


	public static void SetLayoutElementTag_ByName(System.String value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.tag = value;
		}
	}

	public static void SetLayoutElementTag_ByPath(System.String value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.tag = value;
		}
	}

	public static void SetLayoutElementTag_ByOrgin(System.String value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetLayoutElementName_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.name;
		}

		return null;
	}

	public static System.String GetLayoutElementName_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.name;
		}

		return null;
	}

	public static System.String GetLayoutElementName_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.name;
		}

		return null;
	}


	public static void SetLayoutElementName_ByName(System.String value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.name = value;
		}
	}

	public static void SetLayoutElementName_ByPath(System.String value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.name = value;
		}
	}

	public static void SetLayoutElementName_ByOrgin(System.String value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.name = value;
		}
	}


	public static UnityEngine.HideFlags GetLayoutElementHideFlags_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetLayoutElementHideFlags_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetLayoutElementHideFlags_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetLayoutElementHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			layoutelement.hideFlags = value;
		}
	}

	public static void SetLayoutElementHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			layoutelement.hideFlags = value;
		}
	}

	public static void SetLayoutElementHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			layoutelement.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		LayoutElement layoutelement = GetLayoutElementByName(name);
		if(layoutelement != null)
		{
			return layoutelement.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		LayoutElement layoutelement = GetLayoutElementByPath(path);
		if(layoutelement != null)
		{
			return layoutelement.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		LayoutElement layoutelement = GetLayoutElementByOrgin(parentName, path);
		if(layoutelement != null)
		{
			return layoutelement.GetType();
		}

		return null;
	}


}

