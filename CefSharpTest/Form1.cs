using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CefSharpTest
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public Form1()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser(/*Can insert your URL here*/); 
            panel1.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            //chromeBrowser.LoadHtml();   <for HTML>
            chromeBrowser.Load("google.com"); // <for URL>
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
