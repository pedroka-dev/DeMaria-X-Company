# DeMaria Company X
Parte do processo seletivo para a vaga de Desenvolvedor Pleno C# da empresa DeMaria. Essa aplicação foi realizada em 5 dias (entre dia 24/06 até 28/06). Meu principal objetivo é demostrar não só minhas habilidades técnicas, mas também habilidades no planejamento, prototipação e organização no contexto do ciclo de desenvolvimento.

# Requisitos 
Cenário: A empresa X precisa de um sistema para gerenciar seus clientes e produtos. O sistema deve permitir:
* Cadastrar, editar e remover clientes, com informações como nome, endereço, telefone e email.
* Cadastrar, editar e remover produtos, com informações como nome, descrição, preço e estoque.
* Realizar a venda de produtos, registrando o cliente, os produtos e a quantidade de cada item.
* Gerar relatórios de vendas, clientes e estoque.

Requisitos técnicos:
* C#
* Windows Forms
* PostgreSQL (especificar versão na entrega)
* NPGSQL
* Git
* ReportViewer

Tarefas:
* Criar o banco de dados:
  * Criar as tabelas para clientes, produtos e vendas no PostgreSQL.
  * Definir as chaves primárias, estrangeiras e índices.
  * Criar as queries para inserir, atualizar, remover e consultar dados.

* Desenvolver a aplicação desktop:
  * Criar a interface gráfica do usuário (GUI) utilizando Windows Forms.
  * Implementar a funcionalidade de cadastro, edição e remoção para as entidades criadas.
  * Implementar a funcionalidade de geração de relatórios utilizando o ReportViewer.
  * Utilizar a biblioteca NPGSQL para acessar o banco de dados.

* Testar a aplicação (Opcional - Será considerado um direrencial o desenvolvimento desta etapa):
  * Realizar testes unitários para verificar o funcionamento correto de cada módulo da aplicação.
  * Realizar testes de integração para verificar a interação entre os diferentes módulos.
  * Documentar os testes realizados e os resultados.

# Dia 1 - Planejamento 
Nessa etapa é necessário realizar o planejamento da aplicação. C:
* Modelagem de Classe: Utilização de UML para modelar a classes que serão utilizada, para fins de documentação e para ser utilzando como referência na criação do domínio e banco de dados da aplicação
* Definições de Negócios: Define as regras de negócios levando em consideração os requisitos, simulando as definições de négocio oferecidas por um Product Manager. 
* Definições Visuais: Define a aparência da interface Windows Forms, simulando as definições visuais oferecidas por um Product Managetr.
* Sprint Planning: Definine o escopo e realiza criação de tarefas no Backlog do quadro Kanbam, simulando um sprint planning da metodologia Scrum.
  
### Modelagem de Classe
Para modelagem de classe, foi utilizado o draw.io para fazer um diagrama de clasess UML. Foi escolhido 0..* para 1 para ambos as relações "Sale"<->"Client" quanto "Sale"<->"Product", ou seja, uma venda sempre deve obrigatoriamente ter um cliente e um produto. Nesse contexto, o atributo "quantity" representa a quantidade de produtos do mesmo tipo que foram vendidos. 

Todas as classes vão possuir um método chamado "Validate()" que retorna uma mensagem de erro ou sucesso, com o objetivo de verificar o input do usuário antes de enviar para o banco. 

![Company X drawio(2)](https://github.com/pedro-ca/DeMaria-X-Company/assets/50923316/ece0afd6-ba9f-4496-a4ac-0144925bc4a0)

Foi ponderado também a possibilidade de poder haver mais que um tipo de produto em uma venda, em uma relação 1..* para 1..*. Porém essa ideia foi descarta pois aumentaria o escopo da aplicação e poderia fugir dos requisitos previamente estipulados.

### Definições de Negócios
Levando em consideração os requisitos, podemos abstrair as seguintes regras de negócio implicitas para as 3 classes:
* Product:
  * Atributo "name" não pode ser vazio
  * Atributo "description" não pode ser vazio
  * Atributo "price" não pode ser um valor menor ou igual a zero
  * Atributo "inStock" não pode ser um valor menor que zero
  * Objeto não pode ser removido caso houver "Sale" atrelada
* Client:
  * Atributo "name" não pode ser vazio
  * Atributo "address" não pode ser vazio
  * Atributo "phone" deve ser um número de telefone válido
  * Atributo "email" deve ser um email válido
  * Objeto não pode ser removido caso houver "Sale" atrelada
* Sale:
  * Atributo "Client" não deve ser nulo
  * Atributo "Product" não deve ser nulo
  * Em relação a quantidade de itens:
    * Atributo "quantity" não pode ser um valor menor ou igual a zero
    * Não deve permitir a venda caso o atributo "InStock" do "Product" atrelado seja menor que a quantidade desejada de compra
    * Ao cadastrar venda, deve subtrair a quantidade de itens vendidos do atributo "InStock" do "Product" atrelado

### Definições Visuais
Para as definições, foi utilizado o Figma para criar um protótipo de interface. Esse protótipo apresenta um menu principal com 3 botões, cada um apontando para a tela de cada uma das classes. Cada tela possui um ReportViewer, um botão "New", um botão "Edit" e um botão "Delete". Como estilo do tema, foi utilizado o X (antigo Twitter) como inspiração

![image](https://github.com/pedro-ca/DeMaria-X-Company/assets/50923316/0332a507-469b-473d-8a2c-c1effecb2612)


### Sprint Planning
Foi criado um quadro Kamban contendo tarefas para as features do projeto. O padrão escolhido para a escrita de todas as stories é:
* Justificativa (Como X, Desejo Y)
* Definições visuais
* Definições Técnicas (se houver)
* Definições de Negócio (se houver)

No total foi criado 7 user stories. Elas foram dividas por classe (product, client, sale). Porém por razões de um escopo tecnológico adicional (ReportViewer), as operações de visualizar ganharam histórias aparte. As stories que foram criadas são:
* [Tela Principal](https://github.com/pedro-ca/DeMaria-X-Company/issues/1)
* [Visualizar Product](https://github.com/pedro-ca/DeMaria-X-Company/issues/2)
* [Visualizar Client](https://github.com/pedro-ca/DeMaria-X-Company/issues/3) 
* [Visualizar Sales](https://github.com/pedro-ca/DeMaria-X-Company/issues/4)
* [Inserir, Editar e Remover Product](https://github.com/pedro-ca/DeMaria-X-Company/issues/5)
* [Inserir, Editar e Remover Client](https://github.com/pedro-ca/DeMaria-X-Company/issues/6)
* [Inserir, Editar e Remover Sale](https://github.com/pedro-ca/DeMaria-X-Company/issues/7)
![image](https://github.com/pedro-ca/DeMaria-X-Company/assets/50923316/7ab29d07-64cd-4d29-babe-8085658e0236)




