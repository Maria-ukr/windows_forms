using System;

namespace Laba_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Laba - 15";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                box_show.Text = string.Empty;
                type_elem.Text = string.Empty;
                numb_row.Text = string.Empty;
                return;
            }

            box_show.Text = listBox1.SelectedItem.ToString();
            count_elem.Text = box_show.TextLength.ToString();
            type_elem.Text = listBox1.SelectedItem.GetType().Name;
            numb_row.Text = (listBox1.SelectedIndex + 1).ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string text = box_show.Text;
            object itemToAdd = int.TryParse(text, out int treadyText) ? (object)treadyText : text;
            if(!int.TryParse(box_index.Text, out int index_add))
            {
                listBox1.Items.Add(itemToAdd);
            }
            else if (index_add < 0)
            {
                listBox1.Items.Insert(0, itemToAdd);
            } else if(index_add <= listBox1.Items.Count)
            {
                listBox1.Items.Insert(index_add, itemToAdd);
            } else
            {
                listBox1.Items.Add(itemToAdd);
            }
            box_show.Clear();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            string text = box_show.Text;
            int exists = -1;

            if (int.TryParse(text.Trim(), out int parse_numb))
            {
                exists = listBox1.Items.IndexOf(parse_numb);
            }

            if(exists < 0)
            {
                listBox1.Items.IndexOf(text);
            }

            if (exists >= 0)
            {
                listBox1.Items.RemoveAt(exists);
                box_show.Clear();
            }
            MessageBox.Show(
                exists >= 0 ? "The row was removed." : "There is no such row.",
                caption: "Delete row");
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string text = box_show.Text.ToString();
            int exists = -1;
            if(int.TryParse(text, out int parse_numb))
            {
                exists = listBox1.Items.IndexOf(parse_numb);
            }

            if(exists < 0)
            {
                listBox1.Items.IndexOf(text);
            }
            MessageBox.Show(
                exists >= 0 ? $"The sentence is exist in {exists + 1} row under {exists} index." : "There is no such row.",
                caption: "Search row");
        }

        private void clear_list_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            box_show.Clear();
        }
    }
}
