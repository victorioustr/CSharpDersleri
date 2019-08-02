namespace MyTextBoxDemo
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
            this.components = new System.ComponentModel.Container();
            this.MyTextBoxDemo1 = new MyTextBoxDemo.MyTextBox();
            this.myTextBox1 = new MyTextBoxDemo.MyTextBox();
            this.myTextBox2 = new MyTextBoxDemo.MyTextBox();
            this.myTextBox3 = new MyTextBoxDemo.MyTextBox();
            this.myTextBox4 = new MyTextBoxDemo.MyTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MyTextBoxDemo1
            // 
            this.MyTextBoxDemo1.AutoTrim = true;
            this.MyTextBoxDemo1.EnterIleSiradakiKontroleGec = true;
            this.MyTextBoxDemo1.ErrorProvider = this.errorProvider1;
            this.MyTextBoxDemo1.HoverColor = System.Drawing.Color.Yellow;
            this.MyTextBoxDemo1.Location = new System.Drawing.Point(34, 30);
            this.MyTextBoxDemo1.Name = "MyTextBoxDemo1";
            this.MyTextBoxDemo1.Size = new System.Drawing.Size(248, 20);
            this.MyTextBoxDemo1.TabIndex = 0;
            this.MyTextBoxDemo1.TumunuSec = true;
            this.MyTextBoxDemo1.Zorunlu = true;
            // 
            // myTextBox1
            // 
            this.myTextBox1.AutoTrim = true;
            this.myTextBox1.EnterIleSiradakiKontroleGec = true;
            this.myTextBox1.ErrorProvider = this.errorProvider1;
            this.myTextBox1.HoverColor = System.Drawing.Color.Yellow;
            this.myTextBox1.Location = new System.Drawing.Point(34, 56);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(248, 20);
            this.myTextBox1.TabIndex = 1;
            this.myTextBox1.TumunuSec = true;
            this.myTextBox1.Zorunlu = true;
            // 
            // myTextBox2
            // 
            this.myTextBox2.AutoTrim = true;
            this.myTextBox2.EnterIleSiradakiKontroleGec = true;
            this.myTextBox2.ErrorProvider = this.errorProvider1;
            this.myTextBox2.HoverColor = System.Drawing.Color.Yellow;
            this.myTextBox2.Location = new System.Drawing.Point(34, 82);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(248, 20);
            this.myTextBox2.TabIndex = 2;
            this.myTextBox2.TumunuSec = true;
            this.myTextBox2.Zorunlu = true;
            // 
            // myTextBox3
            // 
            this.myTextBox3.AutoTrim = true;
            this.myTextBox3.EnterIleSiradakiKontroleGec = true;
            this.myTextBox3.ErrorProvider = this.errorProvider1;
            this.myTextBox3.HoverColor = System.Drawing.Color.Yellow;
            this.myTextBox3.Location = new System.Drawing.Point(34, 108);
            this.myTextBox3.Name = "myTextBox3";
            this.myTextBox3.Size = new System.Drawing.Size(248, 20);
            this.myTextBox3.TabIndex = 3;
            this.myTextBox3.TumunuSec = true;
            this.myTextBox3.Zorunlu = true;
            // 
            // myTextBox4
            // 
            this.myTextBox4.AutoTrim = true;
            this.myTextBox4.EnterIleSiradakiKontroleGec = true;
            this.myTextBox4.ErrorProvider = this.errorProvider1;
            this.myTextBox4.HoverColor = System.Drawing.Color.Yellow;
            this.myTextBox4.Location = new System.Drawing.Point(34, 134);
            this.myTextBox4.Name = "myTextBox4";
            this.myTextBox4.Size = new System.Drawing.Size(248, 20);
            this.myTextBox4.TabIndex = 4;
            this.myTextBox4.TumunuSec = true;
            this.myTextBox4.Zorunlu = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myTextBox4);
            this.Controls.Add(this.myTextBox3);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.myTextBox1);
            this.Controls.Add(this.MyTextBoxDemo1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTextBoxDemo.MyTextBox MyTextBoxDemo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MyTextBox myTextBox4;
        private MyTextBox myTextBox3;
        private MyTextBox myTextBox2;
        private MyTextBox myTextBox1;
    }
}

