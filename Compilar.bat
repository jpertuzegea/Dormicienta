
:: En esta ruta va la unicacion del Msbuil.exe y depende de la version de visual y el año
set pathMSBuild="C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\"


:: -----------------------------------------------
:: Configuracion de Variables del proyecto
set NombreProyecto=Dormisienta
set RutaSolucion="C:\Users\JORGE\Desktop\SONOLIENTA\Dormisienta.sln"

:: Debug/Release
set TipoCompilacion=Debug 
:: -----------------------------------------------


@echo off
cls
cd %pathMSBuild%
msbuild.exe %RutaSolucion% /target:Rebuild   /p:configuration=%TipoCompilacion%

@echo.
@echo.
@echo  Compilacion de %NombreProyecto% Terminada
@echo.
@echo.
pause
