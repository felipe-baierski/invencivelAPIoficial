FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "invencivelAPIoficial/invencivelAPIoficial.csproj"
RUN dotnet publish "invencivelAPIoficial/invencivelAPIoficial.csproj" -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "invencivelAPIoficial.dll"]
