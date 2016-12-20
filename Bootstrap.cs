using CommunityCoreLibrary_Caerbannog;
using System;
using System.Reflection;
using UnityEngine;
using Verse;

namespace Caerbannog
{
    class Bootstrap : Def
    {
        public string ModName;

        static Bootstrap()
        {
            {
                MethodInfo method1 = typeof(RimWorld.ManhunterPackIncidentUtility).GetMethod("TryFindRandomAnimalKind", BindingFlags.Static | BindingFlags.Public);
                MethodInfo method2 = typeof(ManhunterPackIncidentUtility_Detour).GetMethod("TryFindRandomAnimalKind", BindingFlags.Static | BindingFlags.Public);
                if (!Detours.TryDetourFromTo(method1, method2))
                {
                    Log.Error("EVERYTHING IS BROKEN 1");
                    return;
                }
            }
        }
    }
}
