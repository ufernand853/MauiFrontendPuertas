using System.Collections.Generic;

namespace MauiFrontendPuertas.Data;

/// <summary>
/// Catálogo estático de máquinas que la aplicación puede consultar para conocer
/// el identificador numérico (MachineId), el nombre visible, el código asociado
/// y si permite combinaciones.
/// </summary>
public static class MachineCatalog
{
    public static IReadOnlyList<Machine> Machines { get; } = new List<Machine>
    {
        new(1, "5b558a9a88f149bab44613d87e9ac93a", "Olla 1", false),
        new(2, "ed67b5fcb02f440fbdf83e2ef42d0150", "Olla 2", false),
        new(3, "ab56a66ea1194b108c5f85e2e3514aa7", "Pasteurizador 1", false),
        new(4, null, "Homogeneizador", false),
        new(5, "765a98e28941484086c5be618f5aa092", "Madurador 1", false),
        new(6, "e3f55cb5309349dd84490080c628bc66", "Madurador 2", false),
        new(7, "c0e9afa059944e4f87880425c9e41697", "Madurador 3", false),
        new(8, "3332266874ff440d9c01768492c8e3da", "Madurador 4", false),
        new(9, "40880c25ca9045b7b984898269afaff5", "Madurador 5", false),
        new(10, "cb8964302032499faf9ab1f2282391f1", "Madurador 6", false),
        new(11, "f3d6dc95c3994f7eb8c66a66d9f66fe4", "Madurador 7", false),
        new(12, "88b388a47e8c4ff88e07d077245d6a42", "Madurador 8", false),
        new(13, null, "Tanque de premezcla", true),
        new(14, null, "Tanque de mezcla 1", true),
        new(15, null, "Tanque de mezcla 2", true),
        new(16, null, "Tanque de mezcla 3", true),
        new(17, "12f1043e4566436fb58cf72d73b9c05e", "Batidora 1", false),
        new(18, "8fcd1e13b2594cd7a3368e2fe89a20dd", "Batidora 2", false)
    };
}

/// <summary>
/// Representa la definición de una máquina en el front-end.
/// </summary>
/// <param name="MachineId">Identificador numérico usado en cocina_recipe_tracking.</param>
/// <param name="Code">Identificador interno que coincide con ElementId en base de datos (puede ser null).</param>
/// <param name="Name">Nombre mostrado al usuario.</param>
/// <param name="SupportsCombination">Indica si permite combinaciones.</param>
public sealed record Machine(int MachineId, string? Code, string Name, bool SupportsCombination);
