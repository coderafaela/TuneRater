# 🎸 TuneRater

> Avalie suas bandas e cantores favoritos com notas e acompanhe as médias — tudo no terminal.

---

## 📌 Sobre o projeto

O **TuneRater** é uma aplicação de console desenvolvida em **C#** que permite registrar bandas e cantores, atribuir notas a eles e visualizar a média das avaliações. O projeto foi criado como parte do aprendizado na plataforma **Alura**, mas foi além do escopo original: enquanto o curso focava em somente bandas e em funcionalidades básicas com dicionários e listas, decidi expandir a aplicação adicionando um sistema de registro e avaliação de cantores solo, além de melhorias na interface de terminal com arte ASCII e menus interativos.

---

## ✨ Funcionalidades

| Opção | Funcionalidade |
|-------|---------------|
| `1` | Registrar uma banda |
| `2` | Exibir todas as bandas registradas |
| `3` | Avaliar uma banda com uma nota |
| `4` | Exibir a média de avaliações de uma banda |
| `5` | Registrar um(a) cantor(a) |
| `6` | Exibir todos os cantores registrados |
| `7` | Avaliar um(a) cantor(a) com uma nota |
| `8` | Exibir a média de avaliações de um(a) cantor(a) |
| `9` | Exibir todas as bandas e cantores |
| `-1` | Sair da aplicação |

---

## 🛠️ Tecnologias utilizadas

- **Linguagem:** C# (.NET)
- **Estruturas de dados:** `Dictionary<string, List<double>>`
- **Interface:** Console com arte ASCII
- **Paradigma:** Programação procedural com funções locais (top-level statements)

---

## 🚀 Como executar

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado (versão 10.0)

### Passos

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/tunerater.git

# Acesse a pasta do projeto
cd tunerater

# Execute a aplicação
dotnet run
```

---

## 📂 Estrutura do código

```
tunerater/
│
├── Program.cs          # Arquivo principal com toda a lógica da aplicação
└── tunerater.csproj    # Arquivo de configuração do projeto .NET
```

**Principais elementos:**
- `bandasRegistradas` — Dicionário que armazena bandas e suas notas
- `registroDeCantores` — Dicionário que armazena cantores e suas notas
- Funções como `RegistrarBandas()`, `AvaliarUmaBanda()`, `MediaBanda()` encapsulam cada funcionalidade do menu

---

## 💡 Aprendizados

Durante o desenvolvimento deste projeto, pratiquei e aprofundei:

- Uso de `Dictionary<TKey, TValue>` com `List<T>` como valor
- Manipulação de listas e cálculo de médias com LINQ (`.Average()`)
- Estruturas condicionais (`switch`) para controle de menu
- Boas práticas de organização de código com funções locais
- Criação de interfaces de terminal mais ricas com arte ASCII

---

## 👤 Autor

Feito com 🎵 e código.  
Conecte-se no [LinkedIn](https://linkedin.com/in/rafaela-a-quevedo/) | [GitHub](https://github.com/coderafaela)
