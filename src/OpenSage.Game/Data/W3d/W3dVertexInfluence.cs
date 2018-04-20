using System.IO;
using System.Runtime.InteropServices;

namespace OpenSage.Data.W3d
{
    /// <summary>
    /// Vertex Influences. For "skins" each vertex can be associated with a different bone.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct W3dVertexInfluence
    {
        public ushort BoneIndex;
        public ushort BoneIndex2;
        public ushort BoneWeight;
        public ushort BoneWeight2;

        public static W3dVertexInfluence Parse(BinaryReader reader)
        {
            var result = new W3dVertexInfluence
            {
                BoneIndex = reader.ReadUInt16(),
                BoneIndex2 = reader.ReadUInt16(),
                BoneWeight = reader.ReadUInt16(),
                BoneWeight2 = reader.ReadUInt16()
            };

            return result;
        }
    }
}
