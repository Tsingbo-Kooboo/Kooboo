﻿using System;
using System.Collections.Generic;
using System.Text;
using Kooboo.Model.Meta.Definition;

namespace Kooboo.Model.Meta.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CellConditionAttribute : Attribute, IMetaAttribute
    {
        public bool IsHeader => false;

        public bool Visible { get; set; } = true;

        public string PropertyName => "condition";

        public string TrueClass { get; set; } = string.Empty;

        public string FalseClass { get; set; } = string.Empty;

        public CellConditionAttribute(bool visible)
        {
            Visible = visible;
        }

        public CellConditionAttribute(string trueClass,string falseClass)
        {
            TrueClass = trueClass;
            FalseClass = FalseClass;
        }

        public object Value()
        {
            var visibleStr = Visible.ToString();
            visibleStr = Char.ToLower(visibleStr[0]) + visibleStr.Substring(1);
            
            if (!string.IsNullOrEmpty(TrueClass) || !string.IsNullOrEmpty(FalseClass))
            {
                var dic = new Dictionary<string, string>();
                dic.Add("class")
                return $"{{class:{{true:{TrueClass},false:{FalseClass}}},visible:{visibleStr}}}";
            }
            else
            {
                var dic = new Dictionary<string, bool>();
                dic.Add("visible", Visible);
                return dic;
            }
            
        }
    }
}
