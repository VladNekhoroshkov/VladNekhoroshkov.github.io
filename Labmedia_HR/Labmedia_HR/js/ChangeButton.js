$(document).ready(() => {

    function event(e) {
        let field = $(this);
        field.val(field.val().replace(/\D/g, ''))
    }
    let save = $('.save');

    function saveEvent() {
        let self = $(this)
        let id = self.attr('id').split('-')[1];

        $('#vac').val($('#vacChange').val());
        $('#time').val($('#timeChange').val());
        $('#demands').val($('#demandsChange').val());
        $('#conditions').val($('#conditionsChange').val());
        $('#salary').val($('#salaryChange').val());

        document.getElementById('s').click();

    }

    save.on('click', saveEvent);

});