using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_Redux.Models
{
    interface Scene
    {
        //cross-talk for Game/Player whose classes are inherited from Characters
        //form of event handling
        void createScene(string playerName, DateTime beginPlay);
    }
}
