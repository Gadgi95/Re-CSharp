using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._8
{
    class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Clients> ListBoxItemcColllections { get; set; }
        private string selectedItem { get; set; }


        public string SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;

                NotifyPropertyChanged("SelectedItem");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ViewModel()
        {
            ListBoxItemcColllections = new ObservableCollection<Clients>();

            Clients Ivanov = new Clients("Иванов", "Иван", "Иванович", 89991112233, "8811123456");
            ListBoxItemcColllections.Add(Ivanov);

            Clients Petrov = new Clients("Петров", "Иван", "Иванович", 89991112233, "8811123456");
            ListBoxItemcColllections.Add(Ivanov);

            Clients Sidorov = new Clients("Сидоров", "Иван", "Иванович", 89991112233, "8811123456");
            ListBoxItemcColllections.Add(Ivanov);

            Clients Мишин = new Clients("Мишин", "Иван", "Иванович", 89991112233, "8811123456");
            ListBoxItemcColllections.Add(Ivanov);

        }
    }
}
