using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin101.Services
{
    public interface IFacebookLoginService
    {
        string AccessToken { get; }
        Action<string, string> AccessTokenChanged { get; set; }
        void Logout();

    }
}
