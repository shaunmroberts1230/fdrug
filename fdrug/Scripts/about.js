function show(div) {
    $('#fdContent').fadeOut();

    $(div).fadeIn();
}
function hide(div) {
    $(div).fadeOut();
    $('#fdContent').fadeIn();
}