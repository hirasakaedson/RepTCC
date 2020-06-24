$('#TipoDeServico').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Email').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9@._-]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Nome').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Rua').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9\u00C0-\u00FF ]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Numero').keypress(function (e) {
    var regex = new RegExp("^[a-zA-Z0-9]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
});
$('#Bairro').keypress(function (e) {
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

