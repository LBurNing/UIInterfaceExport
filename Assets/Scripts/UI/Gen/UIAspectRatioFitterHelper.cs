using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIAspectRatioFitterHelper
{
	public static AspectRatioFitter GetAspectRatioFitterByName(string name)
	{
		return UIManager.GetComponentByName<AspectRatioFitter>(name);
	}

	public static AspectRatioFitter GetAspectRatioFitterByPath(string path)
	{
		return UIManager.GetComponentByPath<AspectRatioFitter>(path);
	}

	public static AspectRatioFitter GetAspectRatioFitterByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<AspectRatioFitter>(parentName, path);
	}

	public static UnityEngine.UI.AspectRatioFitter.AspectMode GetAspectRatioFitterAspectMode_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.aspectMode;
		}

		return default(UnityEngine.UI.AspectRatioFitter.AspectMode);
	}

	public static UnityEngine.UI.AspectRatioFitter.AspectMode GetAspectRatioFitterAspectMode_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.aspectMode;
		}

		return default(UnityEngine.UI.AspectRatioFitter.AspectMode);
	}

	public static UnityEngine.UI.AspectRatioFitter.AspectMode GetAspectRatioFitterAspectMode_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.aspectMode;
		}

		return default(UnityEngine.UI.AspectRatioFitter.AspectMode);
	}


	public static void SetAspectRatioFitterAspectMode_ByName(UnityEngine.UI.AspectRatioFitter.AspectMode value, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.aspectMode = value;
		}
	}

	public static void SetAspectRatioFitterAspectMode_ByPath(UnityEngine.UI.AspectRatioFitter.AspectMode value, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.aspectMode = value;
		}
	}

	public static void SetAspectRatioFitterAspectMode_ByOrgin(UnityEngine.UI.AspectRatioFitter.AspectMode value, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.aspectMode = value;
		}
	}


	public static System.Single GetAspectRatioFitterAspectRatio_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.aspectRatio;
		}

		return default(System.Single);
	}

	public static System.Single GetAspectRatioFitterAspectRatio_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.aspectRatio;
		}

		return default(System.Single);
	}

	public static System.Single GetAspectRatioFitterAspectRatio_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.aspectRatio;
		}

		return default(System.Single);
	}


	public static void SetAspectRatioFitterAspectRatio_ByName(System.Single value, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.aspectRatio = value;
		}
	}

	public static void SetAspectRatioFitterAspectRatio_ByPath(System.Single value, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.aspectRatio = value;
		}
	}

	public static void SetAspectRatioFitterAspectRatio_ByOrgin(System.Single value, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.aspectRatio = value;
		}
	}


	public static void SetLayoutHorizontal_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SetLayoutHorizontal();
		}
	}


	public static void SetLayoutVertical_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SetLayoutVertical();
		}
	}


	public static System.Boolean IsComponentValidOnObject_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsComponentValidOnObject();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsComponentValidOnObject_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsComponentValidOnObject();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsComponentValidOnObject_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsComponentValidOnObject();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsAspectModeValid_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsAspectModeValid();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsAspectModeValid_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsAspectModeValid();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsAspectModeValid_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsAspectModeValid();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.StopAllCoroutines();
		}
	}


	public static System.Boolean GetAspectRatioFitterUseGUILayout_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetAspectRatioFitterUseGUILayout_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetAspectRatioFitterUseGUILayout_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetAspectRatioFitterUseGUILayout_ByName(System.Boolean value, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.useGUILayout = value;
		}
	}

	public static void SetAspectRatioFitterUseGUILayout_ByPath(System.Boolean value, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.useGUILayout = value;
		}
	}

	public static void SetAspectRatioFitterUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.useGUILayout = value;
		}
	}


	public static System.Boolean GetAspectRatioFitterRunInEditMode_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetAspectRatioFitterRunInEditMode_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetAspectRatioFitterRunInEditMode_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetAspectRatioFitterRunInEditMode_ByName(System.Boolean value, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.runInEditMode = value;
		}
	}

	public static void SetAspectRatioFitterRunInEditMode_ByPath(System.Boolean value, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.runInEditMode = value;
		}
	}

	public static void SetAspectRatioFitterRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.runInEditMode = value;
		}
	}


	public static System.Boolean GetAspectRatioFitterEnabled_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetAspectRatioFitterEnabled_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetAspectRatioFitterEnabled_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetAspectRatioFitterEnabled_ByName(System.Boolean value, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.enabled = value;
		}
	}

	public static void SetAspectRatioFitterEnabled_ByPath(System.Boolean value, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.enabled = value;
		}
	}

	public static void SetAspectRatioFitterEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.enabled = value;
		}
	}


	public static System.Boolean GetAspectRatioFitterIsActiveAndEnabled_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetAspectRatioFitterIsActiveAndEnabled_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetAspectRatioFitterIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetAspectRatioFitterTransform_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetAspectRatioFitterTransform_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetAspectRatioFitterTransform_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetAspectRatioFitterGameObject_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetAspectRatioFitterGameObject_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetAspectRatioFitterGameObject_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.GetComponents(type, results);
		}
	}


	public static System.String GetAspectRatioFitterTag_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.tag;
		}

		return null;
	}

	public static System.String GetAspectRatioFitterTag_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.tag;
		}

		return null;
	}

	public static System.String GetAspectRatioFitterTag_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.tag;
		}

		return null;
	}


	public static void SetAspectRatioFitterTag_ByName(System.String value, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.tag = value;
		}
	}

	public static void SetAspectRatioFitterTag_ByPath(System.String value, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.tag = value;
		}
	}

	public static void SetAspectRatioFitterTag_ByOrgin(System.String value, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetAspectRatioFitterName_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.name;
		}

		return null;
	}

	public static System.String GetAspectRatioFitterName_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.name;
		}

		return null;
	}

	public static System.String GetAspectRatioFitterName_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.name;
		}

		return null;
	}


	public static void SetAspectRatioFitterName_ByName(System.String value, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.name = value;
		}
	}

	public static void SetAspectRatioFitterName_ByPath(System.String value, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.name = value;
		}
	}

	public static void SetAspectRatioFitterName_ByOrgin(System.String value, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.name = value;
		}
	}


	public static UnityEngine.HideFlags GetAspectRatioFitterHideFlags_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetAspectRatioFitterHideFlags_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetAspectRatioFitterHideFlags_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetAspectRatioFitterHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.hideFlags = value;
		}
	}

	public static void SetAspectRatioFitterHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.hideFlags = value;
		}
	}

	public static void SetAspectRatioFitterHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			aspectratiofitter.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByName(name);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByPath(path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		AspectRatioFitter aspectratiofitter = GetAspectRatioFitterByOrgin(parentName, path);
		if(aspectratiofitter != null)
		{
			return aspectratiofitter.GetType();
		}

		return null;
	}


}

