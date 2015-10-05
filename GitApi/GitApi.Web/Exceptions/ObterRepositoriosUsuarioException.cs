using System;

namespace GitApi.Web.Exceptions
{
    public class ObterRepositoriosUsuarioException : Exception
    {
        public ObterRepositoriosUsuarioException(string erro)
            : base(erro)
        {

        }
    }
}