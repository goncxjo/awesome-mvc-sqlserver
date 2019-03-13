# Starting with .NET Core and Docker on LINUX

![alt text](https://cdn-images-1.medium.com/max/800/1*wXVKmFVrXg1gQrBARX6wJw.png)

In this tutorial, you will be able to create a simple ASP.NET Core MVC app working with Docker. But before starting code, let’s talk about these technologies: I’m sure, you have listened about .NET Framework, but what about .NET Core? What about Docker? Well, it’s time to put all on site.

Requirements:
- [.NET Core Runtime](https://dotnet.microsoft.com/download/)
- [Docker](https://docs.docker.com/install/)
- [Docker Compose](https://docs.docker.com/compose/install/)
- [Docker Toolbox](https://docs.docker.com/toolbox/overview/) only if you can't install Docker and Docker Compose
- [Azure Data Studio](https://docs.microsoft.com/en-us/sql/azure-data-studio/download?view=sql-server-2017) for SQL Server database management
    
Clone this repo and run this command on your terminal in the root of the project:
```
$ docker-compose build
$ docker-compose up
```

Then, go to http://localhost:8000/characters on your favorite browser. You can also connect to the database in the localhost,5433 server (in my case, I'm using Azure Data Studio):
![alt text](https://cdn-images-1.medium.com/max/800/1*9e4Qm_a6F2Jw2nGRx0SN3Q.gif)
![alt text](https://cdn-images-1.medium.com/max/800/1*zcioPTHlP8yYl8q68Yhuwg.png)
![alt text](https://cdn-images-1.medium.com/max/800/1*t0ecdUmnVG_X1X-bGGEeXA.png)
