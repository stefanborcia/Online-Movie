
$(document).ready(function () {
    loadDataTable();
});


function loadDataTable() {
    dataTable = $('#myTable').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns":
            [
                { data: 'title', "width": "15%" },
                { data: 'listPrice', "width": "15%" },
                { data: 'actors', "width": "15%" },
                //{ data: 'place', "width": "15%" },
                { data: 'category.name', "width": "15%" }
            ]
    });
}
