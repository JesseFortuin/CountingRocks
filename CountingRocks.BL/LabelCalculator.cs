namespace CountingRocks.BL
{
    public class LabelCalculator : ILabelCalculator
    {
        public long Rocks(long n)
        {
            var nInt = (int)n;

            var rockList = Enumerable.Range(1, nInt);

            var labelCount = string.Join("", rockList);

            return labelCount.LongCount();
        }
    }
}