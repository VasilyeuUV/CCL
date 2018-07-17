using panelFontParams.Models;
using System;

namespace panelFontParams.VM_ViewModels
{
    public class VM_FontParam : M_PropertyChanged
    {

        //#############################################################################################################################
        #region FIELDS

        private M_FontParams _ucFontParam;

        #endregion // FIELDS





        //#############################################################################################################################
        #region РЕАЛИЗАЦИЯ_SINGLETON

        private static object syncRoot = new Object();
        private static volatile VM_FontParam _instance;
        public static VM_FontParam Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new VM_FontParam();
                        }
                    }
                }
                return _instance;
            }
        }


        #endregion // РЕАЛИЗАЦИЯ_SINGLETON

        




        //#############################################################################################################################
        #region PROPERTIES

        public M_FontParams UcFontParam
        {
            get
            {
                if (_ucFontParam == null)
                {
                    UcFontParam = new M_FontParams();
                }                
                return _ucFontParam;
            }
            set
            {
                _ucFontParam = value;
                OnPropertyChanged("UcFontParam");
            }
        }


        #endregion // PROPERTIES


    }
}
