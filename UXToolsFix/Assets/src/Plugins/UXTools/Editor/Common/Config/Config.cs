using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace ThunderFireUITool
{
    //UXTools中的路径和常量
    public partial class ThunderFireUIToolConfig
    {
        public const string Path = "Assets/src/Plugins";

        public static readonly string RootPath = $"{Path}/";
        public static readonly string SamplesRootPath = $"{Path}/UX_Samples/";

        public static readonly string AssetsRootPath = $"{Path}/UXTools/Res/";
        public static readonly string ToolsRootPath = $"{Path}/UXTools/Editor/";

        //L22
        //public static readonly string RootPath = $"{Path}/Editor/editor_ui/UXTools/Res/";

        //L33
        //public static readonly string RootPath = "";

        //Quick Create
        public static readonly string TextAssemblyName = "Leihuo.UXTools.Runtime";
        public static readonly string TextClassName = "UnityEngine.UI.UXText";
        public static readonly string ImageAssemblyName = "Leihuo.UXTools.Runtime";
        public static readonly string ImageClassName = "UnityEngine.UI.UXImage";

        //L33
        //public static readonly string TextAssemblyName = "UnityEngine.UI";
        //public static readonly string TextClassName = "UnityEngine.UI.Text";
        //public static readonly string ImageAssemblyName = "Assembly-CSharp";
        //public static readonly string ImageClassName = "UnityEngine.UI.UIImage";
    }
}
