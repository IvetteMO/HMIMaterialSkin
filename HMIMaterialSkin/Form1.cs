using MaterialSkin;
using MaterialSkin.Controls;
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

namespace HMIMaterialSkin
{
    public partial class Form1 : MaterialForm
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
            disableControls();
            getAvailableComPorts();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);

            foreach (string port in ports)
            {
                cmbPuerto.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    cmbPuerto.SelectedItem = ports[0];
                }
            }
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void msTema_CheckedChanged(object sender, EventArgs e)
        {
            if (msTema.Checked)
            {
                TManager.Theme = MaterialSkinManager.Themes.DARK;
                TManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
                msTema.Text = "Oscuro";
            }
            else
            {
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
                TManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
                msTema.Text = "Claro";

            }
        }

        private void materialComboBox1_DropDown(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            cmbPuerto.Items.Clear();
            cmbPuerto.Items.AddRange(portList);
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            try
            {

                isConnected = false;
                port.Write("#STOP\n");
                port.Close();
                btnConectar.Text = "Connect";
                disableControls();
                resetDefaults();

                MessageBox.Show("Desconectado de la tarjeta arduino");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                isConnected = true;
                string selectedPort = cmbPuerto.GetItemText(cmbPuerto.SelectedItem);
                int obBaud = Convert.ToInt32(cmbBaud.Text);
                port = new SerialPort(selectedPort, obBaud, Parity.None, 8, StopBits.One);
                port.Open();
                port.Write("#STAR\n");
                //button1.Text = "Disconnect";
                enableControls();

                MessageBox.Show("Conectado a la tarjeta arduino");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void chkRed_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (chkRed.Checked)
                {
                    port.Write("#LED1ON\n");
                    pbRojo.Image = HMIMaterialSkin.Properties.Resources.RojoOn;
                }
                else
                {
                    pbRojo.Image = HMIMaterialSkin.Properties.Resources.RojoOff;
                    port.Write("#LED1OF\n");
                }
            }
        }

        private void chkAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (chkAmarillo.Checked)
                {
                    
                    port.Write("#LED2ON\n");
                    pbAmarillo.Image = HMIMaterialSkin.Properties.Resources.AmarilloOn;
                }
                else
                {
                    port.Write("#LED2OF\n");
                    pbAmarillo.Image = HMIMaterialSkin.Properties.Resources.AmarilloOff;
                }
            }

        }

        private void chkVerde_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (chkVerde.Checked)
                {
                    port.Write("#LED3ON\n");
                    pbVerde.Image = HMIMaterialSkin.Properties.Resources.VerdeOn;
                }
                else
                {
                    port.Write("#LED3OF\n");
                    pbVerde.Image = HMIMaterialSkin.Properties.Resources.VerdeOff;
                }
            }
        }



        private void enableControls()
        {
            chkRed.Enabled = true;
            chkAmarillo.Enabled = true;
            chkVerde.Enabled = true;
            gbLEDs.Enabled = true;
            pbRojo.Enabled = true;
            pbAmarillo.Enabled = true;
            pbVerde.Enabled = true;


        }

        private void disableControls()
        {
            chkRed.Enabled = false;
            chkAmarillo.Enabled = false;
            chkVerde.Enabled = false;;
            gbLEDs.Enabled = false;
            pbRojo.Enabled = false;
            pbAmarillo.Enabled = false;
            pbVerde.Enabled = false;
        }


        private void resetDefaults()
        {
            chkRed.Checked = false;
            chkAmarillo.Checked = false;
            chkVerde.Checked = false;
            pbVerde.Image = HMIMaterialSkin.Properties.Resources.VerdeOff;
            pbAmarillo.Image = HMIMaterialSkin.Properties.Resources.AmarilloOff;
            pbRojo.Image = HMIMaterialSkin.Properties.Resources.RojoOff;

        }

    }
}

