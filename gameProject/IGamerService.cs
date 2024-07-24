using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameProject
{
    internal interface IGamerService
    {  
        void Add(Gamer games);
        void Remove(Gamer games);
        void Update (Gamer games);


    }
}
