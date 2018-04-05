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
    /* Internal type: ahb */
    public partial class MobCharacterAttributes : FightingAttributes
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ahb _internal;
        
        #region Properties
        
        public ahb MobCharacterAttributes_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public MobCharacterAttributes(ahb instance) : base(instance)
        {
            _internal = instance;
        }
        
        static MobCharacterAttributes()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ahb(MobCharacterAttributes instance)
        {
            return instance._internal;
        }
        
        public static implicit operator MobCharacterAttributes(ahb instance)
        {
            return new MobCharacterAttributes(instance);
        }
        
        public static implicit operator bool(MobCharacterAttributes instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
