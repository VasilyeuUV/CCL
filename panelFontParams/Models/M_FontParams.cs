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
                    FontFontCollectionName = FONTNAME_DFLT;
                }
                return _fontFontCollectionName;
            }
            set
            {
                _fontFontCollectionName = value;
                OnPropertyChanged("FontFontCollectionName");
            }
        }


        /// <summary>
        /// шрифт (FontFamily) 
        /// </summary>
        public FontFamily FontFontCollection
        {
            get
            {
                if (_fontFontCollection == null)
                {
                    FontFontCollection = FONTCOLLECTION_DFLT;
                }
                return _fontFontCollection;
            }
            set
            {
                _fontFontCollection = value;
                OnPropertyChanged("FontFontCollection");
            }
        }


        /// <summary>
        /// размер шрифта (FontSize)
        /// </summary>
        public string FontFontSize
        {
            get
            {
                if (_fontFontSize == null)
                {
                    FontFontSize = FONTSIZE_DFLT;
                }
                return _fontFontSize;
            }
            set
            {
                _fontFontSize = value;
                OnPropertyChanged("FontFontSize");
            }
        }


        /// <summary>
        /// жирный шрифт (Font Weight)
        /// </summary>
        public string FontBold
        {
            get
            {
                if (_fontBold == null)
                {
                    FontBold = FONTBOLD_DFLT;
                }
                return _fontBold;
            }
            set
            {
                _fontBold = value;
                OnPropertyChanged("FontBold");
            }
        }



        /// <summary>
        /// курсив шрифт (Font Style)
        /// </summary>
        public string FontItalic
        {
            get
            {
                if (_fontItalic == null)
                {
                    FontItalic = FONTITALIC_DFLT;
                }
                return _fontItalic;
            }
            set
            {
                _fontItalic = value;
                OnPropertyChanged("FontItalic");
            }
        }


        /// <summary>
        /// подчеркнутый шрифт (Font Underline)
        /// </summary>
        public string FontUnderline
        {
            get
            {
                if (_fontUnderline == null)
                {
                    FontUnderline = FONTUNDERLINE_DFLT;
                }
                return _fontUnderline;
            }
            set
            {
                _fontUnderline = value;
                OnPropertyChanged("FontUnderline");
            }
        }




        /// <summary>
        /// цвет текста (Font Color)
        /// </summary>
        public string FontFontColor
        {
            get
            {
                if (_fontFontColor == null)
                {
                    FontFontColor = FONTCOLOR_DFLT;
                }
                return _fontFontColor;
            }
            set
            {
                _fontFontColor = value;
                OnPropertyChanged("FontFontColor");
            }
        }


        /// <summary>
        /// цвет фона (Background Color)
        /// </summary>
        public string FontTextBackground
        {
            get
            {
                if (_fontTextBackground == null)
                {
                    FontTextBackground = TEXTBACKGROUND_DFLT;
                }
                return _fontTextBackground;
            }
            set
            {
                _fontTextBackground = value;
                OnPropertyChanged("FontTextBackground");
            }
        }
        

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
