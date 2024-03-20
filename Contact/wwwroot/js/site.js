$(document).ready(function () {
    $('#tableContatos').DataTable({
        "language": {
            "url": "https://cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Portuguese-Brasil.json"
        }
    });
});


$('.close-alert').click(function () {
    $('.alert').hide('hide');
});