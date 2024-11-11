# Console Application Register

This is a simple C# console application that allows users to register and store their information (Name, Age, and Email). After collecting the data, it displays the registered users and saves their information in a text file.

## Technologies Needed

- .NET SDK (version 7.0 or higher)
- Docker (for containerization and running the project inside a Docker container)
- Visual Studio or Visual Studio Code (optional, for better development experience)

## Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/JessJoha/usuarioproyecto.git
    ```

2. Navigate to the project directory:

    ```bash
    cd usuarioproyecto
    ```

3. Make sure .NET is installed on your machine by checking the version:

    ```bash
    dotnet --version
    ```

    If you don't have .NET SDK installed.

## Running the Project

To run the project locally:

1. Open a terminal and navigate to the project directory.
2. Run the following command to build and run the project:

    ```bash
    dotnet run
    ```

The application will prompt you to enter the number of users you want to register. It will then ask for the name, age, and email for each user. Finally, it will display the entered data and save it to a text file called `usuarios_registrados.txt`.

