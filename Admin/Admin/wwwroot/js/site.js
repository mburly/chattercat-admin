// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
try {
    var cur_page = $('.page-current').text();
    const num_pages = document.getElementById("pages").childElementCount;
    for (let i = 1; i <= num_pages; i++) {
        $('#page-' + i + '-button').click(function () {
            $('.page-' + i).removeClass('hidden');
            $('.page-' + cur_page).addClass('hidden');
            $('.page-current').removeClass('page-current');
            $('#page-' + i + '-button').addClass('page-current');
            cur_page = $('.page-current').text();
        })
    }
}
catch {

}
const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]');
const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl));