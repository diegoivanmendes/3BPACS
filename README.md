# Projeto - Sistema de PACS (Picture Archiving and Communication System)

Um sistema PACS (Picture Archiving and Communication System) é uma tecnologia usada na área da saúde para a gestão, armazenamento e distribuição de imagens médicas digitais.

## Contribute

[Alisson da Silva Pinto](https://github.com/DevAlissonPinto)
[Diego Ivan Mendes de Oliveira](https://github.com/diegoivanmendes)
[Vinicius Roberto de Oliveira Santos](https://github.com/vroliveira)


## Repositories
* API Auth [link](https://github.com/diegoivanmendes/3BPACS/tree/main/ApiAuth)
* ASP NET MVC [link](https://github.com/diegoivanmendes/3BPACS/tree/main/3BPACS)


## Development 

Para executar esses projetos você precisa seguir as etapas abaixo:

* Abrir a solution 3BPACS.sln com o visual studio 2022
* Configurar os os projetos 3BPACS.ApiAuth e 3BPACS.Interface para serem executados juntos como startup
* Com o botão direito do mouse na solution, ir na opção Configure Startup Projects... Selecionar a opção Multiple startup projects
* Alterar o 3BPACS.ApiAuth e 3BPACS.Interface para start
* Abri Package Manager Console e deixar como Defult project: 'Interface\3BPACS.Interface' e executar o comando Update-Database
* Ainda no Package Manager Console e deixar como Defult project: 'ApiAuth\3BPACS.ApiAuth' e executar o comando Update-Database
* Executar o projeto pressionando o F5

### ApiAuth

Esta API foi desenvolvida em .NET 7 com JWT. Para executar este projeto você pode usar VS Code ou VS 2022 community.


### ASP NET MVC

Este é um projeto web desenvolvido com AspNet MVC, esse é o projeto onde tem toda a interface do usuário.

