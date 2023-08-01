using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIScrollbarHelper
{
	public static Scrollbar GetScrollbarByName(string name)
	{
		return UIManager.GetComponentByName<Scrollbar>(name);
	}

	public static Scrollbar GetScrollbarByPath(string path)
	{
		return UIManager.GetComponentByPath<Scrollbar>(path);
	}

	public static Scrollbar GetScrollbarByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<Scrollbar>(parentName, path);
	}

	public static UnityEngine.RectTransform GetScrollbarHandleRect_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.handleRect;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetScrollbarHandleRect_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.handleRect;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetScrollbarHandleRect_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.handleRect;
		}

		return null;
	}


	public static void SetScrollbarHandleRect_ByName(UnityEngine.RectTransform value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.handleRect = value;
		}
	}

	public static void SetScrollbarHandleRect_ByPath(UnityEngine.RectTransform value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.handleRect = value;
		}
	}

	public static void SetScrollbarHandleRect_ByOrgin(UnityEngine.RectTransform value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.handleRect = value;
		}
	}


	public static UnityEngine.UI.Scrollbar.Direction GetScrollbarDirection_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.direction;
		}

		return default(UnityEngine.UI.Scrollbar.Direction);
	}

	public static UnityEngine.UI.Scrollbar.Direction GetScrollbarDirection_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.direction;
		}

		return default(UnityEngine.UI.Scrollbar.Direction);
	}

	public static UnityEngine.UI.Scrollbar.Direction GetScrollbarDirection_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.direction;
		}

		return default(UnityEngine.UI.Scrollbar.Direction);
	}


	public static void SetScrollbarDirection_ByName(UnityEngine.UI.Scrollbar.Direction value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.direction = value;
		}
	}

	public static void SetScrollbarDirection_ByPath(UnityEngine.UI.Scrollbar.Direction value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.direction = value;
		}
	}

	public static void SetScrollbarDirection_ByOrgin(UnityEngine.UI.Scrollbar.Direction value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.direction = value;
		}
	}


	public static System.Single GetScrollbarValue_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.value;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollbarValue_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.value;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollbarValue_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.value;
		}

		return default(System.Single);
	}


	public static void SetScrollbarValue_ByName(System.Single value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.value = value;
		}
	}

	public static void SetScrollbarValue_ByPath(System.Single value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.value = value;
		}
	}

	public static void SetScrollbarValue_ByOrgin(System.Single value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.value = value;
		}
	}


	public static void SetValueWithoutNotify_ByName(System.Single input, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.SetValueWithoutNotify(input);
		}
	}

	public static void SetValueWithoutNotify_ByPath(System.Single input, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.SetValueWithoutNotify(input);
		}
	}

	public static void SetValueWithoutNotify_ByOrgin(System.Single input, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.SetValueWithoutNotify(input);
		}
	}


	public static System.Single GetScrollbarSize_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.size;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollbarSize_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.size;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollbarSize_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.size;
		}

		return default(System.Single);
	}


	public static void SetScrollbarSize_ByName(System.Single value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.size = value;
		}
	}

	public static void SetScrollbarSize_ByPath(System.Single value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.size = value;
		}
	}

	public static void SetScrollbarSize_ByOrgin(System.Single value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.size = value;
		}
	}


	public static System.Int32 GetScrollbarNumberOfSteps_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.numberOfSteps;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetScrollbarNumberOfSteps_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.numberOfSteps;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetScrollbarNumberOfSteps_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.numberOfSteps;
		}

		return default(System.Int32);
	}


	public static void SetScrollbarNumberOfSteps_ByName(System.Int32 value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.numberOfSteps = value;
		}
	}

	public static void SetScrollbarNumberOfSteps_ByPath(System.Int32 value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.numberOfSteps = value;
		}
	}

	public static void SetScrollbarNumberOfSteps_ByOrgin(System.Int32 value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.numberOfSteps = value;
		}
	}


	public static UnityEngine.UI.Scrollbar.ScrollEvent GetScrollbarOnValueChanged_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.onValueChanged;
		}

		return null;
	}

	public static UnityEngine.UI.Scrollbar.ScrollEvent GetScrollbarOnValueChanged_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.onValueChanged;
		}

		return null;
	}

	public static UnityEngine.UI.Scrollbar.ScrollEvent GetScrollbarOnValueChanged_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.onValueChanged;
		}

		return null;
	}


	public static void SetScrollbarOnValueChanged_ByName(UnityEngine.UI.Scrollbar.ScrollEvent value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.onValueChanged = value;
		}
	}

	public static void SetScrollbarOnValueChanged_ByPath(UnityEngine.UI.Scrollbar.ScrollEvent value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.onValueChanged = value;
		}
	}

	public static void SetScrollbarOnValueChanged_ByOrgin(UnityEngine.UI.Scrollbar.ScrollEvent value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.onValueChanged = value;
		}
	}


	public static void Rebuild_ByName(UnityEngine.UI.CanvasUpdate executing, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.Rebuild(executing);
		}
	}

	public static void Rebuild_ByPath(UnityEngine.UI.CanvasUpdate executing, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.Rebuild(executing);
		}
	}

	public static void Rebuild_ByOrgin(UnityEngine.UI.CanvasUpdate executing, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.Rebuild(executing);
		}
	}


	public static void LayoutComplete_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.LayoutComplete();
		}
	}


	public static void GraphicUpdateComplete_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.GraphicUpdateComplete();
		}
	}


	public static void OnBeginDrag_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.OnBeginDrag(eventData);
		}
	}

	public static void OnBeginDrag_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.OnBeginDrag(eventData);
		}
	}

	public static void OnBeginDrag_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.OnBeginDrag(eventData);
		}
	}


	public static void OnDrag_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.OnDrag(eventData);
		}
	}

	public static void OnDrag_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.OnDrag(eventData);
		}
	}

	public static void OnDrag_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.OnDrag(eventData);
		}
	}


	public static void OnPointerDown_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.OnPointerDown(eventData);
		}
	}


	public static void OnPointerUp_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.OnPointerUp(eventData);
		}
	}


	public static void OnMove_ByName(UnityEngine.EventSystems.AxisEventData eventData, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.OnMove(eventData);
		}
	}

	public static void OnMove_ByPath(UnityEngine.EventSystems.AxisEventData eventData, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.OnMove(eventData);
		}
	}

	public static void OnMove_ByOrgin(UnityEngine.EventSystems.AxisEventData eventData, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.OnMove(eventData);
		}
	}


	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectableOnLeft();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectableOnRight();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectableOnUp();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectableOnDown();
		}

		return null;
	}


	public static void OnInitializePotentialDrag_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.OnInitializePotentialDrag(eventData);
		}
	}

	public static void OnInitializePotentialDrag_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.OnInitializePotentialDrag(eventData);
		}
	}

	public static void OnInitializePotentialDrag_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.OnInitializePotentialDrag(eventData);
		}
	}


	public static void SetDirection_ByName(UnityEngine.UI.Scrollbar.Direction direction, System.Boolean includeRectLayouts, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.SetDirection(direction, includeRectLayouts);
		}
	}

	public static void SetDirection_ByPath(UnityEngine.UI.Scrollbar.Direction direction, System.Boolean includeRectLayouts, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.SetDirection(direction, includeRectLayouts);
		}
	}

	public static void SetDirection_ByOrgin(UnityEngine.UI.Scrollbar.Direction direction, System.Boolean includeRectLayouts, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.SetDirection(direction, includeRectLayouts);
		}
	}


	public static UnityEngine.UI.Navigation GetScrollbarNavigation_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetScrollbarNavigation_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetScrollbarNavigation_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}


	public static void SetScrollbarNavigation_ByName(UnityEngine.UI.Navigation value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.navigation = value;
		}
	}

	public static void SetScrollbarNavigation_ByPath(UnityEngine.UI.Navigation value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.navigation = value;
		}
	}

	public static void SetScrollbarNavigation_ByOrgin(UnityEngine.UI.Navigation value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.navigation = value;
		}
	}


	public static UnityEngine.UI.Selectable.Transition GetScrollbarTransition_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetScrollbarTransition_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetScrollbarTransition_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}


	public static void SetScrollbarTransition_ByName(UnityEngine.UI.Selectable.Transition value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.transition = value;
		}
	}

	public static void SetScrollbarTransition_ByPath(UnityEngine.UI.Selectable.Transition value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.transition = value;
		}
	}

	public static void SetScrollbarTransition_ByOrgin(UnityEngine.UI.Selectable.Transition value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.transition = value;
		}
	}


	public static UnityEngine.UI.ColorBlock GetScrollbarColors_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetScrollbarColors_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetScrollbarColors_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}


	public static void SetScrollbarColors_ByName(UnityEngine.UI.ColorBlock value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.colors = value;
		}
	}

	public static void SetScrollbarColors_ByPath(UnityEngine.UI.ColorBlock value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.colors = value;
		}
	}

	public static void SetScrollbarColors_ByOrgin(UnityEngine.UI.ColorBlock value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.colors = value;
		}
	}


	public static UnityEngine.UI.SpriteState GetScrollbarSpriteState_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetScrollbarSpriteState_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetScrollbarSpriteState_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}


	public static void SetScrollbarSpriteState_ByName(UnityEngine.UI.SpriteState value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.spriteState = value;
		}
	}

	public static void SetScrollbarSpriteState_ByPath(UnityEngine.UI.SpriteState value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.spriteState = value;
		}
	}

	public static void SetScrollbarSpriteState_ByOrgin(UnityEngine.UI.SpriteState value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.spriteState = value;
		}
	}


	public static UnityEngine.UI.AnimationTriggers GetScrollbarAnimationTriggers_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetScrollbarAnimationTriggers_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetScrollbarAnimationTriggers_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.animationTriggers;
		}

		return null;
	}


	public static void SetScrollbarAnimationTriggers_ByName(UnityEngine.UI.AnimationTriggers value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.animationTriggers = value;
		}
	}

	public static void SetScrollbarAnimationTriggers_ByPath(UnityEngine.UI.AnimationTriggers value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.animationTriggers = value;
		}
	}

	public static void SetScrollbarAnimationTriggers_ByOrgin(UnityEngine.UI.AnimationTriggers value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.animationTriggers = value;
		}
	}


	public static UnityEngine.UI.Graphic GetScrollbarTargetGraphic_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetScrollbarTargetGraphic_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetScrollbarTargetGraphic_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.targetGraphic;
		}

		return null;
	}


	public static void SetScrollbarTargetGraphic_ByName(UnityEngine.UI.Graphic value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.targetGraphic = value;
		}
	}

	public static void SetScrollbarTargetGraphic_ByPath(UnityEngine.UI.Graphic value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.targetGraphic = value;
		}
	}

	public static void SetScrollbarTargetGraphic_ByOrgin(UnityEngine.UI.Graphic value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.targetGraphic = value;
		}
	}


	public static System.Boolean GetScrollbarInteractable_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollbarInteractable_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollbarInteractable_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.interactable;
		}

		return default(System.Boolean);
	}


	public static void SetScrollbarInteractable_ByName(System.Boolean value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.interactable = value;
		}
	}

	public static void SetScrollbarInteractable_ByPath(System.Boolean value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.interactable = value;
		}
	}

	public static void SetScrollbarInteractable_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.interactable = value;
		}
	}


	public static UnityEngine.UI.Image GetScrollbarImage_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetScrollbarImage_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetScrollbarImage_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.image;
		}

		return null;
	}


	public static void SetScrollbarImage_ByName(UnityEngine.UI.Image value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.image = value;
		}
	}

	public static void SetScrollbarImage_ByPath(UnityEngine.UI.Image value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.image = value;
		}
	}

	public static void SetScrollbarImage_ByOrgin(UnityEngine.UI.Image value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.image = value;
		}
	}


	public static UnityEngine.Animator GetScrollbarAnimator_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetScrollbarAnimator_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetScrollbarAnimator_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.animator;
		}

		return null;
	}


	public static System.Boolean IsInteractable_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.IsInteractable();
		}

		return default(System.Boolean);
	}


	public static UnityEngine.UI.Selectable FindSelectable_ByName(UnityEngine.Vector3 dir, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByPath(UnityEngine.Vector3 dir, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByOrgin(UnityEngine.Vector3 dir, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.FindSelectable(dir);
		}

		return null;
	}


	public static void OnPointerEnter_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.OnPointerEnter(eventData);
		}
	}


	public static void OnPointerExit_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.OnPointerExit(eventData);
		}
	}


	public static void OnSelect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.OnSelect(eventData);
		}
	}


	public static void OnDeselect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.OnDeselect(eventData);
		}
	}


	public static void Select_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.Select();
		}
	}

	public static void Select_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.Select();
		}
	}

	public static void Select_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.Select();
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.StopAllCoroutines();
		}
	}


	public static System.Boolean GetScrollbarUseGUILayout_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollbarUseGUILayout_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollbarUseGUILayout_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetScrollbarUseGUILayout_ByName(System.Boolean value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.useGUILayout = value;
		}
	}

	public static void SetScrollbarUseGUILayout_ByPath(System.Boolean value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.useGUILayout = value;
		}
	}

	public static void SetScrollbarUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.useGUILayout = value;
		}
	}


	public static System.Boolean GetScrollbarRunInEditMode_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollbarRunInEditMode_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollbarRunInEditMode_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetScrollbarRunInEditMode_ByName(System.Boolean value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.runInEditMode = value;
		}
	}

	public static void SetScrollbarRunInEditMode_ByPath(System.Boolean value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.runInEditMode = value;
		}
	}

	public static void SetScrollbarRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.runInEditMode = value;
		}
	}


	public static System.Boolean GetScrollbarEnabled_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollbarEnabled_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollbarEnabled_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetScrollbarEnabled_ByName(System.Boolean value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.enabled = value;
		}
	}

	public static void SetScrollbarEnabled_ByPath(System.Boolean value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.enabled = value;
		}
	}

	public static void SetScrollbarEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.enabled = value;
		}
	}


	public static System.Boolean GetScrollbarIsActiveAndEnabled_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollbarIsActiveAndEnabled_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollbarIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetScrollbarTransform_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetScrollbarTransform_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetScrollbarTransform_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetScrollbarGameObject_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetScrollbarGameObject_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetScrollbarGameObject_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.GetComponents(type, results);
		}
	}


	public static System.String GetScrollbarTag_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.tag;
		}

		return null;
	}

	public static System.String GetScrollbarTag_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.tag;
		}

		return null;
	}

	public static System.String GetScrollbarTag_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.tag;
		}

		return null;
	}


	public static void SetScrollbarTag_ByName(System.String value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.tag = value;
		}
	}

	public static void SetScrollbarTag_ByPath(System.String value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.tag = value;
		}
	}

	public static void SetScrollbarTag_ByOrgin(System.String value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetScrollbarName_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.name;
		}

		return null;
	}

	public static System.String GetScrollbarName_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.name;
		}

		return null;
	}

	public static System.String GetScrollbarName_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.name;
		}

		return null;
	}


	public static void SetScrollbarName_ByName(System.String value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.name = value;
		}
	}

	public static void SetScrollbarName_ByPath(System.String value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.name = value;
		}
	}

	public static void SetScrollbarName_ByOrgin(System.String value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.name = value;
		}
	}


	public static UnityEngine.HideFlags GetScrollbarHideFlags_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetScrollbarHideFlags_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetScrollbarHideFlags_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetScrollbarHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			scrollbar.hideFlags = value;
		}
	}

	public static void SetScrollbarHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			scrollbar.hideFlags = value;
		}
	}

	public static void SetScrollbarHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			scrollbar.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		Scrollbar scrollbar = GetScrollbarByName(name);
		if(scrollbar != null)
		{
			return scrollbar.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		Scrollbar scrollbar = GetScrollbarByPath(path);
		if(scrollbar != null)
		{
			return scrollbar.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		Scrollbar scrollbar = GetScrollbarByOrgin(parentName, path);
		if(scrollbar != null)
		{
			return scrollbar.GetType();
		}

		return null;
	}


}

