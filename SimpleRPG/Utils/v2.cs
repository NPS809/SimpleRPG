using System.Diagnostics.CodeAnalysis;


namespace SimpleRPG
{
    public struct v2
    {
        public int y;
        public int x;

        public v2() { y = 0; x = 0; }
        public v2(int y, int x) { this.y = y; this.x = x; }

        public static bool operator !=(v2 val1, v2 val2)
        {
            return val1.x != val2.x || val1.y != val2.y;
        }
            
        public override bool Equals([NotNullWhen(true)] object? obj) { return base.Equals(obj); }

        public override int GetHashCode() { return base.GetHashCode(); }

        public static bool operator ==(v2 val1, v2 val2)
        {
            return val1.x == val2.x && val1.y == val2.y;
        }

        public override string ToString()
        {
            return $"v2(y={y}, x={x})";
        }

        public bool isInRange0toMax(v2 max)
        {
            return x >= 0 && x < max.x &&
                y >= 0 && y < max.y;
        }
    }

}
