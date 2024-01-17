namespace WCRUD_IL29.UI.Persona
{
    partial class Persona
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
            this.PersonadataGridView = new System.Windows.Forms.DataGridView();
            this.TextConexion = new System.Windows.Forms.Label();
            this.TextSecundarioP = new System.Windows.Forms.Label();
            this.TextAlmacenado = new System.Windows.Forms.Label();
            this.FiltrarPorPe = new System.Windows.Forms.ComboBox();
            this.FiltrarTextPersona = new System.Windows.Forms.TextBox();
            this.BuscarPeBtt = new System.Windows.Forms.Button();
            this.AddPeBtt = new System.Windows.Forms.Button();
            this.UpdatePeBtt = new System.Windows.Forms.Button();
            this.DeletePeBtt = new System.Windows.Forms.Button();
            this.TextPrincipalP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonadataGridView
            // 
            this.PersonadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonadataGridView.Location = new System.Drawing.Point(10, 105);
            this.PersonadataGridView.Name = "PersonadataGridView";
            this.PersonadataGridView.Size = new System.Drawing.Size(736, 282);
            this.PersonadataGridView.TabIndex = 0;
            // 
            // TextConexion
            // 
            this.TextConexion.AutoSize = true;
            this.TextConexion.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextConexion.Location = new System.Drawing.Point(493, 9);
            this.TextConexion.Name = "TextConexion";
            this.TextConexion.Size = new System.Drawing.Size(55, 14);
            this.TextConexion.TabIndex = 1;
            this.TextConexion.Text = "Conexion:";
            // 
            // TextSecundarioP
            // 
            this.TextSecundarioP.AutoSize = true;
            this.TextSecundarioP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSecundarioP.Location = new System.Drawing.Point(12, 41);
            this.TextSecundarioP.Name = "TextSecundarioP";
            this.TextSecundarioP.Size = new System.Drawing.Size(106, 22);
            this.TextSecundarioP.TabIndex = 2;
            this.TextSecundarioP.Text = "Buscar por:";
            // 
            // TextAlmacenado
            // 
            this.TextAlmacenado.AutoSize = true;
            this.TextAlmacenado.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAlmacenado.Location = new System.Drawing.Point(285, 47);
            this.TextAlmacenado.Name = "TextAlmacenado";
            this.TextAlmacenado.Size = new System.Drawing.Size(56, 14);
            this.TextAlmacenado.TabIndex = 3;
            this.TextAlmacenado.Text = "Almacena:";
            // 
            // FiltrarPorPe
            // 
            this.FiltrarPorPe.FormattingEnabled = true;
            this.FiltrarPorPe.Items.AddRange(new object[] {
            "ID",
            "Cedula",
            "Nombre",
            "Apellidos"});
            this.FiltrarPorPe.Location = new System.Drawing.Point(124, 44);
            this.FiltrarPorPe.Name = "FiltrarPorPe";
            this.FiltrarPorPe.Size = new System.Drawing.Size(146, 21);
            this.FiltrarPorPe.TabIndex = 4;
            // 
            // FiltrarTextPersona
            // 
            this.FiltrarTextPersona.Location = new System.Drawing.Point(12, 74);
            this.FiltrarTextPersona.Name = "FiltrarTextPersona";
            this.FiltrarTextPersona.Size = new System.Drawing.Size(199, 20);
            this.FiltrarTextPersona.TabIndex = 5;
            // 
            // BuscarPeBtt
            // 
            this.BuscarPeBtt.Location = new System.Drawing.Point(229, 74);
            this.BuscarPeBtt.Name = "BuscarPeBtt";
            this.BuscarPeBtt.Size = new System.Drawing.Size(75, 23);
            this.BuscarPeBtt.TabIndex = 6;
            this.BuscarPeBtt.Text = "Buscar";
            this.BuscarPeBtt.UseVisualStyleBackColor = true;
            this.BuscarPeBtt.Click += new System.EventHandler(this.BuscarPeBtt_Click);
            // 
            // AddPeBtt
            // 
            this.AddPeBtt.Location = new System.Drawing.Point(360, 75);
            this.AddPeBtt.Name = "AddPeBtt";
            this.AddPeBtt.Size = new System.Drawing.Size(75, 23);
            this.AddPeBtt.TabIndex = 7;
            this.AddPeBtt.Text = "Agregar";
            this.AddPeBtt.UseVisualStyleBackColor = true;
            this.AddPeBtt.Click += new System.EventHandler(this.AddPeBtt_Click);
            // 
            // UpdatePeBtt
            // 
            this.UpdatePeBtt.Location = new System.Drawing.Point(441, 75);
            this.UpdatePeBtt.Name = "UpdatePeBtt";
            this.UpdatePeBtt.Size = new System.Drawing.Size(75, 23);
            this.UpdatePeBtt.TabIndex = 8;
            this.UpdatePeBtt.Text = "Actualizar";
            this.UpdatePeBtt.UseVisualStyleBackColor = true;
            this.UpdatePeBtt.Click += new System.EventHandler(this.UpdatePeBtt_Click);
            // 
            // DeletePeBtt
            // 
            this.DeletePeBtt.Location = new System.Drawing.Point(522, 75);
            this.DeletePeBtt.Name = "DeletePeBtt";
            this.DeletePeBtt.Size = new System.Drawing.Size(75, 23);
            this.DeletePeBtt.TabIndex = 9;
            this.DeletePeBtt.Text = "Eliminar";
            this.DeletePeBtt.UseVisualStyleBackColor = true;
            this.DeletePeBtt.Click += new System.EventHandler(this.DeletePeBtt_Click);
            // 
            // TextPrincipalP
            // 
            this.TextPrincipalP.AutoSize = true;
            this.TextPrincipalP.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPrincipalP.Location = new System.Drawing.Point(193, 9);
            this.TextPrincipalP.Name = "TextPrincipalP";
            this.TextPrincipalP.Size = new System.Drawing.Size(242, 31);
            this.TextPrincipalP.TabIndex = 10;
            this.TextPrincipalP.Text = "DATOS PERSONA";
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 399);
            this.Controls.Add(this.TextPrincipalP);
            this.Controls.Add(this.DeletePeBtt);
            this.Controls.Add(this.UpdatePeBtt);
            this.Controls.Add(this.AddPeBtt);
            this.Controls.Add(this.BuscarPeBtt);
            this.Controls.Add(this.FiltrarTextPersona);
            this.Controls.Add(this.FiltrarPorPe);
            this.Controls.Add(this.TextAlmacenado);
            this.Controls.Add(this.TextSecundarioP);
            this.Controls.Add(this.TextConexion);
            this.Controls.Add(this.PersonadataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Persona";
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.Persona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonadataGridView;
        private System.Windows.Forms.Label TextConexion;
        private System.Windows.Forms.Label TextSecundarioP;
        private System.Windows.Forms.Label TextAlmacenado;
        private System.Windows.Forms.ComboBox FiltrarPorPe;
        private System.Windows.Forms.TextBox FiltrarTextPersona;
        private System.Windows.Forms.Button BuscarPeBtt;
        private System.Windows.Forms.Button AddPeBtt;
        private System.Windows.Forms.Button UpdatePeBtt;
        private System.Windows.Forms.Button DeletePeBtt;
        private System.Windows.Forms.Label TextPrincipalP;
    }
}