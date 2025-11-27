FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Copia apenas os arquivos já publicados pelo CodeBuild
COPY publish/ /app/

ENTRYPOINT ["dotnet", "invencivelAPIoficial.dll"]
