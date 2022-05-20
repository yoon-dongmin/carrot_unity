//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.RosTcpEndpoint
{
    public class MRosUnityError : Message
    {
        public const string RosMessageName = "ros_tcp_endpoint/RosUnityError";

        public string message;

        public MRosUnityError()
        {
            this.message = "";
        }

        public MRosUnityError(string message)
        {
            this.message = message;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(SerializeString(this.message));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            var messageStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.message = DeserializeString(data, offset, messageStringBytesLength);
            offset += messageStringBytesLength;

            return offset;
        }

        public override string ToString()
        {
            return "MRosUnityError: " +
            "\nmessage: " + message.ToString();
        }
    }
}