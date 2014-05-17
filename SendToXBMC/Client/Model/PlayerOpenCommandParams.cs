﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SendToXBMC.Client.Model
{
    [DataContract]
    class PlayerOpenCommandParams: JsonRpcCommandParams
    {
        [DataMember(Name = "item")]
        public PlayerItem Item;
    }
}
