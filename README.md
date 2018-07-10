Mutantes Nivel 2

Projeto desenvolvido em .Net Core 
Este projeto não possui banco de dados, a API retorna status HTTP Code 200 quando a matriz esta de acordo com o especificado ou http code 403 quando não possui o padrão esperado.
Caso ocorra um erro no processamento é retornado um status code 500.
Para realizar o teste em ambiente local, usar o endereço: 

<code>http://localhost:36042/mutant</code><br>

Exemplo de requisição:<br>
<code>
{ "dna":["ATGCGA","CAGTGC","TTATGT","AGAAGG","CCTCTA","TCACTG"] }
</code>
<i> Enviar como application/json </i>

Este projeto não possui banco de dados, a API retorna status HTTP Code 200 quando a matriz esta de acordo com o especificado ou http code 403 quando não possui o padrão esperado.
Para facilitar os testes, o projeto esta publicado no endereço: 

[POST]
<code>http://mutantes-nivel2.azurewebsites.net/mutant</code>
