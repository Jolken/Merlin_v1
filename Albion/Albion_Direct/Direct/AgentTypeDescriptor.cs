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
    /* Internal type: dd */
    public partial class AgentTypeDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private dd _internal;
        
        #region Properties
        
        public dd AgentTypeDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public AgentTypeDescriptor(dd instance)
        {
            _internal = instance;
        }
        
        static AgentTypeDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator dd(AgentTypeDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator AgentTypeDescriptor(dd instance)
        {
            return new AgentTypeDescriptor(instance);
        }
        
        public static implicit operator bool(AgentTypeDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
