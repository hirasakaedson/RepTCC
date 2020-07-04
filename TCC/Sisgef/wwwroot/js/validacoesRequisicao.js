
$('#Responsavel').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Motorista').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#TipoDeServico').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Observacoes').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Litros').keypress(function (e) {
    var regex = new RegExp("^[0-9]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
