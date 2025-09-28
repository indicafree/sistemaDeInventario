# 🛠️ Proyecto: Sistema de Consulta y Exportación de Artículos

Aplicación de escritorio desarrollada en **C# con Windows Forms** para la gestión de artículos.  
Permite consultar productos desde un archivo `.dat`, filtrarlos por rubro, calcular valores en stock y exportar los resultados a un archivo `.csv`.

---

## 🚀 Funcionalidades

- **Lectura de datos externos**
  - Carga artículos desde `ARTICULOS.DAT` y rubros desde `RUBROS.DAT`.
  - Procesamiento de datos separados por `;`.

- **Interfaz gráfica**
  - Implementada con **Windows Forms**.
  - Uso de `DataGridView`, `ComboBox`, `Label`, `TextBox` y `Button`.
  - Filtrado dinámico de productos por rubro.
  - Muestra en tiempo real de:
    - Cantidad de productos listados.
    - Stock del producto seleccionado.
    - Valor en stock (`costo * cantidad`).

- **Exportación de datos**
  - Exporta los artículos filtrados a `.csv`.
  - Uso de `SaveFileDialog` para elegir ubicación y nombre.
  - Generación de nombres dinámicos con rubro + fecha (ejemplo: `Repuestos_2025092_
