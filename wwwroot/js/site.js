// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const swup = new Swup();

// Index
let backgroundVideo = $("#background-video");
let hiddenBtn = $("#hiddenBtn");
let motionBtn = $("#motionBtn");

function StopMotion() {
    backgroundVideo.get(0).pause();
    hiddenBtn.show(0);
    motionBtn.hide(0);
}

function StartMotion() {
    backgroundVideo.get(0).play();
    motionBtn.show(0);
    hiddenBtn.hide(0);
}

function ZoomerMode() {
    $("source").attr("src", "/videos/trolled.mp4");
    $("video")[0].load(0);
}

// Rate Coffee dzava skript
let buttonParent = $(".bnt-menu");
let rateBox = $("#rate-box");
let reviewBox = $("#review-box");
let ingredientsBox = $("#ingredient-box");
let formclicks = true;
let revclicks = true;
let ingclicks = true;

function ShowForm() {
    if (formclicks) {
        rateBox.show(0);
        formclicks = false;
    } else {
        rateBox.hide(0);
        formclicks = true;
    }
}

function ShowReview() {
    if (revclicks) {
        reviewBox.show(0);
        revclicks = false;
    } else {
        reviewBox.hide(0);
        revclicks = true;
    }
}

function ShowIngredients() {
    if (ingclicks) {
        ingredientsBox.show(0);
        ingclicks = false;
    } else {
        ingredientsBox.hide(0);
        ingclicks = true;
    }
}