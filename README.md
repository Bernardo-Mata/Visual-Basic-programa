# Visual-Basic-programa

## 000001_EO_WinForms - VB.NET WinForms Application

### Descripción
Aplicación de escritorio desarrollada en VB.NET WinForms con sistema de login y menú de navegación.

### Funcionalidades

#### Login (Form1)
- **Usuario**: SAM
- **Contraseña**: 123
- Validación de credenciales
- Redirección a menú principal al autenticarse

#### Menú Principal
Panel de navegación izquierdo con 5 opciones:

1. **Biografía**: TabControl con pestañas de información personal, educación y experiencia
2. **Operaciones**: Calculadora de operaciones aritméticas básicas (Suma, Resta, Multiplicación, División)
3. **Interés**: Cálculo de interés compuesto con fórmula M = C * (1 + r/100)^t
4. **Calculadora**: Calculadora con botones numéricos
5. **Información**: Texto informativo sobre la aplicación

### Requisitos
- .NET 8.0 SDK o superior
- Windows (para ejecución)

### Compilación
```bash
cd 000001_EO_WinForms
dotnet build
```

### Ejecución
```bash
dotnet run
```