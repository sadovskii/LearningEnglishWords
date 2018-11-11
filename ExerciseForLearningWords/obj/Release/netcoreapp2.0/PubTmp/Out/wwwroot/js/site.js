$(".test_1").click(function () {
    $(".test_div_1").css('visibility', 'hidden');
    $(".test_div_2").css('visibility', 'visible');
});

$(".test_2").click(function () {
    $(".test_div_1").css('visibility', 'visible');
    $(".test_div_2").css('visibility', 'hidden');
});

$(".test_3").click(function () {
    $(".test_div_1").css('visibility', 'visible');
    $(".test_div_2").css('visibility', 'visible');
});


