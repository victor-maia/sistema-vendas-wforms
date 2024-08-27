namespace SistemaDeVenda
{
    partial class frmUsuarioPainel
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
            topo = new MenuStrip();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            inventárioToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            topo.SuspendLayout();
            SuspendLayout();
            // 
            // topo
            // 
            topo.Items.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, categoriasToolStripMenuItem, inventárioToolStripMenuItem });
            topo.Location = new Point(0, 0);
            topo.Name = "topo";
            topo.Size = new Size(974, 24);
            topo.TabIndex = 2;
            topo.Text = "menuStrip2";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(66, 20);
            usuáriosToolStripMenuItem.Text = "Comprar";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(117, 20);
            categoriasToolStripMenuItem.Text = "Formulário Vendas";
            // 
            // inventárioToolStripMenuItem
            // 
            inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            inventárioToolStripMenuItem.Size = new Size(72, 20);
            inventárioToolStripMenuItem.Text = "Inventário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(714, 238);
            label3.Name = "label3";
            label3.Size = new Size(79, 24);
            label3.TabIndex = 7;
            label3.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.75F);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(181, 264);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 6;
            label2.Text = "Vendas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 225);
            label1.Name = "label1";
            label1.Size = new Size(369, 39);
            label1.TabIndex = 5;
            label1.Text = "Módulo Administrativo ";
            // 
            // frmUsuarioPainel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 521);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(topo);
            Name = "frmUsuarioPainel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paínel de Usuários";
            WindowState = FormWindowState.Maximized;
            topo.ResumeLayout(false);
            topo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip topo;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem inventárioToolStripMenuItem;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}