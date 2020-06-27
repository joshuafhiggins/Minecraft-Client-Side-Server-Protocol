namespace Craft.Net.Common
{
    public class Position
    {
        public long Encoded;
        public Vector3 VecPosition;

        public Position(long x, long y, long z)
        {
            Encoded = ((x & 0x3FFFFFF) << 38) | ((z & 0x3FFFFFF) << 12) | (y & 0xFFF);
            VecPosition = new Vector3(x, y, z);
        }

        public Position(long encoded)
        {
            Encoded = encoded;
            long val = Encoded;
            long x = val >> 38;
            long y = val & 0xFFF;
            long z = (val << 26 >> 38);
            VecPosition = new Vector3(x, y, z);
        }
    }
}