namespace WinFormsApp1
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.typeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(52, 131);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(199, 131);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(75, 23);
            this.displayBtn.TabIndex = 1;
            this.displayBtn.Text = "Display info";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(119, 276);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(141, 22);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 23);
            this.nameTxt.TabIndex = 3;
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(141, 80);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(100, 23);
            this.ageTxt.TabIndex = 4;
            // 
            // typeTxt
            // 
            this.typeTxt.Location = new System.Drawing.Point(141, 51);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(100, 23);
            this.typeTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type:";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(104, 83);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(31, 15);
            this.ageLbl.TabIndex = 8;
            this.ageLbl.Text = "Age:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(24, 161);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 109);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 311);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeTxt);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.submitBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button submitBtn;
        private Button displayBtn;
        private Button clearBtn;
        private TextBox nameTxt;
        private TextBox ageTxt;
        private TextBox typeTxt;
        private Label label1;
        private Label label2;
        private Label ageLbl;
        private ListBox listBox1;
    }
}