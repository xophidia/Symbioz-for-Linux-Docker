


















// Generated on 06/04/2015 18:44:53
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class ExchangeObjectAddedMessage : ExchangeObjectMessage
{

public const ushort Id = 5516;
public override ushort MessageId
{
    get { return Id; }
}

public Types.ObjectItem @object;
        

public ExchangeObjectAddedMessage()
{
}

public ExchangeObjectAddedMessage(bool remote, Types.ObjectItem @object)
         : base(remote)
        {
            this.@object = @object;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            @object.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            @object = new Types.ObjectItem();
            @object.Deserialize(reader);
            

}


}


}