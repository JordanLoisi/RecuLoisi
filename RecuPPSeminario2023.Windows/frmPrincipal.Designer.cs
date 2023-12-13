namespace RecuPPSeminario2023.Windows
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            ButtonBorrar = new ToolStripButton();
            ButtonEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCerrar = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            txtCantidad = new TextBox();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, ButtonBorrar, ButtonEditar, toolStripSeparator1, btnCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageTransparentColor = Color.Magenta;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(46, 22);
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // ButtonBorrar
            // 
            ButtonBorrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ButtonBorrar.Image = (Image)resources.GetObject("ButtonBorrar.Image");
            ButtonBorrar.ImageTransparentColor = Color.Magenta;
            ButtonBorrar.Name = "ButtonBorrar";
            ButtonBorrar.Size = new Size(43, 22);
            ButtonBorrar.Text = "Borrar";
            ButtonBorrar.Click += ButtonBorrar_Click;
            // 
            // ButtonEditar
            // 
            ButtonEditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ButtonEditar.Image = (Image)resources.GetObject("ButtonEditar.Image");
            ButtonEditar.ImageTransparentColor = Color.Magenta;
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.Size = new Size(41, 22);
            ButtonEditar.Text = "Editar";
            ButtonEditar.Click += ButtonEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnCerrar
            // 
            btnCerrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.ImageTransparentColor = Color.Magenta;
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(43, 22);
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtCantidad);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 425);
            splitContainer1.SplitterDistance = 329;
            splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(800, 329);
            dataGridView1.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(206, 43);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 45);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnNuevo;
        private ToolStripButton ButtonBorrar;
        private ToolStripButton ButtonEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCerrar;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private TextBox txtCantidad;
        private Label label1;
    }
}