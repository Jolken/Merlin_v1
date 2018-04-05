////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.357.115208-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Albion_Direct
{
    /* Internal type: axl */
    public partial class ItemObject : SimulationObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private axl _internal;
        
        #region Properties
        
        public axl ItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ItemObject(axl instance) : base(instance)
        {
            _internal = instance;
        }
        
        static ItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator axl(ItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ItemObject(axl instance)
        {
            return new ItemObject(instance);
        }
        
        public static implicit operator bool(ItemObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
