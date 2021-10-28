// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function abrirModal(id) {
    var dialog = $(id).data('dialog');
    dialog.open();
}
function fecharModal(id) {
    var dialog = $(id).data('dialog');
    dialog.close();
}