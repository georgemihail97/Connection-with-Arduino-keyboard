using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tastatura_arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void citestePort()
        {
            try
            {
                // Deschide portul serial pentru a putea citi datele
                serialPort1.Open();
                // Deoarece nu se cunoaste momentul in care utilizatorul va genera evenimentul de apasare a tastei,
                // se va implementa un fir de executie separat care va permite citirea continua, fara sa afecteze interfata grafica
                // adica fara sa blocheze (inghete) interfata cu utilizatorul
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPortData);

            }
            catch (Exception ex)
            {
                afisareTxt.Text = "Nu se poate deschide portul";
            }
        }

        public void AfiseazaText(string text)
        {
            // Se invoca un nou fir de executie pentru afisarea in textBox
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AfiseazaText), new object[] { text });
                return;
            }
            afisareTxt.Text = text;
        }


        void serialPortData(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Citeste datele pe portul serial
                string res = serialPort1.ReadLine();
                // Deoarece citirea se realizeaza intr-un fir de executie, scrierea in textBox in mod direct nu este posibila
                // Din aceste considerente se invoca o alta metoda care permite scrierea intr-un alt fir de executie (Thread)
                AfiseazaText(res);
            }
            catch (Exception ex)
            {
                AfiseazaText("eroare!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            // Atunci cand utilizatorul inchide aplicatia, trebuie inchis si portul serial
            // In caz contrar, la o rulare ulterioara, atunci cand va incerca sa deschida aplicatia va rezulta in eroare, deoarece portul este deja deschis de la executia anterioara
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Apelez metoda care implementeaza comunicatia pe portul serial
            citestePort();
        }

        private void afisareTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
