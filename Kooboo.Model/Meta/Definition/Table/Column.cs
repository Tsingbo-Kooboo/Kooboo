﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kooboo.Model.Meta.Definition
{
 public   class Column
    { 
        public Column()
        {
            this.Header = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            this.Cell = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase); 
        }

        public string Name { get; set; }

        public Dictionary<string, object> Header { get; set; }

        public Dictionary<string,object> Cell { get; set; }  
    }
     

    //     name: "online",//column name
    //    header: { //table header
    //      displayName: "在线情况",//header displayName
    //      class: "",//header class
    //      style: ""//header style
    //    },
    //    cell: {
    //      type: "link",//cell type
    //      style: "",//cell style
    //      class: "",//cell class
    //      action: "newWindow",//cell action
    //      url: "/layout/detail?id={id}" //cell url
    //    }


}
