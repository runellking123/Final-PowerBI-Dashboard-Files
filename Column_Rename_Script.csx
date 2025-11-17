// Tabular Editor 2 C# Script - Column Renaming
// Only renames: yr_cde to Year, trm_cde to Term
// Follows ClaudeCScriptErrorMemory.md standards

// Use explicit type declarations (not var)
int renameCount = 0;

// Loop through all tables
foreach(Microsoft.AnalysisServices.Tabular.Table table in Model.Tables)
{
    // Skip auto-generated date tables
    if (table.Name.StartsWith("LocalDateTable_") || table.Name.StartsWith("DateTableTemplate_"))
    {
        continue;
    }

    // Loop through columns
    foreach(Microsoft.AnalysisServices.Tabular.Column column in table.Columns)
    {
        // Rename yr_cde to Year
        if (column.Name == "yr_cde" || column.Name == "YR_CDE")
        {
            column.Name = "Year";
            renameCount++;
        }
        // Rename trm_cde to Term
        else if (column.Name == "trm_cde" || column.Name == "TRM_CDE")
        {
            column.Name = "Term";
            renameCount++;
        }
    }
}

// Single message at the end - using concatenation (no string interpolation)
Info("Done! Renamed " + renameCount.ToString() + " columns (yr_cde to Year, trm_cde to Term)");
