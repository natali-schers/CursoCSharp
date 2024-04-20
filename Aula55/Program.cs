// Encapsulamento: esconde detalhes de implementação de um componente, expondo apenas operações seguras que o mantenham em um estado consistente
// Exemplo: rádio - operações básica: tocar, pausar, avançar e voltar música. Operações internas ficam fora do alcance do usuário.

// Todo atributo será definido como private
// São implementados get(pegar) e set(definir) para cada atributo

using Aula55;

Produto produto = new Produto("TV", 900.00, 10);

Console.WriteLine(produto.GetNome());

produto.SetNome("TV 4k");

Console.WriteLine(produto.GetNome());