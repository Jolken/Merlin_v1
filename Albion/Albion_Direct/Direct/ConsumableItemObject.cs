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
    /* Internal type: axn */
    public partial class ConsumableItemObject : SimpleItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private axn _internal;
        
        #region Properties
        
        public axn ConsumableItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ConsumableItemObject(axn instance) : base(instance)
        {
            _internal = instance;
        }
        
        static ConsumableItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator axn(ConsumableItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ConsumableItemObject(axn instance)
        {
            return new ConsumableItemObject(instance);
        }
        
        public static implicit operator bool(ConsumableItemObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
