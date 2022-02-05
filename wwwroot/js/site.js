// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//swup - page transitions
const options = {
    cache: false
};
const swup = new Swup(options);




// Index
//var backgroundVideo = $("#background-video");
//var hiddenBtn = $("#hiddenBtn");
//var motionBtn = $("#motionBtn");



function StopMotion() {
    $("#background-video").get(0).pause();
    $("#hiddenBtn").show(0);
    $("#motionBtn").hide(0);
}

function StartMotion() {
    $("#background-video").get(0).play();
    $("#motionBtn").show(0);
    $("#hiddenBtn").hide(0);
}

function ZoomerMode() {
    $("source").attr("src", "/videos/trolled.mp4");
    $("video")[0].load(0);
}

// Rate Coffee dzava skript
const buttonParent = $(".bnt-menu");
const rateBox = $("#rate-box");
const reviewBox = $("#review-box");
const ingredientsBox = $("#ingredient-box");
let formclicks = true;
let revclicks = true;
let ingclicks = true;

function ShowForm() {
    if (formclicks) {
        formclicks = false;
        rateBox.show(0);
    } else {
        formclicks = true;
        rateBox.hide(0);
    }
}

function ShowReview() {
    if (revclicks) {
        reviewBox.show(0);
        revclicks = false;
    } else {
        revclicks = true;
        reviewBox.hide(0);
    }
}

function ShowIngredients() {
    console.log("INGREDIENCE FUNGUJI");
    if (ingclicks) {
        console.log("ingclicks je true");
        ingclicks = false;
        ingredientsBox.css("display", "block");
    } else {
        console.log("ingclicks je false");
        ingclicks = true;
        ingredientsBox.css("display", "none");

    }
}