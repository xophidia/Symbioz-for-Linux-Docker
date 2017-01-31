


















// Generated on 06/04/2015 18:44:20
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class GameFightOptionToggleMessage : Message
{

public const ushort Id = 707;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte option;
        

public GameFightOptionToggleMessage()
{
}

public GameFightOptionToggleMessage(sbyte option)
        {
            this.option = option;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(option);
            

}

public override void Deserialize(ICustomDataInput reader)
{

option = reader.ReadSByte();
            if (option < 0)
                throw new Exception("Forbidden value on option = " + option + ", it doesn't respect the following condition : option < 0");
            

}


}


}