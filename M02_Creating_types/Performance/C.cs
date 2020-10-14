using System;

namespace Performance
{
    class C : IComparable<C>
    {
        private readonly int i;
        public C(int i)
        {
            this.i = i;
        }

        public int CompareTo(C other)
        {
            if (other == null) { return 1; }
            return i.CompareTo (other.i);
        }
    }
}
