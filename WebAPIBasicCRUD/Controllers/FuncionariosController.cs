using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIBasicCRUD.Models;

namespace WebAPIBasicCRUD.Controllers
{
    public class FuncionariosController : ApiController
    {
        //static list
        private static List<Funcionario> fun = new List<Funcionario>();

        //get all
        public List<Funcionario> Get()
        {
            return fun;
        }

        //create
        public HttpResponseMessage Post ( string name, string email, string department)
        {

            //Any blank field = err
            if ((string.IsNullOrEmpty(name)) || (string.IsNullOrEmpty(email)) || (string.IsNullOrEmpty(department)))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Check empty fields!");
            }
            else
            {
                fun.Add(new Funcionario( name, email, department));
                return Request.CreateResponse(HttpStatusCode.Created, "Employee Created.");
            }
        }

        //delete by name
        public HttpResponseMessage Delete(string name)
        {

            //blank field = err
            if (string.IsNullOrEmpty(name))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Could not find a employee to delete");
            }
            else
            {
                fun.RemoveAt(fun.IndexOf(fun.First(x => x.Name.Equals(name))));
                return Request.CreateResponse(HttpStatusCode.OK, "Employee Deleted");
            }

        }
    }
}

