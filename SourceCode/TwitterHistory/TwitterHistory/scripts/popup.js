$(function () {
    $(".btn").click(function (event) {
        event.preventDefault();
        window.location = 'TwitterSearch.html';
    });
});

$(function () {

    $.ajax({
        type: 'GET',
        url: "http://localhost:8303/TwitterHistoryWS.asmx/GetUsers",
        dataType: 'xml',
        headers: {
            "Access-Control-Allow-Origin": "*",
        },
        success: function (xml) {
            var test = xml;
        },
        error: function (xml) {
            var test = xml;
        }

    });
    var usernames = [
      "Rick Policky",
      "Happy Gilmore",
      "Patrick Morrow",
      "Patricia Morrow",
      "Tucker Hochstein",
      "Josh Myers",
      "Michael Myers",
      "Test",
    ];
    $("#userInput").autocomplete({
        source: usernames
    });

    var count = 0;
    var max = 10;
    $("li").each(function () {
        count++;
        
        if(count > max){
            $(this).hide();
        }
    });

    $("#showmore").click(function () {
        max += 10;
        var count = 0;
        $("li").each(function () {
            count++;

            if (count > max) {
                $(this).hide();
            } else {
                $(this).show();
            }
        });
    });
});

