using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class ObjectEntensions
{
    public static bool HasValue(this object obj)
    {
        if (obj == null)
            return false;

        return true;
    }
    
}