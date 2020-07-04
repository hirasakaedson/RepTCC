var TelefoneMaskBehavior = function (val) {
    return val.replace(/\D/g, '').length <= 10 ? '(00) 0000-00009' : '(00) 00000-0000';
},
    telefoneMaskBehaviorOptions = {
        onKeyPress: function (val, e, field, options) {
            field.mask(TelefoneMaskBehavior.apply({}, arguments), options);
        }
    };

$(document).ready(function() {
    
    $(':input[name=Contato]').mask(TelefoneMaskBehavior, telefoneMaskBehaviorOptions);
})
$(document).ready(function () {

    $(':input[name=Contato2]').mask(TelefoneMaskBehavior, telefoneMaskBehaviorOptions);
})




