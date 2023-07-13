var dataTable;
$(document).ready(function () {
    loadDataTable();
});


function loadDataTable() {
    dataTable = $("#myTable").DataTable({
        "ajax": { url:"/admin/order/getall" },
        "columns":
            [
                { data: "id", "width": "20%" },
                { data: "name", "width": "10%" },
                { data: "phoneNumber", "width": "20%" },
                { data: 'applicationUser.email', "width": "15%" },
                { data: "orderStatus", "width": "15%" },
                { data: "orderTotal", "width": "15%" },
                {
                    data: "productId",
                    "render": function (data) {
                        return `<div class="w-100 btn-group" role="group">
                                   <a href="/Admin/Product/UpSert?id=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-square"></i> Edit</a>
                                </div>`;
                    },
                    "width": "25%"
                }
            ]
    });
}
