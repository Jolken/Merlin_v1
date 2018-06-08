////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.362.118917-prod
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
    /* Internal type: cw */
    public partial class SpellDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private cw _internal;
        
        #region Properties
        
        public cw SpellDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public string GetIdent() => _internal.k6();
        public string GetName() => _internal.k7();
        public string GetNameTag() => (string)_methodReflectionPool[0].Invoke(_internal,new object[]{});
        
        #endregion
        
        #region Constructor
        
        public SpellDescriptor(cw instance)
        {
            _internal = instance;
        }
        
        static SpellDescriptor()
        {
            _methodReflectionPool.Add(typeof(cw).GetMethod("jb", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance, null, new Type[]{}, null));
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator cw(SpellDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SpellDescriptor(cw instance)
        {
            return new SpellDescriptor(instance);
        }
        
        public static implicit operator bool(SpellDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
