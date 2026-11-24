namespace Laba_15
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
            box_show = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            count_elem = new TextBox();
            type_elem = new TextBox();
            numb_row = new TextBox();
            del_btn = new Button();
            add_btn = new Button();
            search_btn = new Button();
            clear_list_btn = new Button();
            box_index = new TextBox();
            lebel_index = new Label();
            SuspendLayout();
            // 
            // box_show
            // 
            box_show.BackColor = Color.White;
            box_show.BorderStyle = BorderStyle.FixedSingle;
            box_show.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            box_show.Location = new Point(78, 30);
            box_show.Margin = new Padding(2);
            box_show.Name = "box_show";
            box_show.Size = new Size(510, 27);
            box_show.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "𝐎𝐮𝐫 𝐩𝐚𝐭𝐞𝐧𝐭𝐞𝐝 𝐬𝐞𝐚𝐥𝐞𝐝 𝐢𝐦𝐦𝐞𝐫𝐬𝐢𝐨𝐧 𝐜𝐨𝐨𝐥𝐢𝐧𝐠 𝐭𝐞𝐜𝐡𝐧𝐨𝐥𝐨𝐠𝐲 𝐨𝐟𝐟𝐞𝐫𝐬:", " • Fanless servers, eliminating traditional server cooling fans.", " • Zero water at server level, reducing reliance on water for server cooling.", " • Heat recovery opportunities, where infrastructure allows.", " • High-density computing, designed for modern AI workloads.", "1111111" });
            listBox1.Location = new Point(78, 116);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(647, 204);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(78, 333);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 2;
            label1.Text = "Number of letters:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(78, 365);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 3;
            label2.Text = "Type of element:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(82, 398);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 4;
            label3.Text = "Number of row:";
            // 
            // count_elem
            // 
            count_elem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            count_elem.Location = new Point(218, 326);
            count_elem.Name = "count_elem";
            count_elem.Size = new Size(125, 27);
            count_elem.TabIndex = 5;
            // 
            // type_elem
            // 
            type_elem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            type_elem.Location = new Point(218, 358);
            type_elem.Name = "type_elem";
            type_elem.Size = new Size(125, 27);
            type_elem.TabIndex = 6;
            // 
            // numb_row
            // 
            numb_row.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numb_row.Location = new Point(218, 391);
            numb_row.Name = "numb_row";
            numb_row.Size = new Size(125, 27);
            numb_row.TabIndex = 7;
            // 
            // del_btn
            // 
            del_btn.BackColor = Color.LightCoral;
            del_btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            del_btn.ForeColor = SystemColors.ActiveCaptionText;
            del_btn.Location = new Point(394, 67);
            del_btn.Name = "del_btn";
            del_btn.Size = new Size(86, 38);
            del_btn.TabIndex = 8;
            del_btn.Text = "Delete";
            del_btn.UseVisualStyleBackColor = false;
            del_btn.Click += del_btn_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.Cornsilk;
            add_btn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            add_btn.Location = new Point(218, 67);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(70, 38);
            add_btn.TabIndex = 9;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // search_btn
            // 
            search_btn.BackColor = SystemColors.InactiveBorder;
            search_btn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            search_btn.Location = new Point(310, 67);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(70, 38);
            search_btn.TabIndex = 10;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // clear_list_btn
            // 
            clear_list_btn.BackColor = Color.Honeydew;
            clear_list_btn.BackgroundImageLayout = ImageLayout.None;
            clear_list_btn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            clear_list_btn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            clear_list_btn.Location = new Point(625, 333);
            clear_list_btn.Margin = new Padding(0);
            clear_list_btn.Name = "clear_list_btn";
            clear_list_btn.Size = new Size(130, 42);
            clear_list_btn.TabIndex = 11;
            clear_list_btn.Text = "CLEAR LIST";
            clear_list_btn.UseVisualStyleBackColor = false;
            clear_list_btn.Click += clear_list_btn_Click;
            // 
            // box_index
            // 
            box_index.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            box_index.Location = new Point(114, 71);
            box_index.Name = "box_index";
            box_index.Size = new Size(37, 27);
            box_index.TabIndex = 12;
            // 
            // lebel_index
            // 
            lebel_index.AutoSize = true;
            lebel_index.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lebel_index.Location = new Point(3, 74);
            lebel_index.Name = "lebel_index";
            lebel_index.Size = new Size(105, 20);
            lebel_index.TabIndex = 13;
            lebel_index.Text = "Index for add:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lebel_index);
            Controls.Add(box_index);
            Controls.Add(clear_list_btn);
            Controls.Add(search_btn);
            Controls.Add(add_btn);
            Controls.Add(del_btn);
            Controls.Add(numb_row);
            Controls.Add(type_elem);
            Controls.Add(count_elem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(box_show);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox box_show;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox count_elem;
        private TextBox type_elem;
        private TextBox numb_row;
        private Button del_btn;
        private Button add_btn;
        private Button search_btn;
        private Button clear_list_btn;
        private TextBox box_index;
        private Label lebel_index;
    }
}
