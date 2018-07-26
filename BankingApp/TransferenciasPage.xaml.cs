using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BankingApp.Models;
using Xamarin.Forms;

namespace BankingApp
{
    public partial class TransferenciasPage : ContentPage
    {
        readonly IList<Cuenta> listaCuentas = new ObservableCollection<Cuenta>();

        public TransferenciasPage()
        {
            InitializeComponent();

            listaCuentas.Add(new Cuenta
            {

                Numero = "200-01-125-006154-7",
                NombreCta = "Principal",
                SaldoActual = 750000,
                Moneda = "COL"
            }
                            );

            listaCuentas.Add(new Cuenta
            {

                Numero = "200-01-125-009067-3",
                NombreCta = "Ahorros",
                SaldoActual = 435000,
                Moneda = "COL"
            });

            listaCuentas.Add(new Cuenta
            {

                Numero = "200-02-125-008773-4",
                NombreCta = "Préstamos",
                SaldoActual = 950,
                Moneda = "DOL"
            });


            BindingContext = listaCuentas;

        }
    }
}
