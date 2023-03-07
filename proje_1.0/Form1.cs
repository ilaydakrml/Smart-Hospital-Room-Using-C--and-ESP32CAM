using Microsoft.VisualBasic;
using System.IO.Ports;
using System.Net;
using System.Net.Mail;
using System;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace proje_1._0
{
    public partial class Form1 : Form
    {
        public SerialPort mySerialPort = new SerialPort("COM1");


        // initialize variables
        int nabiz = 0;
        int temp  = 0;
        int ldr   = 0;
        bool photoFlag = false;

        public Form1()
        {
            InitializeComponent();
            connectedPorts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // çalışır çalışmaz burası çalışır
            // serial port ayarlamaları burada yapılır
            // parse işlemi burada yapılacak
            // döngü içerisine al içerisine al thread kullanılacak            
            // fonksiyonu thread de çalıştırma
            // Alert olacak
            // 
            /*
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM4";//Set your board COM
            _serialPort.BaudRate = 9600;
            _serialPort.Open();
            uartRead = _serialPort.ReadExisting();
            nabizLabel.Text = uartRead.ToString();
            nabizLabel.Update();
            Thread.Sleep(200);
            */

            CheckForIllegalCrossThreadCalls = false;
 
 
        }

        private void button1_Click(object sender, EventArgs e) //email butonu
        {
            try
            {
                
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("sinankazan171@gmail.com");
                mail.To.Add(mailBox.Text);
                mail.Subject = "Hasta Durumu";
                mail.Body = "Hasta Nabzı = " + nabiz;
                

                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("sinankazan171@gmail.com", "kwnvzzhkjhrydacg");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            


        }


        private void ldrLow_Click(object sender, EventArgs e)
        {
            int send = 30;
            byte[] str = BitConverter.GetBytes(send);
            mySerialPort.Write(str, 0, 4);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            /*(base64)
             *  ESP ye Komut yolla.
                ESP den fotoğraf çek.
                ESP deki formatı base64 dönüştür.string gönder
                base64 to pic 
             */

            int send = 11;
            byte[] str = BitConverter.GetBytes(send);
            mySerialPort.Write(str, 0, 4);
            photoFlag = true;
            pictureBox.Refresh();


            //pictureBox.Image = Image.FromFile("C:\\Users\\sknkz\\Downloads\\reset.jpg");
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            textBox_alert.Text = Environment.NewLine;
            textBox_alert.Text = "Fotoğraf Çekildi" + Environment.NewLine;            

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int send = 40;
            byte[] str = BitConverter.GetBytes(send);
            mySerialPort.Write(str, 0, 4);

        }

        private void mailBox_MouseClick(object sender, MouseEventArgs e)
        {
            mailBox.Clear();
        }

        private void fanClose_Click(object sender, EventArgs e)
        {
            int send = 20;
            byte[] str = BitConverter.GetBytes(send);
            mySerialPort.Write(str, 0, 4);
        }

        private void fanLow_Click(object sender, EventArgs e)
        {
            int send = 21;
            byte[] str = BitConverter.GetBytes(send);
            mySerialPort.Write(str, 0, 4);
        }

        private void fanHigh_Click(object sender, EventArgs e)
        {
            int send = 22;
            byte[] str = BitConverter.GetBytes(send);
            mySerialPort.Write(str, 0, 4);
        }

        private void ldrLow_Click_1(object sender, EventArgs e)
        {
            int send = 31;
            byte[] str = BitConverter.GetBytes(send);
            mySerialPort.Write(str, 0, 4);
        }

        private void ldrHigh_Click(object sender, EventArgs e)
        {
            int send = 32;
            byte[] str = BitConverter.GetBytes(send);
            mySerialPort.Write(str, 0, 4);
        }

        private void buzzerLow_Click(object sender, EventArgs e)
        {
            int send = 41;
            byte[] str = BitConverter.GetBytes(send);
            mySerialPort.Write(str, 0, 4);
        }

        private void buzzerHigh_Click(object sender, EventArgs e)
        {
            int send = 42;
            byte[] str = BitConverter.GetBytes(send);
            mySerialPort.Write(str, 0 ,4);


        }


        //
        public void Uart()
        {
            mySerialPort.PortName = comboCOM.Text;
            mySerialPort.BaudRate = comboBaud.SelectedIndex;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (photoFlag == false)
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadLine();
                string[] parseData = indata.Split(',');

                try
                {
                    nabiz = int.Parse(parseData[1]);
                    temp = int.Parse(parseData[2]);
                    ldr = int.Parse(parseData[3]);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                //textBox_alert.Text = indata.ToString();
                nabizLabel.Text     = "Nabız = " + nabiz;
                SicaklikLabel.Text  = "Sıcaklık = " + temp;
                LDRLabell.Text      = "ışık = " + ldr;


                if (nabiz < 45)
                {
                    //MessageBox.Show("Hastayı Kontrol Et !!!");
                    //textBox_alert.Clear();
                    textBox_alert.AppendText("!!! Hasta Bayıldı !!!" + Environment.NewLine) ;
                    textBox_alert.Update();


                    //MessageBox.Show("HASTA BAYILDI");
                }

                if (temp < 15)
                {
                    //textBox_alert.Clear();
                    textBox_alert.AppendText("!!! Sıcaklık Düşük !!!" + Environment.NewLine);
                    textBox_alert.Update();
                    

                    //MessageBox.Show("SICAKLIK DÜŞTÜ");
                }

                if (temp > 30)
                {
                    //textBox_alert.Clear();
                    textBox_alert.AppendText("!!! Sıcaklık Yüksek !!!" + Environment.NewLine);
                    textBox_alert.Update();
                    

                }

                if (ldr < 150)
                {
                    //textBox_alert.Clear();
                    textBox_alert.AppendText("!!! Oda Karanlık !!!" + Environment.NewLine);
                    textBox_alert.Update();
                    
                    //MessageBox.Show("ODAYI AYDINLAT");
                }

                if (ldr < 500 && ldr > 150) 
                {
                    //textBox_alert.Clear();
                    textBox_alert.AppendText("!!! Oda Loş !!!" + Environment.NewLine);
                    textBox_alert.Update();
                    
                    //MessageBox.Show("ODAYI AYDINLAT");
                }

                if (ldr > 500)
                {
                    //textBox_alert.Clear();
                    textBox_alert.AppendText("!!! Oda Aydınlık !!!" + Environment.NewLine);
                    textBox_alert.Update();
                    
                    //MessageBox.Show("ODAYI AYDINLAT");
                }
                Thread.Sleep(700);
                textBox_alert.ResetText();
            }

            else if (photoFlag == true)
            {
                SerialPort im_sp = (SerialPort)sender;
                string image_Data = im_sp.ReadTo("*");
                
                Base64ToImage(image_Data);
                photoFlag = false;

            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Uart();

            mySerialPort.Open();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            mySerialPort.Close();
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]

            //byte[] imageBytes = System.Text.Encoding.Unicode.GetBytes(base64String);
            //Regex regex = new Regex(@"^[\w/\:.-]+;base64,");
            //base64String = regex.Replace(base64String, string.Empty);
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);

            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Update();



            return image;
        }

        private void roleOpen_Click(object sender, EventArgs e)
        {
            int send = 51;
            byte[] str = BitConverter.GetBytes(send);
            mySerialPort.Write(str, 0, 4);
        }

        private void roleClose_Click(object sender, EventArgs e)
        {
            int send = 50;
            byte[] str = BitConverter.GetBytes(send);
            mySerialPort.Write(str, 0, 4);
        }

        private void pictureBox_Click_1(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void connectedPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboCOM.Items.Add(port);
            }
        
        }
  
    }
}


/*
        // open file dialog   
        //OpenFileDialog open = new OpenFileDialog();
        // image filters  
        //open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
        //if (open.ShowDialog() == DialogResult.OK)
        //{
        // display image in picture box  
        //pictureBox = new Bitmap(open.FileName);
        pictureBox.Image = Image.FromFile("C:\\Users\\sknkz\\Downloads\\Reset.jpg");
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        // image file path  
        //textBox_alert.Text = open.FileName;
        // }
 
 */
