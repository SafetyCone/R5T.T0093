using System;

using R5T.T0060;
using R5T.T0093;


namespace System
{
    public static class ISelectorExtensions
    {
        public static Func<T, string> SelectFilePath<T>(this ISelector _)
            where T : IFilePathed
        {
            return filedPathed => filedPathed.FilePath;
        }
    }
}
