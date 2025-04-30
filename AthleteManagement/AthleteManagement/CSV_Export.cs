using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AthleteManagement
{
    internal class CSV_Export
    {
        public void ExportToCsv(List<ParticipantResult> data, string filePath, bool includeHeaders = true)
        {
            try
            {
                // Use a StringBuilder for efficient string concatenation
                StringBuilder sb = new StringBuilder();
                if (includeHeaders)
                {
                    // Append column headers
                    sb.AppendLine("BibNumber,Name,Team,FinishTime"); // Customize headers as needed
                }
                // Loop through the data and append each row to the StringBuilder
                foreach (var result in data)
                {
                    // Format each data row, handling commas and null values
                    sb.AppendLine($"{EscapeCsvField(result.BibNumber)},{EscapeCsvField(result.Name)},{EscapeCsvField(result.Team)},{EscapeCsvField(result.FinishTime.ToString())}");
                }
                // Write the CSV data to the specified file
                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Data exported to CSV successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file access errors)
                MessageBox.Show($"Error exporting to CSV: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Helper method to escape commas and quotes in CSV fields
        private string EscapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field))
            {
                return ""; // Or any other default value you prefer
            }
            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
            {
                // Enclose the field in double quotes and escape any inner quotes
                return "\"" + field.Replace("\"", "\"\"") + "\"";
            }
            return field;
        }
    }
}
