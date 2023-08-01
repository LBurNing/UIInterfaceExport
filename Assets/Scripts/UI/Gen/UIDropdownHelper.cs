using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIDropdownHelper
{
	public static Dropdown GetDropdownByName(string name)
	{
		return UIManager.GetComponentByName<Dropdown>(name);
	}

	public static Dropdown GetDropdownByPath(string path)
	{
		return UIManager.GetComponentByPath<Dropdown>(path);
	}

	public static Dropdown GetDropdownByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<Dropdown>(parentName, path);
	}

	public static UnityEngine.RectTransform GetDropdownTemplate_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.template;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetDropdownTemplate_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.template;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetDropdownTemplate_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.template;
		}

		return null;
	}


	public static void SetDropdownTemplate_ByName(UnityEngine.RectTransform value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.template = value;
		}
	}

	public static void SetDropdownTemplate_ByPath(UnityEngine.RectTransform value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.template = value;
		}
	}

	public static void SetDropdownTemplate_ByOrgin(UnityEngine.RectTransform value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.template = value;
		}
	}


	public static UnityEngine.UI.Text GetDropdownCaptionText_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.captionText;
		}

		return null;
	}

	public static UnityEngine.UI.Text GetDropdownCaptionText_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.captionText;
		}

		return null;
	}

	public static UnityEngine.UI.Text GetDropdownCaptionText_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.captionText;
		}

		return null;
	}


	public static void SetDropdownCaptionText_ByName(UnityEngine.UI.Text value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.captionText = value;
		}
	}

	public static void SetDropdownCaptionText_ByPath(UnityEngine.UI.Text value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.captionText = value;
		}
	}

	public static void SetDropdownCaptionText_ByOrgin(UnityEngine.UI.Text value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.captionText = value;
		}
	}


	public static UnityEngine.UI.Image GetDropdownCaptionImage_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.captionImage;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetDropdownCaptionImage_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.captionImage;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetDropdownCaptionImage_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.captionImage;
		}

		return null;
	}


	public static void SetDropdownCaptionImage_ByName(UnityEngine.UI.Image value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.captionImage = value;
		}
	}

	public static void SetDropdownCaptionImage_ByPath(UnityEngine.UI.Image value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.captionImage = value;
		}
	}

	public static void SetDropdownCaptionImage_ByOrgin(UnityEngine.UI.Image value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.captionImage = value;
		}
	}


	public static UnityEngine.UI.Text GetDropdownItemText_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.itemText;
		}

		return null;
	}

	public static UnityEngine.UI.Text GetDropdownItemText_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.itemText;
		}

		return null;
	}

	public static UnityEngine.UI.Text GetDropdownItemText_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.itemText;
		}

		return null;
	}


	public static void SetDropdownItemText_ByName(UnityEngine.UI.Text value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.itemText = value;
		}
	}

	public static void SetDropdownItemText_ByPath(UnityEngine.UI.Text value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.itemText = value;
		}
	}

	public static void SetDropdownItemText_ByOrgin(UnityEngine.UI.Text value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.itemText = value;
		}
	}


	public static UnityEngine.UI.Image GetDropdownItemImage_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.itemImage;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetDropdownItemImage_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.itemImage;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetDropdownItemImage_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.itemImage;
		}

		return null;
	}


	public static void SetDropdownItemImage_ByName(UnityEngine.UI.Image value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.itemImage = value;
		}
	}

	public static void SetDropdownItemImage_ByPath(UnityEngine.UI.Image value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.itemImage = value;
		}
	}

	public static void SetDropdownItemImage_ByOrgin(UnityEngine.UI.Image value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.itemImage = value;
		}
	}


	public static List<UnityEngine.UI.Dropdown.OptionData>  GetDropdownOptions_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.options;
		}

		return null;
	}

	public static List<UnityEngine.UI.Dropdown.OptionData>  GetDropdownOptions_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.options;
		}

		return null;
	}

	public static List<UnityEngine.UI.Dropdown.OptionData>  GetDropdownOptions_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.options;
		}

		return null;
	}


	public static void SetDropdownOptions_ByName(List<UnityEngine.UI.Dropdown.OptionData> value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.options = value;
		}
	}

	public static void SetDropdownOptions_ByPath(List<UnityEngine.UI.Dropdown.OptionData> value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.options = value;
		}
	}

	public static void SetDropdownOptions_ByOrgin(List<UnityEngine.UI.Dropdown.OptionData> value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.options = value;
		}
	}


	public static UnityEngine.UI.Dropdown.DropdownEvent GetDropdownOnValueChanged_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.onValueChanged;
		}

		return null;
	}

	public static UnityEngine.UI.Dropdown.DropdownEvent GetDropdownOnValueChanged_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.onValueChanged;
		}

		return null;
	}

	public static UnityEngine.UI.Dropdown.DropdownEvent GetDropdownOnValueChanged_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.onValueChanged;
		}

		return null;
	}


	public static void SetDropdownOnValueChanged_ByName(UnityEngine.UI.Dropdown.DropdownEvent value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.onValueChanged = value;
		}
	}

	public static void SetDropdownOnValueChanged_ByPath(UnityEngine.UI.Dropdown.DropdownEvent value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.onValueChanged = value;
		}
	}

	public static void SetDropdownOnValueChanged_ByOrgin(UnityEngine.UI.Dropdown.DropdownEvent value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.onValueChanged = value;
		}
	}


	public static System.Single GetDropdownAlphaFadeSpeed_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.alphaFadeSpeed;
		}

		return default(System.Single);
	}

	public static System.Single GetDropdownAlphaFadeSpeed_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.alphaFadeSpeed;
		}

		return default(System.Single);
	}

	public static System.Single GetDropdownAlphaFadeSpeed_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.alphaFadeSpeed;
		}

		return default(System.Single);
	}


	public static void SetDropdownAlphaFadeSpeed_ByName(System.Single value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.alphaFadeSpeed = value;
		}
	}

	public static void SetDropdownAlphaFadeSpeed_ByPath(System.Single value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.alphaFadeSpeed = value;
		}
	}

	public static void SetDropdownAlphaFadeSpeed_ByOrgin(System.Single value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.alphaFadeSpeed = value;
		}
	}


	public static System.Int32 GetDropdownValue_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.value;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetDropdownValue_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.value;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetDropdownValue_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.value;
		}

		return default(System.Int32);
	}


	public static void SetDropdownValue_ByName(System.Int32 value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.value = value;
		}
	}

	public static void SetDropdownValue_ByPath(System.Int32 value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.value = value;
		}
	}

	public static void SetDropdownValue_ByOrgin(System.Int32 value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.value = value;
		}
	}


	public static void SetValueWithoutNotify_ByName(System.Int32 input, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.SetValueWithoutNotify(input);
		}
	}

	public static void SetValueWithoutNotify_ByPath(System.Int32 input, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.SetValueWithoutNotify(input);
		}
	}

	public static void SetValueWithoutNotify_ByOrgin(System.Int32 input, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.SetValueWithoutNotify(input);
		}
	}


	public static void RefreshShownValue_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.RefreshShownValue();
		}
	}

	public static void RefreshShownValue_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.RefreshShownValue();
		}
	}

	public static void RefreshShownValue_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.RefreshShownValue();
		}
	}


	public static void AddOptions_ByName(List<UnityEngine.UI.Dropdown.OptionData> options, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.AddOptions(options);
		}
	}

	public static void AddOptions_ByPath(List<UnityEngine.UI.Dropdown.OptionData> options, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.AddOptions(options);
		}
	}

	public static void AddOptions_ByOrgin(List<UnityEngine.UI.Dropdown.OptionData> options, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.AddOptions(options);
		}
	}


	public static void AddOptions_ByName(List<System.String> options, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.AddOptions(options);
		}
	}

	public static void AddOptions_ByPath(List<System.String> options, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.AddOptions(options);
		}
	}

	public static void AddOptions_ByOrgin(List<System.String> options, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.AddOptions(options);
		}
	}


	public static void AddOptions_ByName(List<UnityEngine.Sprite> options, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.AddOptions(options);
		}
	}

	public static void AddOptions_ByPath(List<UnityEngine.Sprite> options, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.AddOptions(options);
		}
	}

	public static void AddOptions_ByOrgin(List<UnityEngine.Sprite> options, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.AddOptions(options);
		}
	}


	public static void ClearOptions_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.ClearOptions();
		}
	}

	public static void ClearOptions_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.ClearOptions();
		}
	}

	public static void ClearOptions_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.ClearOptions();
		}
	}


	public static void OnPointerClick_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.OnPointerClick(eventData);
		}
	}

	public static void OnPointerClick_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.OnPointerClick(eventData);
		}
	}

	public static void OnPointerClick_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.OnPointerClick(eventData);
		}
	}


	public static void OnSubmit_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.OnSubmit(eventData);
		}
	}

	public static void OnSubmit_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.OnSubmit(eventData);
		}
	}

	public static void OnSubmit_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.OnSubmit(eventData);
		}
	}


	public static void OnCancel_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.OnCancel(eventData);
		}
	}

	public static void OnCancel_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.OnCancel(eventData);
		}
	}

	public static void OnCancel_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.OnCancel(eventData);
		}
	}


	public static void Show_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.Show();
		}
	}

	public static void Show_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.Show();
		}
	}

	public static void Show_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.Show();
		}
	}


	public static void Hide_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.Hide();
		}
	}

	public static void Hide_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.Hide();
		}
	}

	public static void Hide_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.Hide();
		}
	}


	public static UnityEngine.UI.Navigation GetDropdownNavigation_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetDropdownNavigation_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetDropdownNavigation_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}


	public static void SetDropdownNavigation_ByName(UnityEngine.UI.Navigation value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.navigation = value;
		}
	}

	public static void SetDropdownNavigation_ByPath(UnityEngine.UI.Navigation value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.navigation = value;
		}
	}

	public static void SetDropdownNavigation_ByOrgin(UnityEngine.UI.Navigation value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.navigation = value;
		}
	}


	public static UnityEngine.UI.Selectable.Transition GetDropdownTransition_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetDropdownTransition_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetDropdownTransition_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}


	public static void SetDropdownTransition_ByName(UnityEngine.UI.Selectable.Transition value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.transition = value;
		}
	}

	public static void SetDropdownTransition_ByPath(UnityEngine.UI.Selectable.Transition value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.transition = value;
		}
	}

	public static void SetDropdownTransition_ByOrgin(UnityEngine.UI.Selectable.Transition value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.transition = value;
		}
	}


	public static UnityEngine.UI.ColorBlock GetDropdownColors_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetDropdownColors_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetDropdownColors_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}


	public static void SetDropdownColors_ByName(UnityEngine.UI.ColorBlock value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.colors = value;
		}
	}

	public static void SetDropdownColors_ByPath(UnityEngine.UI.ColorBlock value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.colors = value;
		}
	}

	public static void SetDropdownColors_ByOrgin(UnityEngine.UI.ColorBlock value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.colors = value;
		}
	}


	public static UnityEngine.UI.SpriteState GetDropdownSpriteState_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetDropdownSpriteState_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetDropdownSpriteState_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}


	public static void SetDropdownSpriteState_ByName(UnityEngine.UI.SpriteState value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.spriteState = value;
		}
	}

	public static void SetDropdownSpriteState_ByPath(UnityEngine.UI.SpriteState value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.spriteState = value;
		}
	}

	public static void SetDropdownSpriteState_ByOrgin(UnityEngine.UI.SpriteState value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.spriteState = value;
		}
	}


	public static UnityEngine.UI.AnimationTriggers GetDropdownAnimationTriggers_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetDropdownAnimationTriggers_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetDropdownAnimationTriggers_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.animationTriggers;
		}

		return null;
	}


	public static void SetDropdownAnimationTriggers_ByName(UnityEngine.UI.AnimationTriggers value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.animationTriggers = value;
		}
	}

	public static void SetDropdownAnimationTriggers_ByPath(UnityEngine.UI.AnimationTriggers value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.animationTriggers = value;
		}
	}

	public static void SetDropdownAnimationTriggers_ByOrgin(UnityEngine.UI.AnimationTriggers value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.animationTriggers = value;
		}
	}


	public static UnityEngine.UI.Graphic GetDropdownTargetGraphic_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetDropdownTargetGraphic_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetDropdownTargetGraphic_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.targetGraphic;
		}

		return null;
	}


	public static void SetDropdownTargetGraphic_ByName(UnityEngine.UI.Graphic value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.targetGraphic = value;
		}
	}

	public static void SetDropdownTargetGraphic_ByPath(UnityEngine.UI.Graphic value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.targetGraphic = value;
		}
	}

	public static void SetDropdownTargetGraphic_ByOrgin(UnityEngine.UI.Graphic value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.targetGraphic = value;
		}
	}


	public static System.Boolean GetDropdownInteractable_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetDropdownInteractable_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetDropdownInteractable_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.interactable;
		}

		return default(System.Boolean);
	}


	public static void SetDropdownInteractable_ByName(System.Boolean value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.interactable = value;
		}
	}

	public static void SetDropdownInteractable_ByPath(System.Boolean value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.interactable = value;
		}
	}

	public static void SetDropdownInteractable_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.interactable = value;
		}
	}


	public static UnityEngine.UI.Image GetDropdownImage_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetDropdownImage_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetDropdownImage_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.image;
		}

		return null;
	}


	public static void SetDropdownImage_ByName(UnityEngine.UI.Image value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.image = value;
		}
	}

	public static void SetDropdownImage_ByPath(UnityEngine.UI.Image value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.image = value;
		}
	}

	public static void SetDropdownImage_ByOrgin(UnityEngine.UI.Image value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.image = value;
		}
	}


	public static UnityEngine.Animator GetDropdownAnimator_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetDropdownAnimator_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetDropdownAnimator_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.animator;
		}

		return null;
	}


	public static System.Boolean IsInteractable_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.IsInteractable();
		}

		return default(System.Boolean);
	}


	public static UnityEngine.UI.Selectable FindSelectable_ByName(UnityEngine.Vector3 dir, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByPath(UnityEngine.Vector3 dir, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByOrgin(UnityEngine.Vector3 dir, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.FindSelectable(dir);
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.FindSelectableOnLeft();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.FindSelectableOnRight();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.FindSelectableOnUp();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.FindSelectableOnDown();
		}

		return null;
	}


	public static void OnMove_ByName(UnityEngine.EventSystems.AxisEventData eventData, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.OnMove(eventData);
		}
	}

	public static void OnMove_ByPath(UnityEngine.EventSystems.AxisEventData eventData, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.OnMove(eventData);
		}
	}

	public static void OnMove_ByOrgin(UnityEngine.EventSystems.AxisEventData eventData, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.OnMove(eventData);
		}
	}


	public static void OnPointerDown_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.OnPointerDown(eventData);
		}
	}


	public static void OnPointerUp_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.OnPointerUp(eventData);
		}
	}


	public static void OnPointerEnter_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.OnPointerEnter(eventData);
		}
	}


	public static void OnPointerExit_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.OnPointerExit(eventData);
		}
	}


	public static void OnSelect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.OnSelect(eventData);
		}
	}


	public static void OnDeselect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.OnDeselect(eventData);
		}
	}


	public static void Select_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.Select();
		}
	}

	public static void Select_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.Select();
		}
	}

	public static void Select_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.Select();
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.StopAllCoroutines();
		}
	}


	public static System.Boolean GetDropdownUseGUILayout_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetDropdownUseGUILayout_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetDropdownUseGUILayout_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetDropdownUseGUILayout_ByName(System.Boolean value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.useGUILayout = value;
		}
	}

	public static void SetDropdownUseGUILayout_ByPath(System.Boolean value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.useGUILayout = value;
		}
	}

	public static void SetDropdownUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.useGUILayout = value;
		}
	}


	public static System.Boolean GetDropdownRunInEditMode_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetDropdownRunInEditMode_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetDropdownRunInEditMode_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetDropdownRunInEditMode_ByName(System.Boolean value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.runInEditMode = value;
		}
	}

	public static void SetDropdownRunInEditMode_ByPath(System.Boolean value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.runInEditMode = value;
		}
	}

	public static void SetDropdownRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.runInEditMode = value;
		}
	}


	public static System.Boolean GetDropdownEnabled_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetDropdownEnabled_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetDropdownEnabled_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetDropdownEnabled_ByName(System.Boolean value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.enabled = value;
		}
	}

	public static void SetDropdownEnabled_ByPath(System.Boolean value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.enabled = value;
		}
	}

	public static void SetDropdownEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.enabled = value;
		}
	}


	public static System.Boolean GetDropdownIsActiveAndEnabled_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetDropdownIsActiveAndEnabled_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetDropdownIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetDropdownTransform_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetDropdownTransform_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetDropdownTransform_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetDropdownGameObject_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetDropdownGameObject_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetDropdownGameObject_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.GetComponents(type, results);
		}
	}


	public static System.String GetDropdownTag_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.tag;
		}

		return null;
	}

	public static System.String GetDropdownTag_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.tag;
		}

		return null;
	}

	public static System.String GetDropdownTag_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.tag;
		}

		return null;
	}


	public static void SetDropdownTag_ByName(System.String value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.tag = value;
		}
	}

	public static void SetDropdownTag_ByPath(System.String value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.tag = value;
		}
	}

	public static void SetDropdownTag_ByOrgin(System.String value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetDropdownName_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.name;
		}

		return null;
	}

	public static System.String GetDropdownName_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.name;
		}

		return null;
	}

	public static System.String GetDropdownName_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.name;
		}

		return null;
	}


	public static void SetDropdownName_ByName(System.String value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.name = value;
		}
	}

	public static void SetDropdownName_ByPath(System.String value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.name = value;
		}
	}

	public static void SetDropdownName_ByOrgin(System.String value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.name = value;
		}
	}


	public static UnityEngine.HideFlags GetDropdownHideFlags_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetDropdownHideFlags_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetDropdownHideFlags_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetDropdownHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			dropdown.hideFlags = value;
		}
	}

	public static void SetDropdownHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			dropdown.hideFlags = value;
		}
	}

	public static void SetDropdownHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			dropdown.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		Dropdown dropdown = GetDropdownByName(name);
		if(dropdown != null)
		{
			return dropdown.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		Dropdown dropdown = GetDropdownByPath(path);
		if(dropdown != null)
		{
			return dropdown.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		Dropdown dropdown = GetDropdownByOrgin(parentName, path);
		if(dropdown != null)
		{
			return dropdown.GetType();
		}

		return null;
	}


}

