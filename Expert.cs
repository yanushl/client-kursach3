using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clint_kursach3.Models
{
    public class Expert : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _Id;
        private string _LastName;
        private string _FirstName;
        private string _rj;
        private string _DRj;

        
        public int Id
        {
            get { return _Id; }
            set
            {
                if (_Id == value)
                {
                    return;
                }
                _Id = value;
                OnPropertyChanged("_Id");
            }
        }

        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (_LastName == value)
                {
                    return;
                }
                _LastName = value;
                OnPropertyChanged("_LastName");
            }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (_FirstName == value)
                {
                    return;
                }
                _FirstName = value;
                OnPropertyChanged("_FirstName");
            }
        }

        public string rj
        {
            get { return _rj; }
            set
            {
                if (_rj == value)
                {
                    return;
                }
                _rj = value;
                OnPropertyChanged("_rj");
            }
        }

        public string DRj
        {
            get { return _DRj; }
            set
            {
                if (_DRj == value)
                {
                    return;
                }
                _DRj = value;
                OnPropertyChanged("_DRj");
            }
        }

        private void OnPropertyChanged(string v = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public string ToNetWork
        {
            get { return _Id + "\n" + _FirstName + "\n" + _LastName + "\n"; }
        }
    }
}
