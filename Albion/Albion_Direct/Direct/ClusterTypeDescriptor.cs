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
    /* Internal type: ri */
    public partial class ClusterTypeDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ri _internal;
        
        #region Properties
        
        public ri ClusterTypeDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public PvpRules GetPvpRules() => _internal.ap().ToWrapped();
        
        #endregion
        
        #region Constructor
        
        public ClusterTypeDescriptor(ri instance)
        {
            _internal = instance;
        }
        
        static ClusterTypeDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ri(ClusterTypeDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ClusterTypeDescriptor(ri instance)
        {
            return new ClusterTypeDescriptor(instance);
        }
        
        public static implicit operator bool(ClusterTypeDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
