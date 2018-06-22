/* Creator: Paul Engelhardt
 * Description: This program simulates the basics behind Assembly.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMSim
{
    public partial class Form1 : Form
    {
        TextBox[] list = new TextBox[22];
        CodeData data = new CodeData();
        string[] lines;
        bool runAuto = true;
        bool stop = true;
        int currentPosition;
        bool jumped;
        public string[] commands =
        {
            "lda",          //0
            "sta",          //1
            "hlt",          //2
            "add",          //3
            "sub",          //4
            "jmp",          //5
            "jmz",          //6
            "cmx",          //7
            "cmy",          //8
            "mul",          //9
            "div",          //10
        };

        public int[] storage =
        {
            0,
            0,
            0,
            0,
        };
        public string[] storageName =
        {
            "x",
            "y",
            "z",
            "s",
        };
        int[] secondaryStorage = new int[30];

        void InitTextbox()
        {
            int pos = 25;
            for (int i = 0; i < list.Length; i++)
            {
                TextBox text = new TextBox();
                text.Location = new Point(10, pos);
                text.Text = Convert.ToString(i) + ":"+"TODO";
                this.Controls.Add(text);
                pos += 20;
                list[i] = text;
            }
        }


        /// <summary>
        /// starts the running process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Compiler_Click(object sender, EventArgs e)
        {

            stop = !stop;
            if (stop)
            {
                Compiler.Text = "Run";
            }
            else
            {
                Compiler.Text = "Stop";
            }

            currentPosition = data.GetCurrentP()-1;
            lines = Code.Text.Split('\n');
        }
        /// <summary>
        /// processes the current command
        /// </summary>
        /// <param name="currentCommand"></param>
        /// <param name="currentPosition"></param>
        /// <param name="jumped"></param>
        /// <returns></returns>
        bool ExecuteCommand(string[] currentCommand, ref int currentPosition, ref bool jumped)
        {
            bool kill = false;
            if (currentCommand[0] == commands[0])
            {
                kill = LDA(currentCommand[1]);
            }
            else if (currentCommand[0] == commands[1])
            {
                STA(currentCommand[1]);
            }
            else if (currentCommand[0] == commands[3])
            {
                ADD(currentCommand[1]);
            }
            else if (currentCommand[0] == commands[4])
            {
                SUB(currentCommand[1]);
            }
            else if (currentCommand[0] == commands[5])
            {
                currentPosition = Convert.ToInt32(currentCommand[1]);
                jumped = true;
            }
            else if (currentCommand[0] == commands[6])
            {
                if (data.GetAcc() == 0)
                {
                    currentPosition = Convert.ToInt32(currentCommand[1]);
                    jumped = true;
                }
            }
            else if (currentCommand[0] == commands[7])
            {
                if (data.GetAcc() == storage[0])
                {
                    currentPosition = Convert.ToInt32(currentCommand[1]);
                    jumped = true;
                }
            }
            else if (currentCommand[0] == commands[8])
            {
                if (data.GetAcc() == storage[1])
                {
                    currentPosition = Convert.ToInt32(currentCommand[1]);
                    jumped = true;
                }
            }
            else if (currentCommand[0] == commands[9])
            {
                MUL(currentCommand[1]);
            }
            else if (currentCommand[0] == commands[10])
            {
                DIV(currentCommand[1]);
            }
            else if (currentCommand[0] == commands[2])
            {
                kill = true;
            }
            else
            {
                kill = true;
                MessageBox.Show("Error! Unkown Command");
            }
            return kill;
        }


        /// <summary>
        /// used for dividing
        /// </summary>
        /// <param name="command"></param>
        void DIV(string command)
        {
            if (command[0] == '#')
            {
                string[] intToConvert = command.Split('#');
                data.SetAcc(data.GetAcc()/ Convert.ToInt32(intToConvert[1]));
            }
            else
            {
                for (int i = 0; i < storageName.Length; i++)
                {
                    if (command[0] == Convert.ToChar(storageName[i]))
                    {
                        data.SetAcc(data.GetAcc() / storage[i]);
                    }
                }
            }
        }


        /// <summary>
        /// used for mulitplying
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        bool MUL(string command)
        {
            bool kill = false;
            if (command[0] == '#')
            {
                string[] intToConvert = command.Split('#');
                data.SetAcc(Convert.ToInt32(intToConvert[1]) * data.GetAcc());
            }
            else
            {
                for (int i = 0; i < storageName.Length; i++)
                {
                    if (command[0] == Convert.ToChar(storageName[i]))
                    {
                        data.SetAcc(data.GetAcc() * storage[i]);
                    }
                }
            }
            return kill;
        }


        /// <summary>
        /// this Method subtracts numbers
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        bool SUB(string command)
        {
            bool kill = false;
            if (command[0] == '#')
            {
                string[] intToConvert = command.Split('#');
                data.SetAcc(-Convert.ToInt32(intToConvert[1]) + data.GetAcc());
            }
            else
            {
                for (int i = 0; i < storageName.Length; i++)
                {
                    if (command[0] == Convert.ToChar(storageName[i]))
                    {
                        data.SetAcc(data.GetAcc() - storage[i]);
                    }
                }
            }

            return kill;
        }
        /// <summary>
        /// adds to the accumulator
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        bool ADD(string command)
        {
            bool kill = false;

            if (command[0] == '#')
            {
                string[] intToConvert = command.Split('#');
                data.SetAcc(Convert.ToInt32(intToConvert[1]) + data.GetAcc());
            }
            else
            {
                for (int i = 0; i < storageName.Length; i++)
                {
                    if (command[0] == Convert.ToChar(storageName[i]))
                    {
                        data.SetAcc(data.GetAcc()+storage[i]);
                    }
                }
            }

            return kill;
        }

        /// <summary>
        /// stores the accumulator in a storage space
        /// </summary>
        /// <param name="commend"></param>
        /// <returns></returns>
        bool STA(string commend)
        {
            if (commend[0] == '$')
            {
                string[] secStorageName = commend.Split('$');
                secondaryStorage[Convert.ToInt32(secStorageName[1])] = data.GetAcc();
                LastChangedSec.Text = "last changed: "+secStorageName[1] + ": " + data.GetAcc(); 
            }
            for (int i = 0; i < storageName.Length; i++)
            {
                if(commend == storageName[i])
                {
                    storage[i] = data.GetAcc();
                }
            }
            return false;
        }


        /// <summary>
        /// loads the accumulator with a number
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        bool LDA(string command)
        {

            if(command[0] == '$')
            {
                string[] secStorageName = command.Split('$');
                data.SetAcc(Convert.ToInt32(secondaryStorage[Convert.ToInt32(secStorageName[1])]));
            }
            if (command[0] == '#')
            {
                string[] intToConvert = command.Split('#');
                data.SetAcc(Convert.ToInt32(intToConvert[1]));
            }
            else
            {
                for (int i = 0; i < storage.Length; i++)
                {
                    if(command == storageName[i])
                    {
                        data.SetAcc(storage[i]);
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// resets the storage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < storage.Length; i++)
            {
                storage[i] = 0; 
            }
            InitSecStorage();
            data.SetCurrentP(0);
            data.SetAcc(0);
            PrintData();
        }



        /// <summary>
        /// starts the next Command and counts the current Code Position
        /// </summary>
        void ProgramCounter()
        {
            if (!stop)
            {
                if (!jumped)
                {
                    currentPosition++;
                    data.SetCurrentP(currentPosition);
                }
                jumped = false;
                if (currentPosition < 0)
                {
                    currentPosition = 0;
                }
                if (currentPosition < lines.Length)
                {


                    string[] currentCommand = lines[currentPosition].Split(' ');
                    stop = ExecuteCommand(currentCommand, ref currentPosition, ref jumped);
                    PrintData();
                }
                if (currentPosition >= lines.Length)
                {
                    stop = true;
                }

                if (stop)
                {
                    Compiler.Text = "Run";
                }

                PrintSecStorage();
                PrintRunningProgram();
            }
        }

        void PrintRunningProgram()
        {
            for (int i = 0; i < list.Length; i++)
            {
                if(i >= lines.Length)
                {
                    list[i].Text = "       "+i+": NOP";
                }
                else if(i == data.GetCurrentP())
                {
                    list[i].Text = ">     "+i + ": "+lines[i];
                }
                else
                {
                    list[i].Text = "       "+i+": "+lines[i];
                }
            }
        }

        void PrintSecStorage()
        {
            for (int i = 0; i < secondaryStorage.Length; i++)
            {
                SecondaryStorageToolStripMenuItem.Items[i] = i+": "+secondaryStorage[i];
            }
        }
        private void ShowInfo(object sender, EventArgs e)
        {
            Info i = new Info();
            i.Show();
        }


        /// <summary>
        /// opens a file from the Explorer. Can open any file Type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                Code.Text = File.ReadAllText(fileToOpen);
            }
        }


        /// <summary>
        /// Saves the Code in a asm or txt File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Asm File|*.asm| txt file|*.txt";
            saveFileDialog1.Title = "Save Code";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, Code.Text, Encoding.Default);
            }
        }


        /// <summary>
        /// calls the ProgramCounter in Debug Mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ProgramCounter();
        }


        /// <summary>
        /// calls the ProgramCounter when Run Mode is used.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (runAuto)
            {
                ProgramCounter();
            }
        }

        /// <summary>
        /// prints the most important variables to the Form
        /// </summary>
        void PrintData()
        {
            AccText.Text = "Acc: " + data.GetAcc();
            yText.Text = "Y: " + storage[1];
            xText.Text = "X: " + storage[0];
            SDisplay.Text = "S: " + storage[2];
            ZDisplay.Text = "Z: " + storage[3];
            codeP.Text = "Current Commend: " + data.GetCurrentP();
        }

        /// <summary>
        /// used to change between Debug and Run mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoRun(object sender, EventArgs e)
        {
            runAuto = !runAuto;

            if(runAuto)
            {
                button1.IsAccessible = false;
                AutoRUnFaToolStripMenuItem.Text = "Debug Mode";
            }
            else
            {
                button1.IsAccessible = true;
                AutoRUnFaToolStripMenuItem.Text = "Automatic Mode";
            }
        }


        void InitSecStorage()
        {
            SecondaryStorageToolStripMenuItem.Text = "Sec";
            for (int i = 0; i < secondaryStorage.Length; i++)
            {
                secondaryStorage[i] = 0;
                SecondaryStorageToolStripMenuItem.Items.Add(secondaryStorage[i]);
            }

        }
        public Form1()
        {
            InitializeComponent();
            InitTextbox();
            InitSecStorage();
        }

        private void saveSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunProgramTick.Interval = Convert.ToInt32(ProgramSpeedBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
