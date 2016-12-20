using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace Caerbannog
{
    static class ManhunterPackIncidentUtility_Detour
    {
        public static bool TryFindRandomAnimalKind(List<PawnKindDef> candidates, Map map, out PawnKindDef animalKind)
        {
            return (from k in DefDatabase<PawnKindDef>.AllDefs
                    where k.RaceProps.Animal && (map == null || map.mapTemperature.SeasonAndOutdoorTemperatureAcceptableFor(k.race))
                    select k).TryRandomElement(out animalKind);
        }
    }
}
