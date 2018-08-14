// Write your JavaScript code.

$(document).ready(function () {

    $(".partial-contents").each(function (index, item) {

        var url = $(item).data("url");
        if (url && url.length > 0) {

            $(item).load(url);
        }
    });
    
    
});

function load_register(elem) {
    
    var newUrl = $(elem).data("url");

    $(elem).closest(".partial-contents").data("url", newUrl);

    var url = $(elem).closest(".partial-contents").data("url");
    
    if (url && url.length > 0) {

        $(elem).closest(".partial-contents").load(url);
    }
}