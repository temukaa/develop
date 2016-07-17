﻿using L2dotNET.GameService.Model.Items;
using L2dotNET.Network;

namespace L2dotNET.GameService.Network.Serverpackets
{
    class TradeOtherAdd
    {
        private const byte Opcode = 0x21;

        internal static Packet ToPacket(L2Item item)
        {
            Packet p =  new Packet(Opcode);
            p.WriteShort(1);

            p.WriteShort((short)item.Template.Type1);
            p.WriteInt(item.ObjId); //item.ObjID
            p.WriteInt(item.Template.ItemId);
            p.WriteInt(item.Count);

            p.WriteShort((short)item.Template.Type2);
            p.WriteShort(0); // ??

            p.WriteInt(item.Template.BodyPart);
            p.WriteShort(item.Enchant);
            p.WriteShort(0x00); // ?
            p.WriteShort(0x00);
            return p;
        }
    }
}