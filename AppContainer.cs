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
        // yeni bir sayfa açmak için kullanýlan kodlar
        public override TitleBarTab CreateTab()
        {
            throw new NotImplementedException();
            {
                return new TitleBarTab(this)
                {
                    // diðer forma geçmek için
                    Content = new frmBrowser
                    {
                      Text = "Yeni Sayfa"
                    }


        private void AppContainer_Load(object sender, EventArgs e)
        {

        }
    }
}