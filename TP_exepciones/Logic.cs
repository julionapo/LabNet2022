using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_exepciones
{
    public class Logic:Exception
    {
        public Logic():base("Aca estoy en la base ")
        {
              
        }

        public void Ejercicio3()
        {
            throw new NotImplementedException();
        }

        public string Message(Exception ex)
        {
            string msg = "";
            msg = Convert.ToString("Ubicacion y nombre de la excepcion: "+ex.GetType())+"Mensaje del ejercicio 4 excepcion gral. :"+ex.Message;

            return msg;

        }
           
    }
}
