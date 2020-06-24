$('#Placa').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9._\b]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }

    e.preventDefault();
    return false;
});

$('#Chassi').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9._\b]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }

    e.preventDefault();
    return false;
});
$('#TipoCarroceria').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9._\b]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }

    e.preventDefault();
    return false;
});


$('#Renavam').keypress(function (e) {
    var regex = new RegExp("[0-9]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});

$('#Odometro').keypress(function (e) {
    var regex = new RegExp("[0-9]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});



$('#LocalDeEmplacamento').keypress(function (e) {
    var regex = new RegExp("[a-z\s]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }

    e.preventDefault();
    return false;
});
$('#TipoCarroceria').keypress(function (e) {
    var regex = new RegExp("[a-z\s]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }

    e.preventDefault();
    return false;
});
$('#Cor').keypress(function (e) {
    var regex = new RegExp("[a-z\s]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }

    e.preventDefault();
    return false;
});

$('#AnoFabricacao').keypress(function (e) {
    var regex = new RegExp("[[0-9]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }

    e.preventDefault();
    return false;
});

$('#Marca').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9._\b-]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }

    e.preventDefault();
    return false;
});
$('#Modelo').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9._\b-]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }

    e.preventDefault();
    return false;
});


