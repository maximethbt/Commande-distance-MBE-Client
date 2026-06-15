using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Commande_distance_MBE_Client
{
    internal class MBEClient
    {
        private NetworkStream stream;
        private TcpClient client;
        private byte[] buffer = new byte[1024];
        public bool IsConnected { get; private set; } = false;

        public MBEClient(string IP, int Port)
        {
            client = new TcpClient();

            try
            {
                client.Connect(IP, Port);
                client.NoDelay = true;
                stream = client.GetStream();
                IsConnected = true;
            }
            catch (Exception ex)
            {
                IsConnected = false;
            }
        }

        public bool SendMessage(string Message)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(Message);
            try
            {
                stream.Write(messageBytes, 0, messageBytes.Length);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Image RequestImage(int screen)
        {
            try
            {
                byte[] buf = new byte[5];
                buf[0] = 0x01;
                Buffer.BlockCopy(BitConverter.GetBytes(screen), 0, buf, 1, 4);
                stream.Write(buf, 0, 5);

                byte[] sizeBytes = new byte[4];
                stream.Read(sizeBytes, 0, 4);
                int size = BitConverter.ToInt32(sizeBytes, 0);

                // Lire l'image
                byte[] imageBytes = new byte[size];
                int total = 0;
                while (total < size)
                {
                    int n = stream.Read(imageBytes, total, size - total);
                    if (n == 0) break;
                    total += n;
                }

                // Afficher
                MemoryStream ms = new MemoryStream(imageBytes);
                Image img = Image.FromStream(ms);
                return img;
            }
            catch
            {
                return null;
            }
        }

        public string ReadResponse()
        {
            try
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0) return null;
                return Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
            catch
            {
                return null;
            }
        }

        public bool SendMouseMove(int x, int y)
        {
            try
            {
                byte[] buf = new byte[9];
                buf[0] = 0x02;
                Buffer.BlockCopy(BitConverter.GetBytes(x), 0, buf, 1, 4);
                Buffer.BlockCopy(BitConverter.GetBytes(y), 0, buf, 5, 4);
                stream.Write(buf, 0, 9);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SendClick(bool PressorRelease, int button)
        {
            try
            {
                if (PressorRelease)
                {
                    switch (button)
                    {
                        case 1:
                            stream.WriteByte(0x10);
                            break;

                        case 2:
                            stream.WriteByte(0x11);
                            break;

                        case 3:
                            stream.WriteByte(0x12);
                            break;
                    }
                }
                else
                {
                    switch (button)
                    {
                        case 1:
                            stream.WriteByte(0x20);
                            break;

                        case 2:
                            stream.WriteByte(0x21);
                            break;

                        case 3:
                            stream.WriteByte(0x22);
                            break;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SendKey(bool PressedorReleased, int Keycode)
        {
            if (PressedorReleased)
            {
                try
                {
                    byte[] buf = new byte[5];
                    buf[0] = 0x30;
                    Buffer.BlockCopy(BitConverter.GetBytes(Keycode), 0, buf, 1, 4);
                    stream.Write(buf, 0, 5);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    byte[] buf = new byte[5];
                    buf[0] = 0x40;
                    Buffer.BlockCopy(BitConverter.GetBytes(Keycode), 0, buf, 1, 4);
                    stream.Write(buf, 0, 5);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        // === Demande au serveur s'il a un fichier à envoyer ===
        public string PollFile(string receptionFolder)
        {
            try
            {
                stream.WriteByte(0x03);
                int flag = stream.ReadByte();
                if (flag <= 0) return null;                          // 0 = rien, -1 = déconnecté

                int nameLen = BitConverter.ToInt32(ReadExact(4), 0);
                string name = Encoding.UTF8.GetString(ReadExact(nameLen));
                int size = BitConverter.ToInt32(ReadExact(4), 0);
                byte[] fileBytes = ReadExact(size);

                string dest = Path.Combine(receptionFolder, Path.GetFileName(name));
                File.WriteAllBytes(dest, fileBytes);
                return dest;
            }
            catch { return null; }
        }

        private byte[] ReadExact(int n)
        {
            byte[] buf = new byte[n];
            int total = 0;
            while (total < n)
            {
                int r = stream.Read(buf, total, n - total);
                if (r <= 0) throw new Exception("Disconnected");
                total += r;
            }
            return buf;
        }

        public void Close()
        {
            if (stream != null) stream.Close();
            if (client != null) client.Close();
        }
    }
}