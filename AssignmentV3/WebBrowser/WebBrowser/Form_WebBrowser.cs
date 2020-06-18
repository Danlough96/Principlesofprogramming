using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentV3;//this is a reference to the main form

namespace WebBrowser
{
    public partial class Form_WebBrowser : Form
    {
        public Form_WebBrowser()
        {
            InitializeComponent();
        }
        private void btn_MainMenu_Click_1(object sender, EventArgs e)
        {
            this.Close();//this closes current form
            Form_MainMenu main = new Form_MainMenu();//sets main to = new main form
            main.Show();//shows main
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            wb_Browser.GoBack();//this tells the browser to go backwards
        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            wb_Browser.GoForward();//this tells the browser to go forward
        }

        private void txt_Web_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            wb_Browser.Refresh();// this will refresh the web page
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            wb_Browser.Navigate(txt_Web.Text);// this will search what ever has been typed into txt_Web
        }

       

    
    }
}
