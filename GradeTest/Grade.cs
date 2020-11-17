namespace GradeTest
{
    public class Grade
    {
        private string name;
        private int score;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public void Score(int score)
        {
            if (score >= 0 || score <= 100)
            {
                this.score = score;
            }
        }
        public string Score()
        {
            if (score >= 70)
            {
                return "A";
            }
            else if (score >= 60)
            {
                return "B";
            }
            else if (score >= 50)
            {
                return "C";
            }
            else if (score >= 45)
            {
                return "D";
            }
            else if (score >= 40)
            {
                return "E";
            }
            else
            {
                return "F";
            }
        }
    }
}