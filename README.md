# SwaggerApiCrud
<h1>ASP.net Crud</h1>
<h2>An MVC-Model View Controller</h2>

<h3>A asp.net Core MNC api Crud application</h3>
<p>It used to Create,read,Update and delete Operation on user's Data</p> 
<p>-first step,we create models for contact and create new models for add and updating operations<p/> 
<p>-second step,create contactDbcontext from base class dbcontext which contain dbset and add sql server and user name to appsetting.json ,and add dbcontext to sql database with cmd-(builder.addcontext) in program.cs </p>
<p>-third step,create migration cmd-(Add migration "Inital migration") and execute another cmd to create database cmd-(update database)</p>
<p>-fourth step,create contact controller to perform CRUD Operations</p>
<p>-finally step,host the api in swagger to perform crud opertaions/p>
