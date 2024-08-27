namespace SistemaDeVenda
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
            topo = new MenuStrip();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            inventárioToolStripMenuItem = new ToolStripMenuItem();
            transaçãoToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            topo.SuspendLayout();
            SuspendLayout();
            // 
            // topo
            // 
            topo.Items.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, categoriasToolStripMenuItem, produtosToolStripMenuItem, inventárioToolStripMenuItem, transaçãoToolStripMenuItem });
            topo.Location = new Point(0, 0);
            topo.Name = "topo";
            topo.Size = new Size(998, 24);
            topo.TabIndex = 1;
            topo.Text = "menuStrip2";

            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(64, 20);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(75, 20);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // inventárioToolStripMenuItem
            // 
            inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            inventárioToolStripMenuItem.Size = new Size(72, 20);
            inventárioToolStripMenuItem.Text = "Inventário";
            // 
            // transaçãoToolStripMenuItem
            // 
            transaçãoToolStripMenuItem.Name = "transaçãoToolStripMenuItem";
            transaçãoToolStripMenuItem.Size = new Size(71, 20);
            transaçãoToolStripMenuItem.Text = "Transacao";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(726, 233);
            label3.Name = "label3";
            label3.Size = new Size(79, 24);
            label3.TabIndex = 10;
            label3.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.75F);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(193, 259);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 9;
            label2.Text = "Vendas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 220);
            label1.Name = "label1";
            label1.Size = new Size(369, 39);
            label1.TabIndex = 8;
            label1.Text = "Módulo Administrativo ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 511);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(topo);
            Name = "Form1";
            Text = "Painel Administrativo";
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
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem inventárioToolStripMenuItem;
        private ToolStripMenuItem transaçãoToolStripMenuItem;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
