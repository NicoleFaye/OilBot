using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotkey;

namespace Oil_Bot
{
    public partial class OilQueen : Form
    {
        KeyboardHook hook = new KeyboardHook();
        Thread t;
        Object lck = new Object();
        Decimal distanceBetweenOilButtons;
        Decimal lengthOfPressMining;
        Decimal lengthOfPressOil;
        Decimal waitTime;

        public delegate void labelChanger();

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public OilQueen()
        {
            InitializeComponent();
            hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            hook.RegisterHotKey(Hotkey.ModifierKeys.Control, Keys.Home);
            hook.RegisterHotKey(Hotkey.ModifierKeys.Control, Keys.End);
            hook.RegisterHotKey(Hotkey.ModifierKeys.Control, Keys.S);

            distanceBetweenOilButtons = 103;
            lengthOfPressMining = 6000;
            lengthOfPressOil = 3500;
            waitTime = 6000;

            timer.Tick += Timer_Tick;
            timer.Interval = 20;

            LengthOfPressUpDown1.Value = lengthOfPressMining;
            LengthOfPressUpDown2.Value = lengthOfPressOil;
            WaitTimeUpDown.Value = waitTime;
            DistanceBetweenUpDown.Value = distanceBetweenOilButtons;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            XValueLabel.Invoke(new labelChanger(UpdateCoords));
        }

        public void UpdateCoords()
        {

            XValueLabel.Text = Cursor.Position.X.ToString();
            YValueLabel.Text = Cursor.Position.Y.ToString();
        }
        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (e.Key == Keys.Home)
            {
                if (t == null)
                {
                    if (comboBox1.SelectedItem.ToString().ToLower() == "oil")
                    {
                        t = new Thread(new ThreadStart(OilJob));
                    }
                    else if (comboBox1.SelectedItem.ToString().ToLower() == "mining")
                    {
                        t = new Thread(new ThreadStart(MiningJob));
                    }
                }

                if (!t.IsAlive)
                {
                    t.Start();
                }
            }
            else if (e.Key == Keys.End)
            {
                if (t != null)
                {
                    t.Abort();
                    if (comboBox1.SelectedItem.ToString().ToLower() == "oil")
                    {
                        KeyboardHook.MouseRelease();
                    }
                    else if (comboBox1.SelectedItem.ToString().ToLower() == "mining")
                    {
                        KeyboardHook.E_keyUp();
                    }

                    t = null;
                }
            }
            else if (e.Key == Keys.S)
            {

            }
        }
        void MiningJob()
        {
            while (true)
            {
                Thread.Sleep(200);
                KeyboardHook.E_keyDown();
                Thread.Sleep(Decimal.ToInt32(lengthOfPressMining));
                KeyboardHook.E_keyUp();
                Thread.Sleep(Decimal.ToInt32(waitTime));
            }

        }
        void OilJob()
        {
            while (true)
            {
                int numberOfClicks = 4;
                //motion to the right
                for (int i = 0; i < numberOfClicks; i++)
                {
                    KeyboardHook.MousePress();
                    Thread.Sleep(Decimal.ToInt32(lengthOfPressOil));
                    KeyboardHook.MouseRelease();
                    Thread.Sleep(200);
                    Cursor.Position = new Point(Cursor.Position.X + Decimal.ToInt32(distanceBetweenOilButtons), Cursor.Position.Y);
                }
                //motion to the left
                Cursor.Position = new Point(Cursor.Position.X - (Decimal.ToInt32(distanceBetweenOilButtons) * numberOfClicks), Cursor.Position.Y);
                Thread.Sleep(200);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().ToLower() == "oil")
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        private void LengthOfPressUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lock (lck)
            {
                lengthOfPressMining = LengthOfPressUpDown1.Value;
            }
        }

        private void WaitTimeUpDown_ValueChanged(object sender, EventArgs e)
        {
            lock (lck)
            {
                waitTime = WaitTimeUpDown.Value;
            }
        }

        private void LengthOfPressUpDown2_ValueChanged(object sender, EventArgs e)
        {
            lock (lck)
            {
                lengthOfPressOil = LengthOfPressUpDown2.Value;
            }
        }

        private void DistanceBetweenUpDown_ValueChanged(object sender, EventArgs e)
        {
            lock (lck)
            {
                distanceBetweenOilButtons = DistanceBetweenUpDown.Value;
            }
        }
    }
}
