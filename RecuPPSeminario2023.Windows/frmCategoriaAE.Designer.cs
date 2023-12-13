namespace RecuPPSeminario2023.Windows
{
    partial class frmCategoriaAE
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
            components = new System.ComponentModel.Container();
            btnOk = new Button();
            btnCancelar = new Button();
            NombrecATEGORIA = new Label();
            textNombreCategoria = new TextBox();
            textDescripcion = new TextBox();
            dESCRIPCION = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(131, 212);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(316, 212);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // NombrecATEGORIA
            // 
            NombrecATEGORIA.AutoSize = true;
            NombrecATEGORIA.Location = new Point(78, 52);
            NombrecATEGORIA.Name = "NombrecATEGORIA";
            NombrecATEGORIA.Size = new Size(51, 15);
            NombrecATEGORIA.TabIndex = 2;
            NombrecATEGORIA.Text = "Nombre";
            // 
            // textNombreCategoria
            // 
            textNombreCategoria.Location = new Point(172, 49);
            textNombreCategoria.Name = "textNombreCategoria";
            textNombreCategoria.Size = new Size(172, 23);
            textNombreCategoria.TabIndex = 3;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(172, 113);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(179, 23);
            textDescripcion.TabIndex = 5;
            // 
            // dESCRIPCION
            // 
            dESCRIPCION.AutoSize = true;
            dESCRIPCION.Location = new Point(78, 114);
            dESCRIPCION.Name = "dESCRIPCION";
            dESCRIPCION.Size = new Size(69, 15);
            dESCRIPCION.TabIndex = 4;
            dESCRIPCION.Text = "Descripcion";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmCategoriaAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 271);
            ControlBox = false;
            Controls.Add(textDescripcion);
            Controls.Add(dESCRIPCION);
            Controls.Add(textNombreCategoria);
            Controls.Add(NombrecATEGORIA);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Name = "frmCategoriaAE";
            Text = "frmCategoriaAE";
            Load += frmCategoriaAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancelar;
        private Label NombrecATEGORIA;
        private TextBox textNombreCategoria;
        private TextBox textDescripcion;
        private Label dESCRIPCION;
        private ErrorProvider errorProvider1;
    }
}