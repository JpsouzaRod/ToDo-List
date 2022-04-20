
# To Do List
O To Do List é um sistema de gerenciamento de tarefas para organização das atividades da semana. O sistema permitirá que o usuário possa cadastrar, alterar, concluir e vizualizar tarefas salvas no sistema.
## Documentação da API

#### Cadastra uma tarefa

```http
  POST /home/cadastrar
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `id` | `int   ` | Identificação da tarefa |
| `Titulo` | `string` |  Titulo da tarefa |

#### Retorna uma lista de tarefas

```http
  GET /home/
```
#### Retorna uma tarefa

```http
  GET /home/{id}
```
| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `id` | `int   ` | Identificação da tarefa |

#### Conclui uma tarefa

```http
  PUT /home/concluir/{id}
```
| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `id` | `int   ` | Identificação da tarefa |

#### Altera uma tarefa

```http
  PUT /home/alterar
```
| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `id` | `int   ` | Identificação da tarefa |
| `Titulo` | `string` |  Titulo da tarefa |

#### Deleta uma tarefa

```http
  DELETE /home/deletar/{id}
```
| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `id` | `int   ` | Identificação da tarefa |




## Autores

- [@jpsouza-rod](https://www.github.com/jpsouza-rod)

