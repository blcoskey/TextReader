# TextReader
C# application that can read the contents of the text file and determine the most frequent word, most frequent 7 letter word 
and word with the highest scrabble score. The solution has 3 parts. A class library with all of the logic, a console application 
so that it can be run from the command line and a windows form application to allow for a GUI. the GUI and the console app simply 
call the methods and logic of the class library.

# Instructions
1. Open solution in visual studio

- The GUI
  - The solution has the GUI project set as the start up project.
  - Simply click run from visual studio
  - Once the application opens, click the browse button and select the text file that you would like to read from
  - click run
  - once the data has loaded the output will be shown below the file path bar

- The Console App(VS Debug)
  - The solution has the GUI project set as the start up project.
  - from the run menu in visual studio, select TextReaderConsole
  - Click run
  - The program will run and in debug mode will by default select WarAndPeace.txt as the file to read
  - once the data has loaded the output will be shown in the open command window

- The Console App(Command Line)
  - Open a command line in the same folder as the TextReaderConsole project. eg: .\TextReader-master\TextReaderConsole
  - run command dotnet run "Path\To\File"
  
