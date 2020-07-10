// Aca se realiza  la validacion para evitar que se ejecute el submit de unformulario mas de una vez 

function ValidarDobleClic() {

    // para que funcione, se debe cambiar la linea del form por la siguiente, adecuando el controlador y la accion  
    // @using (Html.BeginForm("accion", "controlador", FormMethod.Post, new { onsubmit = "return  ValidarDobleClic()" })) { // el return indica que la accion del formulario llega false cuando ya le han dado clic una vez

    // alert("entro a la funcion ");
    document.getElementById("boton").disabled = true; // nombre del boton 
    document.getElementById("boton").innerHTML = "Enviando..."; // nombre del boton 
    return true;
}

function UpperCase(texto) {
    texto.value = texto.value.toUpperCase();
}
