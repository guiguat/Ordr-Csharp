using OrdrDesktop.models;
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
    public partial class FormRelatorio : Form
    {
        private List<RelatorioItemModel> relatorioData;
        public FormRelatorio()
        {
            InitializeComponent();

        }

        private async Task LoadRelatorios()
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

        private async Task OpenRelatorios()
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
        private async void FormRelatorio_Load(object sender, EventArgs e)
        {        
            await LoadRelatorios();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadRelatorios();
        }

        private async void btnOpenRelatorio_Click(object sender, EventArgs e)
        {
            await OpenRelatorios();
        }
    }
}
