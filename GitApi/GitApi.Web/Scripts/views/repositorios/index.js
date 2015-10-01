$(function () {
    var doc = $(document);

    doc.click("#btnLstRepo", function () {
        var ajax = new Framework.Post("/Repositorios/ObterRepositoriosUsuario");

        ajax.success(function (pData, pTextStatus, pJqXHR)
        {
            alert('sucesso');
        });
    });
});
