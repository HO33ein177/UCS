using System.Collections;

namespace UCS.Application.Common.DTO
{
    public class BarNegativeChartDto
    {
        public List<ChartData> Series { get; set; }
        public string[] Categories { get; set; }
        public string[] Labels { get; set; }


    }
}
