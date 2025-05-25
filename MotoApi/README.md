# MotoApi - Sistema de Gestão de Motos em Galpões

## Descrição
API desenvolvida em .NET para gerenciamento de clientes, galpões, áreas, corredores, vagas e motos, com controle de ocupação, relatórios e validações de negócio.

## Integrantes
- Ruan Lima Silva - RM558775
- Richardy Borges Santana - RM557883
- Marcos Vinicius Pereira de Oliveira - RM557252

## Como rodar o projeto

1. **Pré-requisitos:**
   - .NET 8 ou superior instalado
   - (Opcional) Postman para testar endpoints

2. **Clone o repositório e acesse a pasta:**
   ```bash
   git clone <url-do-repo>
   cd "CsharpSprint1/MotoApi"
   ```

3. **Rode a aplicação:**
   ```bash
   dotnet run
   ```
   A API estará disponível em: `http://localhost:5133`

4. **Acesse a documentação Swagger:**
   - [http://localhost:5133/swagger](http://localhost:5133/swagger)

## Endpoints principais

### Clientes
- `GET /clientes` - Lista todos os clientes
- `POST /clientes` - Cadastra um novo cliente
- `GET /clientes/{id}` - Detalha um cliente
- `PUT /clientes/{id}` - Atualiza um cliente
- `DELETE /clientes/{id}` - Remove um cliente

### Galpões, Áreas, Corredores, Vagas, Motos
- CRUD completo para cada entidade
- Cadastro de moto já vinculando a uma vaga disponível

### Relatórios
- Motos ativas por galpão
- Capacidade por galpão/região
- Total de motos por cliente
- Motos por marca, ano, disponibilidade

## Exemplos de uso (Postman)

### Cadastrar Cliente
```json
POST http://localhost:5133/clientes
{
  "nome": "João da Silva",
  "cpf": "12345678900"
}
```

### Cadastrar Moto
```json
POST http://localhost:5133/motos
{
  "placa": "ABC1234",
  "modelo": "CG 160",
  "marca": "Honda",
  "ano": 2022,
  "status": "ativo",
  "disponibilidade": "disponivel",
  "clienteId": 1,
  "vagaId": 1
}
```

## Testes automatizados
Para rodar os testes:
```bash
dotnet test
```

## Observações
- Todos os endpoints e exemplos podem ser testados pelo Swagger ou Postman.
- O banco de dados é criado automaticamente ao rodar a aplicação.
- Arquivos de build, temporários e banco de dados local são ignorados pelo versionamento (veja `.gitignore`).

---

Projeto desenvolvido para o Challenge 2025 - 1º Semestre (2TDS).
