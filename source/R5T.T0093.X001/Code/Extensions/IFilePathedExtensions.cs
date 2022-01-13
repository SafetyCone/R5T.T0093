using System;
using System.Collections.Generic;

using R5T.Magyar;

using R5T.T0093;

using Instances = R5T.T0093.X001.Instances;


namespace System.Linq
{
    public static class IFilePathedExtensions
    {
        public static T[] FindArrayByFilePath<T>(this IEnumerable<T> filePatheds, string filePath)
            where T : IFilePathed
        {
            var output = filePatheds.FindArray(Instances.Predicate.FilePathIs<T>(filePath));
            return output;
        }

        public static WasFound<T> FindSingleByFilePath<T>(this IEnumerable<T> filePatheds, string filePath)
            where T : IFilePathed
        {
            var output = filePatheds.FindSingle(Instances.Predicate.FilePathIs<T>(filePath));
            return output;
        }

        public static IEnumerable<string> GetFilePaths<T>(this IEnumerable<T> filePatheds)
            where T : IFilePathed
        {
            var output = filePatheds.Select(Instances.Selector.SelectFilePath<T>());
            return output;
        }

        public static Dictionary<string, T> ToDictionaryByFilePath<T>(this IEnumerable<T> filePatheds)
            where T : IFilePathed
        {
            var output = filePatheds.ToDictionary(Instances.Selector.SelectFilePath<T>());
            return output;
        }

        public static Dictionary<string, T> ToDictionaryByFilePathModified<T>(this IEnumerable<T> filePatheds,
            Func<string, string> filePathModifier)
            where T : IFilePathed
        {
            var output = filePatheds.ToDictionary(x => filePathModifier(x.FilePath));
            return output;
        }

        public static void VerifyDistinctByFilePath<T>(this IEnumerable<T> filePatheds)
            where T : IFilePathed
        {
            filePatheds.GetFilePaths().VerifyDistinct();
        }
    }
}
