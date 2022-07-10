using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.APPLICATION.Base.Interfaces
{
    public interface IPermissionService
    {
        bool VerifyPermission(string role, string controller, string action);
    }
}
