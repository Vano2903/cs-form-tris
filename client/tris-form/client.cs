using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace tris_form {
    class client {
        private String username;
        private Socket sender;
        private byte[] bytes = new byte[1024];

        public bool connect() {
            try {
                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = host.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try {
                    sender.Connect(remoteEP);
                } catch (ArgumentNullException ane) {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    return false;
                } catch (SocketException se) {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                    return false;
                } catch (Exception e) {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                    return false;
                }
                this.sender = sender;
                return true;
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public void send(string messaggio) {
            byte[] msg = Encoding.ASCII.GetBytes(messaggio);
            int bytesSent = sender.Send(msg);
        }

        public int genGame(string userName) {
            
            string messaggio = "con" + userName;
            

            int bytesRec = sender.Receive(bytes);
        }
    }
}
