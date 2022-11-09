using Npgsql;

namespace lift
{
    public partial class Form1 : Form
    {
        private string connstring = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres", "123", "dbpostgre");
        private NpgsqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void timerup_Tick(object sender, EventArgs e)
        {
            lift.Location = new Point(lift.Location.X, lift.Location.Y - 5);
            timerup.Enabled = true;

            if (lift.Location.Y == 75)
            {
                timerup.Enabled = false;
            }
        }

        private void buttonup_Click(object sender, EventArgs e)
        {
            if (lift.Location.Y == 585 && First_Right_Door.Size.Width == 80 && First_Left_Door.Size.Width == 80 
                && Ground_Right_Door.Size.Width == 80 && Ground_Left_Door.Size.Width == 80)
            {
                timerup.Enabled = true;
            }
            else
            {
                timerup.Enabled = false;
            }
            
        }

        private void timerdown_Tick(object sender, EventArgs e)
        {
            lift.Location = new Point(lift.Location.X, lift.Location.Y + 5);
            timerdown.Enabled = true;
            if (lift.Location.Y == 585)
                timerdown.Enabled = false;
        }

        private void buttondown_Click(object sender, EventArgs e)
        {
            if (lift.Location.Y == 75 && First_Right_Door.Size.Width == 80 && First_Left_Door.Size.Width == 80 
                && Ground_Right_Door.Size.Width == 80 && Ground_Left_Door.Size.Width == 80)
            {
                timerdown.Enabled = true;
            }
            else
            {
                timerdown.Enabled = false;
            }
        }   


        private void timeropen_Tick(object sender, EventArgs e)
        {
            if (lift.Location.Y == 75)
            {
                First_Right_Door.Location = new Point(First_Right_Door.Location.X + 1, First_Right_Door.Location.Y);
                First_Right_Door.Size = new Size(First_Right_Door.Size.Width - 1, First_Right_Door.Size.Height);
                First_Left_Door.Size = new Size(First_Left_Door.Size.Width - 1, First_Left_Door.Size.Height);

                timeropen.Enabled = true;

                if (First_Left_Door.Size.Width == 0)
                {
                    timeropen.Enabled = false;
                }
            }
            if (lift.Location.Y == 585)
            {
                Ground_Right_Door.Location = new Point(Ground_Right_Door.Location.X + 1, Ground_Right_Door.Location.Y);
                Ground_Right_Door.Size = new Size(Ground_Right_Door.Size.Width - 1, Ground_Right_Door.Size.Height);
                Ground_Left_Door.Size = new Size(Ground_Left_Door.Size.Width - 1, Ground_Left_Door.Size.Height);

                timeropen.Enabled = true;

                if (Ground_Left_Door.Size.Width == 0)
                {
                    timeropen.Enabled = false;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            timeropen.Enabled = true;

            if (lift.Location.Y == 585)
            {
                timeropen.Enabled = true;
            }
        }

        private void timerclose_Tick(object sender, EventArgs e)
        {
            if (lift.Location.Y == 75 && First_Right_Door.Size.Width < 80 && First_Left_Door.Size.Width<80)
            {
                First_Right_Door.Location = new Point(First_Right_Door.Location.X - 1, First_Right_Door.Location.Y);
                First_Right_Door.Size = new Size(First_Right_Door.Size.Width + 1, First_Right_Door.Size.Height);
                First_Left_Door.Size = new Size(First_Left_Door.Size.Width + 1, First_Left_Door.Size.Height);



                  if (First_Left_Door.Size.Width == 80)
                  {
                    timerclose.Enabled = false;
                  }
                               
            }
            

            if (lift.Location.Y == 585 && Ground_Right_Door.Size.Width < 80 && Ground_Left_Door.Size.Width < 80)
            {
                Ground_Right_Door.Location = new Point(Ground_Right_Door.Location.X - 1, Ground_Right_Door.Location.Y);
                Ground_Right_Door.Size = new Size(Ground_Right_Door.Size.Width + 1, Ground_Right_Door.Size.Height);
                Ground_Left_Door.Size = new Size(Ground_Left_Door.Size.Width + 1, Ground_Left_Door.Size.Height);

                timerclose.Enabled = true;

                if (Ground_Left_Door.Size.Width == 80)
                {
                   timerclose.Enabled = false;
                }
            }

        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            timerclose.Enabled = true;

            if (lift.Location.Y == 585)
            {
                timerclose.Enabled = true;
            }
        }

    }
}
