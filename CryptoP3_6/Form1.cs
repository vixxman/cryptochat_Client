using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using CyptoProtocols_1;

namespace CryptoP3_6
{
    public partial class Form1 : Form
    {
        private Socket socket;
        private EndPoint localPoint, remotePoint, trentPoint;
        private int Kt, K, Ra, Rb;
        private bool takeRa = false;
        private bool takeBa = false;
        private bool init = true;

        string firstMsg = "";

        string name = "";
        string friendName = "";

        public void setNames(string youName, string friendName)
        {
            this.name = youName;
            this.friendName = friendName;
            Kt = (name + "trent").GetHashCode() & 0x7FFFFFFF;
        }


        public EndPoint setLocalPont
        {
            set
            {
                localPoint = value;
            }
        }

        public EndPoint setRemotePoint
        {
            set
            {
                remotePoint = value;
            }
        }

        public EndPoint setTrentPoint
        {
            set
            {
                trentPoint = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            sendButton.Enabled = false;
            StartButton.Enabled = false;

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

        }

       /* public void FirstCallBack(IAsyncResult aRes)
        {
            try
            {

                int size = socket.EndReceiveFrom(aRes, ref remotePoint);
                byte[] buf = new byte[50];
                if (size > 0)
                {
                    byte[] recData = new byte[64];
                    recData = (byte[])aRes.AsyncState;

                    ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
                    string msg = aSCIIEncoding.GetString(recData);
                    if (initK)
                    {
                        if (initX)
                        {
                            if (initNG)
                            {
                                string[] ng = msg.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                                n = Convert.ToInt64(ng[0]);
                                g = Convert.ToInt64(ng[1]);
                                initNG = false;
                                //msgList.Items.Add("Friend: " + msg);
                                socket.BeginReceiveFrom(buf, 0, buf.Length, SocketFlags.None, ref remotePoint, new AsyncCallback(FirstCallBack), buf);
                                return;
                            }
                            if (x == 0)
                            {
                                Random r = new Random();
                                x = r.Next(500000, 5000000);
                                X = CryptoMath.PowerMod(g, x, n);
                                ASCIIEncoding asc = new ASCIIEncoding();
                                byte[] msgT = new byte[1500];
                                msgT = asc.GetBytes(X.ToString());
                                socket.Send(msgT);
                                socket.BeginReceiveFrom(buf, 0, buf.Length, SocketFlags.None, ref remotePoint, new AsyncCallback(FirstCallBack), buf);

                            }
                            string xf = aSCIIEncoding.GetString(recData);
                            XF = Convert.ToInt64(xf);
                            //msgList.Items.Add("Friend XF: " + xf);
                            initX = false;

                        }
                        Ki = CryptoMath.PowerMod(XF, x, n);
                        initK = false;
                        socket.BeginReceiveFrom(buf, 0, buf.Length, SocketFlags.None, ref remotePoint, new AsyncCallback(FirstCallBack), buf);
                        return;
                    }
                    byte[] msgb = crypt(recData, Ki);
                    msg = aSCIIEncoding.GetString(msgb);
                    msgList.Items.Add("Friend: " + msg);
                }

                socket.BeginReceiveFrom(buf, 0, buf.Length, SocketFlags.None, ref remotePoint, new AsyncCallback(FirstCallBack), buf);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }*/

        private void sendButton_Click(object sender, EventArgs e)
        {

            try
            {
                ASCIIEncoding asc = new ASCIIEncoding();
                Random r = new Random();
                Ra = r.Next(100000, 99999999);
                byte[] buf = new byte[50];
                if (firstMsg=="")
                {
                    socket.Connect(trentPoint);
                    firstMsg = textBoxMessage.Text;
                    string msg = name + ':' + friendName + ':' + Ra.ToString();
                    //msgList.Items.Add("Отправили тренту");
                    takeRa = true;
                    takeBa = true;
                    socket.SendTo(asc.GetBytes(msg), trentPoint);
                    socket.BeginReceiveFrom(buf, 0, buf.Length, SocketFlags.None, ref trentPoint, new AsyncCallback(KeyCallBack), buf);
                    textBoxMessage.Clear();
                }
                else
                {
                    //byte[] msg = new byte[1500];
                    byte[] cMsg = crypt(textBoxMessage.Text, K);
                    //msg = asc.GetBytes(cMsg);
                    socket.SendTo(cMsg,remotePoint);
                    msgList.Items.Add("You: " + textBoxMessage.Text);
                    textBoxMessage.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                socket.Bind(localPoint);
                socket.Connect(remotePoint);
                
                //checkClient();
                byte[] buf = new byte[256];
                //cryptoProtocolsInit();
                StartButton.Text = "Connected";
                StartButton.Enabled = false;
                socket.BeginReceiveFrom(buf, 0, buf.Length, SocketFlags.None, ref remotePoint, new AsyncCallback(KeyCallBack), buf);
                //getKey();
                sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void KeyCallBack(IAsyncResult aRes)
        {
            try
            {
                int size = socket.EndReceiveFrom(aRes, ref trentPoint);
                Thread.Sleep(700);
                socket.Connect(remotePoint);
                byte[] buf = new byte[128];
                Random r = new Random();
                if (size > 0)
                {
                    byte[] recData = new byte[128];
                    recData = (byte[])aRes.AsyncState;
                    ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
                    if (init)
                    {
                        if (firstMsg == "")
                        {
                            recData = recData.Skip(1).ToArray();
                            byte[] decrMsg = crypt(recData, Kt);
                            string dMsg = aSCIIEncoding.GetString(decrMsg);
                            string[] g = dMsg.Split(':');
                            K = Convert.ToInt32(g[0]);
                            Rb = r.Next(10000, 9999999);
                            byte[] crMsg = crypt(Rb.ToString(), K);
                            socket.SendTo(crMsg, remotePoint);
                            socket.BeginReceiveFrom(buf, 0, buf.Length, SocketFlags.None, ref remotePoint, new AsyncCallback(KeyCallBack), buf);
                            firstMsg = "1";
                            return;
                        }
                        if (takeRa)
                        {
                            byte[] decrMsg = crypt(recData, Kt);
                            int n = Array.LastIndexOf(decrMsg, (byte)58);
                            byte[] b = decrMsg.Take(n).ToArray();
                            byte[] b2 = decrMsg.Skip(n).ToArray();
                            string[] dMsg = aSCIIEncoding.GetString(b).Split(':');
                            takeRa = false;
                            if (Ra.ToString() != dMsg[0])
                            {
                                MessageBox.Show("Ra не совпадает!");
                                return;
                            }
                            else
                            {
                                K = Convert.ToInt32(dMsg[2]);
                                socket.SendTo(b2, remotePoint);
                                socket.BeginReceiveFrom(buf, 0, buf.Length, SocketFlags.None, ref remotePoint, new AsyncCallback(KeyCallBack), buf);
                                return;
                            }
                        }
                        if (takeBa)
                        {
                            //byte[] recData = new byte[128];
                            recData = (byte[])aRes.AsyncState;
                            //ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
                            byte[] decrMsg = crypt(recData, K);
                            byte[] b = new byte[decrMsg.Length];
                            for (int i = 0; i < decrMsg.Length; i++)
                            {
                                if (48 > decrMsg[i] || decrMsg[i] > 57)
                                {
                                    Array.Copy(decrMsg, b, i);
                                    break;
                                }
                            }
                            string s = aSCIIEncoding.GetString(b);
                            int Rb_1 = Convert.ToInt32(s) - 1;
                            socket.SendTo(crypt(Rb_1.ToString(), K), remotePoint);
                            msgList.Items.Add("Ключ установлен!");
                            decrMsg = crypt(firstMsg, K);
                            init = false;
                            socket.SendTo(decrMsg, remotePoint);
                            msgList.Items.Add("You: " + firstMsg);
                            socket.BeginReceiveFrom(buf, 0, buf.Length, SocketFlags.None, ref remotePoint, new AsyncCallback(KeyCallBack), buf);
                        }
                        else
                        {
                            byte[] decrMsg = crypt(recData, K);
                            byte[] b = new byte[decrMsg.Length];
                            takeBa = false;
                            for (int i = 0; i < decrMsg.Length; i++)
                            {
                                if (48 > decrMsg[i] || decrMsg[i] > 57)
                                {
                                    Array.Copy(decrMsg, b, i);
                                    break;
                                }
                            }
                            string s = aSCIIEncoding.GetString(b);
                            if (Rb != Convert.ToInt32(s) + 1)
                            {
                                MessageBox.Show("Rb не совпадает!");
                                return;
                            }
                            else
                            {
                                msgList.Items.Add("Ключ установлен!");
                                init = false;
                                socket.BeginReceiveFrom(buf, 0, buf.Length, SocketFlags.None, ref remotePoint, new AsyncCallback(KeyCallBack), buf);
                                return;
                            }
                        }

                    }
                    else
                    {
                        byte[] encA = crypt(recData, K);
                        string rA = aSCIIEncoding.GetString(encA);
                        if (rA.IndexOf('?') != -1) {
                            rA = rA.Substring(0,rA.IndexOf('?'));
                        }
                        else if (rA.IndexOf('\t') != -1)
                        {
                            rA = rA.Substring(0,rA.IndexOf('\t'));
                        }
                        msgList.Items.Add(friendName + ": " + rA);
                        socket.BeginReceiveFrom(buf, 0, buf.Length, SocketFlags.None, ref remotePoint, new AsyncCallback(KeyCallBack), buf);
                        return;
                    }
                }
                //socket.BeginReceiveFrom(buf, 0, buf.Length, SocketFlags.None, ref trentPoint, new AsyncCallback(KeyCallBack), buf);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        

        private void settingsB_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(this);
            settings.Show();
        }

        private byte[] crypt(string s, int k)
        {
            ASCIIEncoding asc = new ASCIIEncoding();
            byte[] encod = asc.GetBytes(s);
            byte[] bs = BitConverter.GetBytes(k);
            for (int i = 0; i < encod.Length; i++)
            {
                encod[i] = (byte)(encod[i] ^ bs[0]);
            }
            return encod;
        }

        private byte[] crypt(byte[] s, int k)
        {
            byte[] bs = BitConverter.GetBytes(k);
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = (byte)(s[i] ^ bs[0]);
            }
            return s;
        }

        /*private void cryptoProtocolsInit()
        {
            try
            {
                //n = CryptoMath.GBC(5000000);
                //g = CryptoMath.GetSRoot(n);
                n = 161771;
                g = 6;
                string s = n.ToString() + ':' + g.ToString();
                ASCIIEncoding asc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = asc.GetBytes(s);
                socket.SendTo(msg,trentPoint);
                initNG = false;
                Random r = new Random();
                x = r.Next(5000000, 10000000);
                long X = CryptoMath.PowerMod(g, x, n);
                msg = asc.GetBytes(X.ToString());
                //Thread.Sleep(2000);
                socket.SendTo(msg, trentPoint);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }*/
    }
}
