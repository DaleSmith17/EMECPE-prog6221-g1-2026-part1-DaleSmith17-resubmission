using System;
using System.Collections.Generic;
using System.Text;

namespace PROG_Pt1_RESUBMISSION
{
    public class AsciiArtDisplay
    {
        public void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
_________        ___.                 _________                          .__  __          
\_   ___ \___.__.\_ |__   ___________/   _____/ ____   ____  __ _________|__|/  |_ ___.__.
/    \  \<   |  | | __ \_/ __ \_  __ \_____  \_/ __ \_/ ___\|  |  \_  __ \  \   __<   |  |
\     \___\___  | | \_\ \  ___/|  | \/        \  ___/\  \___|  |  /|  | \/  ||  |  \___  |
 \______  / ____| |___  /\___  >__| /_______  /\___  >\___  >____/ |__|  |__||__|  / ____|
        \/\/          \/     \/             \/     \/     \/                       \/     
            ");
            Console.ResetColor();
        }
    }
}
