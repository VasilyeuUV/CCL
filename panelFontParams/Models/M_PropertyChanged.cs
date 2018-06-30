using System.ComponentModel;

namespace panelFontParams.Models
{
    public class M_PropertyChanged : INotifyPropertyChanged
    {

        //#############################################################################################################################
        #region Реализация интерфейса INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        // ОСТАВИТЬ. Другой вариант реализации
        //public void OnPropertyChanged([CallerMemberName]string prop = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        //}

        #endregion // Реализация интерфейса INotifyPropertyChanged



    }
}
