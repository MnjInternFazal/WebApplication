// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    var menuIcon = document.getElementById('menu-icon');
    var sidebar = document.getElementById('sidebar');

    menuIcon.addEventListener('click', function () {
        sidebar.classList.toggle('open');
    });
});
