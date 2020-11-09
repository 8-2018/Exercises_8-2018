using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_8_2018
{
    class ExerciseResult
    {
        public int Id;
        public string StudentName;
        public string StudentIndex;
        public int Points;

        public ExerciseResult()
        {

        }

        public ExerciseResult(int id, string studentname, string studentindex, int points)
        {
            this.Id = id;
            this.StudentName = studentname;
            this.StudentIndex = studentindex;
            this.Points = points;
        }
    }
}
