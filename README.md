# Projeto - Sistema de PACS (Picture Archiving and Communication System)

Um sistema PACS (Picture Archiving and Communication System) é uma tecnologia usada na área da saúde para a gestão, armazenamento e distribuição de imagens médicas digitais.

## Contribute

[Alisson da Silva Pinto](https://github.com/DevAlissonPinto)
[Diego Ivan Mendes de Oliveira](https://github.com/diegoivanmendes)
[Vinicius Roberto de Oliveira Santos](https://github.com/vroliveira)


## Repositories
* SQL [link](./sqldump)
* API Auth [link](./3BPACS.ApiAuth)
* API [link](./3BPACS.Application)
* Admin [link](./3BPACS.Interface)


## Development 

Para executar esses projetos você precisa seguir as etapas abaixo:

* Criar a base de dados
* Abrir a solution 3BPACS.sln com o visual studio 2022
* Ao executar o projeto, verificar se os projetos 3BPACS.ApiAuth e 3BPACS.Interface estão configurador para serem executados juntos como startup

### Database

Este projeto está usando SQL Server, você pode usar uma instância que instalou em seu desktop.


### ApiAuth

Esta API foi desenvolvida em .NET 7 com JWT. Para executar este projeto você pode usar VS Code ou VS 2022 community. [link](./3BPACS.ApiAuth)


### Admin

Este é um projeto de administração, aqui você pode gerenciar seus dados como cadastro de pacientes, exames e etc.

Login

![Cut video](./images/login.png)

