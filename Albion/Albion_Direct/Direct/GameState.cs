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

namespace Albion_Direct
{
    /* Internal type: apo */
    public enum GameState
    {
        Unknown = 0,
        LoggingIn = 1,
        Loading = 2,
        Playing = 3
    }
    
    public static class GameStateExtensions
    {
        public static apo ToInternal(this GameState instance)
        {
            return (apo)instance;
        }
        
        public static GameState ToWrapped(this apo instance)
        {
            return (GameState)instance;
        }
    }
}
