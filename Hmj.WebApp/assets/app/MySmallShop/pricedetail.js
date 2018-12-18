﻿; (function (window, undefined, $) {

    $(document).ready(function () {
        var gridopt = {
            url: options.listUrl + "?id=" + (getQueryString("id") || -1),
            colModel: [
                    { display: '编号', name: 'Id', width: "0", sortable: true, hide: true, align: 'left', iskey: true },
                    { display: '名称', name: 'Name', width: "15%", sortable: false, align: 'left' },
                    //{ display: '门店编号', name: 'STORE_NO', width: "15%", sortable: false, align: 'left' },
                    //{ display: '省份', name: 'PROVINCE', width: "10%", sortable: false, align: 'left' },
                    //{ display: '城市', name: 'CITY', width: "10%", sortable: false, align: 'left' },
                    //{ display: '地区', name: 'REGION', width: "10%", sortable: false, align: 'left' },
                    //{ display: '地址', name: 'ADDRESS', width: "10%", sortable: false, align: 'left' },
                    //{ display: '门店电话', name: 'TELEPHONE', width: "10%", sortable: false, align: 'left' },
                    //{ display: '导航', name: 'ID', width: "15%", sortable: false, align: 'center', process: processOp2 },
                    { display: '操作', name: 'Id', width: "15%", sortable: false, align: 'center', process: processOp }
            ],
            sortname: "id",
            sortorder: "ASC",
            title: false,
            rp: 15,
            usepager: true,
            showcheckbox: false
        };
        var xjgrid = new xjGrid("gridlist", gridopt);
        function processOp2(value, cell) {
            var ops = [];
            ops.push("&nbsp;<a title='编辑信息' class='abtn' href='javascript:;'  onclick=\"util.Edit('", value, "')\"><i class='fa fa-edit' ></i>发型师</a>");
            ops.push("&nbsp;&nbsp;<a title='删除信息' class='abtn' href='javascript:;'  onclick=\"util.Delete('", value, "')\"><i class='fa fa-trash-o' ></i>促销券</a>");
            ops.push("&nbsp;&nbsp;<a title='删除信息' class='abtn' href='javascript:;'  onclick=\"util.Delete('", value, "')\"><i class='fa fa-trash-o' ></i>预约配置</a>");
            return ops.join("");
        }

        function processOp(value, cell) {
            var ops = [];
            ops.push("&nbsp;<a title='编辑信息' class='abtn' href='javascript:;'  onclick=\"util.Edit('", value, "')\"><i class='fa fa-edit' ></i>编辑</a>");
            ops.push("&nbsp;&nbsp;<a title='删除信息' class='abtn' href='javascript:;'  onclick=\"util.Delete('", value, "')\"><i class='fa fa-trash-o' ></i>删除</a>");
            return ops.join("");
        }

        $("#formQuery").submit(function () {
            xjgrid.Query(this);
            return false;
        });

        $("#qb").click(function (e) {
            $("#replyType").val(0);
            $("#formQuery2").submit();
        });

        $("#gjz").click(function (e) {
            $("#replyType").val(1);
            $("#formQuery2").submit();
        });

        $("#bgz").click(function (e) {
            $("#replyType").val(2);
            $("#formQuery2").submit();
        });

        $("#zdhf").click(function (e) {
            $("#replyType").val(3);
            $("#formQuery2").submit();
        });


        $("#formQuery2").submit(function () {
            xjgrid.Query(this);
            return false;
        });
        $("#btnAdd").click(function (e) {
            location = "PriceDetailEdit.do?id=0&pid="+ (getQueryString("id") || -1);
            //$("#ID").val(0);
            //$("#divkeys").show();
            //$("#divtype").show();
            //$("#divnews").show();
            //$("#divtext").hide();
            //$('#frmSave')[0].reset();
            //$('#EditModal').modal('show');
        });

        util.Edit = function (id) {
            location = "PriceDetailEdit.do?id="+id+"&pid=" + (getQueryString("id") || -1);
            
        };

        util.Detail = function (id) {
            location = "ProDetail.do?id=" + id;

        };

        function TreeNode_Click(data) {
            data.expand();
        }

        $("#btnSave").click(function (e) {
            $("#frmSave").submit();
        });

        $("#btnClose").click(function (e) {
            $('#EditModal').modal('hide');
        });



        $("#MsgType").change(function (e) {
            if ($(this).val() == "text") {
                $("#divnews").hide();
                $("#divtext").show();
            }
            else {
                $("#divnews").show();
                $("#divtext").hide();
            }
        });

        $("#replyType").change(function (e) {
            if ($(this).val() == "1") {
                $("#divkeys").show();
                $("#divtype").show();
            }
            else {
                $("#divkeys").hide();
                $("#divtype").hide();
            }
        });

        $('#frmSave').validator({
            rules: {
            },
            fields: {

            },
            valid: function (form) {
                FormSubmit(form, function (res) {
                    if (res.status == 0) {
                        _showInfoMessage("操作成功！", 'success');
                        $('#EditModal').modal('hide');
                        xjgrid.Reload();
                        //location = "Informations.do";
                    }
                    else {
                        _showInfoMessage("操作失败：" + res.message, 'error');
                        //showErrorTip("操作失败！：" + res.message, { left: 100, top: 10 }, true, 5000);
                    }
                })
            }
        });

        util.Delete = function (id) {
            $("#hdCurrentId").val(id);
            $('#confirmModal').modal('show');
        };

        $("#btnConfirm").click(function (e) {
            $('#confirmModal').modal('hide');
            var id = $("#hdCurrentId").val();
            $.post(options.deleteUrl + "/" + id, { id: id },
                  function (res) {
                      if (res.status == 0) {
                          _showInfoMessage("操作成功！", 'success');
                          xjgrid.Reload();
                      }
                      else {
                          _showInfoMessage("操作失败：" + res.message, 'error');
                      }
                  },
                  "json"
            );
        })

        function getQueryString(name) {
            var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i");
            var r = window.location.search.substr(1).match(reg);
            if (r != null) return r[2]; return null;
        }

    });

})(window, undefined, jQuery);