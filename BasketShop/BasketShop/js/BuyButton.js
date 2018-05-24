$('.d').on('click', (e) => {
    $('#field').val(e.currentTarget.attributes[0].value);
    eventFire(document.getElementById('delete'), 'click');
});
$('#main').on('click', () => {
    window.location.replace('/');
});

$('#exit').on('click', () => {
    window.location.replace('/signout');
});