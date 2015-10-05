using System;

namespace GitApi.Web.Exceptions
{
    public class ObterPorNomeException:Exception        
    {
        public ObterPorNomeException(string error)
            : base(error)
        {

        }
    }
}