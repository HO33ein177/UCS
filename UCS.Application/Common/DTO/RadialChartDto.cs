namespace UCS.Application.Common.DTO
{
    public class RadialChartDto
    {
        public decimal TotalCount { get; set; }
        public decimal IncreaseDecreaseAmount { get; set; }
        public bool HasRatioIncreased { get; set; }
        public int[] Series { get; set; }
    }
}
