$(document).ready(function () {
    //slick
    $('.images').slick({
        slidesToShow: 4,
        slidesToScroll: 1,
        arrows: false,
        autoplay: true,
        autoplaySpeed: 1000,
    });

    $('.aboutimage').slick({
        slidesToShow: 3,
        slidesToScroll: 1,
        arrows: false,
        autoplay: true,
        autoplaySpeed: 1000,
    });

	$('input[name="paymentmethod"]').on('click', function () {
		var $value = $(this).attr('value');
		$('.payment-method-details').slideUp();
		$('[data-method="' + $value + '"]').slideDown();
	});

    $("#create_pwd").on("change", function () {
		$(".account-create").slideToggle("100");
	});

	$("#ship_to_different").on("change", function () {
		$(".ship-to-different").slideToggle("100");
	});
});
//for header
$(window).scroll(function () {
    var header = $('.header'),
        scroll = $(window).scrollTop();

    if (scroll >= 150) {
        header.css({
            'position': 'fixed',
            'top': '0',
            'left': '0',
            'right': '0',
            'z-index': '99999'
        });
    } else {
        header.css({
             'position': 'absolute'
            
        });
    }
});


//Blog Side

//let commentForm = document.getElementById("CommentForm");

//commentForm.addEventListener("submit", function (ev) {
//    ev.preventDefault();
//    console.log("Test");
//})

// to top function
//btn
document.querySelector(".topBtn").addEventListener("click", function () {
    window.scrollTo({
        top: 0,
        behavior: 'smooth'
    });
})
function ScrollToTop() {
    let scBtn = document.querySelector(".toTopBtn");
    if (window.scrollY > 250) {
        scBtn.style.opacity = "1"
        scBtn.style.visibility = "visible"
    }
    else {
        scBtn.style.opacity = "0"
        scBtn.style.visibility = "hidden"
    }
}
AOS.init();





  

