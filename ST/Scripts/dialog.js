$(function () {
    $("#dialog").dialog({ autoOpen: false, modal: true, resizable: false, autoSize: true, height: 900, width: 500 });
    $("#AddEmployeeBtn").click(function () {
        $.ajax({
            type: "GET",
            url: '../Employee/Create',
            success: function (data) {
                $('#modalcontent').html(data);
            }
        })
        $("#dialog").dialog("open");
    });

    $("#dialog").dialog({ autoOpen: false, modal: true, resizable: false, autoSize: true, width: 600, height: 450 });
    $(".EditEmployeeBtn").click(function () {
        var id = $(this).attr('dynamicid');
        $.ajax({
            type: "GET",
            url: '../Employee/Edit/' + id,
            success: function (data) {
                $('#modalcontent').html(data);
            }
        })
        $("#dialog").dialog("open");
    });

    $("#dialog").dialog({ autoOpen: false, modal: true, resizable: false, autoSize: true, width: 600, height: 450 });
    $(".DeleteEmployeeBtn").click(function () {
        var id = $(this).attr('dynamicid');
        $.ajax({
            type: "GET",
            url: '../Employee/Delete/' + id,
            success: function (data) {
                $('#modalcontent').html(data);
            }
        })
        $("#dialog").dialog("open");
    });

    $("#dialog").dialog({ autoOpen: false, modal: true, resizable: false, autoSize: true, width: 600, height: 450 });
    $("#AddNewsBtn").click(function () {
        $.ajax({
            type: "GET",
            url: '../News/Create',
            success: function (data) {
                $('#modalcontent').html(data);
            }
        })
        $("#dialog").dialog("open");
    });

    $("#dialog").dialog({ autoOpen: false, modal: true, resizable: false, autoSize: true, width: 600, height: 450 });
    $(".EditNewsBtn").click(function () {
        var id = $(this).attr('dynamicid');
        $.ajax({
            type: "GET",
            url: '../News/Edit/' + id,
            success: function (data) {
                $('#modalcontent').html(data);
            }
        })
        $("#dialog").dialog("open");
    });

    $("#dialog").dialog({ autoOpen: false, modal: true, resizable: false, autoSize: true, width: 600, height: 450 });
    $(".DeleteNewsBtn").click(function () {
        var id = $(this).attr('dynamicid');
        $.ajax({
            type: "GET",
            url: '../News/Delete/' + id,
            success: function (data) {
                $('#modalcontent').html(data);
            }
        })
        $("#dialog").dialog("open");
    });
});