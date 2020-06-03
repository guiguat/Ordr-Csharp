using OrdrDesktop.Models;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdrDesktop
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private async Task LoadRelatorios() { 
            try
            {
                var relatorios = await RelatorioProcessor.loadRelatorio();
                DataTable dt = new DataTable();
                dt.Columns.Add("Data");
                dt.Columns.Add("Debito");
                dt.Columns.Add("Credito");
                dt.Columns.Add("Dinheiro");
                dt.Columns.Add("Total");         
                foreach (var relatorio in relatorios)
                {
                    dt.Rows.Add(new object[] {
                       relatorio.DataHora,
                       relatorio.Debito.ToString(),
                       relatorio.Credito.ToString(),
                       relatorio.Dinheiro.ToString(),
                       relatorio.Total.ToString()
                    });

                }
                dgvRelatorios.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Nao foi possible carregar recursos, favor checar a conexao com o servidor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task OpenRelatorios()
        {
            try
            {
                var relatorios = await RelatorioProcessor.openRelatorio();
                DataTable dt = new DataTable();
                dt.Columns.Add("Data");
                dt.Columns.Add("Debito");
                dt.Columns.Add("Credito");
                dt.Columns.Add("Dinheiro");
                dt.Columns.Add("Total");
                foreach (var relatorio in relatorios)
                {
                    dt.Rows.Add(new object[] {
                   relatorio.DataHora,
                   relatorio.Debito.ToString(),
                   relatorio.Credito.ToString(),
                   relatorio.Dinheiro.ToString(),
                   relatorio.Total.ToString()
                });

                }
                dgvRelatorios.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Nao foi possible carregar recursos, favor checar a conexao com o servidor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            LoadRelatorios();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadRelatorios();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show( "Nao foi possible carregar recursos, favor checar a conexao com o servidor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnOpenRelatorio_Click(object sender, EventArgs e)
        {
            await OpenRelatorios();
        }
    }
}
