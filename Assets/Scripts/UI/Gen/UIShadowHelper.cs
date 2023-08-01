using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIShadowHelper
{
	public static Shadow GetShadowByName(string name)
	{
		return UIManager.GetComponentByName<Shadow>(name);
	}

	public static Shadow GetShadowByPath(string path)
	{
		return UIManager.GetComponentByPath<Shadow>(path);
	}

	public static Shadow GetShadowByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<Shadow>(parentName, path);
	}

	public static UnityEngine.Color GetShadowEffectColor_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.effectColor;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetShadowEffectColor_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.effectColor;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetShadowEffectColor_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.effectColor;
		}

		return default(UnityEngine.Color);
	}


	public static void SetShadowEffectColor_ByName(UnityEngine.Color value, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.effectColor = value;
		}
	}

	public static void SetShadowEffectColor_ByPath(UnityEngine.Color value, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.effectColor = value;
		}
	}

	public static void SetShadowEffectColor_ByOrgin(UnityEngine.Color value, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.effectColor = value;
		}
	}


	public static UnityEngine.Vector2 GetShadowEffectDistance_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.effectDistance;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetShadowEffectDistance_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.effectDistance;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetShadowEffectDistance_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.effectDistance;
		}

		return default(UnityEngine.Vector2);
	}


	public static void SetShadowEffectDistance_ByName(UnityEngine.Vector2 value, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.effectDistance = value;
		}
	}

	public static void SetShadowEffectDistance_ByPath(UnityEngine.Vector2 value, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.effectDistance = value;
		}
	}

	public static void SetShadowEffectDistance_ByOrgin(UnityEngine.Vector2 value, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.effectDistance = value;
		}
	}


	public static System.Boolean GetShadowUseGraphicAlpha_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.useGraphicAlpha;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetShadowUseGraphicAlpha_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.useGraphicAlpha;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetShadowUseGraphicAlpha_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.useGraphicAlpha;
		}

		return default(System.Boolean);
	}


	public static void SetShadowUseGraphicAlpha_ByName(System.Boolean value, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.useGraphicAlpha = value;
		}
	}

	public static void SetShadowUseGraphicAlpha_ByPath(System.Boolean value, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.useGraphicAlpha = value;
		}
	}

	public static void SetShadowUseGraphicAlpha_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.useGraphicAlpha = value;
		}
	}


	public static void ModifyMesh_ByName(UnityEngine.UI.VertexHelper vh, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.ModifyMesh(vh);
		}
	}

	public static void ModifyMesh_ByPath(UnityEngine.UI.VertexHelper vh, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.ModifyMesh(vh);
		}
	}

	public static void ModifyMesh_ByOrgin(UnityEngine.UI.VertexHelper vh, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.ModifyMesh(vh);
		}
	}


	public static void ModifyMesh_ByName(UnityEngine.Mesh mesh, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.ModifyMesh(mesh);
		}
	}

	public static void ModifyMesh_ByPath(UnityEngine.Mesh mesh, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.ModifyMesh(mesh);
		}
	}

	public static void ModifyMesh_ByOrgin(UnityEngine.Mesh mesh, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.ModifyMesh(mesh);
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.StopAllCoroutines();
		}
	}


	public static System.Boolean GetShadowUseGUILayout_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetShadowUseGUILayout_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetShadowUseGUILayout_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetShadowUseGUILayout_ByName(System.Boolean value, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.useGUILayout = value;
		}
	}

	public static void SetShadowUseGUILayout_ByPath(System.Boolean value, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.useGUILayout = value;
		}
	}

	public static void SetShadowUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.useGUILayout = value;
		}
	}


	public static System.Boolean GetShadowRunInEditMode_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetShadowRunInEditMode_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetShadowRunInEditMode_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetShadowRunInEditMode_ByName(System.Boolean value, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.runInEditMode = value;
		}
	}

	public static void SetShadowRunInEditMode_ByPath(System.Boolean value, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.runInEditMode = value;
		}
	}

	public static void SetShadowRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.runInEditMode = value;
		}
	}


	public static System.Boolean GetShadowEnabled_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetShadowEnabled_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetShadowEnabled_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetShadowEnabled_ByName(System.Boolean value, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.enabled = value;
		}
	}

	public static void SetShadowEnabled_ByPath(System.Boolean value, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.enabled = value;
		}
	}

	public static void SetShadowEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.enabled = value;
		}
	}


	public static System.Boolean GetShadowIsActiveAndEnabled_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetShadowIsActiveAndEnabled_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetShadowIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetShadowTransform_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetShadowTransform_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetShadowTransform_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetShadowGameObject_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetShadowGameObject_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetShadowGameObject_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.GetComponents(type, results);
		}
	}


	public static System.String GetShadowTag_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.tag;
		}

		return null;
	}

	public static System.String GetShadowTag_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.tag;
		}

		return null;
	}

	public static System.String GetShadowTag_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.tag;
		}

		return null;
	}


	public static void SetShadowTag_ByName(System.String value, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.tag = value;
		}
	}

	public static void SetShadowTag_ByPath(System.String value, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.tag = value;
		}
	}

	public static void SetShadowTag_ByOrgin(System.String value, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetShadowName_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.name;
		}

		return null;
	}

	public static System.String GetShadowName_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.name;
		}

		return null;
	}

	public static System.String GetShadowName_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.name;
		}

		return null;
	}


	public static void SetShadowName_ByName(System.String value, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.name = value;
		}
	}

	public static void SetShadowName_ByPath(System.String value, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.name = value;
		}
	}

	public static void SetShadowName_ByOrgin(System.String value, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.name = value;
		}
	}


	public static UnityEngine.HideFlags GetShadowHideFlags_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetShadowHideFlags_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetShadowHideFlags_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetShadowHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			shadow.hideFlags = value;
		}
	}

	public static void SetShadowHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			shadow.hideFlags = value;
		}
	}

	public static void SetShadowHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			shadow.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		Shadow shadow = GetShadowByName(name);
		if(shadow != null)
		{
			return shadow.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		Shadow shadow = GetShadowByPath(path);
		if(shadow != null)
		{
			return shadow.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		Shadow shadow = GetShadowByOrgin(parentName, path);
		if(shadow != null)
		{
			return shadow.GetType();
		}

		return null;
	}


}

