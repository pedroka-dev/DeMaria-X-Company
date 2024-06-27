# DeMaria Company X
Parte do processo seletivo para a vaga de Desenvolvedor Pleno C# da empresa DeMaria. Essa aplicação foi realizada em 5 dias (entre dia 24/06 até 28/06). Meu principal objetivo é demostrar não só minhas habilidades técnicas, mas também habilidades no planejamento, prototipação e organização no contexto do ciclo de desenvolvimento. Foi utilizado PostGres 16 e .NET 8.0 para realização desse projeto.

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

# Planejamento Inicial 
Essa etapa foi realizada no primeiro dia, para analisar os requisitos e escopo da aplicação. O planejamento pode ser dividido em 4 sub etapas:
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
Para as definições, foi utilizado o Figma para criar um protótipo de interface. Esse protótipo apresenta um menu principal com 3 botões, cada um apontando para a tela de cada uma das classes. 

Cada tela possui um ReportViewer, um botão "New", um botão "Edit", um botão "Delete" e um botão "Report". Como estilo do tema, foi utilizado o X (antigo Twitter) como inspiração
![image](https://github.com/pedro-ca/DeMaria-X-Company/assets/50923316/588e2d0a-4663-4fe4-ba2a-19113d1cbc99)

### Sprint Planning
Foi criado um quadro Kamban contendo tarefas para as features do projeto. O padrão escolhido para a escrita de todas as stories é:
* Justificativa (Como X, Desejo Y)
* Definições visuais
* Definições Técnicas (se houver)
* Definições de Negócio (se houver)

No total foi criado 10 user stories. A divisão foi realizada baseada na similaridade de escopo entre elas. As stories que foram criadas são:
* [Tela Principal](https://github.com/pedro-ca/DeMaria-X-Company/issues/1)
* [Visualizar Product](https://github.com/pedro-ca/DeMaria-X-Company/issues/2)
* [Visualizar Client](https://github.com/pedro-ca/DeMaria-X-Company/issues/3) 
* [Visualizar Sales](https://github.com/pedro-ca/DeMaria-X-Company/issues/4)
* [Inserir, Editar e Remover Product](https://github.com/pedro-ca/DeMaria-X-Company/issues/5)
* [Inserir, Editar e Remover Client](https://github.com/pedro-ca/DeMaria-X-Company/issues/6)
* [Inserir, Editar e Remover Sale](https://github.com/pedro-ca/DeMaria-X-Company/issues/7)
* [Client Report](https://github.com/pedro-ca/DeMaria-X-Company/issues/9)
* [Product Report](https://github.com/pedro-ca/DeMaria-X-Company/issues/10)
* [Sale Report](https://github.com/pedro-ca/DeMaria-X-Company/issues/11)
![image](https://github.com/pedro-ca/DeMaria-X-Company/assets/50923316/43410626-110b-4b31-af12-93c7b5f5d84b)


# Desenvolvimento
Aqui está documentado algumas notas, observações e informações importantes sobre o desenvolvimento. 

### Conexão com o PortgresSQL utilizando ORM
Para conexão com o banco de dados PostgresSQL 16, foi utilizado o principio de design chamado Object Relational Mapping (ORM) ao invés de ADO.Net. Através do Entity Framework e do NPGSQL, o design ORM permite integração do PostgresSQL com maior grau de escalabilidade e facilidade de manutenção.

Com isso, foi necessário instalar as biblioteca [Microsoft.EntityFramework.Core](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) em conjunto sua extensão [Npgsql.EntityFrameworkCore.PostgreSQL](https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL.NetTopologySuite).

Posteriormente, foi realizado a modelagem da camada de ORM:
* Implementação de um DBContext, para uma database no host "localhost" de nome "postgres", com usuário "postgres" e senha "admin:
![image](https://github.com/pedro-ca/DeMaria-X-Company/assets/50923316/9c11981f-ebc2-4e32-aebe-602288418d76)
* Implementação de um repositório com operações genéricas:
![image](https://github.com/pedro-ca/DeMaria-X-Company/assets/50923316/40df4cfb-0ecb-4e94-a0fe-d53919735654)
* Mapeamento dos atributos de uma classe existente para o Entity Framework
![image](https://github.com/pedro-ca/DeMaria-X-Company/assets/50923316/9aa57731-af29-4a7a-9ab4-a23146fb4d2a)

Com essas alterações feita, é necessário criar uma nova migration do Entity Framework e atualizar o banco: 
* No "Package Manager Console" do Visual Studio com o projeto "X-Company.ORM" selecionado, crie uma nova migration com o comando:
	`add-migration devmigration`
* Posteriormente, atualize o esquema da database com o comando: `update-database`
  * Caso retorne um erro dizendo que falta a extensão postgis, [siga esse guia ](https://postgis.net/documentation/getting_started/).
* Se houver criação qualquer alteração dos atributos das classes e/ou seu mapeamento ORM, é necessário realizar migração de novo 
  








