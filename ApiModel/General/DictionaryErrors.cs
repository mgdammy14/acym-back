using System;
using System.Collections.Generic;

namespace ApiModel.General
{
    public class DictionaryErrors
    {
        public Dictionary<String, string> Login = new Dictionary<string, string>
        {
            {"unAuthorized", "El usuario o la clave ingresada es incorrecta"}
        };
    }
}
