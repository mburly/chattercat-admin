// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
try {

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
        var datetime = new Date(datetimes[i].textContent + ' UTC').toLocaleString('en-US').split(',');
        var date = datetime[0];
        var time = datetime[1];

        var time_segments = time.split(':');
        time = time_segments[0].trim() + ':' + time_segments[1] + ' ' + time_segments[2].split(' ')[1];

        datetimes[i].textContent = date + ' ' + time;
    }
}

function pagination() { 
    var cur_page = parseInt($('.page-current').text());
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

    if (document.querySelector('.page-arrow') !== null) {
        $('#arrowLeft').click(function () {
            if (cur_page != 1) {
                var page_num = cur_page - 1;
                $('.page-' + page_num).removeClass('hidden');
                $('.page-' + cur_page).addClass('hidden');
                $('.page-current').removeClass('page-current');
                $('#page-' + page_num + '-button').addClass('page-current');
                cur_page = parseInt($('.page-current').text());
            }
        });

        $('#arrowRight').click(function () {
            if (cur_page != page_numbers[page_numbers.length - 1]) {
                var page_num = cur_page + 1;
                $('.page-' + page_num).removeClass('hidden');
                $('.page-' + cur_page).addClass('hidden');
                $('.page-current').removeClass('page-current');
                $('#page-' + page_num + '-button').addClass('page-current');
                cur_page = parseInt($('.page-current').text());
            }
        });
    }

}

const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]');
const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl));