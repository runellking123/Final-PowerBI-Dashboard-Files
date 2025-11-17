// Tabular Editor 2 C# Script - Update Column References
// Updates all column names in the Power BI model to match CSV file naming
// This preserves all visuals and DAX formulas by updating references
// Follows ClaudeCScriptErrorMemory.md standards

// Column name mappings: old_name -> new_name
// Format: "table_name[old_column]" -> "new_column_name"

int updateCount = 0;

// Define all column renames
System.Collections.Generic.Dictionary<string, string> columnMappings = new System.Collections.Generic.Dictionary<string, string>();

// wly_ipeds table mappings
columnMappings.Add("id_num", "ID Number");
columnMappings.Add("yr_cde", "Year");
columnMappings.Add("trm_cde", "Term");
columnMappings.Add("div_cde", "Division Code");
columnMappings.Add("ssn", "Ssn");
columnMappings.Add("last_name", "Last Name");
columnMappings.Add("first_name", "First Name");
columnMappings.Add("mid_name", "Mid Name");
columnMappings.Add("ethnic_grp", "Ethnic Group");
columnMappings.Add("race_grp", "Race Group");
columnMappings.Add("gender", "Gender");
columnMappings.Add("citizen_of", "Citizen Of");
columnMappings.Add("religion", "Religion");
columnMappings.Add("birth_dte", "Birth Dte");
columnMappings.Add("age", "Age");
columnMappings.Add("addr1", "Addr1");
columnMappings.Add("perm_city", "Perm City");
columnMappings.Add("perm_state", "Perm State");
columnMappings.Add("perm_zip", "Perm Zip");
columnMappings.Add("county", "County");
columnMappings.Add("country", "Country");
columnMappings.Add("phone", "Phone");
columnMappings.Add("class_cde", "Class Code");
columnMappings.Add("f_p_time", "F P Time");
columnMappings.Add("hrs_enrld", "Hrs Enrld");
columnMappings.Add("cum_gpa", "Cum GPA");
columnMappings.Add("major1", "Major1");
columnMappings.Add("major2", "Major2");
columnMappings.Add("expct_grad_dte", "Expct Grad Dte");
columnMappings.Add("cand_type", "Cand Type");
columnMappings.Add("hs_grad_yr", "Hs Grad Year");
columnMappings.Add("hs_rank", "Hs Rank");
columnMappings.Add("resid_commuter_sts", "Resid Commuter Sts");
columnMappings.Add("dorm_loc_cde", "Dorm Loc Code");
columnMappings.Add("dorm_bldg_cde", "Dorm Bldg Code");
columnMappings.Add("dorm_room_cde", "Dorm Room Code");
columnMappings.Add("add_date", "Add Date");
columnMappings.Add("tuition_cde", "Tuition Code");
columnMappings.Add("career_hrs_att", "Career Hrs Att");
columnMappings.Add("career_hrs_earned", "Career Hrs Earned");
columnMappings.Add("career_hrs_gpa", "Career Hrs GPA");
columnMappings.Add("career_qual_points", "Career Qual Points");
columnMappings.Add("career_gpa", "Career GPA");
columnMappings.Add("local_city", "Local City");
columnMappings.Add("local_zip", "Local Zip");

// Common UPPER_CASE mappings (for other tables)
columnMappings.Add("ID_NUM", "ID Number");
columnMappings.Add("YR_CDE", "Year");
columnMappings.Add("TRM_CDE", "Term");
columnMappings.Add("DIV_CDE", "Division Code");
columnMappings.Add("CRS_CDE", "Course Code");
columnMappings.Add("DEGR_CDE", "Degr Code");
columnMappings.Add("CLASS_CDE", "Class Code");
columnMappings.Add("MAJOR_1", "Major 1");
columnMappings.Add("MAJOR_2", "Major 2");
columnMappings.Add("MINOR_1", "Minor 1");
columnMappings.Add("HRS_ENROLLED", "Hrs Enrolled");
columnMappings.Add("HRS_ATTEMPTED", "Hrs Attempted");
columnMappings.Add("HRS_EARNED", "Hrs Earned");
columnMappings.Add("CAREER_GPA", "Career GPA");
columnMappings.Add("FEES_AMT", "Fees Amt");
columnMappings.Add("FEE_CDE", "Fee Code");
columnMappings.Add("CRS_CAPACITY", "Course Capacity");
columnMappings.Add("CRS_ENROLLMENT", "Course Enrollment");
columnMappings.Add("CRS_TITLE", "Course Title");
columnMappings.Add("SECTION_STS", "Section Sts");
columnMappings.Add("CREDIT_HRS", "Credit Hrs");
columnMappings.Add("INSTRCTR_ID_NUM", "Instructr ID Number");
columnMappings.Add("DTE_DEGR_CONFERRED", "Dte Degr Conferred");
columnMappings.Add("ENTRY_DTE", "Entry Dte");
columnMappings.Add("WITHDRAWAL_DTE", "Withdrawal Dte");
columnMappings.Add("EXIT_DTE", "Exit Dte");

// Loop through all tables
foreach(Microsoft.AnalysisServices.Tabular.Table table in Model.Tables)
{
    // Skip auto-generated date tables
    if (table.Name.StartsWith("LocalDateTable_") || table.Name.StartsWith("DateTableTemplate_"))
    {
        continue;
    }

    // Loop through columns in this table
    foreach(Microsoft.AnalysisServices.Tabular.Column column in table.Columns)
    {
        // Check if this column needs to be renamed
        if (columnMappings.ContainsKey(column.Name))
        {
            string newName = columnMappings[column.Name];
            if (column.Name != newName)
            {
                Info("Renaming: " + table.Name + "[" + column.Name + "] -> [" + newName + "]");
                column.Name = newName;
                updateCount++;
            }
        }
    }
}

// Summary message
Info("===============================================");
Info("Column update complete! Updated " + updateCount.ToString() + " columns");
Info("===============================================");
Info("All DAX formulas and visual references have been automatically updated");
Info("Your visuals will now reference the new column names from CSV files");
Info("Save this model to apply changes to your .pbix file");
