using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIVerticalLayoutGroupHelper
{
	public static VerticalLayoutGroup GetVerticalLayoutGroupByName(string name)
	{
		return UIManager.GetComponentByName<VerticalLayoutGroup>(name);
	}

	public static VerticalLayoutGroup GetVerticalLayoutGroupByPath(string path)
	{
		return UIManager.GetComponentByPath<VerticalLayoutGroup>(path);
	}

	public static VerticalLayoutGroup GetVerticalLayoutGroupByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<VerticalLayoutGroup>(parentName, path);
	}

	public static void CalculateLayoutInputHorizontal_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.CalculateLayoutInputHorizontal();
		}
	}


	public static void CalculateLayoutInputVertical_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.CalculateLayoutInputVertical();
		}
	}


	public static void SetLayoutHorizontal_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SetLayoutHorizontal();
		}
	}


	public static void SetLayoutVertical_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SetLayoutVertical();
		}
	}


	public static System.Single GetVerticalLayoutGroupSpacing_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.spacing;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupSpacing_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.spacing;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupSpacing_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.spacing;
		}

		return default(System.Single);
	}


	public static void SetVerticalLayoutGroupSpacing_ByName(System.Single value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.spacing = value;
		}
	}

	public static void SetVerticalLayoutGroupSpacing_ByPath(System.Single value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.spacing = value;
		}
	}

	public static void SetVerticalLayoutGroupSpacing_ByOrgin(System.Single value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.spacing = value;
		}
	}


	public static System.Boolean GetVerticalLayoutGroupChildForceExpandWidth_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childForceExpandWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupChildForceExpandWidth_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childForceExpandWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupChildForceExpandWidth_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childForceExpandWidth;
		}

		return default(System.Boolean);
	}


	public static void SetVerticalLayoutGroupChildForceExpandWidth_ByName(System.Boolean value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childForceExpandWidth = value;
		}
	}

	public static void SetVerticalLayoutGroupChildForceExpandWidth_ByPath(System.Boolean value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childForceExpandWidth = value;
		}
	}

	public static void SetVerticalLayoutGroupChildForceExpandWidth_ByOrgin(System.Boolean value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childForceExpandWidth = value;
		}
	}


	public static System.Boolean GetVerticalLayoutGroupChildForceExpandHeight_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childForceExpandHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupChildForceExpandHeight_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childForceExpandHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupChildForceExpandHeight_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childForceExpandHeight;
		}

		return default(System.Boolean);
	}


	public static void SetVerticalLayoutGroupChildForceExpandHeight_ByName(System.Boolean value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childForceExpandHeight = value;
		}
	}

	public static void SetVerticalLayoutGroupChildForceExpandHeight_ByPath(System.Boolean value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childForceExpandHeight = value;
		}
	}

	public static void SetVerticalLayoutGroupChildForceExpandHeight_ByOrgin(System.Boolean value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childForceExpandHeight = value;
		}
	}


	public static System.Boolean GetVerticalLayoutGroupChildControlWidth_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childControlWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupChildControlWidth_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childControlWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupChildControlWidth_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childControlWidth;
		}

		return default(System.Boolean);
	}


	public static void SetVerticalLayoutGroupChildControlWidth_ByName(System.Boolean value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childControlWidth = value;
		}
	}

	public static void SetVerticalLayoutGroupChildControlWidth_ByPath(System.Boolean value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childControlWidth = value;
		}
	}

	public static void SetVerticalLayoutGroupChildControlWidth_ByOrgin(System.Boolean value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childControlWidth = value;
		}
	}


	public static System.Boolean GetVerticalLayoutGroupChildControlHeight_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childControlHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupChildControlHeight_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childControlHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupChildControlHeight_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childControlHeight;
		}

		return default(System.Boolean);
	}


	public static void SetVerticalLayoutGroupChildControlHeight_ByName(System.Boolean value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childControlHeight = value;
		}
	}

	public static void SetVerticalLayoutGroupChildControlHeight_ByPath(System.Boolean value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childControlHeight = value;
		}
	}

	public static void SetVerticalLayoutGroupChildControlHeight_ByOrgin(System.Boolean value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childControlHeight = value;
		}
	}


	public static System.Boolean GetVerticalLayoutGroupChildScaleWidth_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childScaleWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupChildScaleWidth_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childScaleWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupChildScaleWidth_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childScaleWidth;
		}

		return default(System.Boolean);
	}


	public static void SetVerticalLayoutGroupChildScaleWidth_ByName(System.Boolean value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childScaleWidth = value;
		}
	}

	public static void SetVerticalLayoutGroupChildScaleWidth_ByPath(System.Boolean value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childScaleWidth = value;
		}
	}

	public static void SetVerticalLayoutGroupChildScaleWidth_ByOrgin(System.Boolean value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childScaleWidth = value;
		}
	}


	public static System.Boolean GetVerticalLayoutGroupChildScaleHeight_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childScaleHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupChildScaleHeight_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childScaleHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupChildScaleHeight_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childScaleHeight;
		}

		return default(System.Boolean);
	}


	public static void SetVerticalLayoutGroupChildScaleHeight_ByName(System.Boolean value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childScaleHeight = value;
		}
	}

	public static void SetVerticalLayoutGroupChildScaleHeight_ByPath(System.Boolean value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childScaleHeight = value;
		}
	}

	public static void SetVerticalLayoutGroupChildScaleHeight_ByOrgin(System.Boolean value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childScaleHeight = value;
		}
	}


	public static System.Boolean GetVerticalLayoutGroupReverseArrangement_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.reverseArrangement;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupReverseArrangement_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.reverseArrangement;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupReverseArrangement_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.reverseArrangement;
		}

		return default(System.Boolean);
	}


	public static void SetVerticalLayoutGroupReverseArrangement_ByName(System.Boolean value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.reverseArrangement = value;
		}
	}

	public static void SetVerticalLayoutGroupReverseArrangement_ByPath(System.Boolean value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.reverseArrangement = value;
		}
	}

	public static void SetVerticalLayoutGroupReverseArrangement_ByOrgin(System.Boolean value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.reverseArrangement = value;
		}
	}


	public static UnityEngine.RectOffset GetVerticalLayoutGroupPadding_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.padding;
		}

		return null;
	}

	public static UnityEngine.RectOffset GetVerticalLayoutGroupPadding_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.padding;
		}

		return null;
	}

	public static UnityEngine.RectOffset GetVerticalLayoutGroupPadding_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.padding;
		}

		return null;
	}


	public static void SetVerticalLayoutGroupPadding_ByName(UnityEngine.RectOffset value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.padding = value;
		}
	}

	public static void SetVerticalLayoutGroupPadding_ByPath(UnityEngine.RectOffset value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.padding = value;
		}
	}

	public static void SetVerticalLayoutGroupPadding_ByOrgin(UnityEngine.RectOffset value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.padding = value;
		}
	}


	public static UnityEngine.TextAnchor GetVerticalLayoutGroupChildAlignment_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}

	public static UnityEngine.TextAnchor GetVerticalLayoutGroupChildAlignment_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}

	public static UnityEngine.TextAnchor GetVerticalLayoutGroupChildAlignment_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}


	public static void SetVerticalLayoutGroupChildAlignment_ByName(UnityEngine.TextAnchor value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childAlignment = value;
		}
	}

	public static void SetVerticalLayoutGroupChildAlignment_ByPath(UnityEngine.TextAnchor value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childAlignment = value;
		}
	}

	public static void SetVerticalLayoutGroupChildAlignment_ByOrgin(UnityEngine.TextAnchor value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.childAlignment = value;
		}
	}


	public static System.Single GetVerticalLayoutGroupMinWidth_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupMinWidth_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupMinWidth_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.minWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetVerticalLayoutGroupPreferredWidth_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupPreferredWidth_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupPreferredWidth_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.preferredWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetVerticalLayoutGroupFlexibleWidth_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupFlexibleWidth_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupFlexibleWidth_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetVerticalLayoutGroupMinHeight_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupMinHeight_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupMinHeight_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.minHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetVerticalLayoutGroupPreferredHeight_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupPreferredHeight_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupPreferredHeight_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.preferredHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetVerticalLayoutGroupFlexibleHeight_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupFlexibleHeight_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetVerticalLayoutGroupFlexibleHeight_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}


	public static System.Int32 GetVerticalLayoutGroupLayoutPriority_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetVerticalLayoutGroupLayoutPriority_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetVerticalLayoutGroupLayoutPriority_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.StopAllCoroutines();
		}
	}


	public static System.Boolean GetVerticalLayoutGroupUseGUILayout_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupUseGUILayout_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupUseGUILayout_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetVerticalLayoutGroupUseGUILayout_ByName(System.Boolean value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.useGUILayout = value;
		}
	}

	public static void SetVerticalLayoutGroupUseGUILayout_ByPath(System.Boolean value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.useGUILayout = value;
		}
	}

	public static void SetVerticalLayoutGroupUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.useGUILayout = value;
		}
	}


	public static System.Boolean GetVerticalLayoutGroupRunInEditMode_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupRunInEditMode_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupRunInEditMode_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetVerticalLayoutGroupRunInEditMode_ByName(System.Boolean value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.runInEditMode = value;
		}
	}

	public static void SetVerticalLayoutGroupRunInEditMode_ByPath(System.Boolean value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.runInEditMode = value;
		}
	}

	public static void SetVerticalLayoutGroupRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.runInEditMode = value;
		}
	}


	public static System.Boolean GetVerticalLayoutGroupEnabled_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupEnabled_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupEnabled_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetVerticalLayoutGroupEnabled_ByName(System.Boolean value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.enabled = value;
		}
	}

	public static void SetVerticalLayoutGroupEnabled_ByPath(System.Boolean value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.enabled = value;
		}
	}

	public static void SetVerticalLayoutGroupEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.enabled = value;
		}
	}


	public static System.Boolean GetVerticalLayoutGroupIsActiveAndEnabled_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupIsActiveAndEnabled_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetVerticalLayoutGroupIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetVerticalLayoutGroupTransform_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetVerticalLayoutGroupTransform_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetVerticalLayoutGroupTransform_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetVerticalLayoutGroupGameObject_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetVerticalLayoutGroupGameObject_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetVerticalLayoutGroupGameObject_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.GetComponents(type, results);
		}
	}


	public static System.String GetVerticalLayoutGroupTag_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.tag;
		}

		return null;
	}

	public static System.String GetVerticalLayoutGroupTag_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.tag;
		}

		return null;
	}

	public static System.String GetVerticalLayoutGroupTag_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.tag;
		}

		return null;
	}


	public static void SetVerticalLayoutGroupTag_ByName(System.String value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.tag = value;
		}
	}

	public static void SetVerticalLayoutGroupTag_ByPath(System.String value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.tag = value;
		}
	}

	public static void SetVerticalLayoutGroupTag_ByOrgin(System.String value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetVerticalLayoutGroupName_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.name;
		}

		return null;
	}

	public static System.String GetVerticalLayoutGroupName_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.name;
		}

		return null;
	}

	public static System.String GetVerticalLayoutGroupName_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.name;
		}

		return null;
	}


	public static void SetVerticalLayoutGroupName_ByName(System.String value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.name = value;
		}
	}

	public static void SetVerticalLayoutGroupName_ByPath(System.String value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.name = value;
		}
	}

	public static void SetVerticalLayoutGroupName_ByOrgin(System.String value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.name = value;
		}
	}


	public static UnityEngine.HideFlags GetVerticalLayoutGroupHideFlags_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetVerticalLayoutGroupHideFlags_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetVerticalLayoutGroupHideFlags_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetVerticalLayoutGroupHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.hideFlags = value;
		}
	}

	public static void SetVerticalLayoutGroupHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.hideFlags = value;
		}
	}

	public static void SetVerticalLayoutGroupHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			verticallayoutgroup.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByName(name);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByPath(path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		VerticalLayoutGroup verticallayoutgroup = GetVerticalLayoutGroupByOrgin(parentName, path);
		if(verticallayoutgroup != null)
		{
			return verticallayoutgroup.GetType();
		}

		return null;
	}


}

