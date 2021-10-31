using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Exceptions
{
    internal class UnauthorizedException : Exception
    {
        internal enum Reason
        {
            UserNotFound,
            WrongPassword
        }
        public UnauthorizedException(Reason reason) : base(reason.ToString())
        {
            
        }
    }
}
