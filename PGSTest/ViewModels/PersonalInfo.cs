using System.ComponentModel;

namespace PGSTest.ViewModels
{
    public class PersonalInfo : INotifyPropertyChanged
    {
        private string _userName, _userSurname, _userAdress, _userPhoneNumber;
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }

        public string UserSurname
        {
            get { return _userSurname; }
            set
            {
                _userSurname = value;
                OnPropertyChanged("UserSurname");
            }
        }

        public string UserAdress
        {
            get { return _userAdress; }
            set
            {
                _userAdress = value;
                OnPropertyChanged("UserAdress");
            }
        }

        public string UserPhoneNumber
        {
            get { return _userPhoneNumber; }
            set
            {
                _userPhoneNumber = value;
                OnPropertyChanged("UserPhoneNumber");
            }
        }
    }
}