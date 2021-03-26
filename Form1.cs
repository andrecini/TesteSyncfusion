using System;
using System.Windows.Forms;
using Syncfusion.XlsIO;

namespace TesteSyncFusion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OrderInfoCollection orderInfoCollection = new OrderInfoCollection("nomes.txt", "estados.txt");
            sfDataGrid2.DataSource = orderInfoCollection.Orders;

            ExcelCreator.CreateExcel("nomes.txt", "estados.txt");
        }
         
        private void BtnSelectFile_Click_1(object sender, EventArgs e)
        {
            //Inicializa o Explorador de Arquivos na pasta bin/Debug
            ofd1.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

            //Associa o OpenFileDialog com o botão
            DialogResult dr = ofd1.ShowDialog();
        }
    }
}
