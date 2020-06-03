using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clint_kursach3.Models
{

    public class Expert_Table : INotifyPropertyChanged, IDataErrorInfo
    {

        //int c = 0;

        //private BindingList<string> _marks;
        //public string mark
        //{
        //    get { c++; return _marks[c-1]; }
        //    set
        //    {

        //        if (_marks[c] == value)
        //        {
        //            return;
        //        }
        //        _marks[c] = value;
        //        OnPropertyChanged("mark");
        //    }
        //}

        //public Expert_Table(Expert other, int length)
        //{
        //    _expert = other;
        //    _marks = new BindingList<string>();
        //    for (int i = 0; i < length; i++)
        //    {
        //        _marks.Add("");
        //    }
        //}

        /// <summary>
        /// ///////////////
        /// </summary>
        private Expert _expert;


        private string _mark1;
        private string _mark2;
        private string _mark3;
        private string _mark4;
        private string _mark5;
        private string _mark6;
        private string _mark7;
        private string _mark8;
        private string _mark9;
        private string _mark10;
        private string _mark11;
        private string _mark12;
        private string _mark13;
        private string _mark14;
        private string _mark15;
        private string _mark16;
        private string _mark17;
        private string _mark18;
        private string _mark19;
        private string _mark20;


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
                        case "mark1":
                            if (Convert.ToInt32(mark1) < 0 || Convert.ToInt32(mark1) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark2":
                            if (Convert.ToInt32(mark2) < 0 || Convert.ToInt32(mark2) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark3":
                            if (Convert.ToInt32(mark3) < 0 || Convert.ToInt32(mark3) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark4":
                            if (Convert.ToInt32(mark4) < 0 || Convert.ToInt32(mark4) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark5":
                            if (Convert.ToInt32(mark5) < 0 || Convert.ToInt32(mark5) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark6":
                            if (Convert.ToInt32(mark6) < 0 || Convert.ToInt32(mark6) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark7":
                            if (Convert.ToInt32(mark7) < 0 || Convert.ToInt32(mark7) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark8":
                            if (Convert.ToInt32(mark8) < 0 || Convert.ToInt32(mark8) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark9":
                            if (Convert.ToInt32(mark9) < 0 || Convert.ToInt32(mark9) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark10":
                            if (Convert.ToInt32(mark10) < 0 || Convert.ToInt32(mark10) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark11":
                            if (Convert.ToInt32(mark11) < 0 || Convert.ToInt32(mark11) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark12":
                            if (Convert.ToInt32(mark12) < 0 || Convert.ToInt32(mark12) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark13":
                            if (Convert.ToInt32(mark13) < 0 || Convert.ToInt32(mark13) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark14":
                            if (Convert.ToInt32(mark14) < 0 || Convert.ToInt32(mark14) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark15":
                            if (Convert.ToInt32(mark15) < 0 || Convert.ToInt32(mark15) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark16":
                            if (Convert.ToInt32(mark16) < 0 || Convert.ToInt32(mark16) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark17":
                            if (Convert.ToInt32(mark17) < 0 || Convert.ToInt32(mark17) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark18":
                            if (Convert.ToInt32(mark18) < 0 || Convert.ToInt32(mark18) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark19":
                            if (Convert.ToInt32(mark19) < 0 || Convert.ToInt32(mark19) > 10)
                            {
                                error = "Оценка принимает значения от 0 до 10";
                            }
                            break;
                        case "mark20":
                            if (Convert.ToInt32(mark20) < 0 || Convert.ToInt32(mark20) > 10)
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

        public Expert_Table(Expert other)
        {
            _expert = other;
        }

        //public Expert_Table(int index, int count)
        //{ 
        //    _row_name = "Э" + index;
        //}

        public string expert
        {
            get { return "Э" + _expert.Id; }
        }

        public string expert_rj { get { return _expert.rj; } set { _expert.rj = value; } }

        public string expert_DRj { get { return _expert.DRj; } set { _expert.DRj = value; } }

        public string mark1
        {
            get { return _mark1; }
            set
            {
                if (_mark1 == value)
                {
                    return;
                }
                _mark1 = value;
                OnPropertyChanged("mark1");
            }
        }

        public string mark2
        {
            get { return _mark2; }
            set
            {
                if (_mark2 == value)
                {
                    return;
                }
                _mark2 = value;
                OnPropertyChanged("mark2");
            }
        }
        public string mark3
        {
            get { return _mark3; }
            set
            {
                if (_mark3 == value)
                {
                    return;
                }
                _mark3 = value;
                OnPropertyChanged("mark3");
            }
        }
        public string mark4
        {
            get { return _mark4; }
            set
            {
                if (_mark4 == value)
                {
                    return;
                }
                _mark4 = value;
                OnPropertyChanged("mark4");
            }
        }
        public string mark5
        {
            get { return _mark5; }
            set
            {
                if (_mark5 == value)
                {
                    return;
                }
                _mark5 = value;
                OnPropertyChanged("mark5");
            }
        }
        public string mark6
        {
            get { return _mark6; }
            set
            {
                if (_mark6 == value)
                {
                    return;
                }
                _mark6 = value;
                OnPropertyChanged("mark6");
            }
        }
        public string mark7
        {
            get { return _mark7; }
            set
            {
                if (_mark7 == value)
                {
                    return;
                }
                _mark7 = value;
                OnPropertyChanged("mark7");
            }
        }
        public string mark8
        {
            get { return _mark8; }
            set
            {
                if (_mark8 == value)
                {
                    return;
                }
                _mark8 = value;
                OnPropertyChanged("mark8");
            }
        }
        public string mark9
        {
            get { return _mark9; }
            set
            {
                if (_mark9 == value)
                {
                    return;
                }
                _mark9 = value;
                OnPropertyChanged("mark9");
            }
        }
        public string mark10
        {
            get { return _mark10; }
            set
            {
                if (_mark10 == value)
                {
                    return;
                }
                _mark10 = value;
                OnPropertyChanged("mark10");
            }
        }
        public string mark11
        {
            get { return _mark11; }
            set
            {
                if (_mark11 == value)
                {
                    return;
                }
                _mark11 = value;
                OnPropertyChanged("mark11");
            }
        }
        public string mark12
        {
            get { return _mark12; }
            set
            {
                if (_mark10 == value)
                {
                    return;
                }
                _mark12 = value;
                OnPropertyChanged("mark12");
            }
        }
        public string mark13
        {
            get { return _mark13; }
            set
            {
                if (_mark13 == value)
                {
                    return;
                }
                _mark13 = value;
                OnPropertyChanged("mark13");
            }
        }
        public string mark14
        {
            get { return _mark14; }
            set
            {
                if (_mark14 == value)
                {
                    return;
                }
                _mark14 = value;
                OnPropertyChanged("mark14");
            }
        }
        public string mark15
        {
            get { return _mark15; }
            set
            {
                if (_mark15 == value)
                {
                    return;
                }
                _mark15 = value;
                OnPropertyChanged("mark15");
            }
        }
        public string mark16
        {
            get { return _mark16; }
            set
            {
                if (_mark16 == value)
                {
                    return;
                }
                _mark16 = value;
                OnPropertyChanged("mark16");
            }
        }
        public string mark17
        {
            get { return _mark17; }
            set
            {
                if (_mark17 == value)
                {
                    return;
                }
                _mark17 = value;
                OnPropertyChanged("mark17");
            }
        }
        public string mark18
        {
            get { return _mark18; }
            set
            {
                if (_mark18 == value)
                {
                    return;
                }
                _mark18 = value;
                OnPropertyChanged("mark18");
            }
        }
        public string mark19
        {
            get { return _mark19; }
            set
            {
                if (_mark19 == value)
                {
                    return;
                }
                _mark19 = value;
                OnPropertyChanged("mark19");
            }
        }
        public string mark20
        {
            get { return _mark20; }
            set
            {
                if (_mark20 == value)
                {
                    return;
                }
                _mark20 = value;
                OnPropertyChanged("mark20");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public string ToServ(int count)
        {
            List<string> ls = new List<string>();
            ls.Add(_mark1); ls.Add(_mark2); ls.Add(_mark3); ls.Add(_mark4); ls.Add(_mark5); ls.Add(_mark6); ls.Add(_mark7); ls.Add(_mark8); ls.Add(_mark9); ls.Add(_mark10);
            ls.Add(_mark11); ls.Add(_mark12); ls.Add(_mark13); ls.Add(_mark14); ls.Add(_mark15); ls.Add(_mark16); ls.Add(_mark17); ls.Add(_mark18); ls.Add(_mark19); ls.Add(_mark20);
            int len = ls.Count;
            ls.RemoveRange(count, len - count);
            string str = _expert.ToNetWork;
            int i = 0;
            for (i = 0; i < ls.Count; i++)
            {
                str += ls[i];
                str += "\n";
            }
            str = str.Remove(str.Length - 1);
            str += "\t";
            return str;
        }

    }
}
