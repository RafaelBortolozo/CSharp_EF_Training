# Curso de Entity Framework (EF) com C# e .NET

## Requisitos
 - .NET Core 5.0
 - .NET Core 6.0
 - Azure Data Studio
 - SQL Server Express (Windows)
 - Docker com SQL Server (Windows, Mac, Linux)

## Comandos
Instalação do docker com SQL Server, segue tutorial do Balta
```
https://balta.io/blog/sql-server-docker
```

Instalação EF core
```
dotnet add package Microsoft.EntityFrameworkCore -v 5.0.10
```

Instalação EF core SQL Server
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 5.0.10
```

Cria uma pasta como novo projeto
```
dotnet new console -o <NomeProjeto>
```

Cria uma pasta e especifica qual sdk usar (use "dotnet new console -h" para mais informações)
```
dotnet new console -o <NomeProjeto> -f net5.0
```
```
dotnet new console -o <NomeProjeto> -f net6.0
```


Lista e instala todas as dependencias
```
dotnet restore
```


Inicia compilação
```
dotnet build
```


Limpa arquivos de cache
```
dotnet clean
```


Roda aplicação localmente
```
dotnet run   
```


Roda aplicação emum determinado ambiente de execução
```
dotnet run --environment=<Ambiente>
```


Cria arquivo .gitignore para postagem no github
```
dotnet new gitignore
```

Listar sdks instaladas
```
dotnet --list-sdks
```


## Curiosidades do EF
 - ORMs permite o mapeamento dos objetos do C# para um banco de dados relacional. O EF tem algumas funcionalidades de conversão de objetos, como do banco relacional para um objeto do C#, desde que há um "interface".
 - EF oferece diversas funcionalidades adicionais em relação ao Dapper.
 - Abordagem Database First consiste em não manipular o banco, mas mapear as entidades com um banco já criado.
 - Abordagem Code/Model First consiste em trabalhar primeiro no código e gerar um banco de dados com código (migrations). É um modelo amplamente usado pois aí a regra de negócio fica no código, o banco vai servir pra somente persistir dados.
 - EF é baseado em contextos, necessita apenas de um DataContext pra funcionar. Esse DataContext define um banco de dados em memória, tendo a aplicação uma velocidade muito maior em relação a um disco de banco. DbSet são subconjuntos de dados, representando as tabelas. A ideia é pegar no banco, carregar e trabalhar em memoria, desce pro banco, sem sobrecarregar a memoria.
 - Models contém as representações dos objetos do banco de dados.
 - 

