using System;

namespace GitApi.Web.Exceptions
{
    public class ObterColaboradoresException : Exception
    {
        public ObterColaboradoresException(string erro)
            : base(erro)
        {

        }
    }
}