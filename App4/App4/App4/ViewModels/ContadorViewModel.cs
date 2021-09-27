using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App4.ViewModels
{
   public class ContadorViewModel : BaseViewModel
   {
        int _cont;
        ICommand _botonclic;
        ICommand _restaurarclic;
        string _contConvertido;
        public ContadorViewModel()
        {
            _cont = 0;
        }

        public int Contador
        {
            get => _cont;
            set
            {
                if (value == _cont) return;
                _cont = value;
                ContConvertido = $"Veces presionado: {_cont}";
                OnPropertyChanged();
            }
        }
        public string ContConvertido
        {
            get => _contConvertido;
            set
            {
                if (string.Equals(_contConvertido, value)) return;
                _contConvertido = value;
                OnPropertyChanged();
            }
        }

        public ICommand BotonClic
        {
            get
            {
                if (_botonclic == null)
                    _botonclic = new Command(BotonClicAc);
                return _botonclic;
            }
        }
        public ICommand BotonRestaurar
        {
            get
            {
                if (_restaurarclic == null)
                    _restaurarclic = new Command(BotonRestaurarClicAc);
                return _restaurarclic;
            }
        }
        private void BotonRestaurarClicAc()
        {
            Contador = 0;
            ContConvertido = "Reiniciado";
        }
        private void BotonClicAc()
        {
            Contador++;
        }
    }
    }
