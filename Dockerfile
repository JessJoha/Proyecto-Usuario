# Usamos una imagen base de .NET SDK para la compilación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establecemos el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copiamos el archivo de proyecto .csproj al contenedor
COPY ["usuarioproyecto.csproj", "./"]

# Restauramos las dependencias del proyecto
RUN dotnet restore

# Copiamos el resto de los archivos del proyecto al contenedor
COPY . .

# Publicamos la aplicación en modo Release
RUN dotnet publish -c Release -o /app/out

# Usamos una imagen más ligera para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Establecemos el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copiamos la aplicación publicada desde la etapa de compilación
COPY --from=build /app/out .

# Exponemos el puerto en el que la aplicación podría estar escuchando
EXPOSE 80

# Comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "usuarioproyecto.dll"]
