-- Actualiza la configuración de máquinas de planta usando MachineId como clave
-- primaria. Este script garantiza que los nombres, la bandera SupportsCombination
-- y los códigos ElementId coincidan con los valores utilizados en la aplicación.
WITH SourceMachines AS (
    SELECT * FROM (VALUES
        (1, N'Olla 1', 0, N'5b558a9a88f149bab44613d87e9ac93a'),
        (2, N'Olla 2', 0, N'ed67b5fcb02f440fbdf83e2ef42d0150'),
        (3, N'Pasteurizador 1', 0, N'ab56a66ea1194b108c5f85e2e3514aa7'),
        (4, N'Homogeneizador', 0, NULL),
        (5, N'Madurador 1', 0, N'765a98e28941484086c5be618f5aa092'),
        (6, N'Madurador 2', 0, N'e3f55cb5309349dd84490080c628bc66'),
        (7, N'Madurador 3', 0, N'c0e9afa059944e4f87880425c9e41697'),
        (8, N'Madurador 4', 0, N'3332266874ff440d9c01768492c8e3da'),
        (9, N'Madurador 5', 0, N'40880c25ca9045b7b984898269afaff5'),
        (10, N'Madurador 6', 0, N'cb8964302032499faf9ab1f2282391f1'),
        (11, N'Madurador 7', 0, N'f3d6dc95c3994f7eb8c66a66d9f66fe4'),
        (12, N'Madurador 8', 0, N'88b388a47e8c4ff88e07d077245d6a42'),
        (13, N'Tanque de premezcla', 1, NULL),
        (14, N'Tanque de mezcla 1', 1, NULL),
        (15, N'Tanque de mezcla 2', 1, NULL),
        (16, N'Tanque de mezcla 3', 1, NULL),
        (17, N'Batidora 1', 0, N'12f1043e4566436fb58cf72d73b9c05e'),
        (18, N'Batidora 2', 0, N'8fcd1e13b2594cd7a3368e2fe89a20dd')
    ) AS s(MachineId, MachineName, SupportsCombination, ElementId)
)
UPDATE mp
SET
    mp.MachineName = sm.MachineName,
    mp.SupportsCombination = sm.SupportsCombination,
    mp.ElementId = sm.ElementId
FROM dbo.maquinas_planta AS mp
INNER JOIN SourceMachines AS sm ON sm.MachineId = mp.MachineId;
