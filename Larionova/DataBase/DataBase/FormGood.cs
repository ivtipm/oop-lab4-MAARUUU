using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace DataBase
{
    public partial class FormGood : Form
    {
        Work work = new Work();
        string filename = "";

        public FormGood()
        {
            InitializeComponent();
            dataGridViewTable.Rows[0].ReadOnly = true;
            dataGridViewTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            comboBoxChoiceSort.Text = comboBoxChoiceSort.Items[0].ToString();
            InitializeTimers();
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBoxOpen, "Открыть файл");
            t.SetToolTip(pictureBoxSave, "Сохранить файл");
            t.SetToolTip(pictureBoxDelete, "Удалить данные");
            t.SetToolTip(pictureBoxAdd, "Добавить данные");
            t.SetToolTip(pictureBoxSearch, "Поиск");
            t.SetToolTip(pictureBoxSort, "Сортировка");
            panelSearchRecord.Visible = false;
            labelSave.Visible = false;
            pictureBoxPin.Visible = false;
            panel1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            открытьToolStripMenuItem_Click(открытьToolStripMenuItem, null);
        }

      

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((work.MemberProfile.Count != 0) || (filename != ""))
            {
                DialogResult dialogResult = MessageBox.Show("Уверены," +
                    "что хотите создать новый файл?", "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Text = "База данных моделей";
                    filename = "";
                    work.DeleteModel();
                    dataGridViewTable.Rows.Clear();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Stop();
                    timer2.Enabled = false;
                }
            }
        }

        private void InitializeTimers()
        {
            // таймер для автосохранения данных в файл раз в 1 минуту
            timer1.Interval = 60000;
            timer1.Tick += new EventHandler(timer1_Tick);

            // Таймер для отображения надписи, свидетельствующей о сохранении файла
            // длительностью 3 сек
            timer2.Interval = 3000;
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            work.SaveToFile(filename);
            labelAutoSave.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (labelAutoSave.Visible)
            {
                labelAutoSave.Visible = false;
            }
            else
            {
                labelSave.Visible = false;
            }
            timer2.Enabled = false;
            timer2.Stop();
        }

        private void pictureBoxSave_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(сохранитьToolStripMenuItem, null);
        }

    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((work.MemberProfile.Count == 0) || (textBoxForSearch.Text == ""))
                return;
            dataGridViewTable.ClearSelection();
            List<int> foundElements = work.SearchModel(textBoxForSearch.Text);
            if (foundElements[0] == -1)
            {
                MessageBox.Show("Ничего не удалось найти!");
                return;
            }
            dataGridViewTable.CurrentCell = dataGridViewTable[0, foundElements[0]];
            for (int i = 0; i < foundElements.Count; i++)
            {
                dataGridViewTable.Rows[foundElements[i]].Selected = true;
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string modelFullName = textBoxFullName.Text;
                string modelName = textBoxName.Text;
                ushort year = (ushort)Convert.ToInt32(textBoxYear.Text);
                byte weight = (byte)Convert.ToInt32(textBoxWeight.Text);
                byte height = (byte)Convert.ToInt32(textBoxHeight.Text);
                textBoxFullName.Text = "";
                textBoxName.Text = "";
                textBoxYear.Text = "";
                textBoxWeight.Text = "";
                textBoxHeight.Text = "";
                MemberProfile m = new MemberProfile(modelFullName, modelName, year, weight, height);
                work.AddProfile(m);
                int n = work.MemberProfile.Count;
                dataGridViewTable.Rows.Add(modelFullName, modelName, year, weight, height);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
            }
        }

        private void btnClearRow_Click(object sender, EventArgs e)
        {
            int count = dataGridViewTable.Rows.Count;
            foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
            {
                int index = row.Index;
                if (index == count - 1) return;
                work.DeleteModeleProfile(index);
                dataGridViewTable.Rows.RemoveAt(index);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            if (work.MemberProfile.Count != 0)
            {
                dataGridViewTable.Rows.Clear();
                if (comboBoxChoiceSort.SelectedIndex == 0)
                {
                    work.Sort(SortDirection.Ascending);
                }
                else
                {
                   work.Sort(SortDirection.Descending);
                }
                WriteToDataGrid();
            }
        }


        private void WriteToDataGrid()
        {
            for (int i = 0; i < work.MemberProfile.Count; i++)
            {
               MemberProfile m = (MemberProfile)work.MemberProfile[i];
                dataGridViewTable.Rows.Add(m.ModelFullname, m.ModelName, m.YearBirth, m.ModelHeight, m.ModelWeight);
            }
        }
      
        private void WriteToGrid()
        {
            for (int i = 0; i < work.MemberProfile.Count; i++)
            {
               MemberProfile m = (MemberProfile)work.MemberProfile[i];
                dataGridViewTable.Rows.Add(m.ModelFullname, m.ModelName,
                    m.YearBirth, m.ModelHeight, m.ModelWeight);
            }
            dataGridViewTable.Rows[work.MemberProfile.Count].ReadOnly = true;
        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
            this.Text = filename + " - База данных моделей";
            dataGridViewTable.Rows.Clear();
            work.OpenFile(filename);
            WriteToGrid();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                filename = saveFileDialog1.FileName;
                this.Text = filename + " - База данных моделей";
            }
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            labelSave.Visible = true;
            timer2.Enabled = true;
            timer2.Start();

            work.SaveToFile(filename);
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            dataGridViewTable.Rows.Clear();
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            panelSearchRecord.Visible = false;
            labelArtist.Visible =true;
            textBoxFullName.Visible = true;
            textBoxName.Visible = true;
            labelYear.Visible = true;
            textBoxYear.Visible = true;
            labelHeight.Visible = true;
            textBoxHeight.Visible = true;
            labelWeight.Visible = true;
            textBoxWeight.Visible = true;
            btnAddUser.Visible = true;
            btnDelUser.Visible = true;
            pictureBoxPin.Visible = false;
            panel1.Visible = false;
            pictureBox3.Visible = true;
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panelSearchRecord.Visible = true;
            pictureBoxPin.Visible = true;
            labelArtist.Visible = false;
            textBoxFullName.Visible = false;
            textBoxName.Visible = false;
            labelYear.Visible = false;
            textBoxYear.Visible = false;
            labelHeight.Visible = false;
            textBoxHeight.Visible = false;
            labelWeight.Visible = false;
            textBoxWeight.Visible = false;
            btnAddUser.Visible = false;
            btnDelUser.Visible = false;
            panel1.Visible = false;
            pictureBox3.Visible = true;
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pictureBox3.Visible = false;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Info = "База данных моделей, версия 1.0" + "\n\n" +
                            "Github: https://github.com/MAARUUU" + "\n\n" +
                            "2020 г.";
            MessageBox.Show(Info, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

 
    }
}
