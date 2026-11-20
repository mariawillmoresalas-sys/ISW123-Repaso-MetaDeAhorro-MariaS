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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(190, 133);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(190, 62);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(383, 92);
            button1.Name = "button1";
            button1.Size = new Size(112, 37);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(49, 222);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(487, 169);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(lblAhorroAlMes);
            Controls.Add(lblMeta);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMeta;
        private Label lblAhorroAlMes;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private ListBox listBox1;
    }
}
