using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace browser
{
    public partial class AppContainer : TitleBarTabs    
    {
        public AppContainer()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }
        // yeni bir sayfa a�mak i�in kullan�lan kodlar
        public override TitleBarTab CreateTab()
        {
            throw new NotImplementedException();
            {
                return new TitleBarTab(this)
                {
                    // di�er forma ge�mek i�in
                    Content = new frmBrowser
                    {
                      Text = "Yeni Sayfa"
                    }


        private void AppContainer_Load(object sender, EventArgs e)
        {

        }
    }
}