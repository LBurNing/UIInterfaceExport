using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UISliderHelper
{
	public static Slider GetSliderByName(string name)
	{
		return UIManager.GetComponentByName<Slider>(name);
	}

	public static Slider GetSliderByPath(string path)
	{
		return UIManager.GetComponentByPath<Slider>(path);
	}

	public static Slider GetSliderByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<Slider>(parentName, path);
	}

	public static UnityEngine.RectTransform GetSliderFillRect_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.fillRect;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetSliderFillRect_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.fillRect;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetSliderFillRect_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.fillRect;
		}

		return null;
	}


	public static void SetSliderFillRect_ByName(UnityEngine.RectTransform value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.fillRect = value;
		}
	}

	public static void SetSliderFillRect_ByPath(UnityEngine.RectTransform value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.fillRect = value;
		}
	}

	public static void SetSliderFillRect_ByOrgin(UnityEngine.RectTransform value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.fillRect = value;
		}
	}


	public static UnityEngine.RectTransform GetSliderHandleRect_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.handleRect;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetSliderHandleRect_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.handleRect;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetSliderHandleRect_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.handleRect;
		}

		return null;
	}


	public static void SetSliderHandleRect_ByName(UnityEngine.RectTransform value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.handleRect = value;
		}
	}

	public static void SetSliderHandleRect_ByPath(UnityEngine.RectTransform value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.handleRect = value;
		}
	}

	public static void SetSliderHandleRect_ByOrgin(UnityEngine.RectTransform value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.handleRect = value;
		}
	}


	public static UnityEngine.UI.Slider.Direction GetSliderDirection_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.direction;
		}

		return default(UnityEngine.UI.Slider.Direction);
	}

	public static UnityEngine.UI.Slider.Direction GetSliderDirection_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.direction;
		}

		return default(UnityEngine.UI.Slider.Direction);
	}

	public static UnityEngine.UI.Slider.Direction GetSliderDirection_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.direction;
		}

		return default(UnityEngine.UI.Slider.Direction);
	}


	public static void SetSliderDirection_ByName(UnityEngine.UI.Slider.Direction value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.direction = value;
		}
	}

	public static void SetSliderDirection_ByPath(UnityEngine.UI.Slider.Direction value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.direction = value;
		}
	}

	public static void SetSliderDirection_ByOrgin(UnityEngine.UI.Slider.Direction value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.direction = value;
		}
	}


	public static System.Single GetSliderMinValue_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.minValue;
		}

		return default(System.Single);
	}

	public static System.Single GetSliderMinValue_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.minValue;
		}

		return default(System.Single);
	}

	public static System.Single GetSliderMinValue_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.minValue;
		}

		return default(System.Single);
	}


	public static void SetSliderMinValue_ByName(System.Single value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.minValue = value;
		}
	}

	public static void SetSliderMinValue_ByPath(System.Single value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.minValue = value;
		}
	}

	public static void SetSliderMinValue_ByOrgin(System.Single value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.minValue = value;
		}
	}


	public static System.Single GetSliderMaxValue_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.maxValue;
		}

		return default(System.Single);
	}

	public static System.Single GetSliderMaxValue_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.maxValue;
		}

		return default(System.Single);
	}

	public static System.Single GetSliderMaxValue_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.maxValue;
		}

		return default(System.Single);
	}


	public static void SetSliderMaxValue_ByName(System.Single value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.maxValue = value;
		}
	}

	public static void SetSliderMaxValue_ByPath(System.Single value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.maxValue = value;
		}
	}

	public static void SetSliderMaxValue_ByOrgin(System.Single value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.maxValue = value;
		}
	}


	public static System.Boolean GetSliderWholeNumbers_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.wholeNumbers;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSliderWholeNumbers_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.wholeNumbers;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSliderWholeNumbers_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.wholeNumbers;
		}

		return default(System.Boolean);
	}


	public static void SetSliderWholeNumbers_ByName(System.Boolean value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.wholeNumbers = value;
		}
	}

	public static void SetSliderWholeNumbers_ByPath(System.Boolean value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.wholeNumbers = value;
		}
	}

	public static void SetSliderWholeNumbers_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.wholeNumbers = value;
		}
	}


	public static System.Single GetSliderValue_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.value;
		}

		return default(System.Single);
	}

	public static System.Single GetSliderValue_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.value;
		}

		return default(System.Single);
	}

	public static System.Single GetSliderValue_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.value;
		}

		return default(System.Single);
	}


	public static void SetSliderValue_ByName(System.Single value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.value = value;
		}
	}

	public static void SetSliderValue_ByPath(System.Single value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.value = value;
		}
	}

	public static void SetSliderValue_ByOrgin(System.Single value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.value = value;
		}
	}


	public static void SetValueWithoutNotify_ByName(System.Single input, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.SetValueWithoutNotify(input);
		}
	}

	public static void SetValueWithoutNotify_ByPath(System.Single input, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.SetValueWithoutNotify(input);
		}
	}

	public static void SetValueWithoutNotify_ByOrgin(System.Single input, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.SetValueWithoutNotify(input);
		}
	}


	public static System.Single GetSliderNormalizedValue_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.normalizedValue;
		}

		return default(System.Single);
	}

	public static System.Single GetSliderNormalizedValue_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.normalizedValue;
		}

		return default(System.Single);
	}

	public static System.Single GetSliderNormalizedValue_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.normalizedValue;
		}

		return default(System.Single);
	}


	public static void SetSliderNormalizedValue_ByName(System.Single value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.normalizedValue = value;
		}
	}

	public static void SetSliderNormalizedValue_ByPath(System.Single value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.normalizedValue = value;
		}
	}

	public static void SetSliderNormalizedValue_ByOrgin(System.Single value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.normalizedValue = value;
		}
	}


	public static UnityEngine.UI.Slider.SliderEvent GetSliderOnValueChanged_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.onValueChanged;
		}

		return null;
	}

	public static UnityEngine.UI.Slider.SliderEvent GetSliderOnValueChanged_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.onValueChanged;
		}

		return null;
	}

	public static UnityEngine.UI.Slider.SliderEvent GetSliderOnValueChanged_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.onValueChanged;
		}

		return null;
	}


	public static void SetSliderOnValueChanged_ByName(UnityEngine.UI.Slider.SliderEvent value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.onValueChanged = value;
		}
	}

	public static void SetSliderOnValueChanged_ByPath(UnityEngine.UI.Slider.SliderEvent value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.onValueChanged = value;
		}
	}

	public static void SetSliderOnValueChanged_ByOrgin(UnityEngine.UI.Slider.SliderEvent value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.onValueChanged = value;
		}
	}


	public static void Rebuild_ByName(UnityEngine.UI.CanvasUpdate executing, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.Rebuild(executing);
		}
	}

	public static void Rebuild_ByPath(UnityEngine.UI.CanvasUpdate executing, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.Rebuild(executing);
		}
	}

	public static void Rebuild_ByOrgin(UnityEngine.UI.CanvasUpdate executing, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.Rebuild(executing);
		}
	}


	public static void LayoutComplete_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.LayoutComplete();
		}
	}


	public static void GraphicUpdateComplete_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.GraphicUpdateComplete();
		}
	}


	public static void OnPointerDown_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.OnPointerDown(eventData);
		}
	}


	public static void OnDrag_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.OnDrag(eventData);
		}
	}

	public static void OnDrag_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.OnDrag(eventData);
		}
	}

	public static void OnDrag_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.OnDrag(eventData);
		}
	}


	public static void OnMove_ByName(UnityEngine.EventSystems.AxisEventData eventData, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.OnMove(eventData);
		}
	}

	public static void OnMove_ByPath(UnityEngine.EventSystems.AxisEventData eventData, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.OnMove(eventData);
		}
	}

	public static void OnMove_ByOrgin(UnityEngine.EventSystems.AxisEventData eventData, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.OnMove(eventData);
		}
	}


	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.FindSelectableOnLeft();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.FindSelectableOnRight();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.FindSelectableOnUp();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.FindSelectableOnDown();
		}

		return null;
	}


	public static void OnInitializePotentialDrag_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.OnInitializePotentialDrag(eventData);
		}
	}

	public static void OnInitializePotentialDrag_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.OnInitializePotentialDrag(eventData);
		}
	}

	public static void OnInitializePotentialDrag_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.OnInitializePotentialDrag(eventData);
		}
	}


	public static void SetDirection_ByName(UnityEngine.UI.Slider.Direction direction, System.Boolean includeRectLayouts, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.SetDirection(direction, includeRectLayouts);
		}
	}

	public static void SetDirection_ByPath(UnityEngine.UI.Slider.Direction direction, System.Boolean includeRectLayouts, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.SetDirection(direction, includeRectLayouts);
		}
	}

	public static void SetDirection_ByOrgin(UnityEngine.UI.Slider.Direction direction, System.Boolean includeRectLayouts, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.SetDirection(direction, includeRectLayouts);
		}
	}


	public static UnityEngine.UI.Navigation GetSliderNavigation_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetSliderNavigation_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetSliderNavigation_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}


	public static void SetSliderNavigation_ByName(UnityEngine.UI.Navigation value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.navigation = value;
		}
	}

	public static void SetSliderNavigation_ByPath(UnityEngine.UI.Navigation value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.navigation = value;
		}
	}

	public static void SetSliderNavigation_ByOrgin(UnityEngine.UI.Navigation value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.navigation = value;
		}
	}


	public static UnityEngine.UI.Selectable.Transition GetSliderTransition_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetSliderTransition_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetSliderTransition_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}


	public static void SetSliderTransition_ByName(UnityEngine.UI.Selectable.Transition value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.transition = value;
		}
	}

	public static void SetSliderTransition_ByPath(UnityEngine.UI.Selectable.Transition value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.transition = value;
		}
	}

	public static void SetSliderTransition_ByOrgin(UnityEngine.UI.Selectable.Transition value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.transition = value;
		}
	}


	public static UnityEngine.UI.ColorBlock GetSliderColors_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetSliderColors_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetSliderColors_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}


	public static void SetSliderColors_ByName(UnityEngine.UI.ColorBlock value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.colors = value;
		}
	}

	public static void SetSliderColors_ByPath(UnityEngine.UI.ColorBlock value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.colors = value;
		}
	}

	public static void SetSliderColors_ByOrgin(UnityEngine.UI.ColorBlock value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.colors = value;
		}
	}


	public static UnityEngine.UI.SpriteState GetSliderSpriteState_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetSliderSpriteState_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetSliderSpriteState_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}


	public static void SetSliderSpriteState_ByName(UnityEngine.UI.SpriteState value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.spriteState = value;
		}
	}

	public static void SetSliderSpriteState_ByPath(UnityEngine.UI.SpriteState value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.spriteState = value;
		}
	}

	public static void SetSliderSpriteState_ByOrgin(UnityEngine.UI.SpriteState value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.spriteState = value;
		}
	}


	public static UnityEngine.UI.AnimationTriggers GetSliderAnimationTriggers_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetSliderAnimationTriggers_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetSliderAnimationTriggers_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.animationTriggers;
		}

		return null;
	}


	public static void SetSliderAnimationTriggers_ByName(UnityEngine.UI.AnimationTriggers value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.animationTriggers = value;
		}
	}

	public static void SetSliderAnimationTriggers_ByPath(UnityEngine.UI.AnimationTriggers value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.animationTriggers = value;
		}
	}

	public static void SetSliderAnimationTriggers_ByOrgin(UnityEngine.UI.AnimationTriggers value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.animationTriggers = value;
		}
	}


	public static UnityEngine.UI.Graphic GetSliderTargetGraphic_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetSliderTargetGraphic_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetSliderTargetGraphic_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.targetGraphic;
		}

		return null;
	}


	public static void SetSliderTargetGraphic_ByName(UnityEngine.UI.Graphic value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.targetGraphic = value;
		}
	}

	public static void SetSliderTargetGraphic_ByPath(UnityEngine.UI.Graphic value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.targetGraphic = value;
		}
	}

	public static void SetSliderTargetGraphic_ByOrgin(UnityEngine.UI.Graphic value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.targetGraphic = value;
		}
	}


	public static System.Boolean GetSliderInteractable_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSliderInteractable_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSliderInteractable_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.interactable;
		}

		return default(System.Boolean);
	}


	public static void SetSliderInteractable_ByName(System.Boolean value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.interactable = value;
		}
	}

	public static void SetSliderInteractable_ByPath(System.Boolean value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.interactable = value;
		}
	}

	public static void SetSliderInteractable_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.interactable = value;
		}
	}


	public static UnityEngine.UI.Image GetSliderImage_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetSliderImage_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetSliderImage_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.image;
		}

		return null;
	}


	public static void SetSliderImage_ByName(UnityEngine.UI.Image value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.image = value;
		}
	}

	public static void SetSliderImage_ByPath(UnityEngine.UI.Image value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.image = value;
		}
	}

	public static void SetSliderImage_ByOrgin(UnityEngine.UI.Image value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.image = value;
		}
	}


	public static UnityEngine.Animator GetSliderAnimator_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetSliderAnimator_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetSliderAnimator_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.animator;
		}

		return null;
	}


	public static System.Boolean IsInteractable_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.IsInteractable();
		}

		return default(System.Boolean);
	}


	public static UnityEngine.UI.Selectable FindSelectable_ByName(UnityEngine.Vector3 dir, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByPath(UnityEngine.Vector3 dir, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByOrgin(UnityEngine.Vector3 dir, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.FindSelectable(dir);
		}

		return null;
	}


	public static void OnPointerUp_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.OnPointerUp(eventData);
		}
	}


	public static void OnPointerEnter_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.OnPointerEnter(eventData);
		}
	}


	public static void OnPointerExit_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.OnPointerExit(eventData);
		}
	}


	public static void OnSelect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.OnSelect(eventData);
		}
	}


	public static void OnDeselect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.OnDeselect(eventData);
		}
	}


	public static void Select_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.Select();
		}
	}

	public static void Select_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.Select();
		}
	}

	public static void Select_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.Select();
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.StopAllCoroutines();
		}
	}


	public static System.Boolean GetSliderUseGUILayout_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSliderUseGUILayout_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSliderUseGUILayout_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetSliderUseGUILayout_ByName(System.Boolean value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.useGUILayout = value;
		}
	}

	public static void SetSliderUseGUILayout_ByPath(System.Boolean value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.useGUILayout = value;
		}
	}

	public static void SetSliderUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.useGUILayout = value;
		}
	}


	public static System.Boolean GetSliderRunInEditMode_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSliderRunInEditMode_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSliderRunInEditMode_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetSliderRunInEditMode_ByName(System.Boolean value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.runInEditMode = value;
		}
	}

	public static void SetSliderRunInEditMode_ByPath(System.Boolean value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.runInEditMode = value;
		}
	}

	public static void SetSliderRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.runInEditMode = value;
		}
	}


	public static System.Boolean GetSliderEnabled_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSliderEnabled_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSliderEnabled_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetSliderEnabled_ByName(System.Boolean value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.enabled = value;
		}
	}

	public static void SetSliderEnabled_ByPath(System.Boolean value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.enabled = value;
		}
	}

	public static void SetSliderEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.enabled = value;
		}
	}


	public static System.Boolean GetSliderIsActiveAndEnabled_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSliderIsActiveAndEnabled_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSliderIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetSliderTransform_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetSliderTransform_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetSliderTransform_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetSliderGameObject_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetSliderGameObject_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetSliderGameObject_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.GetComponents(type, results);
		}
	}


	public static System.String GetSliderTag_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.tag;
		}

		return null;
	}

	public static System.String GetSliderTag_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.tag;
		}

		return null;
	}

	public static System.String GetSliderTag_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.tag;
		}

		return null;
	}


	public static void SetSliderTag_ByName(System.String value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.tag = value;
		}
	}

	public static void SetSliderTag_ByPath(System.String value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.tag = value;
		}
	}

	public static void SetSliderTag_ByOrgin(System.String value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetSliderName_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.name;
		}

		return null;
	}

	public static System.String GetSliderName_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.name;
		}

		return null;
	}

	public static System.String GetSliderName_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.name;
		}

		return null;
	}


	public static void SetSliderName_ByName(System.String value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.name = value;
		}
	}

	public static void SetSliderName_ByPath(System.String value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.name = value;
		}
	}

	public static void SetSliderName_ByOrgin(System.String value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.name = value;
		}
	}


	public static UnityEngine.HideFlags GetSliderHideFlags_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetSliderHideFlags_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetSliderHideFlags_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetSliderHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			slider.hideFlags = value;
		}
	}

	public static void SetSliderHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			slider.hideFlags = value;
		}
	}

	public static void SetSliderHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			slider.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		Slider slider = GetSliderByName(name);
		if(slider != null)
		{
			return slider.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		Slider slider = GetSliderByPath(path);
		if(slider != null)
		{
			return slider.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		Slider slider = GetSliderByOrgin(parentName, path);
		if(slider != null)
		{
			return slider.GetType();
		}

		return null;
	}


}

