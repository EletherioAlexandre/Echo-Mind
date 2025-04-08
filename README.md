# EchoMind — Plataforma de Análise de Sentimentos

EchoMind é uma plataforma de análise de sentimentos desenvolvida para transformar feedbacks de usuários em insights estratégicos para negócios.

Este projeto integra um microserviço de IA, responsável por analisar e classificar textos de usuários em positivos, negativos ou neutros, utilizando o modelo TextBlob (Python). A arquitetura prevê integração com backend .NET, formando uma base sólida para aplicações corporativas de análise inteligente de dados.

## Funcionalidades atuais

- API Python com FastAPI
- Processamento de linguagem natural (NLP) com TextBlob
- Estrutura modular e profissional para expansão futura

## Próximos passos

- Integração com backend .NET
- Dockerização do serviço
- Evolução para modelos de IA multilíngues (HuggingFace Transformers)
- Automação de relatórios e alertas inteligentes

## Como rodar o projeto

1. Clone este repositório
2. Navegue até a pasta `ai-python-service`
3. Crie e ative o ambiente virtual
4. Instale as dependências: pip install -r requirements.txt
5. Execute a aplicação: uvicorn app.main:app --reload
6. Acesse a documentação interativa:  http://127.0.0.1:8000/docs

# EchoMind API — Dockerfile

O **Dockerfile** presente neste projeto automatiza a criação da imagem Docker da aplicação EchoMind, garantindo a execução da solução em um ambiente totalmente preparado, coerente com suas dependências, e livre de erros durante a execução do container, por meio da utilização de imagem imutável.  
Além disso, o desenvolvimento deste arquivo já considera a futura integração com pipelines de **CI/CD**, visando escalar nossa solução e implementar automatizações na geração e entrega de novas imagens.

Este Dockerfile assegura:
- ✅ Portabilidade entre ambientes.
- ✅ Previsibilidade e confiabilidade na execução do serviço.
- ✅ Aderência às boas práticas de **infraestrutura como código**.
- ✅ Preparação para escalabilidade futura e integração simplificada com microserviços, como a camada .NET planejada do EchoMind.

---

## 1. Função Geral

O **Dockerfile** automatiza a construção da imagem Docker do projeto, definindo o ambiente base, as instruções de execução da aplicação e todas as dependências necessárias, garantindo que a aplicação seja construída de forma reproduzível e consistente para qualquer ambiente de execução.

---

## 2. Objetivo dentro do EchoMind

Garantir que a API de análise de sentimentos do EchoMind seja executada:
- 📦 Em um ambiente isolado, consistente e replicável em qualquer máquina ou servidor.
- 🚀 Preparado para integração futura com outros serviços da solução EchoMind.
- 🛠️ Pronto para orquestração multi-container e deploys automatizados em pipelines CI/CD.

---

## 3. Como usar

Siga as seguintes etapas para execução do projeto:

1. Clone o repositório:
   ```bash
   git clone https://github.com/EletherioAlexandre/Echo-Mind
   ```

2. Dentro da raiz do repositório, execute o comando abaixo para construir a imagem Docker da aplicação:
   ```bash
   docker build -t echomind-py .
   ```

3. Após gerar a imagem com sucesso, execute o container com:
   ```bash
   docker run -d -p 8000:8000 echomind-py
   ```

4. Acesse a documentação interativa da API em:
   [http://localhost:8000/docs](http://localhost:8000/docs)

---

## Tecnologias Utilizadas

- Python 3.11
- FastAPI
- TextBlob
- Docker
- Git & GitHub


## Autor

- [Alexandre Junior](https://www.linkedin.com/in/alexandre-junior-ab799719a/)

---


