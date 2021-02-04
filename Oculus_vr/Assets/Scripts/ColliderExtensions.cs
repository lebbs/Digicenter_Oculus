using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digicenter.Extensions
{

    public static class ColliderExtensions
    {
        public static bool IsTriggerButton(this Collider col)
        {
            return col.tag == "ButtonActivator";
        }
    }

}

