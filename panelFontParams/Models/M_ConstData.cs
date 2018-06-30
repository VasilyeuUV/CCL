using System.Collections.Generic;
using System.Reflection;
using System.Windows.Media;

namespace panelFontParams.Models
{
    public static class M_ConstData
    {

        //#############################################################################################################################
        #region FIELDS

        private static List<string> _lstColors;                                     // Список предустановленных Colors
        //private static List<FontFamily> _lstFontFamily;                             // Список установленных в системе шрифтов  

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
        /// Список установленных в системе шрифтов
        /// </summary>
        //public static List<FontFamily> LstFontFamily
        //{
        //    get
        //    {
        //        if (_lstFontFamily == null)
        //        {
        //            _lstFontFamily = Fonts.SystemFontFamilies.OrderBy(o => o.Source).ToList();
        //        }
        //        return _lstFontFamily;
        //    }
        //}


        #endregion // PROPERTIES
    }
}
