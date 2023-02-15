using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace WindowsFormAgendaDeTarefas
{
    public partial class Form1 : Form
    {
      private  MySqlConnection Conexao;
      private string data_source = "datasource=localhost;username=root;password=;database=agenda";
        public Form1()
        {
            InitializeComponent();

            lst_tarefa.View = View.Details;
            lst_tarefa.LabelEdit = true;
            lst_tarefa.AllowColumnReorder = true;
            lst_tarefa.FullRowSelect = true;
            lst_tarefa.GridLines = true;

            lst_tarefa.Columns.Add("nome", 150,HorizontalAlignment.Left);
            lst_tarefa.Columns.Add("descrição", 150, HorizontalAlignment.Left);
            lst_tarefa.Columns.Add("data", 150, HorizontalAlignment.Left);


            carregar_tarefas();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                
                //criar conexão com mySql
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

         

                cmd.CommandText = "INSERT INTO dadosagenda (nome,descricao,dataTarefa,horaInicio,horaFim) " + "VALUES" + "(@nome, @descricao,@data, @horaInicio,@horaFim)";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@nome", txt_nomeTarefa.Text);
                cmd.Parameters.AddWithValue("@descricao", txt_descricao.Text);
                cmd.Parameters.AddWithValue("@data", txt_data.Text);
                cmd.Parameters.AddWithValue("@horaInicio", txt_horaInicio.Text);
                cmd.Parameters.AddWithValue("@horaFim", txt_horaFim.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Tarefa inserida com Sucesso!" ,
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro:" + ex.Number + " ocorreu:" + ex.Message,
                             "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu:" + ex.Message,
                     "Erro",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }
        private void carregar_tarefas()
        {
            try
            {

               

                //criar conexão com mySql
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;



                cmd.CommandText = "SELECT * FROM dadosagenda ORDER BY nome DESC";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@nome", txt_nomeTarefa.Text);
                cmd.Parameters.AddWithValue("@descricao", txt_descricao.Text);
                cmd.Parameters.AddWithValue("@data", txt_data.Text);
                cmd.Parameters.AddWithValue("@horaInicio", txt_horaInicio.Text);
                cmd.Parameters.AddWithValue("@horaFim", txt_horaFim.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Tarefa inserida com Sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro:" + ex.Number + " ocorreu:" + ex.Message,
                             "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu:" + ex.Message,
                     "Erro",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                //criar conexão com mySql
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;



                cmd.CommandText = "SELECT *  FROM dadosagenda   WHERE nome LIKE @q OR descricao  LIKE @q  ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@q", "%" + txt_buscar.Text + "%");


              MySqlDataReader reader = cmd.ExecuteReader();

                lst_tarefa.Items.Clear();

                while (reader.Read())
                        {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),


                    };
                   

                        lst_tarefa.Items.Add( new ListViewItem (row));
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro:" + ex.Number + " ocorreu:" + ex.Message,
                             "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu:" + ex.Message,
                     "Erro",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void lst_tarefas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_tarefa_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lst_tarefa.SelectedItems ;

            foreach (ListViewItem item in itens_selecionados)
            {
                txt_nomeTarefa.Text = item.SubItems[1].Text;
                txt_data.Text = item.SubItems[2].Text;
                txt_descricao.Text = item.SubItems[3].Text;
            }
        }
    }
}
