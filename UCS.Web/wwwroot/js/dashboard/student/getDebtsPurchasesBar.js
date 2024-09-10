$(document).ready(function () {
    loadDebtsPurchasesBar();
});
function loadDebtsPurchasesBar() {
    //$(".chart-spinner").show();

    $.ajax({
        url: "/Dashboard/GetDebtsPurchasesBarChartData",
        type: 'GET',
        dataTypr: 'json',
        success: function (data) {
            loadNegativeBarChart("debtsPurchasesBarChart", data);

            $(".chart-spinner").hide();
        }
    });
}

function loadNegativeBarChart(id, data) {
    var chartColors = getChartColorsArray(id);
    var options = {
        series: [{
            name: 'Debts',
            data: [-8, -14, -22, -28, -37, -39, -42, -31, -44,
            -11, -31, -28
            ]
        },
        {
            name: 'Purchases',
            data: [40, 6, 39, 35,76, 15, 21, 39, 20, 42, 45,30
            ]
        }
        
        ],
        chart: {
            type: 'bar',
            height: 440,
            stacked: true
        },
        colors: ['var(--bs-danger)','var(--bs-success)'],
        plotOptions: {
            bar: {
                borderRadius: 5,
                borderRadiusApplication: 'end', // 'around', 'end'
                borderRadiusWhenStacked: 'all', // 'all', 'last'
                horizontal: true,
                barHeight: '80%',
            },
        },
        dataLabels: {
            enabled: false
        },
        stroke: {
            width: 1,
            colors: ["#fff"]
        },

        grid: {
            xaxis: {
                lines: {
                    show: false
                }
            }
        },
        yaxis: {
            stepSize: 1
        },
        tooltip: {
            shared: false,
            x: {
                formatter: function (val) {
                    return val
                }
            },
            y: {
                formatter: function (val) {
                    return Math.abs(val) + "0$"
                }
            }
        },
        title: {
            text: 'your wallet budget this year'
        },
        xaxis: {
            categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug',
                'Sept', 'Oct', 'Nov', 'Dec'
            ],
            title: {
                text: 'Dollars'
            },
            labels: {
                formatter: function (val) {
                    return Math.abs(Math.round(val)) + "00$"
                }
            }
        },
    };

    var chart = new ApexCharts(document.querySelector("#" + id), options);
    chart.render();
}
function getChartColorsArray(id) {
    if (document.getElementById(id) !== null) {
        var colors = document.getElementById(id).getAttribute("data-colors");
        if (colors) {
            colors = JSON.parse(colors);
            return colors.map(function (value) {
                var newValue = value.replace(" ", "");
                if (newValue.indexOf(",") === -1) {
                    var color = getComputedStyle(document.documentElement).getPropertyValue(newValue);
                    if (color) return color;
                    else return newValue;
                }
            });
        }

    }
}