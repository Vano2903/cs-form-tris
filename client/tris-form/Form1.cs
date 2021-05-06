using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tris_form {
    public partial class Form1 : Form {
        
        client c = new client();
        public Form1() {
            InitializeComponent();
        }

        private void genGame_Click(object sender, EventArgs e) {
            c.connect();
            c.send("mora UwU");
        }

        private void joinGame_Click(object sender, EventArgs e) {

        }
    }
}
