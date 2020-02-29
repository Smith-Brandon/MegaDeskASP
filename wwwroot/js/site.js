$(document).ready(function () {
    $('a.nav-link[href="' + this.location.pathname + '"]').parent().addClass('active');
});

$(document).ready(function () {
    $('#Desk_Material').on('change', function () {
        $('#oak, #laminate, #veneer, #pine, #rosewood').hide();
        if (this.value === 'Oak') {
            $("#oak").show();
        }
        else if (this.value === 'Laminate') {
            $("#laminate").show();
        }
        else if (this.value === 'Veneer') {
            $("#veneer").show();
        }
        else if (this.value === 'Pine') {
            $("#pine").show();
        }
        else if (this.value === 'Rosewood') {
            $("#rosewood").show();
        }
        else {
            $("#oak").hide();
            $("#laminate").hide();
            $("#veneer").hide();
            $("#pine").hide();
            $("#rosewood").hide();
        }
    })
        .change();
});