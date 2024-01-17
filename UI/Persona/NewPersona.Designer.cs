namespace WCRUD_IL29.UI.Persona
{
    partial class NewPersona
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
            this.TextPNP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TextCedulaNP = new System.Windows.Forms.Label();
            this.TextNombreNP = new System.Windows.Forms.Label();
            this.TextApellidoNP = new System.Windows.Forms.Label();
            this.TextEdadNP = new System.Windows.Forms.Label();
            this.TextFNNP = new System.Windows.Forms.Label();
            this.BttAgregarNP = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TextPNP
            // 
            this.TextPNP.AutoSize = true;
            this.TextPNP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPNP.Location = new System.Drawing.Point(60, 9);
            this.TextPNP.Name = "TextPNP";
            this.TextPNP.Size = new System.Drawing.Size(189, 22);
            this.TextPNP.TabIndex = 0;
            this.TextPNP.Text = "AGREGA PERSONA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 4;
            // 
            // TextCedulaNP
            // 
            this.TextCedulaNP.AutoSize = true;
            this.TextCedulaNP.Location = new System.Drawing.Point(45, 43);
            this.TextCedulaNP.Name = "TextCedulaNP";
            this.TextCedulaNP.Size = new System.Drawing.Size(46, 13);
            this.TextCedulaNP.TabIndex = 5;
            this.TextCedulaNP.Text = "Cédula: ";
            // 
            // TextNombreNP
            // 
            this.TextNombreNP.AutoSize = true;
            this.TextNombreNP.Location = new System.Drawing.Point(36, 73);
            this.TextNombreNP.Name = "TextNombreNP";
            this.TextNombreNP.Size = new System.Drawing.Size(55, 13);
            this.TextNombreNP.TabIndex = 6;
            this.TextNombreNP.Text = "Nombres: ";
            // 
            // TextApellidoNP
            // 
            this.TextApellidoNP.AutoSize = true;
            this.TextApellidoNP.Location = new System.Drawing.Point(36, 102);
            this.TextApellidoNP.Name = "TextApellidoNP";
            this.TextApellidoNP.Size = new System.Drawing.Size(52, 13);
            this.TextApellidoNP.TabIndex = 7;
            this.TextApellidoNP.Text = "Apellidos:";
            // 
            // TextEdadNP
            // 
            this.TextEdadNP.AutoSize = true;
            this.TextEdadNP.Location = new System.Drawing.Point(53, 131);
            this.TextEdadNP.Name = "TextEdadNP";
            this.TextEdadNP.Size = new System.Drawing.Size(38, 13);
            this.TextEdadNP.TabIndex = 8;
            this.TextEdadNP.Text = "Edad: ";
            // 
            // TextFNNP
            // 
            this.TextFNNP.AutoSize = true;
            this.TextFNNP.Location = new System.Drawing.Point(12, 165);
            this.TextFNNP.Name = "TextFNNP";
            this.TextFNNP.Size = new System.Drawing.Size(75, 13);
            this.TextFNNP.TabIndex = 9;
            this.TextFNNP.Text = "F. Nacimiento:";
            // 
            // BttAgregarNP
            // 
            this.BttAgregarNP.Location = new System.Drawing.Point(113, 204);
            this.BttAgregarNP.Name = "BttAgregarNP";
            this.BttAgregarNP.Size = new System.Drawing.Size(75, 23);
            this.BttAgregarNP.TabIndex = 10;
            this.BttAgregarNP.Text = "Agregar";
            this.BttAgregarNP.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // NewPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 238);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BttAgregarNP);
            this.Controls.Add(this.TextFNNP);
            this.Controls.Add(this.TextEdadNP);
            this.Controls.Add(this.TextApellidoNP);
            this.Controls.Add(this.TextNombreNP);
            this.Controls.Add(this.TextCedulaNP);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextPNP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewPersona";
            this.Text = "NewPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextPNP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label TextCedulaNP;
        private System.Windows.Forms.Label TextNombreNP;
        private System.Windows.Forms.Label TextApellidoNP;
        private System.Windows.Forms.Label TextEdadNP;
        private System.Windows.Forms.Label TextFNNP;
        private System.Windows.Forms.Button BttAgregarNP;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}