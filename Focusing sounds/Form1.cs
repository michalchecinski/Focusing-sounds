using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Focusing_sounds
{
    public partial class Form1 : Form
    {
        //names for trayIcon and trayMenu
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;

        public Form1()
        {
            InitializeComponent();

            //hided window, not showing in app drawer
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            //name of the tray icon
            this.Text = "Focusing sounds";

            //creating icon in tray
            trayIcon = new NotifyIcon();
            trayIcon.Text = "Focusing sounds";
            trayIcon.Icon = new Icon(@"tray.ico", 40, 40);

            //menu in tray
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Cafe", OnPlay1);
            trayMenu.MenuItems.Add("Rain", OnPlay2);
            trayMenu.MenuItems.Add("Ocean", OnPlay3);
            trayMenu.MenuItems.Add("Stop", OnStop);
            trayMenu.MenuItems.Add("About", AboutShow);
            trayMenu.MenuItems.Add("Exit", OnExit);

            //setting icon menu as trayMenu
            trayIcon.ContextMenu = trayMenu;
            //visibility icon in tray
            trayIcon.Visible = true;

        }

        Player player = new Player();

        string aboutFile = File.ReadAllText(@"about.txt");

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutShow(object sender, EventArgs e)
        {
            MessageBox.Show(aboutFile,"About");
        }

        private void OnPlay1(object sender, EventArgs e)
        {
            player.play_sound("cafe");
        }

        private void OnPlay2(object sender, EventArgs e)
        {
            player.play_sound("rain");
        }

        private void OnPlay3(object sender, EventArgs e)
        {
            player.play_sound("ocean");
        }

        private void OnStop(object sender, EventArgs e)
        {
            player.Stop();
        }

    }
}
