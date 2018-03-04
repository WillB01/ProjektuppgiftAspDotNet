$(document).ready(function () {
    $("#UserName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Home/Search",
                type: "POST",
                dataType: "json",
                data: { Prefix: request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return { label: item.UserName, value: item.UserName };
                    }))

                }
            })
        },
        messages: {
            noResults: "",
            results: function (count) {
                return count + (count > 1 ? ' results' : ' result ') + ' found';
            }
        }
    });

})