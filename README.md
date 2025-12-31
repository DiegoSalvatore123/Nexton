# Nexton
Hi, 

I created two versions of the project. 
One is under Visual Studio so it can be run from the browser using Swagger, which uses port 5000. 
The other version is done with Visual Studio Code, which runs on the requested port 5000. 
The project structure contains the .sln file and three projects, each in its own folder: API, Domain, and Infra. 
I made it three layers to make it maintainable and scalable.

From Visual Studio Code, to run the project using Bash, from the root directory, you should run the following command: `dotnet run --project API/API.csproj` poiting to the API Project.

