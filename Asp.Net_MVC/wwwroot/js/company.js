var dataTable;
$(document).ready(function () {
    loadDataTable();
});


function loadDataTable() {
    dataTable = $("#myTable").DataTable({
        "ajax": { url:"/admin/company/getall" },
        "columns":
            [
                { data: "name", "width": "15%" },
                { data: "email", "width": "15%" },
                { data: "phoneNumber", "width": "15%" },
                { data: "company.name", "width": "15%" },
                { data: "", "width": "15%" },
                {
                    data: "CompanyId",
                    "render": function (data) {
                        return `<div class="w-100 btn-group" role="group">
                                   <a href="/Admin/Company/UpSert?id=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-square"></i> Edit</a>
                                </div>`;
                    },
                    "width": "25%"
                }
            ]
    });
}
