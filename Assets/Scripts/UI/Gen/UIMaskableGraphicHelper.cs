using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.Events;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIMaskableGraphicHelper
{
	public static MaskableGraphic GetMaskableGraphicByName(string name)
	{
		return UIManager.GetComponentByName<MaskableGraphic>(name);
	}

	public static MaskableGraphic GetMaskableGraphicByPath(string path)
	{
		return UIManager.GetComponentByPath<MaskableGraphic>(path);
	}

	public static MaskableGraphic GetMaskableGraphicByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<MaskableGraphic>(parentName, path);
	}

	public static UnityEngine.UI.MaskableGraphic.CullStateChangedEvent GetMaskableGraphicOnCullStateChanged_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.onCullStateChanged;
		}

		return null;
	}

	public static UnityEngine.UI.MaskableGraphic.CullStateChangedEvent GetMaskableGraphicOnCullStateChanged_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.onCullStateChanged;
		}

		return null;
	}

	public static UnityEngine.UI.MaskableGraphic.CullStateChangedEvent GetMaskableGraphicOnCullStateChanged_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.onCullStateChanged;
		}

		return null;
	}


	public static void SetMaskableGraphicOnCullStateChanged_ByName(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.onCullStateChanged = value;
		}
	}

	public static void SetMaskableGraphicOnCullStateChanged_ByPath(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.onCullStateChanged = value;
		}
	}

	public static void SetMaskableGraphicOnCullStateChanged_ByOrgin(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.onCullStateChanged = value;
		}
	}


	public static System.Boolean GetMaskableGraphicMaskable_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.maskable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicMaskable_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.maskable;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicMaskable_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.maskable;
		}

		return default(System.Boolean);
	}


	public static void SetMaskableGraphicMaskable_ByName(System.Boolean value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.maskable = value;
		}
	}

	public static void SetMaskableGraphicMaskable_ByPath(System.Boolean value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.maskable = value;
		}
	}

	public static void SetMaskableGraphicMaskable_ByOrgin(System.Boolean value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.maskable = value;
		}
	}


	public static System.Boolean GetMaskableGraphicIsMaskingGraphic_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.isMaskingGraphic;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicIsMaskingGraphic_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.isMaskingGraphic;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicIsMaskingGraphic_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.isMaskingGraphic;
		}

		return default(System.Boolean);
	}


	public static void SetMaskableGraphicIsMaskingGraphic_ByName(System.Boolean value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.isMaskingGraphic = value;
		}
	}

	public static void SetMaskableGraphicIsMaskingGraphic_ByPath(System.Boolean value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.isMaskingGraphic = value;
		}
	}

	public static void SetMaskableGraphicIsMaskingGraphic_ByOrgin(System.Boolean value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.isMaskingGraphic = value;
		}
	}


	public static UnityEngine.Material GetModifiedMaterial_ByName(UnityEngine.Material baseMaterial, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}

	public static UnityEngine.Material GetModifiedMaterial_ByPath(UnityEngine.Material baseMaterial, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}

	public static UnityEngine.Material GetModifiedMaterial_ByOrgin(UnityEngine.Material baseMaterial, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetModifiedMaterial(baseMaterial);
		}

		return null;
	}


	public static void Cull_ByName(UnityEngine.Rect clipRect, System.Boolean validRect, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.Cull(clipRect, validRect);
		}
	}

	public static void Cull_ByPath(UnityEngine.Rect clipRect, System.Boolean validRect, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.Cull(clipRect, validRect);
		}
	}

	public static void Cull_ByOrgin(UnityEngine.Rect clipRect, System.Boolean validRect, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.Cull(clipRect, validRect);
		}
	}


	public static void SetClipRect_ByName(UnityEngine.Rect clipRect, System.Boolean validRect, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetClipRect(clipRect, validRect);
		}
	}

	public static void SetClipRect_ByPath(UnityEngine.Rect clipRect, System.Boolean validRect, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetClipRect(clipRect, validRect);
		}
	}

	public static void SetClipRect_ByOrgin(UnityEngine.Rect clipRect, System.Boolean validRect, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetClipRect(clipRect, validRect);
		}
	}


	public static void SetClipSoftness_ByName(UnityEngine.Vector2 clipSoftness, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetClipSoftness(clipSoftness);
		}
	}

	public static void SetClipSoftness_ByPath(UnityEngine.Vector2 clipSoftness, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetClipSoftness(clipSoftness);
		}
	}

	public static void SetClipSoftness_ByOrgin(UnityEngine.Vector2 clipSoftness, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetClipSoftness(clipSoftness);
		}
	}


	public static void RecalculateClipping_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.RecalculateClipping();
		}
	}

	public static void RecalculateClipping_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.RecalculateClipping();
		}
	}

	public static void RecalculateClipping_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.RecalculateClipping();
		}
	}


	public static void RecalculateMasking_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.RecalculateMasking();
		}
	}

	public static void RecalculateMasking_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.RecalculateMasking();
		}
	}

	public static void RecalculateMasking_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.RecalculateMasking();
		}
	}


	public static UnityEngine.Color GetMaskableGraphicColor_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.color;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetMaskableGraphicColor_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.color;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetMaskableGraphicColor_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.color;
		}

		return default(UnityEngine.Color);
	}


	public static void SetMaskableGraphicColor_ByName(UnityEngine.Color value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.color = value;
		}
	}

	public static void SetMaskableGraphicColor_ByPath(UnityEngine.Color value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.color = value;
		}
	}

	public static void SetMaskableGraphicColor_ByOrgin(UnityEngine.Color value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.color = value;
		}
	}


	public static System.Boolean GetMaskableGraphicRaycastTarget_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.raycastTarget;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicRaycastTarget_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.raycastTarget;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicRaycastTarget_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.raycastTarget;
		}

		return default(System.Boolean);
	}


	public static void SetMaskableGraphicRaycastTarget_ByName(System.Boolean value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.raycastTarget = value;
		}
	}

	public static void SetMaskableGraphicRaycastTarget_ByPath(System.Boolean value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.raycastTarget = value;
		}
	}

	public static void SetMaskableGraphicRaycastTarget_ByOrgin(System.Boolean value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.raycastTarget = value;
		}
	}


	public static UnityEngine.Vector4 GetMaskableGraphicRaycastPadding_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}

	public static UnityEngine.Vector4 GetMaskableGraphicRaycastPadding_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}

	public static UnityEngine.Vector4 GetMaskableGraphicRaycastPadding_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}


	public static void SetMaskableGraphicRaycastPadding_ByName(UnityEngine.Vector4 value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.raycastPadding = value;
		}
	}

	public static void SetMaskableGraphicRaycastPadding_ByPath(UnityEngine.Vector4 value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.raycastPadding = value;
		}
	}

	public static void SetMaskableGraphicRaycastPadding_ByOrgin(UnityEngine.Vector4 value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.raycastPadding = value;
		}
	}


	public static void SetAllDirty_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetAllDirty();
		}
	}

	public static void SetAllDirty_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetAllDirty();
		}
	}

	public static void SetAllDirty_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetAllDirty();
		}
	}


	public static void SetLayoutDirty_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetLayoutDirty();
		}
	}

	public static void SetLayoutDirty_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetLayoutDirty();
		}
	}

	public static void SetLayoutDirty_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetLayoutDirty();
		}
	}


	public static void SetVerticesDirty_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetVerticesDirty();
		}
	}

	public static void SetVerticesDirty_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetVerticesDirty();
		}
	}

	public static void SetVerticesDirty_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetVerticesDirty();
		}
	}


	public static void SetMaterialDirty_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetMaterialDirty();
		}
	}

	public static void SetMaterialDirty_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetMaterialDirty();
		}
	}

	public static void SetMaterialDirty_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetMaterialDirty();
		}
	}


	public static void SetRaycastDirty_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetRaycastDirty();
		}
	}

	public static void SetRaycastDirty_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetRaycastDirty();
		}
	}

	public static void SetRaycastDirty_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetRaycastDirty();
		}
	}


	public static System.Int32 GetMaskableGraphicDepth_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.depth;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetMaskableGraphicDepth_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.depth;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetMaskableGraphicDepth_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.depth;
		}

		return default(System.Int32);
	}


	public static UnityEngine.RectTransform GetMaskableGraphicRectTransform_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetMaskableGraphicRectTransform_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetMaskableGraphicRectTransform_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.rectTransform;
		}

		return null;
	}


	public static UnityEngine.Canvas GetMaskableGraphicCanvas_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.canvas;
		}

		return null;
	}

	public static UnityEngine.Canvas GetMaskableGraphicCanvas_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.canvas;
		}

		return null;
	}

	public static UnityEngine.Canvas GetMaskableGraphicCanvas_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.canvas;
		}

		return null;
	}


	public static UnityEngine.CanvasRenderer GetMaskableGraphicCanvasRenderer_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.canvasRenderer;
		}

		return null;
	}

	public static UnityEngine.CanvasRenderer GetMaskableGraphicCanvasRenderer_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.canvasRenderer;
		}

		return null;
	}

	public static UnityEngine.CanvasRenderer GetMaskableGraphicCanvasRenderer_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.canvasRenderer;
		}

		return null;
	}


	public static UnityEngine.Material GetMaskableGraphicDefaultMaterial_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.defaultMaterial;
		}

		return null;
	}

	public static UnityEngine.Material GetMaskableGraphicDefaultMaterial_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.defaultMaterial;
		}

		return null;
	}

	public static UnityEngine.Material GetMaskableGraphicDefaultMaterial_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.defaultMaterial;
		}

		return null;
	}


	public static UnityEngine.Material GetMaskableGraphicMaterial_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.material;
		}

		return null;
	}

	public static UnityEngine.Material GetMaskableGraphicMaterial_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.material;
		}

		return null;
	}

	public static UnityEngine.Material GetMaskableGraphicMaterial_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.material;
		}

		return null;
	}


	public static void SetMaskableGraphicMaterial_ByName(UnityEngine.Material value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.material = value;
		}
	}

	public static void SetMaskableGraphicMaterial_ByPath(UnityEngine.Material value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.material = value;
		}
	}

	public static void SetMaskableGraphicMaterial_ByOrgin(UnityEngine.Material value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.material = value;
		}
	}


	public static UnityEngine.Material GetMaskableGraphicMaterialForRendering_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.materialForRendering;
		}

		return null;
	}

	public static UnityEngine.Material GetMaskableGraphicMaterialForRendering_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.materialForRendering;
		}

		return null;
	}

	public static UnityEngine.Material GetMaskableGraphicMaterialForRendering_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.materialForRendering;
		}

		return null;
	}


	public static UnityEngine.Texture GetMaskableGraphicMainTexture_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.mainTexture;
		}

		return null;
	}

	public static UnityEngine.Texture GetMaskableGraphicMainTexture_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.mainTexture;
		}

		return null;
	}

	public static UnityEngine.Texture GetMaskableGraphicMainTexture_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.mainTexture;
		}

		return null;
	}


	public static void OnCullingChanged_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.OnCullingChanged();
		}
	}

	public static void OnCullingChanged_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.OnCullingChanged();
		}
	}

	public static void OnCullingChanged_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.OnCullingChanged();
		}
	}


	public static void Rebuild_ByName(UnityEngine.UI.CanvasUpdate update, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.Rebuild(update);
		}
	}

	public static void Rebuild_ByPath(UnityEngine.UI.CanvasUpdate update, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.Rebuild(update);
		}
	}

	public static void Rebuild_ByOrgin(UnityEngine.UI.CanvasUpdate update, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.Rebuild(update);
		}
	}


	public static void LayoutComplete_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.LayoutComplete();
		}
	}


	public static void GraphicUpdateComplete_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.GraphicUpdateComplete();
		}
	}


	public static void OnRebuildRequested_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.OnRebuildRequested();
		}
	}

	public static void OnRebuildRequested_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.OnRebuildRequested();
		}
	}

	public static void OnRebuildRequested_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.OnRebuildRequested();
		}
	}


	public static void SetNativeSize_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetNativeSize();
		}
	}

	public static void SetNativeSize_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetNativeSize();
		}
	}

	public static void SetNativeSize_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SetNativeSize();
		}
	}


	public static System.Boolean Raycast_ByName(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Raycast_ByPath(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Raycast_ByOrgin(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Vector2 PixelAdjustPoint_ByName(UnityEngine.Vector2 point, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 PixelAdjustPoint_ByPath(UnityEngine.Vector2 point, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 PixelAdjustPoint_ByOrgin(UnityEngine.Vector2 point, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}


	public static UnityEngine.Rect GetPixelAdjustedRect_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetPixelAdjustedRect_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetPixelAdjustedRect_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}


	public static void CrossFadeColor_ByName(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}

	public static void CrossFadeColor_ByPath(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}

	public static void CrossFadeColor_ByOrgin(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}


	public static void CrossFadeColor_ByName(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}

	public static void CrossFadeColor_ByPath(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}

	public static void CrossFadeColor_ByOrgin(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}


	public static void CrossFadeAlpha_ByName(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}

	public static void CrossFadeAlpha_ByPath(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}

	public static void CrossFadeAlpha_ByOrgin(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}


	public static void RegisterDirtyLayoutCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.RegisterDirtyLayoutCallback(action);
		}
	}

	public static void RegisterDirtyLayoutCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.RegisterDirtyLayoutCallback(action);
		}
	}

	public static void RegisterDirtyLayoutCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.RegisterDirtyLayoutCallback(action);
		}
	}


	public static void UnregisterDirtyLayoutCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.UnregisterDirtyLayoutCallback(action);
		}
	}

	public static void UnregisterDirtyLayoutCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.UnregisterDirtyLayoutCallback(action);
		}
	}

	public static void UnregisterDirtyLayoutCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.UnregisterDirtyLayoutCallback(action);
		}
	}


	public static void RegisterDirtyVerticesCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.RegisterDirtyVerticesCallback(action);
		}
	}

	public static void RegisterDirtyVerticesCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.RegisterDirtyVerticesCallback(action);
		}
	}

	public static void RegisterDirtyVerticesCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.RegisterDirtyVerticesCallback(action);
		}
	}


	public static void UnregisterDirtyVerticesCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.UnregisterDirtyVerticesCallback(action);
		}
	}

	public static void UnregisterDirtyVerticesCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.UnregisterDirtyVerticesCallback(action);
		}
	}

	public static void UnregisterDirtyVerticesCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.UnregisterDirtyVerticesCallback(action);
		}
	}


	public static void RegisterDirtyMaterialCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.RegisterDirtyMaterialCallback(action);
		}
	}

	public static void RegisterDirtyMaterialCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.RegisterDirtyMaterialCallback(action);
		}
	}

	public static void RegisterDirtyMaterialCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.RegisterDirtyMaterialCallback(action);
		}
	}


	public static void UnregisterDirtyMaterialCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.UnregisterDirtyMaterialCallback(action);
		}
	}

	public static void UnregisterDirtyMaterialCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.UnregisterDirtyMaterialCallback(action);
		}
	}

	public static void UnregisterDirtyMaterialCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.UnregisterDirtyMaterialCallback(action);
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.StopAllCoroutines();
		}
	}


	public static System.Boolean GetMaskableGraphicUseGUILayout_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicUseGUILayout_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicUseGUILayout_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetMaskableGraphicUseGUILayout_ByName(System.Boolean value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.useGUILayout = value;
		}
	}

	public static void SetMaskableGraphicUseGUILayout_ByPath(System.Boolean value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.useGUILayout = value;
		}
	}

	public static void SetMaskableGraphicUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.useGUILayout = value;
		}
	}


	public static System.Boolean GetMaskableGraphicRunInEditMode_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicRunInEditMode_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicRunInEditMode_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetMaskableGraphicRunInEditMode_ByName(System.Boolean value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.runInEditMode = value;
		}
	}

	public static void SetMaskableGraphicRunInEditMode_ByPath(System.Boolean value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.runInEditMode = value;
		}
	}

	public static void SetMaskableGraphicRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.runInEditMode = value;
		}
	}


	public static System.Boolean GetMaskableGraphicEnabled_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicEnabled_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicEnabled_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetMaskableGraphicEnabled_ByName(System.Boolean value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.enabled = value;
		}
	}

	public static void SetMaskableGraphicEnabled_ByPath(System.Boolean value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.enabled = value;
		}
	}

	public static void SetMaskableGraphicEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.enabled = value;
		}
	}


	public static System.Boolean GetMaskableGraphicIsActiveAndEnabled_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicIsActiveAndEnabled_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetMaskableGraphicIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetMaskableGraphicTransform_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetMaskableGraphicTransform_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetMaskableGraphicTransform_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetMaskableGraphicGameObject_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetMaskableGraphicGameObject_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetMaskableGraphicGameObject_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.GetComponents(type, results);
		}
	}


	public static System.String GetMaskableGraphicTag_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.tag;
		}

		return null;
	}

	public static System.String GetMaskableGraphicTag_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.tag;
		}

		return null;
	}

	public static System.String GetMaskableGraphicTag_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.tag;
		}

		return null;
	}


	public static void SetMaskableGraphicTag_ByName(System.String value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.tag = value;
		}
	}

	public static void SetMaskableGraphicTag_ByPath(System.String value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.tag = value;
		}
	}

	public static void SetMaskableGraphicTag_ByOrgin(System.String value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetMaskableGraphicName_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.name;
		}

		return null;
	}

	public static System.String GetMaskableGraphicName_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.name;
		}

		return null;
	}

	public static System.String GetMaskableGraphicName_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.name;
		}

		return null;
	}


	public static void SetMaskableGraphicName_ByName(System.String value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.name = value;
		}
	}

	public static void SetMaskableGraphicName_ByPath(System.String value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.name = value;
		}
	}

	public static void SetMaskableGraphicName_ByOrgin(System.String value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.name = value;
		}
	}


	public static UnityEngine.HideFlags GetMaskableGraphicHideFlags_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetMaskableGraphicHideFlags_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetMaskableGraphicHideFlags_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetMaskableGraphicHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			maskablegraphic.hideFlags = value;
		}
	}

	public static void SetMaskableGraphicHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			maskablegraphic.hideFlags = value;
		}
	}

	public static void SetMaskableGraphicHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			maskablegraphic.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByName(name);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByPath(path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		MaskableGraphic maskablegraphic = GetMaskableGraphicByOrgin(parentName, path);
		if(maskablegraphic != null)
		{
			return maskablegraphic.GetType();
		}

		return null;
	}


}

