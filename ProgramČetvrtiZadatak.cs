using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Četvrti_zadatak_RPPOON_LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleNotification consoleNotofication = new ConsoleNotification("Luka Š", "Poruka", "Bok!", new DateTime(), Category.INFO, ConsoleColor.Cyan);
            NotificationManager notificationManager = new NotificationManager();
            notificationManager.Display(consoleNotofication);
        }
    }
}
