

<!-- local-development:start -->
# Desarrollo local

Puedes abrir este repositorio en VS Code, Antigravity o Sublime Text. El compilador y los servicios necesarios dependen del componente indicado abajo.

## Visual Studio 2022 / .NET Framework

Instala la carga de trabajo de escritorio .NET y el paquete de destino indicado en la tabla. Los proyectos ASP.NET también requieren la carga web e IIS Express. Abre la solución `.sln` correspondiente y selecciona el proyecto de aplicación para iniciar.

```powershell
# Ejecutar desde Developer PowerShell de Visual Studio 2022
$solutionDir = (Resolve-Path '.').Path + '\'
MSBuild.exe 'CalculadoraWF/CalculadoraWF.csproj' /restore /p:RestorePackagesConfig=true /p:Configuration=Debug /p:DeployOnBuild=false "/p:SolutionDir=$solutionDir"
```

## Componentes y validación

Inventario y compilaciones locales del 2026-11-15. Una compilación correcta no acredita todavía interacción, compatibilidad de base de datos, instalador ni despliegue.

| Componente | Tipo / destino | Validación |
| --- | --- | --- |
| [CalculadoraWF/CalculadoraWF.csproj](<CalculadoraWF/CalculadoraWF.csproj>) | dotnet / v4.8.1 | Compila; prueba funcional pendiente |
| [Caso2Calc_AndreRodriguez.sln](<Caso2Calc_AndreRodriguez.sln>) | solution | Sin ejecutar |
| [Consola/Consola.csproj](<Consola/Consola.csproj>) | dotnet / v4.8.1 | Compila; prueba funcional pendiente |
| [Laboratorio3.sln](<Laboratorio3.sln>) | solution | Sin ejecutar |
| [WebApp/WebApp.vbproj](<WebApp/WebApp.vbproj>) | dotnet / v4.8.1 | Compila; prueba funcional pendiente |

## Archivos ignorados

`.gitignore` excluye credenciales locales, estado del editor y salidas de las herramientas detectadas. No deja de versionar archivos que ya estaban en Git. Los manifiestos, archivos de bloqueo, recursos fuente y scripts de esquema forman parte del código.
<!-- local-development:end -->

<!-- verified-builds-20261115:start -->
## Compilación comprobada

- Compilación satisfactoria registrada para `CalculadoraWF/CalculadoraWF.csproj`.
- Compilación satisfactoria registrada para `Consola/Consola.csproj`.
- Compilación satisfactoria registrada para `WebApp/WebApp.vbproj`.

Comandos:

```powershell
msbuild "CalculadoraWF/CalculadoraWF.csproj" /restore /t:Build
msbuild "Consola/Consola.csproj" /restore /t:Build
msbuild "WebApp/WebApp.vbproj" /restore /t:Build
```

La compilación no acredita todos los flujos gráficos, conexiones a bases de datos ni servicios externos. No se ejecutaron operaciones de administración contra esos servicios.
<!-- verified-builds-20261115:end -->
