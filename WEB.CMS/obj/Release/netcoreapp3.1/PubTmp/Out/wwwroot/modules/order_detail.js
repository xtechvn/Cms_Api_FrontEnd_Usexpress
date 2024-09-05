$(document).ready(function () {
    var orderid = $('#param-order-id').val();
    _cashback.LoadGrid(orderid);
    _payment.LoadGrid(orderid);
});

$("#ip-kup-orderno").autocomplete({
    minLength: 4,
    source: function (request, response) {
        $.ajax({
            url: "/Order/GetSuggestionOrder",
            data: {
                orderNo: request.term
            },
            success: function (data) {
                response(JSON.parse(data));
            }
        });
    },
    focus: function (event, ui) {
        event.preventDefault();
        this.value = ui.item.OrderNo;
        return false;
    },
    select: function (event, ui) {
        event.preventDefault();
        this.value = ui.item.OrderNo;
        location.href = "/order/detail/" + ui.item.Id;
    },
    keyup: function (event, ui) {
        event.preventDefault();
        this.value = ui.item.OrderNo;
        return false;
    },
    keydown: function (event, ui) {
        event.preventDefault();
        this.value = ui.item.OrderNo;
        return false;
    }
}).data("ui-autocomplete")._renderItem = function (ul, item) {
    $item = $("<li></li>").data("ui-autocomplete-item", item)
        .append("<strong style='font-size:14px;'>" + item.OrderNo + "</strong>"
            + "<br />"
            + "<strong style='color:#BABABA;font-size:13px;'>Khách hàng: " + item.ClientName + "</strong>"
            + "<br />"
            + "<strong style='color:#BABABA;font-size:13px;'>Địa chỉ: " + item.Address + "</strong>");
    return $item.appendTo(ul);
};

$('#ip-kup-orderno').keyup(function (e) {
    if (e.which === 13) {
        _orderDetail.OnMoveOrder();
    }
});

var _orderDetail = {
    OnMoveOrder: function () {
        let _orderNo = $('#ip-kup-orderno').val().trim();
        $.ajax({
            url: "/Order/FindOrderIdByOrderNo",
            data: {
                orderNo: _orderNo
            },
            success: function (data) {
                if (data != 0) {
                    location.href = "/order/detail/" + data;
                } else {
                    _msgalert.error("Đơn hàng không tồn tại trong hệ thống");
                }
            }
        });
    },

    GetOrderAmount: function (_orderId) {
        $.ajax({
            url: "/Order/GetOrderTotalAmount",
            data: {
                Id: _orderId
            },
            success: function (data) {
                $('#data-order-amount').val(formatNumber(data.toString()));
            }
        });
    }
};

var _cashback = {
    Search: function (orderid) {
        $.ajax({
            url: "/Order/Cashback",
            data: {
                orderId: orderid
            },
            success: function (data) {
                $('#grid-cashback-order').html(data);
            }
        });
    },

    LoadGrid: function (id) {
        this.Search(id);
    },

    FillUpdateItem: function (id, date, amount, note) {
        $('#model-cashback-id').val(id);
        $('#model-cashback-date').val(date);
        $('#model-cashback-note').val(note);
        $('#model-cashback-amount').val(formatNumber(amount));
    },

    Save: function () {
        let valid = true;

        var obj = {
            Id: $('#model-cashback-id').val() == "" ? 0 : parseFloat($('#model-cashback-id').val()),
            OrderId: $('#param-order-id').val(),
            Amount: $('#model-cashback-amount').val() == "" ? 0 : parseFloat($('#model-cashback-amount').val().replace(/,/g, "")),
            CashbackDate: ConvertToJSONDateTime($('#model-cashback-date').val()),
            Note: $('#model-cashback-note').val()
        };

        if (obj.CashbackDate == null) {
            _msgalert.error("Bạn phải chọn ngày hoàn tiền");
            return;
        }

        if (obj.Amount <= 0) {
            _msgalert.error("Bạn phải nhập số tiền hoàn lại");
            return;
        }

        if (valid) {
            $.ajax({
                url: "/Order/SaveCashback",
                type: "post",
                data: { model: obj },
                success: function (result) {
                    if (result.isSuccess) {
                        _msgalert.success(result.message);
                        _cashback.LoadGrid(obj.OrderId);
                        _orderDetail.GetOrderAmount(obj.OrderId);
                    } else {
                        _msgalert.error(result.message);
                    }
                }
            });
        }
    },

    Delete: function (id) {
        let orderid = $('#param-order-id').val();
        let title = 'Thông báo xác nhận';
        let description = 'Bạn có chắc chắn muốn xóa?';
        _msgconfirm.openDialog(title, description, function () {
            $.ajax({
                url: "/Order/DeleteCashback",
                type: "post",
                data: { cashbackId: id },
                success: function (result) {
                    if (result.isSuccess) {
                        _msgalert.success(result.message);
                        _cashback.LoadGrid(orderid);
                        _orderDetail.GetOrderAmount(orderid);
                    } else {
                        _msgalert.error(result.message);
                    }
                }
            });
        });
    },

    ResetForm: function () {
        $('#model-cashback-id').val(0);
        $('#model-cashback-date').val('');
        $('#model-cashback-note').val('');
        $('#model-cashback-amount').val('');
    }
};

var _payment = {
    Search: function (orderid) {
        $.ajax({
            url: "/Order/Payment",
            data: {
                orderId: orderid
            },
            success: function (data) {
                $('#grid-payment-order').html(data);
            }
        });
    },

    LoadGrid: function (id) {
        this.Search(id);
    },

    FillUpdateItem: function (id, date, type, amount, note) {
        $('#model-payment-id').val(id);
        $('#model-payment-date').val(date);
        $('#model-payment-note').val(note);
        $('#model-payment-amount').val(formatNumber(amount));
        $('#model-payment-type').val(type);
    },

    Save: function () {
        let valid = true;

        var obj = {
            Id: $('#model-payment-id').val() == "" ? 0 : parseFloat($('#model-payment-id').val()),
            OrderId: $('#param-order-id').val(),
            Amount: $('#model-payment-amount').val() == "" ? 0 : parseFloat($('#model-payment-amount').val().replace(/,/g, "")),
            PaymentType: parseInt($('#model-payment-type').val()),
            PaymentDate: ConvertToJSONDateTime($('#model-payment-date').val()),
            Note: $('#model-payment-note').val()
            // ProductId: parseFloat($('#model-payment-productid').val()),
        };

        if (obj.PaymentDate == null) {
            _msgalert.error("Bạn phải chọn ngày thanh toán");
            return;
        }

        if (obj.Amount <= 0) {
            _msgalert.error("Bạn phải nhập số tiền thanh toán");
            return;
        }

        if (obj.PaymentType <= 0) {
            _msgalert.error("Bạn phải chọn hình thức thanh toán");
            return;
        }

        if (valid) {
            $.ajax({
                url: "/Order/SavePayment",
                type: "post",
                data: { model: obj },
                success: function (result) {
                    if (result.isSuccess) {
                        _msgalert.success(result.message);
                        _payment.LoadGrid(obj.OrderId);
                        _orderDetail.GetOrderAmount(obj.OrderId);
                    } else {
                        _msgalert.error(result.message);
                    }
                }
            });
        }
    },

    Delete: function (id) {
        let orderid = $('#param-order-id').val();
        let title = 'Thông báo xác nhận';
        let description = 'Bạn có chắc chắn muốn xóa?';
        _msgconfirm.openDialog(title, description, function () {
            $.ajax({
                url: "/Order/DeletePayment",
                type: "post",
                data: { paymentId: id },
                success: function (result) {
                    if (result.isSuccess) {
                        _msgalert.success(result.message);
                        _payment.LoadGrid(orderid);
                        _orderDetail.GetOrderAmount(orderid);
                    } else {
                        _msgalert.error(result.message);
                    }
                }
            });
        });
    },

    ResetForm: function () {
        $('#model-payment-id').val(0);
        $('#model-payment-date').val('');
        $('#model-payment-note').val('');
        $('#model-payment-amount').val('');
        $('#model-payment-type').val(0);
    }
};