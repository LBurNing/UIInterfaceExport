using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UICanvasScalerHelper
{
	public static CanvasScaler GetCanvasScalerByName(string name)
	{
		return UIManager.GetComponentByName<CanvasScaler>(name);
	}

	public static CanvasScaler GetCanvasScalerByPath(string path)
	{
		return UIManager.GetComponentByPath<CanvasScaler>(path);
	}

	public static CanvasScaler GetCanvasScalerByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<CanvasScaler>(parentName, path);
	}

	public static UnityEngine.UI.CanvasScaler.ScaleMode GetCanvasScalerUiScaleMode_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.uiScaleMode;
		}

		return default(UnityEngine.UI.CanvasScaler.ScaleMode);
	}

	public static UnityEngine.UI.CanvasScaler.ScaleMode GetCanvasScalerUiScaleMode_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.uiScaleMode;
		}

		return default(UnityEngine.UI.CanvasScaler.ScaleMode);
	}

	public static UnityEngine.UI.CanvasScaler.ScaleMode GetCanvasScalerUiScaleMode_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.uiScaleMode;
		}

		return default(UnityEngine.UI.CanvasScaler.ScaleMode);
	}


	public static void SetCanvasScalerUiScaleMode_ByName(UnityEngine.UI.CanvasScaler.ScaleMode value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.uiScaleMode = value;
		}
	}

	public static void SetCanvasScalerUiScaleMode_ByPath(UnityEngine.UI.CanvasScaler.ScaleMode value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.uiScaleMode = value;
		}
	}

	public static void SetCanvasScalerUiScaleMode_ByOrgin(UnityEngine.UI.CanvasScaler.ScaleMode value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.uiScaleMode = value;
		}
	}


	public static System.Single GetCanvasScalerReferencePixelsPerUnit_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.referencePixelsPerUnit;
		}

		return default(System.Single);
	}

	public static System.Single GetCanvasScalerReferencePixelsPerUnit_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.referencePixelsPerUnit;
		}

		return default(System.Single);
	}

	public static System.Single GetCanvasScalerReferencePixelsPerUnit_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.referencePixelsPerUnit;
		}

		return default(System.Single);
	}


	public static void SetCanvasScalerReferencePixelsPerUnit_ByName(System.Single value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.referencePixelsPerUnit = value;
		}
	}

	public static void SetCanvasScalerReferencePixelsPerUnit_ByPath(System.Single value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.referencePixelsPerUnit = value;
		}
	}

	public static void SetCanvasScalerReferencePixelsPerUnit_ByOrgin(System.Single value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.referencePixelsPerUnit = value;
		}
	}


	public static System.Single GetCanvasScalerScaleFactor_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.scaleFactor;
		}

		return default(System.Single);
	}

	public static System.Single GetCanvasScalerScaleFactor_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.scaleFactor;
		}

		return default(System.Single);
	}

	public static System.Single GetCanvasScalerScaleFactor_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.scaleFactor;
		}

		return default(System.Single);
	}


	public static void SetCanvasScalerScaleFactor_ByName(System.Single value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.scaleFactor = value;
		}
	}

	public static void SetCanvasScalerScaleFactor_ByPath(System.Single value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.scaleFactor = value;
		}
	}

	public static void SetCanvasScalerScaleFactor_ByOrgin(System.Single value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.scaleFactor = value;
		}
	}


	public static UnityEngine.Vector2 GetCanvasScalerReferenceResolution_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.referenceResolution;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetCanvasScalerReferenceResolution_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.referenceResolution;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetCanvasScalerReferenceResolution_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.referenceResolution;
		}

		return default(UnityEngine.Vector2);
	}


	public static void SetCanvasScalerReferenceResolution_ByName(UnityEngine.Vector2 value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.referenceResolution = value;
		}
	}

	public static void SetCanvasScalerReferenceResolution_ByPath(UnityEngine.Vector2 value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.referenceResolution = value;
		}
	}

	public static void SetCanvasScalerReferenceResolution_ByOrgin(UnityEngine.Vector2 value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.referenceResolution = value;
		}
	}


	public static UnityEngine.UI.CanvasScaler.ScreenMatchMode GetCanvasScalerScreenMatchMode_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.screenMatchMode;
		}

		return default(UnityEngine.UI.CanvasScaler.ScreenMatchMode);
	}

	public static UnityEngine.UI.CanvasScaler.ScreenMatchMode GetCanvasScalerScreenMatchMode_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.screenMatchMode;
		}

		return default(UnityEngine.UI.CanvasScaler.ScreenMatchMode);
	}

	public static UnityEngine.UI.CanvasScaler.ScreenMatchMode GetCanvasScalerScreenMatchMode_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.screenMatchMode;
		}

		return default(UnityEngine.UI.CanvasScaler.ScreenMatchMode);
	}


	public static void SetCanvasScalerScreenMatchMode_ByName(UnityEngine.UI.CanvasScaler.ScreenMatchMode value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.screenMatchMode = value;
		}
	}

	public static void SetCanvasScalerScreenMatchMode_ByPath(UnityEngine.UI.CanvasScaler.ScreenMatchMode value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.screenMatchMode = value;
		}
	}

	public static void SetCanvasScalerScreenMatchMode_ByOrgin(UnityEngine.UI.CanvasScaler.ScreenMatchMode value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.screenMatchMode = value;
		}
	}


	public static System.Single GetCanvasScalerMatchWidthOrHeight_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.matchWidthOrHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetCanvasScalerMatchWidthOrHeight_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.matchWidthOrHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetCanvasScalerMatchWidthOrHeight_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.matchWidthOrHeight;
		}

		return default(System.Single);
	}


	public static void SetCanvasScalerMatchWidthOrHeight_ByName(System.Single value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.matchWidthOrHeight = value;
		}
	}

	public static void SetCanvasScalerMatchWidthOrHeight_ByPath(System.Single value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.matchWidthOrHeight = value;
		}
	}

	public static void SetCanvasScalerMatchWidthOrHeight_ByOrgin(System.Single value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.matchWidthOrHeight = value;
		}
	}


	public static UnityEngine.UI.CanvasScaler.Unit GetCanvasScalerPhysicalUnit_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.physicalUnit;
		}

		return default(UnityEngine.UI.CanvasScaler.Unit);
	}

	public static UnityEngine.UI.CanvasScaler.Unit GetCanvasScalerPhysicalUnit_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.physicalUnit;
		}

		return default(UnityEngine.UI.CanvasScaler.Unit);
	}

	public static UnityEngine.UI.CanvasScaler.Unit GetCanvasScalerPhysicalUnit_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.physicalUnit;
		}

		return default(UnityEngine.UI.CanvasScaler.Unit);
	}


	public static void SetCanvasScalerPhysicalUnit_ByName(UnityEngine.UI.CanvasScaler.Unit value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.physicalUnit = value;
		}
	}

	public static void SetCanvasScalerPhysicalUnit_ByPath(UnityEngine.UI.CanvasScaler.Unit value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.physicalUnit = value;
		}
	}

	public static void SetCanvasScalerPhysicalUnit_ByOrgin(UnityEngine.UI.CanvasScaler.Unit value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.physicalUnit = value;
		}
	}


	public static System.Single GetCanvasScalerFallbackScreenDPI_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.fallbackScreenDPI;
		}

		return default(System.Single);
	}

	public static System.Single GetCanvasScalerFallbackScreenDPI_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.fallbackScreenDPI;
		}

		return default(System.Single);
	}

	public static System.Single GetCanvasScalerFallbackScreenDPI_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.fallbackScreenDPI;
		}

		return default(System.Single);
	}


	public static void SetCanvasScalerFallbackScreenDPI_ByName(System.Single value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.fallbackScreenDPI = value;
		}
	}

	public static void SetCanvasScalerFallbackScreenDPI_ByPath(System.Single value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.fallbackScreenDPI = value;
		}
	}

	public static void SetCanvasScalerFallbackScreenDPI_ByOrgin(System.Single value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.fallbackScreenDPI = value;
		}
	}


	public static System.Single GetCanvasScalerDefaultSpriteDPI_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.defaultSpriteDPI;
		}

		return default(System.Single);
	}

	public static System.Single GetCanvasScalerDefaultSpriteDPI_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.defaultSpriteDPI;
		}

		return default(System.Single);
	}

	public static System.Single GetCanvasScalerDefaultSpriteDPI_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.defaultSpriteDPI;
		}

		return default(System.Single);
	}


	public static void SetCanvasScalerDefaultSpriteDPI_ByName(System.Single value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.defaultSpriteDPI = value;
		}
	}

	public static void SetCanvasScalerDefaultSpriteDPI_ByPath(System.Single value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.defaultSpriteDPI = value;
		}
	}

	public static void SetCanvasScalerDefaultSpriteDPI_ByOrgin(System.Single value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.defaultSpriteDPI = value;
		}
	}


	public static System.Single GetCanvasScalerDynamicPixelsPerUnit_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.dynamicPixelsPerUnit;
		}

		return default(System.Single);
	}

	public static System.Single GetCanvasScalerDynamicPixelsPerUnit_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.dynamicPixelsPerUnit;
		}

		return default(System.Single);
	}

	public static System.Single GetCanvasScalerDynamicPixelsPerUnit_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.dynamicPixelsPerUnit;
		}

		return default(System.Single);
	}


	public static void SetCanvasScalerDynamicPixelsPerUnit_ByName(System.Single value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.dynamicPixelsPerUnit = value;
		}
	}

	public static void SetCanvasScalerDynamicPixelsPerUnit_ByPath(System.Single value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.dynamicPixelsPerUnit = value;
		}
	}

	public static void SetCanvasScalerDynamicPixelsPerUnit_ByOrgin(System.Single value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.dynamicPixelsPerUnit = value;
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.StopAllCoroutines();
		}
	}


	public static System.Boolean GetCanvasScalerUseGUILayout_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetCanvasScalerUseGUILayout_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetCanvasScalerUseGUILayout_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetCanvasScalerUseGUILayout_ByName(System.Boolean value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.useGUILayout = value;
		}
	}

	public static void SetCanvasScalerUseGUILayout_ByPath(System.Boolean value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.useGUILayout = value;
		}
	}

	public static void SetCanvasScalerUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.useGUILayout = value;
		}
	}


	public static System.Boolean GetCanvasScalerRunInEditMode_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetCanvasScalerRunInEditMode_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetCanvasScalerRunInEditMode_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetCanvasScalerRunInEditMode_ByName(System.Boolean value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.runInEditMode = value;
		}
	}

	public static void SetCanvasScalerRunInEditMode_ByPath(System.Boolean value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.runInEditMode = value;
		}
	}

	public static void SetCanvasScalerRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.runInEditMode = value;
		}
	}


	public static System.Boolean GetCanvasScalerEnabled_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetCanvasScalerEnabled_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetCanvasScalerEnabled_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetCanvasScalerEnabled_ByName(System.Boolean value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.enabled = value;
		}
	}

	public static void SetCanvasScalerEnabled_ByPath(System.Boolean value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.enabled = value;
		}
	}

	public static void SetCanvasScalerEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.enabled = value;
		}
	}


	public static System.Boolean GetCanvasScalerIsActiveAndEnabled_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetCanvasScalerIsActiveAndEnabled_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetCanvasScalerIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetCanvasScalerTransform_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetCanvasScalerTransform_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetCanvasScalerTransform_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetCanvasScalerGameObject_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetCanvasScalerGameObject_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetCanvasScalerGameObject_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.GetComponents(type, results);
		}
	}


	public static System.String GetCanvasScalerTag_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.tag;
		}

		return null;
	}

	public static System.String GetCanvasScalerTag_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.tag;
		}

		return null;
	}

	public static System.String GetCanvasScalerTag_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.tag;
		}

		return null;
	}


	public static void SetCanvasScalerTag_ByName(System.String value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.tag = value;
		}
	}

	public static void SetCanvasScalerTag_ByPath(System.String value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.tag = value;
		}
	}

	public static void SetCanvasScalerTag_ByOrgin(System.String value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetCanvasScalerName_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.name;
		}

		return null;
	}

	public static System.String GetCanvasScalerName_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.name;
		}

		return null;
	}

	public static System.String GetCanvasScalerName_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.name;
		}

		return null;
	}


	public static void SetCanvasScalerName_ByName(System.String value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.name = value;
		}
	}

	public static void SetCanvasScalerName_ByPath(System.String value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.name = value;
		}
	}

	public static void SetCanvasScalerName_ByOrgin(System.String value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.name = value;
		}
	}


	public static UnityEngine.HideFlags GetCanvasScalerHideFlags_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetCanvasScalerHideFlags_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetCanvasScalerHideFlags_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetCanvasScalerHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			canvasscaler.hideFlags = value;
		}
	}

	public static void SetCanvasScalerHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			canvasscaler.hideFlags = value;
		}
	}

	public static void SetCanvasScalerHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			canvasscaler.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByName(name);
		if(canvasscaler != null)
		{
			return canvasscaler.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByPath(path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		CanvasScaler canvasscaler = GetCanvasScalerByOrgin(parentName, path);
		if(canvasscaler != null)
		{
			return canvasscaler.GetType();
		}

		return null;
	}


}

