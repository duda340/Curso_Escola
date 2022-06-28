using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Rec_Escola.Models;
using MySql.Data.MySqlClient;


namespace Rec_Escola.Views
{
    /// <summary>
    /// Lógica interna para EscolaForm.xaml
    /// </summary>
    public partial class EscolaForm : Window
    {
        private Escola _escola = new Escola();
        public EscolaForm()
        {
            InitializeComponent();
            Loaded += EscolaForm_Loaded;
        }
        public EscolaForm(Escola escola)
        {
            InitializeComponent();
            Loaded += EscolaForm_Loaded;

             _escola = escola;
        }

        private void EscolaForm_Loaded(object sender, RoutedEventArgs e)
        {
            txtNomeFantasia.Text = _escola.NomeFantasia;
            txtRazaoSocial.Text = _escola.RazaoSocial;
            txtCNPJ.Text = _escola.Cnpj;
            txtInscEstadual.Text = _escola.InscEstadual;
            dtCriacao.SelectedDate = _escola.DataCriacao;
            txtNomeResponsavel.Text = _escola.Responsavel;
            txtResponsavelTelefone.Text = _escola.ResponsavelTelefone;
            txtEmail.Text = _escola.Email;
            txtTelefone.Text = _escola.Telefone;
            txtEndereco.Text = _escola.Rua;
            txtNumero.Text = _escola.Numero;
            txtBairro.Text = _escola.Bairro;
            txtComplemento.Text = _escola.Complemento;
            txtCEP.Text = _escola.CEP;
            txtCidade.Text = _escola.Cidade;
            txtEstado.Text = _escola.Estado;

            if (_escola.Tipo == "Pública")
            {
                rdPublico.IsChecked = true;
            }
            else
            {
                rdPrivado.IsChecked = true;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _escola.NomeFantasia = txtNomeFantasia.Text;
            _escola.RazaoSocial = txtRazaoSocial.Text;
            _escola.Cnpj = txtCNPJ.Text;
            _escola.InscEstadual = txtInscEstadual.Text;
            _escola.DataCriacao = dtCriacao.SelectedDate;
            _escola.Responsavel = txtNomeResponsavel.Text;
            _escola.ResponsavelTelefone = txtResponsavelTelefone.Text;
            _escola.Email = txtEmail.Text;
            _escola.Telefone = txtTelefone.Text;
            _escola.Rua = txtEndereco.Text;
            _escola.Numero = txtNumero.Text;
            _escola.Bairro = txtBairro.Text;
            _escola.Complemento = txtComplemento.Text;
            _escola.CEP = txtCEP.Text;
            _escola.Cidade = txtCidade.Text;
            _escola.Estado = txtEstado.Text;
            _escola.Tipo = "Pública";

            if ((bool)rdPrivado.IsChecked)
                _escola.Tipo = "Privada";


            try
            {
                var dao = new EscolaDAO();

                if (_escola.Id > 0)
                {
                    dao.Update(_escola);
                    MessageBox.Show("Registro de escola atualizados com sucesso!");
                }
                else
                {
                    dao.Insert(_escola);
                    MessageBox.Show("Registro de escola cadastrado com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
