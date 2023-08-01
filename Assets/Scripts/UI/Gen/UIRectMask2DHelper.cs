using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIRectMask2DHelper
{
	public static RectMask2D GetRectMask2DByName(string name)
	{
		return UIManager.GetComponentByName<RectMask2D>(name);
	}

	public static RectMask2D GetRectMask2DByPath(string path)
	{
		return UIManager.GetComponentByPath<RectMask2D>(path);
	}

	public static RectMask2D GetRectMask2DByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<RectMask2D>(parentName, path);
	}

	public static UnityEngine.Vector4 GetRectMask2DPadding_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.padding;
		}

		return default(UnityEngine.Vector4);
	}

	public static UnityEngine.Vector4 GetRectMask2DPadding_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.padding;
		}

		return default(UnityEngine.Vector4);
	}

	public static UnityEngine.Vector4 GetRectMask2DPadding_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.padding;
		}

		return default(UnityEngine.Vector4);
	}


	public static void SetRectMask2DPadding_ByName(UnityEngine.Vector4 value, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.padding = value;
		}
	}

	public static void SetRectMask2DPadding_ByPath(UnityEngine.Vector4 value, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.padding = value;
		}
	}

	public static void SetRectMask2DPadding_ByOrgin(UnityEngine.Vector4 value, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.padding = value;
		}
	}


	public static UnityEngine.Vector2Int GetRectMask2DSoftness_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.softness;
		}

		return default(UnityEngine.Vector2Int);
	}

	public static UnityEngine.Vector2Int GetRectMask2DSoftness_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.softness;
		}

		return default(UnityEngine.Vector2Int);
	}

	public static UnityEngine.Vector2Int GetRectMask2DSoftness_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.softness;
		}

		return default(UnityEngine.Vector2Int);
	}


	public static void SetRectMask2DSoftness_ByName(UnityEngine.Vector2Int value, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.softness = value;
		}
	}

	public static void SetRectMask2DSoftness_ByPath(UnityEngine.Vector2Int value, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.softness = value;
		}
	}

	public static void SetRectMask2DSoftness_ByOrgin(UnityEngine.Vector2Int value, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.softness = value;
		}
	}


	public static UnityEngine.Rect GetRectMask2DCanvasRect_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.canvasRect;
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetRectMask2DCanvasRect_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.canvasRect;
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetRectMask2DCanvasRect_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.canvasRect;
		}

		return default(UnityEngine.Rect);
	}


	public static UnityEngine.RectTransform GetRectMask2DRectTransform_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetRectMask2DRectTransform_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetRectMask2DRectTransform_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.rectTransform;
		}

		return null;
	}


	public static System.Boolean IsRaycastLocationValid_ByName(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.IsRaycastLocationValid(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsRaycastLocationValid_ByPath(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.IsRaycastLocationValid(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsRaycastLocationValid_ByOrgin(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.IsRaycastLocationValid(sp, eventCamera);
		}

		return default(System.Boolean);
	}


	public static void PerformClipping_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.PerformClipping();
		}
	}

	public static void PerformClipping_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.PerformClipping();
		}
	}

	public static void PerformClipping_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.PerformClipping();
		}
	}


	public static void UpdateClipSoftness_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.UpdateClipSoftness();
		}
	}

	public static void UpdateClipSoftness_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.UpdateClipSoftness();
		}
	}

	public static void UpdateClipSoftness_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.UpdateClipSoftness();
		}
	}


	public static void AddClippable_ByName(UnityEngine.UI.IClippable clippable, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.AddClippable(clippable);
		}
	}

	public static void AddClippable_ByPath(UnityEngine.UI.IClippable clippable, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.AddClippable(clippable);
		}
	}

	public static void AddClippable_ByOrgin(UnityEngine.UI.IClippable clippable, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.AddClippable(clippable);
		}
	}


	public static void RemoveClippable_ByName(UnityEngine.UI.IClippable clippable, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.RemoveClippable(clippable);
		}
	}

	public static void RemoveClippable_ByPath(UnityEngine.UI.IClippable clippable, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.RemoveClippable(clippable);
		}
	}

	public static void RemoveClippable_ByOrgin(UnityEngine.UI.IClippable clippable, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.RemoveClippable(clippable);
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.StopAllCoroutines();
		}
	}


	public static System.Boolean GetRectMask2DUseGUILayout_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRectMask2DUseGUILayout_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRectMask2DUseGUILayout_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetRectMask2DUseGUILayout_ByName(System.Boolean value, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.useGUILayout = value;
		}
	}

	public static void SetRectMask2DUseGUILayout_ByPath(System.Boolean value, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.useGUILayout = value;
		}
	}

	public static void SetRectMask2DUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.useGUILayout = value;
		}
	}


	public static System.Boolean GetRectMask2DRunInEditMode_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRectMask2DRunInEditMode_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRectMask2DRunInEditMode_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetRectMask2DRunInEditMode_ByName(System.Boolean value, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.runInEditMode = value;
		}
	}

	public static void SetRectMask2DRunInEditMode_ByPath(System.Boolean value, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.runInEditMode = value;
		}
	}

	public static void SetRectMask2DRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.runInEditMode = value;
		}
	}


	public static System.Boolean GetRectMask2DEnabled_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRectMask2DEnabled_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRectMask2DEnabled_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetRectMask2DEnabled_ByName(System.Boolean value, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.enabled = value;
		}
	}

	public static void SetRectMask2DEnabled_ByPath(System.Boolean value, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.enabled = value;
		}
	}

	public static void SetRectMask2DEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.enabled = value;
		}
	}


	public static System.Boolean GetRectMask2DIsActiveAndEnabled_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRectMask2DIsActiveAndEnabled_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRectMask2DIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetRectMask2DTransform_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetRectMask2DTransform_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetRectMask2DTransform_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetRectMask2DGameObject_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetRectMask2DGameObject_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetRectMask2DGameObject_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.GetComponents(type, results);
		}
	}


	public static System.String GetRectMask2DTag_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.tag;
		}

		return null;
	}

	public static System.String GetRectMask2DTag_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.tag;
		}

		return null;
	}

	public static System.String GetRectMask2DTag_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.tag;
		}

		return null;
	}


	public static void SetRectMask2DTag_ByName(System.String value, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.tag = value;
		}
	}

	public static void SetRectMask2DTag_ByPath(System.String value, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.tag = value;
		}
	}

	public static void SetRectMask2DTag_ByOrgin(System.String value, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetRectMask2DName_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.name;
		}

		return null;
	}

	public static System.String GetRectMask2DName_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.name;
		}

		return null;
	}

	public static System.String GetRectMask2DName_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.name;
		}

		return null;
	}


	public static void SetRectMask2DName_ByName(System.String value, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.name = value;
		}
	}

	public static void SetRectMask2DName_ByPath(System.String value, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.name = value;
		}
	}

	public static void SetRectMask2DName_ByOrgin(System.String value, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.name = value;
		}
	}


	public static UnityEngine.HideFlags GetRectMask2DHideFlags_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetRectMask2DHideFlags_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetRectMask2DHideFlags_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetRectMask2DHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			rectmask2d.hideFlags = value;
		}
	}

	public static void SetRectMask2DHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			rectmask2d.hideFlags = value;
		}
	}

	public static void SetRectMask2DHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			rectmask2d.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		RectMask2D rectmask2d = GetRectMask2DByName(name);
		if(rectmask2d != null)
		{
			return rectmask2d.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByPath(path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		RectMask2D rectmask2d = GetRectMask2DByOrgin(parentName, path);
		if(rectmask2d != null)
		{
			return rectmask2d.GetType();
		}

		return null;
	}


}

