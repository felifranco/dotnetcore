# Instrucciones

## Creación y ejecución
El proyecto fue generado con comandos de .NET core, el siguiente fue el comando ejecutado:
```
dotnet new webapp -n dotnetcore_login
```
El proyecto se puede levantar con _Visual Studio Code_ en su sección _Run and Debug_ o también se puede utilizar el comando:
```
dotnet run --configuration Debug
```
En una salida de la terminal se visualizará el número de puerto en el cuál se ha publicado la aplicacionón, por ejemplo:
```
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5013
```

## Acerca de la prueba técnica
El proyecto fue generado con **.NET Core** porque se utiliza **Fedora Linux** como sistema operativo anfitrion, eso quiere decir que no es posible utilizar _Visual Studio_ ni _.NET Framework_ en ninguna de sus versiones. Como alternativa a **.aspx** (.NET Framework) se utilizó **.cshtml**(.NET Core).

Las validaciones solicitadas en la prueba se realizan en _wwwroot/js/site.js_ y en _Pages/Index.cshtml.cs_.
