namespace Library_project
{
    partial class return_book
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
            this.book_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.book_number = new System.Windows.Forms.Label();
            this.book_name = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.Cencel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Book ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book ID";
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(625, 112);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(262, 26);
            this.book_id.TabIndex = 2;
            this.book_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_id_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Book Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FloralWhite;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Student Name";
            // 
            // book_number
            // 
            this.book_number.AutoSize = true;
            this.book_number.BackColor = System.Drawing.Color.FloralWhite;
            this.book_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_number.Location = new System.Drawing.Point(619, 188);
            this.book_number.Name = "book_number";
            this.book_number.Size = new System.Drawing.Size(0, 32);
            this.book_number.TabIndex = 6;
            // 
            // book_name
            // 
            this.book_name.AutoSize = true;
            this.book_name.BackColor = System.Drawing.Color.FloralWhite;
            this.book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_name.Location = new System.Drawing.Point(619, 274);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(0, 32);
            this.book_name.TabIndex = 7;
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.BackColor = System.Drawing.Color.FloralWhite;
            this.student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.Location = new System.Drawing.Point(619, 356);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(0, 32);
            this.student_name.TabIndex = 8;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(625, 454);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(158, 50);
            this.save.TabIndex = 9;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Cencel
            // 
            this.Cencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cencel.Location = new System.Drawing.Point(403, 454);
            this.Cencel.Name = "Cencel";
            this.Cencel.Size = new System.Drawing.Size(167, 50);
            this.Cencel.TabIndex = 10;
            this.Cencel.Text = "Cancel";
            this.Cencel.UseVisualStyleBackColor = true;
            this.Cencel.Click += new System.EventHandler(this.Cencel_Click);
            // 
            // return_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1304, 646);
            this.Controls.Add(this.Cencel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.book_name);
            this.Controls.Add(this.book_number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.book_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "return_book";
            this.Text = "return_book";
            this.Load += new System.EventHandler(this.return_book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label book_number;
        private System.Windows.Forms.Label book_name;
        private System.Windows.Forms.Label student_name;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Cencel;
    }
}