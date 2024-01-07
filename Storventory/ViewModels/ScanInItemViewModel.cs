using Storventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storventory.ViewModels
{
    public class ScanInItemViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<InventoryItem> _scannedInItems;
        public ObservableCollection<InventoryItem> ScannedInItems
        {
            get => _scannedInItems;
            set
            {
                _scannedInItems = value;
                OnPropertyChanged(nameof(ScannedInItems));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
