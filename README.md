# Console Application Register

This is a simple C# console application that allows users to register and store their information (Name, Age, and Email). After collecting the data, it displays the registered users and saves their information in a text file.

## Technologies Needed

- .NET SDK (version 7.0 or higher)
- Docker (for containerization and running the project inside a Docker container)
- Visual Studio or Visual Studio Code (optional, for better development experience)

## Installation

1. Make sure .NET is installed on your machine by checking the version:

    ```bash
    dotnet --version
    ```

    If you don't have .NET SDK installed.

## Building the Docker Image 
If you prefer to build the Docker image, run this command.

1. **Build the Docker image:**
   
```bash
docker build -t imgusr .
 ```

## Image to Docker Hub
To push the image to your own Docker Hub account, follow these steps.

1. **Tag the image:**

    ```bash
    docker tag imgusr jessjoha/imgusr:latest
    ``` 
2. **Push the image to Docker Hub:**
   
    ```bash
    docker push jessjoha/imgusr:latest
    ``` 

### Pull the image from Docker Hub:

```bash
docker pull jessjoha/imgusr
```

## Link to the Docker Hub image:

https://hub.docker.com/r/jessjoha/imgusr

The application will prompt you to enter the number of users you want to register. It will then ask for the name, age, and email for each user. Finally, it will display the entered data and save it to a text file called `usuarios_registrados.txt`.

