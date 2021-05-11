using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Среднее_арифмитическое_оценок
{

    class Note
    {
        public NotesDelegate notesDelegate;
        int CountNotes;
        float SumNotes;
        public Note(NotesDelegate A, NotesDelegate B) 
        {
            notesDelegate = A;
            notesDelegate += B;
        }
        public void AddNotes(float notes)
        {
            if (2 <= notes || notes <= 5)
            {
                CountNotes++;
                SumNotes += notes;
            }
        }
        public float Result()
        {
            float res = 0;
            if (CountNotes != 0)  res = SumNotes / CountNotes;
            return res;
        }
        public int ReturnCount
        {
            get{ return CountNotes; }
        }
        public void Clear()
        {
            CountNotes=0;
            SumNotes=0;
        }

    } 
}
