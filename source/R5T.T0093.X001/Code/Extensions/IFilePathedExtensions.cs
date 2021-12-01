using System;
using System.Collections.Generic;

using R5T.T0093;


namespace System.Linq
{
    public static class IFilePathedExtensions
    {
        public static Dictionary<string, T> ToDictionaryByFilePath<T>(this IEnumerable<T> items)
            where T : IFilePathed
        {
            var output = items.ToDictionary(x => x.FilePath);
            return output;
        }

        public static Dictionary<string, T> ToDictionaryByFilePathModified<T>(this IEnumerable<T> items,
            Func<string, string> filePathModifier)
            where T : IFilePathed
        {
            var output = items.ToDictionary(x => filePathModifier(x.FilePath));
            return output;
        }
    }
}
