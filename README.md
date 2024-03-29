# Tangy
Udemy Blazor Tutorial by Bhrugen Patel. I did not create this!!!

## Introduction
This is a fantastic project by Mr. Patel. It has a client application, a seller-focused inventory application (https://tangywebserver11.azurewebsites.net), and an API (https://tangywebapi11.azurewebsites.net/index.html)

## Technology
This application uses ASP.NET Blazor for both front and backend. A few plugins like stripe payments, toastr, sweetalerts, sendgrid, syncfusion, and radzen datagrid, were used for some details.

## Server/Seller App
If you visit https://tangywebserver11.azurewebsites.net, you have the ability to register, login, and CRUD various soaps and candles. The ability to CRUD is protected by authorization. A normal user cannot CRUD products. Only an admin has the ability to work on inventory management.

<img src="/createproduct.png" alt="Homepage" title="Server">

## Client App
The client-side application may be found here: https://tangywebclient11.azurewebsites.net/. A customer can select various candles and soaps, add them to a cart, and complete a functional but not financial stripe payment checkout process. Very cool. Anonymous users cannot checkout, as they are not authorized.

<img src="/client.png" alt="Homepage" title="Client">


## Future improvements
I would probably choose to do a frontend in Angular. The blazor apps are slow. I guess there is a trade-off between advantages of various technologies. The Client application has almost zero User Experience, but that is something I have some strength.
