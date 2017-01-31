


















// Generated on 06/04/2015 18:45:08
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class AccessoryPreviewErrorMessage : Message
{

public const ushort Id = 6521;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte error;
        

public AccessoryPreviewErrorMessage()
{
}

public AccessoryPreviewErrorMessage(sbyte error)
        {
            this.error = error;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(error);
            

}

public override void Deserialize(ICustomDataInput reader)
{

error = reader.ReadSByte();
            if (error < 0)
                throw new Exception("Forbidden value on error = " + error + ", it doesn't respect the following condition : error < 0");
            

}


}


}