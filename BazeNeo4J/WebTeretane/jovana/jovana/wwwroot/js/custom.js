
			
// Dropdown Menu Fade    
jQuery(document).ready(function(){
    $(".dropdown").hover(
        function() { $('.dropdown-menu', this).stop().fadeIn("fast");
        },
        function() { $('.dropdown-menu', this).stop().fadeOut("fast");
    });
});

// Dropdown Menu Fade end   

// Back to top 
 
$('#top-scrolltop').on('click',function(){
 $('html, body').animate({scrollTop:0},500);
});

$(function ($) {
    "use strict";

	$(".back-to-top").addClass("hidden-top");
		$(window).scroll(function () {
		if ($(this).scrollTop() === 0) {
			$(".back-to-top").addClass("hidden-top")
		} else {
			$(".back-to-top").removeClass("hidden-top")
		}
	});

	$('.back-to-top').click(function () {
		$('body,html').animate({scrollTop:0}, 1200);
		return false;
	});	
});

// sticky_header 
$(window).scroll(function() {
  if ($(this).scrollTop() > 211){
    $('.navbar-area').addClass("is-sticky");
  } else{
    $('.navbar-area').removeClass("is-sticky");
  }
});


//mobile menu script


function openNav() {
  document.getElementById("mySidenav").style.width = "100%";
}

function closeNav() {
  document.getElementById("mySidenav").style.width = "0";
}

// Scroll to specific values
// scrollTo is the same
window.scroll({
  top: 0, 
  left: 0, 
  behavior: 'smooth'
});

// Scroll certain amounts from current position 
window.scrollBy({ 
  top: 0, // could be negative value
  left: 0, 
  behavior: 'smooth' 
});

// menu active calss

$(".nav-item").on("click", function(e){
  $(".nav-item").removeClass("active");
  $(this).addClass("active");
});