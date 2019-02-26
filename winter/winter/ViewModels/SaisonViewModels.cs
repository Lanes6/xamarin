using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Storm.Mvvm;
using System.ComponentModel;

namespace winter.ViewModels
{
    class SaisonViewModel : ViewModelBase
    {
        private string _seasonName="SAISON";
        private string _temp="TEMP";
        private DateTime _date = DateTime.Now;

        //public event PropertyChangedEventHandler PropertyChanged;

        public string SeasonName
        {
            get => _seasonName;
            set
            {
                DateTime hiver = new DateTime(2019, 3, 19);
                DateTime autonme = new DateTime(2019, 6, 20);
                DateTime printemps = new DateTime(2019, 9, 22);
                DateTime ete = new DateTime(2019, 12, 21);

                _seasonName = "paf";

                if (_date > hiver)
                {
                    _seasonName = "Hiver";
                }
                if (_date > printemps)
                {
                    _seasonName = "printemps";
                }
                if (_date > ete)
                {
                    _seasonName = "Summer";
                }
                if (_date > autonme)
                {
                    _seasonName = "automne";
                }

                SetProperty(ref _seasonName, value);
            }
        }

        public string Temp
        {
            get => _temp;
            set
            {
                SetProperty(ref _temp, value);
            }
        }

        public DateTime Date
        {
            get => _date;
            set
            {
                /*
                DateTime hiver = new DateTime(2019, 3, 19);
                DateTime autonme = new DateTime(2019, 6, 20);
                DateTime printemps = new DateTime(2019, 9, 22);
                DateTime ete = new DateTime(2019, 12, 21);

                if (Date > hiver)
                {
                    //_image = "";
                    _seasonName = "Hiver";
                }
                if (Date > printemps)
                {
                    //_image = "";
                    _seasonName = "printemps";
                }
                if (Date > ete)
                {
                    //_image = "";
                    _seasonName = "Summer";
                }
                if (Date > autonme)
                {
                    //_image = "";
                    _seasonName = "automne";
                }
                */
                //_seasonName = "paf";

                SetProperty(ref _date, value);
                //SetProperty(ref _seasonName, value);

            }

                /*
            set
            {
                OnPropertyChanged();
            }*/
        }

        

    }
}




