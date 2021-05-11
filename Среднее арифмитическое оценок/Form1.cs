using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Среднее_арифмитическое_оценок
{
    public delegate void NotesDelegate();
    public partial class Form1 : Form
    {
        Note note;
        public Form1()
        {
            InitializeComponent();
            note = new Note(ShowArifNotes, ShowCount);
        }
        public void ShowArifNotes()
        {
            label1.Text = note.Result().ToString("0.0");
        }
        public void ShowCount()
        {
            label2.Text = note.ReturnCount.ToString();
        }

        private void buttonAdd5_Click(object sender, EventArgs e)
        {
            note.AddNotes(float.Parse(((Button)(sender)).Tag.ToString()));
            note.notesDelegate();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            note.Clear();
            label1.Text = note.Result().ToString("0.0");
            label2.Text = note.ReturnCount.ToString();
        }

    }
}
