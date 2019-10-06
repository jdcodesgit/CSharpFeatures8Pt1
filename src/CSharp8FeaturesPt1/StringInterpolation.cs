namespace CSharp8FeaturesPt1
{
    internal class StringInterpolation
    {
        public StringInterpolation(string folderName, string fileName)
        {
            var path1 = $@"c:\{folderName}\{fileName}";
            var path2 = @$"c:\{folderName}\{fileName}";
        }
    }
}
