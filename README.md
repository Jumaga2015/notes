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
