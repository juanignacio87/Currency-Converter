using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Conversor_De_Moneda
{
    internal class CurrencyConverterViewModel : Notifier 
    {
        private decimal pesos;

        public decimal Pesos
        {
            get { return pesos; }
            set
            {
                pesos = value;
                OnPropertyChanged("Pesos");
                OnPesosChanged();
            }
        }

        private decimal dolares;

        public decimal Dolares
        {
            get { return dolares; }
            set
            {
                dolares = value;
                OnPropertyChanged("Dolares");
            }
        }
        
        private void OnPesosChanged()
        {
            Dolares = Pesos / 395M;
        }
    }
}
