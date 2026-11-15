# UCENFOTEC

<!-- local-development:start -->
## Desarrollo local

Consulta [RUNNING.md](RUNNING.md) para ubicar cada componente, abrirlo en su IDE, compilarlo y conocer las comprobaciones realizadas y los requisitos pendientes.
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
