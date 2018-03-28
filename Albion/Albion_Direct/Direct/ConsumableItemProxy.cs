////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.357.114734-prod
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
    /* Internal type: axx */
    public partial class ConsumableItemProxy : SimpleItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private axx _internal;
        
        #region Properties
        
        public axx ConsumableItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ConsumableItemProxy(axx instance) : base(instance)
        {
            _internal = instance;
        }
        
        static ConsumableItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator axx(ConsumableItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ConsumableItemProxy(axx instance)
        {
            return new ConsumableItemProxy(instance);
        }
        
        public static implicit operator bool(ConsumableItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
