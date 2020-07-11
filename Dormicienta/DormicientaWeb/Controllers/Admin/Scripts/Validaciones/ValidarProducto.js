
$("#BotonRegistrar").click(function () {
      
    // validacion ajax que los campos ingresados no existan en la bd 
    var resultado;

    var datos = {
        Codigo: $("#Codigo").val()
    }

    $.ajax({
        type: 'POST',
        url: 'Producto/ValidarCodigoProducto',
        data: datos,
        success: function (result) {
            resultado = result;
        },
        dataType: 'json',
        async: false
    });

    if (resultado) {
        toastr.error('El Codigo Ingresado ya se encuentra registrada', 'ERROR');
        return false;
    }
});
