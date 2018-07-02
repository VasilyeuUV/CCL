using panelFontParams.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.VM_ViewModels
{
    public class VM_PanelFontParams : M_PropertyChanged
    {

        //#############################################################################################################################
        #region FIELDS

        private M_FontParams _testFontParam;

        #endregion // FIELDS





        //#############################################################################################################################
        #region РЕАЛИЗАЦИЯ_SINGLETON

        private static object syncRoot = new Object();
        private static volatile VM_PanelFontParams _instance;
        public static VM_PanelFontParams Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new VM_PanelFontParams();
                        }
                    }
                }
                return _instance;
            }
        }


        #endregion // РЕАЛИЗАЦИЯ_SINGLETON






        //#############################################################################################################################
        #region PROPERTIES

        public M_FontParams TestFontParam
        {
            get
            {
                if (_testFontParam == null)
                {
                    _testFontParam = panelFontParams.VM_ViewModels.VM_FontParam.Instance.UcFontParam;                    
                }
                return _testFontParam;
            }
            set
            {
                _testFontParam = value;
                OnPropertyChanged("TestFontParam");
            }
        }


        #endregion // PROPERTIES


    }


}

