using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace panelFontParams.Models
{
    public class M_PropertyChanged : INotifyPropertyChanged
    {

        //#############################################################################################################################
        #region Реализация интерфейса INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            //PropertyChanged?.Invoke(this, e);     // упрощенная запись нижеследующего
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, e);
            }   
        }


        // ОСТАВИТЬ. Другой вариант реализации
        //public void OnPropertyChanged([CallerMemberName]string prop = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        //}

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }


        #endregion // Реализация интерфейса INotifyPropertyChanged



    }
}
