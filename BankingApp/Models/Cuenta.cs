using System;

namespace BankingApp.Models
{
    public class Cuenta
    {
        public int codigo { get; set; }
        public string Numero { get; set; }
        public string NombreCta { get; set; }
        public decimal SaldoActual { get; set; }       
        public string Moneda { get; set; }
        public DateTime FecCreacion { get; set; }
              
        public Cuenta()
        {
        }


        public string getDescripcionCuenta
        {
            get
            {
                return string.Format("{0} - {1}", Numero,NombreCta);
            }                
         }

        public string getInfoSaldo
        {
            get
            {
                return string.Format("Saldo Actual: {0:N}", SaldoActual);
            }
        }

    }
}
