var listPosition = [];
var postionId = 0;

$(document).ready(function () {
    _groupProduct.Init();
});

var _changeInterval = null;
$('#ip-kup-search-group-product').keyup(function (e) {
    if (e.which === 13) {
        _groupProduct.OnSearchByName(e.target.value);
    } else {
        clearInterval(_changeInterval);
        _changeInterval = setInterval(function () {
            _groupProduct.OnSearchByName(e.target.value);
            clearInterval(_changeInterval);
        }, 500);
    }
});

$('#grid-data').on('click', '.btn-expand-child', function () {
    let seft = $(this);
    if (seft.siblings('ul').is(':hidden')) {
        seft.addClass('active');
        seft.siblings('ul').show();
    } else {
        seft.removeClass('active');
        seft.siblings('ul').hide();
    }
});

$('#grid-data').on('click', '.btn-add-group-product', function () {
    let seft = $(this);
    let id = seft.data('id');
    let title = "Thêm mới cấp con cho mục <b style='color: #1e5846'>" + seft.parent().siblings('a').text() + "</b>";
    _groupProduct.OpenFormCreate(id, title);
});

$('#btn-add-parent-category').on('click', function () {
    let title = "Thêm mới danh mục cấp cha";
    _groupProduct.OpenFormCreate(-1, title);
});

$('#grid-data').on('click', '.btn-edit-group-product', function () {
    let seft = $(this);
    let id = seft.data('id');
    let title = "Thông tin chuyên mục <b style='color: #1e5846'>" + seft.parent().siblings('a').text() + "</b>";
    _groupProduct.OpenFormEdit(id, title);
});

var _groupProduct = {
    Init: function () {
        let searchData = {
            Name: "",
            Status: -1
        };
        this.SearchParam = searchData;
        this.Search(searchData);
    },

    Search: function (input) {
        $.ajax({
            url: "/groupproduct/search",
            type: "post",
            data: input,
            success: function (result) {
                $('#grid-data').html(result);
            }
        });
    },

    OnSearchByName: function (value) {
        var searchobj = this.SearchParam;
        searchobj.Name = value.trim();
        this.SearchParam = searchobj;
        this.Search(searchobj);
    },

    OnSearchByStatus: function (value) {
        var searchobj = this.SearchParam;
        searchobj.Status = value;
        this.SearchParam = searchobj;
        this.Search(searchobj);
    },

    ReLoad: function () {
        this.Search(this.SearchParam);
    },

    Expand: function () {
        $('.expand').show();
        $('.btn-expand-child').addClass('active');
    },

    Collapse: function () {
        $('.expand').hide();
        $('.btn-expand-child').removeClass('active');
    },

    OpenFormCreate: function (id, title) {
        let url = '/GroupProduct/AddOrUpdate';
        let param = { id: id, type: 0 };
        _magnific.OpenSmallPopupWithHeader(title, url, param);
    },

    OpenFormEdit: function (id, title) {
        let url = '/GroupProduct/AddOrUpdate';
        let param = { id: id, type: 1 };
        _magnific.OpenSmallPopupWithHeader(title, url, param);
    },

    ConvertBase64toFile: function (dataurl) {
        var arr = dataurl.split(','), mime = arr[0].match(/:(.*?);/)[1],
            bstr = atob(arr[1]), n = bstr.length, u8arr = new Uint8Array(n);
        while (n--) {
            u8arr[n] = bstr.charCodeAt(n);
        }
        return new File([u8arr], 'cropedimage.png', { type: mime });
    },

    OnSave: function () {
        let formvalid = $('#form-group-product');
        formvalid.validate({
            rules: {
                Name: "required",
            },
            messages: {
                Name: "Vui lòng nhập tên nhóm hàng"
            }
        });

        if (formvalid.valid()) {
            let form = document.getElementById('form-group-product');
            var formData = new FormData(form);
            var imagedata = $('.image-preview').attr('src');
            var mime = imagedata.match(/data:([a-zA-Z0-9]+\/[a-zA-Z0-9-.+]+).*,.*/);
            if (mime && mime.length > 0) {
                formData.append('imageFile', this.ConvertBase64toFile(imagedata, 'cropedimage.png'));
            }

            // Check status of group product 
            if (formData.get("Status") == 1) {
                let title = "Xác nhận khóa nhóm hàng";
                let description = "Nhóm hàng và các nhóm con của nó sẽ bị khóa, Bạn có muốn lưu lại không?";
                _msgconfirm.openDialog(title, description, function () {
                    $.ajax({
                        url: '/groupproduct/upsert',
                        type: 'POST',
                        data: formData,
                        processData: false,
                        contentType: false,
                        success: function (result) {
                            if (result.isSuccess) {
                                _msgalert.success(result.message);
                                // _groupProduct.ReLoad();
                                $.magnificPopup.close();
                                // _groupProduct.Expand();
                            } else {
                                _msgalert.error(result.message);
                            }
                        },
                        error: function (jqXHR) {
                        },
                        complete: function (jqXHR, status) {
                        }
                    });
                });
            } else {
                $.ajax({
                    url: '/groupproduct/upsert',
                    type: 'POST',
                    data: formData,
                    processData: false,
                    contentType: false,
                    success: function (result) {
                        if (result.isSuccess) {
                            _msgalert.success(result.message);
                            // _groupProduct.ReLoad();
                            $.magnificPopup.close();
                            // _groupProduct.Expand();
                        } else {
                            _msgalert.error(result.message);
                        }
                    },
                    error: function (jqXHR) {
                    },
                    complete: function (jqXHR, status) {
                    }
                });
            }
        }
    },

    OnDelete: function (id) {
        let title = 'Thông báo xác nhận';
        let description = "Bạn có chắc chắn muốn xóa nhóm hàng này?";
        _msgconfirm.openDialog(title, description, function () {
            $.ajax({
                url: "/groupproduct/delete",
                type: "post",
                data: { id: id },
                success: function (result) {
                    if (result.isSuccess) {
                        _msgalert.success(result.message);
                        _groupProduct.ReLoad();
                        $.magnificPopup.close();
                    } else {
                        _msgalert.error(result.message);
                    }
                }
            });
        });
    },

    GetAllPosition: function () {
        $.ajax({
            url: '/groupproduct/GetAllPosition',
            type: 'POST',
            data: '',
            success: function (result) {
                if (result.code == 1) {
                    listPosition = result.data;
                }
            },
            error: function (jqXHR) {
            },
            complete: function (jqXHR, status) {
            }
        });
        if (postionId > 0) {
            setTimeout(function () {
                $('#selectCampaign option:eq(' + postionId + ')').prop('selected', true);
            }, 500)
        }
    },

    AddOrUpdatePosition: function (id) {
        setTimeout(function () {
            _groupProduct.GetAllPosition();
        }, 1500);
        let title = 'Kích thước hiển thị';
        let url = '/GroupProduct/AddOrUpdatePosition';
        let param = { id: id };
        _magnific.OpenSmallPopupWithHeader(title, url, param);
    },

    OnCreatePosition: function () {
        var positionName = $('#positionName').val();
        var width = $('#width').val();
        var height = $('#height').val();
        if (positionName == null || positionName == '') {
            _msgalert.error('Bạn chưa nhập tên vị trí');
            return;
        }
        if (width == null || width == '') {
            _msgalert.error('Bạn chưa nhập chiều rộng');
            return;
        }
        if (height == null || height == '') {
            _msgalert.error('Bạn chưa nhập chiều cao');
            return;
        }
        var data = {
            PositionName: positionName,
            Height: height,
            Width: width,
            Id: postionId
        }
        $.ajax({
            url: '/groupproduct/AddPositionJson',
            type: 'POST',
            data: data,
            success: function (result) {
                if (result.code == 1) {
                    _msgalert.success(result.message)
                    _groupProduct.GetAllPosition();
                    $.magnificPopup.close();
                } else {
                    _msgalert.error(result.message)
                }
            },
            error: function (jqXHR) {
            },
            complete: function (jqXHR, status) {
            }
        });
    },

    OnUpdatePosition: function () {
        var positionName = $('#positionName').val();
        var width = $('#width').val();
        var height = $('#height').val();
        if (positionName == null || positionName == '') {
            _msgalert.error('Bạn chưa nhập tên vị trí');
            return;
        }
        if (width == null || width == '') {
            _msgalert.error('Bạn chưa nhập chiều rộng');
            return;
        }
        if (height == null || height == '') {
            _msgalert.error('Bạn chưa nhập chiều cao');
            return;
        }
        var data = {
            PositionName: positionName,
            Height: height,
            Width: width,
            Id: postionId
        }
        $.ajax({
            url: '/groupproduct/UpdatePositionJson',
            type: 'POST',
            data: data,
            success: function (result) {
                if (result.code == 1) {
                    _msgalert.success(result.message)
                    _groupProduct.GetAllPosition();
                    $.magnificPopup.close();
                } else {
                    _msgalert.error(result.message)
                }
            },
            error: function (jqXHR) {
            },
            complete: function (jqXHR, status) {
            }
        });
    },

    ChangePosition: function () {
        $('#positionName').val('')
        $('#width').val('')
        $('#height').val('')
        postionId = parseInt($('#selectPosition').children(":selected").attr("value"));
        if (listPosition != null) {
            var postionInfo = listPosition.result.find(n => n.id == postionId);
            if (postionInfo != null) {
                $('#positionName').val(postionInfo.positionName)
                $('#width').val(postionInfo.width)
                $('#height').val(postionInfo.height)
                $('#btnAddPostion').hide();
                $('#btnEditPostion').show();
            } else {
                $('#btnAddPostion').show();
                $('#btnEditPostion').hide();
            }
        } else {
            $('#btnAddPostion').show();
            $('#btnEditPostion').hide();
        }
    }
};