using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIButtonHelper
{
	public static Button GetButtonByName(string name)
	{
		return UIManager.GetComponentByName<Button>(name);
	}

	public static Button GetButtonByPath(string path)
	{
		return UIManager.GetComponentByPath<Button>(path);
	}

	public static Button GetButtonByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<Button>(parentName, path);
	}

	public static UnityEngine.UI.Button.ButtonClickedEvent GetButtonOnClick_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.onClick;
		}

		return null;
	}

	public static UnityEngine.UI.Button.ButtonClickedEvent GetButtonOnClick_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.onClick;
		}

		return null;
	}

	public static UnityEngine.UI.Button.ButtonClickedEvent GetButtonOnClick_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.onClick;
		}

		return null;
	}


	public static void SetButtonOnClick_ByName(UnityEngine.UI.Button.ButtonClickedEvent value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.onClick = value;
		}
	}

	public static void SetButtonOnClick_ByPath(UnityEngine.UI.Button.ButtonClickedEvent value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.onClick = value;
		}
	}

	public static void SetButtonOnClick_ByOrgin(UnityEngine.UI.Button.ButtonClickedEvent value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.onClick = value;
		}
	}


	public static void OnPointerClick_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.OnPointerClick(eventData);
		}
	}

	public static void OnPointerClick_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.OnPointerClick(eventData);
		}
	}

	public static void OnPointerClick_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.OnPointerClick(eventData);
		}
	}


	public static void OnSubmit_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.OnSubmit(eventData);
		}
	}

	public static void OnSubmit_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.OnSubmit(eventData);
		}
	}

	public static void OnSubmit_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.OnSubmit(eventData);
		}
	}


	public static UnityEngine.UI.Navigation GetButtonNavigation_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetButtonNavigation_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetButtonNavigation_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}


	public static void SetButtonNavigation_ByName(UnityEngine.UI.Navigation value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.navigation = value;
		}
	}

	public static void SetButtonNavigation_ByPath(UnityEngine.UI.Navigation value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.navigation = value;
		}
	}

	public static void SetButtonNavigation_ByOrgin(UnityEngine.UI.Navigation value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.navigation = value;
		}
	}


	public static UnityEngine.UI.Selectable.Transition GetButtonTransition_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetButtonTransition_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetButtonTransition_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}


	public static void SetButtonTransition_ByName(UnityEngine.UI.Selectable.Transition value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.transition = value;
		}
	}

	public static void SetButtonTransition_ByPath(UnityEngine.UI.Selectable.Transition value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.transition = value;
		}
	}

	public static void SetButtonTransition_ByOrgin(UnityEngine.UI.Selectable.Transition value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.transition = value;
		}
	}


	public static UnityEngine.UI.ColorBlock GetButtonColors_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetButtonColors_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetButtonColors_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}


	public static void SetButtonColors_ByName(UnityEngine.UI.ColorBlock value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.colors = value;
		}
	}

	public static void SetButtonColors_ByPath(UnityEngine.UI.ColorBlock value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.colors = value;
		}
	}

	public static void SetButtonColors_ByOrgin(UnityEngine.UI.ColorBlock value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.colors = value;
		}
	}


	public static UnityEngine.UI.SpriteState GetButtonSpriteState_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetButtonSpriteState_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetButtonSpriteState_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}


	public static void SetButtonSpriteState_ByName(UnityEngine.UI.SpriteState value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.spriteState = value;
		}
	}

	public static void SetButtonSpriteState_ByPath(UnityEngine.UI.SpriteState value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.spriteState = value;
		}
	}

	public static void SetButtonSpriteState_ByOrgin(UnityEngine.UI.SpriteState value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.spriteState = value;
		}
	}


	public static UnityEngine.UI.AnimationTriggers GetButtonAnimationTriggers_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetButtonAnimationTriggers_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetButtonAnimationTriggers_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.animationTriggers;
		}

		return null;
	}


	public static void SetButtonAnimationTriggers_ByName(UnityEngine.UI.AnimationTriggers value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.animationTriggers = value;
		}
	}

	public static void SetButtonAnimationTriggers_ByPath(UnityEngine.UI.AnimationTriggers value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.animationTriggers = value;
		}
	}

	public static void SetButtonAnimationTriggers_ByOrgin(UnityEngine.UI.AnimationTriggers value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.animationTriggers = value;
		}
	}


	public static UnityEngine.UI.Graphic GetButtonTargetGraphic_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetButtonTargetGraphic_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetButtonTargetGraphic_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.targetGraphic;
		}

		return null;
	}


	public static void SetButtonTargetGraphic_ByName(UnityEngine.UI.Graphic value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.targetGraphic = value;
		}
	}

	public static void SetButtonTargetGraphic_ByPath(UnityEngine.UI.Graphic value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.targetGraphic = value;
		}
	}

	public static void SetButtonTargetGraphic_ByOrgin(UnityEngine.UI.Graphic value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.targetGraphic = value;
		}
	}


	public static System.Boolean GetButtonInteractable_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetButtonInteractable_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetButtonInteractable_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.interactable;
		}

		return default(System.Boolean);
	}


	public static void SetButtonInteractable_ByName(System.Boolean value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.interactable = value;
		}
	}

	public static void SetButtonInteractable_ByPath(System.Boolean value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.interactable = value;
		}
	}

	public static void SetButtonInteractable_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.interactable = value;
		}
	}


	public static UnityEngine.UI.Image GetButtonImage_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetButtonImage_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetButtonImage_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.image;
		}

		return null;
	}


	public static void SetButtonImage_ByName(UnityEngine.UI.Image value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.image = value;
		}
	}

	public static void SetButtonImage_ByPath(UnityEngine.UI.Image value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.image = value;
		}
	}

	public static void SetButtonImage_ByOrgin(UnityEngine.UI.Image value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.image = value;
		}
	}


	public static UnityEngine.Animator GetButtonAnimator_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetButtonAnimator_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetButtonAnimator_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.animator;
		}

		return null;
	}


	public static System.Boolean IsInteractable_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.IsInteractable();
		}

		return default(System.Boolean);
	}


	public static UnityEngine.UI.Selectable FindSelectable_ByName(UnityEngine.Vector3 dir, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByPath(UnityEngine.Vector3 dir, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByOrgin(UnityEngine.Vector3 dir, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.FindSelectable(dir);
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.FindSelectableOnLeft();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.FindSelectableOnRight();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.FindSelectableOnUp();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.FindSelectableOnDown();
		}

		return null;
	}


	public static void OnMove_ByName(UnityEngine.EventSystems.AxisEventData eventData, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.OnMove(eventData);
		}
	}

	public static void OnMove_ByPath(UnityEngine.EventSystems.AxisEventData eventData, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.OnMove(eventData);
		}
	}

	public static void OnMove_ByOrgin(UnityEngine.EventSystems.AxisEventData eventData, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.OnMove(eventData);
		}
	}


	public static void OnPointerDown_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.OnPointerDown(eventData);
		}
	}


	public static void OnPointerUp_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.OnPointerUp(eventData);
		}
	}


	public static void OnPointerEnter_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.OnPointerEnter(eventData);
		}
	}


	public static void OnPointerExit_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.OnPointerExit(eventData);
		}
	}


	public static void OnSelect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.OnSelect(eventData);
		}
	}


	public static void OnDeselect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.OnDeselect(eventData);
		}
	}


	public static void Select_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.Select();
		}
	}

	public static void Select_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.Select();
		}
	}

	public static void Select_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.Select();
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.StopAllCoroutines();
		}
	}


	public static System.Boolean GetButtonUseGUILayout_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetButtonUseGUILayout_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetButtonUseGUILayout_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetButtonUseGUILayout_ByName(System.Boolean value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.useGUILayout = value;
		}
	}

	public static void SetButtonUseGUILayout_ByPath(System.Boolean value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.useGUILayout = value;
		}
	}

	public static void SetButtonUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.useGUILayout = value;
		}
	}


	public static System.Boolean GetButtonRunInEditMode_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetButtonRunInEditMode_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetButtonRunInEditMode_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetButtonRunInEditMode_ByName(System.Boolean value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.runInEditMode = value;
		}
	}

	public static void SetButtonRunInEditMode_ByPath(System.Boolean value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.runInEditMode = value;
		}
	}

	public static void SetButtonRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.runInEditMode = value;
		}
	}


	public static System.Boolean GetButtonEnabled_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetButtonEnabled_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetButtonEnabled_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetButtonEnabled_ByName(System.Boolean value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.enabled = value;
		}
	}

	public static void SetButtonEnabled_ByPath(System.Boolean value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.enabled = value;
		}
	}

	public static void SetButtonEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.enabled = value;
		}
	}


	public static System.Boolean GetButtonIsActiveAndEnabled_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetButtonIsActiveAndEnabled_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetButtonIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetButtonTransform_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetButtonTransform_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetButtonTransform_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetButtonGameObject_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetButtonGameObject_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetButtonGameObject_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.GetComponents(type, results);
		}
	}


	public static System.String GetButtonTag_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.tag;
		}

		return null;
	}

	public static System.String GetButtonTag_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.tag;
		}

		return null;
	}

	public static System.String GetButtonTag_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.tag;
		}

		return null;
	}


	public static void SetButtonTag_ByName(System.String value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.tag = value;
		}
	}

	public static void SetButtonTag_ByPath(System.String value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.tag = value;
		}
	}

	public static void SetButtonTag_ByOrgin(System.String value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetButtonName_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.name;
		}

		return null;
	}

	public static System.String GetButtonName_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.name;
		}

		return null;
	}

	public static System.String GetButtonName_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.name;
		}

		return null;
	}


	public static void SetButtonName_ByName(System.String value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.name = value;
		}
	}

	public static void SetButtonName_ByPath(System.String value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.name = value;
		}
	}

	public static void SetButtonName_ByOrgin(System.String value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.name = value;
		}
	}


	public static UnityEngine.HideFlags GetButtonHideFlags_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetButtonHideFlags_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetButtonHideFlags_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetButtonHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			button.hideFlags = value;
		}
	}

	public static void SetButtonHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			button.hideFlags = value;
		}
	}

	public static void SetButtonHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			button.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		Button button = GetButtonByName(name);
		if(button != null)
		{
			return button.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		Button button = GetButtonByPath(path);
		if(button != null)
		{
			return button.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		Button button = GetButtonByOrgin(parentName, path);
		if(button != null)
		{
			return button.GetType();
		}

		return null;
	}


}

