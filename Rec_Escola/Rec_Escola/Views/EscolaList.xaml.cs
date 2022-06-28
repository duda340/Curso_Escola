using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Rec_Escola.Models;
using Rec_Escola.Interface;
using Rec_Escola.Views;
using MySql.Data.MySqlClient;

namespace Rec_Escola.Views
{
    /// <summary>
    /// Lógica interna para EscolaList.xaml
    /// </summary>
    public partial class EscolaList : Window
    {
       // private Escola _escola = new Escola();
        public EscolaList()
        {
            InitializeComponent();
            Loaded += EscolaList_Loaded;
        }

        private void EscolaList_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var dao = new EscolaDAO();
                List<Escola> listaEscolas = dao.List();

                dataGridEscola.ItemsSource = listaEscolas;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CarregarListagem()
        {
            try
            {
                var dao = new EscolaDAO();
                List<Escola> listaEscolas = dao.List();

                dataGridEscola.ItemsSource = listaEscolas;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //btAtualizar
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var escolaSelecionada = dataGridEscola.SelectedItem as Escola;

            var form = new EscolaForm(escolaSelecionada);
            form.ShowDialog();
         

        }

        //btApagar
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var escolaSelecionada = dataGridEscola.SelectedItem as Escola;

            var resultado = MessageBox.Show($"Deseja realmente remover a escola '{escolaSelecionada.NomeFantasia}' ?", "Confirmação de Exclusão",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);

            try
            {
                if (resultado == MessageBoxResult.Yes)
                {

                    var dao = new EscolaDAO();
                    dao.Delete(escolaSelecionada);

                    MessageBox.Show("Registro removido com sucesso!");
                    CarregarListagem();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
