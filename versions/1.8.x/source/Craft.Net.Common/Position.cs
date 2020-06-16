namespace Craft.Net.Common
{
    public class Position
    {
        public long x;
        public long y;
        public long z;

        public long Encoded;

        public Position(long x, long y, long z)
        {
            Encoded = ((x & 0x3FFFFFF) << 38) | ((z & 0x3FFFFFF) << 12) | (y & 0xFFF);
            x = Encoded >> 38;
            y = Encoded & 0xFFF;
            z = (Encoded << 26 >> 38);
        }
    }
}