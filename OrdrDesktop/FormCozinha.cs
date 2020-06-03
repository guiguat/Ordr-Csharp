using System;
using OrdrDesktop.Models;
using System.Data;
using System.Windows.Forms;

namespace OrdrDesktop
{
    public partial class FormCozinha : Form
    {
        public FormCozinha()
        {
            InitializeComponent();
        }

        private async void LoadCozinha()
        {
            try
            {
                var pedidos = await CozinhaProcessor.getPedidos();
                DataTable dt = new DataTable();
                dt.Columns.Add("NUM.");
                dt.Columns.Add("PEDIDO");
                dt.Columns.Add("MESA");
                foreach (var pedido in pedidos)
                {
                    dt.Rows.Add(new object[] {
                       pedido.Id,
                       pedido.Pedidos,
                       pedido.Mesa
                    });

                }
                dgvCozinha.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Nao foi possible carregar recursos, favor checar a conexao com o servidor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCozinha_Load(object sender, EventArgs e)
        {
            LoadCozinha();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            LoadCozinha();
        }

        private async void btnDeletePedido_Click(object sender, EventArgs e)
        {
           try
            {
                var delId = int.Parse(dgvCozinha.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show($"Você deseja deletar o item de número:{delId} da lista?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        await CozinhaProcessor.deletePedido(delId);
                        LoadCozinha();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Erro ao deletar pedido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    //...
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Favor selecionar a linha que deseja excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
