namespace CalculForm_onlynum_
{
    public enum Operators {Add, Sub, Nulti, Div} //열거형 데이터 타입 선언
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;


        private void Nb1_Click(object sender, EventArgs e)
        {
            Button numButton =(Button)sender;
            SetNum(numButton.Text);
        }

        
        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
        }

        private void NbPlus_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                int num = int.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                {
                    Result = Result + num;
                }
                else if (Opt == Operators.Sub)
                {
                    Result = Result - num;
                }
                else if(Opt == Operators.Nulti)
                {
                    Result = Result * num;
                }
                else if (Opt == Operators.Div)
                {                
                    Result = Result / num;
                }
                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "*")
                Opt = Operators.Nulti;
            else if (optButton.Text == "/")
                Opt = Operators.Div;
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }
    }
}