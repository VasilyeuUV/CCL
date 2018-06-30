using System;
using System.Linq;
using System.Windows.Media;

namespace panelFontParams.Models
{
    public class M_FontParams
    {

        //#############################################################################################################################
        #region PROPERTIES

        public string _fontFontCollectionName { get; set; }    // название шрифта (FontFamily Name)
        public FontFamily _fontFontCollection { get; set; }   // шрифт (FontFamily)      
        public string _fontFontSize { get; set; }         // размер шрифта (FontSize)
        public string _fontFontColor { get; set; }        // цвет текста (Font Color)
        public string _fontTextBackground { get; set; }   // цвет фона (Background Color)
        public string _fontBold { get; set; }          // жирный шрифт (Font Weight)
        public string _fontItalic { get; set; }        // курсив шрифт (Font Style)
        public string _fontUnderline { get; set; }     // подчеркнутый шрифт (Font Underline)


        #endregion // PROPERTIES





        //#############################################################################################################################
        #region CTOR

        public M_FontParams()
        {
            _fontFontCollectionName = "Arial";
            _fontFontCollection = InstallFontFamily(_fontFontCollectionName);
            _fontFontSize = "12";
            _fontFontColor = "Black";
            _fontTextBackground = "Transparent";
            _fontBold = "Normal";
            _fontItalic = "Normal";
            _fontUnderline = "{x:Null}";
        }

        #endregion // CTOR






        //#############################################################################################################################
        #region METHODS


        /// <summary>
        /// Check Correctly FontFamily 
        /// </summary>
        /// <param name="s">FontCollection Name</param>
        /// <returns>FontFamily</returns>
        private FontFamily InstallFontFamily(string s)
        {
            FontFamily ff;
            try
            {
                ff = new FontFamily(s);
            }
            catch (Exception)
            {
                ff = Fonts.SystemFontFamilies.FirstOrDefault();
                _fontFontCollectionName = ff.Source;
            }
            return ff;
        }

        #endregion // METHODS

    }
}
