var star = 0;
$().ready(function () {
    $('#edit').hide();
    $('#crawl').hide();
    $('#save').hide();
    $('#getDetail').hide();
    $('#create').hide();
});
$(".tab-link").click(function () {
    $(".tab-link").removeClass("active");
    if (!$(this).hasClass("active")) {
        $(this).addClass("active");
    } else {
        $(this).removeClass("active");
    }
    var tabid = $(this).data("id");
    $(".item-tab-content").css("display", "none");
    $(".item-tab-content[data-id='" + tabid + "']").fadeIn();
});
var menu = {
    SelectStar: function (item) {
        var value = parseInt(item.id)
        switch (value) {
            case 1:
                star = 1;
                $('#1').attr('class', 'fa fa-star bg-orange')
                $('#2').attr('class', 'fa fa-star-o ')
                $('#3').attr('class', 'fa fa-star-o ')
                $('#4').attr('class', 'fa fa-star-o')
                $('#5').attr('class', 'fa fa-star-o')
                break;
            case 2:
                star = 2;
                $('#1').attr('class', 'fa fa-star bg-orange')
                $('#2').attr('class', 'fa fa-star bg-orange')
                $('#3').attr('class', 'fa fa-star-o white')
                $('#4').attr('class', 'fa fa-star-o white')
                $('#5').attr('class', 'fa fa-star-o')
                break;
            case 3:
                star = 3;
                $('#1').attr('class', 'fa fa-star bg-orange')
                $('#2').attr('class', 'fa fa-star bg-orange')
                $('#3').attr('class', 'fa fa-star bg-orange')
                $('#4').attr('class', 'fa fa-star-o')
                $('#5').attr('class', 'fa fa-star-o')
                break;
            case 4:
                star = 4;
                $('#1').attr('class', 'fa fa-star bg-orange')
                $('#2').attr('class', 'fa fa-star bg-orange')
                $('#3').attr('class', 'fa fa-star bg-orange')
                $('#4').attr('class', 'fa fa-star bg-orange')
                $('#5').attr('class', 'fa fa-star-o')
                break;
            case 5:
                star = 5;
                $('#1').attr('class', 'fa fa-star bg-orange')
                $('#2').attr('class', 'fa fa-star bg-orange')
                $('#3').attr('class', 'fa fa-star bg-orange')
                $('#4').attr('class', 'fa fa-star bg-orange')
                $('#5').attr('class', 'fa fa-star bg-orange')
                break;
        }
    },
    GetDetailByAsin: function () {
        var ASIN = $('#ASIN').val()
        if (ASIN == undefined || ASIN == null || ASIN == '') {
            _msgalert.error('Vui lòng nhập mã ASIN');
            $('#edit').hide();
            return;
        }
        $('#edit').show();
        var objData = {
            ASIN: ASIN
        }
        $.ajax({
            url: "/product/GetDetailAsin",
            type: "POST",
            data: objData,
            success: function (result) {
                var resultProductModel = result.product_preview
                if (resultProductModel != null && resultProductModel.title != null && resultProductModel.asin != '') {
                    $('#product_preview_after').show();
                    $('#product_preview_above').hide();
                    $('#title_review').html(resultProductModel.title)
                    $('#seller_name_review').html(resultProductModel.seller_name)
                    $('#link_amazon').attr('href', "https://usexpress.vn" + resultProductModel.link_amazon)
                    $('#price_review').html(resultProductModel.price + ' $')
                    $('#ship_price_us_review').html(resultProductModel.ship_price_us + ' $')
                    $('#ship_buy_fee_review').html(resultProductModel.ship_buy_fee + ' $')
                    var detail = resultProductModel.shipping_details != null ? resultProductModel.shipping_details.split(',') : []
                    if (detail != null && detail.length > 0) {
                        var detailPrice = detail[0].split(':');
                        if (detailPrice[0].includes('FIRST_POUND_FEE')) {
                            var number = parseFloat(detailPrice[1])
                            if (number > 0)
                                $('#shipping_details_first_pound').html(detailPrice[1] + ' $')
                        }
                        var shipping_details_luxury_pound = 0;
                        if (detailPrice[0].includes('LUXURY_FEE')) {
                            var number = parseFloat(detailPrice[1])
                            if (number > 0)
                                shipping_details_luxury_pound += number
                        }
                        if (detailPrice[0].includes('PHONE_FEE')) {
                            var number = parseFloat(detailPrice[1])
                            if (number > 0)
                                shipping_details_luxury_pound += number
                        }
                        if (detailPrice[0].includes('CUBIC_FEE')) {
                            var number = parseFloat(detailPrice[1])
                            if (number > 0)
                                shipping_details_luxury_pound += number
                        }
                        if (detailPrice[0].includes('APPLE_FEE')) {
                            var number = parseFloat(detailPrice[1])
                            if (number > 0)
                                shipping_details_luxury_pound += number
                        }
                        if (detailPrice[0].includes('BATTERY_FEE')) {
                            var number = parseFloat(detailPrice[1])
                            if (number > 0)
                                shipping_details_luxury_pound += number
                        }
                        if (detailPrice[0].includes('DISCOUNT_PRODUCT_2ND')) {
                            var number = parseFloat(detailPrice[1])
                            if (number > 0)
                                shipping_details_luxury_pound += number
                        }
                        $('#shipping_details_luxury_pound').html(shipping_details_luxury_pound + ' $')
                    }
                    $('#price_last').html(resultProductModel.price_last + ' $')
                    $('#price_last_vnd').html(resultProductModel.price_last_vnd + ' đ')
                    switch (parseInt(resultProductModel.stars)) {
                        case 1:
                            $('#1star').attr('class', 'fa fa-star bg-orange')
                            $('#2star').attr('class', 'fa fa-star-o ')
                            $('#3star').attr('class', 'fa fa-star-o ')
                            $('#4star').attr('class', 'fa fa-star-o')
                            $('#5star').attr('class', 'fa fa-star-o')
                            break;
                        case 2:
                            $('#1star').attr('class', 'fa fa-star bg-orange')
                            $('#2star').attr('class', 'fa fa-star bg-orange')
                            $('#3star').attr('class', 'fa fa-star-o white')
                            $('#4star').attr('class', 'fa fa-star-o white')
                            $('#5star').attr('class', 'fa fa-star-o')
                            break;
                        case 3:
                            $('#1star').attr('class', 'fa fa-star bg-orange')
                            $('#2star').attr('class', 'fa fa-star bg-orange')
                            $('#3star').attr('class', 'fa fa-star bg-orange')
                            $('#4star').attr('class', 'fa fa-star-o')
                            $('#5star').attr('class', 'fa fa-star-o')
                            break;
                        case 4:
                            $('#1star').attr('class', 'fa fa-star bg-orange')
                            $('#2star').attr('class', 'fa fa-star bg-orange')
                            $('#3star').attr('class', 'fa fa-star bg-orange')
                            $('#4star').attr('class', 'fa fa-star bg-orange')
                            $('#5star').attr('class', 'fa fa-star-o')
                            break;
                        case 5:
                            $('#1star').attr('class', 'fa fa-star bg-orange')
                            $('#2star').attr('class', 'fa fa-star bg-orange')
                            $('#3star').attr('class', 'fa fa-star bg-orange')
                            $('#4star').attr('class', 'fa fa-star bg-orange')
                            $('#5star').attr('class', 'fa fa-star bg-orange')
                            break;
                    }
                }

                if (result.message != result.status) {
                    _msgalert.error(result.message);
                    $('#edit').hide();
                    return;
                }

                var productModel = result.data
                if (productModel == null) {
                    $('#edit').hide();
                    _msgalert.error('Sản phẩm chưa được khởi tạo');
                    return;
                }
                if (productModel != null && productModel != undefined) {
                    $('#title').val(productModel.title)
                    $('#price').val(productModel.price)
                    $('#price_shipping').val(productModel.price_shipping)
                    $('#main_image').val(productModel.images != null ? productModel.images[0] : "")
                    $('#seller_id').val(productModel.seller_id)
                    $('#seller_name').val(productModel.seller_name)
                    $('#package_dimensions').val(productModel.package_dimensions)
                    $('#review_count').val(productModel.review_count)
                    $('#product_description').val(productModel.product_description)
                    if (productModel.shipping_weight != null && productModel.shipping_weight != '') {
                        var lstShipping = productModel.shipping_weight.split(' ')
                        if (lstShipping != null) {
                            $('#shipping_weight').val(lstShipping[0])
                            $('#shipping_weight_unit').val(lstShipping[1])
                        }
                        star = productModel.ratting;
                        switch (parseInt(productModel.ratting)) {
                            case 1:
                                $('#1').attr('class', 'fa fa-star bg-orange')
                                break;
                            case 2:
                                $('#1').attr('class', 'fa fa-star bg-orange')
                                $('#2').attr('class', 'fa fa-star bg-orange')
                                break;
                            case 3:
                                $('#1').attr('class', 'fa fa-star bg-orange')
                                $('#2').attr('class', 'fa fa-star bg-orange')
                                $('#3').attr('class', 'fa fa-star bg-orange')
                                break;
                            case 4:
                                $('#1').attr('class', 'fa fa-star bg-orange')
                                $('#2').attr('class', 'fa fa-star bg-orange')
                                $('#3').attr('class', 'fa fa-star bg-orange')
                                $('#4').attr('class', 'fa fa-star bg-orange')
                                break;
                            case 5:
                                $('#1').attr('class', 'fa fa-star bg-orange')
                                $('#2').attr('class', 'fa fa-star bg-orange')
                                $('#3').attr('class', 'fa fa-star bg-orange')
                                $('#4').attr('class', 'fa fa-star bg-orange')
                                $('#5').attr('class', 'fa fa-star bg-orange')
                                break;
                        }
                    }
                    if (productModel.is_prime_eligible) {
                        var checked = $('#is_prime_eligible').is(":checked")
                        if (!checked)
                            $('#is_prime_eligible').trigger('click')
                    }

                }
                $('#edit').hide();
            },
            error: function (result) {
                _msgalert.error(result.message);
                $('#edit').hide();
            }
        });
    },
    CrawlDetailByAsin: function () {
        var ASIN = $('#ASIN').val()
        if (ASIN == undefined || ASIN == null || ASIN == '') {
            _msgalert.error('Vui lòng nhập mã ASIN');
            $('#edit').hide();
            return;
        }
        $('#edit').show();
        var objData = {
            ASIN: ASIN
        }
        $.ajax({
            url: "/product/CrawlDetailByAsin",
            type: "POST",
            data: objData,
            success: function (result) {
                var productModel = result.data
                if (productModel == null) {
                    $('#edit').hide();
                    _msgalert.error('Sản phẩm chưa được khởi tạo');
                    return;
                }
                if (productModel != null && productModel != undefined) {
                    $('#title').val(productModel.title)
                    $('#price').val(productModel.price)
                    $('#price_shipping').val(productModel.price_shipping)
                    $('#main_image').val(productModel.images != null ? productModel.images[0] : "")
                    $('#seller_id').val(productModel.seller_id)
                    $('#seller_name').val(productModel.seller_name)
                    $('#package_dimensions').val(productModel.package_dimensions)
                    $('#review_count').val(parseInt(productModel.review_count == null ? 0 : productModel.review_count))
                    $('#product_description').val(productModel.product_description)
                    if (productModel.shipping_weight != null && productModel.shipping_weight != '') {
                        var lstShipping = productModel.shipping_weight.split(' ')
                        if (lstShipping != null) {
                            $('#shipping_weight').val(lstShipping[0])
                            $('#shipping_weight_unit').val(lstShipping[1])
                        }
                    }
                    star = productModel.stars;
                    if (parseInt(star) > 0) {

                        switch (parseInt(productModel.stars)) {
                            case 1:
                                $('#1').attr('class', 'fa fa-star bg-orange')
                                break;
                            case 2:
                                $('#1').attr('class', 'fa fa-star bg-orange')
                                $('#2').attr('class', 'fa fa-star bg-orange')
                                break;
                            case 3:
                                $('#1').attr('class', 'fa fa-star bg-orange')
                                $('#2').attr('class', 'fa fa-star bg-orange')
                                $('#3').attr('class', 'fa fa-star bg-orange')
                                break;
                            case 4:
                                $('#1').attr('class', 'fa fa-star bg-orange')
                                $('#2').attr('class', 'fa fa-star bg-orange')
                                $('#3').attr('class', 'fa fa-star bg-orange')
                                $('#4').attr('class', 'fa fa-star bg-orange')
                                break;
                            case 5:
                                $('#1').attr('class', 'fa fa-star bg-orange')
                                $('#2').attr('class', 'fa fa-star bg-orange')
                                $('#3').attr('class', 'fa fa-star bg-orange')
                                $('#4').attr('class', 'fa fa-star bg-orange')
                                $('#5').attr('class', 'fa fa-star bg-orange')
                                break;
                        }
                    }
                    if (productModel.is_prime_eligible) {
                        var checked = $('#is_prime_eligible').is(":checked")
                        if (!checked)
                            $('#is_prime_eligible').trigger('click')
                    }

                }
                $('#edit').hide();
            },
            error: function (result) {
                _msgalert.error(result.message);
                $('#edit').hide();
            }
        });
    },
    Validate: function () {
        var price = $('#price').val()
        if (price == undefined || price == null || price == '' || isNaN(price) == true) {
            _msgalert.error('Giá bán phải là số');
            return false;
        }
        if (parseFloat(price) <= 0) {
            _msgalert.error('Giá bán phải lớn hơn 0');
            return false;
        }
        var ship_price = $('#ship_price').val()
        if (ship_price == undefined || ship_price == null || ship_price == '' || isNaN(ship_price) == true) {
            _msgalert.error('Price shipping US phải là số');
            return false;
        }
        if (parseFloat(ship_price) <= 0) {
            _msgalert.error('Price shipping US phải lớn hơn 0');
            return false;
        }
        var review_count = $('#review_count').val()
        if (review_count != undefined && review_count != null && review_count != '' || isNaN(review_count) == false) {
            if (parseInt(review_count) < 0)
                _msgalert.error('Ratings phải lớn hơn 0');
            return false;
        }
        if (parseFloat(ship_price) <= 0) {
            _msgalert.error('Price shipping US phải lớn hơn 0');
            return false;
        }
        return true;
    },
    CheckOut: function () {
        let FromCreate = $('#form-create-product-manual');
        FromCreate.validate({
            rules: {
                asin: "required",
                title: "required",
                price: "required",
                main_image: "required",
                seller_id: "required",
                seller_name: "required",
                shipping_weight: "required",
                shipping_weight_unit: "required",
            },
            messages: {
                asin: "Vui lòng nhập mã sản phẩm",
                title: "Vui lòng nhập title",
                price: "Vui lòng nhập giá sản phẩm",
                main_image: "Vui lòng nhập ảnh sản phẩm",
                seller_id: "Vui lòng nhập mã người bán",
                seller_name: "Vui lòng nhập tên người bán",
                shipping_weight: "Vui lòng nhập cân nặng",
                shipping_weight_unit: "Vui lòng nhập đơn vị cân nặng",
            }
        });
        if (FromCreate.valid()) {
            var price = $('#price').val()
            if (price == undefined || price == null || price == '') {
                _msgalert.error('Bạn chưa nhập giá ');
                return;
            }
            if (isNaN(price) == true) {
                _msgalert.error('Giá bán phải là số');
                return;
            }
            if (parseFloat(price) <= 0) {
                _msgalert.error('Giá bán phải lớn hơn 0');
                return;
            }
            var ship_price = $('#price_shipping').val()
            if (ship_price != undefined && ship_price != null && ship_price != '' && isNaN(ship_price) == true) {
                _msgalert.error('Price shipping US phải là số');
                return;
            }
            if (parseFloat(ship_price) < 0) {
                _msgalert.error('Price shipping US phải lớn hơn hoặc bằng 0');
                return;
            }
            var shipping_weight = $('#shipping_weight').val()
            if (shipping_weight != undefined && shipping_weight != null && shipping_weight != '' && isNaN(shipping_weight) == true) {
                _msgalert.error('Shipping_weight phải là số');
                return;
            }
            if (parseFloat(shipping_weight) <= 0) {
                _msgalert.error('Shipping_weight phải lớn hơn 0');
                return;
            }
            var unit = $('select[name=shipping_weight_unit] option').filter(':selected').val()
            if (unit <= 0) {
                _msgalert.error('Bạn chưa chọn đơn vị cân nặng');
                return;
            }
            var review_count = $('#review_count').val()
            if (review_count != undefined && review_count != null && review_count != '' && isNaN(review_count)) {
                _msgalert.error('Ratings phải là số');
                return;
            }
            if (parseInt(review_count) < 0) {
                _msgalert.error('Ratings phải lớn hơn 0');
                return;
            }
            var link_image = $('#main_image').val()
            var listImg = link_image.split('.')
            var imgDuoi = listImg[listImg.length - 1];
            //JPG, PNG, JPEG, GIF, TIFF, PSD, PDF, EPS,
            if (imgDuoi != 'jpg' && imgDuoi != 'png' && imgDuoi != 'jpeg' && imgDuoi != 'gif' &&
                imgDuoi != 'tiff' && imgDuoi != 'bmp') {
                _msgalert.error('Link ảnh chỉ chấp nhận các định dạng: jpg, jpeg, png, gif, tiff, bmp');
                return;
            }
            $('#create').show();
            let form = document.getElementById('form-create-product-manual');
            //form.stars = star;
            var formData = new FormData(form);
            formData.append('ratting', star);
            $.ajax({
                url: '/Product/CheckOut',
                type: 'POST',
                data: formData,
                processData: false,
                contentType: false,
                success: function (result) {
                    $('#create').hide();
                    if (result.status == 1) {
                        _msgalert.success(result.message);
                        $('#product_preview_after').show();
                        $('#product_preview_above').hide();
                        var resultProductModel = result.product_preview
                        if (resultProductModel != null) {
                            $('#title_review').html(resultProductModel.title)
                            $('#seller_name_review').html(resultProductModel.seller_name)
                            $('#link_amazon').attr('href', "https://usexpress.vn" + resultProductModel.link_amazon)
                            $('#price_review').html(resultProductModel.price + ' $')
                            $('#ship_price_us_review').html(resultProductModel.ship_price_us + ' $')
                            $('#ship_buy_fee_review').html(resultProductModel.ship_buy_fee + ' $')
                            var detail = resultProductModel.shipping_details != null ? resultProductModel.shipping_details.split(',') : []
                            if (detail != null && detail.length > 0) {
                                var detailPrice = detail[0].split(':');
                                if (detailPrice[0].includes('FIRST_POUND_FEE')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        $('#shipping_details_first_pound').html(detailPrice[1] + ' $')
                                }
                                var shipping_details_luxury_pound = 0;
                                if (detailPrice[0].includes('LUXURY_FEE')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        shipping_details_luxury_pound += number
                                }
                                if (detailPrice[0].includes('PHONE_FEE')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        shipping_details_luxury_pound += number
                                }
                                if (detailPrice[0].includes('CUBIC_FEE')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        shipping_details_luxury_pound += number
                                }
                                if (detailPrice[0].includes('APPLE_FEE')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        shipping_details_luxury_pound += number
                                }
                                if (detailPrice[0].includes('BATTERY_FEE')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        shipping_details_luxury_pound += number
                                }
                                if (detailPrice[0].includes('DISCOUNT_PRODUCT_2ND')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        shipping_details_luxury_pound += number
                                }
                                $('#shipping_details_luxury_pound').html(shipping_details_luxury_pound + ' $')
                            }
                            $('#price_last').html(resultProductModel.price_last + ' $')
                            $('#price_last_vnd').html(resultProductModel.price_last_vnd + ' đ')
                            switch (parseInt(resultProductModel.stars)) {
                                case 1:
                                    $('#1star').attr('class', 'fa fa-star bg-orange')
                                    $('#2star').attr('class', 'fa fa-star-o ')
                                    $('#3star').attr('class', 'fa fa-star-o ')
                                    $('#4star').attr('class', 'fa fa-star-o')
                                    $('#5star').attr('class', 'fa fa-star-o')
                                    break;
                                case 2:
                                    $('#1star').attr('class', 'fa fa-star bg-orange')
                                    $('#2star').attr('class', 'fa fa-star bg-orange')
                                    $('#3star').attr('class', 'fa fa-star-o white')
                                    $('#4star').attr('class', 'fa fa-star-o white')
                                    $('#5star').attr('class', 'fa fa-star-o')
                                    break;
                                case 3:
                                    $('#1star').attr('class', 'fa fa-star bg-orange')
                                    $('#2star').attr('class', 'fa fa-star bg-orange')
                                    $('#3star').attr('class', 'fa fa-star bg-orange')
                                    $('#4star').attr('class', 'fa fa-star-o')
                                    $('#5star').attr('class', 'fa fa-star-o')
                                    break;
                                case 4:
                                    $('#1star').attr('class', 'fa fa-star bg-orange')
                                    $('#2star').attr('class', 'fa fa-star bg-orange')
                                    $('#3star').attr('class', 'fa fa-star bg-orange')
                                    $('#4star').attr('class', 'fa fa-star bg-orange')
                                    $('#5star').attr('class', 'fa fa-star-o')
                                    break;
                                case 5:
                                    $('#1star').attr('class', 'fa fa-star bg-orange')
                                    $('#2star').attr('class', 'fa fa-star bg-orange')
                                    $('#3star').attr('class', 'fa fa-star bg-orange')
                                    $('#4star').attr('class', 'fa fa-star bg-orange')
                                    $('#5star').attr('class', 'fa fa-star bg-orange')
                                    break;
                            }
                        }
                    } else {
                        _msgalert.error(result.message);
                    }
                },
                error: function (jqXHR) {
                    $('#create').hide();
                },
                complete: function (jqXHR, status) {
                }
            });
        }
    },
    CreateProductManual: function () {
        let FromCreate = $('#form-create-product-manual');
        FromCreate.validate({
            rules: {
                asin: "required",
                title: "required",
                price: "required",
                main_image: "required",
                seller_id: "required",
                seller_name: "required",
                shipping_weight: "required",
                shipping_weight_unit: "required",
            },
            messages: {
                asin: "Vui lòng nhập mã sản phẩm",
                title: "Vui lòng nhập tên sản phẩm",
                price: "Vui lòng nhập giá ",
                main_image: "Vui lòng nhập ảnh sản phẩm",
                seller_id: "Vui lòng nhập mã người bán",
                seller_name: "Vui lòng nhập tên người bán",
                shipping_weight: "Vui lòng nhập cân nặng",
                shipping_weight_unit: "Vui lòng nhập đơn vị cân nặng",
            }
        });
        if (FromCreate.valid()) {
            var price = $('#price').val()
            if (price == undefined || price == null || price == '') {
                _msgalert.error('Bạn chưa nhập giá ');
                return;
            }
            if (isNaN(price) == true) {
                _msgalert.error('Giá bán phải là số');
                return;
            }
            if (parseFloat(price) <= 0) {
                _msgalert.error('Giá bán phải lớn hơn 0');
                return;
            }
            var ship_price = $('#price_shipping').val()
            if (ship_price != undefined && ship_price != null && ship_price != '' && isNaN(ship_price) == true) {
                _msgalert.error('Price shipping US phải là số');
                return;
            }
            if (parseFloat(ship_price) < 0) {
                _msgalert.error('Price shipping US phải lớn hơn hoặc bằng 0');
                return;
            }
            var shipping_weight = $('#shipping_weight').val()
            if (shipping_weight != undefined && shipping_weight != null && shipping_weight != '' && isNaN(shipping_weight) == true) {
                _msgalert.error('Shipping_weight phải là số');
                return;
            }
            if (parseFloat(shipping_weight) <= 0) {
                _msgalert.error('Shipping_weight phải lớn hơn 0');
                return;
            }
            var unit = $('select[name=shipping_weight_unit] option').filter(':selected').val()
            if (unit <= 0) {
                _msgalert.error('Bạn chưa chọn đơn vị cân nặng');
                return;
            }
            var review_count = $('#review_count').val()
            if (review_count != undefined && review_count != null && review_count != '' && isNaN(review_count)) {
                _msgalert.error('Ratings phải là số');
                return;
            }
            if (parseInt(review_count) < 0) {
                _msgalert.error('Ratings phải lớn hơn 0');
                return;
            }
            var link_image = $('#main_image').val()
            var listImg = link_image.split('.')
            var imgDuoi = listImg[listImg.length - 1];
            //JPG, PNG, JPEG, GIF, TIFF, PSD, PDF, EPS,
            if (imgDuoi != 'jpg' && imgDuoi != 'png' && imgDuoi != 'jpeg' && imgDuoi != 'gif' &&
                imgDuoi != 'tiff' && imgDuoi != 'bmp') {
                _msgalert.error('Link ảnh chỉ chấp nhận các định dạng: jpg, jpeg, png, gif, tiff, bmp');
                return;
            }
            let form = document.getElementById('form-create-product-manual');
            // form.ratting = star;
            $('#create').show();
            var formData = new FormData(form);
            formData.append('ratting', star);
            $.ajax({
                url: '/Product/CreateProductManual',
                type: 'POST',
                data: formData,
                processData: false,
                contentType: false,
                success: function (result) {
                    $('#create').hide();
                    if (result.status == 'success') {
                        _msgalert.success(result.message);
                        $('#product_preview_after').show();
                        $('#product_preview_above').hide();
                        var resultProductModel = result.product_preview
                        if (resultProductModel != null) {
                            $('#title_review').html(resultProductModel.title)
                            $('#seller_name_review').html(resultProductModel.seller_name)
                            $('#link_amazon').attr('href', "https://usexpress.vn" + resultProductModel.link_amazon)
                            $('#price_review').html(resultProductModel.price + ' $')
                            $('#ship_price_us_review').html(resultProductModel.ship_price_us + ' $')
                            $('#ship_buy_fee_review').html(resultProductModel.ship_buy_fee + ' $')
                            var detail = resultProductModel.shipping_details != null ? resultProductModel.shipping_details.split(',') : []
                            if (detail != null && detail.length > 0) {
                                var detailPrice = detail[0].split(':');
                                if (detailPrice[0].includes('FIRST_POUND_FEE')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        $('#shipping_details_first_pound').html(detailPrice[1] + ' $')
                                }
                                var shipping_details_luxury_pound = 0;
                                if (detailPrice[0].includes('LUXURY_FEE')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        shipping_details_luxury_pound += number
                                }
                                if (detailPrice[0].includes('PHONE_FEE')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        shipping_details_luxury_pound += number
                                }
                                if (detailPrice[0].includes('CUBIC_FEE')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        shipping_details_luxury_pound += number
                                }
                                if (detailPrice[0].includes('APPLE_FEE')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        shipping_details_luxury_pound += number
                                }
                                if (detailPrice[0].includes('BATTERY_FEE')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        shipping_details_luxury_pound += number
                                }
                                if (detailPrice[0].includes('DISCOUNT_PRODUCT_2ND')) {
                                    var number = parseFloat(detailPrice[1])
                                    if (number > 0)
                                        shipping_details_luxury_pound += number
                                }
                                $('#shipping_details_luxury_pound').html(shipping_details_luxury_pound + ' $')
                            }
                            $('#price_last').html(resultProductModel.price_last + ' $')
                            $('#price_last_vnd').html(resultProductModel.price_last_vnd + ' đ')
                            switch (parseInt(resultProductModel.stars)) {
                                case 1:
                                    $('#1star').attr('class', 'fa fa-star bg-orange')
                                    $('#2star').attr('class', 'fa fa-star-o ')
                                    $('#3star').attr('class', 'fa fa-star-o ')
                                    $('#4star').attr('class', 'fa fa-star-o')
                                    $('#5star').attr('class', 'fa fa-star-o')
                                    break;
                                case 2:
                                    $('#1star').attr('class', 'fa fa-star bg-orange')
                                    $('#2star').attr('class', 'fa fa-star bg-orange')
                                    $('#3star').attr('class', 'fa fa-star-o white')
                                    $('#4star').attr('class', 'fa fa-star-o white')
                                    $('#5star').attr('class', 'fa fa-star-o')
                                    break;
                                case 3:
                                    $('#1star').attr('class', 'fa fa-star bg-orange')
                                    $('#2star').attr('class', 'fa fa-star bg-orange')
                                    $('#3star').attr('class', 'fa fa-star bg-orange')
                                    $('#4star').attr('class', 'fa fa-star-o')
                                    $('#5star').attr('class', 'fa fa-star-o')
                                    break;
                                case 4:
                                    $('#1star').attr('class', 'fa fa-star bg-orange')
                                    $('#2star').attr('class', 'fa fa-star bg-orange')
                                    $('#3star').attr('class', 'fa fa-star bg-orange')
                                    $('#4star').attr('class', 'fa fa-star bg-orange')
                                    $('#5star').attr('class', 'fa fa-star-o')
                                    break;
                                case 5:
                                    $('#1star').attr('class', 'fa fa-star bg-orange')
                                    $('#2star').attr('class', 'fa fa-star bg-orange')
                                    $('#3star').attr('class', 'fa fa-star bg-orange')
                                    $('#4star').attr('class', 'fa fa-star bg-orange')
                                    $('#5star').attr('class', 'fa fa-star bg-orange')
                                    break;
                            }
                        }
                    } else {
                        _msgalert.error(result.message);
                    }
                },
                error: function (jqXHR) {
                    $('#create').hide();
                },
                complete: function (jqXHR, status) {
                }
            });
        }
    },
    GetDetail: function (data_type) {
        var asin = $("#ASINCmd").val()
        if ((asin == null || asin == undefined || asin == '') && data_type == 1) {
            _msgalert.error("Bạn chưa nhập mã ASIN");
            return;
        }
        $('#getDetail').show();
        var objData = {
            ASIN: asin,
            data_type: data_type
        }
        $.ajax({
            url: "/product/GetDetail",
            type: "POST",
            data: objData,
            success: function (result) {
                if (result.code == 0) {
                    $("#json_product").val(result.detail);
                } else {
                    $("#json_product").val(result.detail);
                }
                $('#getDetail').hide();
            },
            error: function (result) {
                _msgalert.error(result.message);
                $('#getDetail').hide();
            }
        });
    },
    LockProductManual: function () {
        var asin = $("#ASIN").val()
        if ((asin == null || asin == undefined || asin == '') && data_type == 1) {
            _msgalert.error("Bạn chưa nhập mã ASIN");
            return;
        }
        $('#create').show();
        var objData = {
            ASIN: asin,
        }
        $.ajax({
            url: "/product/LockProductManual",
            type: "POST",
            data: objData,
            success: function (result) {
                if (result.code == "success") {
                    _msgalert.success(result.message);
                    $('#product_preview_after').hide();
                    $('#product_preview_above').show();
                } else {
                    _msgalert.error(result.message);
                }
                $('#create').hide();
            },
            error: function (result) {
                _msgalert.error(result.message);
                $('#create').hide();
            }
        });
    },
    Save: function () {
        $('#save').show();
        var asin = $("#ASINCmd").val()
        var json_product = $("#json_product").val()
        if (asin == null || asin == "") {
            _msgalert.error("Vui lòng nhập ASIN");
            return;
        }
        if (json_product == null || json_product == "") {
            _msgalert.error("Vui lòng nhập chuỗi json của sản phẩm");
            return;
        }
        var objData = {
            ASIN: asin,
            json_product: json_product,
        }
        $.ajax({
            url: "/product/CreateProductManualV1",
            type: "POST",
            data: objData,
            success: function (result) {
                if (result.code == 0) {
                    _msgalert.success(result.message);
                    $("#ASIN").val("")
                } else {
                    _msgalert.error(result.message);
                }
                $('#save').hide();
            },
            error: function (result) {
                _msgalert.error(result.message);
                $('#save').hide();
            }
        });
    },
    RemoveShippingFee: function () {
        $('#edit').show();
        var asin = $("#ASIN").val()
        if (asin == null || asin == "") {
            $('#edit').hide();
            _msgalert.error("Vui lòng nhập ASIN");
            return;
        }
        var checked = $('#removeShippingFee').is(':checked')
        var objData = {
            ASIN: asin,
            uncheck: checked == true ? 0 : 1,
        }
        $.ajax({
            url: "/product/RemoveShippingFee",
            type: "POST",
            data: objData,
            success: function (result) {
                if (result.code == true) {
                    _msgalert.success(result.message);
                    //$("#ASIN").val("")
                } else {
                    _msgalert.error(result.message);
                }
                $('#edit').hide();
            },
            error: function (result) {
                _msgalert.error(result.message);
                $('#edit').hide();
            }
        });
    },
    RemoveLuxuryFee: function () {
        $('#edit').show();
        var asin = $("#ASIN").val()
        if (asin == null || asin == "") {
            $('#edit').hide();
            _msgalert.error("Vui lòng nhập ASIN");
            return;
        }
        var checked = $('#removeLuxuryFee').is(':checked')
        var objData = {
            ASIN: asin,
            uncheck: checked == true ? 0 : 1,
        }
        $.ajax({
            url: "/product/RemoveLuxuryFee",
            type: "POST",
            data: objData,
            success: function (result) {
                if (result.code == true) {
                    _msgalert.success(result.message);
                    //$("#ASIN").val("")
                } else {
                    _msgalert.error(result.message);
                }
                $('#edit').hide();
            },
            error: function (result) {
                _msgalert.error(result.message);
                $('#edit').hide();
            }
        });
    },
};