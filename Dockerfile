# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copia o arquivo csproj e restaura as dependências
COPY *.csproj ./
RUN dotnet restore

# Copia o restante da aplicação e constrói
COPY . ./
RUN dotnet publish -c Release -o out

# Etapa 2: Criação da imagem final
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expondo a porta que a aplicação irá rodar
EXPOSE 80

# Comando para rodar a aplicação
ENTRYPOINT ["dotnet", "moneyzor.dll"]
