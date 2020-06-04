// JavaScript Document
$(function () {
    touch.swipeup("body", function () {
        handle(-1);        
    });
    touch.swipedown("body", function () {
       handle(1);
    });   
    var hei = $(".page li").height();
    $(window).resize(function () { hei = $(".page li").height() })
    var l = $(".page li").length;
    var t = 0;
    $(".dot span").each(function (j) {
        $(".dot span").eq(j).click(function () {
            move(j);
            t = j;
        })
    });
    $(".more").click(function () {
        move(2);
        t = 2;
    });
    function move(i) {
        $(".page").animate({ "top": -hei * i }, 500, function () {
            //$(".page b").removeClass('cur');
            //$(".page li").eq(i).find("b").addClass('cur');
            var tt = 100;
            if (document.all) tt = 500;
            $(".page b").removeAttr("style");
            if ((i-1) % 2 == 0) {
                $(".page li").eq(i).find("b").animate({ right: '-1%' }, tt)
            } else {
                $(".page li").eq(i).find("b").animate({ left: '1%' }, tt)
            }
            $(".dot span").removeClass('cur');
            $(".dot span").eq(i).addClass('cur');
            $(".six tt").removeClass("cur")
            $(".page li").eq(i).find("tt").addClass("cur");
            $(".page li").eq(i).addClass("active").siblings().removeClass("active");
            $(".ibox").css("display", "none");
            //if (i == 0) { $(".top").css("display", "none") } else { $(".top").css("display", "block") };
        });
    }
    function handle(delta) {
        if ($(".page").is(":animated")) return;
        if (delta < 0) {
            if (t >= l - 1) return;
            t++;
        } else {
            if (t == 0) return;
            t--;
        }
        move(t);
    }
    function wheel(event) {
        $(window).blur();
        var delta = 0;
        if (!event) event = window.event;
        if (event.wheelDelta) {
            delta = event.wheelDelta / 120;
            if (window.opera) delta = -delta;
        } else if (event.detail) {
            delta = -event.detail / 3;
        }
        if (delta)
            handle(delta);
    }
    var debounce = function (func, threshold, execAsap) {
        var timeout;
        return function debounced() {
            var obj = this, args = arguments;
            function delayed() {
                if (!execAsap)
                    func.apply(obj, args);
                timeout = null;
            };
            if (timeout)
                clearTimeout(timeout);
            else if (execAsap)
                func.apply(obj, args);
            timeout = setTimeout(delayed, threshold || 200);
        };
    }

    if (window.addEventListener)
        window.addEventListener('DOMMouseScroll', wheel, false);
    window.onmousewheel = document.onmousewheel = wheel;
    $(window).focus();
    window.onresize = debounce(function () {
        move(t);
        if ($(window).width() <= 1024) {
            $(".page .wz").attr("class", "font-34");
            //$(".copy").css("height", "108px");
            $(".six tt").attr("class", "icon2");
        } else if ($(window).width() > 1024 && $(window).width() < 1440) {
            $(".page .wz").attr("class", "font-40");
            $(".six tt").attr("class", "icon2");
        } else {
            $(".page .wz").attr("class", "font-50");
            $(".six tt").attr("class", "icon");
        }
    }, 200, true)

    if ($(window).width() <= 1024) {
        $(".page .wz").attr("class", "font-34");
        //$(".copy").css("height", "108px");
        $(".six tt").attr("class", "icon2");
        $(".videolist").addClass("vl2");
    } else if ($(window).width() > 1024 && $(window).width() < 1440) {
        $(".page .wz").attr("class", "font-40");
        $(".six tt").attr("class", "icon2");
    } else {
        $(".page .wz").attr("class", "font-50");
        $(".six tt").attr("class", "icon");
        $(".videolist").removeClass("vl2");
    }
})
