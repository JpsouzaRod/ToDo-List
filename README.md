
# To Do List
O To Do List é um sistema de gerenciamento de tarefas para organização das atividades da semana. O sistema permitirá que o usuário possa cadastrar, alterar, concluir e vizualizar tarefas salvas no sistema.
## Documentação da API

## Métodos
Requisições para a API devem seguir os padrões:
| Método | Descrição |
|---|---|
| `GET` | Retorna informações de um ou mais registros. |
| `POST` | Utilizado para criar um novo registro. |
| `PUT` | Atualiza dados de um registro ou altera sua situação. |
| `DELETE` | Remove um registro do sistema. |


## Respostas

| Código | Descrição |
|---|---|
| `200` | Requisição executada com sucesso (success).|
| `400` | Erros de validação ou os campos informados não existem no sistema.|
| `401` | Dados de acesso inválidos.|


#### Cadastra uma tarefa

```http
  POST   /home/cadastrar
```

Body
```json
    {
        "id": int,
        "titulo": "string"
    }
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




## Stack utilizada
**Back-end:** .Net, C#

**Danco de Dados:** Sqlite 


## Autores

- [@jpsouza-rod](https://www.github.com/jpsouza-rod)

