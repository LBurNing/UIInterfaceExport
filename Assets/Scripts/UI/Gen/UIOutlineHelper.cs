using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIOutlineHelper
{
	public static Outline GetOutlineByName(string name)
	{
		return UIManager.GetComponentByName<Outline>(name);
	}

	public static Outline GetOutlineByPath(string path)
	{
		return UIManager.GetComponentByPath<Outline>(path);
	}

	public static Outline GetOutlineByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<Outline>(parentName, path);
	}

	public static void ModifyMesh_ByName(UnityEngine.UI.VertexHelper vh, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.ModifyMesh(vh);
		}
	}

	public static void ModifyMesh_ByPath(UnityEngine.UI.VertexHelper vh, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.ModifyMesh(vh);
		}
	}

	public static void ModifyMesh_ByOrgin(UnityEngine.UI.VertexHelper vh, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.ModifyMesh(vh);
		}
	}


	public static UnityEngine.Color GetOutlineEffectColor_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.effectColor;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetOutlineEffectColor_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.effectColor;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetOutlineEffectColor_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.effectColor;
		}

		return default(UnityEngine.Color);
	}


	public static void SetOutlineEffectColor_ByName(UnityEngine.Color value, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.effectColor = value;
		}
	}

	public static void SetOutlineEffectColor_ByPath(UnityEngine.Color value, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.effectColor = value;
		}
	}

	public static void SetOutlineEffectColor_ByOrgin(UnityEngine.Color value, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.effectColor = value;
		}
	}


	public static UnityEngine.Vector2 GetOutlineEffectDistance_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.effectDistance;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetOutlineEffectDistance_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.effectDistance;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetOutlineEffectDistance_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.effectDistance;
		}

		return default(UnityEngine.Vector2);
	}


	public static void SetOutlineEffectDistance_ByName(UnityEngine.Vector2 value, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.effectDistance = value;
		}
	}

	public static void SetOutlineEffectDistance_ByPath(UnityEngine.Vector2 value, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.effectDistance = value;
		}
	}

	public static void SetOutlineEffectDistance_ByOrgin(UnityEngine.Vector2 value, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.effectDistance = value;
		}
	}


	public static System.Boolean GetOutlineUseGraphicAlpha_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.useGraphicAlpha;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetOutlineUseGraphicAlpha_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.useGraphicAlpha;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetOutlineUseGraphicAlpha_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.useGraphicAlpha;
		}

		return default(System.Boolean);
	}


	public static void SetOutlineUseGraphicAlpha_ByName(System.Boolean value, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.useGraphicAlpha = value;
		}
	}

	public static void SetOutlineUseGraphicAlpha_ByPath(System.Boolean value, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.useGraphicAlpha = value;
		}
	}

	public static void SetOutlineUseGraphicAlpha_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.useGraphicAlpha = value;
		}
	}


	public static void ModifyMesh_ByName(UnityEngine.Mesh mesh, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.ModifyMesh(mesh);
		}
	}

	public static void ModifyMesh_ByPath(UnityEngine.Mesh mesh, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.ModifyMesh(mesh);
		}
	}

	public static void ModifyMesh_ByOrgin(UnityEngine.Mesh mesh, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.ModifyMesh(mesh);
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.StopAllCoroutines();
		}
	}


	public static System.Boolean GetOutlineUseGUILayout_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetOutlineUseGUILayout_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetOutlineUseGUILayout_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetOutlineUseGUILayout_ByName(System.Boolean value, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.useGUILayout = value;
		}
	}

	public static void SetOutlineUseGUILayout_ByPath(System.Boolean value, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.useGUILayout = value;
		}
	}

	public static void SetOutlineUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.useGUILayout = value;
		}
	}


	public static System.Boolean GetOutlineRunInEditMode_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetOutlineRunInEditMode_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetOutlineRunInEditMode_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetOutlineRunInEditMode_ByName(System.Boolean value, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.runInEditMode = value;
		}
	}

	public static void SetOutlineRunInEditMode_ByPath(System.Boolean value, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.runInEditMode = value;
		}
	}

	public static void SetOutlineRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.runInEditMode = value;
		}
	}


	public static System.Boolean GetOutlineEnabled_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetOutlineEnabled_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetOutlineEnabled_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetOutlineEnabled_ByName(System.Boolean value, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.enabled = value;
		}
	}

	public static void SetOutlineEnabled_ByPath(System.Boolean value, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.enabled = value;
		}
	}

	public static void SetOutlineEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.enabled = value;
		}
	}


	public static System.Boolean GetOutlineIsActiveAndEnabled_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetOutlineIsActiveAndEnabled_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetOutlineIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetOutlineTransform_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetOutlineTransform_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetOutlineTransform_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetOutlineGameObject_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetOutlineGameObject_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetOutlineGameObject_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.GetComponents(type, results);
		}
	}


	public static System.String GetOutlineTag_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.tag;
		}

		return null;
	}

	public static System.String GetOutlineTag_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.tag;
		}

		return null;
	}

	public static System.String GetOutlineTag_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.tag;
		}

		return null;
	}


	public static void SetOutlineTag_ByName(System.String value, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.tag = value;
		}
	}

	public static void SetOutlineTag_ByPath(System.String value, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.tag = value;
		}
	}

	public static void SetOutlineTag_ByOrgin(System.String value, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetOutlineName_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.name;
		}

		return null;
	}

	public static System.String GetOutlineName_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.name;
		}

		return null;
	}

	public static System.String GetOutlineName_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.name;
		}

		return null;
	}


	public static void SetOutlineName_ByName(System.String value, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.name = value;
		}
	}

	public static void SetOutlineName_ByPath(System.String value, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.name = value;
		}
	}

	public static void SetOutlineName_ByOrgin(System.String value, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.name = value;
		}
	}


	public static UnityEngine.HideFlags GetOutlineHideFlags_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetOutlineHideFlags_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetOutlineHideFlags_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetOutlineHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			outline.hideFlags = value;
		}
	}

	public static void SetOutlineHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			outline.hideFlags = value;
		}
	}

	public static void SetOutlineHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			outline.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		Outline outline = GetOutlineByName(name);
		if(outline != null)
		{
			return outline.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		Outline outline = GetOutlineByPath(path);
		if(outline != null)
		{
			return outline.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		Outline outline = GetOutlineByOrgin(parentName, path);
		if(outline != null)
		{
			return outline.GetType();
		}

		return null;
	}


}

