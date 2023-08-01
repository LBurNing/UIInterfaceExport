using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UISelectableHelper
{
	public static Selectable GetSelectableByName(string name)
	{
		return UIManager.GetComponentByName<Selectable>(name);
	}

	public static Selectable GetSelectableByPath(string path)
	{
		return UIManager.GetComponentByPath<Selectable>(path);
	}

	public static Selectable GetSelectableByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<Selectable>(parentName, path);
	}

	public static UnityEngine.UI.Navigation GetSelectableNavigation_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetSelectableNavigation_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetSelectableNavigation_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}


	public static void SetSelectableNavigation_ByName(UnityEngine.UI.Navigation value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.navigation = value;
		}
	}

	public static void SetSelectableNavigation_ByPath(UnityEngine.UI.Navigation value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.navigation = value;
		}
	}

	public static void SetSelectableNavigation_ByOrgin(UnityEngine.UI.Navigation value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.navigation = value;
		}
	}


	public static UnityEngine.UI.Selectable.Transition GetSelectableTransition_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetSelectableTransition_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetSelectableTransition_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}


	public static void SetSelectableTransition_ByName(UnityEngine.UI.Selectable.Transition value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.transition = value;
		}
	}

	public static void SetSelectableTransition_ByPath(UnityEngine.UI.Selectable.Transition value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.transition = value;
		}
	}

	public static void SetSelectableTransition_ByOrgin(UnityEngine.UI.Selectable.Transition value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.transition = value;
		}
	}


	public static UnityEngine.UI.ColorBlock GetSelectableColors_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetSelectableColors_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetSelectableColors_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}


	public static void SetSelectableColors_ByName(UnityEngine.UI.ColorBlock value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.colors = value;
		}
	}

	public static void SetSelectableColors_ByPath(UnityEngine.UI.ColorBlock value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.colors = value;
		}
	}

	public static void SetSelectableColors_ByOrgin(UnityEngine.UI.ColorBlock value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.colors = value;
		}
	}


	public static UnityEngine.UI.SpriteState GetSelectableSpriteState_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetSelectableSpriteState_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetSelectableSpriteState_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}


	public static void SetSelectableSpriteState_ByName(UnityEngine.UI.SpriteState value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.spriteState = value;
		}
	}

	public static void SetSelectableSpriteState_ByPath(UnityEngine.UI.SpriteState value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.spriteState = value;
		}
	}

	public static void SetSelectableSpriteState_ByOrgin(UnityEngine.UI.SpriteState value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.spriteState = value;
		}
	}


	public static UnityEngine.UI.AnimationTriggers GetSelectableAnimationTriggers_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetSelectableAnimationTriggers_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetSelectableAnimationTriggers_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.animationTriggers;
		}

		return null;
	}


	public static void SetSelectableAnimationTriggers_ByName(UnityEngine.UI.AnimationTriggers value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.animationTriggers = value;
		}
	}

	public static void SetSelectableAnimationTriggers_ByPath(UnityEngine.UI.AnimationTriggers value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.animationTriggers = value;
		}
	}

	public static void SetSelectableAnimationTriggers_ByOrgin(UnityEngine.UI.AnimationTriggers value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.animationTriggers = value;
		}
	}


	public static UnityEngine.UI.Graphic GetSelectableTargetGraphic_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetSelectableTargetGraphic_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetSelectableTargetGraphic_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.targetGraphic;
		}

		return null;
	}


	public static void SetSelectableTargetGraphic_ByName(UnityEngine.UI.Graphic value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.targetGraphic = value;
		}
	}

	public static void SetSelectableTargetGraphic_ByPath(UnityEngine.UI.Graphic value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.targetGraphic = value;
		}
	}

	public static void SetSelectableTargetGraphic_ByOrgin(UnityEngine.UI.Graphic value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.targetGraphic = value;
		}
	}


	public static System.Boolean GetSelectableInteractable_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSelectableInteractable_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSelectableInteractable_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.interactable;
		}

		return default(System.Boolean);
	}


	public static void SetSelectableInteractable_ByName(System.Boolean value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.interactable = value;
		}
	}

	public static void SetSelectableInteractable_ByPath(System.Boolean value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.interactable = value;
		}
	}

	public static void SetSelectableInteractable_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.interactable = value;
		}
	}


	public static UnityEngine.UI.Image GetSelectableImage_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetSelectableImage_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetSelectableImage_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.image;
		}

		return null;
	}


	public static void SetSelectableImage_ByName(UnityEngine.UI.Image value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.image = value;
		}
	}

	public static void SetSelectableImage_ByPath(UnityEngine.UI.Image value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.image = value;
		}
	}

	public static void SetSelectableImage_ByOrgin(UnityEngine.UI.Image value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.image = value;
		}
	}


	public static UnityEngine.Animator GetSelectableAnimator_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetSelectableAnimator_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetSelectableAnimator_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.animator;
		}

		return null;
	}


	public static System.Boolean IsInteractable_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.IsInteractable();
		}

		return default(System.Boolean);
	}


	public static UnityEngine.UI.Selectable FindSelectable_ByName(UnityEngine.Vector3 dir, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByPath(UnityEngine.Vector3 dir, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByOrgin(UnityEngine.Vector3 dir, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.FindSelectable(dir);
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.FindSelectableOnLeft();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.FindSelectableOnRight();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.FindSelectableOnUp();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.FindSelectableOnDown();
		}

		return null;
	}


	public static void OnMove_ByName(UnityEngine.EventSystems.AxisEventData eventData, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.OnMove(eventData);
		}
	}

	public static void OnMove_ByPath(UnityEngine.EventSystems.AxisEventData eventData, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.OnMove(eventData);
		}
	}

	public static void OnMove_ByOrgin(UnityEngine.EventSystems.AxisEventData eventData, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.OnMove(eventData);
		}
	}


	public static void OnPointerDown_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.OnPointerDown(eventData);
		}
	}


	public static void OnPointerUp_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.OnPointerUp(eventData);
		}
	}


	public static void OnPointerEnter_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.OnPointerEnter(eventData);
		}
	}


	public static void OnPointerExit_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.OnPointerExit(eventData);
		}
	}


	public static void OnSelect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.OnSelect(eventData);
		}
	}


	public static void OnDeselect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.OnDeselect(eventData);
		}
	}


	public static void Select_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.Select();
		}
	}

	public static void Select_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.Select();
		}
	}

	public static void Select_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.Select();
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.StopAllCoroutines();
		}
	}


	public static System.Boolean GetSelectableUseGUILayout_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSelectableUseGUILayout_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSelectableUseGUILayout_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetSelectableUseGUILayout_ByName(System.Boolean value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.useGUILayout = value;
		}
	}

	public static void SetSelectableUseGUILayout_ByPath(System.Boolean value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.useGUILayout = value;
		}
	}

	public static void SetSelectableUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.useGUILayout = value;
		}
	}


	public static System.Boolean GetSelectableRunInEditMode_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSelectableRunInEditMode_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSelectableRunInEditMode_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetSelectableRunInEditMode_ByName(System.Boolean value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.runInEditMode = value;
		}
	}

	public static void SetSelectableRunInEditMode_ByPath(System.Boolean value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.runInEditMode = value;
		}
	}

	public static void SetSelectableRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.runInEditMode = value;
		}
	}


	public static System.Boolean GetSelectableEnabled_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSelectableEnabled_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSelectableEnabled_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetSelectableEnabled_ByName(System.Boolean value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.enabled = value;
		}
	}

	public static void SetSelectableEnabled_ByPath(System.Boolean value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.enabled = value;
		}
	}

	public static void SetSelectableEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.enabled = value;
		}
	}


	public static System.Boolean GetSelectableIsActiveAndEnabled_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSelectableIsActiveAndEnabled_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetSelectableIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetSelectableTransform_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetSelectableTransform_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetSelectableTransform_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetSelectableGameObject_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetSelectableGameObject_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetSelectableGameObject_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.GetComponents(type, results);
		}
	}


	public static System.String GetSelectableTag_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.tag;
		}

		return null;
	}

	public static System.String GetSelectableTag_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.tag;
		}

		return null;
	}

	public static System.String GetSelectableTag_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.tag;
		}

		return null;
	}


	public static void SetSelectableTag_ByName(System.String value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.tag = value;
		}
	}

	public static void SetSelectableTag_ByPath(System.String value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.tag = value;
		}
	}

	public static void SetSelectableTag_ByOrgin(System.String value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetSelectableName_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.name;
		}

		return null;
	}

	public static System.String GetSelectableName_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.name;
		}

		return null;
	}

	public static System.String GetSelectableName_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.name;
		}

		return null;
	}


	public static void SetSelectableName_ByName(System.String value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.name = value;
		}
	}

	public static void SetSelectableName_ByPath(System.String value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.name = value;
		}
	}

	public static void SetSelectableName_ByOrgin(System.String value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.name = value;
		}
	}


	public static UnityEngine.HideFlags GetSelectableHideFlags_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetSelectableHideFlags_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetSelectableHideFlags_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetSelectableHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			selectable.hideFlags = value;
		}
	}

	public static void SetSelectableHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			selectable.hideFlags = value;
		}
	}

	public static void SetSelectableHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			selectable.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		Selectable selectable = GetSelectableByName(name);
		if(selectable != null)
		{
			return selectable.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		Selectable selectable = GetSelectableByPath(path);
		if(selectable != null)
		{
			return selectable.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		Selectable selectable = GetSelectableByOrgin(parentName, path);
		if(selectable != null)
		{
			return selectable.GetType();
		}

		return null;
	}


}

