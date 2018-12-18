﻿;(function () {
    $.MsgBox = {
        Alert: function (title, msg, callback) {
            GenerateHtml("alert", title, msg);
            btnOk(callback); //alert只是弹出消息，因此没必要用到回调函数callback
            btnNo();
        },
        Confirm: function (title, msg, callback) {
            GenerateHtml("confirm", title, msg);
            btnOk(callback);
            btnNo();
        }
    }

    //生成Html
    var GenerateHtml = function (type, title, msg) {

        var _html = "";

        _html += '<div id="mb_box"></div><div id="mb_con">';
        _html += '<div id="mb_msg" style="text-align:center">' + msg + '</div><div id="mb_btnbox">';

        if (type == "alert") {
            //_html += '<input id="mb_btn_ok" type="button" value="确定" />';
            _html += '<button id="mb_btn_ok"class="button button-round button-small button-wide"><span class="button-inner">确定</span></button>'
        }
        if (type == "confirm") {
            _html += '<input id="mb_btn_ok" type="button" value="确定" />';
            _html += '<input id="mb_btn_no" type="button" value="取消" />';
        }
        _html += '</div></div>';

        //必须先将_html添加到body，再设置Css样式
        $("body").append(_html); GenerateCss();
    }

    //生成Css
    var GenerateCss = function () {

        $("#mb_box").css({
            width: '100%', height: '100%', zIndex: '99999', position: 'fixed',
            filter: 'Alpha(opacity=60)', backgroundColor: 'black', top: '0', left: '0', opacity: '0.6'
        });

        $("#mb_con").css({
            zIndex: '999999', width: '80%', position: 'fixed',
            backgroundColor: 'White', borderRadius: '15px'
        });

        $("#mb_tit").css({
            display: 'block', fontSize: '15px', color: 'White', padding: '10px 15px', lineHeight: '20px',
            backgroundColor: '#30954C', borderRadius: '15px 15px 0 0',
            borderBottom: '3px solid #30954C', fontWeight: 'bold'
        });

        $("#mb_msg").css({
            padding: '20px', lineHeight: '20px', "margin-top": '5px',
            borderBottom: '1px dashed #DDD', fontSize: '15px', fontWeight: 'bold'
        });

        $("#mb_ico").css({
            display: 'block', position: 'absolute', right: '10px', top: '9px',
            border: '0px solid Gray', width: '128px', height: '28px', textAlign: 'center',
            lineHeight: '16px', cursor: 'pointer', borderRadius: '12px', fontFamily: '微软雅黑', fontSize: '15px'
        });

        $("#mb_btnbox").css({ margin: '15px 0 10px 0', textAlign: 'center', lineHeight: '10px' });
        $("#mb_btn_ok,#mb_btn_no").css({ width: '150px', height: '35px', color: 'white', border: 'none', fontSize: '15px', padding: '5px' });
        $("#mb_btn_ok").css({ backgroundColor: '#30954C', fontSize: '15px' });
        $("#mb_btn_no").css({ backgroundColor: 'gray', marginLeft: '20px', fontSize: '15px' });


        //右上角关闭按钮hover样式
        $("#mb_ico").hover(function () {
            $(this).css({ backgroundColor: 'Red', color: 'White' });
        }, function () {
            $(this).css({ backgroundColor: '#DDD', color: 'black' });
        });

        var _widht = document.documentElement.clientWidth; //屏幕宽
        var _height = document.documentElement.clientHeight; //屏幕高

        var boxWidth = $("#mb_con").width();
        var boxHeight = $("#mb_con").height();

        //让提示框居中
        $("#mb_con").css({ top: (_height - boxHeight) / 3 + "px", left: (_widht - boxWidth) / 2 + "px" });
    }


    //确定按钮事件
    var btnOk = function (callback) {
        $("#mb_btn_ok").click(function () {
            $("#mb_box,#mb_con").remove();
            if (typeof (callback) == 'function') {
                callback();
            }
        });
    }

    //取消按钮事件
    var btnNo = function () {
        $("#mb_btn_no,#mb_ico").click(function () {
            $("#mb_box,#mb_con").remove();
        });
    }

    //打包post请求
    function ajax(url, bc) {
        $.post(url, {

        },
        function (ret) {
            if (typeof (bc) == 'function') {
                bc(ret);
            }
        },
            "json"
        );
    }
})();