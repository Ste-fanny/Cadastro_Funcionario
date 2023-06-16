namespace Cadastro_Funcionario
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
            tx_matricula = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tx_nome = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tx_cpf = new MaskedTextBox();
            tx_funcao = new ComboBox();
            tx_salario = new TextBox();
            cancelar = new Button();
            cadastrar = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // tx_matricula
            // 
            tx_matricula.BorderStyle = BorderStyle.None;
            tx_matricula.Cursor = Cursors.PanNW;
            tx_matricula.Location = new Point(120, 186);
            tx_matricula.Name = "tx_matricula";
            tx_matricula.Size = new Size(129, 14);
            tx_matricula.TabIndex = 0;
            tx_matricula.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(205, 45);
            label1.Name = "label1";
            label1.Size = new Size(277, 36);
            label1.TabIndex = 1;
            label1.Text = "Cadastro De Funcionario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 183);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 2;
            label2.Text = "Matrícula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 123);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 3;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(338, 243);
            label4.Name = "label4";
            label4.Size = new Size(64, 19);
            label4.TabIndex = 4;
            label4.Text = "Função";
            // 
            // tx_nome
            // 
            tx_nome.BorderStyle = BorderStyle.None;
            tx_nome.Cursor = Cursors.PanNW;
            tx_nome.Location = new Point(100, 126);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(442, 14);
            tx_nome.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(338, 186);
            label5.Name = "label5";
            label5.Size = new Size(39, 19);
            label5.TabIndex = 6;
            label5.Text = "CPF";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 243);
            label6.Name = "label6";
            label6.Size = new Size(62, 19);
            label6.TabIndex = 7;
            label6.Text = "Salário";
            // 
            // tx_cpf
            // 
            tx_cpf.BorderStyle = BorderStyle.None;
            tx_cpf.Location = new Point(383, 191);
            tx_cpf.Mask = "000,000,000-00";
            tx_cpf.Name = "tx_cpf";
            tx_cpf.Size = new Size(99, 14);
            tx_cpf.TabIndex = 8;
            // 
            // tx_funcao
            // 
            tx_funcao.DropDownStyle = ComboBoxStyle.DropDownList;
            tx_funcao.FormattingEnabled = true;
            tx_funcao.Items.AddRange(new object[] { "Médico", "Técnico Em Informática", "Administrador " });
            tx_funcao.Location = new Point(408, 239);
            tx_funcao.Name = "tx_funcao";
            tx_funcao.Size = new Size(119, 23);
            tx_funcao.TabIndex = 9;
            tx_funcao.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tx_salario
            // 
            tx_salario.BorderStyle = BorderStyle.None;
            tx_salario.Cursor = Cursors.PanNW;
            tx_salario.Location = new Point(100, 248);
            tx_salario.Name = "tx_salario";
            tx_salario.Size = new Size(97, 14);
            tx_salario.TabIndex = 10;
            tx_salario.TextChanged += textBox3_TextChanged;
            // 
            // cancelar
            // 
            cancelar.Font = new Font("Source Serif Pro", 9F, FontStyle.Italic, GraphicsUnit.Point);
            cancelar.Location = new Point(126, 415);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(93, 23);
            cancelar.TabIndex = 12;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            // 
            // cadastrar
            // 
            cadastrar.Font = new Font("Source Serif Pro", 9F, FontStyle.Italic, GraphicsUnit.Point);
            cadastrar.Location = new Point(474, 415);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(93, 23);
            cadastrar.TabIndex = 13;
            cadastrar.Text = "Cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(33, 307);
            label7.Name = "label7";
            label7.Size = new Size(104, 19);
            label7.TabIndex = 14;
            label7.Text = "Salário Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(319, 307);
            label8.Name = "label8";
            label8.Size = new Size(48, 19);
            label8.TabIndex = 15;
            label8.Text = "JRPF";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(143, 311);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 16;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(373, 310);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 17;
            label10.Text = "label10";
            label10.Click += label10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(735, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cadastrar);
            Controls.Add(cancelar);
            Controls.Add(tx_salario);
            Controls.Add(tx_funcao);
            Controls.Add(tx_cpf);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tx_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tx_matricula);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_matricula;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tx_nome;
        private Label label5;
        private Label label6;
        private MaskedTextBox tx_cpf;
        private ComboBox tx_funcao;
        private TextBox tx_salario;
        private Button cancelar;
        private Button cadastrar;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}