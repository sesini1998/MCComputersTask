# MC Computers Invoice Generation

## Overview

This project is an ASP.NET MVC application designed for MC Computers, a retail shop selling computer parts and accessories. The application allows the shop owner to generate invoices for every transaction.

## Features

- Generate customer invoices
- Capture transaction date, products, discount, quantity, total amount, and balance amount
- Display the invoice

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio](https://visualstudio.microsoft.com/) or any C# IDE
- SQL Server

## Setup

1. Clone the repository
    
    git clone https://github.com/sesini1998/MCComputersTask.git
    cd MCComputers
    

2. Update the connection string in appsettings.json to point to your SQL Server instance.

3. Apply the migrations to create the database schema
    
    dotnet ef database update
    

4. Run the application
    
    dotnet run
    

5. Application will open on browser.

## Screens

The application contains the following screens:

1. Create Invoice: Allows to generate a new invoice.
2. Invoices List: Displays a list of all generated invoices.

## Images                                                       
Screen 1  
![Image Description](https://drive.google.com/uc?export=view&id=1eORgAE_a7aZRXCJlByKORu2BORgXBtBO)
Screen 2
![Image 2 Description](https://drive.google.com/uc?export=view&id=12L_rrPJEPjjl-zQ0gCH7DfMuEw4y_bgP)
Screen 3 
![Image 3 Description](https://drive.google.com/uc?export=view&id=1JcAKCNP3z7r8ds-D3zbs92k1SuRxynKN)
Screen 4 
![Image 4 Description](https://drive.google.com/uc?export=view&id=1MYjJpFoHYoWP41w3lj5bfipUwFi_j8hJ)
Screen 5 
![Image 5 Description](https://drive.google.com/uc?export=view&id=1E4Uf1MnEhqIejzUeefG2QhZmUWeNqDQj)
Screen 6 
![Image 6 Description](https://drive.google.com/uc?export=view&id=1_RGEY7HC0S2OzFRcrJR3ZoGuysA8slSC)
