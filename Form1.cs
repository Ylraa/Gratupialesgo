using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

//Copyright by KangCpanel
//jangan ubah copyrightnya gan
namespace GtTrainer
{
    public partial class Form1 : Form
    {
        int TogMove;
        int MValX;
        int MValY;

        Mem memory = new Mem();
        public Form1()
        {
            InitializeComponent();
        }

        string bypass = "Growtopia.exe+532959";
        string modZoom = "Growtopia.exe+52334F";
        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = memory.GetProcIdFromName("Growtopia");
            if(PID > 0)
            {
                memory.OpenProcess(PID);
                memory.WriteMemory(modZoom, "bytes", "90 90 90 90 90 90 90");
                memory.WriteMemory(bypass, "bytes", "90 90");
                MessageBox.Show("Happy Cheating !!!", "GtTrainer.exe");
            }
            //jika process growtopia tidak di temukan
            //aplikasi tidak muncul
            else
            {
                MessageBox.Show("Dll Not Injected, open first growtopia!!", "GtTrainer.exe");
                //CallTheFunction
                closeApps();

            }

        }

        string ModFly = "Growtopia.exe+698AA7";
        private void modfly_CheckedChanged(object sender, EventArgs e)
        {
            if(modfly.Checked == true)
            {
                memory.WriteMemory(ModFly, "bytes", "90 90");
            }
            else
            {
                memory.WriteMemory(ModFly, "bytes", "74 5D");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                memory.WriteMemory("Growtopia.exe+688C75", "bytes", "90 90");
            }
            else
            {
                memory.WriteMemory("Growtopia.exe+688C75", "bytes", "75 0B");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked == true)
            {
                memory.WriteMemory("Growtopia.exe+699AE3", "bytes", "90 90");
            }
            else
            {
                memory.WriteMemory("Growtopia.exe+699AE3", "bytes", "75 10");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                memory.WriteMemory("Growtopia.exe+688C69", "bytes", "90 90 90 90");
            }
            else
            {
                memory.WriteMemory("Growtopia.exe+688C69", "bytes", "80 79 12 00");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox8.Checked == true)
            {
                memory.WriteMemory("Growtopia.exe+62CD80", "bytes", "90 90 90 90 90 90 90");
            }
            else
            {
                memory.WriteMemory("Growtopia.exe+62CD80", "bytes", "48 8D 15 41 8D 5E 00");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked == true)
            {
                memory.WriteMemory("Growtopia.exe+638F84", "bytes", "90 90 90 90 90 90 90");
            }
            else
            {
                memory.WriteMemory("Growtopia.exe+638F84", "bytes", "F6 87 88 01 00 00 01");
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox13.Checked == true)
            {
                memory.WriteMemory("Growtopia.exe+199C09", "bytes", "90 90");
            }
            else
            {
                memory.WriteMemory("Growtopia.exe+199C09", "bytes", "72 A7");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox11.Checked == true)
            {
                memory.WriteMemory("Growtopia.exe+11B043", "bytes", "90 90 90 90 90 90");
            }
            else
            {
                memory.WriteMemory("Growtopia.exe+11B043", "bytes", "0F 84 9E 01 00 00");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox10.Checked == true)
            {
                memory.WriteMemory("Growtopia.exe+230188", "bytes", "90 90 90 90 90 90");
            }
            else
            {
                memory.WriteMemory("Growtopia.exe+230188", "bytes", "8B 86 88 01 00 00");
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox12.Checked == true)
            {
                memory.WriteMemory("Growtopia.exe+6449B2", "bytes", "90 90 90 90 90 90");
            }
            else
            {
                memory.WriteMemory("Growtopia.exe+6449B2", "bytes", "0F 84 17 01 00 00");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox9.Checked == true)
            {
                memory.WriteMemory("Growtopia.exe+6343AF", "bytes", "90 90 90");
            }
            else
            {
                memory.WriteMemory("Growtopia.exe+6343AF", "bytes", "48 8B D9");
            }
        }

        //speedhack
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        //anti checkpoint
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true)
            {
                memory.WriteMemory("Growtopia.exe+688C4A", "bytes", "90 90 90 90 90");
            }
            else
            {
                memory.WriteMemory("Growtopia.exe+688C4A", "bytes", "83 7C 02 04 1B");
            }
        }

        //function close application
        private void closeApps()
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //CallTheFunction
            closeApps();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox14.Checked == true)
            {
                memory.WriteMemory("Growtopia.exe+645B8B", "bytes", "90 90");
            }
            else
            {
                memory.WriteMemory("Growtopia.exe+645B8B", "bytes", "74 5F");
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(TogMove == 1) 
            { 
               this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void directLink()
        {
            MessageBox.Show("Github belum buat bang !!!", "GtTrainer.exe");
        }

        //youtube channel
        private void youtube()
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCIF19i2Gl0s532jmWlxFR-g");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            directLink();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //call the function
            youtube();
        }
    }
}
