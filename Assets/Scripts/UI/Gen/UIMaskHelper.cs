using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIMaskHelper
{
	public static Mask GetMaskByName(string name)
	{
		return UIManager.GetComponentByName<Mask>(name);
	}

	public static Mask GetMaskByPath(string path)
	{
		return UIManager.GetComponentByPath<Mask>(path);
	}

	public static Mask GetMaskByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<Mask>(parentName, path);
	}

	public static UnityEngine.RectTransform GetMaskRectTransform_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetMaskRectTransform_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetMaskRectTransform_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.rectTransform;
		}

		return null;
	}


	public static System.Boolean GetMaskShowMaskGraphic_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.showMaskGraphic;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskShowMaskGraphic_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.showMaskGraphic;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskShowMaskGraphic_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.showMaskGraphic;
		}

		return default(System.Boolean);
	}


	public static void SetMaskShowMaskGraphic_ByName(System.Boolean value, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.showMaskGraphic = value;
		}
	}

	public static void SetMaskShowMaskGraphic_ByPath(System.Boolean value, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.showMaskGraphic = value;
		}
	}

	public static void SetMaskShowMaskGraphic_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.showMaskGraphic = value;
		}
	}


	public static UnityEngine.UI.Graphic GetMaskGraphic_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.graphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetMaskGraphic_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.graphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetMaskGraphic_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.graphic;
		}

		return null;
	}


	public static System.Boolean MaskEnabled_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.MaskEnabled();
		}

		return default(System.Boolean);
	}

	public static System.Boolean MaskEnabled_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.MaskEnabled();
		}

		return default(System.Boolean);
	}

	public static System.Boolean MaskEnabled_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.MaskEnabled();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsRaycastLocationValid_ByName(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.IsRaycastLocationValid(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsRaycastLocationValid_ByPath(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.IsRaycastLocationValid(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsRaycastLocationValid_ByOrgin(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.IsRaycastLocationValid(sp, eventCamera);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Material GetModifiedMaterial_ByName(UnityEngine.Material baseMaterial, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}

	public static UnityEngine.Material GetModifiedMaterial_ByPath(UnityEngine.Material baseMaterial, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}

	public static UnityEngine.Material GetModifiedMaterial_ByOrgin(UnityEngine.Material baseMaterial, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.StopAllCoroutines();
		}
	}


	public static System.Boolean GetMaskUseGUILayout_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskUseGUILayout_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskUseGUILayout_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetMaskUseGUILayout_ByName(System.Boolean value, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.useGUILayout = value;
		}
	}

	public static void SetMaskUseGUILayout_ByPath(System.Boolean value, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.useGUILayout = value;
		}
	}

	public static void SetMaskUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.useGUILayout = value;
		}
	}


	public static System.Boolean GetMaskRunInEditMode_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskRunInEditMode_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskRunInEditMode_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetMaskRunInEditMode_ByName(System.Boolean value, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.runInEditMode = value;
		}
	}

	public static void SetMaskRunInEditMode_ByPath(System.Boolean value, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.runInEditMode = value;
		}
	}

	public static void SetMaskRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.runInEditMode = value;
		}
	}


	public static System.Boolean GetMaskEnabled_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskEnabled_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskEnabled_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetMaskEnabled_ByName(System.Boolean value, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.enabled = value;
		}
	}

	public static void SetMaskEnabled_ByPath(System.Boolean value, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.enabled = value;
		}
	}

	public static void SetMaskEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.enabled = value;
		}
	}


	public static System.Boolean GetMaskIsActiveAndEnabled_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskIsActiveAndEnabled_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetMaskTransform_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetMaskTransform_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetMaskTransform_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetMaskGameObject_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetMaskGameObject_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetMaskGameObject_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.GetComponents(type, results);
		}
	}


	public static System.String GetMaskTag_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.tag;
		}

		return null;
	}

	public static System.String GetMaskTag_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.tag;
		}

		return null;
	}

	public static System.String GetMaskTag_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.tag;
		}

		return null;
	}


	public static void SetMaskTag_ByName(System.String value, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.tag = value;
		}
	}

	public static void SetMaskTag_ByPath(System.String value, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.tag = value;
		}
	}

	public static void SetMaskTag_ByOrgin(System.String value, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetMaskName_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.name;
		}

		return null;
	}

	public static System.String GetMaskName_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.name;
		}

		return null;
	}

	public static System.String GetMaskName_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.name;
		}

		return null;
	}


	public static void SetMaskName_ByName(System.String value, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.name = value;
		}
	}

	public static void SetMaskName_ByPath(System.String value, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.name = value;
		}
	}

	public static void SetMaskName_ByOrgin(System.String value, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.name = value;
		}
	}


	public static UnityEngine.HideFlags GetMaskHideFlags_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetMaskHideFlags_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetMaskHideFlags_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetMaskHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			mask.hideFlags = value;
		}
	}

	public static void SetMaskHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			mask.hideFlags = value;
		}
	}

	public static void SetMaskHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			mask.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		Mask mask = GetMaskByName(name);
		if(mask != null)
		{
			return mask.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		Mask mask = GetMaskByPath(path);
		if(mask != null)
		{
			return mask.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		Mask mask = GetMaskByOrgin(parentName, path);
		if(mask != null)
		{
			return mask.GetType();
		}

		return null;
	}


}

