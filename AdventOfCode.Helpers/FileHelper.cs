namespace AdventOfCode.Helpers
{
    public static class FileHelper
    {
        public static List<string> GetDataFromInput(string filePath)
        {
            var rawData = File.ReadAllLines(filePath);
            var lines = new List<string>();

            foreach (var line in rawData)
            {
                if(!string.IsNullOrEmpty(line))
                {
                    lines.Add(line);
                }
            }

            return lines;
        }
    }
}