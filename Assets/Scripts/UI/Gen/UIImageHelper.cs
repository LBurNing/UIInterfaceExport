using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.Events;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIImageHelper
{
	public static Image GetImageByName(string name)
	{
		return UIManager.GetComponentByName<Image>(name);
	}

	public static Image GetImageByPath(string path)
	{
		return UIManager.GetComponentByPath<Image>(path);
	}

	public static Image GetImageByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<Image>(parentName, path);
	}

	public static UnityEngine.Sprite GetImageSprite_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.sprite;
		}

		return null;
	}

	public static UnityEngine.Sprite GetImageSprite_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.sprite;
		}

		return null;
	}

	public static UnityEngine.Sprite GetImageSprite_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.sprite;
		}

		return null;
	}


	public static void SetImageSprite_ByName(UnityEngine.Sprite value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.sprite = value;
		}
	}

	public static void SetImageSprite_ByPath(UnityEngine.Sprite value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.sprite = value;
		}
	}

	public static void SetImageSprite_ByOrgin(UnityEngine.Sprite value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.sprite = value;
		}
	}


	public static void DisableSpriteOptimizations_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.DisableSpriteOptimizations();
		}
	}

	public static void DisableSpriteOptimizations_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.DisableSpriteOptimizations();
		}
	}

	public static void DisableSpriteOptimizations_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.DisableSpriteOptimizations();
		}
	}


	public static UnityEngine.Sprite GetImageOverrideSprite_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.overrideSprite;
		}

		return null;
	}

	public static UnityEngine.Sprite GetImageOverrideSprite_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.overrideSprite;
		}

		return null;
	}

	public static UnityEngine.Sprite GetImageOverrideSprite_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.overrideSprite;
		}

		return null;
	}


	public static void SetImageOverrideSprite_ByName(UnityEngine.Sprite value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.overrideSprite = value;
		}
	}

	public static void SetImageOverrideSprite_ByPath(UnityEngine.Sprite value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.overrideSprite = value;
		}
	}

	public static void SetImageOverrideSprite_ByOrgin(UnityEngine.Sprite value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.overrideSprite = value;
		}
	}


	public static UnityEngine.UI.Image.Type GetImageType_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.type;
		}

		return default(UnityEngine.UI.Image.Type);
	}

	public static UnityEngine.UI.Image.Type GetImageType_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.type;
		}

		return default(UnityEngine.UI.Image.Type);
	}

	public static UnityEngine.UI.Image.Type GetImageType_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.type;
		}

		return default(UnityEngine.UI.Image.Type);
	}


	public static void SetImageType_ByName(UnityEngine.UI.Image.Type value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.type = value;
		}
	}

	public static void SetImageType_ByPath(UnityEngine.UI.Image.Type value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.type = value;
		}
	}

	public static void SetImageType_ByOrgin(UnityEngine.UI.Image.Type value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.type = value;
		}
	}


	public static System.Boolean GetImagePreserveAspect_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.preserveAspect;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImagePreserveAspect_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.preserveAspect;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImagePreserveAspect_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.preserveAspect;
		}

		return default(System.Boolean);
	}


	public static void SetImagePreserveAspect_ByName(System.Boolean value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.preserveAspect = value;
		}
	}

	public static void SetImagePreserveAspect_ByPath(System.Boolean value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.preserveAspect = value;
		}
	}

	public static void SetImagePreserveAspect_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.preserveAspect = value;
		}
	}


	public static System.Boolean GetImageFillCenter_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.fillCenter;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageFillCenter_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.fillCenter;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageFillCenter_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.fillCenter;
		}

		return default(System.Boolean);
	}


	public static void SetImageFillCenter_ByName(System.Boolean value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.fillCenter = value;
		}
	}

	public static void SetImageFillCenter_ByPath(System.Boolean value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.fillCenter = value;
		}
	}

	public static void SetImageFillCenter_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.fillCenter = value;
		}
	}


	public static UnityEngine.UI.Image.FillMethod GetImageFillMethod_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.fillMethod;
		}

		return default(UnityEngine.UI.Image.FillMethod);
	}

	public static UnityEngine.UI.Image.FillMethod GetImageFillMethod_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.fillMethod;
		}

		return default(UnityEngine.UI.Image.FillMethod);
	}

	public static UnityEngine.UI.Image.FillMethod GetImageFillMethod_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.fillMethod;
		}

		return default(UnityEngine.UI.Image.FillMethod);
	}


	public static void SetImageFillMethod_ByName(UnityEngine.UI.Image.FillMethod value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.fillMethod = value;
		}
	}

	public static void SetImageFillMethod_ByPath(UnityEngine.UI.Image.FillMethod value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.fillMethod = value;
		}
	}

	public static void SetImageFillMethod_ByOrgin(UnityEngine.UI.Image.FillMethod value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.fillMethod = value;
		}
	}


	public static System.Single GetImageFillAmount_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.fillAmount;
		}

		return default(System.Single);
	}

	public static System.Single GetImageFillAmount_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.fillAmount;
		}

		return default(System.Single);
	}

	public static System.Single GetImageFillAmount_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.fillAmount;
		}

		return default(System.Single);
	}


	public static void SetImageFillAmount_ByName(System.Single value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.fillAmount = value;
		}
	}

	public static void SetImageFillAmount_ByPath(System.Single value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.fillAmount = value;
		}
	}

	public static void SetImageFillAmount_ByOrgin(System.Single value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.fillAmount = value;
		}
	}


	public static System.Boolean GetImageFillClockwise_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.fillClockwise;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageFillClockwise_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.fillClockwise;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageFillClockwise_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.fillClockwise;
		}

		return default(System.Boolean);
	}


	public static void SetImageFillClockwise_ByName(System.Boolean value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.fillClockwise = value;
		}
	}

	public static void SetImageFillClockwise_ByPath(System.Boolean value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.fillClockwise = value;
		}
	}

	public static void SetImageFillClockwise_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.fillClockwise = value;
		}
	}


	public static System.Int32 GetImageFillOrigin_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.fillOrigin;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetImageFillOrigin_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.fillOrigin;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetImageFillOrigin_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.fillOrigin;
		}

		return default(System.Int32);
	}


	public static void SetImageFillOrigin_ByName(System.Int32 value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.fillOrigin = value;
		}
	}

	public static void SetImageFillOrigin_ByPath(System.Int32 value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.fillOrigin = value;
		}
	}

	public static void SetImageFillOrigin_ByOrgin(System.Int32 value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.fillOrigin = value;
		}
	}


	public static System.Single GetImageAlphaHitTestMinimumThreshold_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.alphaHitTestMinimumThreshold;
		}

		return default(System.Single);
	}

	public static System.Single GetImageAlphaHitTestMinimumThreshold_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.alphaHitTestMinimumThreshold;
		}

		return default(System.Single);
	}

	public static System.Single GetImageAlphaHitTestMinimumThreshold_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.alphaHitTestMinimumThreshold;
		}

		return default(System.Single);
	}


	public static void SetImageAlphaHitTestMinimumThreshold_ByName(System.Single value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.alphaHitTestMinimumThreshold = value;
		}
	}

	public static void SetImageAlphaHitTestMinimumThreshold_ByPath(System.Single value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.alphaHitTestMinimumThreshold = value;
		}
	}

	public static void SetImageAlphaHitTestMinimumThreshold_ByOrgin(System.Single value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.alphaHitTestMinimumThreshold = value;
		}
	}


	public static System.Boolean GetImageUseSpriteMesh_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.useSpriteMesh;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageUseSpriteMesh_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.useSpriteMesh;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageUseSpriteMesh_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.useSpriteMesh;
		}

		return default(System.Boolean);
	}


	public static void SetImageUseSpriteMesh_ByName(System.Boolean value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.useSpriteMesh = value;
		}
	}

	public static void SetImageUseSpriteMesh_ByPath(System.Boolean value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.useSpriteMesh = value;
		}
	}

	public static void SetImageUseSpriteMesh_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.useSpriteMesh = value;
		}
	}


	public static UnityEngine.Texture GetImageMainTexture_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.mainTexture;
		}

		return null;
	}

	public static UnityEngine.Texture GetImageMainTexture_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.mainTexture;
		}

		return null;
	}

	public static UnityEngine.Texture GetImageMainTexture_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.mainTexture;
		}

		return null;
	}


	public static System.Boolean GetImageHasBorder_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.hasBorder;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageHasBorder_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.hasBorder;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageHasBorder_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.hasBorder;
		}

		return default(System.Boolean);
	}


	public static System.Single GetImagePixelsPerUnitMultiplier_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.pixelsPerUnitMultiplier;
		}

		return default(System.Single);
	}

	public static System.Single GetImagePixelsPerUnitMultiplier_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.pixelsPerUnitMultiplier;
		}

		return default(System.Single);
	}

	public static System.Single GetImagePixelsPerUnitMultiplier_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.pixelsPerUnitMultiplier;
		}

		return default(System.Single);
	}


	public static void SetImagePixelsPerUnitMultiplier_ByName(System.Single value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.pixelsPerUnitMultiplier = value;
		}
	}

	public static void SetImagePixelsPerUnitMultiplier_ByPath(System.Single value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.pixelsPerUnitMultiplier = value;
		}
	}

	public static void SetImagePixelsPerUnitMultiplier_ByOrgin(System.Single value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.pixelsPerUnitMultiplier = value;
		}
	}


	public static System.Single GetImagePixelsPerUnit_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.pixelsPerUnit;
		}

		return default(System.Single);
	}

	public static System.Single GetImagePixelsPerUnit_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.pixelsPerUnit;
		}

		return default(System.Single);
	}

	public static System.Single GetImagePixelsPerUnit_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.pixelsPerUnit;
		}

		return default(System.Single);
	}


	public static UnityEngine.Material GetImageMaterial_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.material;
		}

		return null;
	}

	public static UnityEngine.Material GetImageMaterial_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.material;
		}

		return null;
	}

	public static UnityEngine.Material GetImageMaterial_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.material;
		}

		return null;
	}


	public static void SetImageMaterial_ByName(UnityEngine.Material value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.material = value;
		}
	}

	public static void SetImageMaterial_ByPath(UnityEngine.Material value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.material = value;
		}
	}

	public static void SetImageMaterial_ByOrgin(UnityEngine.Material value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.material = value;
		}
	}


	public static void OnBeforeSerialize_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.OnBeforeSerialize();
		}
	}

	public static void OnBeforeSerialize_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.OnBeforeSerialize();
		}
	}

	public static void OnBeforeSerialize_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.OnBeforeSerialize();
		}
	}


	public static void OnAfterDeserialize_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.OnAfterDeserialize();
		}
	}

	public static void OnAfterDeserialize_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.OnAfterDeserialize();
		}
	}

	public static void OnAfterDeserialize_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.OnAfterDeserialize();
		}
	}


	public static void SetNativeSize_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SetNativeSize();
		}
	}

	public static void SetNativeSize_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SetNativeSize();
		}
	}

	public static void SetNativeSize_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SetNativeSize();
		}
	}


	public static void CalculateLayoutInputHorizontal_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.CalculateLayoutInputHorizontal();
		}
	}


	public static void CalculateLayoutInputVertical_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.CalculateLayoutInputVertical();
		}
	}


	public static System.Single GetImageMinWidth_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetImageMinWidth_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetImageMinWidth_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.minWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetImagePreferredWidth_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetImagePreferredWidth_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetImagePreferredWidth_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.preferredWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetImageFlexibleWidth_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetImageFlexibleWidth_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetImageFlexibleWidth_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.flexibleWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetImageMinHeight_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetImageMinHeight_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetImageMinHeight_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.minHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetImagePreferredHeight_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetImagePreferredHeight_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetImagePreferredHeight_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.preferredHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetImageFlexibleHeight_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetImageFlexibleHeight_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetImageFlexibleHeight_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.flexibleHeight;
		}

		return default(System.Single);
	}


	public static System.Int32 GetImageLayoutPriority_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetImageLayoutPriority_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetImageLayoutPriority_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.layoutPriority;
		}

		return default(System.Int32);
	}


	public static System.Boolean IsRaycastLocationValid_ByName(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.IsRaycastLocationValid(screenPoint, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsRaycastLocationValid_ByPath(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.IsRaycastLocationValid(screenPoint, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsRaycastLocationValid_ByOrgin(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.IsRaycastLocationValid(screenPoint, eventCamera);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.UI.MaskableGraphic.CullStateChangedEvent GetImageOnCullStateChanged_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.onCullStateChanged;
		}

		return null;
	}

	public static UnityEngine.UI.MaskableGraphic.CullStateChangedEvent GetImageOnCullStateChanged_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.onCullStateChanged;
		}

		return null;
	}

	public static UnityEngine.UI.MaskableGraphic.CullStateChangedEvent GetImageOnCullStateChanged_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.onCullStateChanged;
		}

		return null;
	}


	public static void SetImageOnCullStateChanged_ByName(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.onCullStateChanged = value;
		}
	}

	public static void SetImageOnCullStateChanged_ByPath(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.onCullStateChanged = value;
		}
	}

	public static void SetImageOnCullStateChanged_ByOrgin(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.onCullStateChanged = value;
		}
	}


	public static System.Boolean GetImageMaskable_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.maskable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageMaskable_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.maskable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageMaskable_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.maskable;
		}

		return default(System.Boolean);
	}


	public static void SetImageMaskable_ByName(System.Boolean value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.maskable = value;
		}
	}

	public static void SetImageMaskable_ByPath(System.Boolean value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.maskable = value;
		}
	}

	public static void SetImageMaskable_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.maskable = value;
		}
	}


	public static System.Boolean GetImageIsMaskingGraphic_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.isMaskingGraphic;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageIsMaskingGraphic_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.isMaskingGraphic;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageIsMaskingGraphic_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.isMaskingGraphic;
		}

		return default(System.Boolean);
	}


	public static void SetImageIsMaskingGraphic_ByName(System.Boolean value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.isMaskingGraphic = value;
		}
	}

	public static void SetImageIsMaskingGraphic_ByPath(System.Boolean value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.isMaskingGraphic = value;
		}
	}

	public static void SetImageIsMaskingGraphic_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.isMaskingGraphic = value;
		}
	}


	public static UnityEngine.Material GetModifiedMaterial_ByName(UnityEngine.Material baseMaterial, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}

	public static UnityEngine.Material GetModifiedMaterial_ByPath(UnityEngine.Material baseMaterial, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}

	public static UnityEngine.Material GetModifiedMaterial_ByOrgin(UnityEngine.Material baseMaterial, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}


	public static void Cull_ByName(UnityEngine.Rect clipRect, System.Boolean validRect, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.Cull(clipRect, validRect);
		}
	}

	public static void Cull_ByPath(UnityEngine.Rect clipRect, System.Boolean validRect, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.Cull(clipRect, validRect);
		}
	}

	public static void Cull_ByOrgin(UnityEngine.Rect clipRect, System.Boolean validRect, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.Cull(clipRect, validRect);
		}
	}


	public static void SetClipRect_ByName(UnityEngine.Rect clipRect, System.Boolean validRect, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SetClipRect(clipRect, validRect);
		}
	}

	public static void SetClipRect_ByPath(UnityEngine.Rect clipRect, System.Boolean validRect, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SetClipRect(clipRect, validRect);
		}
	}

	public static void SetClipRect_ByOrgin(UnityEngine.Rect clipRect, System.Boolean validRect, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SetClipRect(clipRect, validRect);
		}
	}


	public static void SetClipSoftness_ByName(UnityEngine.Vector2 clipSoftness, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SetClipSoftness(clipSoftness);
		}
	}

	public static void SetClipSoftness_ByPath(UnityEngine.Vector2 clipSoftness, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SetClipSoftness(clipSoftness);
		}
	}

	public static void SetClipSoftness_ByOrgin(UnityEngine.Vector2 clipSoftness, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SetClipSoftness(clipSoftness);
		}
	}


	public static void RecalculateClipping_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.RecalculateClipping();
		}
	}

	public static void RecalculateClipping_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.RecalculateClipping();
		}
	}

	public static void RecalculateClipping_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.RecalculateClipping();
		}
	}


	public static void RecalculateMasking_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.RecalculateMasking();
		}
	}

	public static void RecalculateMasking_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.RecalculateMasking();
		}
	}

	public static void RecalculateMasking_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.RecalculateMasking();
		}
	}


	public static UnityEngine.Color GetImageColor_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.color;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetImageColor_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.color;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetImageColor_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.color;
		}

		return default(UnityEngine.Color);
	}


	public static void SetImageColor_ByName(UnityEngine.Color value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.color = value;
		}
	}

	public static void SetImageColor_ByPath(UnityEngine.Color value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.color = value;
		}
	}

	public static void SetImageColor_ByOrgin(UnityEngine.Color value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.color = value;
		}
	}


	public static System.Boolean GetImageRaycastTarget_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.raycastTarget;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageRaycastTarget_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.raycastTarget;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageRaycastTarget_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.raycastTarget;
		}

		return default(System.Boolean);
	}


	public static void SetImageRaycastTarget_ByName(System.Boolean value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.raycastTarget = value;
		}
	}

	public static void SetImageRaycastTarget_ByPath(System.Boolean value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.raycastTarget = value;
		}
	}

	public static void SetImageRaycastTarget_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.raycastTarget = value;
		}
	}


	public static UnityEngine.Vector4 GetImageRaycastPadding_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}

	public static UnityEngine.Vector4 GetImageRaycastPadding_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}

	public static UnityEngine.Vector4 GetImageRaycastPadding_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}


	public static void SetImageRaycastPadding_ByName(UnityEngine.Vector4 value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.raycastPadding = value;
		}
	}

	public static void SetImageRaycastPadding_ByPath(UnityEngine.Vector4 value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.raycastPadding = value;
		}
	}

	public static void SetImageRaycastPadding_ByOrgin(UnityEngine.Vector4 value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.raycastPadding = value;
		}
	}


	public static void SetAllDirty_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SetAllDirty();
		}
	}

	public static void SetAllDirty_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SetAllDirty();
		}
	}

	public static void SetAllDirty_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SetAllDirty();
		}
	}


	public static void SetLayoutDirty_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SetLayoutDirty();
		}
	}

	public static void SetLayoutDirty_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SetLayoutDirty();
		}
	}

	public static void SetLayoutDirty_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SetLayoutDirty();
		}
	}


	public static void SetVerticesDirty_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SetVerticesDirty();
		}
	}

	public static void SetVerticesDirty_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SetVerticesDirty();
		}
	}

	public static void SetVerticesDirty_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SetVerticesDirty();
		}
	}


	public static void SetMaterialDirty_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SetMaterialDirty();
		}
	}

	public static void SetMaterialDirty_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SetMaterialDirty();
		}
	}

	public static void SetMaterialDirty_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SetMaterialDirty();
		}
	}


	public static void SetRaycastDirty_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SetRaycastDirty();
		}
	}

	public static void SetRaycastDirty_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SetRaycastDirty();
		}
	}

	public static void SetRaycastDirty_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SetRaycastDirty();
		}
	}


	public static System.Int32 GetImageDepth_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.depth;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetImageDepth_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.depth;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetImageDepth_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.depth;
		}

		return default(System.Int32);
	}


	public static UnityEngine.RectTransform GetImageRectTransform_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetImageRectTransform_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetImageRectTransform_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.rectTransform;
		}

		return null;
	}


	public static UnityEngine.Canvas GetImageCanvas_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.canvas;
		}

		return null;
	}

	public static UnityEngine.Canvas GetImageCanvas_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.canvas;
		}

		return null;
	}

	public static UnityEngine.Canvas GetImageCanvas_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.canvas;
		}

		return null;
	}


	public static UnityEngine.CanvasRenderer GetImageCanvasRenderer_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.canvasRenderer;
		}

		return null;
	}

	public static UnityEngine.CanvasRenderer GetImageCanvasRenderer_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.canvasRenderer;
		}

		return null;
	}

	public static UnityEngine.CanvasRenderer GetImageCanvasRenderer_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.canvasRenderer;
		}

		return null;
	}


	public static UnityEngine.Material GetImageDefaultMaterial_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.defaultMaterial;
		}

		return null;
	}

	public static UnityEngine.Material GetImageDefaultMaterial_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.defaultMaterial;
		}

		return null;
	}

	public static UnityEngine.Material GetImageDefaultMaterial_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.defaultMaterial;
		}

		return null;
	}


	public static UnityEngine.Material GetImageMaterialForRendering_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.materialForRendering;
		}

		return null;
	}

	public static UnityEngine.Material GetImageMaterialForRendering_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.materialForRendering;
		}

		return null;
	}

	public static UnityEngine.Material GetImageMaterialForRendering_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.materialForRendering;
		}

		return null;
	}


	public static void OnCullingChanged_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.OnCullingChanged();
		}
	}

	public static void OnCullingChanged_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.OnCullingChanged();
		}
	}

	public static void OnCullingChanged_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.OnCullingChanged();
		}
	}


	public static void Rebuild_ByName(UnityEngine.UI.CanvasUpdate update, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.Rebuild(update);
		}
	}

	public static void Rebuild_ByPath(UnityEngine.UI.CanvasUpdate update, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.Rebuild(update);
		}
	}

	public static void Rebuild_ByOrgin(UnityEngine.UI.CanvasUpdate update, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.Rebuild(update);
		}
	}


	public static void LayoutComplete_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.LayoutComplete();
		}
	}


	public static void GraphicUpdateComplete_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.GraphicUpdateComplete();
		}
	}


	public static void OnRebuildRequested_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.OnRebuildRequested();
		}
	}

	public static void OnRebuildRequested_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.OnRebuildRequested();
		}
	}

	public static void OnRebuildRequested_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.OnRebuildRequested();
		}
	}


	public static System.Boolean Raycast_ByName(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Raycast_ByPath(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Raycast_ByOrgin(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Vector2 PixelAdjustPoint_ByName(UnityEngine.Vector2 point, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 PixelAdjustPoint_ByPath(UnityEngine.Vector2 point, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 PixelAdjustPoint_ByOrgin(UnityEngine.Vector2 point, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}


	public static UnityEngine.Rect GetPixelAdjustedRect_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetPixelAdjustedRect_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetPixelAdjustedRect_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}


	public static void CrossFadeColor_ByName(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}

	public static void CrossFadeColor_ByPath(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}

	public static void CrossFadeColor_ByOrgin(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}


	public static void CrossFadeColor_ByName(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}

	public static void CrossFadeColor_ByPath(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}

	public static void CrossFadeColor_ByOrgin(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}


	public static void CrossFadeAlpha_ByName(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}

	public static void CrossFadeAlpha_ByPath(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}

	public static void CrossFadeAlpha_ByOrgin(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}


	public static void RegisterDirtyLayoutCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.RegisterDirtyLayoutCallback(action);
		}
	}

	public static void RegisterDirtyLayoutCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.RegisterDirtyLayoutCallback(action);
		}
	}

	public static void RegisterDirtyLayoutCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.RegisterDirtyLayoutCallback(action);
		}
	}


	public static void UnregisterDirtyLayoutCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.UnregisterDirtyLayoutCallback(action);
		}
	}

	public static void UnregisterDirtyLayoutCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.UnregisterDirtyLayoutCallback(action);
		}
	}

	public static void UnregisterDirtyLayoutCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.UnregisterDirtyLayoutCallback(action);
		}
	}


	public static void RegisterDirtyVerticesCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.RegisterDirtyVerticesCallback(action);
		}
	}

	public static void RegisterDirtyVerticesCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.RegisterDirtyVerticesCallback(action);
		}
	}

	public static void RegisterDirtyVerticesCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.RegisterDirtyVerticesCallback(action);
		}
	}


	public static void UnregisterDirtyVerticesCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.UnregisterDirtyVerticesCallback(action);
		}
	}

	public static void UnregisterDirtyVerticesCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.UnregisterDirtyVerticesCallback(action);
		}
	}

	public static void UnregisterDirtyVerticesCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.UnregisterDirtyVerticesCallback(action);
		}
	}


	public static void RegisterDirtyMaterialCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.RegisterDirtyMaterialCallback(action);
		}
	}

	public static void RegisterDirtyMaterialCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.RegisterDirtyMaterialCallback(action);
		}
	}

	public static void RegisterDirtyMaterialCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.RegisterDirtyMaterialCallback(action);
		}
	}


	public static void UnregisterDirtyMaterialCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.UnregisterDirtyMaterialCallback(action);
		}
	}

	public static void UnregisterDirtyMaterialCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.UnregisterDirtyMaterialCallback(action);
		}
	}

	public static void UnregisterDirtyMaterialCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.UnregisterDirtyMaterialCallback(action);
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.StopAllCoroutines();
		}
	}


	public static System.Boolean GetImageUseGUILayout_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageUseGUILayout_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageUseGUILayout_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetImageUseGUILayout_ByName(System.Boolean value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.useGUILayout = value;
		}
	}

	public static void SetImageUseGUILayout_ByPath(System.Boolean value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.useGUILayout = value;
		}
	}

	public static void SetImageUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.useGUILayout = value;
		}
	}


	public static System.Boolean GetImageRunInEditMode_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageRunInEditMode_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageRunInEditMode_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetImageRunInEditMode_ByName(System.Boolean value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.runInEditMode = value;
		}
	}

	public static void SetImageRunInEditMode_ByPath(System.Boolean value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.runInEditMode = value;
		}
	}

	public static void SetImageRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.runInEditMode = value;
		}
	}


	public static System.Boolean GetImageEnabled_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageEnabled_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageEnabled_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetImageEnabled_ByName(System.Boolean value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.enabled = value;
		}
	}

	public static void SetImageEnabled_ByPath(System.Boolean value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.enabled = value;
		}
	}

	public static void SetImageEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.enabled = value;
		}
	}


	public static System.Boolean GetImageIsActiveAndEnabled_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageIsActiveAndEnabled_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetImageIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetImageTransform_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetImageTransform_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetImageTransform_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetImageGameObject_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetImageGameObject_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetImageGameObject_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.GetComponents(type, results);
		}
	}


	public static System.String GetImageTag_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.tag;
		}

		return null;
	}

	public static System.String GetImageTag_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.tag;
		}

		return null;
	}

	public static System.String GetImageTag_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.tag;
		}

		return null;
	}


	public static void SetImageTag_ByName(System.String value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.tag = value;
		}
	}

	public static void SetImageTag_ByPath(System.String value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.tag = value;
		}
	}

	public static void SetImageTag_ByOrgin(System.String value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetImageName_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.name;
		}

		return null;
	}

	public static System.String GetImageName_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.name;
		}

		return null;
	}

	public static System.String GetImageName_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.name;
		}

		return null;
	}


	public static void SetImageName_ByName(System.String value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.name = value;
		}
	}

	public static void SetImageName_ByPath(System.String value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.name = value;
		}
	}

	public static void SetImageName_ByOrgin(System.String value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.name = value;
		}
	}


	public static UnityEngine.HideFlags GetImageHideFlags_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetImageHideFlags_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetImageHideFlags_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetImageHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			image.hideFlags = value;
		}
	}

	public static void SetImageHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			image.hideFlags = value;
		}
	}

	public static void SetImageHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			image.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		Image image = GetImageByName(name);
		if(image != null)
		{
			return image.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		Image image = GetImageByPath(path);
		if(image != null)
		{
			return image.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		Image image = GetImageByOrgin(parentName, path);
		if(image != null)
		{
			return image.GetType();
		}

		return null;
	}


}

