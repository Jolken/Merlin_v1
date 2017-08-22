////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.94396-live
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

namespace Merlin.API.Direct
{
    /* Internal type: azo */
    public partial class StaticObject : WorldObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private azo _internal;
        
        #region Properties
        
        public azo StaticObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public StaticObject(azo instance) : base(instance)
        {
            _internal = instance;
        }
        
        static StaticObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator azo(StaticObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator StaticObject(azo instance)
        {
            return new StaticObject(instance);
        }
        
        public static implicit operator bool(StaticObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}