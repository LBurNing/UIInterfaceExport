using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

//It is generated automatically. Do not modify it!
public class UIHorizontalOrVerticalLayoutGroupHelper
{
	public static HorizontalOrVerticalLayoutGroup GetHorizontalOrVerticalLayoutGroupByName(string name)
	{
		return UIManager.GetComponentByName<HorizontalOrVerticalLayoutGroup>(name);
	}

	public static HorizontalOrVerticalLayoutGroup GetHorizontalOrVerticalLayoutGroupByPath(string path)
	{
		return UIManager.GetComponentByPath<HorizontalOrVerticalLayoutGroup>(path);
	}

	public static HorizontalOrVerticalLayoutGroup GetHorizontalOrVerticalLayoutGroupByOrgin(string parentName, string path)
	{
		return UIManager.GetComponentByOrgin<HorizontalOrVerticalLayoutGroup>(parentName, path);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupSpacing_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.spacing;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupSpacing_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.spacing;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupSpacing_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.spacing;
		}

		return default(System.Single);
	}


	public static void SetHorizontalOrVerticalLayoutGroupSpacing_ByName(System.Single value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.spacing = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupSpacing_ByPath(System.Single value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.spacing = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupSpacing_ByOrgin(System.Single value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.spacing = value;
		}
	}


	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildForceExpandWidth_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childForceExpandWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildForceExpandWidth_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childForceExpandWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildForceExpandWidth_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childForceExpandWidth;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalOrVerticalLayoutGroupChildForceExpandWidth_ByName(System.Boolean value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childForceExpandWidth = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildForceExpandWidth_ByPath(System.Boolean value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childForceExpandWidth = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildForceExpandWidth_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childForceExpandWidth = value;
		}
	}


	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildForceExpandHeight_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childForceExpandHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildForceExpandHeight_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childForceExpandHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildForceExpandHeight_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childForceExpandHeight;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalOrVerticalLayoutGroupChildForceExpandHeight_ByName(System.Boolean value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childForceExpandHeight = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildForceExpandHeight_ByPath(System.Boolean value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childForceExpandHeight = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildForceExpandHeight_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childForceExpandHeight = value;
		}
	}


	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildControlWidth_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childControlWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildControlWidth_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childControlWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildControlWidth_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childControlWidth;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalOrVerticalLayoutGroupChildControlWidth_ByName(System.Boolean value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childControlWidth = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildControlWidth_ByPath(System.Boolean value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childControlWidth = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildControlWidth_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childControlWidth = value;
		}
	}


	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildControlHeight_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childControlHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildControlHeight_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childControlHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildControlHeight_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childControlHeight;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalOrVerticalLayoutGroupChildControlHeight_ByName(System.Boolean value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childControlHeight = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildControlHeight_ByPath(System.Boolean value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childControlHeight = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildControlHeight_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childControlHeight = value;
		}
	}


	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildScaleWidth_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childScaleWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildScaleWidth_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childScaleWidth;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildScaleWidth_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childScaleWidth;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalOrVerticalLayoutGroupChildScaleWidth_ByName(System.Boolean value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childScaleWidth = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildScaleWidth_ByPath(System.Boolean value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childScaleWidth = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildScaleWidth_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childScaleWidth = value;
		}
	}


	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildScaleHeight_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childScaleHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildScaleHeight_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childScaleHeight;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupChildScaleHeight_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childScaleHeight;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalOrVerticalLayoutGroupChildScaleHeight_ByName(System.Boolean value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childScaleHeight = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildScaleHeight_ByPath(System.Boolean value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childScaleHeight = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildScaleHeight_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childScaleHeight = value;
		}
	}


	public static System.Boolean GetHorizontalOrVerticalLayoutGroupReverseArrangement_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.reverseArrangement;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupReverseArrangement_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.reverseArrangement;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupReverseArrangement_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.reverseArrangement;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalOrVerticalLayoutGroupReverseArrangement_ByName(System.Boolean value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.reverseArrangement = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupReverseArrangement_ByPath(System.Boolean value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.reverseArrangement = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupReverseArrangement_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.reverseArrangement = value;
		}
	}


	public static UnityEngine.RectOffset GetHorizontalOrVerticalLayoutGroupPadding_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.padding;
		}

		return null;
	}

	public static UnityEngine.RectOffset GetHorizontalOrVerticalLayoutGroupPadding_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.padding;
		}

		return null;
	}

	public static UnityEngine.RectOffset GetHorizontalOrVerticalLayoutGroupPadding_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.padding;
		}

		return null;
	}


	public static void SetHorizontalOrVerticalLayoutGroupPadding_ByName(UnityEngine.RectOffset value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.padding = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupPadding_ByPath(UnityEngine.RectOffset value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.padding = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupPadding_ByOrgin(UnityEngine.RectOffset value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.padding = value;
		}
	}


	public static UnityEngine.TextAnchor GetHorizontalOrVerticalLayoutGroupChildAlignment_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}

	public static UnityEngine.TextAnchor GetHorizontalOrVerticalLayoutGroupChildAlignment_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}

	public static UnityEngine.TextAnchor GetHorizontalOrVerticalLayoutGroupChildAlignment_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.childAlignment;
		}

		return default(UnityEngine.TextAnchor);
	}


	public static void SetHorizontalOrVerticalLayoutGroupChildAlignment_ByName(UnityEngine.TextAnchor value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childAlignment = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildAlignment_ByPath(UnityEngine.TextAnchor value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childAlignment = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupChildAlignment_ByOrgin(UnityEngine.TextAnchor value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.childAlignment = value;
		}
	}


	public static void CalculateLayoutInputHorizontal_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.CalculateLayoutInputHorizontal();
		}
	}

	public static void CalculateLayoutInputHorizontal_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.CalculateLayoutInputHorizontal();
		}
	}


	public static void CalculateLayoutInputVertical_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.CalculateLayoutInputVertical();
		}
	}

	public static void CalculateLayoutInputVertical_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.CalculateLayoutInputVertical();
		}
	}


	public static System.Single GetHorizontalOrVerticalLayoutGroupMinWidth_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupMinWidth_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.minWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupMinWidth_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.minWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetHorizontalOrVerticalLayoutGroupPreferredWidth_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupPreferredWidth_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.preferredWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupPreferredWidth_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.preferredWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetHorizontalOrVerticalLayoutGroupFlexibleWidth_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupFlexibleWidth_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupFlexibleWidth_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.flexibleWidth;
		}

		return default(System.Single);
	}


	public static System.Single GetHorizontalOrVerticalLayoutGroupMinHeight_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupMinHeight_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.minHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupMinHeight_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.minHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetHorizontalOrVerticalLayoutGroupPreferredHeight_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupPreferredHeight_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.preferredHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupPreferredHeight_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.preferredHeight;
		}

		return default(System.Single);
	}


	public static System.Single GetHorizontalOrVerticalLayoutGroupFlexibleHeight_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupFlexibleHeight_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}

	public static System.Single GetHorizontalOrVerticalLayoutGroupFlexibleHeight_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.flexibleHeight;
		}

		return default(System.Single);
	}


	public static System.Int32 GetHorizontalOrVerticalLayoutGroupLayoutPriority_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHorizontalOrVerticalLayoutGroupLayoutPriority_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHorizontalOrVerticalLayoutGroupLayoutPriority_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.layoutPriority;
		}

		return default(System.Int32);
	}


	public static void SetLayoutHorizontal_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SetLayoutHorizontal();
		}
	}

	public static void SetLayoutHorizontal_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SetLayoutHorizontal();
		}
	}


	public static void SetLayoutVertical_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SetLayoutVertical();
		}
	}

	public static void SetLayoutVertical_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SetLayoutVertical();
		}
	}


	public static System.Boolean IsActive_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.IsActive();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsActive_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.IsActive();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsDestroyed_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsDestroyed_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.IsDestroyed();
		}

		return default(System.Boolean);
	}


	public static System.Boolean IsInvoking_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.IsInvoking();
		}

		return default(System.Boolean);
	}


	public static void CancelInvoke_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.CancelInvoke();
		}
	}

	public static void CancelInvoke_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.CancelInvoke();
		}
	}


	public static void Invoke_ByName(System.String methodName, System.Single time, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByPath(System.String methodName, System.Single time, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.Invoke(methodName, time);
		}
	}

	public static void Invoke_ByOrgin(System.String methodName, System.Single time, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.Invoke(methodName, time);
		}
	}


	public static void InvokeRepeating_ByName(System.String methodName, System.Single time, System.Single repeatRate, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByPath(System.String methodName, System.Single time, System.Single repeatRate, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}

	public static void InvokeRepeating_ByOrgin(System.String methodName, System.Single time, System.Single repeatRate, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.InvokeRepeating(methodName, time, repeatRate);
		}
	}


	public static void CancelInvoke_ByName(System.String methodName, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByPath(System.String methodName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.CancelInvoke(methodName);
		}
	}

	public static void CancelInvoke_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.CancelInvoke(methodName);
		}
	}


	public static System.Boolean IsInvoking_ByName(System.String methodName, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByPath(System.String methodName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}

	public static System.Boolean IsInvoking_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.IsInvoking(methodName);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.StartCoroutine(methodName);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.StartCoroutine(methodName);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.String methodName, System.Object value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.String methodName, System.Object value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.StartCoroutine(methodName, value);
		}

		return null;
	}


	public static UnityEngine.Coroutine StartCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.StartCoroutine(routine);
		}

		return null;
	}

	public static UnityEngine.Coroutine StartCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.StartCoroutine(routine);
		}

		return null;
	}


	public static void StopCoroutine_ByName(System.Collections.IEnumerator routine, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(System.Collections.IEnumerator routine, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(System.Collections.IEnumerator routine, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(UnityEngine.Coroutine routine, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByPath(UnityEngine.Coroutine routine, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.StopCoroutine(routine);
		}
	}

	public static void StopCoroutine_ByOrgin(UnityEngine.Coroutine routine, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.StopCoroutine(routine);
		}
	}


	public static void StopCoroutine_ByName(System.String methodName, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByPath(System.String methodName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.StopCoroutine(methodName);
		}
	}

	public static void StopCoroutine_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.StopCoroutine(methodName);
		}
	}


	public static void StopAllCoroutines_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.StopAllCoroutines();
		}
	}

	public static void StopAllCoroutines_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.StopAllCoroutines();
		}
	}


	public static System.Boolean GetHorizontalOrVerticalLayoutGroupUseGUILayout_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupUseGUILayout_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupUseGUILayout_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.useGUILayout;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalOrVerticalLayoutGroupUseGUILayout_ByName(System.Boolean value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.useGUILayout = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupUseGUILayout_ByPath(System.Boolean value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.useGUILayout = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupUseGUILayout_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.useGUILayout = value;
		}
	}


	public static System.Boolean GetHorizontalOrVerticalLayoutGroupRunInEditMode_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupRunInEditMode_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupRunInEditMode_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.runInEditMode;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalOrVerticalLayoutGroupRunInEditMode_ByName(System.Boolean value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.runInEditMode = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupRunInEditMode_ByPath(System.Boolean value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.runInEditMode = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupRunInEditMode_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.runInEditMode = value;
		}
	}


	public static System.Boolean GetHorizontalOrVerticalLayoutGroupEnabled_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupEnabled_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.enabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupEnabled_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.enabled;
		}

		return default(System.Boolean);
	}


	public static void SetHorizontalOrVerticalLayoutGroupEnabled_ByName(System.Boolean value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.enabled = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupEnabled_ByPath(System.Boolean value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.enabled = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupEnabled_ByOrgin(System.Boolean value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.enabled = value;
		}
	}


	public static System.Boolean GetHorizontalOrVerticalLayoutGroupIsActiveAndEnabled_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupIsActiveAndEnabled_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}

	public static System.Boolean GetHorizontalOrVerticalLayoutGroupIsActiveAndEnabled_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.isActiveAndEnabled;
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Transform GetHorizontalOrVerticalLayoutGroupTransform_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetHorizontalOrVerticalLayoutGroupTransform_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.transform;
		}

		return null;
	}

	public static UnityEngine.Transform GetHorizontalOrVerticalLayoutGroupTransform_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.transform;
		}

		return null;
	}


	public static UnityEngine.GameObject GetHorizontalOrVerticalLayoutGroupGameObject_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetHorizontalOrVerticalLayoutGroupGameObject_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.gameObject;
		}

		return null;
	}

	public static UnityEngine.GameObject GetHorizontalOrVerticalLayoutGroupGameObject_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.gameObject;
		}

		return null;
	}


	public static UnityEngine.Component GetComponent_ByName(System.Type type, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.Type type, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.Type type, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponent(type);
		}

		return null;
	}


	public static System.Boolean TryGetComponent_ByName(System.Type type, UnityEngine.Component component, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByPath(System.Type type, UnityEngine.Component component, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}

	public static System.Boolean TryGetComponent_ByOrgin(System.Type type, UnityEngine.Component component, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.TryGetComponent(type, out component);
		}

		return default(System.Boolean);
	}


	public static UnityEngine.Component GetComponent_ByName(System.String type, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByPath(System.String type, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponent(type);
		}

		return null;
	}

	public static UnityEngine.Component GetComponent_ByOrgin(System.String type, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponent(type);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInChildren_ByName(System.Type t, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByPath(System.Type t, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentsInChildren(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInChildren_ByName(System.Type t, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByPath(System.Type t, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInChildren_ByOrgin(System.Type t, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentsInChildren(t);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component GetComponentInParent_ByName(System.Type t, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByPath(System.Type t, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component GetComponentInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, System.Boolean includeInactive, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, System.Boolean includeInactive, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, System.Boolean includeInactive, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentsInParent(t, includeInactive);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponentsInParent_ByName(System.Type t, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByPath(System.Type t, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentsInParent(t);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponentsInParent_ByOrgin(System.Type t, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponentsInParent(t);
		}

		return null;
	}


	public static UnityEngine.Component[] GetComponents_ByName(System.Type type, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByPath(System.Type type, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponents(type);
		}

		return null;
	}

	public static UnityEngine.Component[] GetComponents_ByOrgin(System.Type type, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetComponents(type);
		}

		return null;
	}


	public static void GetComponents_ByName(System.Type type, List<UnityEngine.Component> results, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByPath(System.Type type, List<UnityEngine.Component> results, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.GetComponents(type, results);
		}
	}

	public static void GetComponents_ByOrgin(System.Type type, List<UnityEngine.Component> results, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.GetComponents(type, results);
		}
	}


	public static System.String GetHorizontalOrVerticalLayoutGroupTag_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.tag;
		}

		return null;
	}

	public static System.String GetHorizontalOrVerticalLayoutGroupTag_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.tag;
		}

		return null;
	}

	public static System.String GetHorizontalOrVerticalLayoutGroupTag_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.tag;
		}

		return null;
	}


	public static void SetHorizontalOrVerticalLayoutGroupTag_ByName(System.String value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.tag = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupTag_ByPath(System.String value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.tag = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupTag_ByOrgin(System.String value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.tag = value;
		}
	}


	public static System.Boolean CompareTag_ByName(System.String tag, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByPath(System.String tag, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}

	public static System.Boolean CompareTag_ByOrgin(System.String tag, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.CompareTag(tag);
		}

		return default(System.Boolean);
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessageUpwards(methodName, value, options);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, System.Object value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, System.Object value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessageUpwards(methodName, value);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessageUpwards(methodName, value);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessageUpwards(methodName);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessageUpwards(methodName);
		}
	}


	public static void SendMessageUpwards_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessageUpwards(methodName, options);
		}
	}

	public static void SendMessageUpwards_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessageUpwards(methodName, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessage(methodName, value);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessage(methodName, value);
		}
	}


	public static void SendMessage_ByName(System.String methodName, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessage(methodName);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessage(methodName);
		}
	}


	public static void SendMessage_ByName(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessage(methodName, value, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessage(methodName, value, options);
		}
	}


	public static void SendMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessage(methodName, options);
		}
	}

	public static void SendMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.SendMessage(methodName, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.BroadcastMessage(methodName, parameter, options);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, System.Object parameter, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, System.Object parameter, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.BroadcastMessage(methodName, parameter);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, System.Object parameter, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.BroadcastMessage(methodName, parameter);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.BroadcastMessage(methodName);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.BroadcastMessage(methodName);
		}
	}


	public static void BroadcastMessage_ByName(System.String methodName, UnityEngine.SendMessageOptions options, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByPath(System.String methodName, UnityEngine.SendMessageOptions options, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.BroadcastMessage(methodName, options);
		}
	}

	public static void BroadcastMessage_ByOrgin(System.String methodName, UnityEngine.SendMessageOptions options, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.BroadcastMessage(methodName, options);
		}
	}


	public static System.Int32 GetInstanceID_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetInstanceID_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetInstanceID();
		}

		return default(System.Int32);
	}


	public static System.Int32 GetHashCode_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}

	public static System.Int32 GetHashCode_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetHashCode();
		}

		return default(System.Int32);
	}


	public static System.Boolean Equals_ByName(System.Object other, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByPath(System.Object other, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}

	public static System.Boolean Equals_ByOrgin(System.Object other, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.Equals(other);
		}

		return default(System.Boolean);
	}


	public static System.String GetHorizontalOrVerticalLayoutGroupName_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.name;
		}

		return null;
	}

	public static System.String GetHorizontalOrVerticalLayoutGroupName_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.name;
		}

		return null;
	}

	public static System.String GetHorizontalOrVerticalLayoutGroupName_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.name;
		}

		return null;
	}


	public static void SetHorizontalOrVerticalLayoutGroupName_ByName(System.String value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.name = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupName_ByPath(System.String value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.name = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupName_ByOrgin(System.String value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.name = value;
		}
	}


	public static UnityEngine.HideFlags GetHorizontalOrVerticalLayoutGroupHideFlags_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetHorizontalOrVerticalLayoutGroupHideFlags_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}

	public static UnityEngine.HideFlags GetHorizontalOrVerticalLayoutGroupHideFlags_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.hideFlags;
		}

		return default(UnityEngine.HideFlags);
	}


	public static void SetHorizontalOrVerticalLayoutGroupHideFlags_ByName(UnityEngine.HideFlags value, string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.hideFlags = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupHideFlags_ByPath(UnityEngine.HideFlags value, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.hideFlags = value;
		}
	}

	public static void SetHorizontalOrVerticalLayoutGroupHideFlags_ByOrgin(UnityEngine.HideFlags value, string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			horizontalorverticallayoutgroup.hideFlags = value;
		}
	}


	public static System.String ToString_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.ToString();
		}

		return null;
	}

	public static System.String ToString_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.ToString();
		}

		return null;
	}

	public static System.String ToString_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.ToString();
		}

		return null;
	}


	public static System.Type GetType_ByName(string name)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByName(name);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByPath(string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByPath(path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetType();
		}

		return null;
	}

	public static System.Type GetType_ByOrgin(string parentName, string path)
	{
		HorizontalOrVerticalLayoutGroup horizontalorverticallayoutgroup = GetHorizontalOrVerticalLayoutGroupByOrgin(parentName, path);
		if(horizontalorverticallayoutgroup != null)
		{
			return horizontalorverticallayoutgroup.GetType();
		}

		return null;
	}


}

