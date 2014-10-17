$(document).ready(function(){
    $("#hide").click(function () {
        $("p").hide();
    });

    $("#show").click(function () {
        $("p").show();
    });

    $("button").click(function () {
        $("p").toggle();
    });
});



