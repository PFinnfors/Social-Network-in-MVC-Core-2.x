
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

    //Enter keyup
    if (e.which === 13) {
        if ($("input:focus").length > 0) {

            var currentForm = $("input:focus").first().closest("form");

            var uri = currentForm.closest(".partial-contents").data("url");
            console.log("posting to: " + uri);
            var data = currentForm.serializeArray();

            $.post(uri, data, function (resultView) {
                currentForm.closest(".partial-contents").html(resultView);
            });

            return false;
        }
    }
});

function replace_content(elem) {

    //Get uri to content action from data-url attribute of the link
    var newUri = $(elem).data("url");
    
    if (newUri && newUri.length > 0) {
        //Change container's data-url to replacing action uri, then load new content inside it
        var container = $(elem).closest(".partial-contents");
        container.data("url", newUri);
        container.attr("data-url", newUri);
        container.load(newUri);
    }
}