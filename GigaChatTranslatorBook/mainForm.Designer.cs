namespace GigaChatTranslatorBook
{
    partial class mainForm
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
            lb_about_book = new Label();
            tb_file_name = new TextBox();
            tb_file_type = new TextBox();
            tb_file_path = new TextBox();
            btn_open = new Button();
            SuspendLayout();
            // 
            // lb_about_book
            // 
            lb_about_book.AutoSize = true;
            lb_about_book.Font = new Font("Segoe UI", 16F);
            lb_about_book.Location = new Point(35, 31);
            lb_about_book.Name = "lb_about_book";
            lb_about_book.Size = new Size(244, 30);
            lb_about_book.TabIndex = 0;
            lb_about_book.Text = "Information about Book";
            // 
            // tb_file_name
            // 
            tb_file_name.Font = new Font("Segoe UI", 12F);
            tb_file_name.Location = new Point(35, 75);
            tb_file_name.Name = "tb_file_name";
            tb_file_name.ReadOnly = true;
            tb_file_name.Size = new Size(244, 29);
            tb_file_name.TabIndex = 1;
            // 
            // tb_file_type
            // 
            tb_file_type.Font = new Font("Segoe UI", 12F);
            tb_file_type.Location = new Point(35, 115);
            tb_file_type.Name = "tb_file_type";
            tb_file_type.ReadOnly = true;
            tb_file_type.Size = new Size(244, 29);
            tb_file_type.TabIndex = 2;
            // 
            // tb_file_path
            // 
            tb_file_path.Font = new Font("Segoe UI", 12F);
            tb_file_path.Location = new Point(35, 159);
            tb_file_path.Name = "tb_file_path";
            tb_file_path.ReadOnly = true;
            tb_file_path.Size = new Size(244, 29);
            tb_file_path.TabIndex = 3;
            // 
            // btn_open
            // 
            btn_open.Font = new Font("Segoe UI", 12F);
            btn_open.Location = new Point(385, 181);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(99, 35);
            btn_open.TabIndex = 4;
            btn_open.Text = "Open Book";
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_open_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_open);
            Controls.Add(tb_file_path);
            Controls.Add(tb_file_type);
            Controls.Add(tb_file_name);
            Controls.Add(lb_about_book);
            Name = "mainForm";
            Text = "GigaChatTranslatorBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_about_book;
        private TextBox tb_file_name;
        private TextBox tb_file_type;
        private TextBox tb_file_path;
        private Button btn_open;
    }
}
