// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================
using System.Reflection;
 
    var assembly =Assembly.GetExecutingAssembly();
    var version = assembly.GetName().Version;



Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"{version}");
Console.WriteLine($"Versión: 1.0.0");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estructura de proyecto: ");
Console.WriteLine("Configuracion .csproj: ");
Console.WriteLine("Carpeta src/ creada");
Console.WriteLine("Metadatos Configurados");
Console.WriteLine();
Console.WriteLine("Proximo paso: Agregar argumentos CLI' y confguracion de repositorio en github");
