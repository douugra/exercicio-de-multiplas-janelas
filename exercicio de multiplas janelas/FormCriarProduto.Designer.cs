namespace exercicio_de_multiplas_janelas
{
    partial class FormCriarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxNome = new TextBox();
            inputPrecoCompra = new NumericUpDown();
            inputPrecoVenda = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxFabricante = new TextBox();
            buttonOk = new Button();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 34);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do produto";
            label1.Click += label1_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(112, 31);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 1;
            textBoxNome.TextChanged += textBox1_TextChanged;
            // 
            // inputPrecoCompra
            // 
            inputPrecoCompra.DecimalPlaces = 2;
            inputPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoCompra.Location = new Point(112, 91);
            inputPrecoCompra.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            inputPrecoCompra.Name = "inputPrecoCompra";
            inputPrecoCompra.Size = new Size(100, 23);
            inputPrecoCompra.TabIndex = 2;
            inputPrecoCompra.TextAlign = HorizontalAlignment.Right;
            inputPrecoCompra.ValueChanged += inputPrecoCompra_ValueChanged;
            // 
            // inputPrecoVenda
            // 
            inputPrecoVenda.DecimalPlaces = 2;
            inputPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoVenda.Location = new Point(112, 120);
            inputPrecoVenda.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            inputPrecoVenda.Name = "inputPrecoVenda";
            inputPrecoVenda.Size = new Size(100, 23);
            inputPrecoVenda.TabIndex = 3;
            inputPrecoVenda.TextAlign = HorizontalAlignment.Right;
            inputPrecoVenda.ValueChanged += InputPrecoVenda_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Fabricante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 0;
            label3.Text = "Preço de Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 120);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "Preço de Venda";
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(112, 60);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(100, 23);
            textBoxFabricante.TabIndex = 1;
            textBoxFabricante.TextChanged += textBox1_TextChanged;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(3, 162);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(62, 23);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(149, 162);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(63, 23);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormCriarProduto
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(236, 198);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Controls.Add(inputPrecoVenda);
            Controls.Add(inputPrecoCompra);
            Controls.Add(textBoxFabricante);
            Controls.Add(textBoxNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCriarProduto";
            Text = "FormCriarProduto";
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private NumericUpDown inputPrecoCompra;
        private NumericUpDown inputPrecoVenda;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxFabricante;
        private Button buttonOk;
        private Button buttonCancelar;
    }
}