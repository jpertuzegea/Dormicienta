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


// -------- inicio Marca --------
function CrearMarca() {
    $("#contenido").load("/Marca/MarcaAdd");
}
function ModificarMarca(id) {
    $("#contenido").load("/Marca/MarcaUpdt/" + id);
} // -------- fin Marca --------


// -------- inicio Producto --------
function CrearProducto() {
    $("#contenido").load("/Producto/ProductoAdd");
}
function ModificarProducto(id) {
    $("#contenido").load("/Producto/ProductoUpdt/" + id);
} // -------- fin Marca --------

