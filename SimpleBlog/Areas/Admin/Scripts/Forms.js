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

        //$("[data-slug]").each(function () {
        //    var $this = $(this);
        //    var $sendSlugFrom = $($this.data("slug"));

        //    $sendSlugFrom.keyup(function() {
        //        var slug = $sendSlugFrom.val();
        //        slug = slug.replace(/[^a-zA-Z0-9\s]/g, "");
        //        slug = slug.toLocaleLowerCase();
        //        slug = slug.replace(/\s+/g, "-");

        //        if (slug.charAt(slug.length - 1) == "-")
        //            slug = slug.substr(0, slug.length - 1);

        //        $this.val(slug);

    //    });/
    //});

    //, data_slug = "'#Title" this line was taken from the form.cshtml line 25, the slug field.

    // above code was removed it was giving problems and is in the end only a nice to have not a need to have.


        

});



// den grønne kode som er udkommenteret var til at genere en anti-forgery token til delete formen.                    