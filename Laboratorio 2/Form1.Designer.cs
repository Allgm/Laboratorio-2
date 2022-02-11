namespace Laboratorio_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páginaSiguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páginaAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1386, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navegarToolStripMenuItem
            // 
            this.navegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúPrincipalToolStripMenuItem,
            this.páginaSiguienteToolStripMenuItem,
            this.páginaAnteriorToolStripMenuItem});
            this.navegarToolStripMenuItem.Name = "navegarToolStripMenuItem";
            this.navegarToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.navegarToolStripMenuItem.Text = "Navegar";
            // 
            // menúPrincipalToolStripMenuItem
            // 
            this.menúPrincipalToolStripMenuItem.Name = "menúPrincipalToolStripMenuItem";
            this.menúPrincipalToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.menúPrincipalToolStripMenuItem.Text = "Menú principal";
            this.menúPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menúPrincipalToolStripMenuItem_Click);
            // 
            // páginaSiguienteToolStripMenuItem
            // 
            this.páginaSiguienteToolStripMenuItem.Name = "páginaSiguienteToolStripMenuItem";
            this.páginaSiguienteToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.páginaSiguienteToolStripMenuItem.Text = "Página siguiente";
            this.páginaSiguienteToolStripMenuItem.Click += new System.EventHandler(this.páginaSiguienteToolStripMenuItem_Click);
            // 
            // páginaAnteriorToolStripMenuItem
            // 
            this.páginaAnteriorToolStripMenuItem.Name = "páginaAnteriorToolStripMenuItem";
            this.páginaAnteriorToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.páginaAnteriorToolStripMenuItem.Text = "Página anterior";
            this.páginaAnteriorToolStripMenuItem.Click += new System.EventHandler(this.páginaAnteriorToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(64, 82);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1089, 634);
            this.webBrowser1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "www.google.com/",
            "www.facebook.com/",
            "www.mesoamericana.edu.gt/"});
            this.comboBox1.Location = new System.Drawing.Point(145, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(502, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 26);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(769, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Buscar en Google";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 775);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem páginaSiguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem páginaAnteriorToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

