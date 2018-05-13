$(document).ready(() => {

    let images = $('.images-container');

    $(document).scroll(function () {
        let scrolled = window.pageYOffset || document.documentElement.scrollTop;
        images.css('top', scrolled);
    });

});