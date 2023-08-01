using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIGridLayoutGroupHelper
{
	public static GridLayoutGroup GetGridLayoutGroupByName(string name)
	{
		return UIManager.GetComponentByName<GridLayoutGroup>(name);
	}

	public static GridLayoutGroup GetGridLayoutGroupByPath(string path)
	{
		return UIManager.GetComponentByPath<GridLayoutGroup>(path);
	}

	public static GridLayoutGroup GetGridLayoutGroupByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<GridLayoutGroup>(parentName, path);
	}

	public static UnityEngine.UI.GridLayoutGroup.Corner GetGridLayoutGroupStartCorner_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.startCorner;
		}

		return default(UnityEngine.UI.GridLayoutGroup.Corner);
	}

	public static UnityEngine.UI.GridLayoutGroup.Corner GetGridLayoutGroupStartCorner_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.startCorner;
		}

		return default(UnityEngine.UI.GridLayoutGroup.Corner);
	}

	public static UnityEngine.UI.GridLayoutGroup.Corner GetGridLayoutGroupStartCorner_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.startCorner;
		}

		return default(UnityEngine.UI.GridLayoutGroup.Corner);
	}


	public static void SetGridLayoutGroupStartCorner_ByName(UnityEngine.UI.GridLayoutGroup.Corner value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.startCorner = value;
		}
	}

	public static void SetGridLayoutGroupStartCorner_ByPath(UnityEngine.UI.GridLayoutGroup.Corner value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.startCorner = value;
		}
	}

	public static void SetGridLayoutGroupStartCorner_ByOrgin(UnityEngine.UI.GridLayoutGroup.Corner value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.startCorner = value;
		}
	}


	public static UnityEngine.UI.GridLayoutGroup.Axis GetGridLayoutGroupStartAxis_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.startAxis;
		}

		return default(UnityEngine.UI.GridLayoutGroup.Axis);
	}

	public static UnityEngine.UI.GridLayoutGroup.Axis GetGridLayoutGroupStartAxis_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.startAxis;
		}

		return default(UnityEngine.UI.GridLayoutGroup.Axis);
	}

	public static UnityEngine.UI.GridLayoutGroup.Axis GetGridLayoutGroupStartAxis_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.startAxis;
		}

		return default(UnityEngine.UI.GridLayoutGroup.Axis);
	}


	public static void SetGridLayoutGroupStartAxis_ByName(UnityEngine.UI.GridLayoutGroup.Axis value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.startAxis = value;
		}
	}

	public static void SetGridLayoutGroupStartAxis_ByPath(UnityEngine.UI.GridLayoutGroup.Axis value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.startAxis = value;
		}
	}

	public static void SetGridLayoutGroupStartAxis_ByOrgin(UnityEngine.UI.GridLayoutGroup.Axis value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.startAxis = value;
		}
	}


	public static UnityEngine.Vector2 GetGridLayoutGroupCellSize_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.cellSize;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetGridLayoutGroupCellSize_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.cellSize;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetGridLayoutGroupCellSize_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.cellSize;
		}

		return default(UnityEngine.Vector2);
	}


	public static void SetGridLayoutGroupCellSize_ByName(UnityEngine.Vector2 value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.cellSize = value;
		}
	}

	public static void SetGridLayoutGroupCellSize_ByPath(UnityEngine.Vector2 value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.cellSize = value;
		}
	}

	public static void SetGridLayoutGroupCellSize_ByOrgin(UnityEngine.Vector2 value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.cellSize = value;
		}
	}


	public static UnityEngine.Vector2 GetGridLayoutGroupSpacing_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.spacing;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetGridLayoutGroupSpacing_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.spacing;
		}

		return default(UnityEngine.Vector2);
	}

	public static UnityEngine.Vector2 GetGridLayoutGroupSpacing_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.spacing;
		}

		return default(UnityEngine.Vector2);
	}


	public static void SetGridLayoutGroupSpacing_ByName(UnityEngine.Vector2 value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.spacing = value;
		}
	}

	public static void SetGridLayoutGroupSpacing_ByPath(UnityEngine.Vector2 value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.spacing = value;
		}
	}

	public static void SetGridLayoutGroupSpacing_ByOrgin(UnityEngine.Vector2 value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.spacing = value;
		}
	}


	public static UnityEngine.UI.GridLayoutGroup.Constraint GetGridLayoutGroupConstraint_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.constraint;
		}

		return default(UnityEngine.UI.GridLayoutGroup.Constraint);
	}

	public static UnityEngine.UI.GridLayoutGroup.Constraint GetGridLayoutGroupConstraint_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.constraint;
		}

		return default(UnityEngine.UI.GridLayoutGroup.Constraint);
	}

	public static UnityEngine.UI.GridLayoutGroup.Constraint GetGridLayoutGroupConstraint_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.constraint;
		}

		return default(UnityEngine.UI.GridLayoutGroup.Constraint);
	}


	public static void SetGridLayoutGroupConstraint_ByName(UnityEngine.UI.GridLayoutGroup.Constraint value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.constraint = value;
		}
	}

	public static void SetGridLayoutGroupConstraint_ByPath(UnityEngine.UI.GridLayoutGroup.Constraint value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.constraint = value;
		}
	}

	public static void SetGridLayoutGroupConstraint_ByOrgin(UnityEngine.UI.GridLayoutGroup.Constraint value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.constraint = value;
		}
	}


	public static System.Int32 GetGridLayoutGroupConstraintCount_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.constraintCount;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetGridLayoutGroupConstraintCount_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.constraintCount;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetGridLayoutGroupConstraintCount_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.constraintCount;
		}

		return default(System.Int32);
	}


	public static void SetGridLayoutGroupConstraintCount_ByName(System.Int32 value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.constraintCount = value;
		}
	}

	public static void SetGridLayoutGroupConstraintCount_ByPath(System.Int32 value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.constraintCount = value;
		}
	}

	public static void SetGridLayoutGroupConstraintCount_ByOrgin(System.Int32 value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.constraintCount = value;
		}
	}


	public static void CalculateLayoutInputHorizontal_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.CalculateLayoutInputHorizontal();
		}
	}


	public static void CalculateLayoutInputVertical_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.CalculateLayoutInputVertical();
		}
	}


	public static void SetLayoutHorizontal_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SetLayoutHorizontal();
		}
	}


	public static void SetLayoutVertical_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SetLayoutVertical();
		}
	}


	public static UnityEngine.RectOffset GetGridLayoutGroupPadding_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.padding;
		}

		return null;
	}

	public static UnityEngine.RectOffset GetGridLayoutGroupPadding_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.padding;
		}

		return null;
	}

	public static UnityEngine.RectOffset GetGridLayoutGroupPadding_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.padding;
		}

		return null;
	}


	public static void SetGridLayoutGroupPadding_ByName(UnityEngine.RectOffset value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.padding = value;
		}
	}

	public static void SetGridLayoutGroupPadding_ByPath(UnityEngine.RectOffset value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.padding = value;
		}
	}

	public static void SetGridLayoutGroupPadding_ByOrgin(UnityEngine.RectOffset value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.padding = value;
		}
	}


	public static UnityEngine.TextAnchor GetGridLayoutGroupChildAlignment_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}

	public static UnityEngine.TextAnchor GetGridLayoutGroupChildAlignment_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}

	public static UnityEngine.TextAnchor GetGridLayoutGroupChildAlignment_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}


	public static void SetGridLayoutGroupChildAlignment_ByName(UnityEngine.TextAnchor value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.childAlignment = value;
		}
	}

	public static void SetGridLayoutGroupChildAlignment_ByPath(UnityEngine.TextAnchor value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.childAlignment = value;
		}
	}

	public static void SetGridLayoutGroupChildAlignment_ByOrgin(UnityEngine.TextAnchor value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.childAlignment = value;
		}
	}


	public static System.Single GetGridLayoutGroupMinWidth_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetGridLayoutGroupMinWidth_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetGridLayoutGroupMinWidth_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.minWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetGridLayoutGroupPreferredWidth_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetGridLayoutGroupPreferredWidth_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetGridLayoutGroupPreferredWidth_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.preferredWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetGridLayoutGroupFlexibleWidth_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetGridLayoutGroupFlexibleWidth_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetGridLayoutGroupFlexibleWidth_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetGridLayoutGroupMinHeight_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetGridLayoutGroupMinHeight_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetGridLayoutGroupMinHeight_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.minHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetGridLayoutGroupPreferredHeight_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetGridLayoutGroupPreferredHeight_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetGridLayoutGroupPreferredHeight_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.preferredHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetGridLayoutGroupFlexibleHeight_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetGridLayoutGroupFlexibleHeight_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetGridLayoutGroupFlexibleHeight_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}


	public static System.Int32 GetGridLayoutGroupLayoutPriority_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetGridLayoutGroupLayoutPriority_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetGridLayoutGroupLayoutPriority_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.StopAllCoroutines();
		}
	}


	public static System.Boolean GetGridLayoutGroupUseGUILayout_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGridLayoutGroupUseGUILayout_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGridLayoutGroupUseGUILayout_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetGridLayoutGroupUseGUILayout_ByName(System.Boolean value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.useGUILayout = value;
		}
	}

	public static void SetGridLayoutGroupUseGUILayout_ByPath(System.Boolean value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.useGUILayout = value;
		}
	}

	public static void SetGridLayoutGroupUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.useGUILayout = value;
		}
	}


	public static System.Boolean GetGridLayoutGroupRunInEditMode_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGridLayoutGroupRunInEditMode_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGridLayoutGroupRunInEditMode_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetGridLayoutGroupRunInEditMode_ByName(System.Boolean value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.runInEditMode = value;
		}
	}

	public static void SetGridLayoutGroupRunInEditMode_ByPath(System.Boolean value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.runInEditMode = value;
		}
	}

	public static void SetGridLayoutGroupRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.runInEditMode = value;
		}
	}


	public static System.Boolean GetGridLayoutGroupEnabled_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGridLayoutGroupEnabled_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGridLayoutGroupEnabled_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetGridLayoutGroupEnabled_ByName(System.Boolean value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.enabled = value;
		}
	}

	public static void SetGridLayoutGroupEnabled_ByPath(System.Boolean value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.enabled = value;
		}
	}

	public static void SetGridLayoutGroupEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.enabled = value;
		}
	}


	public static System.Boolean GetGridLayoutGroupIsActiveAndEnabled_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGridLayoutGroupIsActiveAndEnabled_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetGridLayoutGroupIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetGridLayoutGroupTransform_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetGridLayoutGroupTransform_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetGridLayoutGroupTransform_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetGridLayoutGroupGameObject_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetGridLayoutGroupGameObject_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetGridLayoutGroupGameObject_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.GetComponents(type, results);
		}
	}


	public static System.String GetGridLayoutGroupTag_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.tag;
		}

		return null;
	}

	public static System.String GetGridLayoutGroupTag_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.tag;
		}

		return null;
	}

	public static System.String GetGridLayoutGroupTag_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.tag;
		}

		return null;
	}


	public static void SetGridLayoutGroupTag_ByName(System.String value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.tag = value;
		}
	}

	public static void SetGridLayoutGroupTag_ByPath(System.String value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.tag = value;
		}
	}

	public static void SetGridLayoutGroupTag_ByOrgin(System.String value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetGridLayoutGroupName_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.name;
		}

		return null;
	}

	public static System.String GetGridLayoutGroupName_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.name;
		}

		return null;
	}

	public static System.String GetGridLayoutGroupName_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.name;
		}

		return null;
	}


	public static void SetGridLayoutGroupName_ByName(System.String value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.name = value;
		}
	}

	public static void SetGridLayoutGroupName_ByPath(System.String value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.name = value;
		}
	}

	public static void SetGridLayoutGroupName_ByOrgin(System.String value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.name = value;
		}
	}


	public static UnityEngine.HideFlags GetGridLayoutGroupHideFlags_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetGridLayoutGroupHideFlags_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetGridLayoutGroupHideFlags_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetGridLayoutGroupHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.hideFlags = value;
		}
	}

	public static void SetGridLayoutGroupHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.hideFlags = value;
		}
	}

	public static void SetGridLayoutGroupHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			gridlayoutgroup.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByName(name);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByPath(path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		GridLayoutGroup gridlayoutgroup = GetGridLayoutGroupByOrgin(parentName, path);
		if(gridlayoutgroup != null)
		{
			return gridlayoutgroup.GetType();
		}

		return null;
	}


}

