using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FLARE_WIN
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "Help":
                    AboutBox FAbout = new AboutBox();
                    FAbout.ShowDialog();
                    break;
                case "Option":
                    tabControlMain.SelectedTab = tabPage_option;
                    break;
                case "Setup":
                    tabControlMain.SelectedTab = tabPage_setup;
                    break;

            }
        }

        private void tabPage_home_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FLARE_CFILE.FlareCFILE a = new FLARE_CFILE.FlareCFILE();
            a.FCODE = "001";

            FLARE_TYPE.FlareMinute m = new FLARE_TYPE.FlareMinute();

            m.辨別碼 = "93";
            m.管道編號 ="A001";
            m.格式碼 ="A979";
            m.日期 = "1030303";
            m.時間 = "0000";
            m.平均值 = "88.33";
            string b = a.MakeMinuteFormat(m);

            List<string> s = new List<string> ();
            s.Add(b);
            s.Add(b);
            s.Add(b);
            s.Add(b);

            a.MakeRealFile(DateTime.Now, s);
        }

    }
}
