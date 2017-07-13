/* site.js */

  (function () {

    var ele = $("#username");
    ele.text("Glitch Doctor");

    var $sidebarAndWrapper = $("#sidebar,#wrapper,.navbar");
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $icon.removeClass("fa-angle-double-left");
            $icon.addClass("fa-angle-double-right");
            $("#title").text("Show Menu");
        } else {
            $icon.removeClass("fa-angle-double-right");
            $icon.addClass("fa-angle-double-left");
            $("#title").text("Hide Menu");
        }
    });

  })();
