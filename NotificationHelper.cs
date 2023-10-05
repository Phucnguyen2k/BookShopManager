using System.Drawing;
using System.Windows.Forms;

namespace BookShopManager
{
    internal class NotificationHelper
    {
        public static void ShowNotification(string title, string message, ToolTipIcon icon)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.BalloonTipText = message;
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(2000);
        }
    }
}
