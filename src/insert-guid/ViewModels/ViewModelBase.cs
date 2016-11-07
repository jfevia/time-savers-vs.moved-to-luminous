using System.ComponentModel;

namespace TimeSavers.VS.InsertGuid.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void SetValue()
        {
        }
    }
}