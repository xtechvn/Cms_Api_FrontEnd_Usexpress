$(document).ready(function () {
    var _searchData = {
        fromTime: '',
        toTime: '',
        listLabelId: [],
        listCampaignId: [],
        status: -1,
        strLink: '',
        currentPage: 1,
        pageSize: 10
    };
    _menu.Init(_searchData);

    $('#token-input-campaign').tokenInput('/Campaign/GetCampaignSuggestionList', {
        queryParam: "name",
        hintText: "Nhập từ khóa tìm kiếm",
        searchingText: "Đang tìm kiếm...",
        placeholder: 'Nhập từ khóa tìm kiếm',
        searchDelay: 500,
        preventDuplicates: true,
        minChars: 4,
        noResultsText: "Không tìm thấy kết quả",
        tokenLimit: 10,
        onAdd: function (item) {
            _menu.OnChangeCampaignName($(this).val());
        },
        onDelete: function (item) {
            _menu.OnChangeCampaignName($(this).val());
        }
    });
});

var _menu = {
    Init: function (data) {
        this.SearchParam = data;
        this.Search(data);
    },

    Search: function (input) {
        $('#grid-data').html('<img src="/images/icons/loading.gif" style="width:50px; height:50px;" />');
        $.ajax({
            url: "/Campaign/SearchData",
            type: "post",
            data: input,
            success: function (result) {
                $('#grid-data').html(result);
            }
        });
    },

    ReLoad: function () {
        this.Search(this.SearchParam);
    },

    OnChangeCampaignName: function (value) {
        var searchobj = this.SearchParam;
        searchobj.listCampaignId = value
        searchobj.currentPage = 1;
        this.SearchParam = searchobj;
        this.Search(searchobj);
    },

    OnSearchLink: function (item) {
        var searchobj = this.SearchParam;
        if (item == null || item == undefined) {
            searchobj.strLink = $('#linkproduct').val()
        } else {
            searchobj.strLink = item.value
        }
        searchobj.currentPage = 1;
        this.SearchParam = searchobj;
        this.Search(searchobj);
    },

    OnChangeLabel: function (value) {
        var searchobj = this.SearchParam;
        if (searchobj.listLabelId.length == 0) {
            searchobj.listLabelId.push(value);
        } else {
            var flag = false
            for (var i = 0; i < searchobj.listLabelId.length; i++) {
                if (searchobj.listLabelId[i] == value) {
                    flag = true
                    break
                }
                if (flag) {
                    break
                }
            }
            if (!flag) {
                searchobj.listLabelId.push(value);
            } else {
                var idx = searchobj.listLabelId.indexOf(value)
                searchobj.listLabelId.splice(idx, 1);
            }
        }
        searchobj.currentPage = 1;
        this.SearchParam = searchobj;
        this.Search(searchobj);
    },

    OnChangeStatus: function (value) {
        var searchobj = this.SearchParam;
        searchobj.status = value;
        searchobj.currentPage = 1;
        this.SearchParam = searchobj;
        this.Search(searchobj);
    },

    OnChangeFromTime: function (date) {
        var searchobj = this.SearchParam;
        searchobj.fromTime = date.value;
        searchobj.currentPage = 1;
        this.SearchParam = searchobj;
        this.Search(searchobj);
    },

    OnChangeToTime: function (date) {
        var searchobj = this.SearchParam;
        searchobj.toTime = date.value;
        searchobj.currentPage = 1;
        this.SearchParam = searchobj;
        this.Search(searchobj);
    },

    OnPaging: function (value) {
        var searchobj = this.SearchParam;
        searchobj.currentPage = value;
        this.SearchParam = searchobj;
        this.Search(searchobj);
    },

    OnLoadUserData: function (id, callback) {
        $.ajax({
            url: "/role/RoleListUser",
            type: "post",
            data: { Id: id },
            success: function (result) {
                callback(result);
            }
        });
    },

    OnLoadMenuPermission: function (id, callback) {
        $.ajax({
            url: "/role/RolePermission",
            type: "post",
            data: { Id: id },
            success: function (result) {
                callback(result);
            }
        });
    },

    OnUpdateUserRole: function (roleid, userid, type) {
        let obj = {
            roleId: parseInt(roleid),
            userId: userid,
            type: type
        };
        console.log(obj);
        $.ajax({
            url: "/role/UpdateUserRole",
            type: "post",
            data: obj,
            success: function (result) {
            }
        });
    },

    OnShowError: function (id) {
        let title = 'Thông tin lỗi';
        let url = '/campaign/Error';
        let param = { id: id };
        _magnific.OpenSmallPopup(title, url, param);
    },

    OnDelete: function (id) {
        let title = "Xác nhận xóa sản phẩm Ads";
        let description = "Sản phẩm sẽ bị xóa và không được crawl về hệ thống nữa. Bạn có chắc chắn xóa không?";
        _msgconfirm.openDialog(title, description, function () {
            $.ajax({
                url: "/Campaign/delete",
                type: "post",
                data: { Id: id },
                success: function (result) {
                    if (result.isSuccess) {
                        _msgalert.success(result.message);
                        _menu.ReLoad();
                        $.magnificPopup.close();
                    } else {
                        _msgalert.error(result.message);
                    }
                }
            });
        });
    },

    RedirectManageCampaign: function () {
        window.location.href = "/GroupProduct/ProductCategory?isFromCampaign=true";
    }
};