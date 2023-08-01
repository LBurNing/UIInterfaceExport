using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.Events;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UITextHelper
{
	public static Text GetTextByName(string name)
	{
		return UIManager.GetComponentByName<Text>(name);
	}

	public static Text GetTextByPath(string path)
	{
		return UIManager.GetComponentByPath<Text>(path);
	}

	public static Text GetTextByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<Text>(parentName, path);
	}

	public static UnityEngine.TextGenerator GetTextCachedTextGenerator_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.cachedTextGenerator;
		}

		return null;
	}

	public static UnityEngine.TextGenerator GetTextCachedTextGenerator_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.cachedTextGenerator;
		}

		return null;
	}

	public static UnityEngine.TextGenerator GetTextCachedTextGenerator_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.cachedTextGenerator;
		}

		return null;
	}


	public static UnityEngine.TextGenerator GetTextCachedTextGeneratorForLayout_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.cachedTextGeneratorForLayout;
		}

		return null;
	}

	public static UnityEngine.TextGenerator GetTextCachedTextGeneratorForLayout_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.cachedTextGeneratorForLayout;
		}

		return null;
	}

	public static UnityEngine.TextGenerator GetTextCachedTextGeneratorForLayout_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.cachedTextGeneratorForLayout;
		}

		return null;
	}


	public static UnityEngine.Texture GetTextMainTexture_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.mainTexture;
		}

		return null;
	}

	public static UnityEngine.Texture GetTextMainTexture_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.mainTexture;
		}

		return null;
	}

	public static UnityEngine.Texture GetTextMainTexture_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.mainTexture;
		}

		return null;
	}


	public static void FontTextureChanged_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.FontTextureChanged();
		}
	}

	public static void FontTextureChanged_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.FontTextureChanged();
		}
	}

	public static void FontTextureChanged_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.FontTextureChanged();
		}
	}


	public static UnityEngine.Font GetTextFont_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.font;
		}

		return null;
	}

	public static UnityEngine.Font GetTextFont_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.font;
		}

		return null;
	}

	public static UnityEngine.Font GetTextFont_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.font;
		}

		return null;
	}


	public static void SetTextFont_ByName(UnityEngine.Font value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.font = value;
		}
	}

	public static void SetTextFont_ByPath(UnityEngine.Font value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.font = value;
		}
	}

	public static void SetTextFont_ByOrgin(UnityEngine.Font value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.font = value;
		}
	}


	public static System.String GetTextText_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.text;
		}

		return null;
	}

	public static System.String GetTextText_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.text;
		}

		return null;
	}

	public static System.String GetTextText_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.text;
		}

		return null;
	}


	public static void SetTextText_ByName(System.String value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.text = value;
		}
	}

	public static void SetTextText_ByPath(System.String value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.text = value;
		}
	}

	public static void SetTextText_ByOrgin(System.String value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.text = value;
		}
	}


	public static System.Boolean GetTextSupportRichText_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.supportRichText;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextSupportRichText_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.supportRichText;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextSupportRichText_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.supportRichText;
		}

		return default(System.Boolean);
	}


	public static void SetTextSupportRichText_ByName(System.Boolean value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.supportRichText = value;
		}
	}

	public static void SetTextSupportRichText_ByPath(System.Boolean value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.supportRichText = value;
		}
	}

	public static void SetTextSupportRichText_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.supportRichText = value;
		}
	}


	public static System.Boolean GetTextResizeTextForBestFit_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.resizeTextForBestFit;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextResizeTextForBestFit_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.resizeTextForBestFit;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextResizeTextForBestFit_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.resizeTextForBestFit;
		}

		return default(System.Boolean);
	}


	public static void SetTextResizeTextForBestFit_ByName(System.Boolean value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.resizeTextForBestFit = value;
		}
	}

	public static void SetTextResizeTextForBestFit_ByPath(System.Boolean value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.resizeTextForBestFit = value;
		}
	}

	public static void SetTextResizeTextForBestFit_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.resizeTextForBestFit = value;
		}
	}


	public static System.Int32 GetTextResizeTextMinSize_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.resizeTextMinSize;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetTextResizeTextMinSize_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.resizeTextMinSize;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetTextResizeTextMinSize_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.resizeTextMinSize;
		}

		return default(System.Int32);
	}


	public static void SetTextResizeTextMinSize_ByName(System.Int32 value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.resizeTextMinSize = value;
		}
	}

	public static void SetTextResizeTextMinSize_ByPath(System.Int32 value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.resizeTextMinSize = value;
		}
	}

	public static void SetTextResizeTextMinSize_ByOrgin(System.Int32 value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.resizeTextMinSize = value;
		}
	}


	public static System.Int32 GetTextResizeTextMaxSize_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.resizeTextMaxSize;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetTextResizeTextMaxSize_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.resizeTextMaxSize;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetTextResizeTextMaxSize_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.resizeTextMaxSize;
		}

		return default(System.Int32);
	}


	public static void SetTextResizeTextMaxSize_ByName(System.Int32 value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.resizeTextMaxSize = value;
		}
	}

	public static void SetTextResizeTextMaxSize_ByPath(System.Int32 value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.resizeTextMaxSize = value;
		}
	}

	public static void SetTextResizeTextMaxSize_ByOrgin(System.Int32 value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.resizeTextMaxSize = value;
		}
	}


	public static UnityEngine.TextAnchor GetTextAlignment_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.alignment;
		}

		return default(UnityEngine.TextAnchor);
	}

	public static UnityEngine.TextAnchor GetTextAlignment_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.alignment;
		}

		return default(UnityEngine.TextAnchor);
	}

	public static UnityEngine.TextAnchor GetTextAlignment_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.alignment;
		}

		return default(UnityEngine.TextAnchor);
	}


	public static void SetTextAlignment_ByName(UnityEngine.TextAnchor value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.alignment = value;
		}
	}

	public static void SetTextAlignment_ByPath(UnityEngine.TextAnchor value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.alignment = value;
		}
	}

	public static void SetTextAlignment_ByOrgin(UnityEngine.TextAnchor value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.alignment = value;
		}
	}


	public static System.Boolean GetTextAlignByGeometry_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.alignByGeometry;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextAlignByGeometry_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.alignByGeometry;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextAlignByGeometry_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.alignByGeometry;
		}

		return default(System.Boolean);
	}


	public static void SetTextAlignByGeometry_ByName(System.Boolean value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.alignByGeometry = value;
		}
	}

	public static void SetTextAlignByGeometry_ByPath(System.Boolean value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.alignByGeometry = value;
		}
	}

	public static void SetTextAlignByGeometry_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.alignByGeometry = value;
		}
	}


	public static System.Int32 GetTextFontSize_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.fontSize;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetTextFontSize_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.fontSize;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetTextFontSize_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.fontSize;
		}

		return default(System.Int32);
	}


	public static void SetTextFontSize_ByName(System.Int32 value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.fontSize = value;
		}
	}

	public static void SetTextFontSize_ByPath(System.Int32 value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.fontSize = value;
		}
	}

	public static void SetTextFontSize_ByOrgin(System.Int32 value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.fontSize = value;
		}
	}


	public static UnityEngine.HorizontalWrapMode GetTextHorizontalOverflow_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.horizontalOverflow;
		}

		return default(UnityEngine.HorizontalWrapMode);
	}

	public static UnityEngine.HorizontalWrapMode GetTextHorizontalOverflow_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.horizontalOverflow;
		}

		return default(UnityEngine.HorizontalWrapMode);
	}

	public static UnityEngine.HorizontalWrapMode GetTextHorizontalOverflow_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.horizontalOverflow;
		}

		return default(UnityEngine.HorizontalWrapMode);
	}


	public static void SetTextHorizontalOverflow_ByName(UnityEngine.HorizontalWrapMode value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.horizontalOverflow = value;
		}
	}

	public static void SetTextHorizontalOverflow_ByPath(UnityEngine.HorizontalWrapMode value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.horizontalOverflow = value;
		}
	}

	public static void SetTextHorizontalOverflow_ByOrgin(UnityEngine.HorizontalWrapMode value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.horizontalOverflow = value;
		}
	}


	public static UnityEngine.VerticalWrapMode GetTextVerticalOverflow_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.verticalOverflow;
		}

		return default(UnityEngine.VerticalWrapMode);
	}

	public static UnityEngine.VerticalWrapMode GetTextVerticalOverflow_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.verticalOverflow;
		}

		return default(UnityEngine.VerticalWrapMode);
	}

	public static UnityEngine.VerticalWrapMode GetTextVerticalOverflow_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.verticalOverflow;
		}

		return default(UnityEngine.VerticalWrapMode);
	}


	public static void SetTextVerticalOverflow_ByName(UnityEngine.VerticalWrapMode value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.verticalOverflow = value;
		}
	}

	public static void SetTextVerticalOverflow_ByPath(UnityEngine.VerticalWrapMode value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.verticalOverflow = value;
		}
	}

	public static void SetTextVerticalOverflow_ByOrgin(UnityEngine.VerticalWrapMode value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.verticalOverflow = value;
		}
	}


	public static System.Single GetTextLineSpacing_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.lineSpacing;
		}

		return default(System.Single);
	}

	public static System.Single GetTextLineSpacing_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.lineSpacing;
		}

		return default(System.Single);
	}

	public static System.Single GetTextLineSpacing_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.lineSpacing;
		}

		return default(System.Single);
	}


	public static void SetTextLineSpacing_ByName(System.Single value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.lineSpacing = value;
		}
	}

	public static void SetTextLineSpacing_ByPath(System.Single value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.lineSpacing = value;
		}
	}

	public static void SetTextLineSpacing_ByOrgin(System.Single value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.lineSpacing = value;
		}
	}


	public static UnityEngine.FontStyle GetTextFontStyle_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.fontStyle;
		}

		return default(UnityEngine.FontStyle);
	}

	public static UnityEngine.FontStyle GetTextFontStyle_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.fontStyle;
		}

		return default(UnityEngine.FontStyle);
	}

	public static UnityEngine.FontStyle GetTextFontStyle_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.fontStyle;
		}

		return default(UnityEngine.FontStyle);
	}


	public static void SetTextFontStyle_ByName(UnityEngine.FontStyle value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.fontStyle = value;
		}
	}

	public static void SetTextFontStyle_ByPath(UnityEngine.FontStyle value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.fontStyle = value;
		}
	}

	public static void SetTextFontStyle_ByOrgin(UnityEngine.FontStyle value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.fontStyle = value;
		}
	}


	public static System.Single GetTextPixelsPerUnit_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.pixelsPerUnit;
		}

		return default(System.Single);
	}

	public static System.Single GetTextPixelsPerUnit_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.pixelsPerUnit;
		}

		return default(System.Single);
	}

	public static System.Single GetTextPixelsPerUnit_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.pixelsPerUnit;
		}

		return default(System.Single);
	}


	public static UnityEngine.TextGenerationSettings GetGenerationSettings_ByName(UnityEngine.Vector2 extents, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetGenerationSettings(extents);
		}

		return default(UnityEngine.TextGenerationSettings);
	}

	public static UnityEngine.TextGenerationSettings GetGenerationSettings_ByPath(UnityEngine.Vector2 extents, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetGenerationSettings(extents);
		}

		return default(UnityEngine.TextGenerationSettings);
	}

	public static UnityEngine.TextGenerationSettings GetGenerationSettings_ByOrgin(UnityEngine.Vector2 extents, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetGenerationSettings(extents);
		}

		return default(UnityEngine.TextGenerationSettings);
	}


	public static void CalculateLayoutInputHorizontal_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.CalculateLayoutInputHorizontal();
		}
	}


	public static void CalculateLayoutInputVertical_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.CalculateLayoutInputVertical();
		}
	}


	public static System.Single GetTextMinWidth_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetTextMinWidth_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetTextMinWidth_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.minWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetTextPreferredWidth_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetTextPreferredWidth_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetTextPreferredWidth_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.preferredWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetTextFlexibleWidth_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetTextFlexibleWidth_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetTextFlexibleWidth_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.flexibleWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetTextMinHeight_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetTextMinHeight_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetTextMinHeight_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.minHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetTextPreferredHeight_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetTextPreferredHeight_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetTextPreferredHeight_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.preferredHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetTextFlexibleHeight_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetTextFlexibleHeight_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetTextFlexibleHeight_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.flexibleHeight;
		}

		return default(System.Single);
	}


	public static System.Int32 GetTextLayoutPriority_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetTextLayoutPriority_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetTextLayoutPriority_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.layoutPriority;
		}

		return default(System.Int32);
	}


	public static void OnRebuildRequested_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.OnRebuildRequested();
		}
	}

	public static void OnRebuildRequested_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.OnRebuildRequested();
		}
	}

	public static void OnRebuildRequested_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.OnRebuildRequested();
		}
	}


	public static UnityEngine.UI.MaskableGraphic.CullStateChangedEvent GetTextOnCullStateChanged_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.onCullStateChanged;
		}

		return null;
	}

	public static UnityEngine.UI.MaskableGraphic.CullStateChangedEvent GetTextOnCullStateChanged_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.onCullStateChanged;
		}

		return null;
	}

	public static UnityEngine.UI.MaskableGraphic.CullStateChangedEvent GetTextOnCullStateChanged_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.onCullStateChanged;
		}

		return null;
	}


	public static void SetTextOnCullStateChanged_ByName(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.onCullStateChanged = value;
		}
	}

	public static void SetTextOnCullStateChanged_ByPath(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.onCullStateChanged = value;
		}
	}

	public static void SetTextOnCullStateChanged_ByOrgin(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.onCullStateChanged = value;
		}
	}


	public static System.Boolean GetTextMaskable_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.maskable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextMaskable_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.maskable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextMaskable_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.maskable;
		}

		return default(System.Boolean);
	}


	public static void SetTextMaskable_ByName(System.Boolean value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.maskable = value;
		}
	}

	public static void SetTextMaskable_ByPath(System.Boolean value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.maskable = value;
		}
	}

	public static void SetTextMaskable_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.maskable = value;
		}
	}


	public static System.Boolean GetTextIsMaskingGraphic_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.isMaskingGraphic;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextIsMaskingGraphic_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.isMaskingGraphic;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextIsMaskingGraphic_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.isMaskingGraphic;
		}

		return default(System.Boolean);
	}


	public static void SetTextIsMaskingGraphic_ByName(System.Boolean value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.isMaskingGraphic = value;
		}
	}

	public static void SetTextIsMaskingGraphic_ByPath(System.Boolean value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.isMaskingGraphic = value;
		}
	}

	public static void SetTextIsMaskingGraphic_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.isMaskingGraphic = value;
		}
	}


	public static UnityEngine.Material GetModifiedMaterial_ByName(UnityEngine.Material baseMaterial, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}

	public static UnityEngine.Material GetModifiedMaterial_ByPath(UnityEngine.Material baseMaterial, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}

	public static UnityEngine.Material GetModifiedMaterial_ByOrgin(UnityEngine.Material baseMaterial, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}


	public static void Cull_ByName(UnityEngine.Rect clipRect, System.Boolean validRect, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.Cull(clipRect, validRect);
		}
	}

	public static void Cull_ByPath(UnityEngine.Rect clipRect, System.Boolean validRect, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.Cull(clipRect, validRect);
		}
	}

	public static void Cull_ByOrgin(UnityEngine.Rect clipRect, System.Boolean validRect, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.Cull(clipRect, validRect);
		}
	}


	public static void SetClipRect_ByName(UnityEngine.Rect clipRect, System.Boolean validRect, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SetClipRect(clipRect, validRect);
		}
	}

	public static void SetClipRect_ByPath(UnityEngine.Rect clipRect, System.Boolean validRect, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SetClipRect(clipRect, validRect);
		}
	}

	public static void SetClipRect_ByOrgin(UnityEngine.Rect clipRect, System.Boolean validRect, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SetClipRect(clipRect, validRect);
		}
	}


	public static void SetClipSoftness_ByName(UnityEngine.Vector2 clipSoftness, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SetClipSoftness(clipSoftness);
		}
	}

	public static void SetClipSoftness_ByPath(UnityEngine.Vector2 clipSoftness, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SetClipSoftness(clipSoftness);
		}
	}

	public static void SetClipSoftness_ByOrgin(UnityEngine.Vector2 clipSoftness, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SetClipSoftness(clipSoftness);
		}
	}


	public static void RecalculateClipping_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.RecalculateClipping();
		}
	}

	public static void RecalculateClipping_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.RecalculateClipping();
		}
	}

	public static void RecalculateClipping_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.RecalculateClipping();
		}
	}


	public static void RecalculateMasking_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.RecalculateMasking();
		}
	}

	public static void RecalculateMasking_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.RecalculateMasking();
		}
	}

	public static void RecalculateMasking_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.RecalculateMasking();
		}
	}


	public static UnityEngine.Color GetTextColor_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.color;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetTextColor_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.color;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetTextColor_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.color;
		}

		return default(UnityEngine.Color);
	}


	public static void SetTextColor_ByName(UnityEngine.Color value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.color = value;
		}
	}

	public static void SetTextColor_ByPath(UnityEngine.Color value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.color = value;
		}
	}

	public static void SetTextColor_ByOrgin(UnityEngine.Color value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.color = value;
		}
	}


	public static System.Boolean GetTextRaycastTarget_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.raycastTarget;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextRaycastTarget_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.raycastTarget;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextRaycastTarget_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.raycastTarget;
		}

		return default(System.Boolean);
	}


	public static void SetTextRaycastTarget_ByName(System.Boolean value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.raycastTarget = value;
		}
	}

	public static void SetTextRaycastTarget_ByPath(System.Boolean value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.raycastTarget = value;
		}
	}

	public static void SetTextRaycastTarget_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.raycastTarget = value;
		}
	}


	public static UnityEngine.Vector4 GetTextRaycastPadding_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}

	public static UnityEngine.Vector4 GetTextRaycastPadding_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}

	public static UnityEngine.Vector4 GetTextRaycastPadding_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}


	public static void SetTextRaycastPadding_ByName(UnityEngine.Vector4 value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.raycastPadding = value;
		}
	}

	public static void SetTextRaycastPadding_ByPath(UnityEngine.Vector4 value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.raycastPadding = value;
		}
	}

	public static void SetTextRaycastPadding_ByOrgin(UnityEngine.Vector4 value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.raycastPadding = value;
		}
	}


	public static void SetAllDirty_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SetAllDirty();
		}
	}

	public static void SetAllDirty_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SetAllDirty();
		}
	}

	public static void SetAllDirty_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SetAllDirty();
		}
	}


	public static void SetLayoutDirty_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SetLayoutDirty();
		}
	}

	public static void SetLayoutDirty_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SetLayoutDirty();
		}
	}

	public static void SetLayoutDirty_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SetLayoutDirty();
		}
	}


	public static void SetVerticesDirty_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SetVerticesDirty();
		}
	}

	public static void SetVerticesDirty_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SetVerticesDirty();
		}
	}

	public static void SetVerticesDirty_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SetVerticesDirty();
		}
	}


	public static void SetMaterialDirty_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SetMaterialDirty();
		}
	}

	public static void SetMaterialDirty_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SetMaterialDirty();
		}
	}

	public static void SetMaterialDirty_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SetMaterialDirty();
		}
	}


	public static void SetRaycastDirty_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SetRaycastDirty();
		}
	}

	public static void SetRaycastDirty_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SetRaycastDirty();
		}
	}

	public static void SetRaycastDirty_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SetRaycastDirty();
		}
	}


	public static System.Int32 GetTextDepth_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.depth;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetTextDepth_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.depth;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetTextDepth_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.depth;
		}

		return default(System.Int32);
	}


	public static UnityEngine.RectTransform GetTextRectTransform_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetTextRectTransform_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetTextRectTransform_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.rectTransform;
		}

		return null;
	}


	public static UnityEngine.Canvas GetTextCanvas_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.canvas;
		}

		return null;
	}

	public static UnityEngine.Canvas GetTextCanvas_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.canvas;
		}

		return null;
	}

	public static UnityEngine.Canvas GetTextCanvas_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.canvas;
		}

		return null;
	}


	public static UnityEngine.CanvasRenderer GetTextCanvasRenderer_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.canvasRenderer;
		}

		return null;
	}

	public static UnityEngine.CanvasRenderer GetTextCanvasRenderer_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.canvasRenderer;
		}

		return null;
	}

	public static UnityEngine.CanvasRenderer GetTextCanvasRenderer_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.canvasRenderer;
		}

		return null;
	}


	public static UnityEngine.Material GetTextDefaultMaterial_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.defaultMaterial;
		}

		return null;
	}

	public static UnityEngine.Material GetTextDefaultMaterial_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.defaultMaterial;
		}

		return null;
	}

	public static UnityEngine.Material GetTextDefaultMaterial_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.defaultMaterial;
		}

		return null;
	}


	public static UnityEngine.Material GetTextMaterial_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.material;
		}

		return null;
	}

	public static UnityEngine.Material GetTextMaterial_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.material;
		}

		return null;
	}

	public static UnityEngine.Material GetTextMaterial_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.material;
		}

		return null;
	}


	public static void SetTextMaterial_ByName(UnityEngine.Material value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.material = value;
		}
	}

	public static void SetTextMaterial_ByPath(UnityEngine.Material value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.material = value;
		}
	}

	public static void SetTextMaterial_ByOrgin(UnityEngine.Material value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.material = value;
		}
	}


	public static UnityEngine.Material GetTextMaterialForRendering_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.materialForRendering;
		}

		return null;
	}

	public static UnityEngine.Material GetTextMaterialForRendering_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.materialForRendering;
		}

		return null;
	}

	public static UnityEngine.Material GetTextMaterialForRendering_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.materialForRendering;
		}

		return null;
	}


	public static void OnCullingChanged_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.OnCullingChanged();
		}
	}

	public static void OnCullingChanged_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.OnCullingChanged();
		}
	}

	public static void OnCullingChanged_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.OnCullingChanged();
		}
	}


	public static void Rebuild_ByName(UnityEngine.UI.CanvasUpdate update, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.Rebuild(update);
		}
	}

	public static void Rebuild_ByPath(UnityEngine.UI.CanvasUpdate update, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.Rebuild(update);
		}
	}

	public static void Rebuild_ByOrgin(UnityEngine.UI.CanvasUpdate update, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.Rebuild(update);
		}
	}


	public static void LayoutComplete_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.LayoutComplete();
		}
	}


	public static void GraphicUpdateComplete_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.GraphicUpdateComplete();
		}
	}


	public static void SetNativeSize_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SetNativeSize();
		}
	}

	public static void SetNativeSize_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SetNativeSize();
		}
	}

	public static void SetNativeSize_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SetNativeSize();
		}
	}


	public static System.Boolean Raycast_ByName(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Raycast_ByPath(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Raycast_ByOrgin(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Vector2 PixelAdjustPoint_ByName(UnityEngine.Vector2 point, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 PixelAdjustPoint_ByPath(UnityEngine.Vector2 point, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 PixelAdjustPoint_ByOrgin(UnityEngine.Vector2 point, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}


	public static UnityEngine.Rect GetPixelAdjustedRect_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetPixelAdjustedRect_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetPixelAdjustedRect_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}


	public static void CrossFadeColor_ByName(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}

	public static void CrossFadeColor_ByPath(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}

	public static void CrossFadeColor_ByOrgin(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}


	public static void CrossFadeColor_ByName(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}

	public static void CrossFadeColor_ByPath(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}

	public static void CrossFadeColor_ByOrgin(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}


	public static void CrossFadeAlpha_ByName(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}

	public static void CrossFadeAlpha_ByPath(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}

	public static void CrossFadeAlpha_ByOrgin(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}


	public static void RegisterDirtyLayoutCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.RegisterDirtyLayoutCallback(action);
		}
	}

	public static void RegisterDirtyLayoutCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.RegisterDirtyLayoutCallback(action);
		}
	}

	public static void RegisterDirtyLayoutCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.RegisterDirtyLayoutCallback(action);
		}
	}


	public static void UnregisterDirtyLayoutCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.UnregisterDirtyLayoutCallback(action);
		}
	}

	public static void UnregisterDirtyLayoutCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.UnregisterDirtyLayoutCallback(action);
		}
	}

	public static void UnregisterDirtyLayoutCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.UnregisterDirtyLayoutCallback(action);
		}
	}


	public static void RegisterDirtyVerticesCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.RegisterDirtyVerticesCallback(action);
		}
	}

	public static void RegisterDirtyVerticesCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.RegisterDirtyVerticesCallback(action);
		}
	}

	public static void RegisterDirtyVerticesCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.RegisterDirtyVerticesCallback(action);
		}
	}


	public static void UnregisterDirtyVerticesCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.UnregisterDirtyVerticesCallback(action);
		}
	}

	public static void UnregisterDirtyVerticesCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.UnregisterDirtyVerticesCallback(action);
		}
	}

	public static void UnregisterDirtyVerticesCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.UnregisterDirtyVerticesCallback(action);
		}
	}


	public static void RegisterDirtyMaterialCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.RegisterDirtyMaterialCallback(action);
		}
	}

	public static void RegisterDirtyMaterialCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.RegisterDirtyMaterialCallback(action);
		}
	}

	public static void RegisterDirtyMaterialCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.RegisterDirtyMaterialCallback(action);
		}
	}


	public static void UnregisterDirtyMaterialCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.UnregisterDirtyMaterialCallback(action);
		}
	}

	public static void UnregisterDirtyMaterialCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.UnregisterDirtyMaterialCallback(action);
		}
	}

	public static void UnregisterDirtyMaterialCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.UnregisterDirtyMaterialCallback(action);
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.StopAllCoroutines();
		}
	}


	public static System.Boolean GetTextUseGUILayout_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextUseGUILayout_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextUseGUILayout_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetTextUseGUILayout_ByName(System.Boolean value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.useGUILayout = value;
		}
	}

	public static void SetTextUseGUILayout_ByPath(System.Boolean value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.useGUILayout = value;
		}
	}

	public static void SetTextUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.useGUILayout = value;
		}
	}


	public static System.Boolean GetTextRunInEditMode_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextRunInEditMode_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextRunInEditMode_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetTextRunInEditMode_ByName(System.Boolean value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.runInEditMode = value;
		}
	}

	public static void SetTextRunInEditMode_ByPath(System.Boolean value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.runInEditMode = value;
		}
	}

	public static void SetTextRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.runInEditMode = value;
		}
	}


	public static System.Boolean GetTextEnabled_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextEnabled_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextEnabled_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetTextEnabled_ByName(System.Boolean value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.enabled = value;
		}
	}

	public static void SetTextEnabled_ByPath(System.Boolean value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.enabled = value;
		}
	}

	public static void SetTextEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.enabled = value;
		}
	}


	public static System.Boolean GetTextIsActiveAndEnabled_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextIsActiveAndEnabled_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetTextIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetTextTransform_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetTextTransform_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetTextTransform_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetTextGameObject_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetTextGameObject_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetTextGameObject_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.GetComponents(type, results);
		}
	}


	public static System.String GetTextTag_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.tag;
		}

		return null;
	}

	public static System.String GetTextTag_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.tag;
		}

		return null;
	}

	public static System.String GetTextTag_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.tag;
		}

		return null;
	}


	public static void SetTextTag_ByName(System.String value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.tag = value;
		}
	}

	public static void SetTextTag_ByPath(System.String value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.tag = value;
		}
	}

	public static void SetTextTag_ByOrgin(System.String value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetTextName_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.name;
		}

		return null;
	}

	public static System.String GetTextName_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.name;
		}

		return null;
	}

	public static System.String GetTextName_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.name;
		}

		return null;
	}


	public static void SetTextName_ByName(System.String value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.name = value;
		}
	}

	public static void SetTextName_ByPath(System.String value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.name = value;
		}
	}

	public static void SetTextName_ByOrgin(System.String value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.name = value;
		}
	}


	public static UnityEngine.HideFlags GetTextHideFlags_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetTextHideFlags_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetTextHideFlags_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetTextHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			text.hideFlags = value;
		}
	}

	public static void SetTextHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			text.hideFlags = value;
		}
	}

	public static void SetTextHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			text.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		Text text = GetTextByName(name);
		if(text != null)
		{
			return text.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		Text text = GetTextByPath(path);
		if(text != null)
		{
			return text.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		Text text = GetTextByOrgin(parentName, path);
		if(text != null)
		{
			return text.GetType();
		}

		return null;
	}


}

