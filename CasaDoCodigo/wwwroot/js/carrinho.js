class Carrinho {
    clickIncremento(btnClicked) {
        let data = this.GetData(btnClicked);
        data.Quantidade++;
        this.PostQuantidade(data);
    }

    clickDecremento(btnClicked) {
        let data = this.GetData(btnClicked);
        data.Quantidade--;
        this.PostQuantidade(data);
    }

    inputUpdateQuantidade(input) {
        let data = this.GetData(input);
        this.PostQuantidade(data);
    }

    GetData(elemento) {
        let linhaDoItem = $(elemento).parents("[item-id]");
        let itemId = $(linhaDoItem).attr("item-id");
        let novaQtde = parseInt($(linhaDoItem).find("input[type = 'text']").val());

        return { Id: itemId, Quantidade: novaQtde }
    }

    PostQuantidade(data) {

        let headers = {};
        let token = $("[name='__RequestVerificationToken']").val();
        headers["RequestVerificationToken"] = token;



        $.ajax({
            url: '/Pedido/UpdateQuantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: headers
        }).done(function (response) {
            let carrinhoViewModel = response.carrinhoViewModel;
            let itemPedido = response.itemPedido;
            let linhaDoItem = $('[item-id=' + itemPedido.id + ']');
            linhaDoItem.find('input[type="text"]').val(itemPedido.quantidade);
            linhaDoItem.find('span[subtotal]').html((itemPedido.quantidade * itemPedido.precoUnitario).duasCasas());
            $('span[total]').html((carrinhoViewModel.total).duasCasas());


            if (itemPedido.quantidade <= 0) {
                linhaDoItem.remove();
            }

            $("span[numero-itens]").html("Total: " + carrinhoViewModel.itens.length + " itens");

        });
    }
}

let carrinho = new Carrinho();

Number.prototype.duasCasas = function () {
    return this.toFixed(2).replace(".", ",")
}