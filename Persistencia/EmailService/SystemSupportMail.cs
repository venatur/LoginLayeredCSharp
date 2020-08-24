using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.EmailService
{
    class SystemSupportMail:MasterEmailServer
    {
        public SystemSupportMail()
        {
            senderMail = "caldos69@gmail.com";
            password = "venatur69!!";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;

        }
    }
}
