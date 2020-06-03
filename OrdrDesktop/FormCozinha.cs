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
    }
}
