
# Tarefa State Pattern

Este projeto implementa o **State Pattern** para gerenciar os diferentes estados de uma **Task** **(Tarefa)**. A Tarefa pode ter vários estados, e cada estado tem comportamentos diferentes para alterar o status da tarefa. O projeto também inclui testes unitários, que podem ser executados usando o comando `dotnet test` no terminal.

## Estrutura do Projeto

- **States**: Contém as classes principais para implementar o padrão de estado, incluindo a interface `ITaskStatusState` e as classes de estados concretos.
- **Models**: Contém o modelo de Tarefa e a lógica para gerenciar transições de estados.
- **StatePattern.Tests**: Contém os testes unitários para garantir que as transições de estado e a lógica da Task funcionem corretamente.

## Padrão de Projeto: State Pattern

O **State Pattern** é usado para permitir que um objeto altere seu comportamento quando o seu estado interno mudar. Nesse caso, a Tarefa muda de comportamento com base em seu estado atual (ex: "Criada", "Iniciada", "Concluída").

### Estados da Tarefa

- **Created** **(Criada)**: Estado inicial, a tarefa está aguardando para ser iniciada.
- **Started** **(Iniciada)**: A tarefa está sendo executada.
- **Concluded** **(Concluída)**: A tarefa foi finalizada.

### Estrutura de Classes

- `Task`: Representa a classe principal que possui um estado atual e fornece métodos para alterar seu estado.
- `ITaskStatusState`: Interface para os estados da tarefa, define os métodos que cada estado concreto deve implementar.
- `TaskCreated`, `TaskStarted`, `TaskConcluded`: Implementações concretas do estado da tarefa.

## Como Usar

### Instalar Dependências

Para instalar as dependências e configurar o projeto, execute o seguinte comando:

```bash
dotnet restore
```

### Executar o Projeto

Para executar o projeto, use o comando:

```bash
dotnet run
```

## Exemplo de Uso

Aqui está um exemplo de como utilizar o State Pattern para alterar o estado de uma tarefa:

```csharp
using System;

// A tarefa é inicializada com o status de Criada
Task task = new("Some Task");
Console.WriteLine($"Initial status: {task.Status}");

// Mudando para o estado "Iniciada"
task.Start();
Console.WriteLine($"Status after change: {task.Status}");

// Mudando para o estado "Concluída"
task.Conclude();
Console.WriteLine($"Status after change: {task.Status}");

```


## Testes Unitários

Os testes unitários para o projeto podem ser encontrados na pasta **Tests**. Eles validam as transições de estado e a lógica do sistema.

### Executar Testes Unitários

O projeto inclui testes unitários que podem ser executados com o comando:

```bash
dotnet test
```

Isso executará todos os testes no projeto e exibirá os resultados no terminal.
