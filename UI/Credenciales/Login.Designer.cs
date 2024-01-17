namespace WCRUD_IL29.UI.Credenciales
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TextUserName = new System.Windows.Forms.Label();
            this.TextContraseña = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.ContraseñaText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgLogin = new System.Windows.Forms.PictureBox();
            this.TextPrincipal = new System.Windows.Forms.Label();
            this.BttIngresar = new System.Windows.Forms.Button();
            this.BttRegistrar = new System.Windows.Forms.Button();
            this.TextSecundario = new System.Windows.Forms.Label();
            this.progressVerificacion = new System.Windows.Forms.ProgressBar();
            this.StatusBar = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // TextUserName
            // 
            this.TextUserName.AutoSize = true;
            this.TextUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUserName.Location = new System.Drawing.Point(217, 67);
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Size = new System.Drawing.Size(82, 19);
            this.TextUserName.TabIndex = 2;
            this.TextUserName.Text = "Username:";
            // 
            // TextContraseña
            // 
            this.TextContraseña.AutoSize = true;
            this.TextContraseña.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextContraseña.Location = new System.Drawing.Point(208, 98);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(91, 19);
            this.TextContraseña.TabIndex = 3;
            this.TextContraseña.Text = "Contraseña:";
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(305, 68);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(156, 20);
            this.UserNameText.TabIndex = 4;
            // 
            // ContraseñaText
            // 
            this.ContraseñaText.Location = new System.Drawing.Point(305, 99);
            this.ContraseñaText.Name = "ContraseñaText";
            this.ContraseñaText.Size = new System.Drawing.Size(156, 20);
            this.ContraseñaText.TabIndex = 5;
            this.ContraseñaText.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.ImgLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 248);
            this.panel1.TabIndex = 9;
            // 
            // ImgLogin
            // 
            this.ImgLogin.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogin.Image")));
            this.ImgLogin.Location = new System.Drawing.Point(-51, 0);
            this.ImgLogin.Name = "ImgLogin";
            this.ImgLogin.Size = new System.Drawing.Size(253, 247);
            this.ImgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogin.TabIndex = 0;
            this.ImgLogin.TabStop = false;
            // 
            // TextPrincipal
            // 
            this.TextPrincipal.AutoSize = true;
            this.TextPrincipal.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPrincipal.ForeColor = System.Drawing.Color.Black;
            this.TextPrincipal.Location = new System.Drawing.Point(200, 9);
            this.TextPrincipal.Name = "TextPrincipal";
            this.TextPrincipal.Size = new System.Drawing.Size(271, 45);
            this.TextPrincipal.TabIndex = 0;
            this.TextPrincipal.Text = "LOGIN USER";
            // 
            // BttIngresar
            // 
            this.BttIngresar.Location = new System.Drawing.Point(305, 135);
            this.BttIngresar.Name = "BttIngresar";
            this.BttIngresar.Size = new System.Drawing.Size(90, 24);
            this.BttIngresar.TabIndex = 10;
            this.BttIngresar.Text = "Ingresar";
            this.BttIngresar.UseVisualStyleBackColor = true;
            this.BttIngresar.Click += new System.EventHandler(this.BttIngresar_Click);
            // 
            // BttRegistrar
            // 
            this.BttRegistrar.Location = new System.Drawing.Point(454, 206);
            this.BttRegistrar.Name = "BttRegistrar";
            this.BttRegistrar.Size = new System.Drawing.Size(90, 35);
            this.BttRegistrar.TabIndex = 11;
            this.BttRegistrar.Text = "Registar";
            this.BttRegistrar.UseVisualStyleBackColor = true;
            this.BttRegistrar.Click += new System.EventHandler(this.BttRegistrar_Click);
            // 
            // TextSecundario
            // 
            this.TextSecundario.AutoSize = true;
            this.TextSecundario.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSecundario.Location = new System.Drawing.Point(160, 216);
            this.TextSecundario.Name = "TextSecundario";
            this.TextSecundario.Size = new System.Drawing.Size(294, 15);
            this.TextSecundario.TabIndex = 12;
            this.TextSecundario.Text = "Si no cuenta con credenciales haga clik en registrar.";
            // 
            // progressVerificacion
            // 
            this.progressVerificacion.Location = new System.Drawing.Point(215, 177);
            this.progressVerificacion.Name = "progressVerificacion";
            this.progressVerificacion.Size = new System.Drawing.Size(280, 10);
            this.progressVerificacion.TabIndex = 13;
            // 
            // StatusBar
            // 
            this.StatusBar.AutoSize = true;
            this.StatusBar.Location = new System.Drawing.Point(209, 174);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(0, 13);
            this.StatusBar.TabIndex = 14;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(218, 161);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.Text = "Status";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 248);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.progressVerificacion);
            this.Controls.Add(this.TextSecundario);
            this.Controls.Add(this.BttRegistrar);
            this.Controls.Add(this.BttIngresar);
            this.Controls.Add(this.TextPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContraseñaText);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.TextContraseña);
            this.Controls.Add(this.TextUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextUserName;
        private System.Windows.Forms.Label TextContraseña;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.TextBox ContraseñaText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TextPrincipal;
        private System.Windows.Forms.PictureBox ImgLogin;
        private System.Windows.Forms.Button BttIngresar;
        private System.Windows.Forms.Button BttRegistrar;
        private System.Windows.Forms.Label TextSecundario;
        private System.Windows.Forms.ProgressBar progressVerificacion;
        private System.Windows.Forms.Label StatusBar;
        private System.Windows.Forms.Label statusLabel;
    }
}