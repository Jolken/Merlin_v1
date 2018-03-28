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
    /* Internal type: er */
    public partial class ConsumableItemDescriptor : SimpleItemDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private er _internal;
        
        #region Properties
        
        public er ConsumableItemDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ConsumableItemDescriptor(er instance) : base(instance)
        {
            _internal = instance;
        }
        
        static ConsumableItemDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator er(ConsumableItemDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ConsumableItemDescriptor(er instance)
        {
            return new ConsumableItemDescriptor(instance);
        }
        
        public static implicit operator bool(ConsumableItemDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
