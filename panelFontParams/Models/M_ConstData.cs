using System.Collections.Generic;
using System.Reflection;
using System.Windows.Media;

namespace panelFontParams.Models
{
    public static class M_ConstData
    {

        //#############################################################################################################################
        #region FIELDS

        private static List<string> _lstColors;                 // Список предустановленных Colors
        //private static List<FontFamily> _lstFontFamily;                             // Список установленных в системе шрифтов 
        private static List<string> _lstColorsBackgr;            // библиотека цветов выделения

        #endregion // FIELDS



        //#############################################################################################################################
        #region PROPERTIES

        /// <summary>
        /// Список констант Colors 
        /// </summary>
        public static List<string> LstColors
        {
            get
            {
                if (_lstColors == null)
                {
                    _lstColors = new List<string>();

                    _lstColors.Add("= по умолч. =");

                    foreach (PropertyInfo property in typeof(Colors).GetProperties())
                    {
                        if (property.DeclaringType == typeof(Colors))
                        {
                            _lstColors.Add(property.Name);
                        }
                    }
                }
                return _lstColors;
            }
        }

        /// <summary>
        /// Список констант Background Colors 
        /// </summary>
        public static List<string> LstColorsBackgr
        {
            get
            {
                if (_lstColorsBackgr == null)
                {
                    _lstColorsBackgr = new List<string>()
                    {
                      "= по умолч. =",
                      "Black",
                      "Blue",
                      "Turquoise",
                      "LawnGreen",
                      "Pink",
                      "Red",
                      "Yellow",
                      "White",
                      "DarkBlue",
                      "Teal",
                      "Green",
                      "Violet",
                      "DarkRed",
                      "Olive",
                      "Gray",
                      "LightGray"
                    };
                }
                return _lstColorsBackgr;
            }
        }



        //public static Dictionary<string, string> DictColors
        //{
        //    get
        //    {
        //        if (_dictColors == null)
        //        {
        //            _dictColors = new Dictionary<string, string>()
        //            {
        //                {"wdAuto",          "= по умолч. ="},
        //                {"wdBlack",         "Black"},
        //                {"wdBlue",          "Blue"},
        //                {"wdTurquoise",     "Turquoise"},
        //                {"wdBrightGreen",   "LawnGreen"},
        //                {"wdPink",          "Pink"},
        //                {"wdRed",           "Red"},
        //                {"wdYellow",        "Yellow"},
        //                {"wdWhite",         "White"},
        //                {"wdDarkBlue",      "DarkBlue"},
        //                {"wdTeal",          "Teal"},
        //                {"wdGreen",         "Green"},
        //                {"wdViolet",        "Violet"},
        //                {"wdDarkRed",       "DarkRed"},
        //                {"wdDarkYellow",    "Olive"},
        //                {"wdGray50",        "Gray"},
        //                {"wdGray25",        "LightGray"}
        //            };
        //        }
        //        return _dictColors;
        //    }
        //}

        #endregion // PROPERTIES

    }
}
