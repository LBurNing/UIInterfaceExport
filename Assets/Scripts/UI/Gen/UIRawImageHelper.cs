using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.Events;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIRawImageHelper
{
	public static RawImage GetRawImageByName(string name)
	{
		return UIManager.GetComponentByName<RawImage>(name);
	}

	public static RawImage GetRawImageByPath(string path)
	{
		return UIManager.GetComponentByPath<RawImage>(path);
	}

	public static RawImage GetRawImageByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<RawImage>(parentName, path);
	}

	public static UnityEngine.Texture GetRawImageMainTexture_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.mainTexture;
		}

		return null;
	}

	public static UnityEngine.Texture GetRawImageMainTexture_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.mainTexture;
		}

		return null;
	}

	public static UnityEngine.Texture GetRawImageMainTexture_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.mainTexture;
		}

		return null;
	}


	public static UnityEngine.Texture GetRawImageTexture_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.texture;
		}

		return null;
	}

	public static UnityEngine.Texture GetRawImageTexture_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.texture;
		}

		return null;
	}

	public static UnityEngine.Texture GetRawImageTexture_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.texture;
		}

		return null;
	}


	public static void SetRawImageTexture_ByName(UnityEngine.Texture value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.texture = value;
		}
	}

	public static void SetRawImageTexture_ByPath(UnityEngine.Texture value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.texture = value;
		}
	}

	public static void SetRawImageTexture_ByOrgin(UnityEngine.Texture value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.texture = value;
		}
	}


	public static UnityEngine.Rect GetRawImageUvRect_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.uvRect;
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetRawImageUvRect_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.uvRect;
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetRawImageUvRect_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.uvRect;
		}

		return default(UnityEngine.Rect);
	}


	public static void SetRawImageUvRect_ByName(UnityEngine.Rect value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.uvRect = value;
		}
	}

	public static void SetRawImageUvRect_ByPath(UnityEngine.Rect value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.uvRect = value;
		}
	}

	public static void SetRawImageUvRect_ByOrgin(UnityEngine.Rect value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.uvRect = value;
		}
	}


	public static void SetNativeSize_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SetNativeSize();
		}
	}

	public static void SetNativeSize_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SetNativeSize();
		}
	}

	public static void SetNativeSize_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SetNativeSize();
		}
	}


	public static UnityEngine.UI.MaskableGraphic.CullStateChangedEvent GetRawImageOnCullStateChanged_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.onCullStateChanged;
		}

		return null;
	}

	public static UnityEngine.UI.MaskableGraphic.CullStateChangedEvent GetRawImageOnCullStateChanged_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.onCullStateChanged;
		}

		return null;
	}

	public static UnityEngine.UI.MaskableGraphic.CullStateChangedEvent GetRawImageOnCullStateChanged_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.onCullStateChanged;
		}

		return null;
	}


	public static void SetRawImageOnCullStateChanged_ByName(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.onCullStateChanged = value;
		}
	}

	public static void SetRawImageOnCullStateChanged_ByPath(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.onCullStateChanged = value;
		}
	}

	public static void SetRawImageOnCullStateChanged_ByOrgin(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.onCullStateChanged = value;
		}
	}


	public static System.Boolean GetRawImageMaskable_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.maskable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageMaskable_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.maskable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageMaskable_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.maskable;
		}

		return default(System.Boolean);
	}


	public static void SetRawImageMaskable_ByName(System.Boolean value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.maskable = value;
		}
	}

	public static void SetRawImageMaskable_ByPath(System.Boolean value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.maskable = value;
		}
	}

	public static void SetRawImageMaskable_ByOrgin(System.Boolean value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.maskable = value;
		}
	}


	public static System.Boolean GetRawImageIsMaskingGraphic_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.isMaskingGraphic;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageIsMaskingGraphic_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.isMaskingGraphic;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageIsMaskingGraphic_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.isMaskingGraphic;
		}

		return default(System.Boolean);
	}


	public static void SetRawImageIsMaskingGraphic_ByName(System.Boolean value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.isMaskingGraphic = value;
		}
	}

	public static void SetRawImageIsMaskingGraphic_ByPath(System.Boolean value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.isMaskingGraphic = value;
		}
	}

	public static void SetRawImageIsMaskingGraphic_ByOrgin(System.Boolean value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.isMaskingGraphic = value;
		}
	}


	public static UnityEngine.Material GetModifiedMaterial_ByName(UnityEngine.Material baseMaterial, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}

	public static UnityEngine.Material GetModifiedMaterial_ByPath(UnityEngine.Material baseMaterial, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}

	public static UnityEngine.Material GetModifiedMaterial_ByOrgin(UnityEngine.Material baseMaterial, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}


	public static void Cull_ByName(UnityEngine.Rect clipRect, System.Boolean validRect, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.Cull(clipRect, validRect);
		}
	}

	public static void Cull_ByPath(UnityEngine.Rect clipRect, System.Boolean validRect, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.Cull(clipRect, validRect);
		}
	}

	public static void Cull_ByOrgin(UnityEngine.Rect clipRect, System.Boolean validRect, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.Cull(clipRect, validRect);
		}
	}


	public static void SetClipRect_ByName(UnityEngine.Rect clipRect, System.Boolean validRect, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SetClipRect(clipRect, validRect);
		}
	}

	public static void SetClipRect_ByPath(UnityEngine.Rect clipRect, System.Boolean validRect, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SetClipRect(clipRect, validRect);
		}
	}

	public static void SetClipRect_ByOrgin(UnityEngine.Rect clipRect, System.Boolean validRect, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SetClipRect(clipRect, validRect);
		}
	}


	public static void SetClipSoftness_ByName(UnityEngine.Vector2 clipSoftness, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SetClipSoftness(clipSoftness);
		}
	}

	public static void SetClipSoftness_ByPath(UnityEngine.Vector2 clipSoftness, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SetClipSoftness(clipSoftness);
		}
	}

	public static void SetClipSoftness_ByOrgin(UnityEngine.Vector2 clipSoftness, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SetClipSoftness(clipSoftness);
		}
	}


	public static void RecalculateClipping_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.RecalculateClipping();
		}
	}

	public static void RecalculateClipping_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.RecalculateClipping();
		}
	}

	public static void RecalculateClipping_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.RecalculateClipping();
		}
	}


	public static void RecalculateMasking_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.RecalculateMasking();
		}
	}

	public static void RecalculateMasking_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.RecalculateMasking();
		}
	}

	public static void RecalculateMasking_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.RecalculateMasking();
		}
	}


	public static UnityEngine.Color GetRawImageColor_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.color;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetRawImageColor_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.color;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetRawImageColor_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.color;
		}

		return default(UnityEngine.Color);
	}


	public static void SetRawImageColor_ByName(UnityEngine.Color value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.color = value;
		}
	}

	public static void SetRawImageColor_ByPath(UnityEngine.Color value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.color = value;
		}
	}

	public static void SetRawImageColor_ByOrgin(UnityEngine.Color value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.color = value;
		}
	}


	public static System.Boolean GetRawImageRaycastTarget_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.raycastTarget;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageRaycastTarget_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.raycastTarget;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageRaycastTarget_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.raycastTarget;
		}

		return default(System.Boolean);
	}


	public static void SetRawImageRaycastTarget_ByName(System.Boolean value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.raycastTarget = value;
		}
	}

	public static void SetRawImageRaycastTarget_ByPath(System.Boolean value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.raycastTarget = value;
		}
	}

	public static void SetRawImageRaycastTarget_ByOrgin(System.Boolean value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.raycastTarget = value;
		}
	}


	public static UnityEngine.Vector4 GetRawImageRaycastPadding_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}

	public static UnityEngine.Vector4 GetRawImageRaycastPadding_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}

	public static UnityEngine.Vector4 GetRawImageRaycastPadding_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}


	public static void SetRawImageRaycastPadding_ByName(UnityEngine.Vector4 value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.raycastPadding = value;
		}
	}

	public static void SetRawImageRaycastPadding_ByPath(UnityEngine.Vector4 value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.raycastPadding = value;
		}
	}

	public static void SetRawImageRaycastPadding_ByOrgin(UnityEngine.Vector4 value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.raycastPadding = value;
		}
	}


	public static void SetAllDirty_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SetAllDirty();
		}
	}

	public static void SetAllDirty_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SetAllDirty();
		}
	}

	public static void SetAllDirty_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SetAllDirty();
		}
	}


	public static void SetLayoutDirty_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SetLayoutDirty();
		}
	}

	public static void SetLayoutDirty_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SetLayoutDirty();
		}
	}

	public static void SetLayoutDirty_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SetLayoutDirty();
		}
	}


	public static void SetVerticesDirty_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SetVerticesDirty();
		}
	}

	public static void SetVerticesDirty_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SetVerticesDirty();
		}
	}

	public static void SetVerticesDirty_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SetVerticesDirty();
		}
	}


	public static void SetMaterialDirty_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SetMaterialDirty();
		}
	}

	public static void SetMaterialDirty_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SetMaterialDirty();
		}
	}

	public static void SetMaterialDirty_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SetMaterialDirty();
		}
	}


	public static void SetRaycastDirty_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SetRaycastDirty();
		}
	}

	public static void SetRaycastDirty_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SetRaycastDirty();
		}
	}

	public static void SetRaycastDirty_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SetRaycastDirty();
		}
	}


	public static System.Int32 GetRawImageDepth_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.depth;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetRawImageDepth_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.depth;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetRawImageDepth_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.depth;
		}

		return default(System.Int32);
	}


	public static UnityEngine.RectTransform GetRawImageRectTransform_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetRawImageRectTransform_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetRawImageRectTransform_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.rectTransform;
		}

		return null;
	}


	public static UnityEngine.Canvas GetRawImageCanvas_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.canvas;
		}

		return null;
	}

	public static UnityEngine.Canvas GetRawImageCanvas_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.canvas;
		}

		return null;
	}

	public static UnityEngine.Canvas GetRawImageCanvas_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.canvas;
		}

		return null;
	}


	public static UnityEngine.CanvasRenderer GetRawImageCanvasRenderer_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.canvasRenderer;
		}

		return null;
	}

	public static UnityEngine.CanvasRenderer GetRawImageCanvasRenderer_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.canvasRenderer;
		}

		return null;
	}

	public static UnityEngine.CanvasRenderer GetRawImageCanvasRenderer_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.canvasRenderer;
		}

		return null;
	}


	public static UnityEngine.Material GetRawImageDefaultMaterial_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.defaultMaterial;
		}

		return null;
	}

	public static UnityEngine.Material GetRawImageDefaultMaterial_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.defaultMaterial;
		}

		return null;
	}

	public static UnityEngine.Material GetRawImageDefaultMaterial_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.defaultMaterial;
		}

		return null;
	}


	public static UnityEngine.Material GetRawImageMaterial_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.material;
		}

		return null;
	}

	public static UnityEngine.Material GetRawImageMaterial_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.material;
		}

		return null;
	}

	public static UnityEngine.Material GetRawImageMaterial_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.material;
		}

		return null;
	}


	public static void SetRawImageMaterial_ByName(UnityEngine.Material value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.material = value;
		}
	}

	public static void SetRawImageMaterial_ByPath(UnityEngine.Material value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.material = value;
		}
	}

	public static void SetRawImageMaterial_ByOrgin(UnityEngine.Material value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.material = value;
		}
	}


	public static UnityEngine.Material GetRawImageMaterialForRendering_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.materialForRendering;
		}

		return null;
	}

	public static UnityEngine.Material GetRawImageMaterialForRendering_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.materialForRendering;
		}

		return null;
	}

	public static UnityEngine.Material GetRawImageMaterialForRendering_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.materialForRendering;
		}

		return null;
	}


	public static void OnCullingChanged_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.OnCullingChanged();
		}
	}

	public static void OnCullingChanged_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.OnCullingChanged();
		}
	}

	public static void OnCullingChanged_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.OnCullingChanged();
		}
	}


	public static void Rebuild_ByName(UnityEngine.UI.CanvasUpdate update, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.Rebuild(update);
		}
	}

	public static void Rebuild_ByPath(UnityEngine.UI.CanvasUpdate update, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.Rebuild(update);
		}
	}

	public static void Rebuild_ByOrgin(UnityEngine.UI.CanvasUpdate update, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.Rebuild(update);
		}
	}


	public static void LayoutComplete_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.LayoutComplete();
		}
	}


	public static void GraphicUpdateComplete_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.GraphicUpdateComplete();
		}
	}


	public static void OnRebuildRequested_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.OnRebuildRequested();
		}
	}

	public static void OnRebuildRequested_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.OnRebuildRequested();
		}
	}

	public static void OnRebuildRequested_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.OnRebuildRequested();
		}
	}


	public static System.Boolean Raycast_ByName(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Raycast_ByPath(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Raycast_ByOrgin(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Vector2 PixelAdjustPoint_ByName(UnityEngine.Vector2 point, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 PixelAdjustPoint_ByPath(UnityEngine.Vector2 point, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 PixelAdjustPoint_ByOrgin(UnityEngine.Vector2 point, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}


	public static UnityEngine.Rect GetPixelAdjustedRect_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetPixelAdjustedRect_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetPixelAdjustedRect_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}


	public static void CrossFadeColor_ByName(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}

	public static void CrossFadeColor_ByPath(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}

	public static void CrossFadeColor_ByOrgin(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}


	public static void CrossFadeColor_ByName(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}

	public static void CrossFadeColor_ByPath(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}

	public static void CrossFadeColor_ByOrgin(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}


	public static void CrossFadeAlpha_ByName(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}

	public static void CrossFadeAlpha_ByPath(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}

	public static void CrossFadeAlpha_ByOrgin(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}


	public static void RegisterDirtyLayoutCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.RegisterDirtyLayoutCallback(action);
		}
	}

	public static void RegisterDirtyLayoutCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.RegisterDirtyLayoutCallback(action);
		}
	}

	public static void RegisterDirtyLayoutCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.RegisterDirtyLayoutCallback(action);
		}
	}


	public static void UnregisterDirtyLayoutCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.UnregisterDirtyLayoutCallback(action);
		}
	}

	public static void UnregisterDirtyLayoutCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.UnregisterDirtyLayoutCallback(action);
		}
	}

	public static void UnregisterDirtyLayoutCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.UnregisterDirtyLayoutCallback(action);
		}
	}


	public static void RegisterDirtyVerticesCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.RegisterDirtyVerticesCallback(action);
		}
	}

	public static void RegisterDirtyVerticesCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.RegisterDirtyVerticesCallback(action);
		}
	}

	public static void RegisterDirtyVerticesCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.RegisterDirtyVerticesCallback(action);
		}
	}


	public static void UnregisterDirtyVerticesCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.UnregisterDirtyVerticesCallback(action);
		}
	}

	public static void UnregisterDirtyVerticesCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.UnregisterDirtyVerticesCallback(action);
		}
	}

	public static void UnregisterDirtyVerticesCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.UnregisterDirtyVerticesCallback(action);
		}
	}


	public static void RegisterDirtyMaterialCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.RegisterDirtyMaterialCallback(action);
		}
	}

	public static void RegisterDirtyMaterialCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.RegisterDirtyMaterialCallback(action);
		}
	}

	public static void RegisterDirtyMaterialCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.RegisterDirtyMaterialCallback(action);
		}
	}


	public static void UnregisterDirtyMaterialCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.UnregisterDirtyMaterialCallback(action);
		}
	}

	public static void UnregisterDirtyMaterialCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.UnregisterDirtyMaterialCallback(action);
		}
	}

	public static void UnregisterDirtyMaterialCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.UnregisterDirtyMaterialCallback(action);
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.StopAllCoroutines();
		}
	}


	public static System.Boolean GetRawImageUseGUILayout_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageUseGUILayout_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageUseGUILayout_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetRawImageUseGUILayout_ByName(System.Boolean value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.useGUILayout = value;
		}
	}

	public static void SetRawImageUseGUILayout_ByPath(System.Boolean value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.useGUILayout = value;
		}
	}

	public static void SetRawImageUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.useGUILayout = value;
		}
	}


	public static System.Boolean GetRawImageRunInEditMode_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageRunInEditMode_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageRunInEditMode_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetRawImageRunInEditMode_ByName(System.Boolean value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.runInEditMode = value;
		}
	}

	public static void SetRawImageRunInEditMode_ByPath(System.Boolean value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.runInEditMode = value;
		}
	}

	public static void SetRawImageRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.runInEditMode = value;
		}
	}


	public static System.Boolean GetRawImageEnabled_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageEnabled_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageEnabled_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetRawImageEnabled_ByName(System.Boolean value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.enabled = value;
		}
	}

	public static void SetRawImageEnabled_ByPath(System.Boolean value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.enabled = value;
		}
	}

	public static void SetRawImageEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.enabled = value;
		}
	}


	public static System.Boolean GetRawImageIsActiveAndEnabled_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageIsActiveAndEnabled_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetRawImageIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetRawImageTransform_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetRawImageTransform_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetRawImageTransform_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetRawImageGameObject_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetRawImageGameObject_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetRawImageGameObject_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.GetComponents(type, results);
		}
	}


	public static System.String GetRawImageTag_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.tag;
		}

		return null;
	}

	public static System.String GetRawImageTag_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.tag;
		}

		return null;
	}

	public static System.String GetRawImageTag_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.tag;
		}

		return null;
	}


	public static void SetRawImageTag_ByName(System.String value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.tag = value;
		}
	}

	public static void SetRawImageTag_ByPath(System.String value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.tag = value;
		}
	}

	public static void SetRawImageTag_ByOrgin(System.String value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetRawImageName_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.name;
		}

		return null;
	}

	public static System.String GetRawImageName_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.name;
		}

		return null;
	}

	public static System.String GetRawImageName_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.name;
		}

		return null;
	}


	public static void SetRawImageName_ByName(System.String value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.name = value;
		}
	}

	public static void SetRawImageName_ByPath(System.String value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.name = value;
		}
	}

	public static void SetRawImageName_ByOrgin(System.String value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.name = value;
		}
	}


	public static UnityEngine.HideFlags GetRawImageHideFlags_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetRawImageHideFlags_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetRawImageHideFlags_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetRawImageHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			rawimage.hideFlags = value;
		}
	}

	public static void SetRawImageHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			rawimage.hideFlags = value;
		}
	}

	public static void SetRawImageHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			rawimage.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		RawImage rawimage = GetRawImageByName(name);
		if(rawimage != null)
		{
			return rawimage.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		RawImage rawimage = GetRawImageByPath(path);
		if(rawimage != null)
		{
			return rawimage.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		RawImage rawimage = GetRawImageByOrgin(parentName, path);
		if(rawimage != null)
		{
			return rawimage.GetType();
		}

		return null;
	}


}

