namespace Library_project
{
    partial class add_book
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.book_Number = new System.Windows.Forms.TextBox();
            this.book_name = new System.Windows.Forms.TextBox();
            this.book_author = new System.Windows.Forms.TextBox();
            this.book_quntity = new System.Windows.Forms.TextBox();
            this.book_price = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Save_book = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(582, 96);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add New Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Book Quntity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cyan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Book Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Cyan;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(388, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date";
            // 
            // book_Number
            // 
            this.book_Number.Location = new System.Drawing.Point(655, 138);
            this.book_Number.Name = "book_Number";
            this.book_Number.Size = new System.Drawing.Size(263, 26);
            this.book_Number.TabIndex = 7;
            this.book_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_Number_KeyPress);
            // 
            // book_name
            // 
            this.book_name.Location = new System.Drawing.Point(655, 212);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(263, 26);
            this.book_name.TabIndex = 8;
            this.book_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress);
            // 
            // book_author
            // 
            this.book_author.Location = new System.Drawing.Point(655, 281);
            this.book_author.Name = "book_author";
            this.book_author.Size = new System.Drawing.Size(263, 26);
            this.book_author.TabIndex = 9;
            this.book_author.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_author_KeyPress);
            // 
            // book_quntity
            // 
            this.book_quntity.Location = new System.Drawing.Point(655, 360);
            this.book_quntity.Name = "book_quntity";
            this.book_quntity.Size = new System.Drawing.Size(263, 26);
            this.book_quntity.TabIndex = 10;
            this.book_quntity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_quntity_KeyPress);
            // 
            // book_price
            // 
            this.book_price.Location = new System.Drawing.Point(655, 430);
            this.book_price.Name = "book_price";
            this.book_price.Size = new System.Drawing.Size(263, 26);
            this.book_price.TabIndex = 11;
            this.book_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_price_KeyPress);
            // 
            // Save_book
            // 
            this.Save_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_book.Location = new System.Drawing.Point(730, 595);
            this.Save_book.Name = "Save_book";
            this.Save_book.Size = new System.Drawing.Size(134, 50);
            this.Save_book.TabIndex = 12;
            this.Save_book.Text = "Save";
            this.Save_book.UseVisualStyleBackColor = true;
            this.Save_book.Click += new System.EventHandler(this.Save_book_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(547, 595);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(134, 50);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(359, 595);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(147, 50);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(655, 506);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // add_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1159, 1050);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Save_book);
            this.Controls.Add(this.book_price);
            this.Controls.Add(this.book_quntity);
            this.Controls.Add(this.book_author);
            this.Controls.Add(this.book_name);
            this.Controls.Add(this.book_Number);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 500);
            this.Name = "add_book";
            this.Text = "Add Book Form";
            this.Load += new System.EventHandler(this.add_book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox book_Number;
        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.TextBox book_author;
        private System.Windows.Forms.TextBox book_quntity;
        private System.Windows.Forms.TextBox book_price;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Save_book;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}