$(document).ready(function () {

    //Set selected tab
   /* var selected = $(this).attr('title').replace(/\s/g, '');
    $('#' + selected).addClass('active');
    $('.nav li').click(function () {
        $('.nav li').removeClass('active');
        $(this).addClass('active');
    });*/

    $('#employee_table tr').click(function () {
        /*$(this).attr('id');*/
        var selected = $(this).attr('id');
        alert(selected);
    });


    /*function Details(currentModel) {
        var id = $('tr.selected.').attr('id');
        $.ajax({
            url: '../Employee/Details/' + id,
            type: 'GET',
            success: function (data) {
                $('#user_content').html(data);
            }
        })
    }*/