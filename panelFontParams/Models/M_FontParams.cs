using System;
using System.Linq;
using System.Windows.Media;

namespace panelFontParams.Models
{
    public class M_FontParams : M_PropertyChanged
    {

        //#############################################################################################################################
        #region CONSTANTS

        private string FONTNAME_DFLT = "Arial";
        private FontFamily FONTCOLLECTION_DFLT = new FontFamily("Arial");
        private string FONTSIZE_DFLT = "12";
        private string FONTBOLD_DFLT = "Normal";
        private string FONTITALIC_DFLT = "Normal";
        private string FONTUNDERLINE_DFLT = "{x:Null}";
        private string FONTCOLOR_DFLT = "Black";
        private string TEXTBACKGROUND_DFLT = "Transparent";

        #endregion // CONSTANTS


        //#############################################################################################################################
        #region FIELDS

        private string _fontFontCollectionName;     // название шрифта (FontFamily Name)
        private FontFamily _fontFontCollection;     // шрифт (FontFamily)      
        private string _fontFontSize;               // размер шрифта (FontSize)
        private string _fontBold;                   // жирный шрифт (Font Weight)
        private string _fontItalic;                 // курсив шрифт (Font Style)
        private string _fontUnderline;              // подчеркнутый шрифт (Font Underline)
        private string _fontFontColor;              // цвет текста (Font Color)
        private string _fontTextBackground;         // цвет фона (Background Color)

        #endregion // FIELDS


        //#############################################################################################################################
        #region PROPERTIES


        /// <summary>
        /// название шрифта (FontFamily Name)
        /// </summary>
        public string FontFontCollectionName
        {
            get
            {
                if (_fontFontCollectionName == null)
                {
                    FontFontCollectionName = "Arial";
                }
                return _fontFontCollectionName;
            }
            set
            {
                _fontFontCollectionName = value;
                OnPropertyChanged("FontFontCollectionName");
            }
        }
        


        public FontFamily FontFontCollection { get => _fontFontCollection; set => _fontFontCollection = value; }
        public string FontFontSize { get => _fontFontSize; set => _fontFontSize = value; }
        public string FontBold { get => _fontBold; set => _fontBold = value; }
        public string FontItalic { get => _fontItalic; set => _fontItalic = value; }
        public string FontUnderline { get => _fontUnderline; set => _fontUnderline = value; }
        public string FontFontColor { get => _fontFontColor; set => _fontFontColor = value; }
        public string FontTextBackground { get => _fontTextBackground; set => _fontTextBackground = value; }






        #endregion // PROPERTIES





        //#############################################################################################################################
        #region CTOR

        public M_FontParams()
        {
            FontFontCollectionName = "Arial";
            FontFontCollection = InstallFontFamily(FontFontCollectionName);
            FontFontSize = "12";
            FontFontColor = "Black";
            FontTextBackground = "Transparent";
            FontBold = "Normal";
            FontItalic = "Normal";
            FontUnderline = "{x:Null}";
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
                FontFontCollectionName = ff.Source;
            }
            return ff;
        }

        #endregion // METHODS

    }
}
