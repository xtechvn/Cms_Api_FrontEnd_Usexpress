$(document).ready(function () {

    _menu.GetMenu();
});
var _menu = {
    Init: function () {
        this.Search();
    },

    GetMenu: function () {
        $.ajax({
            url: "/product/GetMenu",
            type: "post",
            data: "",
            success: function (result) {
                $('#grid-data').html(result);
            }
        });
    },
};