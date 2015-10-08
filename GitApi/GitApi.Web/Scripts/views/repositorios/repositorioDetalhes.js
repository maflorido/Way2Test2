$(function () {
    alert('chamou')
    $("#btn-favorito").click(function () {

        alert('chamou');
        var nomeRepo = $(this).data("nome-repo");
        var idRepo = $(this).data("id-repo");

        $.post("/Favoritos/AdicionarFavorito", { nomeRepositorio: nomeRepo, idRepositorioGit: idRepo }).success(function (data) {
            alert(data.mensagem);
        });
    });
});