﻿; (function (window, undefined, $) {

    $(document).ready(function () {

        var gridopt = {
            url: options.listUrl,
            colModel: [
                    { display: '编号', name: 'ID', width: "10%", sortable: true, hide: false, align: 'left', iskey: true },
                    { display: '名称', name: 'NAME', width: "30%", sortable: true, hide: false, align: 'left' },                 
                    { display: '售价', name: 'PRICE', width: "10%", sortable: false, align: 'left' },
                     { display: '有效期', name: 'PERIOD', width: "10%", sortable: false, align: 'left' },
                    { display: '状态', name: 'STATUS', width: "10%", sortable: false, align: 'left', process: formatStatus },
                    { display: '操作', name: 'ID', width: "20%", sortable: false, align: 'center', process: processOp }
                  
            ],
            sortname: "ID",
            sortorder: "ASC",
            title: false,
            rp: 15,
            usepager: true,
            showcheckbox: false
        };
        var xjgrid = new xjGrid("gridlist", gridopt);
        function processOp(value, cell) {
            var ops = [];
            ops.push("&nbsp;<a title='编辑疗程卡信息' class='abtn' href='javascript:;'  onclick=\"util.Edit('", value, "')\"><i class='fa fa-edit' ></i>编辑</a>");
            ops.push("&nbsp;&nbsp;<a title='删除疗程卡信息' class='abtn' href='javascript:;'  onclick=\"util.Delete('", value, "','", cell[0], "')\"><i class='fa fa-trash-o' ></i>删除</a>");
            return ops.join("");
        }
        function formatGender(value, cell) {
            if (value == "1") {
                return "男";
            }
            else {
                return "女";
            }
        }
        function formatStatus(value, cell) {
            if (value == "1") {
                return "启用";
            }
            else {
                return "关闭";
            }
        }
        function formatDate(value, cell) {
            if (value) {
                return value.split(" ")[0]
            }
            else {
                return "-"
            }
        }
        $("#formQuery").submit(function () {
            xjgrid.Query(this);
            return false;
        });

        $("#btnAdd").click(function (e) {
            window.location.href = options.editUrl;
        });

        $("#btnConfirm").click(function (e) {
            $('#confirmModal').modal('hide');
            var id = $("#hdCardId").val();
            $.post(options.deleteUrl + "/" + id, { id: id },
                  function (res) {
                      if (res.status == 0) {
                          showLoadingMsg("操作成功", { right: 100, top: 10 }, true, 5000);
                          xjgrid.Reload();
                      }
                      else {
                          showErrorTip("操作失败！：" + res.message, { right: 100, top: 10 }, true, 5000);
                      }
                  },
                  "json"
            );
        })
        util.Edit = function (id) {
            window.location.href = options.editUrl + "/" + id;
        };
        util.Delete = function (id, name) {
            $("#lbuserName").html(name);
            $("#hdCardId").val(id);
            $('#confirmModal').modal('show');
        };
    });

})(window, undefined, jQuery);