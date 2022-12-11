# SwaggerApiCrud
[![.NET Foundation](https://img.shields.io/badge/.NET%20Foundation-blueviolet.svg)](https://www.dotnetfoundation.org/)
<h1>ASP.NET</h1>
ASP.NET Core is an open-source and cross-platform framework for building modern cloud-based internet-connected applications, such as web apps, IoT apps and mobile backends. ASP.NET Core apps run on [.NET](https://dot.net), a free, cross-platform and open-source application runtime. It was architected to provide an optimized development framework for apps that are deployed to the cloud or run on-premises. It consists of modular components with minimal overhead, so you retain flexibility while constructing your solutions. You can develop and run your ASP.NET Core apps cross-platform on Windows, Mac and Linux. [Learn more about ASP.NET Core](https://docs.microsoft.com/aspnet/core/).

## Get Started

Follow the [Getting Started](https://docs.microsoft.com/aspnet/core/getting-started) instructions in the [ASP.NET Core docs](https://docs.microsoft.com/aspnet/index).

Also check out the [.NET Homepage](https://www.microsoft.com/net) for released versions of .NET, getting started guides, and learning resources.


<h2>An MVC-Model View Controller</h2>

<h3>A asp.net Core MNC api Crud application</h3>
<p>It used to Create,read,Update and delete Operation on user's Data</p> 
<p>-first step,we create models for contact and create new models for add and updating operations<p/> 
<p>-second step,create contactDbcontext from base class dbcontext which contain dbset and add sql server and user name to appsetting.json ,and add dbcontext to sql database with cmd-(builder.addcontext) in program.cs </p>
<p>-third step,create migration cmd-(Add migration "Inital migration") and execute another cmd to create database cmd-(update database)</p>
<p>-fourth step,create contact controller to perform CRUD Operations</p>
<p>-finally step,host the api in swagger to perform crud opertaions/p>

## Prerequirements

* Visual Studio 2017
* .NET Core SDK
* SQL Server

## How To Run

* Open solution in Visual Studio 2017
* Set .Web project as Startup Project and build the project.
* Run the application.
