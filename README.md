#DependencyFinder
Dependency Finder is a tool that can help you get an overview of which projects and assemblies are refered and from where.
The idea is that you choose a "root" folder. The application then recursivly goes through all the subfolders and find all your project files (only .csproj files). It will then figure out "project" reference and "assembly" references. The last one is especially relevant if your big website is build of multiply solutions and therefore don't use project references.

#Technical stuff
The application is written in C# to .NET 3.5. and therefore require at least .NET 3.5 runtime to run.

For now the application will ONLY look for .csproj files (C# project files) from VS2005 or VS2008.


#Getting Started
First of all you need to get the lastest release of the project from the "Releases" tab on this page.

* Choose your "root" folder, from where the application will start looking for .csproj files. Do this by clicking on the "Browse" button. Navigate to your project(s) root folder and click ok. The path to your root folder will now be in the textbox besides the "Browse" button.
* The application is now ready to start collecting data, so click the "Start" button.
* After some time (depents on the the number of folders, files and projects in your root folder) the collecting of data i finished and you can start using the application.
* In the right side of the windows you will se some tabs, *Projects* and *Assemblies*. 
  * Projects tab - In the Projects tab you will se all the projects (.csproj files) the application have found. If you click one of them the panel to the left will update. Here you can see:
    * The path for this particular .csproj file. 
    * Which projects that have a ProjectReference to this project.. (This feature is one of the key goals for this application).
    * Which assemblies the project has a reference to.
    * And finally which ProjectReferences the project have.
* Assemblies tab - In the Assemblies tab you will se all the assemblies that were found during the data collecting. (Everytime the application finds a referenced assembly in the .csproj file it will be added to this list, but only once). If you click one of them the panel to the left will update. Here you can see:
    * Which projects that have a reference to this assembly. (This feature is one of the key goals for this application).

The Property Window will update everytime you click a Project or an Assembly.

# Visualization
Thanks to this project http://www.codeplex.com/dependencyvisualizer you can now get an diagram of your projects references. Select an Project in the list, right click it and click 'Visualize'. A window will open, showing you the diagram. Adjust the size of the window to make the diagram look better. The generated .png can also be found in the "Dependencies" folder in the application folder.

# Screenshot
## General view
![alt text](https://raw.githubusercontent.com/Laumania/DependencyFinder/master/screenshots/DependencyFinder1.png "DependencyFinder Screenshot 01")

## Visualization
![alt text](https://raw.githubusercontent.com/Laumania/DependencyFinder/master/screenshots/DependencyFinder2.png "DependencyFinder Screenshot 02")

#History note
This project was originally living on https://dependencyfinder.codeplex.com/, but is now moved here, as Github has become so much cooler than Codeplex.com.
