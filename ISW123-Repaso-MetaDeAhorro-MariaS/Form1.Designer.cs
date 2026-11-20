namespace ISW123_Repaso_MetaDeAhorro_MariaS
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
            lblMeta = new Label();
            lblAhorroAlMes = new Label();
            nudAhorro = new NumericUpDown();
            btnCalcular = new Button();
            lstSalida = new ListBox();
            nudMeta = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudAhorro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMeta).BeginInit();
            SuspendLayout();
            // 
            // lblMeta
            // 
            lblMeta.AutoSize = true;
            lblMeta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblMeta.Location = new Point(49, 122);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(45, 20);
            lblMeta.TabIndex = 0;
            lblMeta.Text = "Meta";
            // 
            // lblAhorroAlMes
            // 
            lblAhorroAlMes.AutoSize = true;
            lblAhorroAlMes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblAhorroAlMes.Location = new Point(49, 62);
            lblAhorroAlMes.Name = "lblAhorroAlMes";
            lblAhorroAlMes.Size = new Size(108, 20);
            lblAhorroAlMes.TabIndex = 1;
            lblAhorroAlMes.Text = "Ahorro al mes";
            // 
            // nudAhorro
            // 
            nudAhorro.Location = new Point(190, 62);
            nudAhorro.Name = "nudAhorro";
            nudAhorro.Size = new Size(120, 23);
            nudAhorro.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(383, 92);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 37);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lstSalida
            // 
            lstSalida.FormattingEnabled = true;
            lstSalida.Location = new Point(49, 222);
            lstSalida.Name = "lstSalida";
            lstSalida.Size = new Size(487, 169);
            lstSalida.TabIndex = 5;
            // 
            // nudMeta
            // 
            nudMeta.Location = new Point(190, 124);
            nudMeta.Name = "nudMeta";
            nudMeta.Size = new Size(120, 23);
            nudMeta.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 450);
            Controls.Add(nudMeta);
            Controls.Add(lstSalida);
            Controls.Add(btnCalcular);
            Controls.Add(nudAhorro);
            Controls.Add(lblAhorroAlMes);
            Controls.Add(lblMeta);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudAhorro).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMeta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMeta;
        private Label lblAhorroAlMes;
       
        private NumericUpDown nudAhorro;
        private Button btnCalcular;
        private ListBox lstSalida;
        private NumericUpDown nudMeta;
    }
}
