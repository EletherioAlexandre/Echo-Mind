# Escolhendo a imagem base oficial do Python
FROM python:3.11-slim

# Definindo o diretório de trabalho dentro do container
WORKDIR /app

# Copiando os arquivos de dependências para o container
COPY requirements.txt requirements.txt

# Instalando as dependências no ambiente do container
RUN pip install --no-cache-dir -r requirements.txt

# Copiando o restante do código para dentro do container
COPY . .

#Definindo o comando para rodar a aplicação
CMD ["uvicorn", "app.main:app", "--host", "0.0.0.0", "--port", "8000"]