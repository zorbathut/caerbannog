using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace Caerbannog
{
    public class IncidentWorker_ManhunterPack_Caerbannog : IncidentWorker_ManhunterPack
    {
        public override bool TryExecute(IncidentParms parms)
        {
            def.pawnKinds = (from k in DefDatabase<PawnKindDef>.AllDefs
                             where k.RaceProps.Animal
                             select k).ToList();

            return base.TryExecute(parms);
        }
    }
}
