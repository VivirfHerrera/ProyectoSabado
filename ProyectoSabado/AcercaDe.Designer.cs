namespace ProyectoSabado
{
    partial class AcercaDe
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
            this.txtInformación = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInformación
            // 
            this.txtInformación.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformación.Location = new System.Drawing.Point(123, 120);
            this.txtInformación.Margin = new System.Windows.Forms.Padding(6);
            this.txtInformación.Multiline = true;
            this.txtInformación.Name = "txtInformación";
            this.txtInformación.ReadOnly = true;
            this.txtInformación.Size = new System.Drawing.Size(540, 122);
            this.txtInformación.TabIndex = 1;
            this.txtInformación.Text = "Nombres de los que se conectaron ";
            this.txtInformación.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInformación.TextChanged += new System.EventHandler(this.txtInformación_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(347, 349);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 39);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtv
            // 
            this.txtv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtv.Location = new System.Drawing.Point(173, 252);
            this.txtv.Name = "txtv";
            this.txtv.Size = new System.Drawing.Size(225, 32);
            this.txtv.TabIndex = 3;
            this.txtv.Text = "Vivian Herrera";
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 549);
            this.ControlBox = false;
            this.Controls.Add(this.txtv);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtInformación);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(824, 588);
            this.MinimumSize = new System.Drawing.Size(824, 588);
            this.Name = "AcercaDe";
            this.Text = "Acerca De";
            this.Load += new System.EventHandler(this.AcercaDe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInformación;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtv;
    }
}