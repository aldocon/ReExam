$(document).ready(function() {
        $("a[data-post]").click(function(e) {
                e.preventDefault();

                var $this = $(this);
                var message = $this.data("post");

                if (message && !confirm(message))
                    return;

                //var antiForgeryToken = $("#anti-forgery-form input");
                //var antiForgeryInput = $("<input type='hidden'").attr("name", antiForgeryToken.attr("name")).val(antiForgeryToken.val());

            $("<form>")
                    .attr("method", "post")
                    .attr("action", $this.attr("href"))
                    //.append($("<input type='hidden' name=''>").val($("#anti-forgery-form").find("input").val()))
                    .appendTo(document.body)
                    .submit();
            });
});

// den grønne kode som er udkommenteret var til at genere en anti-forgery token til delete formen.                    