# chessboard-oliver-simon
This is a C# console application that renders a chessboard.

## Requirements
.NET 10

## Upcoming features and changes
    -Implement SpectreConsole features for customizing how the terminal displays the application.
    -Adding a method for handling inputs.
    -Updating README.md

## Cloning this repository

1. Navigate to the [main page of the repository.](https://github.com/oliboh/chessboard-oliver-simon)    

2. Above the list of files click **<> Code**

3. Copy the HTTPS URL of the repository.

4. Open your terminal.

5. Change your directory to the location in which you would like to clone the repository.
    
    Example:
    >cd c:\user\USERNAME\desired-path
    
    
6. Type git cloned followed by the URL copied.

    Example:
    >git clone >HTTPS-URL<

7. Press Enter to create your local clone.

8. Type dotnet build to build the project and ensure NuGet-packages are installed.

    Example
    >dotnet build

To read more about cloning a repository visit [Cloning a repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository).
    
## Instructions for using the application.
When you run the application the console will greet you, you will then be asked to input a number between 3-50.\
If your input is within the scope of valid inputs the application will render a chessboard the size of your input.

Example:

>user input: 4
>
>◼︎ ◻︎ ◼︎ ◻︎\
>◻︎ ◼︎ ◻︎ ◼︎\
>◼︎ ◻︎ ◼︎ ◻︎\
>◻︎ ◼︎ ◻︎ ◼︎

## NuGet Packages
Spectre.Console version 0.57.2.\
Spectre.Console allows us to customize our interfaces using colors, panels and much more.

## Code Structure
We have structured our code using different classes.

StandardMessages is a class that contains methods for printing text to the user using Spectre.Console. It contains methods such as GreetUser(), AskForInput(), AskForAnother().

UserInput is a class which purpose is handling inputs from the user, it contains methods such as SaveInput(), ValidateInput().

ChessBoard is a class that specifies the properties of the chessBoard, it contains a constructor and the method RenderBoard(), used for rendering the chessboard.

## Version Control
"Git-arbete: kort information om hur ni arbetade med commits och merge conflict."
## Choices and Crossroads
"en kort motivering av de viktigaste valen i lösningen, till exempel hur ni validerar input, hur ni växlar mellan svarta och vita rutor och varför ni delat upp koden i metoder/klasser."