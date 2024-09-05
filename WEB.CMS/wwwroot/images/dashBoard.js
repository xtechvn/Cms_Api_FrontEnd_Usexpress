var totalCustomer = 0;
var totalOrder = 0, totalOrderTemp = 0;
var totalRevenuToday = 0, totalRevenuTodayTemp = 0, totalRevenu = 0;
var totalRevenuTodayStr = '', totalRevenuTodayTempStr = '';
var currentType = 0, currentChartTab = 0, currentChartType = 0;
var revenuType = 0;
var listChartRevenuWeek = [];
var listDataChartRevenu = [];
var listDataChartLabel = [];
var chartRevenu = null, chartLabel = null
const constChart_Label_Type_Revenu = 1, constChart_Label_Type_Quantity = 2;
const constRevenu_Week = 1, constRevenu_Month = 2;
const constChart_Type_Today = 1, constChart_Type_Yesterday = 2,
    constChart_Type_Week = 3, constChart_Type_Month = 4;
var pageIndexLog = 1
var pageSizeLog = 5
var pageIndexLogToday = 1
var pageSizeLogToday = 5
var firstload = true
$(document).ready(function () {
    menu.Init();
    setTimeout(function () {
        menu.GetLogActivityToday();
    }, 100)
    setTimeout(function () {
        menu.GetTotalCustomerInday();
    }, 200)
    setTimeout(function () {
        menu.GetRevenuToday();
    }, 400)
    setTimeout(function () {
        menu.GetRevenuTemp();
    }, 500)
    setTimeout(function () {
        menu.GetRevenuDay();
    }, 600)
    setTimeout(function () {
        menu.GetCrawlPercentToDay();
    }, 700)
    setTimeout(function () {
        menu.GetChartRevenu();
    }, 800)
    setTimeout(function () {
        menu.GetChartLabelRevenu();
    }, 1200)
    //setTimeout(function () {
    //    menu.GetLogActivityToday();
    //}, 1400)
    setInterval(function () {
        menu.GetLogActivityToday();
    }, 10000)
});
var menu = {
    Init: function () {
        $('#revenuday_increase').hide();
        $('#revenuday_deincrease').hide();
        $('#img_deincrease').hide();
        $('#img_increase').hide();
        $('#imgLoading').show();
        $('#chartLabel1Month').hide();
        $('#revenu1Month').hide();
        $('#chartLabelMonth').hide();
        //ẩn title
        $('#titlechartLabelYesterday').hide();
        $('#chartLabelQuantity').hide();
        $('#titlechartLabel7Days').hide();
        $('#titlechartLabel1Month').hide();
        //doanh thu thuần
        $('#active1month').removeClass('active')
        //doanh thu theo label
        $('#labelrevenuYesterday').removeClass('active')
        $('#labelrevenu7day').removeClass('active')
        $('#labelrevenu30day').removeClass('active')
        //so luong don theo label
        $('#labelquantityToday').removeClass('active')
        $('#labelquantityYesterday').removeClass('active')
        $('#labelquantity7day').removeClass('active')
        $('#labelquantity30day').removeClass('active')
        $('#titlechartLabelYesterday').hide();
        $('#titlechartLabel7Days').hide();
        $('#titlechartLabel1Month').hide();
    },
    GetTotalCustomerInday: function () {
        $.ajax({
            url: "/DashBoard/GetCustomerInDay",
            type: "post",
            success: function (result) {
                if (result.data <= 0) {
                    $('#customerInDay').html("Chưa có khách hàng mới");
                } else {
                    $('#customerInDay').html(result.data + " khách hàng mới");
                }
                totalCustomer = result.data
            }
        });
    },
    GetRevenuToday: function () {
        $.ajax({
            url: "/DashBoard/GetRevenuToday",
            type: "post",
            success: function (result) {
                $('#totalOrder').html(result.data.totalOrder + " đơn đã thanh toán");
                totalOrder = result.data.totalOrder
                $('#revenu7Days').show();
                $('#revenu1Month').hide();
                $('#totalMoney').html(result.data.revenueStr);
                totalRevenuToday = result.data.revenue
                totalRevenuTodayStr = result.data.revenueStr
            }
        });
    },
    GetRevenuTemp: function () {
        $.ajax({
            url: "/DashBoard/GetRevenuTemp",
            type: "post",
            success: function (result) {
                $('#totalOrderTemp').html(result.data.totalOrder + " đơn chưa thanh toán");
                totalOrderTemp = result.data.totalOrder
                $('#revenu7Days').show();
                $('#revenu1Month').hide();
                $('#totalMoneyTemp').html(result.data.revenueStr);
                totalRevenuTodayTemp = result.data.revenue
                totalRevenuTodayTempStr = result.data.revenueStr
            }
        });
    },
    ViewCustomer: function () {
        if (totalCustomer <= 0) {
            _msgalert.error('Hiện chưa có khách hàng nào mới');
            return;
        }
        var todayTime = new Date();
        var month = ((todayTime.getMonth() + 1) < 10 ? "0" : '') + (todayTime.getMonth() + 1);
        var day = (todayTime.getDate() < 10 ? "0" : '') + todayTime.getDate();
        var year = (todayTime.getFullYear());
        window.location.href = "/Client?date=" + day + "-" + month + "-" + year;
    },
    ViewOrder: function (paymentStatus) {
        if (totalOrder <= 0) {
            _msgalert.error('Hiện chưa có đơn hàng nào mới');
            return;
        }
        var todayTime = new Date();
        var month = ((todayTime.getMonth() + 1) < 10 ? "0" : '') + (todayTime.getMonth() + 1);
        var day = (todayTime.getDate() < 10 ? "0" : '') + todayTime.getDate();
        var year = (todayTime.getFullYear());
        window.location.href = "/Order?date=" + day + "-" + month + "-" + year + '&PaymentStatus=' + paymentStatus;
    },
    ViewOrderTemp: function (paymentStatus) {
        if (totalOrderTemp <= 0) {
            _msgalert.error('Hiện chưa có đơn hàng nào chưa thanh toán trong hôm nay');
            return;
        }
        var todayTime = new Date();
        var month = ((todayTime.getMonth() + 1) < 10 ? "0" : '') + (todayTime.getMonth() + 1);
        var day = (todayTime.getDate() < 10 ? "0" : '') + todayTime.getDate();
        var year = (todayTime.getFullYear());
        window.location.href = "/Order?date=" + day + "-" + month + "-" + year + '&PaymentStatus=' + paymentStatus;
    },
    GetRevenuDay: function () {
        $.ajax({
            url: "/DashBoard/GetRevenuDay",
            type: "post",
            success: function (result) {
                if (result.data < 0) {
                    $('#revenuday_increase').hide();
                    $('#revenuday_deincrease').show();
                    $('#img_increase').hide();
                    $('#img_deincrease').show();
                    $('#revenuday_deincrease').html(result.data + "%");
                }
                if (result.data > 0) {
                    $('#revenuday_increase').show();
                    $('#revenuday_deincrease').hide();
                    if (result.data > 100) {
                        $('#img_increase').show();
                    }
                    $('#img_deincrease').hide();
                    $('#revenuday_increase').html(result.data + "%");
                }
                if (result.data == 0) {
                    $('#revenuday_increase').show();
                    $('#revenuday_deincrease').hide();
                    $('#img_increase').hide();
                    $('#img_deincrease').hide();
                    $('#revenuday_increase').html(result.data + "%");
                }
            }
        });
    },
    GetCrawlPercentToDay: function () {
        $.ajax({
            url: "/DashBoard/GetCrawlPercent",
            type: "post",
            success: function (result) {
                if (result.data.crawlPercent < 0) {
                    $('#crawl_percent_increase').hide();
                    $('#crawl_percent_deincrease').show();
                    $('#crawl_percent_deincrease').html(result.data.crawlPercent + "%");
                }
                if (result.data.crawlPercent > 0) {
                    if (result.data.crawlPercent > 100) {
                        $('#crawl_percent_increase').show();
                        $('#crawl_percent_deincrease').hide();
                        $('#crawl_percent_increase').html(result.data.crawlPercent + "%");
                    } else {
                        $('#crawl_percent_increase').hide();
                        $('#crawl_percent_deincrease').show();
                        $('#crawl_percent_deincrease').html("-" + result.data.crawlPercent + "%");
                    }
                }
                if (result.data.crawlPercent == 0) {
                    $('#crawl_percent_increase').show();
                    $('#crawl_percent_deincrease').hide();
                    $('#crawl_percent_increase').html(result.data.crawlPercent + "%");
                }
                $('#totalProductNotFound').html(result.data.totalProductNotFound + ' sản phẩm không tìm thấy')
            }
        });
    },
    GetChartRevenu: function (revenuType) {
        if (revenuType == undefined || revenuType == null || revenuType == '')
            revenuType = 1
        $('#imgLoading').show();
        $('#revenuChart').hide();
        $.ajax({
            url: "/DashBoard/GetChartRevenu",
            type: "post",
            data: { revenuType: revenuType },
            success: function (result) {
                $('#imgLoading').hide();
                $('#revenuChart').show();
                totalRevenu = result.totalRevenu
                $('#doanhThuThuan').html(" <i class='fa fa-arrow-circle-o-right'></i>"
                    + totalRevenu);
                listDataChartRevenu = result.dataChart
                if (revenuType == constRevenu_Week) {
                    $('#active7day').addClass('active')
                    $('#active1month').removeClass('active')
                    $('#revenu7Days').show();
                    $('#revenu1Month').hide();
                }
                if (revenuType == constRevenu_Month) {
                    $('#active7day').removeClass('active')
                    $('#active1month').addClass('active')
                    $('#revenu7Days').hide();
                    $('#revenu1Month').show();
                }
                chart.LoadChartRevenu(revenuType);
            }
        });
    },
    GetChartLabelRevenu: function (revenuType, revenuChartType) {
        $('#imgLabelLoading').show();
        if (revenuType == undefined || revenuType == null || revenuType == ''
            || revenuType == constChart_Type_Today) {
            revenuType = constChart_Type_Today
            $('#labelrevenuToday').addClass('active')
            $('#titlechartLabelToday').show();
            $('#titlechartLabelYesterday').hide();
            $('#titlechartLabel7Days').hide();
            $('#titlechartLabel1Month').hide();
        }
        if (revenuChartType == undefined || revenuChartType == null || revenuChartType == ''
            || revenuChartType == constChart_Label_Type_Revenu) {
            revenuChartType = constChart_Label_Type_Revenu
            $('#labelQuantityToday').addClass('active')
        }
        if (revenuChartType == constChart_Label_Type_Quantity) {
            if (currentChartTab == constChart_Type_Today) {
                $('#labelQuantityToday').addClass('active')
            } else {
                $('#labelQuantityToday').removeClass('active')
            }
            if (currentChartTab == constChart_Type_Yesterday) {
                $('#labelQuantityYesterday').addClass('active')
            } else {
                $('#labelQuantityYesterday').removeClass('active')
            }
            if (currentChartTab == constChart_Type_Week) {
                $('#labelQuantity7day').addClass('active')
            } else {
                $('#labelQuantity7day').removeClass('active')
            }
            if (currentChartTab == constChart_Type_Month) {
                $('#labelQuantity30day').addClass('active')
            } else {
                $('#labelQuantity30day').removeClass('active')
            }
        }
        $.ajax({
            url: "/DashBoard/GetChartLabel",
            type: "post",
            data: { revenuType: revenuType, revenuChartType: revenuChartType },
            success: function (result) {
                listDataChartLabel = result.dataChart
                $('#imgLabelLoading').hide();
                $('#revenuLabelChart').show();
                if (revenuChartType == constChart_Label_Type_Revenu) {
                    chart.LoadChartLabelRevenu(constChart_Type_Today);
                    $('#chartLabelRevenu').show();
                    $('#chartLabelQuantity').hide();
                }
                if (revenuChartType == constChart_Label_Type_Quantity) {
                    chart.LoadChartLabelQuantity(constChart_Type_Today);
                    $('#chartLabelRevenu').hide();
                    $('#chartLabelQuantity').show();
                }
            }
        });
    },
    //loại biểu đồ doanh thu label 
    LoadChartLabelRevenuToday: function (revenuType, revenuChartType) {
        currentChartTab = revenuType;
        currentChartType = revenuChartType;
        //active loại biểu đồ
        $('#labelrevenuToday').addClass('active')
        $('#labelrevenuYesterday').removeClass('active')
        $('#labelrevenu7day').removeClass('active')
        $('#labelrevenu30day').removeClass('active')
        //ẩn hiện title
        $('#titlechartLabelToday').show();
        $('#titlechartLabelYesterday').hide();
        $('#titlechartLabel7Days').hide();
        $('#titlechartLabel1Month').hide();
        //ẩn hiện doanh thu hoặc số lượng
        $('#chartLabelRevenu').show();
        $('#chartLabelQuantity').hide();
        this.GetChartLabelRevenu(revenuType, revenuChartType);
    },
    LoadChartLabelRevenuYesterday: function (revenuType, revenuChartType) {
        currentChartTab = revenuType;
        currentChartType = revenuChartType;
        //active loại biểu đồ
        $('#labelrevenuToday').removeClass('active')
        $('#labelrevenuYesterday').addClass('active')
        $('#labelrevenu7day').removeClass('active')
        $('#labelrevenu30day').removeClass('active')
        //ẩn hiện title
        $('#titlechartLabelToday').hide();
        $('#titlechartLabelYesterday').show();
        $('#titlechartLabel7Days').hide();
        $('#titlechartLabel1Month').hide();
        //ẩn hiện doanh thu hoặc số lượng
        $('#chartLabelRevenu').show();
        $('#chartLabelQuantity').hide();
        this.GetChartLabelRevenu(revenuType, revenuChartType);
    },
    LoadChartLabelRevenuWeek: function (revenuType, revenuChartType) {
        currentChartTab = revenuType;
        currentChartType = revenuChartType;
        //active loại biểu đồ
        $('#labelrevenuToday').removeClass('active')
        $('#labelrevenuYesterday').removeClass('active')
        $('#labelrevenu7day').addClass('active')
        $('#labelrevenu30day').removeClass('active')
        //ẩn hiện title
        $('#titlechartLabelToday').hide();
        $('#titlechartLabelYesterday').hide();
        $('#titlechartLabel7Days').show();
        $('#titlechartLabel1Month').hide();
        //ẩn hiện doanh thu hoặc số lượng
        $('#chartLabelRevenu').show();
        $('#chartLabelQuantity').hide();
        this.GetChartLabelRevenu(revenuType, revenuChartType);
    },
    LoadChartLabelRevenuMonth: function (revenuType, revenuChartType) {
        currentChartTab = revenuType;
        currentChartType = revenuChartType;
        //active loại biểu đồ
        $('#labelrevenuToday').removeClass('active')
        $('#labelrevenuYesterday').removeClass('active')
        $('#labelrevenu7day').removeClass('active')
        $('#labelrevenu30day').addClass('active')
        //ẩn hiện title
        $('#titlechartLabelToday').hide();
        $('#titlechartLabelYesterday').hide();
        $('#titlechartLabel7Days').hide();
        $('#titlechartLabel1Month').show();
        //ẩn hiện doanh thu hoặc số lượng
        $('#chartLabel7Days').hide();
        $('#chartLabel1Month').show();
        this.GetChartLabelRevenu(revenuType, revenuChartType);
    },
    //loại biểu đồ số lượng đơn theo label 
    LoadChartLabelQuantityToday: function (revenuType, revenuChartType) {
        currentChartTab = revenuType;
        currentChartType = revenuChartType;
        //active loại biểu đồ
        $('#labelQuantityToday').addClass('active')
        $('#labelQuantityYesterday').removeClass('active')
        $('#labelQuantity7day').removeClass('active')
        $('#labelQuantity30day').removeClass('active')
        //ẩn hiện title
        $('#titlechartLabelToday').show();
        $('#titlechartLabelYesterday').hide();
        $('#titlechartLabel7Days').hide();
        $('#titlechartLabel1Month').hide();
        //ẩn hiện doanh thu hoặc số lượng
        $('#chartLabel7Days').show();
        $('#chartLabel1Month').hide();
        this.GetChartLabelRevenu(revenuType, revenuChartType);
    },
    LoadChartLabelQuantityYesterday: function (revenuType, revenuChartType) {
        currentChartTab = revenuType;
        currentChartType = revenuChartType;
        //active loại biểu đồ
        $('#labelQuantityToday').removeClass('active')
        $('#labelQuantityYesterday').addClass('active')
        $('#labelQuantity7day').removeClass('active')
        $('#labelQuantity30day').removeClass('active')
        //ẩn hiện title
        $('#titlechartLabelToday').hide();
        $('#titlechartLabelYesterday').show();
        $('#titlechartLabel7Days').hide();
        $('#titlechartLabel1Month').hide();
        //ẩn hiện doanh thu hoặc số lượng
        $('#chartLabel7Days').show();
        $('#chartLabel1Month').hide();
        this.GetChartLabelRevenu(revenuType, revenuChartType);
    },
    LoadChartLabelQuantityWeek: function (revenuType, revenuChartType) {
        currentChartTab = revenuType;
        currentChartType = revenuChartType;
        //active loại biểu đồ
        $('#labelQuantityToday').removeClass('active')
        $('#labelQuantityYesterday').removeClass('active')
        $('#labelQuantity7day').addClass('active')
        $('#labelQuantity30day').removeClass('active')
        //ẩn hiện title
        $('#titlechartLabelToday').hide();
        $('#titlechartLabelYesterday').hide();
        $('#titlechartLabel7Days').show();
        $('#titlechartLabel1Month').hide();
        //ẩn hiện doanh thu hoặc số lượng
        $('#chartLabel7Days').show();
        $('#chartLabel1Month').hide();
        this.GetChartLabelRevenu(revenuType, revenuChartType);
    },
    LoadChartLabelQuantityMonth: function (revenuType, revenuChartType) {
        currentChartTab = revenuType;
        currentChartType = revenuChartType;
        //active loại biểu đồ
        $('#labelQuantityToday').removeClass('active')
        $('#labelQuantityYesterday').removeClass('active')
        $('#labelQuantity7day').removeClass('active')
        $('#labelQuantity30day').addClass('active')
        //ẩn hiện title
        $('#titlechartLabelToday').hide();
        $('#titlechartLabelYesterday').hide();
        $('#titlechartLabel7Days').hide();
        $('#titlechartLabel1Month').show();
        //ẩn hiện doanh thu hoặc số lượng
        $('#chartLabel7Days').hide();
        $('#chartLabel1Month').show();
        this.GetChartLabelRevenu(revenuType, revenuChartType);
    },
    LoadChartLabel: function (type) {
        if (currentType == 0) {
            if (type == constChart_Label_Type_Revenu) {
                $('#chartLabelRevenu').show();
                $('#chartLabelQuantity').hide();
                //doanh thu thuần
                if (currentChartTab == constChart_Type_Today) {
                    $('#labelrevenuToday').addClass('active')
                } else {
                    $('#labelrevenuToday').removeClass('active')
                }
                if (currentChartTab == constChart_Type_Yesterday) {
                    $('#labelrevenuYesterday').addClass('active')
                } else {
                    $('#labelrevenuYesterday').removeClass('active')
                }
                if (currentChartTab == constChart_Type_Week) {
                    $('#labelrevenu7day').addClass('active')
                } else {
                    $('#labelrevenu7day').removeClass('active')
                }
                if (currentChartTab == constChart_Type_Month) {
                    $('#labelrevenu30day').addClass('active')
                } else {
                    $('#labelrevenu30day').removeClass('active')
                }
                this.GetChartLabelRevenu(currentChartTab, type);
            }
            if (type == constChart_Label_Type_Quantity) {
                $('#chartLabelRevenu').hide();
                $('#chartLabelQuantity').show();
                //số lượng đơn hàng
                if (currentChartTab == constChart_Type_Today) {
                    $('#labelQuantityToday').addClass('active')
                } else {
                    $('#labelQuantityToday').removeClass('active')
                }
                if (currentChartTab == constChart_Type_Yesterday) {
                    $('#labelQuantityYesterday').addClass('active')
                } else {
                    $('#labelQuantityYesterday').removeClass('active')
                }
                if (currentChartTab == constChart_Type_Week) {
                    $('#labelQuantity7day').addClass('active')
                } else {
                    $('#labelQuantity7day').removeClass('active')
                }
                if (currentChartTab == constChart_Type_Month) {
                    $('#labelQuantity30day').addClass('active')
                } else {
                    $('#labelQuantity30day').removeClass('active')
                }
                this.GetChartLabelRevenu(currentChartTab, type);
            }
            currentType = type;
        }
        else {
            if (currentType != type) {
                if (type == constChart_Label_Type_Revenu) {
                    $('#chartLabelRevenu').show();
                    $('#chartLabelQuantity').hide();
                    //doanh thu thuần
                    if (currentChartTab == constChart_Type_Today) {
                        $('#labelrevenuToday').addClass('active')
                    } else {
                        $('#labelrevenuToday').removeClass('active')
                    }
                    if (currentChartTab == constChart_Type_Yesterday) {
                        $('#labelrevenuYesterday').addClass('active')
                    } else {
                        $('#labelrevenuYesterday').removeClass('active')
                    }
                    if (currentChartTab == constChart_Type_Week) {
                        $('#labelrevenu7day').addClass('active')
                    } else {
                        $('#labelrevenu7day').removeClass('active')
                    }
                    if (currentChartTab == constChart_Type_Month) {
                        $('#labelrevenu30day').addClass('active')
                    } else {
                        $('#labelrevenu30day').removeClass('active')
                    }
                    this.GetChartLabelRevenu(currentChartTab, type);
                }
                if (type == constChart_Label_Type_Quantity) {
                    $('#chartLabelRevenu').hide();
                    $('#chartLabelQuantity').show();
                    //số lượng đơn hàng
                    if (currentChartTab == constChart_Type_Today) {
                        $('#labelQuantityToday').addClass('active')
                    } else {
                        $('#labelQuantityToday').removeClass('active')
                    }
                    if (currentChartTab == constChart_Type_Yesterday) {
                        $('#labelQuantityYesterday').addClass('active')
                    } else {
                        $('#labelQuantityYesterday').removeClass('active')
                    }
                    if (currentChartTab == constChart_Type_Week) {
                        $('#labelQuantity7day').addClass('active')
                    } else {
                        $('#labelQuantity7day').removeClass('active')
                    }
                    if (currentChartTab == constChart_Type_Month) {
                        $('#labelQuantity30day').addClass('active')
                    } else {
                        $('#labelQuantity30day').removeClass('active')
                    }
                    this.GetChartLabelRevenu(currentChartTab, type);
                }
                currentType = type;
            }
        }
    },
    GetLogActivityToday: function () {
        $.ajax({
            url: "/DashBoard/GetOrderLogActivityToday",
            data: {},
            type: "post",
            success: function (result) {
                if (firstload)
                    $('#loadingImg').hide()
                $('#LogActivityToday').html('')
                //$('#LogActivityToday').append(result.data);
                if (result.data != null && result.data.length > 0) {
                    for (var i = 0; i < result.data.length; i++) {
                        var className = "images/icons/uslogo.jpg";
                        var html = " <li>" +
                            "<img class='icon' src='" + className + "'>" +
                            "   <a href='/order/detail/" + result.data[i].orderId + "'>Đơn <strong class='color-main'>"
                            + result.data[i].order_no + "</strong> " + result.data[i].notify_name + "</a>" +
                            " <div class='date'>" + result.data[i].time +
                            (result.data[i].status == 13 ? " - thời gian thanh toán: " : " - thời gian đổi trạng thái: ")
                            + (result.data[i].hour < 10 ? '0' + result.data[i].hour : result.data[i].hour) +
                            ":" + (result.data[i].minute < 10 ? '0' + result.data[i].minute : result.data[i].minute) + "</div>" +
                            "  </li>";
                        $('#LogActivityToday').append(html);
                        firstload = false
                    }
                }
                pageIndexLog++;
            }
        });
    },
};
var chart = {
    LoadChartRevenu: function (type) {
        if (chartRevenu != null && chartRevenu != undefined) {
            chartRevenu.destroy();
        }
        var backgroundColor = '#49B391';
        var borderColor = '#49B391';
        var backgroundColorAgo = '#ECEAEA';
        var borderColorAgo = '#ECEAEA';
        if (chartRevenu != undefined) chartRevenu.destroy();
        var ctx = document.getElementById("revenuChart").getContext('2d');

        var listRevenu = [];
        var listLabel = [];
        var listLabelAgo = [];
        var label = "";
        var listDataNow = [];
        var listDataAgo = [];
        for (var i = 0; i < listDataChartRevenu.length; i++) {
            listLabel.push(listDataChartRevenu[i].dateStr);
            listLabelAgo.push(listDataChartRevenu[i].datePassStr);
            listDataNow.push(listDataChartRevenu[i].totalRevenu);
            listDataAgo.push(listDataChartRevenu[i].totalRevenuPass);
        }
        var barChartData = {
            labels: listLabel,
            datasets: [
                {
                    type: "bar",
                    fill: false,
                    label: 'Doanh thu thuần cùng kỳ',
                    backgroundColor: backgroundColorAgo,
                    borderColor: borderColorAgo,
                    borderWidth: 1,
                    data: listDataAgo,
                    stack: 2
                },
                {
                    type: "bar",
                    fill: false,
                    label: 'Doanh thu thuần',
                    backgroundColor: backgroundColor,
                    borderColor: borderColor,
                    borderWidth: 1,
                    data: listDataNow,
                    stack: 1
                },
            ]
        };

        barPercentageCustomer = 0.9 * Math.min(6, listLabel.length) / 6;// lay ti le nho

        var ObjectChart = {
            type: 'bar',
            data: barChartData,
            options: {
                responsive: true,
                legend: {
                    cursor: "pointer",
                    position: 'top',
                },
                title: {
                    display: true,
                },
                scales: {
                    yAxes: [{
                        ticks: {
                            fontColor: 'black',
                            beginAtZero: true,
                            callback: function (value, index, values) {
                                return value / 1000000 + " tr";
                            }
                        },
                        stacked: true,
                    }],
                    xAxes: [{
                        barPercentage: 0.5,
                    }]

                },
                tooltips: {
                    enabled: true,
                    mode: 'single',
                    callbacks: {
                        title: function () { },
                        label: function (tooltipItems, data) {
                            var indice = tooltipItems.index;
                            var dateStr = data.labels[indice].toLocaleString();
                            var date_Ago = "";
                            var order_Count = 0;
                            var order_Count_Ago = 0;
                            var ship_Fee = 0;
                            var ship_Fee_Ago = 0;
                            for (var i = 0; i < listDataChartRevenu.length; i++) {
                                if (listDataChartRevenu[i].dateStr == dateStr) {
                                    order_Count = listDataChartRevenu[i].orderCount;
                                    order_Count_Ago = listDataChartRevenu[i].orderCountPass;
                                    ship_Fee = listDataChartRevenu[i].totalShipFee;
                                    ship_Fee_Ago = listDataChartRevenu[i].totalShipFeePass;
                                    date_Ago = listDataChartRevenu[i].datePassStr;
                                    break;
                                }
                            }
                            var multistringText = [];
                            if (tooltipItems.datasetIndex == 0) {
                                multistringText.push(date_Ago);
                            } else {
                                multistringText.push(dateStr);
                            }
                            var shipfeeAmount = 0;
                            if (tooltipItems.datasetIndex == 1) {
                                shipfeeAmount = ship_Fee;
                            } else {
                                shipfeeAmount = ship_Fee_Ago;
                            }
                            multistringText.push("Doanh thu thuần : " + shipfeeAmount.toLocaleString());
                            multistringText.push("Doanh thu : " + tooltipItems.yLabel.toLocaleString());
                            var count = 0;
                            //var shipfeeAmount = 0;
                            if (tooltipItems.datasetIndex == 1) {
                                count = order_Count;
                                //shipfeeAmount = ship_Fee;
                            } else {
                                count = order_Count_Ago;
                                //shipfeeAmount = ship_Fee_Ago;
                                tooltipItems.xLabel = date_Ago
                            }
                            multistringText.push("SL : " + count.toLocaleString());
                            //  multistringText.push("Ship Fee: " + shipfeeAmount.toLocaleString());
                            return multistringText;
                        }
                    }
                },
            }
        };
        chartRevenu = new Chart(ctx, ObjectChart);
        if (chartRevenu != undefined)
            chartRevenu.update();
    },
    LoadChartLabelRevenu: function (type) {
        if (chartLabel != null && chartLabel != undefined) {
            chartLabel.destroy();
        }
        var backgroundColor = '#49B391';
        var borderColor = '#49B391';
        if (chartLabel != undefined) chartLabel.destroy();
        var label = "";
        var ctx = document.getElementById("revenuLabelChart").getContext('2d');

        var listRevenu = []
        var listLabel = []
        for (var i = 0; i < listDataChartLabel.length; i++) {
            listLabel.push(listDataChartLabel[i].storeName);
            listRevenu.push(listDataChartLabel[i].totalRevenu);
        }
        var dataset = {
            label: label,
            data: listRevenu,
            backgroundColor: backgroundColor,
            borderColor: borderColor
        };

        barPercentageCustomer = 0.9 * Math.min(6, listLabel.length) / 6;// lay ti le nho
        var lstDataset = [dataset];

        var ObjectChart = {
            type: 'horizontalBar',
            data: {
                labels: listLabel,
                datasets: lstDataset
            },
            options: {
                responsive: true,
                legend: {
                    display: false,
                },
                title: {
                    display: true,
                    text: label
                },
                scales: {
                    yAxes: [{
                        position: 'left',
                        type: "category",
                        barPercentage: 0.5,
                    }],
                    xAxes: [{
                        ticks: {
                            fontColor: 'black',
                            beginAtZero: true,
                            callback: function (value, index, values) {
                                if (value <= 1) {
                                    return 0 + " tr";
                                }
                                if (value <= 100) {
                                    return value;
                                }
                                else {
                                    return value / 1000000 + " tr";
                                }
                            }
                        }
                    }]

                },
                tooltips: {
                    mode: 'label',
                    callbacks: {
                        label: function (tooltipItem, data) {
                            var indice = tooltipItem.index;
                            return data.datasets[0].data[indice].toLocaleString();
                        }
                    }
                },
            }
        };
        chartLabel = new Chart(ctx, ObjectChart);

        if (chartLabel != undefined)
            chartLabel.update();
    },
    LoadChartLabelQuantity: function (type) {
        if (chartLabel != null && chartLabel != undefined) {
            chartLabel.destroy();
        }
        var backgroundColor = '#49B391';
        var borderColor = '#49B391';
        if (chartLabel != undefined) chartLabel.destroy();
        var label = "";
        var ctx = document.getElementById("revenuLabelChart").getContext('2d');

        var listQuantity = []
        var listLabel = []
        for (var i = 0; i < listDataChartLabel.length; i++) {
            listLabel.push(listDataChartLabel[i].storeName);
            listQuantity.push(listDataChartLabel[i].orderCount);
        }
        var dataset = {
            label: label,
            data: listQuantity,
            backgroundColor: backgroundColor,
            borderColor: borderColor
        };

        barPercentageCustomer = 0.9 * Math.min(6, listLabel.length) / 6;// lay ti le nho
        var lstDataset = [dataset];

        var ObjectChart = {
            type: 'horizontalBar',
            data: {
                labels: listLabel,
                datasets: lstDataset
            },
            options: {
                responsive: true,
                legend: {
                    display: false,
                },
                title: {
                    display: true,
                    text: label
                },
                scales: {
                    yAxes: [{
                        position: 'left',
                        type: "category",
                        barPercentage: 0.5,
                    }],
                    xAxes: [{
                        ticks: {
                            fontColor: 'black',
                            beginAtZero: true,
                            callback: function (value, index, values) {
                                if (value <= 1) {
                                    return 0;
                                }
                                return value;
                            }
                        }
                    }]

                },
                tooltips: {
                    mode: 'label',
                    callbacks: {
                        label: function (tooltipItem, data) {
                            var indice = tooltipItem.index;
                            return data.datasets[0].data[indice].toLocaleString();
                        }
                    }
                },
            }
        };
        chartLabel = new Chart(ctx, ObjectChart);

        if (chartLabel != undefined)
            chartLabel.update();
    },
}
function dateToString(_date) {
    var dd = _date.getDate();
    var mm = _date.getMonth() + 1;

    var yyyy = _date.getFullYear();
    if (dd < 10) {
        dd = '0' + dd;
    };
    if (mm < 10) {
        mm = '0' + mm;
    };
    return dd + '/' + mm + '/' + yyyy;
}
function getMinute(datetimeString) {
    if (datetimeString == undefined || datetimeString == '') return null;
    var dateTime = datetimeString.split("T");
    var timeOnly = dateTime[1];
    var hm = timeOnly.split(':');
    return hm[1];
}
function getHour(datetimeString) {
    if (datetimeString == undefined || datetimeString == '') return null;
    var dateTime = datetimeString.split("T");
    var timeOnly = dateTime[1];
    var hm = timeOnly.split(':');
    return hm[0];
}
function stringToDate(dateStr) {
    var newDate = new Date();
    newDate.setDate(dateStr.split('/')[0]);
    newDate.setMonth(dateStr.split('/')[1] - 1);
    newDate.setFullYear(dateStr.split('/')[2]);
    newDate.setHours(0, 0, 0);
    return newDate;
}
function parseDateMinute(datetimeString) {
    if (datetimeString == undefined || datetimeString == '') return null;
    var dateTime = datetimeString.split("T");
    var dateOnly = dateTime[0];
    var dmy = dateOnly.split('-');
    var timeOnly = dateTime[1];
    var hm = timeOnly.split(':');
    return dmy[2] + '-' + dmy[1] + '-' + dmy[0];
}









