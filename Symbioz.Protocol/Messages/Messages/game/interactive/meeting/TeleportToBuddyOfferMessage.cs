


















// Generated on 06/04/2015 18:44:49
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class TeleportToBuddyOfferMessage : Message
{

public const ushort Id = 6287;
public override ushort MessageId
{
    get { return Id; }
}

public ushort dungeonId;
        public uint buddyId;
        public uint timeLeft;
        

public TeleportToBuddyOfferMessage()
{
}

public TeleportToBuddyOfferMessage(ushort dungeonId, uint buddyId, uint timeLeft)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
            this.timeLeft = timeLeft;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(dungeonId);
            writer.WriteVarUhInt(buddyId);
            writer.WriteVarUhInt(timeLeft);
            

}

public override void Deserialize(ICustomDataInput reader)
{

dungeonId = reader.ReadVarUhShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            buddyId = reader.ReadVarUhInt();
            if (buddyId < 0)
                throw new Exception("Forbidden value on buddyId = " + buddyId + ", it doesn't respect the following condition : buddyId < 0");
            timeLeft = reader.ReadVarUhInt();
            if (timeLeft < 0)
                throw new Exception("Forbidden value on timeLeft = " + timeLeft + ", it doesn't respect the following condition : timeLeft < 0");
            

}


}


}