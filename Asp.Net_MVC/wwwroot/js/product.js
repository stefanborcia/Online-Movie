
$(document).ready(function () {
    loadDataTable();
});


function loadDataTable() {
    dataTable = $("#myTable").DataTable({
        "ajax": { url:"/admin/product/getall" },
        "columns":
            [
                { data: "title", "width": "20%" },
                { data: "listPrice", "width": "10%" },
                { data: "actors", "width": "20%" },
                //{ data: 'place', "width": "15%" },
                { data: "category.name", "width": "15%" },
                {
                    data: "productId",
                    "render": function (data) {
                        return `<div class="w-100 btn-group" role="group">
                                   <a href="/Admin/Product/UpSert?id=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-square"></i> Edit</a>
                                   <a href="/Admin/Product/Delete/${data}" class="btn btn-danger mx-2"><i class="bi bi-trash"></i> Delete</a>
                                </div>`;
                    },
                    "width": "25%"
                }
            ]
    });
}
