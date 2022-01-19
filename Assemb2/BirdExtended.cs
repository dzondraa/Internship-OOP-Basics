using Snadbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assemb2
{
    public class BirdExtended : BirdWithProtectedMember
    {

        // Clan je dostupan u nasledjenim klasama !u konstruktoru!
        public BirdExtended()
        {
            int val =  base.protectedMember;
        }

    }


    public class BirdExtended2 : BirdWithInternal
    {
        public BirdExtended2()
        {
            // base referenca nema pristup internal clanovima roditeljske klase
            //base
        }
    }
}
