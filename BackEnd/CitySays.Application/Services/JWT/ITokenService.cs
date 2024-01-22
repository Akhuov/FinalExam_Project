using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySays.Application.Services.JWT
{
    public interface ITokenService
    {
        string Generate(string userName);
    }
}
