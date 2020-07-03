
$(document).ready(function () {
    $("#Valor").mask("999.999.990,00", { reverse: true })
})
$(document).ready(function () {
    $('#Data').mask('99/99/9999');
    return false;
});

const adicionar = document.getElementById("adicionar");

adicionar.addEventListener("click", function (event) {

    var table = document.getElementById("tabela");
    var row = table.insertRow(2);

    row.insertCell(0).innerHTML = "C�d. Produto:";
    row.insertCell(1).innerHTML = `<input type="text" name="codProduto[]" placeholder="CodProduto"> `;
    row.insertCell(2).innerHTML = "Quantidade";
    row.insertCell(3).innerHTML = `<input type="text" name="razao[]" placeholder="Quantidade">`;
    row.insertCell(4).innerHTML = "Desconto";
    row.insertCell(5).innerHTML = `<input type="text" name="desconto[]" placeholder="Desconto">`;

});

new Vue({
    el: "#app"
})













$('#Renavam').keypress(function (e) {
    var regex = new RegExp("^[0-9]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#NomeDoProprietario').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Placa').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Chassi').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});


$('#Marca').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Modelo').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#TipoCarroceria').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Cor').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});

});
$('#LocalDeEmplacamento').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#AnoFabricacao').keypress(function (e) {
    var regex = new RegExp("^[0-9]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Odometro').keypress(function (e) {
    var regex = new RegExp("^[0-9]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});

