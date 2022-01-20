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
            int val = this.protectedMember;
        }

    }


    public class BirdExtendingInternalMemeberFromOtherProject : Snadbox.BirdWithInternal
    {
        public BirdExtendingInternalMemeberFromOtherProject()
        {
            // base referenca nema pristup internal clanovima roditeljske klase
            //base
        }
    }

    public class BirdExtendingInternalMemeberFromThisProject: Assemb2.BirdWithInternal
    {
        // Private class
        InnerClass instance = new InnerClass();
        public BirdExtendingInternalMemeberFromThisProject()
        {
            // base referenca nema pristup internal clanovima roditeljske klase
            this.add();

        }

        class InnerClass : InternalClassFromThisProject
        {

            void changeValue()
            {
                this.a = 2;
            }
        }
    }


    internal class InternalClassFromThisProject
    {
        internal int a = 2;
    }



    public class BirdWithInternal
    {
        internal void add()
        {
            Console.WriteLine("Internal method");
        }
       
    }



    



}
