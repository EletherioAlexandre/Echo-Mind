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


## Autor

- [Alexandre Junior](https://www.linkedin.com/in/alexandre-junior-ab799719a/)

---


