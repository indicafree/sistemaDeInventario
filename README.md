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
  - Generación de nombres dinámicos con rubro + fecha (ejemplo: `Repuestos_20250926.csv`).

---

## 🖥️ Tecnologías utilizadas

- Lenguaje: **C#**
- Entorno: **Visual Studio**
- GUI: **Windows Forms**
- Manejo de archivos: `System.IO`
- Programación orientada a eventos

---

## 📂 Ejemplo de código

```csharp
private void lblexportar_Click(object sender, EventArgs e)
{
    if (dgvArtuculos.Rows.Count == 0 || dgvArtuculos.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
    {
        MessageBox.Show("No hay datos para exportar.", "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    string rubroSeleccionado = cmbRubros.SelectedItem?.ToString() ?? "Articulos";

    SaveFileDialog saveFile = new SaveFileDialog();
    saveFile.Filter = "Archivo CSV|*.csv";
    saveFile.Title = "Guardar artículos filtrados";
    saveFile.FileName = $"{rubroSeleccionado}_{DateTime.Now:yyyyMMdd}.csv";

    if (saveFile.ShowDialog() == DialogResult.OK)
    {
        using (StreamWriter writer = new StreamWriter(saveFile.FileName))
        {
            writer.WriteLine("Código,Descripción,Costo,Rubro,Stock");

            foreach (DataGridViewRow fila in dgvArtuculos.Rows)
            {
                if (!fila.IsNewRow)
                {
                    string linea = string.Join(",",
                        fila.Cells[0].Value,
                        fila.Cells[1].Value,
                        fila.Cells[2].Value,
                        fila.Cells[3].Value,
                        fila.Cells[4].Value
                    );
                    writer.WriteLine(linea);
                }
            }
        }

        MessageBox.Show($"Archivo CSV exportado correctamente como {Path.GetFileName(saveFile.FileName)}",
            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
✅ Aprendizajes
Manejo de archivos planos (.dat) y exportación a .csv.

Interacción con la interfaz gráfica mediante eventos (Click, CellClick, SelectionChanged).

Validaciones para evitar errores al procesar datos vacíos.

Desarrollo de un flujo completo: consulta → visualización → cálculo → exportación.


