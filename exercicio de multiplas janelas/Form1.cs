namespace exercicio_de_multiplas_janelas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormCriarProduto fcp = new FormCriarProduto();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK) 
            {
                string textoProduto = $"{fcp.nomeProduto}({fcp.nomeFabricante}) preço de compra [R$ {fcp.precoCompra}] preço de venda [R$ {fcp.precoVenda}]";
                listBox1.Items.Add(textoProduto);
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
