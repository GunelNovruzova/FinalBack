$(document).ready(function(){

    $(".nav-bar").slideUp();

    $(".side-menu").click(function(){
        $(this).toggleClass("side-menu-active");
        $(".nav-bar").slideToggle();
    })
})