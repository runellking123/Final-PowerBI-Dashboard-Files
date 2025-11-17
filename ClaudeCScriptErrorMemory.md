# Claude C# Script Error Memory - Tabular Editor 2

## IMPORTANT: Read this to Claude at the start of any session where you need C# scripts for Tabular Editor 2

---

## Critical Rules for Tabular Editor 2 C# Scripts

### 1. Use Explicit Type Declarations (NOT var)
```csharp
// CORRECT
string tableName = "MyTable";
string sourceTable = "wly_ipeds";
string currentFolder = "";

// WRONG - causes CS1056 errors
var tableName = "MyTable";
var sourceTable = "wly_ipeds";
```

### 2. No String Interpolation ($"" or $@"")
```csharp
// CORRECT
"DISTINCTCOUNT(" + sourceTable + "[ID Number])"
"CALCULATE(DISTINCTCOUNT(" + sourceTable + "[ID Number]), " + sourceTable + "[Gender] = \"F\")"

// WRONG - causes "Unexpected character '$'" errors
$"DISTINCTCOUNT({sourceTable}[ID Number])"
$@"CALCULATE(DISTINCTCOUNT({sourceTable}[ID Number]))"
```

### 3. Avoid Special Characters in Measure Names
```csharp
// CORRECT
"IPEDS Female Pct"
"IPEDS In-State Pct"

// PROBLEMATIC - can cause encoding issues
"IPEDS Female %"
"IPEDS In-State %"
```

### 4. No Variable Name Collisions (CS0136 Error)
```csharp
// CORRECT - different names for outer variable and lambda parameter
string currentFolder = "";
Action<string, string, string, string> AddMeasure = (name, expression, folderName, description) =>

// WRONG - same name causes scope conflict
string folder = "";
Action<string, string, string, string> AddMeasure = (name, expression, folder, description) =>
```

### 5. Keep DAX Expressions on Single Lines
```csharp
// CORRECT
"VAR CurrentYearCount = CALCULATE(DISTINCTCOUNT(" + sourceTable + "[ID Number]), " + sourceTable + "[Year Code] = MAX(" + sourceTable + "[Year Code])) RETURN CurrentYearCount"

// AVOID - multi-line with newlines can cause parsing issues
"VAR CurrentYearCount = " +
"CALCULATE( " +
"DISTINCTCOUNT(" + sourceTable + "[ID Number]) " +
")"
```

### 6. Proper Quote Escaping
```csharp
// CORRECT
sourceTable + "[Gender] = \"F\""
sourceTable + "[Term Code] = \"10\""

// WRONG
sourceTable + "[Gender] = 'F'"  // Single quotes don't work in DAX for strings
```

### 7. Use Simple Format Strings
```csharp
// CORRECT
m.FormatString = "0.0";
m.FormatString = "#,##0";
m.FormatString = "0.00";

// AVOID complex format strings that may have encoding issues
m.FormatString = "0.0\"%\"";  // Can cause problems
```

---

## Common Errors and Solutions

| Error Code | Description | Solution |
|------------|-------------|----------|
| CS1056 | Unexpected character '$' | Remove all string interpolation, use concatenation |
| CS0136 | Variable cannot be declared in this scope | Rename lambda parameters to avoid conflicts |
| CS1002 | ; expected | Check for missing semicolons or malformed strings |

---

## Template for Future Scripts

```csharp
// Tabular Editor 2 C# Script
// CONFIGURATION - use explicit string types
string measuresTableName = "Your Measures Table";
string sourceTable = "your_source_table";

// Create table if needed
if (!Model.Tables.Contains(measuresTableName))
{
    var newTable = Model.AddCalculatedTable(measuresTableName, "ROW(\"Helper\", 1)");
    newTable.IsHidden = false;
}

var targetTable = Model.Tables[measuresTableName];
string currentFolder = "";

// Helper function - note folderName parameter (not folder)
Action<string, string, string, string> AddMeasure = (name, expression, folderName, description) =>
{
    if (!targetTable.Measures.Contains(name))
    {
        var m = targetTable.AddMeasure(name, expression);
        m.DisplayFolder = folderName;
        m.Description = description;
        m.FormatString = "#,##0";
    }
};

// Add measures using string concatenation
currentFolder = "01. Category Name";
AddMeasure(
    "Measure Name",
    "DISTINCTCOUNT(" + sourceTable + "[Column Name])",
    currentFolder,
    "Description"
);

Info("Script completed successfully");
```

---

## How to Use This File

When starting a new Claude session and you need a C# script for Tabular Editor 2:

1. Tell Claude: "Read the ClaudeCScriptErrorMemory.md file first"
2. Or copy/paste these rules into your prompt
3. This ensures Claude follows the correct patterns and avoids compile errors

---

Last Updated: November 2025
Based on errors encountered with Tabular Editor 2.27.2
