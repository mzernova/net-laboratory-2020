using System;

namespace Performance
{
    struct S : IComparable<S>
    {
        private int i;
        public S(int i)
        {
            this.i = i;
        }

        public int CompareTo (S other)
        {
            return i.CompareTo(other.i);
        }
    }
}
