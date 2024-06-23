using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiseEnPlace.ViewModels
{
    public class SelectedLabels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<string> _selectedLabels;
        public ObservableCollection<string> selectedLabels
        {
            get { return _selectedLabels; }
            set
            {
                if (_selectedLabels != value)
                {
                    _selectedLabels = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(selectedLabels)));
                }
            }
        }

        public SelectedLabels()
        {
            selectedLabels = new ObservableCollection<string>();
        }


    }
}
