var EmailMaskBehavior = function (val) {
    return val.replace(/\D/g, '').length <= 11 ? '000.000.000-009' : '00.000.000/0000-00';
},
    cpfCnpjpOptions = {
        onKeyPress: function (val, e, field, options) {
            field.mask(EmailMaskBehavior.apply({}, arguments), options);
        }
    };

$(document).ready(function() {
    
    $(':input[name=CpfCnpj]').mask(EmailMaskBehavior, cpfCnpjpOptions);
})
