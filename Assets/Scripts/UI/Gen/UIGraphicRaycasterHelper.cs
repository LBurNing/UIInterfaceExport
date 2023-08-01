using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIGraphicRaycasterHelper
{
	public static GraphicRaycaster GetGraphicRaycasterByName(string name)
	{
		return UIManager.GetComponentByName<GraphicRaycaster>(name);
	}

	public static GraphicRaycaster GetGraphicRaycasterByPath(string path)
	{
		return UIManager.GetComponentByPath<GraphicRaycaster>(path);
	}

	public static GraphicRaycaster GetGraphicRaycasterByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<GraphicRaycaster>(parentName, path);
	}

	public static System.Int32 GetGraphicRaycasterSortOrderPriority_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.sortOrderPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetGraphicRaycasterSortOrderPriority_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.sortOrderPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetGraphicRaycasterSortOrderPriority_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.sortOrderPriority;
		}

		return default(System.Int32);
	}


	public static System.Int32 GetGraphicRaycasterRenderOrderPriority_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.renderOrderPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetGraphicRaycasterRenderOrderPriority_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.renderOrderPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetGraphicRaycasterRenderOrderPriority_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.renderOrderPriority;
		}

		return default(System.Int32);
	}


	public static System.Boolean GetGraphicRaycasterIgnoreReversedGraphics_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.ignoreReversedGraphics;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRaycasterIgnoreReversedGraphics_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.ignoreReversedGraphics;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRaycasterIgnoreReversedGraphics_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.ignoreReversedGraphics;
		}

		return default(System.Boolean);
	}


	public static void SetGraphicRaycasterIgnoreReversedGraphics_ByName(System.Boolean value, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.ignoreReversedGraphics = value;
		}
	}

	public static void SetGraphicRaycasterIgnoreReversedGraphics_ByPath(System.Boolean value, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.ignoreReversedGraphics = value;
		}
	}

	public static void SetGraphicRaycasterIgnoreReversedGraphics_ByOrgin(System.Boolean value, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.ignoreReversedGraphics = value;
		}
	}


	public static UnityEngine.UI.GraphicRaycaster.BlockingObjects GetGraphicRaycasterBlockingObjects_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.blockingObjects;
		}

		return default(UnityEngine.UI.GraphicRaycaster.BlockingObjects);
	}

	public static UnityEngine.UI.GraphicRaycaster.BlockingObjects GetGraphicRaycasterBlockingObjects_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.blockingObjects;
		}

		return default(UnityEngine.UI.GraphicRaycaster.BlockingObjects);
	}

	public static UnityEngine.UI.GraphicRaycaster.BlockingObjects GetGraphicRaycasterBlockingObjects_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.blockingObjects;
		}

		return default(UnityEngine.UI.GraphicRaycaster.BlockingObjects);
	}


	public static void SetGraphicRaycasterBlockingObjects_ByName(UnityEngine.UI.GraphicRaycaster.BlockingObjects value, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.blockingObjects = value;
		}
	}

	public static void SetGraphicRaycasterBlockingObjects_ByPath(UnityEngine.UI.GraphicRaycaster.BlockingObjects value, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.blockingObjects = value;
		}
	}

	public static void SetGraphicRaycasterBlockingObjects_ByOrgin(UnityEngine.UI.GraphicRaycaster.BlockingObjects value, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.blockingObjects = value;
		}
	}


	public static UnityEngine.LayerMask GetGraphicRaycasterBlockingMask_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.blockingMask;
		}

		return default(UnityEngine.LayerMask);
	}

	public static UnityEngine.LayerMask GetGraphicRaycasterBlockingMask_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.blockingMask;
		}

		return default(UnityEngine.LayerMask);
	}

	public static UnityEngine.LayerMask GetGraphicRaycasterBlockingMask_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.blockingMask;
		}

		return default(UnityEngine.LayerMask);
	}


	public static void SetGraphicRaycasterBlockingMask_ByName(UnityEngine.LayerMask value, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.blockingMask = value;
		}
	}

	public static void SetGraphicRaycasterBlockingMask_ByPath(UnityEngine.LayerMask value, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.blockingMask = value;
		}
	}

	public static void SetGraphicRaycasterBlockingMask_ByOrgin(UnityEngine.LayerMask value, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.blockingMask = value;
		}
	}


	public static void Raycast_ByName(UnityEngine.EventSystems.PointerEventData eventData, List<UnityEngine.EventSystems.RaycastResult> resultAppendList, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.Raycast(eventData, resultAppendList);
		}
	}

	public static void Raycast_ByPath(UnityEngine.EventSystems.PointerEventData eventData, List<UnityEngine.EventSystems.RaycastResult> resultAppendList, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.Raycast(eventData, resultAppendList);
		}
	}

	public static void Raycast_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, List<UnityEngine.EventSystems.RaycastResult> resultAppendList, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.Raycast(eventData, resultAppendList);
		}
	}


	public static UnityEngine.Camera GetGraphicRaycasterEventCamera_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.eventCamera;
		}

		return null;
	}

	public static UnityEngine.Camera GetGraphicRaycasterEventCamera_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.eventCamera;
		}

		return null;
	}

	public static UnityEngine.Camera GetGraphicRaycasterEventCamera_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.eventCamera;
		}

		return null;
	}


	public static System.Int32 GetGraphicRaycasterPriority_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.priority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetGraphicRaycasterPriority_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.priority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetGraphicRaycasterPriority_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.priority;
		}

		return default(System.Int32);
	}


	public static UnityEngine.EventSystems.BaseRaycaster GetGraphicRaycasterRootRaycaster_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.rootRaycaster;
		}

		return null;
	}

	public static UnityEngine.EventSystems.BaseRaycaster GetGraphicRaycasterRootRaycaster_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.rootRaycaster;
		}

		return null;
	}

	public static UnityEngine.EventSystems.BaseRaycaster GetGraphicRaycasterRootRaycaster_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.rootRaycaster;
		}

		return null;
	}


	public static System.String ToString_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.ToString();
		}

		return null;
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.StopAllCoroutines();
		}
	}


	public static System.Boolean GetGraphicRaycasterUseGUILayout_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRaycasterUseGUILayout_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRaycasterUseGUILayout_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetGraphicRaycasterUseGUILayout_ByName(System.Boolean value, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.useGUILayout = value;
		}
	}

	public static void SetGraphicRaycasterUseGUILayout_ByPath(System.Boolean value, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.useGUILayout = value;
		}
	}

	public static void SetGraphicRaycasterUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.useGUILayout = value;
		}
	}


	public static System.Boolean GetGraphicRaycasterRunInEditMode_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRaycasterRunInEditMode_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRaycasterRunInEditMode_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetGraphicRaycasterRunInEditMode_ByName(System.Boolean value, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.runInEditMode = value;
		}
	}

	public static void SetGraphicRaycasterRunInEditMode_ByPath(System.Boolean value, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.runInEditMode = value;
		}
	}

	public static void SetGraphicRaycasterRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.runInEditMode = value;
		}
	}


	public static System.Boolean GetGraphicRaycasterEnabled_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRaycasterEnabled_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRaycasterEnabled_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetGraphicRaycasterEnabled_ByName(System.Boolean value, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.enabled = value;
		}
	}

	public static void SetGraphicRaycasterEnabled_ByPath(System.Boolean value, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.enabled = value;
		}
	}

	public static void SetGraphicRaycasterEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.enabled = value;
		}
	}


	public static System.Boolean GetGraphicRaycasterIsActiveAndEnabled_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRaycasterIsActiveAndEnabled_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRaycasterIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetGraphicRaycasterTransform_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetGraphicRaycasterTransform_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetGraphicRaycasterTransform_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetGraphicRaycasterGameObject_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetGraphicRaycasterGameObject_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetGraphicRaycasterGameObject_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.GetComponents(type, results);
		}
	}


	public static System.String GetGraphicRaycasterTag_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.tag;
		}

		return null;
	}

	public static System.String GetGraphicRaycasterTag_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.tag;
		}

		return null;
	}

	public static System.String GetGraphicRaycasterTag_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.tag;
		}

		return null;
	}


	public static void SetGraphicRaycasterTag_ByName(System.String value, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.tag = value;
		}
	}

	public static void SetGraphicRaycasterTag_ByPath(System.String value, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.tag = value;
		}
	}

	public static void SetGraphicRaycasterTag_ByOrgin(System.String value, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetGraphicRaycasterName_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.name;
		}

		return null;
	}

	public static System.String GetGraphicRaycasterName_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.name;
		}

		return null;
	}

	public static System.String GetGraphicRaycasterName_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.name;
		}

		return null;
	}


	public static void SetGraphicRaycasterName_ByName(System.String value, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.name = value;
		}
	}

	public static void SetGraphicRaycasterName_ByPath(System.String value, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.name = value;
		}
	}

	public static void SetGraphicRaycasterName_ByOrgin(System.String value, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.name = value;
		}
	}


	public static UnityEngine.HideFlags GetGraphicRaycasterHideFlags_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetGraphicRaycasterHideFlags_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetGraphicRaycasterHideFlags_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetGraphicRaycasterHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			graphicraycaster.hideFlags = value;
		}
	}

	public static void SetGraphicRaycasterHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			graphicraycaster.hideFlags = value;
		}
	}

	public static void SetGraphicRaycasterHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			graphicraycaster.hideFlags = value;
		}
	}


	public static System.Type GetType_ByName(string name)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByName(name);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByPath(path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		GraphicRaycaster graphicraycaster = GetGraphicRaycasterByOrgin(parentName, path);
		if(graphicraycaster != null)
		{
			return graphicraycaster.GetType();
		}

		return null;
	}


}

