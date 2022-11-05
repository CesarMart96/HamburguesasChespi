window.onload = function () {
    ListaClientes();
}

function ListaClientes() {
    pintar({
        url: "Cliente/ListaClientes",
        propiedades: ["nombreCompleto", "direccion"],
        cabeceras: ["Nombre Completo", "Direccion"]
    })
}
