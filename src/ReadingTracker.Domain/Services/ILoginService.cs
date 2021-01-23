using System;
using System.Collections.Generic;
using System.Text;

namespace ReadingTracker.Domain.Services
{
    public interface ILoginService
    {
        int doLogin(string email, string senha);
    }
}
