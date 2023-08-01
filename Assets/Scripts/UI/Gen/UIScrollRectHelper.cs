using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIScrollRectHelper
{
	public static ScrollRect GetScrollRectByName(string name)
	{
		return UIManager.GetComponentByName<ScrollRect>(name);
	}

	public static ScrollRect GetScrollRectByPath(string path)
	{
		return UIManager.GetComponentByPath<ScrollRect>(path);
	}

	public static ScrollRect GetScrollRectByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<ScrollRect>(parentName, path);
	}

	public static UnityEngine.RectTransform GetScrollRectContent_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.content;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetScrollRectContent_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.content;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetScrollRectContent_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.content;
		}

		return null;
	}


	public static void SetScrollRectContent_ByName(UnityEngine.RectTransform value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.content = value;
		}
	}

	public static void SetScrollRectContent_ByPath(UnityEngine.RectTransform value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.content = value;
		}
	}

	public static void SetScrollRectContent_ByOrgin(UnityEngine.RectTransform value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.content = value;
		}
	}


	public static System.Boolean GetScrollRectHorizontal_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.horizontal;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectHorizontal_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.horizontal;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectHorizontal_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.horizontal;
		}

		return default(System.Boolean);
	}


	public static void SetScrollRectHorizontal_ByName(System.Boolean value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.horizontal = value;
		}
	}

	public static void SetScrollRectHorizontal_ByPath(System.Boolean value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.horizontal = value;
		}
	}

	public static void SetScrollRectHorizontal_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.horizontal = value;
		}
	}


	public static System.Boolean GetScrollRectVertical_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.vertical;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectVertical_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.vertical;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectVertical_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.vertical;
		}

		return default(System.Boolean);
	}


	public static void SetScrollRectVertical_ByName(System.Boolean value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.vertical = value;
		}
	}

	public static void SetScrollRectVertical_ByPath(System.Boolean value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.vertical = value;
		}
	}

	public static void SetScrollRectVertical_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.vertical = value;
		}
	}


	public static UnityEngine.UI.ScrollRect.MovementType GetScrollRectMovementType_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.movementType;
		}

		return default(UnityEngine.UI.ScrollRect.MovementType);
	}

	public static UnityEngine.UI.ScrollRect.MovementType GetScrollRectMovementType_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.movementType;
		}

		return default(UnityEngine.UI.ScrollRect.MovementType);
	}

	public static UnityEngine.UI.ScrollRect.MovementType GetScrollRectMovementType_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.movementType;
		}

		return default(UnityEngine.UI.ScrollRect.MovementType);
	}


	public static void SetScrollRectMovementType_ByName(UnityEngine.UI.ScrollRect.MovementType value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.movementType = value;
		}
	}

	public static void SetScrollRectMovementType_ByPath(UnityEngine.UI.ScrollRect.MovementType value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.movementType = value;
		}
	}

	public static void SetScrollRectMovementType_ByOrgin(UnityEngine.UI.ScrollRect.MovementType value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.movementType = value;
		}
	}


	public static System.Single GetScrollRectElasticity_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.elasticity;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectElasticity_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.elasticity;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectElasticity_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.elasticity;
		}

		return default(System.Single);
	}


	public static void SetScrollRectElasticity_ByName(System.Single value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.elasticity = value;
		}
	}

	public static void SetScrollRectElasticity_ByPath(System.Single value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.elasticity = value;
		}
	}

	public static void SetScrollRectElasticity_ByOrgin(System.Single value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.elasticity = value;
		}
	}


	public static System.Boolean GetScrollRectInertia_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.inertia;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectInertia_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.inertia;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectInertia_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.inertia;
		}

		return default(System.Boolean);
	}


	public static void SetScrollRectInertia_ByName(System.Boolean value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.inertia = value;
		}
	}

	public static void SetScrollRectInertia_ByPath(System.Boolean value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.inertia = value;
		}
	}

	public static void SetScrollRectInertia_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.inertia = value;
		}
	}


	public static System.Single GetScrollRectDecelerationRate_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.decelerationRate;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectDecelerationRate_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.decelerationRate;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectDecelerationRate_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.decelerationRate;
		}

		return default(System.Single);
	}


	public static void SetScrollRectDecelerationRate_ByName(System.Single value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.decelerationRate = value;
		}
	}

	public static void SetScrollRectDecelerationRate_ByPath(System.Single value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.decelerationRate = value;
		}
	}

	public static void SetScrollRectDecelerationRate_ByOrgin(System.Single value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.decelerationRate = value;
		}
	}


	public static System.Single GetScrollRectScrollSensitivity_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.scrollSensitivity;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectScrollSensitivity_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.scrollSensitivity;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectScrollSensitivity_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.scrollSensitivity;
		}

		return default(System.Single);
	}


	public static void SetScrollRectScrollSensitivity_ByName(System.Single value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.scrollSensitivity = value;
		}
	}

	public static void SetScrollRectScrollSensitivity_ByPath(System.Single value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.scrollSensitivity = value;
		}
	}

	public static void SetScrollRectScrollSensitivity_ByOrgin(System.Single value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.scrollSensitivity = value;
		}
	}


	public static UnityEngine.RectTransform GetScrollRectViewport_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.viewport;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetScrollRectViewport_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.viewport;
		}

		return null;
	}

	public static UnityEngine.RectTransform GetScrollRectViewport_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.viewport;
		}

		return null;
	}


	public static void SetScrollRectViewport_ByName(UnityEngine.RectTransform value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.viewport = value;
		}
	}

	public static void SetScrollRectViewport_ByPath(UnityEngine.RectTransform value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.viewport = value;
		}
	}

	public static void SetScrollRectViewport_ByOrgin(UnityEngine.RectTransform value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.viewport = value;
		}
	}


	public static UnityEngine.UI.Scrollbar GetScrollRectHorizontalScrollbar_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.horizontalScrollbar;
		}

		return null;
	}

	public static UnityEngine.UI.Scrollbar GetScrollRectHorizontalScrollbar_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.horizontalScrollbar;
		}

		return null;
	}

	public static UnityEngine.UI.Scrollbar GetScrollRectHorizontalScrollbar_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.horizontalScrollbar;
		}

		return null;
	}


	public static void SetScrollRectHorizontalScrollbar_ByName(UnityEngine.UI.Scrollbar value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.horizontalScrollbar = value;
		}
	}

	public static void SetScrollRectHorizontalScrollbar_ByPath(UnityEngine.UI.Scrollbar value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.horizontalScrollbar = value;
		}
	}

	public static void SetScrollRectHorizontalScrollbar_ByOrgin(UnityEngine.UI.Scrollbar value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.horizontalScrollbar = value;
		}
	}


	public static UnityEngine.UI.Scrollbar GetScrollRectVerticalScrollbar_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.verticalScrollbar;
		}

		return null;
	}

	public static UnityEngine.UI.Scrollbar GetScrollRectVerticalScrollbar_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.verticalScrollbar;
		}

		return null;
	}

	public static UnityEngine.UI.Scrollbar GetScrollRectVerticalScrollbar_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.verticalScrollbar;
		}

		return null;
	}


	public static void SetScrollRectVerticalScrollbar_ByName(UnityEngine.UI.Scrollbar value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.verticalScrollbar = value;
		}
	}

	public static void SetScrollRectVerticalScrollbar_ByPath(UnityEngine.UI.Scrollbar value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.verticalScrollbar = value;
		}
	}

	public static void SetScrollRectVerticalScrollbar_ByOrgin(UnityEngine.UI.Scrollbar value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.verticalScrollbar = value;
		}
	}


	public static UnityEngine.UI.ScrollRect.ScrollbarVisibility GetScrollRectHorizontalScrollbarVisibility_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.horizontalScrollbarVisibility;
		}

		return default(UnityEngine.UI.ScrollRect.ScrollbarVisibility);
	}

	public static UnityEngine.UI.ScrollRect.ScrollbarVisibility GetScrollRectHorizontalScrollbarVisibility_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.horizontalScrollbarVisibility;
		}

		return default(UnityEngine.UI.ScrollRect.ScrollbarVisibility);
	}

	public static UnityEngine.UI.ScrollRect.ScrollbarVisibility GetScrollRectHorizontalScrollbarVisibility_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.horizontalScrollbarVisibility;
		}

		return default(UnityEngine.UI.ScrollRect.ScrollbarVisibility);
	}


	public static void SetScrollRectHorizontalScrollbarVisibility_ByName(UnityEngine.UI.ScrollRect.ScrollbarVisibility value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.horizontalScrollbarVisibility = value;
		}
	}

	public static void SetScrollRectHorizontalScrollbarVisibility_ByPath(UnityEngine.UI.ScrollRect.ScrollbarVisibility value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.horizontalScrollbarVisibility = value;
		}
	}

	public static void SetScrollRectHorizontalScrollbarVisibility_ByOrgin(UnityEngine.UI.ScrollRect.ScrollbarVisibility value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.horizontalScrollbarVisibility = value;
		}
	}


	public static UnityEngine.UI.ScrollRect.ScrollbarVisibility GetScrollRectVerticalScrollbarVisibility_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.verticalScrollbarVisibility;
		}

		return default(UnityEngine.UI.ScrollRect.ScrollbarVisibility);
	}

	public static UnityEngine.UI.ScrollRect.ScrollbarVisibility GetScrollRectVerticalScrollbarVisibility_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.verticalScrollbarVisibility;
		}

		return default(UnityEngine.UI.ScrollRect.ScrollbarVisibility);
	}

	public static UnityEngine.UI.ScrollRect.ScrollbarVisibility GetScrollRectVerticalScrollbarVisibility_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.verticalScrollbarVisibility;
		}

		return default(UnityEngine.UI.ScrollRect.ScrollbarVisibility);
	}


	public static void SetScrollRectVerticalScrollbarVisibility_ByName(UnityEngine.UI.ScrollRect.ScrollbarVisibility value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.verticalScrollbarVisibility = value;
		}
	}

	public static void SetScrollRectVerticalScrollbarVisibility_ByPath(UnityEngine.UI.ScrollRect.ScrollbarVisibility value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.verticalScrollbarVisibility = value;
		}
	}

	public static void SetScrollRectVerticalScrollbarVisibility_ByOrgin(UnityEngine.UI.ScrollRect.ScrollbarVisibility value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.verticalScrollbarVisibility = value;
		}
	}


	public static System.Single GetScrollRectHorizontalScrollbarSpacing_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.horizontalScrollbarSpacing;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectHorizontalScrollbarSpacing_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.horizontalScrollbarSpacing;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectHorizontalScrollbarSpacing_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.horizontalScrollbarSpacing;
		}

		return default(System.Single);
	}


	public static void SetScrollRectHorizontalScrollbarSpacing_ByName(System.Single value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.horizontalScrollbarSpacing = value;
		}
	}

	public static void SetScrollRectHorizontalScrollbarSpacing_ByPath(System.Single value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.horizontalScrollbarSpacing = value;
		}
	}

	public static void SetScrollRectHorizontalScrollbarSpacing_ByOrgin(System.Single value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.horizontalScrollbarSpacing = value;
		}
	}


	public static System.Single GetScrollRectVerticalScrollbarSpacing_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.verticalScrollbarSpacing;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectVerticalScrollbarSpacing_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.verticalScrollbarSpacing;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectVerticalScrollbarSpacing_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.verticalScrollbarSpacing;
		}

		return default(System.Single);
	}


	public static void SetScrollRectVerticalScrollbarSpacing_ByName(System.Single value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.verticalScrollbarSpacing = value;
		}
	}

	public static void SetScrollRectVerticalScrollbarSpacing_ByPath(System.Single value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.verticalScrollbarSpacing = value;
		}
	}

	public static void SetScrollRectVerticalScrollbarSpacing_ByOrgin(System.Single value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.verticalScrollbarSpacing = value;
		}
	}


	public static UnityEngine.UI.ScrollRect.ScrollRectEvent GetScrollRectOnValueChanged_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.onValueChanged;
		}

		return null;
	}

	public static UnityEngine.UI.ScrollRect.ScrollRectEvent GetScrollRectOnValueChanged_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.onValueChanged;
		}

		return null;
	}

	public static UnityEngine.UI.ScrollRect.ScrollRectEvent GetScrollRectOnValueChanged_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.onValueChanged;
		}

		return null;
	}


	public static void SetScrollRectOnValueChanged_ByName(UnityEngine.UI.ScrollRect.ScrollRectEvent value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.onValueChanged = value;
		}
	}

	public static void SetScrollRectOnValueChanged_ByPath(UnityEngine.UI.ScrollRect.ScrollRectEvent value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.onValueChanged = value;
		}
	}

	public static void SetScrollRectOnValueChanged_ByOrgin(UnityEngine.UI.ScrollRect.ScrollRectEvent value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.onValueChanged = value;
		}
	}


	public static UnityEngine.Vector2 GetScrollRectVelocity_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.velocity;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetScrollRectVelocity_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.velocity;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetScrollRectVelocity_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.velocity;
		}

		return default(UnityEngine.Vector2);
	}


	public static void SetScrollRectVelocity_ByName(UnityEngine.Vector2 value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.velocity = value;
		}
	}

	public static void SetScrollRectVelocity_ByPath(UnityEngine.Vector2 value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.velocity = value;
		}
	}

	public static void SetScrollRectVelocity_ByOrgin(UnityEngine.Vector2 value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.velocity = value;
		}
	}


	public static void Rebuild_ByName(UnityEngine.UI.CanvasUpdate executing, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.Rebuild(executing);
		}
	}

	public static void Rebuild_ByPath(UnityEngine.UI.CanvasUpdate executing, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.Rebuild(executing);
		}
	}

	public static void Rebuild_ByOrgin(UnityEngine.UI.CanvasUpdate executing, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.Rebuild(executing);
		}
	}


	public static void LayoutComplete_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.LayoutComplete();
		}
	}

	public static void LayoutComplete_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.LayoutComplete();
		}
	}


	public static void GraphicUpdateComplete_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.GraphicUpdateComplete();
		}
	}

	public static void GraphicUpdateComplete_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.GraphicUpdateComplete();
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.IsActive();
		}

		return default(System.Boolean);
	}


	public static void StopMovement_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.StopMovement();
		}
	}

	public static void StopMovement_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.StopMovement();
		}
	}

	public static void StopMovement_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.StopMovement();
		}
	}


	public static void OnScroll_ByName(UnityEngine.EventSystems.PointerEventData data, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.OnScroll(data);
		}
	}

	public static void OnScroll_ByPath(UnityEngine.EventSystems.PointerEventData data, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.OnScroll(data);
		}
	}

	public static void OnScroll_ByOrgin(UnityEngine.EventSystems.PointerEventData data, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.OnScroll(data);
		}
	}


	public static void OnInitializePotentialDrag_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.OnInitializePotentialDrag(eventData);
		}
	}

	public static void OnInitializePotentialDrag_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.OnInitializePotentialDrag(eventData);
		}
	}

	public static void OnInitializePotentialDrag_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.OnInitializePotentialDrag(eventData);
		}
	}


	public static void OnBeginDrag_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.OnBeginDrag(eventData);
		}
	}

	public static void OnBeginDrag_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.OnBeginDrag(eventData);
		}
	}

	public static void OnBeginDrag_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.OnBeginDrag(eventData);
		}
	}


	public static void OnEndDrag_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.OnEndDrag(eventData);
		}
	}

	public static void OnEndDrag_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.OnEndDrag(eventData);
		}
	}

	public static void OnEndDrag_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.OnEndDrag(eventData);
		}
	}


	public static void OnDrag_ByName(UnityEngine.EventSystems.PointerEventData eventData, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.OnDrag(eventData);
		}
	}

	public static void OnDrag_ByPath(UnityEngine.EventSystems.PointerEventData eventData, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.OnDrag(eventData);
		}
	}

	public static void OnDrag_ByOrgin(UnityEngine.EventSystems.PointerEventData eventData, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.OnDrag(eventData);
		}
	}


	public static UnityEngine.Vector2 GetScrollRectNormalizedPosition_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.normalizedPosition;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetScrollRectNormalizedPosition_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.normalizedPosition;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetScrollRectNormalizedPosition_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.normalizedPosition;
		}

		return default(UnityEngine.Vector2);
	}


	public static void SetScrollRectNormalizedPosition_ByName(UnityEngine.Vector2 value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.normalizedPosition = value;
		}
	}

	public static void SetScrollRectNormalizedPosition_ByPath(UnityEngine.Vector2 value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.normalizedPosition = value;
		}
	}

	public static void SetScrollRectNormalizedPosition_ByOrgin(UnityEngine.Vector2 value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.normalizedPosition = value;
		}
	}


	public static System.Single GetScrollRectHorizontalNormalizedPosition_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.horizontalNormalizedPosition;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectHorizontalNormalizedPosition_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.horizontalNormalizedPosition;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectHorizontalNormalizedPosition_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.horizontalNormalizedPosition;
		}

		return default(System.Single);
	}


	public static void SetScrollRectHorizontalNormalizedPosition_ByName(System.Single value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.horizontalNormalizedPosition = value;
		}
	}

	public static void SetScrollRectHorizontalNormalizedPosition_ByPath(System.Single value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.horizontalNormalizedPosition = value;
		}
	}

	public static void SetScrollRectHorizontalNormalizedPosition_ByOrgin(System.Single value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.horizontalNormalizedPosition = value;
		}
	}


	public static System.Single GetScrollRectVerticalNormalizedPosition_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.verticalNormalizedPosition;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectVerticalNormalizedPosition_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.verticalNormalizedPosition;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectVerticalNormalizedPosition_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.verticalNormalizedPosition;
		}

		return default(System.Single);
	}


	public static void SetScrollRectVerticalNormalizedPosition_ByName(System.Single value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.verticalNormalizedPosition = value;
		}
	}

	public static void SetScrollRectVerticalNormalizedPosition_ByPath(System.Single value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.verticalNormalizedPosition = value;
		}
	}

	public static void SetScrollRectVerticalNormalizedPosition_ByOrgin(System.Single value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.verticalNormalizedPosition = value;
		}
	}


	public static void CalculateLayoutInputHorizontal_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.CalculateLayoutInputHorizontal();
		}
	}


	public static void CalculateLayoutInputVertical_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.CalculateLayoutInputVertical();
		}
	}


	public static System.Single GetScrollRectMinWidth_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectMinWidth_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectMinWidth_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.minWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetScrollRectPreferredWidth_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectPreferredWidth_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectPreferredWidth_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.preferredWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetScrollRectFlexibleWidth_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectFlexibleWidth_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectFlexibleWidth_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.flexibleWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetScrollRectMinHeight_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectMinHeight_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectMinHeight_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.minHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetScrollRectPreferredHeight_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectPreferredHeight_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectPreferredHeight_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.preferredHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetScrollRectFlexibleHeight_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectFlexibleHeight_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetScrollRectFlexibleHeight_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.flexibleHeight;
		}

		return default(System.Single);
	}


	public static System.Int32 GetScrollRectLayoutPriority_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetScrollRectLayoutPriority_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetScrollRectLayoutPriority_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.layoutPriority;
		}

		return default(System.Int32);
	}


	public static void SetLayoutHorizontal_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.SetLayoutHorizontal();
		}
	}


	public static void SetLayoutVertical_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.SetLayoutVertical();
		}
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.StopAllCoroutines();
		}
	}


	public static System.Boolean GetScrollRectUseGUILayout_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectUseGUILayout_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectUseGUILayout_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetScrollRectUseGUILayout_ByName(System.Boolean value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.useGUILayout = value;
		}
	}

	public static void SetScrollRectUseGUILayout_ByPath(System.Boolean value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.useGUILayout = value;
		}
	}

	public static void SetScrollRectUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.useGUILayout = value;
		}
	}


	public static System.Boolean GetScrollRectRunInEditMode_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectRunInEditMode_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectRunInEditMode_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetScrollRectRunInEditMode_ByName(System.Boolean value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.runInEditMode = value;
		}
	}

	public static void SetScrollRectRunInEditMode_ByPath(System.Boolean value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.runInEditMode = value;
		}
	}

	public static void SetScrollRectRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.runInEditMode = value;
		}
	}


	public static System.Boolean GetScrollRectEnabled_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectEnabled_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectEnabled_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetScrollRectEnabled_ByName(System.Boolean value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.enabled = value;
		}
	}

	public static void SetScrollRectEnabled_ByPath(System.Boolean value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.enabled = value;
		}
	}

	public static void SetScrollRectEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.enabled = value;
		}
	}


	public static System.Boolean GetScrollRectIsActiveAndEnabled_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectIsActiveAndEnabled_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetScrollRectIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetScrollRectTransform_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetScrollRectTransform_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetScrollRectTransform_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetScrollRectGameObject_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetScrollRectGameObject_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetScrollRectGameObject_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.GetComponents(type, results);
		}
	}


	public static System.String GetScrollRectTag_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.tag;
		}

		return null;
	}

	public static System.String GetScrollRectTag_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.tag;
		}

		return null;
	}

	public static System.String GetScrollRectTag_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.tag;
		}

		return null;
	}


	public static void SetScrollRectTag_ByName(System.String value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.tag = value;
		}
	}

	public static void SetScrollRectTag_ByPath(System.String value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.tag = value;
		}
	}

	public static void SetScrollRectTag_ByOrgin(System.String value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetScrollRectName_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.name;
		}

		return null;
	}

	public static System.String GetScrollRectName_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.name;
		}

		return null;
	}

	public static System.String GetScrollRectName_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.name;
		}

		return null;
	}


	public static void SetScrollRectName_ByName(System.String value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.name = value;
		}
	}

	public static void SetScrollRectName_ByPath(System.String value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.name = value;
		}
	}

	public static void SetScrollRectName_ByOrgin(System.String value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.name = value;
		}
	}


	public static UnityEngine.HideFlags GetScrollRectHideFlags_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetScrollRectHideFlags_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetScrollRectHideFlags_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetScrollRectHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			scrollrect.hideFlags = value;
		}
	}

	public static void SetScrollRectHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			scrollrect.hideFlags = value;
		}
	}

	public static void SetScrollRectHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			scrollrect.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		ScrollRect scrollrect = GetScrollRectByName(name);
		if(scrollrect != null)
		{
			return scrollrect.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		ScrollRect scrollrect = GetScrollRectByPath(path);
		if(scrollrect != null)
		{
			return scrollrect.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		ScrollRect scrollrect = GetScrollRectByOrgin(parentName, path);
		if(scrollrect != null)
		{
			return scrollrect.GetType();
		}

		return null;
	}


}

