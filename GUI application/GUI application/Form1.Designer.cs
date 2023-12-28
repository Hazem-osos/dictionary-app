namespace GUI_application
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnadd = new Button();
            btndelete = new Button();
            btnsearch = new Button();
            btndfindlength = new Button();
            btnreverse = new Button();
            txtword = new TextBox();
            txtupdate = new TextBox();
            btnupdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(261, 21);
            label1.Name = "label1";
            label1.Size = new Size(154, 38);
            label1.TabIndex = 0;
            label1.Text = "Dictionary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 144);
            label2.Name = "label2";
            label2.Size = new Size(73, 31);
            label2.TabIndex = 1;
            label2.Text = "Word";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 197);
            label3.Name = "label3";
            label3.Size = new Size(92, 31);
            label3.TabIndex = 2;
            label3.Text = "Update";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(37, 315);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 29);
            btnadd.TabIndex = 3;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(251, 315);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 5;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(362, 315);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(94, 29);
            btnsearch.TabIndex = 6;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // btndfindlength
            // 
            btndfindlength.Location = new Point(462, 315);
            btndfindlength.Name = "btndfindlength";
            btndfindlength.Size = new Size(94, 29);
            btndfindlength.TabIndex = 7;
            btndfindlength.Text = "Find Length";
            btndfindlength.UseVisualStyleBackColor = true;
            btndfindlength.Click += btndfindlength_Click;
            // 
            // btnreverse
            // 
            btnreverse.Location = new Point(571, 315);
            btnreverse.Name = "btnreverse";
            btnreverse.Size = new Size(94, 29);
            btnreverse.TabIndex = 8;
            btnreverse.Text = "Reverse";
            btnreverse.UseVisualStyleBackColor = true;
            btnreverse.Click += btnreverse_Click;
            // 
            // txtword
            // 
            txtword.Location = new Point(178, 144);
            txtword.Name = "txtword";
            txtword.Size = new Size(459, 27);
            txtword.TabIndex = 9;
            // 
            // txtupdate
            // 
            txtupdate.Location = new Point(178, 190);
            txtupdate.Name = "txtupdate";
            txtupdate.Size = new Size(459, 27);
            txtupdate.TabIndex = 10;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(151, 315);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 29);
            btnupdate.TabIndex = 11;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(677, 380);
            Controls.Add(btnupdate);
            Controls.Add(txtupdate);
            Controls.Add(txtword);
            Controls.Add(btnreverse);
            Controls.Add(btndfindlength);
            Controls.Add(btnsearch);
            Controls.Add(btndelete);
            Controls.Add(btnadd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "My Dictionary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnadd;
        private Button btndelete;
        private Button btnsearch;
        private Button btndfindlength;
        private Button btnreverse;
        private TextBox txtword;
        private TextBox txtupdate;
        private Button btnupdate;
    }
}