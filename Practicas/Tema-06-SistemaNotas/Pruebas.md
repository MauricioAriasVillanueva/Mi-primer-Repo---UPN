
# Pruebas del Sistema de Notas - Tema 6

## 1. Objetivo

Comprobar el funcionamiento del sistema de notas desarrollado en C#, verificando la validación de datos, el cálculo de promedios y la determinación de la condición académica.

## 2. Métodos evaluados

- `NotasValidas()`: verifica que el arreglo no esté vacío y que las notas estén entre 0 y 20.
- `CalcularPromedio()`: calcula el promedio de las notas.
- `DeterminarCondicion()`: determina si el estudiante está aprobado o reprobado, considerando 13 como nota mínima aprobatoria.

## 3. Casos de prueba

| Caso | Entrada | Resultado esperado | Resultado obtenido | Estado |
|---|---|---|---|---|
| Grupo A - Normal | {12, 15, 18, 20, 17} | 16,40 - Aprobado | 16,40 - Aprobado | Pasó |
| Grupo B - Límite | {13} | 13,00 - Aprobado | 13,00 - Aprobado | Pasó |
| Grupo C - Reprobado | {12.99} | 12,99 - Reprobado | 12,99 - Reprobado | Pasó |
| Grupo D - Vacío | {} | Notas inválidas | Notas inválidas | Pasó |
| Grupo E - Fuera de rango | {12, 15, 18, 20, 21} | Notas inválidas | Notas inválidas | Pasó |

## 4. Resultados de ejecución

Se ejecutó el proyecto utilizando el comando `dotnet run`.

Salida obtenida:

```text
Grupo A: 16,40 - Aprobado
Grupo B: 13,00 - Aprobado
Grupo C: 12,99 - Reprobado
Grupo D tiene notas inválidas.
Grupo E tiene notas inválidas.
```

## 5. Análisis de resultados

Los cinco casos de prueba produjeron los resultados esperados para la implementación actual.

- El Grupo A permitió comprobar el cálculo de un promedio con cinco notas válidas.
- El Grupo B confirmó que una nota de 13 se considera aprobatoria.
- El Grupo C confirmó que un promedio inferior a 13 produce la condición "Reprobado".
- El Grupo D comprobó que el sistema rechaza arreglos vacíos.
- El Grupo E comprobó que el sistema detecta una nota fuera del rango permitido.

## 6. Conclusión

El sistema superó los cinco casos de prueba realizados. La separación de responsabilidades entre validación, cálculo y condición académica facilitó la comprobación de su funcionamiento.

Los métodos se encuentran organizados en la clase `Calculos`, mientras que `Program.cs` coordina su ejecución y presenta los resultados.
