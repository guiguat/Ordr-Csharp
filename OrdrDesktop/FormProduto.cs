using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdrDesktop
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private async void FormProduto_Load(object sender, EventArgs e)
        {
            await getProdutos();
        }
        private async Task getProdutos()
        {
            try
            {
                var relatorios = await ProdutoProcessor.getProdutos();
                DataTable dt = new DataTable();
                dt.Columns.Add("Cod");
                dt.Columns.Add("Nome");
                dt.Columns.Add("Preço");
                dt.Columns.Add("Estoque");
                dt.Columns.Add("Tipo");
                foreach (var relatorio in relatorios)
                {
                    dt.Rows.Add(new object[] {
                       relatorio.Id,
                       relatorio.Nome,
                       relatorio.Preco,
                       relatorio.Estoque,
                       relatorio.Tipo
                    });

                }
                dgvProdutos.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Nao foi possible carregar recursos, favor checar a conexao com o servidor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            await getProdutos();
        }
    }
}
