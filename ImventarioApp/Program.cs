// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================

using System.Reflection;
using System.Xml;

var assembly =Assembly.GetExecutingAssembly();
    var version = assembly.GetName().Version;

 if (args.Length > 0)
{
    switch(args[0].ToLower())
    {
        case "--help":
            MostrarAyuda();
            Environment.Exit(0);
            break;

            case "--version":
                Console.WriteLine($"ImventarioApp v({version})");
                Environment.Exit(0);
                break;

                deafault:
                Console.WriteLine($"Error: Comando desconocido '{args[0]}'");
                Console.WriteLine("use --help para ver los comandos disponibles. ");
                Environment.Exit(1);
    }
}

    int cantidadProductos = 0;
    decimal valorTotalDelInventario = 0.00m;
    bool sistemaActivo = true;
    string nombreSistema = "Sistema de Gestion de Inventario";
    decimal precio = 19.99m;

    Console.WriteLine("Estado del Sistema");
    Console.WriteLine($" Nombre: {nombreSistema}");
    Console.WriteLine($" Producto registrados: {cantidadProductos}");
    Console.WriteLine($" Valor total del inventario: $ {valorTotalDelInventario:N2}");
    Console.WriteLine($" Sistema activo: {(sistemaActivo ? "Si" : "No")}");

    Console.WriteLine("Ingrese una cantidad: ");
    string? entradaCantidad = Console.ReadLine();
    
    // Conversion segura Tryparse
    if (int.TryParse(entradaCantidad, out int cantidad))
{
    Console.WriteLine($"Cantidad validada: {cantidad}\n");
    cantidadProductos = cantidad;
}
else
{
    Console.WriteLine("Error: debe ingresar un numero entrero");

}
Console.WriteLine("Ingresar un precio: ");
string? entradaPrecio = Console.ReadLine();

if (decimal.TryParse(entradaPrecio, out decimal precio2))
{
    Console.Write($"Precio validado: {precio2:N2}\n");
    valorTotalDelInventario = cantidadProductos * precio2;
    Console.WriteLine($"Valor total del inventario actualizado: ${valorTotalDelInventario:N2}");
}
else
{
    Console.WriteLine("Error: debe ingresar un numero decimal");
}

   // MostratBanner();

 // Modo interactivo si no hay argumentos
 Console.WriteLine("ingrese un comando(o 'salir' para terminar): ");
 string? entrada = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(entrada) || entrada.ToLower() == "salir")
{
    Console.WriteLine("Hasta Luego!"); //STDOut para mostrar un mensaje de despedida
    Environment.Exit(0);    
}
 /*
Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"{version}");
Console.WriteLine($"Versión: 1.0.0");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine();
Console.WriteLine("Estructura de proyecto: ");
Console.WriteLine(" InventarioApp/");
Console.WriteLine("  |--Program.cs");
Console.WriteLine("  |--InventarioApp.csproj");
Console.WriteLine("  |--gitignore");
Console.WriteLine("  |--README.md");
Console.WriteLine("  |--src/");
Console.WriteLine("     |--Models/ (Proxima clase");
Console.WriteLine("Configuracion.csproj: ");
Console.WriteLine("Carpeta src/ creada");
Console.WriteLine("Metadatos Configurados");
Console.WriteLine();
Console.WriteLine("Proximo paso: Checkpoint");*/

// =================== FUNCIONES ===================
void MostratBanner()
{
    Console.WriteLine("================================");
    Console.WriteLine("SISTEMA DE GESTION DE INVENTARIO");
    Console.WriteLine("================================");
    Console.WriteLine();
    Console.WriteLine($"Version: {version}");
    Console.WriteLine($".NET: {Environment.Version}");
    Console.WriteLine();
}

void MostrarAyuda()
{
    Console.WriteLine("================================");
    Console.WriteLine("SISTEMA DE GESTION DE INVENTARIO");
    Console.WriteLine("================================");
    Console.WriteLine();
    Console.WriteLine("USO: InventarioApp [comando] [opciones]");
    Console.WriteLine();
    Console.WriteLine("COMANDOS:");
    Console.WriteLine("  --help, -h      Muestra esta ayuda");
    Console.WriteLine("  --version, -v   Muestra la version del programa");
    Console.WriteLine();
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine(" dotnet run -- --help");
    Console.WriteLine(" dotnet run -- --version");
}