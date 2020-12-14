using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Services
{
    public class EmailSenderOptions
    {
        public string SENDGRID_KEY { get; set; }
        public string SENDGRID_EMAIL { get; set; }
        public string SENDGRID_NAME { get; set; }
    }
}
