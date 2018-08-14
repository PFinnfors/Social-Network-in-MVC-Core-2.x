
$(".partial-contents").each(function (index, item) {
    
    var uri = $(item).data("url");

    if (uri && uri.length > 0) {

        console.log(uri);
        $(item).load(uri);
        $(item).data("url", "");
    }
});

$("form").submit(function (e) {
    e.preventDefault();
    console.log("Form posted!");
    return false;
});

$(document).keyup(function (e) {
    
    ////Enter keyup
    if (e.which === 13) {
        if ($("input:focus").length > 0) {
            $("input:focus").first().closest("form").submit();
            return false;
        }
    }
})

//$(".fullscreen-bg-video video").addClass("fade-in");

function replace_content(elem) {

    //Get uri to content action from data-url attribute of the link
    var newUri = $(elem).data("url");

    if (newUri && newUri.length > 0) {

        $(elem).closest(".partial-contents").load(newUri);
    }
}