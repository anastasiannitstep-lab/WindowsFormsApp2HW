namespace WindowsFormsApp2HW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.fc = new System.Windows.Forms.ListBox();
            this.fo = new System.Windows.Forms.ListBox();
            this.fcb = new System.Windows.Forms.Button();
            this.fob = new System.Windows.Forms.Button();
            this.tbc = new System.Windows.Forms.TextBox();
            this.tbo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(12, 12);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(469, 292);
            this.lb1.TabIndex = 0;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 16;
            this.lb2.Location = new System.Drawing.Point(504, 12);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(626, 292);
            this.lb2.TabIndex = 1;
            // 
            // fc
            // 
            this.fc.FormattingEnabled = true;
            this.fc.ItemHeight = 16;
            this.fc.Location = new System.Drawing.Point(12, 366);
            this.fc.Name = "fc";
            this.fc.Size = new System.Drawing.Size(469, 36);
            this.fc.TabIndex = 2;
            // 
            // fo
            // 
            this.fo.FormattingEnabled = true;
            this.fo.ItemHeight = 16;
            this.fo.Location = new System.Drawing.Point(504, 366);
            this.fo.Name = "fo";
            this.fo.Size = new System.Drawing.Size(626, 36);
            this.fo.TabIndex = 3;
            // 
            // fcb
            // 
            this.fcb.Location = new System.Drawing.Point(143, 408);
            this.fcb.Name = "fcb";
            this.fcb.Size = new System.Drawing.Size(125, 30);
            this.fcb.TabIndex = 4;
            this.fcb.Text = "Find Customer";
            this.fcb.UseVisualStyleBackColor = true;
            this.fcb.Click += new System.EventHandler(this.find_Customer);
            // 
            // fob
            // 
            this.fob.AllowDrop = true;
            this.fob.Location = new System.Drawing.Point(749, 408);
            this.fob.Name = "fob";
            this.fob.Size = new System.Drawing.Size(125, 30);
            this.fob.TabIndex = 5;
            this.fob.Text = "Find Order";
            this.fob.UseVisualStyleBackColor = true;
            this.fob.Click += new System.EventHandler(this.find_Order);
            // 
            // tbc
            // 
            this.tbc.Location = new System.Drawing.Point(12, 328);
            this.tbc.Name = "tbc";
            this.tbc.Size = new System.Drawing.Size(469, 22);
            this.tbc.TabIndex = 6;
            this.tbc.Text = "Put Name";
            // 
            // tbo
            // 
            this.tbo.Location = new System.Drawing.Point(504, 328);
            this.tbo.Name = "tbo";
            this.tbo.Size = new System.Drawing.Size(626, 22);
            this.tbo.TabIndex = 7;
            this.tbo.Text = "Put CustomerId";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.tbo);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.fob);
            this.Controls.Add(this.fcb);
            this.Controls.Add(this.fo);
            this.Controls.Add(this.fc);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.ListBox fc;
        private System.Windows.Forms.ListBox fo;
        private System.Windows.Forms.Button fcb;
        private System.Windows.Forms.Button fob;
        private System.Windows.Forms.TextBox tbc;
        private System.Windows.Forms.TextBox tbo;
    }
}

