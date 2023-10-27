using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema3_CalculadoraDinamica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AsignaNumeros();
        }

        public void AsignaNumeros()
        {
            Button boton0 = new Button();
            boton0.Tag = 0.ToString();

            Viewbox viewBox0 = new Viewbox();

            TextBox textBox0 = new TextBox();
            textBox0.Text = 0.ToString();

            viewBox0.Child = textBox0;
            boton0.Content = viewBox0;


            Grid.SetRow(boton0, 4);
            Grid.SetColumn(boton0, 0);
            Grid.SetColumnSpan(boton0, 3);

            botones.Children.Add(boton0);

            Button boton;
            Viewbox viewBox;
            TextBox textBox;
            int numero = 1;

            for (int i = 1; i < botones.RowDefinitions.Count - 1; i++) 
            {
                for(int j = 0; j < botones.ColumnDefinitions.Count; j++) 
                {
                    boton = new Button();
                    boton.Tag = numero.ToString();

                    viewBox = new Viewbox();

                    textBox = new TextBox();
                    textBox.Text = numero.ToString();

                    viewBox.Child = textBox;
                    boton.Content = viewBox;


                    Grid.SetRow(boton, i);
                    Grid.SetColumn(boton, j);

                    botones.Children.Add(boton);

                    numero++;
                }
            }
        }

        private void Num_Click(object sender, RoutedEventArgs e)
        {
            cuadroTexto.Text += ((Button)sender).Tag.ToString();
        }
    }
}
