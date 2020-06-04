touch = {
    swipedown: function (selector, handler) {
        var touches = this.bindTouchEvent(selector, function (touches) {
            for (var i = 0; i < touches.length - 1; i++) {
                var touch = touches[i];
                var nextTouch = touches[i + 1];
                if ((nextTouch.pageY - touch.pageY) < 0) {
                    return;
                }
            }
            var firstTouch = touches[0];
            var lastTouch = touches[touches.length - 1];
            if (Math.abs(lastTouch.pageY - firstTouch.pageY) < 50) {
                return;
            }
            if (Math.abs(lastTouch.pageX - firstTouch.pageX) > 100) {
                return;
            }
            handler();
        });
    },
    swipeup: function (selector, handler) {
        var touches = this.bindTouchEvent(selector, function (touches) {
            for (var i = 0; i < touches.length - 1; i++) {
                var touch = touches[i];
                var nextTouch = touches[i + 1];
                if ((nextTouch.pageY - touch.pageY) > 0) {
                    return;
                }
            }
            var firstTouch = touches[0];
            var lastTouch = touches[touches.length - 1];
            if (Math.abs(lastTouch.pageY - firstTouch.pageY) < 50) {
                return;
            }
            if (Math.abs(lastTouch.pageX - firstTouch.pageX) > 100) {
                return;
            }
            handler();
        });
    },
    bindTouchEvent: function (selector, handler) {
        var touches;
        $(selector).bind("touchstart", function (e) {
            touches = [];
            for (var i = 0; i < e.originalEvent.changedTouches.length; i++) {
                touches.push({ pageX: e.originalEvent.changedTouches[i].pageX, pageY: e.originalEvent.changedTouches[i].pageY });
            }
        });
        $(selector).bind("touchmove", function (e) {
            e.preventDefault();
            for (var i = 0; i < e.originalEvent.changedTouches.length; i++) {
                touches.push({ pageX: e.originalEvent.changedTouches[i].pageX, pageY: e.originalEvent.changedTouches[i].pageY });
            }
        });
        $(selector).bind("touchend", function (e) {
            for (var i = 0; i < e.originalEvent.changedTouches.length; i++) {
                touches.push({ pageX: e.originalEvent.changedTouches[i].pageX, pageY: e.originalEvent.changedTouches[i].pageY });
            }
            handler(touches);
        });
    }
}