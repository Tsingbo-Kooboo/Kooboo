﻿using Kooboo.Data.Context;
using Kooboo.Web.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kooboo.Web.Backend.Menus.FeatureMenus
{
    public class DiagnosisMenu : IFeatureMenu
    {
        public string Name => "Diagnosis";

        public string Icon => "icon icon-picture";

        public string Url => Web.Menus.MenuHelper.AdminUrl("Sites/Diagnosis");

        public int Order => 1;

        public List<ICmsMenu> SubItems { get; set; }

        public string GetDisplayName(RenderContext Context)
        {
            return Kooboo.Data.Language.Hardcoded.GetValue("Diagnosis", Context);
        }
    }
}

 

//new MenuItem { Name = Hardcoded.GetValue("Media library", context), Icon="icon icon-picture", Url = AdminUrl("Contents/Images", siteDb) },
//            new MenuItem { Name = Hardcoded.GetValue("Pages", context), Icon = "icon icon-layers", Url = AdminUrl("Pages", siteDb) },
//            new MenuItem{ Name = Hardcoded.GetValue("Diagnosis", context), Icon = "icon icon-support", Url = AdminUrl("Sites/Diagnosis", siteDb) },