function confirmDelete(obj) {
    if (!obj) {
        return;
    }
    var cf = confirm("Bạn có chắc chắn muốn xóa?");
    if (cf) {
        window.location.replace(obj.data("url"));
    }
}