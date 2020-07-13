
$("#Codigo").blur(function () {// Se ejecuta cuando el campo pierde el foco
      
    // validacion ajax que los campos ingresados no existan en la bd 
    var resultado;

    var datos = {
        Codigo: $("#Codigo").val()
    }

    $.ajax({
        type: 'POST',
        url: 'ProductosWebApi/ValidarCodigo',
        data: datos,
        success: function (result) {
            resultado = result;
        },
        dataType: 'json',
        async: false
    });

    if (resultado) {
   //  $("#Codigo").focus();
        toastr.error('El Codigo Ingresado ya se encuentra registrado', 'ERROR');
        return false;
    }
});
