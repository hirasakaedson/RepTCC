var CpfCnpjMaskBehavior = function (val) {
    return val.replace(/\D/g, '').length <= 11 ? '000.000.000-009' : '00.000.000/0000-00';
},
    cpfCnpjpOptions = {
        onKeyPress: function (val, e, field, options) {
            field.mask(CpfCnpjMaskBehavior.apply({}, arguments), options);
        }
    };

$(document).ready(function() {
    
    $(':input[name=CpfCnpj]').mask(CpfCnpjMaskBehavior, cpfCnpjpOptions);
})
