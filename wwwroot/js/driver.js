//capturar o cep do usuário
var textCep = $("#cep");

textCep.on("input", function () {
    var cep = textCep.val().toString();
    if (cep != null || cep.length != 0) {
        validateCep(cep);
    }
});

//valida o cep
function validateCep(cep) {
    var cepClean = cep.toString().replace("-", "").replace(".", "");
    if (cepClean.length >= 8) {
        searchCep(cepClean);
    }
}

//Busca o CEP na API
function searchCep(cepClean){
    $.getJSON("https://viacep.com.br/ws/"+ cepClean +"/json/?callback=?", function(dados) {
        editInputsToSearch();
        if (!("erro" in dados)) {
            //Atualiza os campos com os valores da consulta.
            $("#streetName").val(dados.logradouro);
            $("#district").val(dados.bairro);
            $("#city").val(dados.localidade);
        } //end if.
        else {
            //CEP pesquisado não foi encontrado.
            cleaninputs();
            alert("CEP não encontrado.");
        }
    });
}

//msg de carregamento da busca do CEP
function editInputsToSearch(){
    $("#streetName").val("...");
    $("#district").val("...");
    $("#city").val("...");
}

//limpa os campos
function cleaninputs(){
    $("#streetName").val("");
    $("#district").val("");
    $("#city").val("");
}
