// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
try {


    $(document).ready(function () {
        document.getElementsByTagName("html")[0].style.visibility = "visible";
    });


    // Convert dates to local time
    if (document.querySelector('.datetime') !== null) {
        convertDatesToLocalTime();
    }


    // Handle pagination for content
    if (document.querySelector('#pages') !== null) {
        pagination();
    }
}
catch {

}

function convertDatesToLocalTime() {
    var datetimes = document.getElementsByClassName("datetime");
    for (let i = 0; i < datetimes.length; i++) {
        var date = new Date(datetimes[i].textContent + ' UTC');
        datetimes[i].textContent = date.toLocaleString('en-US');
    }
}

function pagination() { 
    var cur_page = $('.page-current').text();
    const num_pages = document.getElementById("pages").childElementCount;
    var pages = document.getElementById("pages");
    var page_numbers = Array();
    for (let i = 0; i < num_pages; i++) {
        var num = parseInt(pages.children[i].textContent);
        if(!isNaN(num))
            page_numbers.push(num);
    }
    page_numbers.forEach(page_num => $('#page-' + page_num + '-button').click(function () {
        if (cur_page != page_num) {
            $('.page-' + page_num).removeClass('hidden');
            $('.page-' + cur_page).addClass('hidden');
            $('.page-current').removeClass('page-current');
            $('#page-' + page_num + '-button').addClass('page-current');
            cur_page = $('.page-current').text();
        }
    }));

}

const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]');
const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl));