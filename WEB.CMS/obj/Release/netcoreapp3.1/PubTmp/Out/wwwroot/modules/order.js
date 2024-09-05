$(document).ready(function () {
    $('#iconExport').show()
    $('#imgLoading').hide()
    _order.Init();
});

$('.checkbox-tb-column').click(function () {
    let seft = $(this);
    let id = seft.data('id');
    if (seft.is(':checked')) {
        $('td:nth-child(' + id + '),th:nth-child(' + id + ')').removeClass('mfp-hide');
    } else {
        $('td:nth-child(' + id + '),th:nth-child(' + id + ')').addClass('mfp-hide');
    }
});

$('#ip-orderno-data').keyup(function (e) {
    if (e.which === 13) {
        _order.BasicSearch();
    }
});

var _order = {
    Init: function () {
        var _filterDate = $('#ip-date-search-data').val() != "" ? $('#ip-date-search-data').val() : null;
        var _filterPaymentStatus = $("#ip-payment-status-init-data").val();
        let _searchModel = {
            OrderNo: null,
            FromDate: null,
            ToDate: null,
            ClientName: null,
            Phone: null,
            OrderStatus: -1,
            VoucherNo: null,
            UtmSource: null,
            PaymentType: -1,
            PaymentStatus: _filterPaymentStatus,
            PaymentDate: _filterDate
        };

        let objSearch = {
            searchModel: _searchModel,
            currentPage: 1,
            pageSize: 20
        };

        this.SearchParam = objSearch;
        this.Search(objSearch);
    },

    Search: function (input) {
        $.ajax({
            url: "/order/search",
            type: "post",
            data: input,
            success: function (result) {
                $('#grid-data').html(result);
                $('.checkbox-tb-column').each(function () {
                    let seft = $(this);
                    let id = seft.data('id');
                    if (seft.is(':checked')) {
                        $('td:nth-child(' + id + '),th:nth-child(' + id + ')').removeClass('mfp-hide');
                    } else {
                        $('td:nth-child(' + id + '),th:nth-child(' + id + ')').addClass('mfp-hide');
                    }
                });
            }
        });
    },

    OnPaging: function (value) {
        var objSearch = this.SearchParam;
        objSearch.currentPage = value;
        this.Search(objSearch);
    },

    ReLoad: function () {
        this.Search(this.SearchParam);
    },

    BasicSearch: function () {
        var objSearch = this.SearchParam;
        objSearch.searchModel.OrderNo = $('#ip-orderno-data').val().trim();
        objSearch.currentPage = 1;
        this.Search(objSearch);
    },

    AdvanceSearch: function () {
        var objSearch = this.SearchParam;
        objSearch.searchModel.OrderNo = $('#OrderNo').val();
        objSearch.searchModel.FromDate = $('#FromDate').val();
        objSearch.searchModel.ToDate = $('#ToDate').val();
        objSearch.searchModel.ClientName = $('#ClientName').val();
        objSearch.searchModel.Phone = $('#Phone').val();
        objSearch.searchModel.OrderStatus = $('#OrderStatus').val();
        objSearch.searchModel.VoucherNo = $('#VoucherNo').val();
        objSearch.searchModel.UtmSource = $('#UtmSource').val();
        objSearch.searchModel.PaymentType = $('#PaymentType').val();
        objSearch.searchModel.PaymentDate = null;
        objSearch.currentPage = 1;
        this.Search(objSearch);
    },

    OnOpenAdvanceSearch: function () {
        $('.fillter-search').slideDown();
        $('.dynamic-dom').hide();
    },

    OnCloseAdvanceSearch: function () {
        $('#form-advance-search').trigger("reset");
        this.SearchParam.searchModel.OrderNo = null;
        this.SearchParam.searchModel.FromDate = null;
        this.SearchParam.searchModel.ToDate = null;
        this.SearchParam.searchModel.ClientName = null;
        this.SearchParam.searchModel.Phone = null;
        this.SearchParam.searchModel.OrderStatus = -1;
        this.SearchParam.searchModel.VoucherNo = null;
        this.SearchParam.searchModel.UtmSource = null;
        this.SearchParam.searchModel.PaymentType = -1;
        this.SearchParam.searchModel.PaymentStatus = -1;
        this.SearchParam.searchModel.PaymentDate = null;
        $('.fillter-search').slideUp();
        $('.dynamic-dom').show();
    },

    OnChangePaymentStatus: function () {
        let _PaymentStatus = -1;
        if ($('.ckb-PaymentStatus:checked').length == 1) {
            _PaymentStatus = parseInt($('.ckb-PaymentStatus:checked').val());
        }
        this.SearchParam.searchModel.PaymentStatus = _PaymentStatus;
    },

    MappingOrder: function () {
        $('#mapping').show();
        var orderNoInput = $('#orderno').val()
        if (orderNoInput == null || orderNoInput == '') {
            _msgalert.error('Vui lòng nhập danh sách mã đơn hàng để đồng bộ');
            $('#mapping').hide();
            return;
        }
        orderNoInput = orderNoInput.trim()
        var listOrder = orderNoInput.trim().split(',');
        var objData = {
            listOrder: listOrder,
        }
        $.ajax({
            url: "/Order/MappingOrderJson",
            type: "POST",
            data: objData,
            success: function (result) {
                if (result.status == 0) {
                    _msgalert.success(result.message);
                    _order.ReLoad();
                    $.magnificPopup.close();
                } else {
                    $('#mapping').hide();
                    _msgalert.error(result.message);
                }
            },
            error: function (result) {
                _msgalert.error(result.message);
            }
        });
    },

    MappingOneOrder: function (orderId) {
        $('#mapping-order-' + orderId).removeClass('fa fa-refresh');
        $('#mapping-order-' + orderId).addClass('fa fa-refresh fa-spin ');
        if (orderId == null || orderId == '' || orderId == undefined) {
            _msgalert.error('Vui lòng nhập mã đơn hàng để đồng bộ');
            return;
        }
        var objData = {
            orderId: orderId,
        }
        $.ajax({
            url: "/Order/MappingOneOrderJson",
            type: "POST",
            data: objData,
            success: function (result) {
                if (result.status == 0) {
                    _msgalert.success(result.message);
                    _order.ReLoad();
                    $.magnificPopup.close();
                } else {
                    $('#mapping').hide();
                    _msgalert.error(result.message);
                }
                $('#mapping-order-' + orderId).removeClass('fa fa-refresh fa-spin');
                $('#mapping-order-' + orderId).addClass('fa fa-refresh ');
            },
            error: function (result) {
                _msgalert.error(result.message);
                $('#mapping-order-' + orderId).removeClass('fa fa-refresh fa-spin');
                $('#mapping-order-' + orderId).addClass('fa fa-refresh ');
            }
        });
    },

    PushOrderToUsOld: function (orderId) {
        $('#push-order-' + orderId).removeClass('fa fa-history');
        $('#push-order-' + orderId).addClass('fa fa-spinner fa-spin');
        if (orderId == null || orderId == '' || orderId == undefined) {
            _msgalert.error('Vui lòng chọn mã đơn hàng để đồng bộ');
            return;
        }
        var objData = {
            orderId: orderId,
        }
        $.ajax({
            url: "/Order/PushOrderToUsOld",
            type: "POST",
            data: objData,
            success: function (result) {
                if (result.status == 0) {
                    _msgalert.success(result.message);
                } else {
                    // $('#mapping').hide();
                    _msgalert.error(result.message);
                }
                $('#push-order-' + orderId).removeClass('fa fa-spinner fa-spin');
                $('#push-order-' + orderId).addClass('fa fa-history');
            },
            error: function (result) {
                _msgalert.error(result.message);
                $('#push-order-' + orderId).removeClass('fa fa-spinner fa-spin');
                $('#push-order-' + orderId).addClass('fa fa-history');
            }
        });
    },

    OnOpenMappingOrder: function () {
        let title = 'Đồng bộ đơn hàng';
        let url = '/order/mappingOrder';
        let param = {};
        _magnific.OpenSmallPopup(title, url, param);
    },

    ExportExcel: function () {
        var input = this.SearchParam;
        $('#icon-export').removeClass('fa-file-excel-o');
        $('#icon-export').addClass('fa-spinner fa-pulse');
        $.ajax({
            url: "/order/ExportExcel",
            type: "post",
            data: input,
            success: function (result) {
                if (result.isSuccess) {
                    _msgalert.success(result.message);
                    window.location.href = result.path;
                } else {
                    _msgalert.error(result.message);
                }
                $('#icon-export').removeClass('fa-spinner fa-pulse');
                $('#icon-export').addClass('fa-file-excel-o');
            }
        });
    }
};