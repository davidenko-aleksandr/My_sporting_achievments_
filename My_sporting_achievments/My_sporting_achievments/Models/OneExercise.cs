using SQLite;
using System.Windows.Input;

namespace My_sporting_achievments.Models
{
    [Table("Exercises")]
    public class OneExercise
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string NameExercise { get; set; }
        public double Weight_1 { get; set; }
        public int Repetitions_1 { get; set; }
        public double Weight_2 { get; set; }
        public int Repetitions_2 { get; set; }
        public double Weight_3 { get; set; }
        public int Repetitions_3 { get; set; }
        public double Result { get; set; }
        //public double Weight_4 { get; set; }
        //public int Repetitions_4 { get; set; }
        //public double Weight_5 { get; set; }
        //public int Repetitions_5 { get; set; }
        [Ignore]
        public ICommand ExerciseSelected { get; set; }
    }
}
