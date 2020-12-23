$(document).ready(function () {

    if ($('tr.selected').length != 0) {
        Details('employee');
        ToggleUserButtonsState();
    }

    $('tr.employee').live('click', function () {
        $('tr.employee').removeClass('selected');
        $(this).addClass('selected');
        
        var id = $(this).attr('id');
        $.ajax({
            url: '../Employee/Details/' + id,
            type: 'GET',
            success: function (data) {
                $('#user_content').html(data);
            }
        })
       //alert(id);
        ToggleUserButtonsState();
        Details('employee');
    });

});

function InitializeUserTable($table, sortCol, sorting) {
    $dataTable = $table.dataTable({
        "sPaginationType": "bootstrap",
        "aaSorting": [[sortCol != undefined ? sortCol : 1, sorting || 'asc']],
        "oLanguage": {
			"sLengthMenu": "Display _MENU_ "
		},
    });

    $dataTable.fnFilter('Yes', 3);

    $('.show_inactive input').click(function () {
        if ($(this).val() == 'Yes') {
            var selected = $('tr.selected');
            $dataTable.fnFilter('', 3);
            if ($('tr.selected') != selected) {
                $('tr.selected').removeClass('selected');
            }
            selected.addClass('selected');
            ToggleUserButtonsState();
        }
        else if ($(this).val() == 'No') {
            $dataTable.fnFilter('Yes', 3);
            ToggleUserButtonsState();
        }
    });
}