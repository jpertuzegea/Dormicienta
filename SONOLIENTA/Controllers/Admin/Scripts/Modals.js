// llamado de modales para los modulos


// -------- inicio Usuario --------
function CrearUsuario() {
    $("#contenido").load("/Usuario/UsuarioAdd");
}
function ModificarUsuario(id) {
    $("#contenido").load("/Usuario/UsuarioUpdt/" + id);
} // -------- fin Usuario --------

// -------- inicio Categoria --------
function CrearCategoria() {
    $("#contenido").load("/Categoria/CategoriaAdd");
}
function ModificarCategoria(id) {
    $("#contenido").load("/Categoria/CategoriaUpdt/" + id);
} // -------- fin Categoria --------

