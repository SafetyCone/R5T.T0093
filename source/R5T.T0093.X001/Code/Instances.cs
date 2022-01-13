using System;

using R5T.T0060;


namespace R5T.T0093.X001
{
    public static class Instances
    {
        public static IPredicate Predicate { get; } = T0060.Predicate.Instance;
        public static ISelector Selector { get; } = T0060.Selector.Instance;
    }
}
