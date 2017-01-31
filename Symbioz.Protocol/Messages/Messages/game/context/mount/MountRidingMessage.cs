


















// Generated on 06/04/2015 18:44:23
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class MountRidingMessage : Message
{

public const ushort Id = 5967;
public override ushort MessageId
{
    get { return Id; }
}

public bool isRiding;
        

public MountRidingMessage()
{
}

public MountRidingMessage(bool isRiding)
        {
            this.isRiding = isRiding;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteBoolean(isRiding);
            

}

public override void Deserialize(ICustomDataInput reader)
{

isRiding = reader.ReadBoolean();
            

}


}


}