
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build


WORKDIR /app

COPY . .

RUN dotnet restore


RUN dotnet publish -c Release -o /app/out


FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime

WORKDIR /app


COPY --from=build /app/out .

CMD ["dotnet", "usuarioproyecto.dll"]