﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Biblioteca;
namespace Evaluacion01
{
    /// <summary>
    /// Lógica de interacción para listadoContrato.xaml
    /// </summary>
    public partial class listadoContrato : Window
    {
        public listadoContrato()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gridcontrato.ItemsSource = ContratoCollecion.lista;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
