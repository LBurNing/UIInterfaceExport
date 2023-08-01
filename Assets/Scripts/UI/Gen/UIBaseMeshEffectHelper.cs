using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIBaseMeshEffectHelper
{
	public static BaseMeshEffect GetBaseMeshEffectByName(string name)
	{
		return UIManager.GetComponentByName<BaseMeshEffect>(name);
	}

	public static BaseMeshEffect GetBaseMeshEffectByPath(string path)
	{
		return UIManager.GetComponentByPath<BaseMeshEffect>(path);
	}

	public static BaseMeshEffect GetBaseMeshEffectByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<BaseMeshEffect>(parentName, path);
	}

	public static void ModifyMesh_ByName(UnityEngine.Mesh mesh, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.ModifyMesh(mesh);
		}
	}

	public static void ModifyMesh_ByPath(UnityEngine.Mesh mesh, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.ModifyMesh(mesh);
		}
	}

	public static void ModifyMesh_ByOrgin(UnityEngine.Mesh mesh, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.ModifyMesh(mesh);
		}
	}


	public static void ModifyMesh_ByName(UnityEngine.UI.VertexHelper vh, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.ModifyMesh(vh);
		}
	}

	public static void ModifyMesh_ByPath(UnityEngine.UI.VertexHelper vh, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.ModifyMesh(vh);
		}
	}

	public static void ModifyMesh_ByOrgin(UnityEngine.UI.VertexHelper vh, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.ModifyMesh(vh);
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.StopAllCoroutines();
		}
	}


	public static System.Boolean GetBaseMeshEffectUseGUILayout_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetBaseMeshEffectUseGUILayout_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetBaseMeshEffectUseGUILayout_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetBaseMeshEffectUseGUILayout_ByName(System.Boolean value, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.useGUILayout = value;
		}
	}

	public static void SetBaseMeshEffectUseGUILayout_ByPath(System.Boolean value, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.useGUILayout = value;
		}
	}

	public static void SetBaseMeshEffectUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.useGUILayout = value;
		}
	}


	public static System.Boolean GetBaseMeshEffectRunInEditMode_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetBaseMeshEffectRunInEditMode_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetBaseMeshEffectRunInEditMode_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetBaseMeshEffectRunInEditMode_ByName(System.Boolean value, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.runInEditMode = value;
		}
	}

	public static void SetBaseMeshEffectRunInEditMode_ByPath(System.Boolean value, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.runInEditMode = value;
		}
	}

	public static void SetBaseMeshEffectRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.runInEditMode = value;
		}
	}


	public static System.Boolean GetBaseMeshEffectEnabled_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetBaseMeshEffectEnabled_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetBaseMeshEffectEnabled_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetBaseMeshEffectEnabled_ByName(System.Boolean value, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.enabled = value;
		}
	}

	public static void SetBaseMeshEffectEnabled_ByPath(System.Boolean value, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.enabled = value;
		}
	}

	public static void SetBaseMeshEffectEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.enabled = value;
		}
	}


	public static System.Boolean GetBaseMeshEffectIsActiveAndEnabled_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetBaseMeshEffectIsActiveAndEnabled_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetBaseMeshEffectIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetBaseMeshEffectTransform_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetBaseMeshEffectTransform_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetBaseMeshEffectTransform_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetBaseMeshEffectGameObject_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetBaseMeshEffectGameObject_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetBaseMeshEffectGameObject_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.GetComponents(type, results);
		}
	}


	public static System.String GetBaseMeshEffectTag_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.tag;
		}

		return null;
	}

	public static System.String GetBaseMeshEffectTag_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.tag;
		}

		return null;
	}

	public static System.String GetBaseMeshEffectTag_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.tag;
		}

		return null;
	}


	public static void SetBaseMeshEffectTag_ByName(System.String value, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.tag = value;
		}
	}

	public static void SetBaseMeshEffectTag_ByPath(System.String value, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.tag = value;
		}
	}

	public static void SetBaseMeshEffectTag_ByOrgin(System.String value, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetBaseMeshEffectName_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.name;
		}

		return null;
	}

	public static System.String GetBaseMeshEffectName_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.name;
		}

		return null;
	}

	public static System.String GetBaseMeshEffectName_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.name;
		}

		return null;
	}


	public static void SetBaseMeshEffectName_ByName(System.String value, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.name = value;
		}
	}

	public static void SetBaseMeshEffectName_ByPath(System.String value, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.name = value;
		}
	}

	public static void SetBaseMeshEffectName_ByOrgin(System.String value, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.name = value;
		}
	}


	public static UnityEngine.HideFlags GetBaseMeshEffectHideFlags_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetBaseMeshEffectHideFlags_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetBaseMeshEffectHideFlags_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetBaseMeshEffectHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			basemesheffect.hideFlags = value;
		}
	}

	public static void SetBaseMeshEffectHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			basemesheffect.hideFlags = value;
		}
	}

	public static void SetBaseMeshEffectHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			basemesheffect.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByName(name);
		if(basemesheffect != null)
		{
			return basemesheffect.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByPath(path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		BaseMeshEffect basemesheffect = GetBaseMeshEffectByOrgin(parentName, path);
		if(basemesheffect != null)
		{
			return basemesheffect.GetType();
		}

		return null;
	}


}

