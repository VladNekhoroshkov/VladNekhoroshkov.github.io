$(document).ready(() => {

    let wraper = $("#main-slider");
let sample = $("#sample-image");

window.onresize = () => {
    wraper.css('height', sample.height());
};

wraper.css('height', sample.height());

});