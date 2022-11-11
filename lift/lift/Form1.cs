using Npgsql;
using System.Data;

namespace lift
{
    public partial class Form1 : Form
    {
        private string connstring = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres", "123", "postgres");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            databaseTable.Visible = true;
            select_all();
        }

        private void buttonup_Click(object sender, EventArgs e)
        {
            if (lift.Location.Y == 585 && First_Right_Door.Size.Width == 80 && First_Left_Door.Size.Width == 80
                && Ground_Right_Door.Size.Width == 80 && Ground_Left_Door.Size.Width == 80)
            {
                TimerUp.Enabled = true;

                UpButton.Enabled = false;
                CloseButton.Enabled = false;
                OpenButton.Enabled = false;
                DownButton.Enabled = false;

            }
            else
            {
                TimerUp.Enabled = false;
            }                      

        }
        private void TimerUp_Tick(object sender, EventArgs e)
        {
            DisplayMain.Image = Properties.Resources.display1;
            SmallDisplay1.Image = Properties.Resources.display1;
            SmallDisplay2.Image = Properties.Resources.display1;
            lift.Location = new Point(lift.Location.X, lift.Location.Y - 5);
            TimerUp.Enabled = true;

            if (lift.Location.Y == 75)
            {
                TimerUp.Enabled = false;
                TimerOpen.Enabled = true;
                UpButton.Enabled = true;
                CloseButton.Enabled = true;
                OpenButton.Enabled = true;
                DownButton.Enabled = true;
                insertElevatorLogs("Up", "Reached First Floor");

            }  
        }

        private void buttondown_Click(object sender, EventArgs e)
        {

            if (lift.Location.Y == 75 && First_Right_Door.Size.Width == 80 && First_Left_Door.Size.Width == 80
                && Ground_Right_Door.Size.Width == 80 && Ground_Left_Door.Size.Width == 80)
            {
                TimerDown.Enabled = true;
                
                UpButton.Enabled = false;
                CloseButton.Enabled = false;
                OpenButton.Enabled = false;
                DownButton.Enabled= false;
            }
            else
            {
                TimerDown.Enabled = false;
            }
        }
        private void timerdown_Tick(object sender, EventArgs e)
        {
            DisplayMain.Image = Properties.Resources.display0;
            SmallDisplay1.Image = Properties.Resources.display0;
            SmallDisplay2.Image = Properties.Resources.display0;
            lift.Location = new Point(lift.Location.X, lift.Location.Y + 5);
            TimerDown.Enabled = true;

            if (lift.Location.Y == 585)
            {
                TimerOpen.Enabled = true;
                TimerDown.Enabled = false;

                UpButton.Enabled = true;
                CloseButton.Enabled = true;
                OpenButton.Enabled = true;
                DownButton.Enabled = true;
                insertElevatorLogs("Down", "Reached Ground Floor");
                DisplayMain.Image = Properties.Resources.display0;
                SmallDisplay1.Image = Properties.Resources.display0;
                SmallDisplay2.Image = Properties.Resources.display0;
            }

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            TimerOpen.Enabled = true;
        }

        private void timeropen_Tick(object sender, EventArgs e)
        {
            


            if (lift.Location.Y == 75)
            {
                First_Right_Door.Location = new Point(First_Right_Door.Location.X + 1, First_Right_Door.Location.Y);
                First_Right_Door.Size = new Size(First_Right_Door.Size.Width - 1, First_Right_Door.Size.Height);
                First_Left_Door.Size = new Size(First_Left_Door.Size.Width - 1, First_Left_Door.Size.Height);

                TimerOpen.Enabled = true;
            
                UpButton.Enabled = false;
                DownButton.Enabled = false;
                CloseButton.Enabled = false;


                if (First_Left_Door.Size.Width == 0)
                {
                    TimerOpen.Enabled = false;

                    UpButton.Enabled = true;
                    DownButton.Enabled = true;
                    CloseButton.Enabled = true;
                    insertElevatorLogs("Open", "Opening First Floor Elevator Door");
                }
            }

            if (lift.Location.Y == 585)
            {
                Ground_Right_Door.Location = new Point(Ground_Right_Door.Location.X + 1, Ground_Right_Door.Location.Y);
                Ground_Right_Door.Size = new Size(Ground_Right_Door.Size.Width - 1, Ground_Right_Door.Size.Height);
                Ground_Left_Door.Size = new Size(Ground_Left_Door.Size.Width - 1, Ground_Left_Door.Size.Height);

                TimerOpen.Enabled = true;

                UpButton.Enabled = false;
                DownButton.Enabled = false;
                CloseButton.Enabled = false;


                if (Ground_Left_Door.Size.Width == 0)
                {
                    TimerOpen.Enabled = false;

                    UpButton.Enabled = true;
                    DownButton.Enabled = true;
                    CloseButton.Enabled = true;
                    insertElevatorLogs("Open", "Opening Ground Floor Elevator Door");
                }
            }

        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            TimerClose.Enabled = true;

        }

        private void timerclose_Tick(object sender, EventArgs e)
        {
            

            if (lift.Location.Y == 75 && First_Right_Door.Size.Width < 80 && First_Left_Door.Size.Width < 80)
            {
                First_Right_Door.Location = new Point(First_Right_Door.Location.X - 1, First_Right_Door.Location.Y);
                First_Right_Door.Size = new Size(First_Right_Door.Size.Width + 1, First_Right_Door.Size.Height);
                First_Left_Door.Size = new Size(First_Left_Door.Size.Width + 1, First_Left_Door.Size.Height);

                TimerClose.Enabled = true;

                UpButton.Enabled = false;
                DownButton.Enabled = false;
                OpenButton.Enabled = false;


                if (First_Left_Door.Size.Width == 80)
                {
                    TimerClose.Enabled = false;


                    UpButton.Enabled = true;
                    DownButton.Enabled = true;
                    OpenButton.Enabled = true;
                    insertElevatorLogs("Close", "Closing First Floor Elevator Door");
                }

            }


            if (lift.Location.Y == 585 && Ground_Right_Door.Size.Width < 80 && Ground_Left_Door.Size.Width < 80)
            {
                Ground_Right_Door.Location = new Point(Ground_Right_Door.Location.X - 1, Ground_Right_Door.Location.Y);
                Ground_Right_Door.Size = new Size(Ground_Right_Door.Size.Width + 1, Ground_Right_Door.Size.Height);
                Ground_Left_Door.Size = new Size(Ground_Left_Door.Size.Width + 1, Ground_Left_Door.Size.Height);

                TimerClose.Enabled = true;
                UpButton.Enabled = false;
                DownButton.Enabled = false;
                OpenButton.Enabled = false;

                if (Ground_Left_Door.Size.Width == 80)
                {
                    TimerClose.Enabled = false;


                    UpButton.Enabled = true;
                    DownButton.Enabled = true;
                    OpenButton.Enabled = true;
                    insertElevatorLogs("Close", "Closing Ground Floor Elevator Door");
                }
            }


        }



        public void insertElevatorLogs(String btn, String btnAction)
        {
            conn.Open();
            sql = @"Insert into lift (lift_button, lift_details, lift_date, lift_time) values (@btn, @details, @lift_date, @lift_time)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@btn", btn);
            cmd.Parameters.AddWithValue("@details", btnAction);
            cmd.Parameters.AddWithValue("@lift_date", DateTime.Now.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@lift_time", DateTime.Now.ToString("hh:mm:ss"));
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void select_all()
        {
            try
            {
                conn.Open();
                sql = "select * from lift";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                databaseTable.DataSource = null;
                databaseTable.DataSource = dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }

            //FUNCTION SELECT(){
            //sql=select * from lift;
            //}
        }

        private void log_Click(object sender, EventArgs e)
        {
            select_all();
        }

    
       
    }
}
