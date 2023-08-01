using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIInputFieldHelper
{
	public static InputField GetInputFieldByName(string name)
	{
		return UIManager.GetComponentByName<InputField>(name);
	}

	public static InputField GetInputFieldByPath(string path)
	{
		return UIManager.GetComponentByPath<InputField>(path);
	}

	public static InputField GetInputFieldByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<InputField>(parentName, path);
	}

	public static void SetInputFieldShouldHideMobileInput_ByName(System.Boolean value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.shouldHideMobileInput = value;
		}
	}

	public static void SetInputFieldShouldHideMobileInput_ByPath(System.Boolean value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.shouldHideMobileInput = value;
		}
	}

	public static void SetInputFieldShouldHideMobileInput_ByOrgin(System.Boolean value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.shouldHideMobileInput = value;
		}
	}


	public static System.Boolean GetInputFieldShouldHideMobileInput_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.shouldHideMobileInput;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldShouldHideMobileInput_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.shouldHideMobileInput;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldShouldHideMobileInput_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.shouldHideMobileInput;
		}

		return default(System.Boolean);
	}


	public static void SetInputFieldShouldActivateOnSelect_ByName(System.Boolean value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.shouldActivateOnSelect = value;
		}
	}

	public static void SetInputFieldShouldActivateOnSelect_ByPath(System.Boolean value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.shouldActivateOnSelect = value;
		}
	}

	public static void SetInputFieldShouldActivateOnSelect_ByOrgin(System.Boolean value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.shouldActivateOnSelect = value;
		}
	}


	public static System.Boolean GetInputFieldShouldActivateOnSelect_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.shouldActivateOnSelect;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldShouldActivateOnSelect_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.shouldActivateOnSelect;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldShouldActivateOnSelect_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.shouldActivateOnSelect;
		}

		return default(System.Boolean);
	}


	public static System.String GetInputFieldText_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.text;
		}

		return null;
	}

	public static System.String GetInputFieldText_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.text;
		}

		return null;
	}

	public static System.String GetInputFieldText_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.text;
		}

		return null;
	}


	public static void SetInputFieldText_ByName(System.String value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.text = value;
		}
	}

	public static void SetInputFieldText_ByPath(System.String value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.text = value;
		}
	}

	public static void SetInputFieldText_ByOrgin(System.String value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.text = value;
		}
	}


	public static void SetTextWithoutNotify_ByName(System.String input, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.SetTextWithoutNotify(input);
		}
	}

	public static void SetTextWithoutNotify_ByPath(System.String input, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.SetTextWithoutNotify(input);
		}
	}

	public static void SetTextWithoutNotify_ByOrgin(System.String input, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.SetTextWithoutNotify(input);
		}
	}


	public static System.Boolean GetInputFieldIsFocused_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.isFocused;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldIsFocused_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.isFocused;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldIsFocused_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.isFocused;
		}

		return default(System.Boolean);
	}


	public static System.Single GetInputFieldCaretBlinkRate_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.caretBlinkRate;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldCaretBlinkRate_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.caretBlinkRate;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldCaretBlinkRate_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.caretBlinkRate;
		}

		return default(System.Single);
	}


	public static void SetInputFieldCaretBlinkRate_ByName(System.Single value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.caretBlinkRate = value;
		}
	}

	public static void SetInputFieldCaretBlinkRate_ByPath(System.Single value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.caretBlinkRate = value;
		}
	}

	public static void SetInputFieldCaretBlinkRate_ByOrgin(System.Single value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.caretBlinkRate = value;
		}
	}


	public static System.Int32 GetInputFieldCaretWidth_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.caretWidth;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInputFieldCaretWidth_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.caretWidth;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInputFieldCaretWidth_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.caretWidth;
		}

		return default(System.Int32);
	}


	public static void SetInputFieldCaretWidth_ByName(System.Int32 value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.caretWidth = value;
		}
	}

	public static void SetInputFieldCaretWidth_ByPath(System.Int32 value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.caretWidth = value;
		}
	}

	public static void SetInputFieldCaretWidth_ByOrgin(System.Int32 value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.caretWidth = value;
		}
	}


	public static UnityEngine.UI.Text GetInputFieldTextComponent_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.textComponent;
		}

		return null;
	}

	public static UnityEngine.UI.Text GetInputFieldTextComponent_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.textComponent;
		}

		return null;
	}

	public static UnityEngine.UI.Text GetInputFieldTextComponent_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.textComponent;
		}

		return null;
	}


	public static void SetInputFieldTextComponent_ByName(UnityEngine.UI.Text value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.textComponent = value;
		}
	}

	public static void SetInputFieldTextComponent_ByPath(UnityEngine.UI.Text value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.textComponent = value;
		}
	}

	public static void SetInputFieldTextComponent_ByOrgin(UnityEngine.UI.Text value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.textComponent = value;
		}
	}


	public static UnityEngine.UI.Graphic GetInputFieldPlaceholder_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.placeholder;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetInputFieldPlaceholder_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.placeholder;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetInputFieldPlaceholder_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.placeholder;
		}

		return null;
	}


	public static void SetInputFieldPlaceholder_ByName(UnityEngine.UI.Graphic value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.placeholder = value;
		}
	}

	public static void SetInputFieldPlaceholder_ByPath(UnityEngine.UI.Graphic value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.placeholder = value;
		}
	}

	public static void SetInputFieldPlaceholder_ByOrgin(UnityEngine.UI.Graphic value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.placeholder = value;
		}
	}


	public static UnityEngine.Color GetInputFieldCaretColor_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.caretColor;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetInputFieldCaretColor_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.caretColor;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetInputFieldCaretColor_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.caretColor;
		}

		return default(UnityEngine.Color);
	}


	public static void SetInputFieldCaretColor_ByName(UnityEngine.Color value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.caretColor = value;
		}
	}

	public static void SetInputFieldCaretColor_ByPath(UnityEngine.Color value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.caretColor = value;
		}
	}

	public static void SetInputFieldCaretColor_ByOrgin(UnityEngine.Color value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.caretColor = value;
		}
	}


	public static System.Boolean GetInputFieldCustomCaretColor_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.customCaretColor;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldCustomCaretColor_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.customCaretColor;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldCustomCaretColor_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.customCaretColor;
		}

		return default(System.Boolean);
	}


	public static void SetInputFieldCustomCaretColor_ByName(System.Boolean value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.customCaretColor = value;
		}
	}

	public static void SetInputFieldCustomCaretColor_ByPath(System.Boolean value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.customCaretColor = value;
		}
	}

	public static void SetInputFieldCustomCaretColor_ByOrgin(System.Boolean value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.customCaretColor = value;
		}
	}


	public static UnityEngine.Color GetInputFieldSelectionColor_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.selectionColor;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetInputFieldSelectionColor_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.selectionColor;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetInputFieldSelectionColor_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.selectionColor;
		}

		return default(UnityEngine.Color);
	}


	public static void SetInputFieldSelectionColor_ByName(UnityEngine.Color value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.selectionColor = value;
		}
	}

	public static void SetInputFieldSelectionColor_ByPath(UnityEngine.Color value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.selectionColor = value;
		}
	}

	public static void SetInputFieldSelectionColor_ByOrgin(UnityEngine.Color value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.selectionColor = value;
		}
	}


	public static UnityEngine.UI.InputField.EndEditEvent GetInputFieldOnEndEdit_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.onEndEdit;
		}

		return null;
	}

	public static UnityEngine.UI.InputField.EndEditEvent GetInputFieldOnEndEdit_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.onEndEdit;
		}

		return null;
	}

	public static UnityEngine.UI.InputField.EndEditEvent GetInputFieldOnEndEdit_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.onEndEdit;
		}

		return null;
	}


	public static void SetInputFieldOnEndEdit_ByName(UnityEngine.UI.InputField.EndEditEvent value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.onEndEdit = value;
		}
	}

	public static void SetInputFieldOnEndEdit_ByPath(UnityEngine.UI.InputField.EndEditEvent value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.onEndEdit = value;
		}
	}

	public static void SetInputFieldOnEndEdit_ByOrgin(UnityEngine.UI.InputField.EndEditEvent value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.onEndEdit = value;
		}
	}


	public static UnityEngine.UI.InputField.SubmitEvent GetInputFieldOnSubmit_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.onSubmit;
		}

		return null;
	}

	public static UnityEngine.UI.InputField.SubmitEvent GetInputFieldOnSubmit_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.onSubmit;
		}

		return null;
	}

	public static UnityEngine.UI.InputField.SubmitEvent GetInputFieldOnSubmit_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.onSubmit;
		}

		return null;
	}


	public static void SetInputFieldOnSubmit_ByName(UnityEngine.UI.InputField.SubmitEvent value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.onSubmit = value;
		}
	}

	public static void SetInputFieldOnSubmit_ByPath(UnityEngine.UI.InputField.SubmitEvent value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.onSubmit = value;
		}
	}

	public static void SetInputFieldOnSubmit_ByOrgin(UnityEngine.UI.InputField.SubmitEvent value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.onSubmit = value;
		}
	}


	public static UnityEngine.UI.InputField.OnChangeEvent GetInputFieldOnValueChange_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.onValueChange;
		}

		return null;
	}

	public static UnityEngine.UI.InputField.OnChangeEvent GetInputFieldOnValueChange_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.onValueChange;
		}

		return null;
	}

	public static UnityEngine.UI.InputField.OnChangeEvent GetInputFieldOnValueChange_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.onValueChange;
		}

		return null;
	}


	public static void SetInputFieldOnValueChange_ByName(UnityEngine.UI.InputField.OnChangeEvent value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.onValueChange = value;
		}
	}

	public static void SetInputFieldOnValueChange_ByPath(UnityEngine.UI.InputField.OnChangeEvent value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.onValueChange = value;
		}
	}

	public static void SetInputFieldOnValueChange_ByOrgin(UnityEngine.UI.InputField.OnChangeEvent value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.onValueChange = value;
		}
	}


	public static UnityEngine.UI.InputField.OnChangeEvent GetInputFieldOnValueChanged_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.onValueChanged;
		}

		return null;
	}

	public static UnityEngine.UI.InputField.OnChangeEvent GetInputFieldOnValueChanged_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.onValueChanged;
		}

		return null;
	}

	public static UnityEngine.UI.InputField.OnChangeEvent GetInputFieldOnValueChanged_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.onValueChanged;
		}

		return null;
	}


	public static void SetInputFieldOnValueChanged_ByName(UnityEngine.UI.InputField.OnChangeEvent value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.onValueChanged = value;
		}
	}

	public static void SetInputFieldOnValueChanged_ByPath(UnityEngine.UI.InputField.OnChangeEvent value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.onValueChanged = value;
		}
	}

	public static void SetInputFieldOnValueChanged_ByOrgin(UnityEngine.UI.InputField.OnChangeEvent value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.onValueChanged = value;
		}
	}


	public static UnityEngine.UI.InputField.OnValidateInput GetInputFieldOnValidateInput_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.onValidateInput;
		}

		return null;
	}

	public static UnityEngine.UI.InputField.OnValidateInput GetInputFieldOnValidateInput_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.onValidateInput;
		}

		return null;
	}

	public static UnityEngine.UI.InputField.OnValidateInput GetInputFieldOnValidateInput_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.onValidateInput;
		}

		return null;
	}


	public static void SetInputFieldOnValidateInput_ByName(UnityEngine.UI.InputField.OnValidateInput value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.onValidateInput = value;
		}
	}

	public static void SetInputFieldOnValidateInput_ByPath(UnityEngine.UI.InputField.OnValidateInput value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.onValidateInput = value;
		}
	}

	public static void SetInputFieldOnValidateInput_ByOrgin(UnityEngine.UI.InputField.OnValidateInput value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.onValidateInput = value;
		}
	}


	public static System.Int32 GetInputFieldCharacterLimit_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.characterLimit;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInputFieldCharacterLimit_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.characterLimit;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInputFieldCharacterLimit_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.characterLimit;
		}

		return default(System.Int32);
	}


	public static void SetInputFieldCharacterLimit_ByName(System.Int32 value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.characterLimit = value;
		}
	}

	public static void SetInputFieldCharacterLimit_ByPath(System.Int32 value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.characterLimit = value;
		}
	}

	public static void SetInputFieldCharacterLimit_ByOrgin(System.Int32 value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.characterLimit = value;
		}
	}


	public static UnityEngine.UI.InputField.ContentType GetInputFieldContentType_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.contentType;
		}

		return default(UnityEngine.UI.InputField.ContentType);
	}

	public static UnityEngine.UI.InputField.ContentType GetInputFieldContentType_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.contentType;
		}

		return default(UnityEngine.UI.InputField.ContentType);
	}

	public static UnityEngine.UI.InputField.ContentType GetInputFieldContentType_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.contentType;
		}

		return default(UnityEngine.UI.InputField.ContentType);
	}


	public static void SetInputFieldContentType_ByName(UnityEngine.UI.InputField.ContentType value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.contentType = value;
		}
	}

	public static void SetInputFieldContentType_ByPath(UnityEngine.UI.InputField.ContentType value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.contentType = value;
		}
	}

	public static void SetInputFieldContentType_ByOrgin(UnityEngine.UI.InputField.ContentType value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.contentType = value;
		}
	}


	public static UnityEngine.UI.InputField.LineType GetInputFieldLineType_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.lineType;
		}

		return default(UnityEngine.UI.InputField.LineType);
	}

	public static UnityEngine.UI.InputField.LineType GetInputFieldLineType_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.lineType;
		}

		return default(UnityEngine.UI.InputField.LineType);
	}

	public static UnityEngine.UI.InputField.LineType GetInputFieldLineType_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.lineType;
		}

		return default(UnityEngine.UI.InputField.LineType);
	}


	public static void SetInputFieldLineType_ByName(UnityEngine.UI.InputField.LineType value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.lineType = value;
		}
	}

	public static void SetInputFieldLineType_ByPath(UnityEngine.UI.InputField.LineType value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.lineType = value;
		}
	}

	public static void SetInputFieldLineType_ByOrgin(UnityEngine.UI.InputField.LineType value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.lineType = value;
		}
	}


	public static UnityEngine.UI.InputField.InputType GetInputFieldInputType_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.inputType;
		}

		return default(UnityEngine.UI.InputField.InputType);
	}

	public static UnityEngine.UI.InputField.InputType GetInputFieldInputType_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.inputType;
		}

		return default(UnityEngine.UI.InputField.InputType);
	}

	public static UnityEngine.UI.InputField.InputType GetInputFieldInputType_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.inputType;
		}

		return default(UnityEngine.UI.InputField.InputType);
	}


	public static void SetInputFieldInputType_ByName(UnityEngine.UI.InputField.InputType value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.inputType = value;
		}
	}

	public static void SetInputFieldInputType_ByPath(UnityEngine.UI.InputField.InputType value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.inputType = value;
		}
	}

	public static void SetInputFieldInputType_ByOrgin(UnityEngine.UI.InputField.InputType value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.inputType = value;
		}
	}


	public static UnityEngine.TouchScreenKeyboard GetInputFieldTouchScreenKeyboard_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.touchScreenKeyboard;
		}

		return null;
	}

	public static UnityEngine.TouchScreenKeyboard GetInputFieldTouchScreenKeyboard_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.touchScreenKeyboard;
		}

		return null;
	}

	public static UnityEngine.TouchScreenKeyboard GetInputFieldTouchScreenKeyboard_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.touchScreenKeyboard;
		}

		return null;
	}


	public static UnityEngine.TouchScreenKeyboardType GetInputFieldKeyboardType_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.keyboardType;
		}

		return default(UnityEngine.TouchScreenKeyboardType);
	}

	public static UnityEngine.TouchScreenKeyboardType GetInputFieldKeyboardType_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.keyboardType;
		}

		return default(UnityEngine.TouchScreenKeyboardType);
	}

	public static UnityEngine.TouchScreenKeyboardType GetInputFieldKeyboardType_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.keyboardType;
		}

		return default(UnityEngine.TouchScreenKeyboardType);
	}


	public static void SetInputFieldKeyboardType_ByName(UnityEngine.TouchScreenKeyboardType value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.keyboardType = value;
		}
	}

	public static void SetInputFieldKeyboardType_ByPath(UnityEngine.TouchScreenKeyboardType value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.keyboardType = value;
		}
	}

	public static void SetInputFieldKeyboardType_ByOrgin(UnityEngine.TouchScreenKeyboardType value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.keyboardType = value;
		}
	}


	public static UnityEngine.UI.InputField.CharacterValidation GetInputFieldCharacterValidation_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.characterValidation;
		}

		return default(UnityEngine.UI.InputField.CharacterValidation);
	}

	public static UnityEngine.UI.InputField.CharacterValidation GetInputFieldCharacterValidation_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.characterValidation;
		}

		return default(UnityEngine.UI.InputField.CharacterValidation);
	}

	public static UnityEngine.UI.InputField.CharacterValidation GetInputFieldCharacterValidation_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.characterValidation;
		}

		return default(UnityEngine.UI.InputField.CharacterValidation);
	}


	public static void SetInputFieldCharacterValidation_ByName(UnityEngine.UI.InputField.CharacterValidation value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.characterValidation = value;
		}
	}

	public static void SetInputFieldCharacterValidation_ByPath(UnityEngine.UI.InputField.CharacterValidation value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.characterValidation = value;
		}
	}

	public static void SetInputFieldCharacterValidation_ByOrgin(UnityEngine.UI.InputField.CharacterValidation value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.characterValidation = value;
		}
	}


	public static System.Boolean GetInputFieldReadOnly_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.readOnly;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldReadOnly_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.readOnly;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldReadOnly_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.readOnly;
		}

		return default(System.Boolean);
	}


	public static void SetInputFieldReadOnly_ByName(System.Boolean value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.readOnly = value;
		}
	}

	public static void SetInputFieldReadOnly_ByPath(System.Boolean value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.readOnly = value;
		}
	}

	public static void SetInputFieldReadOnly_ByOrgin(System.Boolean value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.readOnly = value;
		}
	}


	public static System.Boolean GetInputFieldMultiLine_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.multiLine;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldMultiLine_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.multiLine;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldMultiLine_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.multiLine;
		}

		return default(System.Boolean);
	}


	public static System.Char GetInputFieldAsteriskChar_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.asteriskChar;
		}

		return default(System.Char);
	}

	public static System.Char GetInputFieldAsteriskChar_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.asteriskChar;
		}

		return default(System.Char);
	}

	public static System.Char GetInputFieldAsteriskChar_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.asteriskChar;
		}

		return default(System.Char);
	}


	public static void SetInputFieldAsteriskChar_ByName(System.Char value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.asteriskChar = value;
		}
	}

	public static void SetInputFieldAsteriskChar_ByPath(System.Char value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.asteriskChar = value;
		}
	}

	public static void SetInputFieldAsteriskChar_ByOrgin(System.Char value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.asteriskChar = value;
		}
	}


	public static System.Boolean GetInputFieldWasCanceled_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.wasCanceled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldWasCanceled_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.wasCanceled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldWasCanceled_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.wasCanceled;
		}

		return default(System.Boolean);
	}


	public static System.Int32 GetInputFieldCaretPosition_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.caretPosition;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInputFieldCaretPosition_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.caretPosition;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInputFieldCaretPosition_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.caretPosition;
		}

		return default(System.Int32);
	}


	public static void SetInputFieldCaretPosition_ByName(System.Int32 value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.caretPosition = value;
		}
	}

	public static void SetInputFieldCaretPosition_ByPath(System.Int32 value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.caretPosition = value;
		}
	}

	public static void SetInputFieldCaretPosition_ByOrgin(System.Int32 value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.caretPosition = value;
		}
	}


	public static System.Int32 GetInputFieldSelectionAnchorPosition_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.selectionAnchorPosition;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInputFieldSelectionAnchorPosition_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.selectionAnchorPosition;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInputFieldSelectionAnchorPosition_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.selectionAnchorPosition;
		}

		return default(System.Int32);
	}


	public static void SetInputFieldSelectionAnchorPosition_ByName(System.Int32 value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.selectionAnchorPosition = value;
		}
	}

	public static void SetInputFieldSelectionAnchorPosition_ByPath(System.Int32 value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.selectionAnchorPosition = value;
		}
	}

	public static void SetInputFieldSelectionAnchorPosition_ByOrgin(System.Int32 value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.selectionAnchorPosition = value;
		}
	}


	public static System.Int32 GetInputFieldSelectionFocusPosition_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.selectionFocusPosition;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInputFieldSelectionFocusPosition_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.selectionFocusPosition;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInputFieldSelectionFocusPosition_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.selectionFocusPosition;
		}

		return default(System.Int32);
	}


	public static void SetInputFieldSelectionFocusPosition_ByName(System.Int32 value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.selectionFocusPosition = value;
		}
	}

	public static void SetInputFieldSelectionFocusPosition_ByPath(System.Int32 value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.selectionFocusPosition = value;
		}
	}

	public static void SetInputFieldSelectionFocusPosition_ByOrgin(System.Int32 value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.selectionFocusPosition = value;
		}
	}


	public static void MoveTextEnd_ByName(System.Boolean shift, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.MoveTextEnd(shift);
		}
	}

	public static void MoveTextEnd_ByPath(System.Boolean shift, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.MoveTextEnd(shift);
		}
	}

	public static void MoveTextEnd_ByOrgin(System.Boolean shift, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.MoveTextEnd(shift);
		}
	}


	public static void MoveTextStart_ByName(System.Boolean shift, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.MoveTextStart(shift);
		}
	}

	public static void MoveTextStart_ByPath(System.Boolean shift, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.MoveTextStart(shift);
		}
	}

	public static void MoveTextStart_ByOrgin(System.Boolean shift, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.MoveTextStart(shift);
		}
	}


	public static void OnBeginDrag_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnBeginDrag(eventData);
		}
	}

	public static void OnBeginDrag_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnBeginDrag(eventData);
		}
	}

	public static void OnBeginDrag_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnBeginDrag(eventData);
		}
	}


	public static void OnDrag_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnDrag(eventData);
		}
	}

	public static void OnDrag_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnDrag(eventData);
		}
	}

	public static void OnDrag_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnDrag(eventData);
		}
	}


	public static void OnEndDrag_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnEndDrag(eventData);
		}
	}

	public static void OnEndDrag_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnEndDrag(eventData);
		}
	}

	public static void OnEndDrag_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnEndDrag(eventData);
		}
	}


	public static void OnPointerDown_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnPointerDown(eventData);
		}
	}

	public static void OnPointerDown_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnPointerDown(eventData);
		}
	}


	public static void ProcessEvent_ByName(UnityEngine.Event e, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.ProcessEvent(e);
		}
	}

	public static void ProcessEvent_ByPath(UnityEngine.Event e, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.ProcessEvent(e);
		}
	}

	public static void ProcessEvent_ByOrgin(UnityEngine.Event e, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.ProcessEvent(e);
		}
	}


	public static void OnUpdateSelected_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnUpdateSelected(eventData);
		}
	}

	public static void OnUpdateSelected_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnUpdateSelected(eventData);
		}
	}

	public static void OnUpdateSelected_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnUpdateSelected(eventData);
		}
	}


	public static void ForceLabelUpdate_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.ForceLabelUpdate();
		}
	}

	public static void ForceLabelUpdate_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.ForceLabelUpdate();
		}
	}

	public static void ForceLabelUpdate_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.ForceLabelUpdate();
		}
	}


	public static void Rebuild_ByName(UnityEngine.UI.CanvasUpdate update, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.Rebuild(update);
		}
	}

	public static void Rebuild_ByPath(UnityEngine.UI.CanvasUpdate update, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.Rebuild(update);
		}
	}

	public static void Rebuild_ByOrgin(UnityEngine.UI.CanvasUpdate update, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.Rebuild(update);
		}
	}


	public static void LayoutComplete_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.LayoutComplete();
		}
	}


	public static void GraphicUpdateComplete_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.GraphicUpdateComplete();
		}
	}


	public static void ActivateInputField_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.ActivateInputField();
		}
	}

	public static void ActivateInputField_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.ActivateInputField();
		}
	}

	public static void ActivateInputField_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.ActivateInputField();
		}
	}


	public static void OnSelect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnSelect(eventData);
		}
	}

	public static void OnSelect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnSelect(eventData);
		}
	}


	public static void OnPointerClick_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnPointerClick(eventData);
		}
	}

	public static void OnPointerClick_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnPointerClick(eventData);
		}
	}

	public static void OnPointerClick_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnPointerClick(eventData);
		}
	}


	public static void DeactivateInputField_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.DeactivateInputField();
		}
	}

	public static void DeactivateInputField_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.DeactivateInputField();
		}
	}

	public static void DeactivateInputField_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.DeactivateInputField();
		}
	}


	public static void OnDeselect_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnDeselect(eventData);
		}
	}

	public static void OnDeselect_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnDeselect(eventData);
		}
	}


	public static void OnSubmit_ByName(UnityEngine.EventSystems.BaseEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnSubmit(eventData);
		}
	}

	public static void OnSubmit_ByPath(UnityEngine.EventSystems.BaseEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnSubmit(eventData);
		}
	}

	public static void OnSubmit_ByOrgin(UnityEngine.EventSystems.BaseEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnSubmit(eventData);
		}
	}


	public static void CalculateLayoutInputHorizontal_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.CalculateLayoutInputHorizontal();
		}
	}


	public static void CalculateLayoutInputVertical_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.CalculateLayoutInputVertical();
		}
	}


	public static System.Single GetInputFieldMinWidth_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldMinWidth_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldMinWidth_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.minWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetInputFieldPreferredWidth_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldPreferredWidth_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldPreferredWidth_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.preferredWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetInputFieldFlexibleWidth_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldFlexibleWidth_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldFlexibleWidth_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.flexibleWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetInputFieldMinHeight_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldMinHeight_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldMinHeight_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.minHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetInputFieldPreferredHeight_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldPreferredHeight_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldPreferredHeight_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.preferredHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetInputFieldFlexibleHeight_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldFlexibleHeight_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetInputFieldFlexibleHeight_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.flexibleHeight;
		}

		return default(System.Single);
	}


	public static System.Int32 GetInputFieldLayoutPriority_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInputFieldLayoutPriority_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInputFieldLayoutPriority_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.layoutPriority;
		}

		return default(System.Int32);
	}


	public static UnityEngine.UI.Navigation GetInputFieldNavigation_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetInputFieldNavigation_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}

	public static UnityEngine.UI.Navigation GetInputFieldNavigation_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.navigation;
		}

		return default(UnityEngine.UI.Navigation);
	}


	public static void SetInputFieldNavigation_ByName(UnityEngine.UI.Navigation value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.navigation = value;
		}
	}

	public static void SetInputFieldNavigation_ByPath(UnityEngine.UI.Navigation value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.navigation = value;
		}
	}

	public static void SetInputFieldNavigation_ByOrgin(UnityEngine.UI.Navigation value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.navigation = value;
		}
	}


	public static UnityEngine.UI.Selectable.Transition GetInputFieldTransition_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetInputFieldTransition_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}

	public static UnityEngine.UI.Selectable.Transition GetInputFieldTransition_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.transition;
		}

		return default(UnityEngine.UI.Selectable.Transition);
	}


	public static void SetInputFieldTransition_ByName(UnityEngine.UI.Selectable.Transition value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.transition = value;
		}
	}

	public static void SetInputFieldTransition_ByPath(UnityEngine.UI.Selectable.Transition value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.transition = value;
		}
	}

	public static void SetInputFieldTransition_ByOrgin(UnityEngine.UI.Selectable.Transition value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.transition = value;
		}
	}


	public static UnityEngine.UI.ColorBlock GetInputFieldColors_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetInputFieldColors_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}

	public static UnityEngine.UI.ColorBlock GetInputFieldColors_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.colors;
		}

		return default(UnityEngine.UI.ColorBlock);
	}


	public static void SetInputFieldColors_ByName(UnityEngine.UI.ColorBlock value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.colors = value;
		}
	}

	public static void SetInputFieldColors_ByPath(UnityEngine.UI.ColorBlock value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.colors = value;
		}
	}

	public static void SetInputFieldColors_ByOrgin(UnityEngine.UI.ColorBlock value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.colors = value;
		}
	}


	public static UnityEngine.UI.SpriteState GetInputFieldSpriteState_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetInputFieldSpriteState_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}

	public static UnityEngine.UI.SpriteState GetInputFieldSpriteState_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.spriteState;
		}

		return default(UnityEngine.UI.SpriteState);
	}


	public static void SetInputFieldSpriteState_ByName(UnityEngine.UI.SpriteState value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.spriteState = value;
		}
	}

	public static void SetInputFieldSpriteState_ByPath(UnityEngine.UI.SpriteState value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.spriteState = value;
		}
	}

	public static void SetInputFieldSpriteState_ByOrgin(UnityEngine.UI.SpriteState value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.spriteState = value;
		}
	}


	public static UnityEngine.UI.AnimationTriggers GetInputFieldAnimationTriggers_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetInputFieldAnimationTriggers_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.animationTriggers;
		}

		return null;
	}

	public static UnityEngine.UI.AnimationTriggers GetInputFieldAnimationTriggers_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.animationTriggers;
		}

		return null;
	}


	public static void SetInputFieldAnimationTriggers_ByName(UnityEngine.UI.AnimationTriggers value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.animationTriggers = value;
		}
	}

	public static void SetInputFieldAnimationTriggers_ByPath(UnityEngine.UI.AnimationTriggers value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.animationTriggers = value;
		}
	}

	public static void SetInputFieldAnimationTriggers_ByOrgin(UnityEngine.UI.AnimationTriggers value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.animationTriggers = value;
		}
	}


	public static UnityEngine.UI.Graphic GetInputFieldTargetGraphic_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetInputFieldTargetGraphic_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.targetGraphic;
		}

		return null;
	}

	public static UnityEngine.UI.Graphic GetInputFieldTargetGraphic_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.targetGraphic;
		}

		return null;
	}


	public static void SetInputFieldTargetGraphic_ByName(UnityEngine.UI.Graphic value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.targetGraphic = value;
		}
	}

	public static void SetInputFieldTargetGraphic_ByPath(UnityEngine.UI.Graphic value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.targetGraphic = value;
		}
	}

	public static void SetInputFieldTargetGraphic_ByOrgin(UnityEngine.UI.Graphic value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.targetGraphic = value;
		}
	}


	public static System.Boolean GetInputFieldInteractable_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldInteractable_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.interactable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldInteractable_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.interactable;
		}

		return default(System.Boolean);
	}


	public static void SetInputFieldInteractable_ByName(System.Boolean value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.interactable = value;
		}
	}

	public static void SetInputFieldInteractable_ByPath(System.Boolean value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.interactable = value;
		}
	}

	public static void SetInputFieldInteractable_ByOrgin(System.Boolean value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.interactable = value;
		}
	}


	public static UnityEngine.UI.Image GetInputFieldImage_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetInputFieldImage_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.image;
		}

		return null;
	}

	public static UnityEngine.UI.Image GetInputFieldImage_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.image;
		}

		return null;
	}


	public static void SetInputFieldImage_ByName(UnityEngine.UI.Image value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.image = value;
		}
	}

	public static void SetInputFieldImage_ByPath(UnityEngine.UI.Image value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.image = value;
		}
	}

	public static void SetInputFieldImage_ByOrgin(UnityEngine.UI.Image value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.image = value;
		}
	}


	public static UnityEngine.Animator GetInputFieldAnimator_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetInputFieldAnimator_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.animator;
		}

		return null;
	}

	public static UnityEngine.Animator GetInputFieldAnimator_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.animator;
		}

		return null;
	}


	public static System.Boolean IsInteractable_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.IsInteractable();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInteractable_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.IsInteractable();
		}

		return default(System.Boolean);
	}


	public static UnityEngine.UI.Selectable FindSelectable_ByName(UnityEngine.Vector3 dir, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByPath(UnityEngine.Vector3 dir, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.FindSelectable(dir);
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectable_ByOrgin(UnityEngine.Vector3 dir, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.FindSelectable(dir);
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.FindSelectableOnLeft();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnLeft_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.FindSelectableOnLeft();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.FindSelectableOnRight();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnRight_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.FindSelectableOnRight();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.FindSelectableOnUp();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnUp_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.FindSelectableOnUp();
		}

		return null;
	}


	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.FindSelectableOnDown();
		}

		return null;
	}

	public static UnityEngine.UI.Selectable FindSelectableOnDown_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.FindSelectableOnDown();
		}

		return null;
	}


	public static void OnMove_ByName(UnityEngine.EventSystems.AxisEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnMove(eventData);
		}
	}

	public static void OnMove_ByPath(UnityEngine.EventSystems.AxisEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnMove(eventData);
		}
	}

	public static void OnMove_ByOrgin(UnityEngine.EventSystems.AxisEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnMove(eventData);
		}
	}


	public static void OnPointerUp_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnPointerUp(eventData);
		}
	}

	public static void OnPointerUp_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnPointerUp(eventData);
		}
	}


	public static void OnPointerEnter_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnPointerEnter(eventData);
		}
	}

	public static void OnPointerEnter_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnPointerEnter(eventData);
		}
	}


	public static void OnPointerExit_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.OnPointerExit(eventData);
		}
	}

	public static void OnPointerExit_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.OnPointerExit(eventData);
		}
	}


	public static void Select_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.Select();
		}
	}

	public static void Select_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.Select();
		}
	}

	public static void Select_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.Select();
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.StopAllCoroutines();
		}
	}


	public static System.Boolean GetInputFieldUseGUILayout_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldUseGUILayout_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldUseGUILayout_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetInputFieldUseGUILayout_ByName(System.Boolean value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.useGUILayout = value;
		}
	}

	public static void SetInputFieldUseGUILayout_ByPath(System.Boolean value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.useGUILayout = value;
		}
	}

	public static void SetInputFieldUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.useGUILayout = value;
		}
	}


	public static System.Boolean GetInputFieldRunInEditMode_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldRunInEditMode_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldRunInEditMode_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetInputFieldRunInEditMode_ByName(System.Boolean value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.runInEditMode = value;
		}
	}

	public static void SetInputFieldRunInEditMode_ByPath(System.Boolean value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.runInEditMode = value;
		}
	}

	public static void SetInputFieldRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.runInEditMode = value;
		}
	}


	public static System.Boolean GetInputFieldEnabled_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldEnabled_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldEnabled_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetInputFieldEnabled_ByName(System.Boolean value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.enabled = value;
		}
	}

	public static void SetInputFieldEnabled_ByPath(System.Boolean value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.enabled = value;
		}
	}

	public static void SetInputFieldEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.enabled = value;
		}
	}


	public static System.Boolean GetInputFieldIsActiveAndEnabled_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldIsActiveAndEnabled_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetInputFieldIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetInputFieldTransform_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetInputFieldTransform_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetInputFieldTransform_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetInputFieldGameObject_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetInputFieldGameObject_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetInputFieldGameObject_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.GetComponents(type, results);
		}
	}


	public static System.String GetInputFieldTag_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.tag;
		}

		return null;
	}

	public static System.String GetInputFieldTag_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.tag;
		}

		return null;
	}

	public static System.String GetInputFieldTag_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.tag;
		}

		return null;
	}


	public static void SetInputFieldTag_ByName(System.String value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.tag = value;
		}
	}

	public static void SetInputFieldTag_ByPath(System.String value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.tag = value;
		}
	}

	public static void SetInputFieldTag_ByOrgin(System.String value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetInputFieldName_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.name;
		}

		return null;
	}

	public static System.String GetInputFieldName_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.name;
		}

		return null;
	}

	public static System.String GetInputFieldName_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.name;
		}

		return null;
	}


	public static void SetInputFieldName_ByName(System.String value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.name = value;
		}
	}

	public static void SetInputFieldName_ByPath(System.String value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.name = value;
		}
	}

	public static void SetInputFieldName_ByOrgin(System.String value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.name = value;
		}
	}


	public static UnityEngine.HideFlags GetInputFieldHideFlags_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetInputFieldHideFlags_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetInputFieldHideFlags_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetInputFieldHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			inputfield.hideFlags = value;
		}
	}

	public static void SetInputFieldHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			inputfield.hideFlags = value;
		}
	}

	public static void SetInputFieldHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			inputfield.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		InputField inputfield = GetInputFieldByName(name);
		if(inputfield != null)
		{
			return inputfield.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		InputField inputfield = GetInputFieldByPath(path);
		if(inputfield != null)
		{
			return inputfield.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		InputField inputfield = GetInputFieldByOrgin(parentName, path);
		if(inputfield != null)
		{
			return inputfield.GetType();
		}

		return null;
	}


}

