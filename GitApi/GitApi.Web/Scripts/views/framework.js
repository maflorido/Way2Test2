var Framework = {
    Post: function (pUrl, parametros) {

        return $.ajax({
            type: "POST",
            data: JSON.stringify(parametros),
            url: pUrl,
            contentType: 'application/json; charset=utf-8'
        });
    }    
};