var ValorMaskBehavior = function (val) {
    return val.replace(/\D/g, '').length <= 11 ? '000.000.000-009' : '00.000.000/0000-00';
},
    valorOptions = {
        onKeyPress: function (val, e, field, options) {
            field.mask(ValorMaskBehavior.apply({}, arguments), options);
        }
    };

$(document).ready(function() {
    
    $(':input[name=CpfCnpj]').mask(ValorMaskBehavior, valorOptions);
})
