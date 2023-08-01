using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIToggleHelper
{
	public static Toggle GetToggleByName(string name)
	{
		return UIManager.GetComponentByName<Toggle>(name);
	}

	public static Toggle GetToggleByPath(string path)
	{
		return UIManager.GetComponentByPath<Toggle>(path);
	}

	public static Toggle GetToggleByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<Toggle>(parentName, path);
	}

	public static UnityEngine.UI.ToggleGroup GetToggleGroup_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.group;
		}

		return null;
	}

	public static UnityEngine.UI.ToggleGroup GetToggleGroup_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.group;
		}

		return null;
	}

	public static UnityEngine.UI.ToggleGroup GetToggleGroup_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.group;
		}

		return null;
	}


	public static void SetToggleGroup_ByName(UnityEngine.UI.ToggleGroup value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.group = value;
		}
	}

	public static void SetToggleGroup_ByPath(UnityEngine.UI.ToggleGroup value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.group = value;
		}
	}

	public static void SetToggleGroup_ByOrgin(UnityEngine.UI.ToggleGroup value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.group = value;
		}
	}


	public static void Rebuild_ByName(UnityEngine.UI.CanvasUpdate executing, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.Rebuild(executing);
		}
	}

	public static void Rebuild_ByPath(UnityEngine.UI.CanvasUpdate executing, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.Rebuild(executing);
		}
	}

	public static void Rebuild_ByOrgin(UnityEngine.UI.CanvasUpdate executing, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.Rebuild(executing);
		}
	}


	public static void LayoutComplete_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.LayoutComplete();
		}
	}


	public static void GraphicUpdateComplete_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.GraphicUpdateComplete();
		}
	}


	public static System.Boolean GetToggleIsOn_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.isOn;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleIsOn_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.isOn;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleIsOn_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.isOn;
		}

		return default(System.Boolean);
	}


	public static void SetToggleIsOn_ByName(System.Boolean value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.isOn = value;
		}
	}

	public static void SetToggleIsOn_ByPath(System.Boolean value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.isOn = value;
		}
	}

	public static void SetToggleIsOn_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.isOn = value;
		}
	}


	public static void SetIsOnWithoutNotify_ByName(System.Boolean value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.SetIsOnWithoutNotify(value);
		}
	}

	public static void SetIsOnWithoutNotify_ByPath(System.Boolean value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.SetIsOnWithoutNotify(value);
		}
	}

	public static void SetIsOnWithoutNotify_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.SetIsOnWithoutNotify(value);
		}
	}


	public static void OnPointerClick_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.OnPointerClick(eventData);
		}
	}

	public static void OnPointerClick_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.OnPointerClick(eventData);
		}
	}

	public static void OnPointerClick_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.OnPointerClick(eventData);
		}
	}


	public static void OnSubmit_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.OnSubmit(eventData);
		}
	}

	public static void OnSubmit_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.OnSubmit(eventData);
		}
	}

	public static void OnSubmit_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.OnSubmit(eventData);
		}
	}


	public static UnityEngine.UI.Navigation GetToggleNavigation_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetToggleNavigation_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetToggleNavigation_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}


	public static void SetToggleNavigation_ByName(UnityEngine.UI.Navigation value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.navigation = value;
		}
	}

	public static void SetToggleNavigation_ByPath(UnityEngine.UI.Navigation value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.navigation = value;
		}
	}

	public static void SetToggleNavigation_ByOrgin(UnityEngine.UI.Navigation value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.navigation = value;
		}
	}


	public static UnityEngine.UI.Selectable.Transition GetToggleTransition_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetToggleTransition_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetToggleTransition_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}


	public static void SetToggleTransition_ByName(UnityEngine.UI.Selectable.Transition value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.transition = value;
		}
	}

	public static void SetToggleTransition_ByPath(UnityEngine.UI.Selectable.Transition value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.transition = value;
		}
	}

	public static void SetToggleTransition_ByOrgin(UnityEngine.UI.Selectable.Transition value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.transition = value;
		}
	}


	public static UnityEngine.UI.ColorBlock GetToggleColors_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetToggleColors_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetToggleColors_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}


	public static void SetToggleColors_ByName(UnityEngine.UI.ColorBlock value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.colors = value;
		}
	}

	public static void SetToggleColors_ByPath(UnityEngine.UI.ColorBlock value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.colors = value;
		}
	}

	public static void SetToggleColors_ByOrgin(UnityEngine.UI.ColorBlock value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.colors = value;
		}
	}


	public static UnityEngine.UI.SpriteState GetToggleSpriteState_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetToggleSpriteState_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetToggleSpriteState_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}


	public static void SetToggleSpriteState_ByName(UnityEngine.UI.SpriteState value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.spriteState = value;
		}
	}

	public static void SetToggleSpriteState_ByPath(UnityEngine.UI.SpriteState value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.spriteState = value;
		}
	}

	public static void SetToggleSpriteState_ByOrgin(UnityEngine.UI.SpriteState value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.spriteState = value;
		}
	}


	public static UnityEngine.UI.AnimationTriggers GetToggleAnimationTriggers_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetToggleAnimationTriggers_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetToggleAnimationTriggers_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.animationTriggers;
		}

		return null;
	}


	public static void SetToggleAnimationTriggers_ByName(UnityEngine.UI.AnimationTriggers value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.animationTriggers = value;
		}
	}

	public static void SetToggleAnimationTriggers_ByPath(UnityEngine.UI.AnimationTriggers value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.animationTriggers = value;
		}
	}

	public static void SetToggleAnimationTriggers_ByOrgin(UnityEngine.UI.AnimationTriggers value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.animationTriggers = value;
		}
	}


	public static UnityEngine.UI.Graphic GetToggleTargetGraphic_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetToggleTargetGraphic_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetToggleTargetGraphic_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.targetGraphic;
		}

		return null;
	}


	public static void SetToggleTargetGraphic_ByName(UnityEngine.UI.Graphic value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.targetGraphic = value;
		}
	}

	public static void SetToggleTargetGraphic_ByPath(UnityEngine.UI.Graphic value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.targetGraphic = value;
		}
	}

	public static void SetToggleTargetGraphic_ByOrgin(UnityEngine.UI.Graphic value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.targetGraphic = value;
		}
	}


	public static System.Boolean GetToggleInteractable_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleInteractable_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleInteractable_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.interactable;
		}

		return default(System.Boolean);
	}


	public static void SetToggleInteractable_ByName(System.Boolean value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.interactable = value;
		}
	}

	public static void SetToggleInteractable_ByPath(System.Boolean value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.interactable = value;
		}
	}

	public static void SetToggleInteractable_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.interactable = value;
		}
	}


	public static UnityEngine.UI.Image GetToggleImage_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetToggleImage_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetToggleImage_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.image;
		}

		return null;
	}


	public static void SetToggleImage_ByName(UnityEngine.UI.Image value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.image = value;
		}
	}

	public static void SetToggleImage_ByPath(UnityEngine.UI.Image value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.image = value;
		}
	}

	public static void SetToggleImage_ByOrgin(UnityEngine.UI.Image value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.image = value;
		}
	}


	public static UnityEngine.Animator GetToggleAnimator_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetToggleAnimator_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetToggleAnimator_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.animator;
		}

		return null;
	}


	public static System.Boolean IsInteractable_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.IsInteractable();
		}

		return default(System.Boolean);
	}


	public static UnityEngine.UI.Selectable FindSelectable_ByName(UnityEngine.Vector3 dir, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByPath(UnityEngine.Vector3 dir, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByOrgin(UnityEngine.Vector3 dir, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.FindSelectable(dir);
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.FindSelectableOnLeft();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.FindSelectableOnRight();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.FindSelectableOnUp();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.FindSelectableOnDown();
		}

		return null;
	}


	public static void OnMove_ByName(UnityEngine.EventSystems.AxisEventData eventData, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.OnMove(eventData);
		}
	}

	public static void OnMove_ByPath(UnityEngine.EventSystems.AxisEventData eventData, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.OnMove(eventData);
		}
	}

	public static void OnMove_ByOrgin(UnityEngine.EventSystems.AxisEventData eventData, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.OnMove(eventData);
		}
	}


	public static void OnPointerDown_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.OnPointerDown(eventData);
		}
	}


	public static void OnPointerUp_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.OnPointerUp(eventData);
		}
	}


	public static void OnPointerEnter_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.OnPointerEnter(eventData);
		}
	}


	public static void OnPointerExit_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.OnPointerExit(eventData);
		}
	}


	public static void OnSelect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.OnSelect(eventData);
		}
	}


	public static void OnDeselect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.OnDeselect(eventData);
		}
	}


	public static void Select_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.Select();
		}
	}

	public static void Select_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.Select();
		}
	}

	public static void Select_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.Select();
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.StopAllCoroutines();
		}
	}


	public static System.Boolean GetToggleUseGUILayout_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleUseGUILayout_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleUseGUILayout_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetToggleUseGUILayout_ByName(System.Boolean value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.useGUILayout = value;
		}
	}

	public static void SetToggleUseGUILayout_ByPath(System.Boolean value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.useGUILayout = value;
		}
	}

	public static void SetToggleUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.useGUILayout = value;
		}
	}


	public static System.Boolean GetToggleRunInEditMode_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleRunInEditMode_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleRunInEditMode_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetToggleRunInEditMode_ByName(System.Boolean value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.runInEditMode = value;
		}
	}

	public static void SetToggleRunInEditMode_ByPath(System.Boolean value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.runInEditMode = value;
		}
	}

	public static void SetToggleRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.runInEditMode = value;
		}
	}


	public static System.Boolean GetToggleEnabled_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleEnabled_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleEnabled_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetToggleEnabled_ByName(System.Boolean value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.enabled = value;
		}
	}

	public static void SetToggleEnabled_ByPath(System.Boolean value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.enabled = value;
		}
	}

	public static void SetToggleEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.enabled = value;
		}
	}


	public static System.Boolean GetToggleIsActiveAndEnabled_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleIsActiveAndEnabled_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetToggleIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetToggleTransform_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetToggleTransform_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetToggleTransform_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetToggleGameObject_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetToggleGameObject_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetToggleGameObject_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.GetComponents(type, results);
		}
	}


	public static System.String GetToggleTag_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.tag;
		}

		return null;
	}

	public static System.String GetToggleTag_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.tag;
		}

		return null;
	}

	public static System.String GetToggleTag_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.tag;
		}

		return null;
	}


	public static void SetToggleTag_ByName(System.String value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.tag = value;
		}
	}

	public static void SetToggleTag_ByPath(System.String value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.tag = value;
		}
	}

	public static void SetToggleTag_ByOrgin(System.String value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetToggleName_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.name;
		}

		return null;
	}

	public static System.String GetToggleName_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.name;
		}

		return null;
	}

	public static System.String GetToggleName_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.name;
		}

		return null;
	}


	public static void SetToggleName_ByName(System.String value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.name = value;
		}
	}

	public static void SetToggleName_ByPath(System.String value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.name = value;
		}
	}

	public static void SetToggleName_ByOrgin(System.String value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.name = value;
		}
	}


	public static UnityEngine.HideFlags GetToggleHideFlags_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetToggleHideFlags_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetToggleHideFlags_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetToggleHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			toggle.hideFlags = value;
		}
	}

	public static void SetToggleHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			toggle.hideFlags = value;
		}
	}

	public static void SetToggleHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			toggle.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		Toggle toggle = GetToggleByName(name);
		if(toggle != null)
		{
			return toggle.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		Toggle toggle = GetToggleByPath(path);
		if(toggle != null)
		{
			return toggle.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		Toggle toggle = GetToggleByOrgin(parentName, path);
		if(toggle != null)
		{
			return toggle.GetType();
		}

		return null;
	}


}

