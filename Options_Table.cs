using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clint_kursach3.Models
{
    public class Options_Table : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private BindingList<Options> _options;
        private List<string> marks;
        private Expert _expert;
        private int _option_mark1;
        private int _option_mark2;
        private int _option_mark3;
        private int _option_mark4;
        private int _option_mark5;
        private int _option_mark6;
        private int _option_mark7;
        private int _option_mark8;
        private int _option_mark9;
        private int _option_mark10;


        public Options_Table(Expert other, BindingList<Options> opti)
        {
            _expert = other;
            _options = opti;
            marks = new List<string>();
        }



        public string expert
        {
            get { return "Э" + _expert.Id; }
        }

        public string expert_rj { get { return _expert.rj; } set { _expert.rj = value; } }

        public string expert_Drj { get { return _expert.DRj; } set { _expert.DRj = value; } }

        public List<string> Marks { get { return marks; } set { marks = value; } }


        public int Option_Mark1
        {
            get { return _option_mark1; }
            set
            {
                if (_option_mark1 == value)
                {
                    return;
                }
                _option_mark1 = value;
                OnPropertyChanged("Option_Mark1");
            }
        }

        public int Option_Mark2
        {
            get { return _option_mark2; }
            set
            {
                if (_option_mark2 == value)
                {
                    return;
                }
                _option_mark2 = value;
                OnPropertyChanged("Option_Mark2");
            }
        }
        public int Option_Mark3
        {
            get { return _option_mark3; }
            set
            {
                if (_option_mark3 == value)
                {
                    return;
                }
                _option_mark3 = value;
                OnPropertyChanged("Option_Mark3");
            }
        }
        public int Option_Mark4
        {
            get { return _option_mark4; }
            set
            {
                if (_option_mark4 == value)
                {
                    return;
                }
                _option_mark4 = value;
                OnPropertyChanged("Option_Mark4");
            }
        }
        public int Option_Mark5
        {
            get { return _option_mark5; }
            set
            {
                if (_option_mark5 == value)
                {
                    return;
                }
                _option_mark5 = value;
                OnPropertyChanged("Option_Mark5");
            }
        }
        public int Option_Mark6
        {
            get { return _option_mark6; }
            set
            {
                if (_option_mark6 == value)
                {
                    return;
                }
                _option_mark6 = value;
                OnPropertyChanged("Option_Mark6");
            }
        }
        public int Option_Mark7
        {
            get { return _option_mark7; }
            set
            {
                if (_option_mark7 == value)
                {
                    return;
                }
                _option_mark7 = value;
                OnPropertyChanged("Option_Mark7");
            }
        }
        public int Option_Mark8
        {
            get { return _option_mark8; }
            set
            {
                if (_option_mark8 == value)
                {
                    return;
                }
                _option_mark8 = value;
                OnPropertyChanged("Option_Mark8");
            }
        }
        public int Option_Mark9
        {
            get { return _option_mark9; }
            set
            {
                if (_option_mark9 == value)
                {
                    return;
                }
                _option_mark9 = value;
                OnPropertyChanged("Option_Mark9");
            }
        }
        public int Option_Mark10
        {
            get { return _option_mark10; }
            set
            {
                if (_option_mark10 == value)
                {
                    return;
                }
                _option_mark10 = value;
                OnPropertyChanged("Option_Mark10");
            }
        }

        public void OnPropertyChanged(string v = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                try
                {
                    switch (columnName)
                    {
                        case "Option_Mark1":
                            if (Convert.ToInt32(Option_Mark1) < 0 || Convert.ToInt32(Option_Mark1) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "Option_Mark2":
                            if (Convert.ToInt32(Option_Mark2) < 0 || Convert.ToInt32(Option_Mark2) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "Option_Mark3":
                            if (Convert.ToInt32(Option_Mark3) < 0 || Convert.ToInt32(Option_Mark3) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "Option_Mark4":
                            if (Convert.ToInt32(Option_Mark4) < 0 || Convert.ToInt32(Option_Mark4) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "Option_Mark5":
                            if (Convert.ToInt32(Option_Mark5) < 0 || Convert.ToInt32(Option_Mark5) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "Option_Mark6":
                            if (Convert.ToInt32(Option_Mark6) < 0 || Convert.ToInt32(Option_Mark6) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "Option_Mark7":
                            if (Convert.ToInt32(Option_Mark7) < 0 || Convert.ToInt32(Option_Mark7) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "Option_Mark8":
                            if (Convert.ToInt32(Option_Mark8) < 0 || Convert.ToInt32(Option_Mark8) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "Option_Mark9":
                            if (Convert.ToInt32(Option_Mark9) < 0 || Convert.ToInt32(Option_Mark9) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "Option_Mark10":
                            if (Convert.ToInt32(Option_Mark10) < 0 || Convert.ToInt32(Option_Mark10) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;

                    }
                }
                catch (Exception)
                {
                    error = "Оценка принимает значения от 0 до 10";
                }

                return error;
            }
        }


        public string ToServ()
        {
            if (marks.Count > 0)
            {
                marks.Clear();
            }
            int count = _options.Count;
            List<string> ls = new List<string>();
            ls.Add(_option_mark1.ToString()); ls.Add(_option_mark2.ToString()); ls.Add(_option_mark3.ToString()); ls.Add(_option_mark4.ToString());
            ls.Add(_option_mark5.ToString()); ls.Add(_option_mark6.ToString()); ls.Add(_option_mark7.ToString()); ls.Add(_option_mark8.ToString());
            ls.Add(_option_mark9.ToString()); ls.Add(_option_mark10.ToString());

            int len = ls.Count;
            ls.RemoveRange(count, len - count);

            string str = _expert.ToNetWork;

            int i;
            for (i = 0; i < _options.Count; i++)
            {
                str += _options[i].ToNetWork;

                str += ls[i];
                str += "\n";
                marks.Add(ls[i]);
            }

            str = str.Remove(str.Length - 1);
            str += "\t";
            return str;
        }

    }
}
