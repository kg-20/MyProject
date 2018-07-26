using System;
using System.Collections.Generic;

namespace BankingApp.Models
{
    public class Usuario
    {

        public int IdCliente { get; set; }
        public String NombreCliente { get; set; }
        public List<Cuenta> ListaCuentas { get; set; }

        public Usuario()
        {
        }
    }
}
