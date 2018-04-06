using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIBasicCRUD.Models
{
    public class Funcionario
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Dep { get; set; }

        public Funcionario ( string name, string mail, string dep)
        {
            this.Name = name;
            this.Mail = mail;
            this.Dep = dep;

        }
    }
}

