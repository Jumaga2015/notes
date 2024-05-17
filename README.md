# Ruta al directorio que deseas monitorear
$directorio = "C:\Ruta\A\Tu\Directorio"

# Función para obtener el número de archivos, escribir en el log y medir el tiempo
function ObtenerNumeroArchivos {
    $horaActual = Get-Date -Format "HH:mm:ss"
    $numeroArchivos = (Get-ChildItem -Path $directorio -File).Count

    # Ruta al archivo de registro
    $rutaLog = "C:\Ruta\A\Tu\Log\archivo.log"

    # Agregar la hora, el número de archivos y el tiempo al archivo de registro
    Add-Content -Path $rutaLog -Value "$horaActual - Archivos totales: $numeroArchivos"

    # Medir el tiempo de ejecución
    $tiempoEjecucion = (Measure-Command {
        # Coloca aquí cualquier otra acción que desees realizar
    }).TotalSeconds

    # Agregar el tiempo al archivo de registro
    Add-Content -Path $rutaLog -Value "Tiempo de ejecución: $tiempoEjecucion segundos"
}

# Ejecutar la función cada hora
while ($true) {
    ObtenerNumeroArchivos
    Start-Sleep -Seconds 3600  # Esperar 1 hora
}


# Copiar ficheros por fechas
# Define la ruta de las carpetas de origen y destino
$carpetasOrigen = "C:\Ruta\Origen1", "C:\Ruta\Origen2", "C:\Ruta\Origen3"
$carpetaDestino = "C:\Ruta\Destino"

# Define la máscara de archivo (por ejemplo, "*.txt" para archivos de texto)
$mascara = "*.txt"

# Define la fecha mínima desde la cual deseas copiar los archivos
$fechaMinima = Get-Date "2024-05-01"

# Copia los archivos que coinciden con la máscara y que fueron modificados después de la fecha mínima
foreach ($carpeta in $carpetasOrigen) {
    Get-ChildItem -Path $carpeta -File -Recurse | Where-Object { $_.LastWriteTime -ge $fechaMinima -and $_.Name -like $mascara } | ForEach-Object {
        $rutaRelativa = $_.FullName -replace [regex]::escape($carpeta), ""
        $destino = Join-Path -Path $carpetaDestino -ChildPath $rutaRelativa
        Write-Host "Copiando archivo desde $($_.FullName) a $destino"
        Copy-Item -Path $_.FullName -Destination $destino -Force
    }
}


