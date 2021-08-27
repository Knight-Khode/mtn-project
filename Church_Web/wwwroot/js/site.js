"use strict";

$("#signing-up").click(function (e) {
    e.preventDefault();
    window.location = "/Account/Signup";
});

$("#signing-in").click(function (e) {
    e.preventDefault();
    window.location = "/Account/Login";
});

$("#about-us").click(function (e) {
    e.preventDefault();
    window.location = "/Account/Login";
});

//from signup page
$("#redirect-signin").click(function (e) {
    e.preventDefault();
    window.location = "/Account/Login";
});

//from login page
$("#redirect-signup").click(function (e) {
    e.preventDefault();
    window.location = "/Account/Signup";
});