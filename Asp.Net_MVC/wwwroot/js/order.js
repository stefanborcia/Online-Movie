var dataTable;
$(document).ready(function () {
    var url = window.location.search;
    if (url.include("inprocess")) {
        loadDataTable("inprocess");
    } else {
        if (url.include("completed")) {
            loadDataTable("completed");
        } else {
            if (url.include("pending")) {
                loadDataTable("pending");
            } else {
                if (url.include("approved")) {
                    loadDataTable("approved");
                } else {
                    loadDataTable("all");
                }
            }
        }
    }
});


function loadDataTable(status) {
    dataTable = $("#myTable").DataTable({
        "ajax": { url:"/admin/order/getall?status=" + status },
        "columns":
            [
                { data: "id", "width": "5%" },
                { data: "name", "width": "15%" },
                { data: "phoneNumber", "width": "20%" },
                { data: 'applicationUser.email', "width": "20%" },
                { data: "orderStatus", "width": "15%" },
                { data: "orderTotal", "width": "15%" },
                {
                    data: "productId",
                    "render": function (data) {
                        return `<div class="w-100 btn-group" role="group">
                                   <a href="/Admin/Order/Details?orderId=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-square"></i></a>
                                </div>`;
                    },
                    "width": "25%"
                }
            ]
    });
}
