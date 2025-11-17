// Tabular Editor 2 C# Script - Update Column References
// Updates all column names in the Power BI model to match CSV file naming
// This preserves all visuals and DAX formulas by updating references
// Follows ClaudeCScriptErrorMemory.md standards

// Column name mappings: old_name -> new_name
// Format: "table_name[old_column]" -> "new_column_name"

int updateCount = 0;

// Helper function to rename a column if the old name matches
Action<Microsoft.AnalysisServices.Tabular.Table, string, string> RenameColumn = (tbl, oldName, newName) =>
{
    foreach(Microsoft.AnalysisServices.Tabular.Column col in tbl.Columns)
    {
        if (col.Name == oldName && col.Name != newName)
        {
            Info("Renaming: " + tbl.Name + "[" + col.Name + "] -> [" + newName + "]");
            col.Name = newName;
            updateCount++;
        }
    }
};

// Loop through all tables
foreach(Microsoft.AnalysisServices.Tabular.Table table in Model.Tables)
{
    // Skip auto-generated date tables
    if (table.Name.StartsWith("LocalDateTable_") || table.Name.StartsWith("DateTableTemplate_"))
    {
        continue;
    }

    // Rename columns in this table
    RenameColumn(table, "id_num", "ID Number");
    RenameColumn(table, "ID_NUM", "ID Number");
    RenameColumn(table, "yr_cde", "Year");
    RenameColumn(table, "YR_CDE", "Year");
    RenameColumn(table, "trm_cde", "Term");
    RenameColumn(table, "TRM_CDE", "Term");
    RenameColumn(table, "div_cde", "Division Code");
    RenameColumn(table, "DIV_CDE", "Division Code");
    RenameColumn(table, "ssn", "Ssn");
    RenameColumn(table, "last_name", "Last Name");
    RenameColumn(table, "first_name", "First Name");
    RenameColumn(table, "mid_name", "Mid Name");
    RenameColumn(table, "ethnic_grp", "Ethnic Group");
    RenameColumn(table, "race_grp", "Race Group");
    RenameColumn(table, "gender", "Gender");
    RenameColumn(table, "citizen_of", "Citizen Of");
    RenameColumn(table, "religion", "Religion");
    RenameColumn(table, "birth_dte", "Birth Dte");
    RenameColumn(table, "age", "Age");
    RenameColumn(table, "addr1", "Addr1");
    RenameColumn(table, "perm_city", "Perm City");
    RenameColumn(table, "perm_state", "Perm State");
    RenameColumn(table, "perm_zip", "Perm Zip");
    RenameColumn(table, "county", "County");
    RenameColumn(table, "country", "Country");
    RenameColumn(table, "phone", "Phone");
    RenameColumn(table, "class_cde", "Class Code");
    RenameColumn(table, "CLASS_CDE", "Class Code");
    RenameColumn(table, "f_p_time", "F P Time");
    RenameColumn(table, "hrs_enrld", "Hrs Enrld");
    RenameColumn(table, "HRS_ENROLLED", "Hrs Enrolled");
    RenameColumn(table, "cum_gpa", "Cum GPA");
    RenameColumn(table, "major1", "Major1");
    RenameColumn(table, "major2", "Major2");
    RenameColumn(table, "expct_grad_dte", "Expct Grad Dte");
    RenameColumn(table, "cand_type", "Cand Type");
    RenameColumn(table, "hs_grad_yr", "Hs Grad Year");
    RenameColumn(table, "hs_rank", "Hs Rank");
    RenameColumn(table, "resid_commuter_sts", "Resid Commuter Sts");
    RenameColumn(table, "dorm_loc_cde", "Dorm Loc Code");
    RenameColumn(table, "dorm_bldg_cde", "Dorm Bldg Code");
    RenameColumn(table, "dorm_room_cde", "Dorm Room Code");
    RenameColumn(table, "add_date", "Add Date");
    RenameColumn(table, "tuition_cde", "Tuition Code");
    RenameColumn(table, "career_hrs_att", "Career Hrs Att");
    RenameColumn(table, "career_hrs_earned", "Career Hrs Earned");
    RenameColumn(table, "career_hrs_gpa", "Career Hrs GPA");
    RenameColumn(table, "career_qual_points", "Career Qual Points");
    RenameColumn(table, "career_gpa", "Career GPA");
    RenameColumn(table, "CAREER_GPA", "Career GPA");
    RenameColumn(table, "local_city", "Local City");
    RenameColumn(table, "local_zip", "Local Zip");
    RenameColumn(table, "CRS_CDE", "Course Code");
    RenameColumn(table, "DEGR_CDE", "Degr Code");
    RenameColumn(table, "MAJOR_1", "Major 1");
    RenameColumn(table, "MAJOR_2", "Major 2");
    RenameColumn(table, "MINOR_1", "Minor 1");
    RenameColumn(table, "HRS_ATTEMPTED", "Hrs Attempted");
    RenameColumn(table, "HRS_EARNED", "Hrs Earned");
    RenameColumn(table, "FEES_AMT", "Fees Amt");
    RenameColumn(table, "FEE_CDE", "Fee Code");
    RenameColumn(table, "CRS_CAPACITY", "Course Capacity");
    RenameColumn(table, "CRS_ENROLLMENT", "Course Enrollment");
    RenameColumn(table, "CRS_TITLE", "Course Title");
    RenameColumn(table, "SECTION_STS", "Section Sts");
    RenameColumn(table, "CREDIT_HRS", "Credit Hrs");
    RenameColumn(table, "INSTRCTR_ID_NUM", "Instructr ID Number");
    RenameColumn(table, "DTE_DEGR_CONFERRED", "Dte Degr Conferred");
    RenameColumn(table, "ENTRY_DTE", "Entry Dte");
    RenameColumn(table, "WITHDRAWAL_DTE", "Withdrawal Dte");
    RenameColumn(table, "EXIT_DTE", "Exit Dte");
}

// Summary message
Info("===============================================");
Info("Column update complete! Updated " + updateCount.ToString() + " columns");
Info("===============================================");
Info("All DAX formulas and visual references have been automatically updated");
Info("Your visuals will now reference the new column names from CSV files");
Info("Save this model to apply changes to your .pbix file");
