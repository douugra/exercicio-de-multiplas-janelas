namespace exercicio_de_multiplas_janelas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button buttonvendas;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            dataGridView1 = new DataGridView();
            buttonclientes = new Button();
            buttonfornecedores = new Button();
            buttonprodutos = new Button();
            buttoncompras = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            buttonvendas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonvendas
            // 
            buttonvendas.Location = new Point(445, 20);
            buttonvendas.Name = "buttonvendas";
            buttonvendas.Size = new Size(96, 39);
            buttonvendas.TabIndex = 4;
            buttonvendas.Text = "Vendas";
            buttonvendas.UseVisualStyleBackColor = true;
            buttonvendas.Click += buttonvendas_Click;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackgroundImage = (Image)resources.GetObject("buttonAdicionar.BackgroundImage");
            buttonAdicionar.Location = new Point(175, 81);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(92, 20);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "𝔸𝕕𝕚𝕔𝕚𝕠𝕟𝕒𝕣";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.BackgroundImage = (Image)resources.GetObject("buttonRemover.BackgroundImage");
            buttonRemover.Location = new Point(175, 107);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(92, 20);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "ℝ𝕖𝕞𝕠𝕧𝕖𝕣";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(175, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(633, 385);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonclientes
            // 
            buttonclientes.Location = new Point(310, 20);
            buttonclientes.Name = "buttonclientes";
            buttonclientes.Size = new Size(95, 38);
            buttonclientes.TabIndex = 3;
            buttonclientes.Text = "Clientes";
            buttonclientes.UseVisualStyleBackColor = true;
            buttonclientes.Click += button1_Click;
            // 
            // buttonfornecedores
            // 
            buttonfornecedores.Location = new Point(586, 20);
            buttonfornecedores.Name = "buttonfornecedores";
            buttonfornecedores.Size = new Size(94, 39);
            buttonfornecedores.TabIndex = 5;
            buttonfornecedores.Text = "Fornecedores";
            buttonfornecedores.UseVisualStyleBackColor = true;
            buttonfornecedores.Click += buttonfornecedores_Click;
            // 
            // buttonprodutos
            // 
            buttonprodutos.Location = new Point(175, 20);
            buttonprodutos.Name = "buttonprodutos";
            buttonprodutos.Size = new Size(92, 39);
            buttonprodutos.TabIndex = 6;
            buttonprodutos.Text = "Produtos";
            buttonprodutos.UseVisualStyleBackColor = true;
            buttonprodutos.Click += buttonprodutos_Click;
            // 
            // buttoncompras
            // 
            buttoncompras.Location = new Point(712, 20);
            buttoncompras.Name = "buttoncompras";
            buttoncompras.Size = new Size(96, 39);
            buttoncompras.TabIndex = 7;
            buttoncompras.Text = "Compras";
            buttoncompras.UseVisualStyleBackColor = true;
            buttoncompras.Click += buttoncompras_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(310, 81);
            button1.Name = "button1";
            button1.Size = new Size(95, 20);
            button1.TabIndex = 0;
            button1.Text = "𝔸𝕕𝕚𝕔𝕚𝕠𝕟𝕒𝕣";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonAdicionar_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(712, 81);
            button2.Name = "button2";
            button2.Size = new Size(96, 20);
            button2.TabIndex = 0;
            button2.Text = "𝔸𝕕𝕚𝕔𝕚𝕠𝕟𝕒𝕣";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonAdicionar_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(445, 81);
            button3.Name = "button3";
            button3.Size = new Size(96, 20);
            button3.TabIndex = 0;
            button3.Text = "𝔸𝕕𝕚𝕔𝕚𝕠𝕟𝕒𝕣";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonAdicionar_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.Location = new Point(586, 81);
            button4.Name = "button4";
            button4.Size = new Size(94, 20);
            button4.TabIndex = 0;
            button4.Text = "𝔸𝕕𝕚𝕔𝕚𝕠𝕟𝕒𝕣";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonAdicionar_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.Location = new Point(445, 107);
            button6.Name = "button6";
            button6.Size = new Size(96, 20);
            button6.TabIndex = 1;
            button6.Text = "ℝ𝕖𝕞𝕠𝕧𝕖𝕣";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonRemover_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.Location = new Point(310, 107);
            button5.Name = "button5";
            button5.Size = new Size(95, 20);
            button5.TabIndex = 1;
            button5.Text = "ℝ𝕖𝕞𝕠𝕧𝕖𝕣";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonRemover_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.Location = new Point(712, 107);
            button7.Name = "button7";
            button7.Size = new Size(96, 20);
            button7.TabIndex = 1;
            button7.Text = "ℝ𝕖𝕞𝕠𝕧𝕖𝕣";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonRemover_Click;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.Location = new Point(586, 107);
            button8.Name = "button8";
            button8.Size = new Size(94, 20);
            button8.TabIndex = 1;
            button8.Text = "ℝ𝕖𝕞𝕠𝕧𝕖𝕣";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonRemover_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1015, 683);
            Controls.Add(buttoncompras);
            Controls.Add(buttonprodutos);
            Controls.Add(buttonfornecedores);
            Controls.Add(buttonvendas);
            Controls.Add(buttonclientes);
            Controls.Add(dataGridView1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(buttonRemover);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonAdicionar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionar;
        private Button buttonRemover;
        private DataGridView dataGridView1;
        private Button buttonclientes;
        private Button buttonvendas;
        private Button buttonfornecedores;
        private Button buttonprodutos;
        private Button buttoncompras;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button8;
    }
}
