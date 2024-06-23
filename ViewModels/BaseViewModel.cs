using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace MiseEnPlace.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public readonly HttpClient Client = new HttpClient(); // Httpclient we will be using throughout to make our api calls
        
        public BaseViewModel()
        { 
         Client.Timeout = TimeSpan.FromHours(1);
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
