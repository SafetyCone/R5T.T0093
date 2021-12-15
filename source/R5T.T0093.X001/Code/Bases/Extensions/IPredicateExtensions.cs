using System;

using R5T.T0060;
using R5T.T0093;


namespace System
{
    public static class IPredicateExtensions
    {
        public static Func<T, bool> FilePathIs<T>(this IPredicate _, string filePath)
            where T : IFilePathed
        {
            return filePathed => filePathed.FilePath == filePath;
        }
    }
}
