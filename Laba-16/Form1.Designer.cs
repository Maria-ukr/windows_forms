namespace Laba_16
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
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            open_btn = new Button();
            save_btn = new Button();
            remove_btn = new Button();
            edit_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // open_btn
            // 
            open_btn.BackColor = SystemColors.GradientInactiveCaption;
            open_btn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            open_btn.Location = new Point(685, 25);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(90, 50);
            open_btn.TabIndex = 1;
            open_btn.Text = "Open";
            open_btn.UseVisualStyleBackColor = false;
            open_btn.Click += open_btn_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.LightGreen;
            save_btn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            save_btn.Location = new Point(685, 81);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(90, 48);
            save_btn.TabIndex = 2;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // remove_btn
            // 
            remove_btn.BackColor = Color.MistyRose;
            remove_btn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            remove_btn.Location = new Point(685, 135);
            remove_btn.Name = "remove_btn";
            remove_btn.Size = new Size(90, 44);
            remove_btn.TabIndex = 3;
            remove_btn.Text = "Remove";
            remove_btn.UseVisualStyleBackColor = false;
            remove_btn.Click += remove_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = Color.BlueViolet;
            edit_btn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            edit_btn.ForeColor = SystemColors.ControlLightLight;
            edit_btn.Location = new Point(685, 185);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(90, 47);
            edit_btn.TabIndex = 4;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += Edit_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(edit_btn);
            Controls.Add(remove_btn);
            Controls.Add(save_btn);
            Controls.Add(open_btn);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Load image";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button open_btn;
        private Button save_btn;
        private Button remove_btn;
        private Button edit_btn;
    }
}
