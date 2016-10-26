using System.ComponentModel;

namespace TimeSavers.VS.UI.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void SetValue()
        {
        }
    }
}