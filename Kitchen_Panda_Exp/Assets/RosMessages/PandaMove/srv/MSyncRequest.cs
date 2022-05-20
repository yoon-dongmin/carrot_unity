//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.PandaMove
{
    public class MSyncRequest : Message
    {
        public const string RosMessageName = "panda_move/Sync";

        public string[] activated_object;

        public MSyncRequest()
        {
            this.activated_object = new string[0];
        }

        public MSyncRequest(string[] activated_object)
        {
            this.activated_object = activated_object;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            
            listOfSerializations.Add(BitConverter.GetBytes(activated_object.Length));
            foreach(var entry in activated_object)
                listOfSerializations.Add(SerializeString(entry));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            
            var activated_objectArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.activated_object= new string[activated_objectArrayLength];
            for(var i = 0; i < activated_objectArrayLength; i++)
            {
                var activated_objectStringBytesLength = DeserializeLength(data, offset);
                offset += 4;
                this.activated_object[i] = DeserializeString(data, offset, activated_objectStringBytesLength);
                offset += activated_objectStringBytesLength;
            }

            return offset;
        }

        public override string ToString()
        {
            return "MSyncRequest: " +
            "\nactivated_object: " + System.String.Join(", ", activated_object.ToList());
        }
    }
}
