using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIPositionAsUV1Helper
{
	public static PositionAsUV1 GetPositionAsUV1ByName(string name)
	{
		return UIManager.GetComponentByName<PositionAsUV1>(name);
	}

	public static PositionAsUV1 GetPositionAsUV1ByPath(string path)
	{
		return UIManager.GetComponentByPath<PositionAsUV1>(path);
	}

	public static PositionAsUV1 GetPositionAsUV1ByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<PositionAsUV1>(parentName, path);
	}

	public static void ModifyMesh_ByName(UnityEngine.UI.VertexHelper vh, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.ModifyMesh(vh);
		}
	}

	public static void ModifyMesh_ByPath(UnityEngine.UI.VertexHelper vh, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.ModifyMesh(vh);
		}
	}

	public static void ModifyMesh_ByOrgin(UnityEngine.UI.VertexHelper vh, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.ModifyMesh(vh);
		}
	}


	public static void ModifyMesh_ByName(UnityEngine.Mesh mesh, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.ModifyMesh(mesh);
		}
	}

	public static void ModifyMesh_ByPath(UnityEngine.Mesh mesh, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.ModifyMesh(mesh);
		}
	}

	public static void ModifyMesh_ByOrgin(UnityEngine.Mesh mesh, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.ModifyMesh(mesh);
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.StopAllCoroutines();
		}
	}


	public static System.Boolean GetPositionAsUV1UseGUILayout_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetPositionAsUV1UseGUILayout_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetPositionAsUV1UseGUILayout_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetPositionAsUV1UseGUILayout_ByName(System.Boolean value, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.useGUILayout = value;
		}
	}

	public static void SetPositionAsUV1UseGUILayout_ByPath(System.Boolean value, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.useGUILayout = value;
		}
	}

	public static void SetPositionAsUV1UseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.useGUILayout = value;
		}
	}


	public static System.Boolean GetPositionAsUV1RunInEditMode_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetPositionAsUV1RunInEditMode_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetPositionAsUV1RunInEditMode_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetPositionAsUV1RunInEditMode_ByName(System.Boolean value, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.runInEditMode = value;
		}
	}

	public static void SetPositionAsUV1RunInEditMode_ByPath(System.Boolean value, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.runInEditMode = value;
		}
	}

	public static void SetPositionAsUV1RunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.runInEditMode = value;
		}
	}


	public static System.Boolean GetPositionAsUV1Enabled_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetPositionAsUV1Enabled_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetPositionAsUV1Enabled_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetPositionAsUV1Enabled_ByName(System.Boolean value, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.enabled = value;
		}
	}

	public static void SetPositionAsUV1Enabled_ByPath(System.Boolean value, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.enabled = value;
		}
	}

	public static void SetPositionAsUV1Enabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.enabled = value;
		}
	}


	public static System.Boolean GetPositionAsUV1IsActiveAndEnabled_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetPositionAsUV1IsActiveAndEnabled_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetPositionAsUV1IsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetPositionAsUV1Transform_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetPositionAsUV1Transform_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetPositionAsUV1Transform_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetPositionAsUV1GameObject_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetPositionAsUV1GameObject_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetPositionAsUV1GameObject_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.GetComponents(type, results);
		}
	}


	public static System.String GetPositionAsUV1Tag_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.tag;
		}

		return null;
	}

	public static System.String GetPositionAsUV1Tag_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.tag;
		}

		return null;
	}

	public static System.String GetPositionAsUV1Tag_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.tag;
		}

		return null;
	}


	public static void SetPositionAsUV1Tag_ByName(System.String value, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.tag = value;
		}
	}

	public static void SetPositionAsUV1Tag_ByPath(System.String value, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.tag = value;
		}
	}

	public static void SetPositionAsUV1Tag_ByOrgin(System.String value, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetPositionAsUV1Name_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.name;
		}

		return null;
	}

	public static System.String GetPositionAsUV1Name_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.name;
		}

		return null;
	}

	public static System.String GetPositionAsUV1Name_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.name;
		}

		return null;
	}


	public static void SetPositionAsUV1Name_ByName(System.String value, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.name = value;
		}
	}

	public static void SetPositionAsUV1Name_ByPath(System.String value, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.name = value;
		}
	}

	public static void SetPositionAsUV1Name_ByOrgin(System.String value, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.name = value;
		}
	}


	public static UnityEngine.HideFlags GetPositionAsUV1HideFlags_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetPositionAsUV1HideFlags_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetPositionAsUV1HideFlags_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetPositionAsUV1HideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			positionasuv1.hideFlags = value;
		}
	}

	public static void SetPositionAsUV1HideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			positionasuv1.hideFlags = value;
		}
	}

	public static void SetPositionAsUV1HideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			positionasuv1.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByName(name);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByPath(path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		PositionAsUV1 positionasuv1 = GetPositionAsUV1ByOrgin(parentName, path);
		if(positionasuv1 != null)
		{
			return positionasuv1.GetType();
		}

		return null;
	}


}

