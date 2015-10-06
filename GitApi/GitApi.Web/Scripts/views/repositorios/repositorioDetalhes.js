$(function () {
    $("#btn-favorito").click(function () {
        var nomeRepo = $(this).data("nome-repo");
        var idRepo = $(this).data("id-repo");

        $.post("/Favoritos/AdicionarFavorito", { nomeRepositorio: nomeRepo, idRepositorioGit: idRepo}).success(function (data) {
            alert(data.mensagem);
        });
    });
});