using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAgendamento
{
    public partial class Form1 : Form
    {
        //static string strCn = "Data Source=192.168.60.28;Initial Catalog=3EMIA;User ID=;Password=";
        static string strCn = "Data Source=BR-REBOUCAJ03;Initial Catalog=dbAgendamento;Integrated Security=True";
        
        // Responsável por efetuar a conexão com o banco de dados
        SqlConnection conexao = new SqlConnection(strCn);
        
        // Objeto usado para recuperar valores
        SqlDataReader DR;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            // Criando a inserção do nome no agendamento de horários
            string agendar = "insert into tb_Agendamento_11 values (@h1, @h2, @h3, @h4, @h5, @agendamento)";

            SqlCommand cmd = new SqlCommand(agendar, conexao);

            cmd.Parameters.AddWithValue("@h1", txtH1.Text);
            cmd.Parameters.AddWithValue("@h2", txtH2.Text);
            cmd.Parameters.AddWithValue("@h3", txtH3.Text);
            cmd.Parameters.AddWithValue("@h4", txtH4.Text);
            cmd.Parameters.AddWithValue("@h5", txtH5.Text);

            // A atenção ao objeto DateTimePicker
            cmd.Parameters.AddWithValue("@agendamento", dateTimePicker1.Text);

            try
            {
                conexao.Open();
                //DR = cmd.ExecuteReader();
                int resultado;
                // Executando o insert no banco cmd.ExecuteNonQuery() e atribuindo o resultado a variável resultado, se o resultado for igual a 1 - OK
                resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                {
                    MessageBox.Show("Hora agendada com sucesso");
                }
                else
                {
                    MessageBox.Show("ERRO...Não foi possível agendar este horário");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            // Não esquecer de usar o DR para recuperar 
            // String de pesquisa
            string pesquisa = "select * from tb_Agendamento_11 where agendamento = @agendamento";
            SqlCommand cmd = new SqlCommand(pesquisa, conexao);
            cmd.Parameters.AddWithValue("@agendamento", dateTimePicker1.Text);

            // Atenção limpar os campos antes de executar o comando
            txtH1.Clear();
            txtH2.Clear();
            txtH3.Clear();
            txtH4.Clear();
            txtH5.Clear();

            try
            {
                conexao.Open();
                // Recuperando os valores do banco
                DR = cmd.ExecuteReader();
                // Se existir dados
                if (DR.Read())
                {
                    // Preencher os campos
                    txtH1.Text = DR.GetValue(1).ToString();
                    txtH2.Text = DR.GetValue(2).ToString();
                    txtH3.Text = DR.GetValue(3).ToString();
                    txtH4.Text = DR.GetValue(4).ToString();
                    txtH5.Text = DR.GetValue(5).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
