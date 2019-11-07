$(function () {
    var l = abp.localization.getResource('XYLib');

    var dataTable = $('#BookInfoTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(bodhi.xYLib.bookInfo.getList),
        columnDefs: [
            { data: "iSBN" },
            { data: "title" },
            { data: "owner" },
            { data: "publisher" },
            { data: "place" },
            { data: "libName" },
            { data: "libAddress" },
        ]
    }));

});