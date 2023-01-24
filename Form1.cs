namespace College_Application
{
    public partial class WelcomeForm : Form
    {
        // Student Model
        private string studentName = string.Empty;
        private int studentRoll = 0;
        private int studentMarks = 0;

        // Book Model
        private int bookId = 0 ;
        private string tittle = string.Empty;
        private string author = string.Empty;
        private double price = 0.0;

        // Libaray Model
        private int id = 0;
        private int libarayBookId = 0;
        private int libarayStudentId = 0;
        private DateTime subDate = DateTime.MinValue;
        private DateTime retDate = DateTime.MinValue;
        private int subscribed = 0;

        // setting and getting values

        // Student Properties

        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }
        public int StudentRoll
        {
            get
            {
                return studentRoll;
            }
            set
            {
                studentRoll = value;
            }
        }
        public int StudentMarks
        {
            get
            {
                return studentMarks;
            }
            set
            {
                studentMarks = value;
            }
        }
        
        // Book Properties

        public int BookId
        {
            get { return bookId; }
            set
            {
                bookId = value;
            }
        }
        public string BookTittle
        {
            get { return tittle; }
            set
            {
                tittle = value;
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                author = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }

        // Libaray Properties

        public int LibarayId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int LibarayBookId
        {
            get
            {
                return libarayBookId;
            }
            set
            {
                libarayBookId = value;
            }
        }
        public int LibarayStudentId
        {
            get
            {
                return libarayStudentId;
            }
            set
            {
                libarayStudentId = value;
            }
        }
        public int Subscribed
        {
            get
            {
                return subscribed;
            }
            set
            {
                subscribed = value;
            }
        }
        public DateTime SubDate
        {
            get
            {
                return subDate;
            }
            set
            {
                subDate = value;
            }
        }
        public DateTime RetDate
        {
            get
            {
                return retDate;
            }
            set
            {
                retDate = value;
            }
        }
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}