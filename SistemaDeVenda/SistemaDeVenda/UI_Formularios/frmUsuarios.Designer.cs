namespace SistemaDeVenda.UI_Formularios
{
    partial class frmIdUsuario
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
            panel1 = new Panel();
            closeUserButton = new PictureBox();
            label1 = new Label();
            lblNomeUsuario = new Label();
            txtNomeUsuario = new TextBox();
            txtSobrenomeUsuario = new TextBox();
            lblSobrenomeUsuario = new Label();
            txtEmailUsuario = new TextBox();
            lblEmailUsuario = new Label();
            txtUserUsuario = new TextBox();
            lblUserUsuario = new Label();
            txtSenhaUsuario = new TextBox();
            lblSenhaUsuario = new Label();
            txtContatoUsuario = new TextBox();
            lblContatoUsuario = new Label();
            txtEnderecoUsuario = new TextBox();
            lblEnderecoUsuario = new Label();
            lblSexoUsuario = new Label();
            cmbSexo = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtIdUsuario = new TextBox();
            dgvUsuarios = new DataGridView();
            textBox1 = new TextBox();
            label4 = new Label();
            btnCadastrarUsuario = new Button();
            btnAtualizarUsuario = new Button();
            btnDeletarUsuario = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeUserButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(closeUserButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 67);
            panel1.TabIndex = 0;
            // 
            // closeUserButton
            // 
            closeUserButton.Image = Properties.Resources.close_button;
            closeUserButton.Location = new Point(1043, 9);
            closeUserButton.Name = "closeUserButton";
            closeUserButton.Size = new Size(47, 46);
            closeUserButton.TabIndex = 1;
            closeUserButton.TabStop = false;
            closeUserButton.Click += closeUserButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 18);
            label1.Name = "label1";
            label1.Size = new Size(245, 29);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Usuários";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario.Location = new Point(32, 136);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(62, 24);
            lblNomeUsuario.TabIndex = 1;
            lblNomeUsuario.Text = "Nome";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(155, 137);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(208, 23);
            txtNomeUsuario.TabIndex = 2;
            // 
            // txtSobrenomeUsuario
            // 
            txtSobrenomeUsuario.Location = new Point(155, 169);
            txtSobrenomeUsuario.Name = "txtSobrenomeUsuario";
            txtSobrenomeUsuario.Size = new Size(208, 23);
            txtSobrenomeUsuario.TabIndex = 4;
            // 
            // lblSobrenomeUsuario
            // 
            lblSobrenomeUsuario.AutoSize = true;
            lblSobrenomeUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSobrenomeUsuario.Location = new Point(32, 169);
            lblSobrenomeUsuario.Name = "lblSobrenomeUsuario";
            lblSobrenomeUsuario.Size = new Size(110, 24);
            lblSobrenomeUsuario.TabIndex = 3;
            lblSobrenomeUsuario.Text = "Sobrenome";
            // 
            // txtEmailUsuario
            // 
            txtEmailUsuario.Location = new Point(155, 199);
            txtEmailUsuario.Name = "txtEmailUsuario";
            txtEmailUsuario.Size = new Size(208, 23);
            txtEmailUsuario.TabIndex = 6;
            // 
            // lblEmailUsuario
            // 
            lblEmailUsuario.AutoSize = true;
            lblEmailUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailUsuario.Location = new Point(32, 199);
            lblEmailUsuario.Name = "lblEmailUsuario";
            lblEmailUsuario.Size = new Size(57, 24);
            lblEmailUsuario.TabIndex = 5;
            lblEmailUsuario.Text = "Email";
            // 
            // txtUserUsuario
            // 
            txtUserUsuario.Location = new Point(155, 230);
            txtUserUsuario.Name = "txtUserUsuario";
            txtUserUsuario.Size = new Size(208, 23);
            txtUserUsuario.TabIndex = 8;
            // 
            // lblUserUsuario
            // 
            lblUserUsuario.AutoSize = true;
            lblUserUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserUsuario.Location = new Point(32, 230);
            lblUserUsuario.Name = "lblUserUsuario";
            lblUserUsuario.Size = new Size(74, 24);
            lblUserUsuario.TabIndex = 7;
            lblUserUsuario.Text = "Usuário";
            // 
            // txtSenhaUsuario
            // 
            txtSenhaUsuario.Location = new Point(155, 262);
            txtSenhaUsuario.Name = "txtSenhaUsuario";
            txtSenhaUsuario.Size = new Size(208, 23);
            txtSenhaUsuario.TabIndex = 10;
            // 
            // lblSenhaUsuario
            // 
            lblSenhaUsuario.AutoSize = true;
            lblSenhaUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenhaUsuario.Location = new Point(30, 262);
            lblSenhaUsuario.Name = "lblSenhaUsuario";
            lblSenhaUsuario.Size = new Size(65, 24);
            lblSenhaUsuario.TabIndex = 9;
            lblSenhaUsuario.Text = "Senha";
            // 
            // txtContatoUsuario
            // 
            txtContatoUsuario.Location = new Point(155, 294);
            txtContatoUsuario.Name = "txtContatoUsuario";
            txtContatoUsuario.Size = new Size(208, 23);
            txtContatoUsuario.TabIndex = 12;
            // 
            // lblContatoUsuario
            // 
            lblContatoUsuario.AutoSize = true;
            lblContatoUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContatoUsuario.Location = new Point(30, 293);
            lblContatoUsuario.Name = "lblContatoUsuario";
            lblContatoUsuario.Size = new Size(74, 24);
            lblContatoUsuario.TabIndex = 11;
            lblContatoUsuario.Text = "Contato";
            // 
            // txtEnderecoUsuario
            // 
            txtEnderecoUsuario.Location = new Point(155, 327);
            txtEnderecoUsuario.Multiline = true;
            txtEnderecoUsuario.Name = "txtEnderecoUsuario";
            txtEnderecoUsuario.Size = new Size(208, 114);
            txtEnderecoUsuario.TabIndex = 14;
            // 
            // lblEnderecoUsuario
            // 
            lblEnderecoUsuario.AutoSize = true;
            lblEnderecoUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnderecoUsuario.Location = new Point(32, 337);
            lblEnderecoUsuario.Name = "lblEnderecoUsuario";
            lblEnderecoUsuario.Size = new Size(94, 24);
            lblEnderecoUsuario.TabIndex = 13;
            lblEnderecoUsuario.Text = "Endereco";
            lblEnderecoUsuario.Click += label6_Click;
            // 
            // lblSexoUsuario
            // 
            lblSexoUsuario.AutoSize = true;
            lblSexoUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSexoUsuario.Location = new Point(32, 458);
            lblSexoUsuario.Name = "lblSexoUsuario";
            lblSexoUsuario.Size = new Size(54, 24);
            lblSexoUsuario.TabIndex = 15;
            lblSexoUsuario.Text = "Sexo";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Não Especificado" });
            cmbSexo.Location = new Point(155, 458);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(208, 23);
            cmbSexo.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Usuario", "Admin" });
            comboBox1.Location = new Point(155, 494);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 23);
            comboBox1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 494);
            label2.Name = "label2";
            label2.Size = new Size(117, 24);
            label2.TabIndex = 18;
            label2.Text = "Tipo Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 103);
            label3.Name = "label3";
            label3.Size = new Size(27, 24);
            label3.TabIndex = 19;
            label3.Text = "ID";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Enabled = false;
            txtIdUsuario.Location = new Point(155, 103);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(208, 23);
            txtIdUsuario.TabIndex = 20;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(418, 103);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(663, 414);
            dgvUsuarios.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(873, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(696, 73);
            label4.Name = "label4";
            label4.Size = new Size(171, 24);
            label4.TabIndex = 23;
            label4.Text = "Pesquisar Usuários";
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.BackColor = Color.ForestGreen;
            btnCadastrarUsuario.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarUsuario.ForeColor = Color.White;
            btnCadastrarUsuario.Location = new Point(675, 533);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(132, 39);
            btnCadastrarUsuario.TabIndex = 25;
            btnCadastrarUsuario.Text = "Cadastrar";
            btnCadastrarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarUsuario
            // 
            btnAtualizarUsuario.BackColor = Color.Orange;
            btnAtualizarUsuario.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizarUsuario.ForeColor = Color.White;
            btnAtualizarUsuario.Location = new Point(813, 533);
            btnAtualizarUsuario.Name = "btnAtualizarUsuario";
            btnAtualizarUsuario.Size = new Size(132, 39);
            btnAtualizarUsuario.TabIndex = 26;
            btnAtualizarUsuario.Text = "Atualizar";
            btnAtualizarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnDeletarUsuario
            // 
            btnDeletarUsuario.BackColor = Color.Red;
            btnDeletarUsuario.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletarUsuario.ForeColor = Color.White;
            btnDeletarUsuario.Location = new Point(951, 533);
            btnDeletarUsuario.Name = "btnDeletarUsuario";
            btnDeletarUsuario.Size = new Size(132, 39);
            btnDeletarUsuario.TabIndex = 27;
            btnDeletarUsuario.Text = "Deletar";
            btnDeletarUsuario.UseVisualStyleBackColor = false;
            // 
            // frmIdUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1106, 589);
            Controls.Add(btnDeletarUsuario);
            Controls.Add(btnAtualizarUsuario);
            Controls.Add(btnCadastrarUsuario);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(dgvUsuarios);
            Controls.Add(txtIdUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(cmbSexo);
            Controls.Add(lblSexoUsuario);
            Controls.Add(txtEnderecoUsuario);
            Controls.Add(lblEnderecoUsuario);
            Controls.Add(txtContatoUsuario);
            Controls.Add(lblContatoUsuario);
            Controls.Add(txtSenhaUsuario);
            Controls.Add(lblSenhaUsuario);
            Controls.Add(txtUserUsuario);
            Controls.Add(lblUserUsuario);
            Controls.Add(txtEmailUsuario);
            Controls.Add(lblEmailUsuario);
            Controls.Add(txtSobrenomeUsuario);
            Controls.Add(lblSobrenomeUsuario);
            Controls.Add(txtNomeUsuario);
            Controls.Add(lblNomeUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmIdUsuario";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closeUserButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox closeUserButton;
        private Label lblNomeUsuario;
        private TextBox txtNomeUsuario;
        private TextBox txtSobrenomeUsuario;
        private Label lblSobrenomeUsuario;
        private TextBox txtEmailUsuario;
        private Label lblEmailUsuario;
        private TextBox txtUserUsuario;
        private Label lblUserUsuario;
        private TextBox txtSenhaUsuario;
        private Label lblSenhaUsuario;
        private TextBox txtContatoUsuario;
        private Label lblContatoUsuario;
        private TextBox txtEnderecoUsuario;
        private Label lblEnderecoUsuario;
        private Label lblSexoUsuario;
        private ComboBox cmbSexo;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox txtIdUsuario;
        private DataGridView dgvUsuarios;
        private TextBox textBox1;
        private Label label4;
        private Button btnCadastrarUsuario;
        private Button btnAtualizarUsuario;
        private Button btnDeletarUsuario;
    }
}