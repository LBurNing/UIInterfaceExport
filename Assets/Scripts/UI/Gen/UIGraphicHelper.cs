using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.Events;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIGraphicHelper
{
	public static Graphic GetGraphicByName(string name)
	{
		return UIManager.GetComponentByName<Graphic>(name);
	}

	public static Graphic GetGraphicByPath(string path)
	{
		return UIManager.GetComponentByPath<Graphic>(path);
	}

	public static Graphic GetGraphicByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<Graphic>(parentName, path);
	}

	public static UnityEngine.Color GetGraphicColor_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.color;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetGraphicColor_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.color;
		}

		return default(UnityEngine.Color);
	}

	public static UnityEngine.Color GetGraphicColor_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.color;
		}

		return default(UnityEngine.Color);
	}


	public static void SetGraphicColor_ByName(UnityEngine.Color value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.color = value;
		}
	}

	public static void SetGraphicColor_ByPath(UnityEngine.Color value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.color = value;
		}
	}

	public static void SetGraphicColor_ByOrgin(UnityEngine.Color value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.color = value;
		}
	}


	public static System.Boolean GetGraphicRaycastTarget_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.raycastTarget;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRaycastTarget_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.raycastTarget;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRaycastTarget_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.raycastTarget;
		}

		return default(System.Boolean);
	}


	public static void SetGraphicRaycastTarget_ByName(System.Boolean value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.raycastTarget = value;
		}
	}

	public static void SetGraphicRaycastTarget_ByPath(System.Boolean value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.raycastTarget = value;
		}
	}

	public static void SetGraphicRaycastTarget_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.raycastTarget = value;
		}
	}


	public static UnityEngine.Vector4 GetGraphicRaycastPadding_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}

	public static UnityEngine.Vector4 GetGraphicRaycastPadding_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}

	public static UnityEngine.Vector4 GetGraphicRaycastPadding_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.raycastPadding;
		}

		return default(UnityEngine.Vector4);
	}


	public static void SetGraphicRaycastPadding_ByName(UnityEngine.Vector4 value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.raycastPadding = value;
		}
	}

	public static void SetGraphicRaycastPadding_ByPath(UnityEngine.Vector4 value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.raycastPadding = value;
		}
	}

	public static void SetGraphicRaycastPadding_ByOrgin(UnityEngine.Vector4 value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.raycastPadding = value;
		}
	}


	public static void SetAllDirty_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SetAllDirty();
		}
	}

	public static void SetAllDirty_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SetAllDirty();
		}
	}

	public static void SetAllDirty_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SetAllDirty();
		}
	}


	public static void SetLayoutDirty_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SetLayoutDirty();
		}
	}

	public static void SetLayoutDirty_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SetLayoutDirty();
		}
	}

	public static void SetLayoutDirty_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SetLayoutDirty();
		}
	}


	public static void SetVerticesDirty_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SetVerticesDirty();
		}
	}

	public static void SetVerticesDirty_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SetVerticesDirty();
		}
	}

	public static void SetVerticesDirty_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SetVerticesDirty();
		}
	}


	public static void SetMaterialDirty_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SetMaterialDirty();
		}
	}

	public static void SetMaterialDirty_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SetMaterialDirty();
		}
	}

	public static void SetMaterialDirty_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SetMaterialDirty();
		}
	}


	public static void SetRaycastDirty_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SetRaycastDirty();
		}
	}

	public static void SetRaycastDirty_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SetRaycastDirty();
		}
	}

	public static void SetRaycastDirty_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SetRaycastDirty();
		}
	}


	public static System.Int32 GetGraphicDepth_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.depth;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetGraphicDepth_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.depth;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetGraphicDepth_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.depth;
		}

		return default(System.Int32);
	}


	public static UnityEngine.RectTransform GetGraphicRectTransform_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetGraphicRectTransform_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.rectTransform;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetGraphicRectTransform_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.rectTransform;
		}

		return null;
	}


	public static UnityEngine.Canvas GetGraphicCanvas_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.canvas;
		}

		return null;
	}

	public static UnityEngine.Canvas GetGraphicCanvas_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.canvas;
		}

		return null;
	}

	public static UnityEngine.Canvas GetGraphicCanvas_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.canvas;
		}

		return null;
	}


	public static UnityEngine.CanvasRenderer GetGraphicCanvasRenderer_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.canvasRenderer;
		}

		return null;
	}

	public static UnityEngine.CanvasRenderer GetGraphicCanvasRenderer_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.canvasRenderer;
		}

		return null;
	}

	public static UnityEngine.CanvasRenderer GetGraphicCanvasRenderer_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.canvasRenderer;
		}

		return null;
	}


	public static UnityEngine.Material GetGraphicDefaultMaterial_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.defaultMaterial;
		}

		return null;
	}

	public static UnityEngine.Material GetGraphicDefaultMaterial_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.defaultMaterial;
		}

		return null;
	}

	public static UnityEngine.Material GetGraphicDefaultMaterial_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.defaultMaterial;
		}

		return null;
	}


	public static UnityEngine.Material GetGraphicMaterial_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.material;
		}

		return null;
	}

	public static UnityEngine.Material GetGraphicMaterial_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.material;
		}

		return null;
	}

	public static UnityEngine.Material GetGraphicMaterial_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.material;
		}

		return null;
	}


	public static void SetGraphicMaterial_ByName(UnityEngine.Material value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.material = value;
		}
	}

	public static void SetGraphicMaterial_ByPath(UnityEngine.Material value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.material = value;
		}
	}

	public static void SetGraphicMaterial_ByOrgin(UnityEngine.Material value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.material = value;
		}
	}


	public static UnityEngine.Material GetGraphicMaterialForRendering_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.materialForRendering;
		}

		return null;
	}

	public static UnityEngine.Material GetGraphicMaterialForRendering_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.materialForRendering;
		}

		return null;
	}

	public static UnityEngine.Material GetGraphicMaterialForRendering_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.materialForRendering;
		}

		return null;
	}


	public static UnityEngine.Texture GetGraphicMainTexture_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.mainTexture;
		}

		return null;
	}

	public static UnityEngine.Texture GetGraphicMainTexture_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.mainTexture;
		}

		return null;
	}

	public static UnityEngine.Texture GetGraphicMainTexture_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.mainTexture;
		}

		return null;
	}


	public static void OnCullingChanged_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.OnCullingChanged();
		}
	}

	public static void OnCullingChanged_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.OnCullingChanged();
		}
	}

	public static void OnCullingChanged_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.OnCullingChanged();
		}
	}


	public static void Rebuild_ByName(UnityEngine.UI.CanvasUpdate update, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.Rebuild(update);
		}
	}

	public static void Rebuild_ByPath(UnityEngine.UI.CanvasUpdate update, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.Rebuild(update);
		}
	}

	public static void Rebuild_ByOrgin(UnityEngine.UI.CanvasUpdate update, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.Rebuild(update);
		}
	}


	public static void LayoutComplete_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.LayoutComplete();
		}
	}


	public static void GraphicUpdateComplete_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.GraphicUpdateComplete();
		}
	}


	public static void OnRebuildRequested_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.OnRebuildRequested();
		}
	}

	public static void OnRebuildRequested_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.OnRebuildRequested();
		}
	}

	public static void OnRebuildRequested_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.OnRebuildRequested();
		}
	}


	public static void SetNativeSize_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SetNativeSize();
		}
	}

	public static void SetNativeSize_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SetNativeSize();
		}
	}

	public static void SetNativeSize_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SetNativeSize();
		}
	}


	public static System.Boolean Raycast_ByName(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Raycast_ByPath(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Raycast_ByOrgin(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.Raycast(sp, eventCamera);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Vector2 PixelAdjustPoint_ByName(UnityEngine.Vector2 point, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 PixelAdjustPoint_ByPath(UnityEngine.Vector2 point, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 PixelAdjustPoint_ByOrgin(UnityEngine.Vector2 point, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.PixelAdjustPoint(point);
		}

		return default(UnityEngine.Vector2);
	}


	public static UnityEngine.Rect GetPixelAdjustedRect_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetPixelAdjustedRect_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}

	public static UnityEngine.Rect GetPixelAdjustedRect_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetPixelAdjustedRect();
		}

		return default(UnityEngine.Rect);
	}


	public static void CrossFadeColor_ByName(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}

	public static void CrossFadeColor_ByPath(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}

	public static void CrossFadeColor_ByOrgin(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha);
		}
	}


	public static void CrossFadeColor_ByName(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}

	public static void CrossFadeColor_ByPath(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}

	public static void CrossFadeColor_ByOrgin(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.CrossFadeColor(targetColor, duration, ignoreTimeScale, useAlpha, useRGB);
		}
	}


	public static void CrossFadeAlpha_ByName(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}

	public static void CrossFadeAlpha_ByPath(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}

	public static void CrossFadeAlpha_ByOrgin(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
		}
	}


	public static void RegisterDirtyLayoutCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.RegisterDirtyLayoutCallback(action);
		}
	}

	public static void RegisterDirtyLayoutCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.RegisterDirtyLayoutCallback(action);
		}
	}

	public static void RegisterDirtyLayoutCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.RegisterDirtyLayoutCallback(action);
		}
	}


	public static void UnregisterDirtyLayoutCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.UnregisterDirtyLayoutCallback(action);
		}
	}

	public static void UnregisterDirtyLayoutCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.UnregisterDirtyLayoutCallback(action);
		}
	}

	public static void UnregisterDirtyLayoutCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.UnregisterDirtyLayoutCallback(action);
		}
	}


	public static void RegisterDirtyVerticesCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.RegisterDirtyVerticesCallback(action);
		}
	}

	public static void RegisterDirtyVerticesCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.RegisterDirtyVerticesCallback(action);
		}
	}

	public static void RegisterDirtyVerticesCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.RegisterDirtyVerticesCallback(action);
		}
	}


	public static void UnregisterDirtyVerticesCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.UnregisterDirtyVerticesCallback(action);
		}
	}

	public static void UnregisterDirtyVerticesCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.UnregisterDirtyVerticesCallback(action);
		}
	}

	public static void UnregisterDirtyVerticesCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.UnregisterDirtyVerticesCallback(action);
		}
	}


	public static void RegisterDirtyMaterialCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.RegisterDirtyMaterialCallback(action);
		}
	}

	public static void RegisterDirtyMaterialCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.RegisterDirtyMaterialCallback(action);
		}
	}

	public static void RegisterDirtyMaterialCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.RegisterDirtyMaterialCallback(action);
		}
	}


	public static void UnregisterDirtyMaterialCallback_ByName(UnityEngine.Events.UnityAction action, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.UnregisterDirtyMaterialCallback(action);
		}
	}

	public static void UnregisterDirtyMaterialCallback_ByPath(UnityEngine.Events.UnityAction action, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.UnregisterDirtyMaterialCallback(action);
		}
	}

	public static void UnregisterDirtyMaterialCallback_ByOrgin(UnityEngine.Events.UnityAction action, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.UnregisterDirtyMaterialCallback(action);
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.StopAllCoroutines();
		}
	}


	public static System.Boolean GetGraphicUseGUILayout_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicUseGUILayout_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicUseGUILayout_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetGraphicUseGUILayout_ByName(System.Boolean value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.useGUILayout = value;
		}
	}

	public static void SetGraphicUseGUILayout_ByPath(System.Boolean value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.useGUILayout = value;
		}
	}

	public static void SetGraphicUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.useGUILayout = value;
		}
	}


	public static System.Boolean GetGraphicRunInEditMode_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRunInEditMode_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicRunInEditMode_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetGraphicRunInEditMode_ByName(System.Boolean value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.runInEditMode = value;
		}
	}

	public static void SetGraphicRunInEditMode_ByPath(System.Boolean value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.runInEditMode = value;
		}
	}

	public static void SetGraphicRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.runInEditMode = value;
		}
	}


	public static System.Boolean GetGraphicEnabled_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicEnabled_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicEnabled_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetGraphicEnabled_ByName(System.Boolean value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.enabled = value;
		}
	}

	public static void SetGraphicEnabled_ByPath(System.Boolean value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.enabled = value;
		}
	}

	public static void SetGraphicEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.enabled = value;
		}
	}


	public static System.Boolean GetGraphicIsActiveAndEnabled_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicIsActiveAndEnabled_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGraphicIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetGraphicTransform_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetGraphicTransform_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetGraphicTransform_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetGraphicGameObject_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetGraphicGameObject_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetGraphicGameObject_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.GetComponents(type, results);
		}
	}


	public static System.String GetGraphicTag_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.tag;
		}

		return null;
	}

	public static System.String GetGraphicTag_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.tag;
		}

		return null;
	}

	public static System.String GetGraphicTag_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.tag;
		}

		return null;
	}


	public static void SetGraphicTag_ByName(System.String value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.tag = value;
		}
	}

	public static void SetGraphicTag_ByPath(System.String value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.tag = value;
		}
	}

	public static void SetGraphicTag_ByOrgin(System.String value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetGraphicName_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.name;
		}

		return null;
	}

	public static System.String GetGraphicName_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.name;
		}

		return null;
	}

	public static System.String GetGraphicName_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.name;
		}

		return null;
	}


	public static void SetGraphicName_ByName(System.String value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.name = value;
		}
	}

	public static void SetGraphicName_ByPath(System.String value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.name = value;
		}
	}

	public static void SetGraphicName_ByOrgin(System.String value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.name = value;
		}
	}


	public static UnityEngine.HideFlags GetGraphicHideFlags_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetGraphicHideFlags_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetGraphicHideFlags_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetGraphicHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			graphic.hideFlags = value;
		}
	}

	public static void SetGraphicHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			graphic.hideFlags = value;
		}
	}

	public static void SetGraphicHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			graphic.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		Graphic graphic = GetGraphicByName(name);
		if(graphic != null)
		{
			return graphic.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		Graphic graphic = GetGraphicByPath(path);
		if(graphic != null)
		{
			return graphic.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		Graphic graphic = GetGraphicByOrgin(parentName, path);
		if(graphic != null)
		{
			return graphic.GetType();
		}

		return null;
	}


}

