$(document).ready(function () {
    $('#groupNameSuggestions').change(function () {
        $('#GroupName').val($(this).find('option:selected').text());
    });

    $('#ModifiedDate').datepicker({
        format: 'yyyy-mm-dd'
    })
});

