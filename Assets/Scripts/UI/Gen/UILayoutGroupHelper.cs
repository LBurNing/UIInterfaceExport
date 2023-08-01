using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UILayoutGroupHelper
{
	public static LayoutGroup GetLayoutGroupByName(string name)
	{
		return UIManager.GetComponentByName<LayoutGroup>(name);
	}

	public static LayoutGroup GetLayoutGroupByPath(string path)
	{
		return UIManager.GetComponentByPath<LayoutGroup>(path);
	}

	public static LayoutGroup GetLayoutGroupByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<LayoutGroup>(parentName, path);
	}

	public static UnityEngine.RectOffset GetLayoutGroupPadding_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.padding;
		}

		return null;
	}

	public static UnityEngine.RectOffset GetLayoutGroupPadding_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.padding;
		}

		return null;
	}

	public static UnityEngine.RectOffset GetLayoutGroupPadding_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.padding;
		}

		return null;
	}


	public static void SetLayoutGroupPadding_ByName(UnityEngine.RectOffset value, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.padding = value;
		}
	}

	public static void SetLayoutGroupPadding_ByPath(UnityEngine.RectOffset value, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.padding = value;
		}
	}

	public static void SetLayoutGroupPadding_ByOrgin(UnityEngine.RectOffset value, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.padding = value;
		}
	}


	public static UnityEngine.TextAnchor GetLayoutGroupChildAlignment_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}

	public static UnityEngine.TextAnchor GetLayoutGroupChildAlignment_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}

	public static UnityEngine.TextAnchor GetLayoutGroupChildAlignment_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}


	public static void SetLayoutGroupChildAlignment_ByName(UnityEngine.TextAnchor value, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.childAlignment = value;
		}
	}

	public static void SetLayoutGroupChildAlignment_ByPath(UnityEngine.TextAnchor value, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.childAlignment = value;
		}
	}

	public static void SetLayoutGroupChildAlignment_ByOrgin(UnityEngine.TextAnchor value, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.childAlignment = value;
		}
	}


	public static void CalculateLayoutInputHorizontal_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.CalculateLayoutInputHorizontal();
		}
	}


	public static void CalculateLayoutInputVertical_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.CalculateLayoutInputVertical();
		}
	}


	public static System.Single GetLayoutGroupMinWidth_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutGroupMinWidth_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutGroupMinWidth_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.minWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetLayoutGroupPreferredWidth_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutGroupPreferredWidth_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutGroupPreferredWidth_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.preferredWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetLayoutGroupFlexibleWidth_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutGroupFlexibleWidth_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutGroupFlexibleWidth_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetLayoutGroupMinHeight_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutGroupMinHeight_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutGroupMinHeight_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.minHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetLayoutGroupPreferredHeight_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutGroupPreferredHeight_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutGroupPreferredHeight_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.preferredHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetLayoutGroupFlexibleHeight_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutGroupFlexibleHeight_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetLayoutGroupFlexibleHeight_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}


	public static System.Int32 GetLayoutGroupLayoutPriority_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetLayoutGroupLayoutPriority_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetLayoutGroupLayoutPriority_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}


	public static void SetLayoutHorizontal_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.SetLayoutHorizontal();
		}
	}


	public static void SetLayoutVertical_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.SetLayoutVertical();
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.StopAllCoroutines();
		}
	}


	public static System.Boolean GetLayoutGroupUseGUILayout_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutGroupUseGUILayout_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutGroupUseGUILayout_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetLayoutGroupUseGUILayout_ByName(System.Boolean value, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.useGUILayout = value;
		}
	}

	public static void SetLayoutGroupUseGUILayout_ByPath(System.Boolean value, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.useGUILayout = value;
		}
	}

	public static void SetLayoutGroupUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.useGUILayout = value;
		}
	}


	public static System.Boolean GetLayoutGroupRunInEditMode_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutGroupRunInEditMode_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutGroupRunInEditMode_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetLayoutGroupRunInEditMode_ByName(System.Boolean value, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.runInEditMode = value;
		}
	}

	public static void SetLayoutGroupRunInEditMode_ByPath(System.Boolean value, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.runInEditMode = value;
		}
	}

	public static void SetLayoutGroupRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.runInEditMode = value;
		}
	}


	public static System.Boolean GetLayoutGroupEnabled_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutGroupEnabled_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutGroupEnabled_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetLayoutGroupEnabled_ByName(System.Boolean value, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.enabled = value;
		}
	}

	public static void SetLayoutGroupEnabled_ByPath(System.Boolean value, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.enabled = value;
		}
	}

	public static void SetLayoutGroupEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.enabled = value;
		}
	}


	public static System.Boolean GetLayoutGroupIsActiveAndEnabled_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutGroupIsActiveAndEnabled_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetLayoutGroupIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetLayoutGroupTransform_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetLayoutGroupTransform_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetLayoutGroupTransform_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetLayoutGroupGameObject_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetLayoutGroupGameObject_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetLayoutGroupGameObject_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.GetComponents(type, results);
		}
	}


	public static System.String GetLayoutGroupTag_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.tag;
		}

		return null;
	}

	public static System.String GetLayoutGroupTag_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.tag;
		}

		return null;
	}

	public static System.String GetLayoutGroupTag_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.tag;
		}

		return null;
	}


	public static void SetLayoutGroupTag_ByName(System.String value, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.tag = value;
		}
	}

	public static void SetLayoutGroupTag_ByPath(System.String value, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.tag = value;
		}
	}

	public static void SetLayoutGroupTag_ByOrgin(System.String value, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetLayoutGroupName_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.name;
		}

		return null;
	}

	public static System.String GetLayoutGroupName_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.name;
		}

		return null;
	}

	public static System.String GetLayoutGroupName_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.name;
		}

		return null;
	}


	public static void SetLayoutGroupName_ByName(System.String value, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.name = value;
		}
	}

	public static void SetLayoutGroupName_ByPath(System.String value, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.name = value;
		}
	}

	public static void SetLayoutGroupName_ByOrgin(System.String value, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.name = value;
		}
	}


	public static UnityEngine.HideFlags GetLayoutGroupHideFlags_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetLayoutGroupHideFlags_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetLayoutGroupHideFlags_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetLayoutGroupHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			layoutgroup.hideFlags = value;
		}
	}

	public static void SetLayoutGroupHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			layoutgroup.hideFlags = value;
		}
	}

	public static void SetLayoutGroupHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			layoutgroup.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByName(name);
		if(layoutgroup != null)
		{
			return layoutgroup.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByPath(path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		LayoutGroup layoutgroup = GetLayoutGroupByOrgin(parentName, path);
		if(layoutgroup != null)
		{
			return layoutgroup.GetType();
		}

		return null;
	}


}

