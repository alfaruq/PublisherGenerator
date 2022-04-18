namespace PublisherGenerator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLowerBound = new System.Windows.Forms.TextBox();
            this.txtUpperBound = new System.Windows.Forms.TextBox();
            this.cbFifo = new System.Windows.Forms.CheckBox();
            this.btnFire = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFifoQueue = new System.Windows.Forms.TextBox();
            this.txtStdQueue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lower Bound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upper Bound";
            // 
            // txtLowerBound
            // 
            this.txtLowerBound.Location = new System.Drawing.Point(116, 118);
            this.txtLowerBound.Name = "txtLowerBound";
            this.txtLowerBound.Size = new System.Drawing.Size(100, 20);
            this.txtLowerBound.TabIndex = 2;
            this.txtLowerBound.Text = "1";
            // 
            // txtUpperBound
            // 
            this.txtUpperBound.Location = new System.Drawing.Point(517, 118);
            this.txtUpperBound.Name = "txtUpperBound";
            this.txtUpperBound.Size = new System.Drawing.Size(100, 20);
            this.txtUpperBound.TabIndex = 3;
            this.txtUpperBound.Text = "1000";
            // 
            // cbFifo
            // 
            this.cbFifo.AutoSize = true;
            this.cbFifo.Location = new System.Drawing.Point(25, 151);
            this.cbFifo.Name = "cbFifo";
            this.cbFifo.Size = new System.Drawing.Size(49, 17);
            this.cbFifo.TabIndex = 4;
            this.cbFifo.Text = "FIFO";
            this.cbFifo.UseVisualStyleBackColor = true;
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(542, 147);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 5;
            this.btnFire.Text = "Fire!";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFifoQueue);
            this.groupBox1.Controls.Add(this.txtStdQueue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // txtFifoQueue
            // 
            this.txtFifoQueue.Location = new System.Drawing.Point(128, 60);
            this.txtFifoQueue.Name = "txtFifoQueue";
            this.txtFifoQueue.Size = new System.Drawing.Size(477, 20);
            this.txtFifoQueue.TabIndex = 3;
            // 
            // txtStdQueue
            // 
            this.txtStdQueue.Location = new System.Drawing.Point(128, 28);
            this.txtStdQueue.Name = "txtStdQueue";
            this.txtStdQueue.Size = new System.Drawing.Size(477, 20);
            this.txtStdQueue.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "FIFO Queue URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Standard Queue URL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 194);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.cbFifo);
            this.Controls.Add(this.txtUpperBound);
            this.Controls.Add(this.txtLowerBound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Publisher Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLowerBound;
        private System.Windows.Forms.TextBox txtUpperBound;
        private System.Windows.Forms.CheckBox cbFifo;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFifoQueue;
        private System.Windows.Forms.TextBox txtStdQueue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

