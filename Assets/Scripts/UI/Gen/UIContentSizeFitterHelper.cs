using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIContentSizeFitterHelper
{
	public static ContentSizeFitter GetContentSizeFitterByName(string name)
	{
		return UIManager.GetComponentByName<ContentSizeFitter>(name);
	}

	public static ContentSizeFitter GetContentSizeFitterByPath(string path)
	{
		return UIManager.GetComponentByPath<ContentSizeFitter>(path);
	}

	public static ContentSizeFitter GetContentSizeFitterByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<ContentSizeFitter>(parentName, path);
	}

	public static UnityEngine.UI.ContentSizeFitter.FitMode GetContentSizeFitterHorizontalFit_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.horizontalFit;
		}

		return default(UnityEngine.UI.ContentSizeFitter.FitMode);
	}

	public static UnityEngine.UI.ContentSizeFitter.FitMode GetContentSizeFitterHorizontalFit_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.horizontalFit;
		}

		return default(UnityEngine.UI.ContentSizeFitter.FitMode);
	}

	public static UnityEngine.UI.ContentSizeFitter.FitMode GetContentSizeFitterHorizontalFit_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.horizontalFit;
		}

		return default(UnityEngine.UI.ContentSizeFitter.FitMode);
	}


	public static void SetContentSizeFitterHorizontalFit_ByName(UnityEngine.UI.ContentSizeFitter.FitMode value, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.horizontalFit = value;
		}
	}

	public static void SetContentSizeFitterHorizontalFit_ByPath(UnityEngine.UI.ContentSizeFitter.FitMode value, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.horizontalFit = value;
		}
	}

	public static void SetContentSizeFitterHorizontalFit_ByOrgin(UnityEngine.UI.ContentSizeFitter.FitMode value, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.horizontalFit = value;
		}
	}


	public static UnityEngine.UI.ContentSizeFitter.FitMode GetContentSizeFitterVerticalFit_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.verticalFit;
		}

		return default(UnityEngine.UI.ContentSizeFitter.FitMode);
	}

	public static UnityEngine.UI.ContentSizeFitter.FitMode GetContentSizeFitterVerticalFit_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.verticalFit;
		}

		return default(UnityEngine.UI.ContentSizeFitter.FitMode);
	}

	public static UnityEngine.UI.ContentSizeFitter.FitMode GetContentSizeFitterVerticalFit_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.verticalFit;
		}

		return default(UnityEngine.UI.ContentSizeFitter.FitMode);
	}


	public static void SetContentSizeFitterVerticalFit_ByName(UnityEngine.UI.ContentSizeFitter.FitMode value, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.verticalFit = value;
		}
	}

	public static void SetContentSizeFitterVerticalFit_ByPath(UnityEngine.UI.ContentSizeFitter.FitMode value, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.verticalFit = value;
		}
	}

	public static void SetContentSizeFitterVerticalFit_ByOrgin(UnityEngine.UI.ContentSizeFitter.FitMode value, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.verticalFit = value;
		}
	}


	public static void SetLayoutHorizontal_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SetLayoutHorizontal();
		}
	}


	public static void SetLayoutVertical_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SetLayoutVertical();
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.StopAllCoroutines();
		}
	}


	public static System.Boolean GetContentSizeFitterUseGUILayout_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetContentSizeFitterUseGUILayout_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetContentSizeFitterUseGUILayout_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetContentSizeFitterUseGUILayout_ByName(System.Boolean value, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.useGUILayout = value;
		}
	}

	public static void SetContentSizeFitterUseGUILayout_ByPath(System.Boolean value, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.useGUILayout = value;
		}
	}

	public static void SetContentSizeFitterUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.useGUILayout = value;
		}
	}


	public static System.Boolean GetContentSizeFitterRunInEditMode_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetContentSizeFitterRunInEditMode_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetContentSizeFitterRunInEditMode_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetContentSizeFitterRunInEditMode_ByName(System.Boolean value, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.runInEditMode = value;
		}
	}

	public static void SetContentSizeFitterRunInEditMode_ByPath(System.Boolean value, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.runInEditMode = value;
		}
	}

	public static void SetContentSizeFitterRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.runInEditMode = value;
		}
	}


	public static System.Boolean GetContentSizeFitterEnabled_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetContentSizeFitterEnabled_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetContentSizeFitterEnabled_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetContentSizeFitterEnabled_ByName(System.Boolean value, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.enabled = value;
		}
	}

	public static void SetContentSizeFitterEnabled_ByPath(System.Boolean value, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.enabled = value;
		}
	}

	public static void SetContentSizeFitterEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.enabled = value;
		}
	}


	public static System.Boolean GetContentSizeFitterIsActiveAndEnabled_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetContentSizeFitterIsActiveAndEnabled_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetContentSizeFitterIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetContentSizeFitterTransform_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetContentSizeFitterTransform_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetContentSizeFitterTransform_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetContentSizeFitterGameObject_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetContentSizeFitterGameObject_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetContentSizeFitterGameObject_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.GetComponents(type, results);
		}
	}


	public static System.String GetContentSizeFitterTag_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.tag;
		}

		return null;
	}

	public static System.String GetContentSizeFitterTag_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.tag;
		}

		return null;
	}

	public static System.String GetContentSizeFitterTag_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.tag;
		}

		return null;
	}


	public static void SetContentSizeFitterTag_ByName(System.String value, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.tag = value;
		}
	}

	public static void SetContentSizeFitterTag_ByPath(System.String value, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.tag = value;
		}
	}

	public static void SetContentSizeFitterTag_ByOrgin(System.String value, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetContentSizeFitterName_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.name;
		}

		return null;
	}

	public static System.String GetContentSizeFitterName_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.name;
		}

		return null;
	}

	public static System.String GetContentSizeFitterName_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.name;
		}

		return null;
	}


	public static void SetContentSizeFitterName_ByName(System.String value, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.name = value;
		}
	}

	public static void SetContentSizeFitterName_ByPath(System.String value, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.name = value;
		}
	}

	public static void SetContentSizeFitterName_ByOrgin(System.String value, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.name = value;
		}
	}


	public static UnityEngine.HideFlags GetContentSizeFitterHideFlags_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetContentSizeFitterHideFlags_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetContentSizeFitterHideFlags_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetContentSizeFitterHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			contentsizefitter.hideFlags = value;
		}
	}

	public static void SetContentSizeFitterHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			contentsizefitter.hideFlags = value;
		}
	}

	public static void SetContentSizeFitterHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			contentsizefitter.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByName(name);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByPath(path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		ContentSizeFitter contentsizefitter = GetContentSizeFitterByOrgin(parentName, path);
		if(contentsizefitter != null)
		{
			return contentsizefitter.GetType();
		}

		return null;
	}


}

