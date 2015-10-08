$(function () {
    var doc = $(document);

    $("#btnLstRepo").click(function () {
        $.post("/Repositorios/ObterRepositoriosUsuario").success(function (data) {
            $("#resultado").html(data);
        }).error(function () {
            alert("Erro ao processar requisição!");
        });
    });

    $("#btnBuscarNome").click(function () {
        var campoNome= $("#NomeRepositorio");

        if(campoNome.valid())
        {            
            $.post("/Repositorios/ObterRepositoriosNome", { NomeRepositorio: campoNome.val() }).success(function (data) {
                $("#resultado").html(data);
            }).error(function () {
                alert("Erro ao processar requisição!");
            });
        }        
    });       
});

function registrarEventosListagem() {
    $("#detalhes-repositorio").unbind("click", null);

    $("#detalhes-repositorio").click(function () {
        var nomeRepo = $(this).data("repositorio");

        $.post("/Repositorios/Detalhes", { nome: $(this).data("name"), login: $(this).data("login") }).success(function (data) {
            $("#resultado").html(data);
        }).error(function () {
            alert("Erro ao processar requisição!");
        });
    });
}
