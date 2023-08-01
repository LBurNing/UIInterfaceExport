using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIHorizontalLayoutGroupHelper
{
	public static HorizontalLayoutGroup GetHorizontalLayoutGroupByName(string name)
	{
		return UIManager.GetComponentByName<HorizontalLayoutGroup>(name);
	}

	public static HorizontalLayoutGroup GetHorizontalLayoutGroupByPath(string path)
	{
		return UIManager.GetComponentByPath<HorizontalLayoutGroup>(path);
	}

	public static HorizontalLayoutGroup GetHorizontalLayoutGroupByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<HorizontalLayoutGroup>(parentName, path);
	}

	public static void CalculateLayoutInputHorizontal_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.CalculateLayoutInputHorizontal();
		}
	}


	public static void CalculateLayoutInputVertical_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.CalculateLayoutInputVertical();
		}
	}


	public static void SetLayoutHorizontal_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SetLayoutHorizontal();
		}
	}


	public static void SetLayoutVertical_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SetLayoutVertical();
		}
	}


	public static System.Single GetHorizontalLayoutGroupSpacing_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.spacing;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupSpacing_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.spacing;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupSpacing_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.spacing;
		}

		return default(System.Single);
	}


	public static void SetHorizontalLayoutGroupSpacing_ByName(System.Single value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.spacing = value;
		}
	}

	public static void SetHorizontalLayoutGroupSpacing_ByPath(System.Single value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.spacing = value;
		}
	}

	public static void SetHorizontalLayoutGroupSpacing_ByOrgin(System.Single value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.spacing = value;
		}
	}


	public static System.Boolean GetHorizontalLayoutGroupChildForceExpandWidth_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childForceExpandWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupChildForceExpandWidth_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childForceExpandWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupChildForceExpandWidth_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childForceExpandWidth;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalLayoutGroupChildForceExpandWidth_ByName(System.Boolean value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childForceExpandWidth = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildForceExpandWidth_ByPath(System.Boolean value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childForceExpandWidth = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildForceExpandWidth_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childForceExpandWidth = value;
		}
	}


	public static System.Boolean GetHorizontalLayoutGroupChildForceExpandHeight_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childForceExpandHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupChildForceExpandHeight_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childForceExpandHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupChildForceExpandHeight_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childForceExpandHeight;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalLayoutGroupChildForceExpandHeight_ByName(System.Boolean value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childForceExpandHeight = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildForceExpandHeight_ByPath(System.Boolean value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childForceExpandHeight = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildForceExpandHeight_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childForceExpandHeight = value;
		}
	}


	public static System.Boolean GetHorizontalLayoutGroupChildControlWidth_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childControlWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupChildControlWidth_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childControlWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupChildControlWidth_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childControlWidth;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalLayoutGroupChildControlWidth_ByName(System.Boolean value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childControlWidth = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildControlWidth_ByPath(System.Boolean value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childControlWidth = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildControlWidth_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childControlWidth = value;
		}
	}


	public static System.Boolean GetHorizontalLayoutGroupChildControlHeight_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childControlHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupChildControlHeight_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childControlHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupChildControlHeight_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childControlHeight;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalLayoutGroupChildControlHeight_ByName(System.Boolean value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childControlHeight = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildControlHeight_ByPath(System.Boolean value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childControlHeight = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildControlHeight_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childControlHeight = value;
		}
	}


	public static System.Boolean GetHorizontalLayoutGroupChildScaleWidth_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childScaleWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupChildScaleWidth_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childScaleWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupChildScaleWidth_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childScaleWidth;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalLayoutGroupChildScaleWidth_ByName(System.Boolean value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childScaleWidth = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildScaleWidth_ByPath(System.Boolean value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childScaleWidth = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildScaleWidth_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childScaleWidth = value;
		}
	}


	public static System.Boolean GetHorizontalLayoutGroupChildScaleHeight_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childScaleHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupChildScaleHeight_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childScaleHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupChildScaleHeight_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childScaleHeight;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalLayoutGroupChildScaleHeight_ByName(System.Boolean value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childScaleHeight = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildScaleHeight_ByPath(System.Boolean value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childScaleHeight = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildScaleHeight_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childScaleHeight = value;
		}
	}


	public static System.Boolean GetHorizontalLayoutGroupReverseArrangement_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.reverseArrangement;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupReverseArrangement_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.reverseArrangement;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupReverseArrangement_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.reverseArrangement;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalLayoutGroupReverseArrangement_ByName(System.Boolean value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.reverseArrangement = value;
		}
	}

	public static void SetHorizontalLayoutGroupReverseArrangement_ByPath(System.Boolean value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.reverseArrangement = value;
		}
	}

	public static void SetHorizontalLayoutGroupReverseArrangement_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.reverseArrangement = value;
		}
	}


	public static UnityEngine.RectOffset GetHorizontalLayoutGroupPadding_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.padding;
		}

		return null;
	}

	public static UnityEngine.RectOffset GetHorizontalLayoutGroupPadding_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.padding;
		}

		return null;
	}

	public static UnityEngine.RectOffset GetHorizontalLayoutGroupPadding_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.padding;
		}

		return null;
	}


	public static void SetHorizontalLayoutGroupPadding_ByName(UnityEngine.RectOffset value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.padding = value;
		}
	}

	public static void SetHorizontalLayoutGroupPadding_ByPath(UnityEngine.RectOffset value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.padding = value;
		}
	}

	public static void SetHorizontalLayoutGroupPadding_ByOrgin(UnityEngine.RectOffset value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.padding = value;
		}
	}


	public static UnityEngine.TextAnchor GetHorizontalLayoutGroupChildAlignment_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}

	public static UnityEngine.TextAnchor GetHorizontalLayoutGroupChildAlignment_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}

	public static UnityEngine.TextAnchor GetHorizontalLayoutGroupChildAlignment_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}


	public static void SetHorizontalLayoutGroupChildAlignment_ByName(UnityEngine.TextAnchor value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childAlignment = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildAlignment_ByPath(UnityEngine.TextAnchor value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childAlignment = value;
		}
	}

	public static void SetHorizontalLayoutGroupChildAlignment_ByOrgin(UnityEngine.TextAnchor value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.childAlignment = value;
		}
	}


	public static System.Single GetHorizontalLayoutGroupMinWidth_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupMinWidth_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupMinWidth_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.minWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetHorizontalLayoutGroupPreferredWidth_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupPreferredWidth_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupPreferredWidth_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.preferredWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetHorizontalLayoutGroupFlexibleWidth_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupFlexibleWidth_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupFlexibleWidth_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetHorizontalLayoutGroupMinHeight_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupMinHeight_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupMinHeight_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.minHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetHorizontalLayoutGroupPreferredHeight_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupPreferredHeight_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupPreferredHeight_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.preferredHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetHorizontalLayoutGroupFlexibleHeight_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupFlexibleHeight_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalLayoutGroupFlexibleHeight_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}


	public static System.Int32 GetHorizontalLayoutGroupLayoutPriority_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHorizontalLayoutGroupLayoutPriority_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHorizontalLayoutGroupLayoutPriority_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.StopAllCoroutines();
		}
	}


	public static System.Boolean GetHorizontalLayoutGroupUseGUILayout_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupUseGUILayout_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupUseGUILayout_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalLayoutGroupUseGUILayout_ByName(System.Boolean value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.useGUILayout = value;
		}
	}

	public static void SetHorizontalLayoutGroupUseGUILayout_ByPath(System.Boolean value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.useGUILayout = value;
		}
	}

	public static void SetHorizontalLayoutGroupUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.useGUILayout = value;
		}
	}


	public static System.Boolean GetHorizontalLayoutGroupRunInEditMode_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupRunInEditMode_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupRunInEditMode_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalLayoutGroupRunInEditMode_ByName(System.Boolean value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.runInEditMode = value;
		}
	}

	public static void SetHorizontalLayoutGroupRunInEditMode_ByPath(System.Boolean value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.runInEditMode = value;
		}
	}

	public static void SetHorizontalLayoutGroupRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.runInEditMode = value;
		}
	}


	public static System.Boolean GetHorizontalLayoutGroupEnabled_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupEnabled_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupEnabled_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalLayoutGroupEnabled_ByName(System.Boolean value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.enabled = value;
		}
	}

	public static void SetHorizontalLayoutGroupEnabled_ByPath(System.Boolean value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.enabled = value;
		}
	}

	public static void SetHorizontalLayoutGroupEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.enabled = value;
		}
	}


	public static System.Boolean GetHorizontalLayoutGroupIsActiveAndEnabled_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupIsActiveAndEnabled_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalLayoutGroupIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetHorizontalLayoutGroupTransform_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetHorizontalLayoutGroupTransform_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetHorizontalLayoutGroupTransform_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetHorizontalLayoutGroupGameObject_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetHorizontalLayoutGroupGameObject_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetHorizontalLayoutGroupGameObject_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.GetComponents(type, results);
		}
	}


	public static System.String GetHorizontalLayoutGroupTag_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.tag;
		}

		return null;
	}

	public static System.String GetHorizontalLayoutGroupTag_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.tag;
		}

		return null;
	}

	public static System.String GetHorizontalLayoutGroupTag_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.tag;
		}

		return null;
	}


	public static void SetHorizontalLayoutGroupTag_ByName(System.String value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.tag = value;
		}
	}

	public static void SetHorizontalLayoutGroupTag_ByPath(System.String value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.tag = value;
		}
	}

	public static void SetHorizontalLayoutGroupTag_ByOrgin(System.String value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetHorizontalLayoutGroupName_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.name;
		}

		return null;
	}

	public static System.String GetHorizontalLayoutGroupName_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.name;
		}

		return null;
	}

	public static System.String GetHorizontalLayoutGroupName_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.name;
		}

		return null;
	}


	public static void SetHorizontalLayoutGroupName_ByName(System.String value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.name = value;
		}
	}

	public static void SetHorizontalLayoutGroupName_ByPath(System.String value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.name = value;
		}
	}

	public static void SetHorizontalLayoutGroupName_ByOrgin(System.String value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.name = value;
		}
	}


	public static UnityEngine.HideFlags GetHorizontalLayoutGroupHideFlags_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetHorizontalLayoutGroupHideFlags_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetHorizontalLayoutGroupHideFlags_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetHorizontalLayoutGroupHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.hideFlags = value;
		}
	}

	public static void SetHorizontalLayoutGroupHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.hideFlags = value;
		}
	}

	public static void SetHorizontalLayoutGroupHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			horizontallayoutgroup.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByName(name);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByPath(path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		HorizontalLayoutGroup horizontallayoutgroup = GetHorizontalLayoutGroupByOrgin(parentName, path);
		if(horizontallayoutgroup != null)
		{
			return horizontallayoutgroup.GetType();
		}

		return null;
	}


}

