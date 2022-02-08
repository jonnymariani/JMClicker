using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMClicker
{
    public partial class Form1 : Form
    {

       

        // Importa DLL's
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]

        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int LeftUp = 0x0004; 
        private const int LeftDown = 0x0002;

        public int Intervalo;
        public String Hotkey;
        public bool Clicar = false;
        public bool BTNStatus = false;

        
        // Cria thread responsável por clicar
        Thread AC;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Intervalo = Convert.ToInt32(NUMIntervalo.Value);
            Hotkey = TXTInput.Text;

            AC = new Thread(AutoClick);
            BGW_BackgroundWorker.RunWorkerAsync();

        }


        private void AutoClick()
        {
            while (true)
            {
                if (Clicar)
                {
                    mouse_event(dwFlags: LeftUp, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(5);
                    mouse_event(dwFlags: LeftDown, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(Intervalo);
                }
                
                Thread.Sleep(5);

            }
        }

        private void BGW_BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            while (true)
            {
                Keys key;
                Enum.TryParse(Hotkey, out key);

                if (BTNStatus)
                {
                    if (GetAsyncKeyState(key) < 0)
                    {
                        Clicar = true;
                    }
                    else
                    {
                        Clicar = false;
                    }
                }

                Thread.Sleep(5);
            }

            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AC.Abort();
        }

        private void BTNStart_Click_1(object sender, EventArgs e)
        {
            if (AC.IsAlive)
            {
                BTNStart.Text = "Start";
                BTNStatus = false;

                AC.Abort();

                Console.WriteLine("Abortado");
            }
            else
            {
                AC = new Thread(AutoClick);
                AC.Start();

                BTNStart.Text = "Stop";
                BTNStatus = true;

                Console.WriteLine("Iniciado");

                this.WindowState = FormWindowState.Minimized;

            }
        }

        private void NUMIntervalo_ValueChanged(object sender, EventArgs e)
        {
            AC.Abort();
            Console.WriteLine("Abortado");

            Hotkey = TXTInput.Text;

            AC = new Thread(AutoClick);
            AC.Start();
            Console.WriteLine("Iniciado");
        }

        private void NUMIntervalo_Click(object sender, EventArgs e)
        {
            NUMIntervalo.Focus();
            NUMIntervalo.Select(0, NUMIntervalo.Value.ToString().Length);

        }

        int AguardandoInput = 0; // 1 = entrou no foco 2 = aguardando input
        String UltimoKey = "M";

        private void TXTInput_Click(object sender, EventArgs e)
        {
            AguardandoInput++;
        }

        private void TXTInput_KeyDown(object sender, KeyEventArgs e)
        {
            Hotkey = e.KeyCode + "";
            BTNStart.Focus();

            TXTInput.Text = "";
            TXTInput.Text = Hotkey;

            UltimoKey = TXTInput.Text;

            AguardandoInput = 0;
        }

        private void TXTInput_Enter(object sender, EventArgs e)
        {
            TXTInput.ForeColor = Color.Red;
            TXTInput.Text = "Press a Key";
        }

        private void TXTInput_Leave(object sender, EventArgs e)
        {
            TXTInput.ForeColor = Color.Black;

            if (TXTInput.Text == "Press a Key")
            {
                TXTInput.Text = UltimoKey;
            }
        }
    }
   
}
