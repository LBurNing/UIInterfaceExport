using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIToggleGroupHelper
{
	public static ToggleGroup GetToggleGroupByName(string name)
	{
		return UIManager.GetComponentByName<ToggleGroup>(name);
	}

	public static ToggleGroup GetToggleGroupByPath(string path)
	{
		return UIManager.GetComponentByPath<ToggleGroup>(path);
	}

	public static ToggleGroup GetToggleGroupByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<ToggleGroup>(parentName, path);
	}

	public static System.Boolean GetToggleGroupAllowSwitchOff_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.allowSwitchOff;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleGroupAllowSwitchOff_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.allowSwitchOff;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleGroupAllowSwitchOff_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.allowSwitchOff;
		}

		return default(System.Boolean);
	}


	public static void SetToggleGroupAllowSwitchOff_ByName(System.Boolean value, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.allowSwitchOff = value;
		}
	}

	public static void SetToggleGroupAllowSwitchOff_ByPath(System.Boolean value, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.allowSwitchOff = value;
		}
	}

	public static void SetToggleGroupAllowSwitchOff_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.allowSwitchOff = value;
		}
	}


	public static void NotifyToggleOn_ByName(UnityEngine.UI.Toggle toggle, System.Boolean sendCallback, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.NotifyToggleOn(toggle, sendCallback);
		}
	}

	public static void NotifyToggleOn_ByPath(UnityEngine.UI.Toggle toggle, System.Boolean sendCallback, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.NotifyToggleOn(toggle, sendCallback);
		}
	}

	public static void NotifyToggleOn_ByOrgin(UnityEngine.UI.Toggle toggle, System.Boolean sendCallback, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.NotifyToggleOn(toggle, sendCallback);
		}
	}


	public static void UnregisterToggle_ByName(UnityEngine.UI.Toggle toggle, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.UnregisterToggle(toggle);
		}
	}

	public static void UnregisterToggle_ByPath(UnityEngine.UI.Toggle toggle, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.UnregisterToggle(toggle);
		}
	}

	public static void UnregisterToggle_ByOrgin(UnityEngine.UI.Toggle toggle, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.UnregisterToggle(toggle);
		}
	}


	public static void RegisterToggle_ByName(UnityEngine.UI.Toggle toggle, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.RegisterToggle(toggle);
		}
	}

	public static void RegisterToggle_ByPath(UnityEngine.UI.Toggle toggle, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.RegisterToggle(toggle);
		}
	}

	public static void RegisterToggle_ByOrgin(UnityEngine.UI.Toggle toggle, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.RegisterToggle(toggle);
		}
	}


	public static void EnsureValidState_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.EnsureValidState();
		}
	}

	public static void EnsureValidState_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.EnsureValidState();
		}
	}

	public static void EnsureValidState_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.EnsureValidState();
		}
	}


	public static System.Boolean AnyTogglesOn_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.AnyTogglesOn();
		}

		return default(System.Boolean);
	}

	public static System.Boolean AnyTogglesOn_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.AnyTogglesOn();
		}

		return default(System.Boolean);
	}

	public static System.Boolean AnyTogglesOn_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.AnyTogglesOn();
		}

		return default(System.Boolean);
	}


	public static IEnumerable<UnityEngine.UI.Toggle>  ActiveToggles_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.ActiveToggles();
		}

		return default(IEnumerable<UnityEngine.UI.Toggle> );
	}

	public static IEnumerable<UnityEngine.UI.Toggle>  ActiveToggles_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.ActiveToggles();
		}

		return default(IEnumerable<UnityEngine.UI.Toggle> );
	}

	public static IEnumerable<UnityEngine.UI.Toggle>  ActiveToggles_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.ActiveToggles();
		}

		return default(IEnumerable<UnityEngine.UI.Toggle> );
	}


	public static UnityEngine.UI.Toggle GetFirstActiveToggle_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetFirstActiveToggle();
		}

		return null;
	}

	public static UnityEngine.UI.Toggle GetFirstActiveToggle_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetFirstActiveToggle();
		}

		return null;
	}

	public static UnityEngine.UI.Toggle GetFirstActiveToggle_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetFirstActiveToggle();
		}

		return null;
	}


	public static void SetAllTogglesOff_ByName(System.Boolean sendCallback, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.SetAllTogglesOff(sendCallback);
		}
	}

	public static void SetAllTogglesOff_ByPath(System.Boolean sendCallback, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.SetAllTogglesOff(sendCallback);
		}
	}

	public static void SetAllTogglesOff_ByOrgin(System.Boolean sendCallback, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.SetAllTogglesOff(sendCallback);
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.StopAllCoroutines();
		}
	}


	public static System.Boolean GetToggleGroupUseGUILayout_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleGroupUseGUILayout_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleGroupUseGUILayout_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetToggleGroupUseGUILayout_ByName(System.Boolean value, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.useGUILayout = value;
		}
	}

	public static void SetToggleGroupUseGUILayout_ByPath(System.Boolean value, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.useGUILayout = value;
		}
	}

	public static void SetToggleGroupUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.useGUILayout = value;
		}
	}


	public static System.Boolean GetToggleGroupRunInEditMode_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleGroupRunInEditMode_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleGroupRunInEditMode_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetToggleGroupRunInEditMode_ByName(System.Boolean value, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.runInEditMode = value;
		}
	}

	public static void SetToggleGroupRunInEditMode_ByPath(System.Boolean value, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.runInEditMode = value;
		}
	}

	public static void SetToggleGroupRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.runInEditMode = value;
		}
	}


	public static System.Boolean GetToggleGroupEnabled_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleGroupEnabled_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleGroupEnabled_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetToggleGroupEnabled_ByName(System.Boolean value, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.enabled = value;
		}
	}

	public static void SetToggleGroupEnabled_ByPath(System.Boolean value, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.enabled = value;
		}
	}

	public static void SetToggleGroupEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.enabled = value;
		}
	}


	public static System.Boolean GetToggleGroupIsActiveAndEnabled_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleGroupIsActiveAndEnabled_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleGroupIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetToggleGroupTransform_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetToggleGroupTransform_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetToggleGroupTransform_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetToggleGroupGameObject_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetToggleGroupGameObject_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetToggleGroupGameObject_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.GetComponents(type, results);
		}
	}


	public static System.String GetToggleGroupTag_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.tag;
		}

		return null;
	}

	public static System.String GetToggleGroupTag_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.tag;
		}

		return null;
	}

	public static System.String GetToggleGroupTag_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.tag;
		}

		return null;
	}


	public static void SetToggleGroupTag_ByName(System.String value, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.tag = value;
		}
	}

	public static void SetToggleGroupTag_ByPath(System.String value, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.tag = value;
		}
	}

	public static void SetToggleGroupTag_ByOrgin(System.String value, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetToggleGroupName_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.name;
		}

		return null;
	}

	public static System.String GetToggleGroupName_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.name;
		}

		return null;
	}

	public static System.String GetToggleGroupName_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.name;
		}

		return null;
	}


	public static void SetToggleGroupName_ByName(System.String value, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.name = value;
		}
	}

	public static void SetToggleGroupName_ByPath(System.String value, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.name = value;
		}
	}

	public static void SetToggleGroupName_ByOrgin(System.String value, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.name = value;
		}
	}


	public static UnityEngine.HideFlags GetToggleGroupHideFlags_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetToggleGroupHideFlags_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetToggleGroupHideFlags_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetToggleGroupHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			togglegroup.hideFlags = value;
		}
	}

	public static void SetToggleGroupHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			togglegroup.hideFlags = value;
		}
	}

	public static void SetToggleGroupHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			togglegroup.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		ToggleGroup togglegroup = GetToggleGroupByName(name);
		if(togglegroup != null)
		{
			return togglegroup.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByPath(path);
		if(togglegroup != null)
		{
			return togglegroup.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		ToggleGroup togglegroup = GetToggleGroupByOrgin(parentName, path);
		if(togglegroup != null)
		{
			return togglegroup.GetType();
		}

		return null;
	}


}

