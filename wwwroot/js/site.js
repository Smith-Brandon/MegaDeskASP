// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


$(document).ready(function () {
    $('#Desk_Material').on('change', function () {
        $('#image1,#image2, #image3, #image4, #image5').hide();
        if (this.value === 'Oak') {
            $("#image1").show();
        }
        else if (this.value === 'Laminate') {
            $("#image2").show();
        }
        else if (this.value === 'Veneer') {
            $("#image3").show();
        }
        else if (this.value === 'Pine') {
            $("#image4").show();
        }
        else if (this.value === 'Rosewood') {
            $("#image5").show();
        }
        else {
            $("#image1").hide();
            $("#image2").hide();
            $("#image3").hide();
            $("#image4").hide();
            $("#image5").hide();
        }
    })
        .change();
});