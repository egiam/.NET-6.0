// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//mostrarBolilla() en el html, del 1 al 90 incluido y sin repetir

var bolillas = [];

function mostrarBolilla() {
    var bolilla = Math.floor(Math.random() * 90) + 1;
    if (bolillas.includes(bolilla)) {
        mostrarBolilla();
    } else {
        bolillas.push(bolilla);
        document.getElementById("bolilla").innerHTML = bolilla;
        var hdnfldVariable = document.getElementById('hdnfldVariable');
        hdnfldVariable.value = bolilla;
    }

    // Si bolilla coincide con un numero del td, el mismo se pone con background color rojo
    //var td = document.querySelectorAll(bolilla.toString());
    var td = document.getElementsByClassName(bolilla.toString());
    if (td != null) {
        td.forEach(function (element) {
            element.style.backgroundColor = "red";
        });
    }
}
