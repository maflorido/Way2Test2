$(function () {
    var doc = $(document);

    $("#btnLstRepo").click(function () {
        $.post("/Repositorios/ObterRepositoriosUsuario").success(function (data) {
            $("#resultado").html(data);
        });
    });

    $("#btnBuscarNome").click(function () {
        var campoNome= $("#NomeRepositorio");

        if(campoNome.valid())
        {            
            $.post("/Repositorios/ObterRepositoriosNome", { NomeRepositorio: campoNome.val() }).success(function (data) {
                $("#resultado").html(data);
            });
        }        
    });

    $("#detalhes-repositorio").click(function () {
        var nomeRepo = $(this).data("repositorio");

        $.post("/Repositorios/Detalhes", { nome: nomeRepo }).success(function (data) {
            $("#resultado").html(data);
        });
    });
});
