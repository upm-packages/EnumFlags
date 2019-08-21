using System;

namespace EnumFlags.Tests.Runtime
{
    [Flags]
    public enum SampleFlag
    {
        Foo = 1 << 0,
        Bar = 1 << 1,
        Buz = 1 << 2,
        Quz = 1 << 3,
    }
}

