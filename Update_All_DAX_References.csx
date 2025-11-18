// Tabular Editor 2 C# Script - Update ALL DAX References
// Updates all DAX formulas (measures, calculated columns, etc.) to use new column names
// This script updates column references throughout your entire model
// Follows ClaudeCScriptErrorMemory.md standards

int updateCount = 0;

// Helper function to update DAX expression
string UpdateDAXExpression(string daxExpression)
{
    if (string.IsNullOrEmpty(daxExpression))
    {
        return daxExpression;
    }

    string updatedDAX = daxExpression;

    // Replace old column references with new ones
    // Format: table[old_column] -> table[New Column]

    // wly_ipeds table columns
    updatedDAX = updatedDAX.Replace("wly_ipeds[id_num]", "wly_ipeds[ID Number]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[yr_cde]", "wly_ipeds[Year]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[trm_cde]", "wly_ipeds[Term]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[div_cde]", "wly_ipeds[Division Code]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[ssn]", "wly_ipeds[Ssn]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[last_name]", "wly_ipeds[Last Name]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[first_name]", "wly_ipeds[First Name]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[mid_name]", "wly_ipeds[Mid Name]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[ethnic_grp]", "wly_ipeds[Ethnic Group]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[race_grp]", "wly_ipeds[Race Group]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[gender]", "wly_ipeds[Gender]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[citizen_of]", "wly_ipeds[Citizen Of]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[religion]", "wly_ipeds[Religion]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[birth_dte]", "wly_ipeds[Birth Dte]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[age]", "wly_ipeds[Age]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[addr1]", "wly_ipeds[Addr1]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[perm_city]", "wly_ipeds[Perm City]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[perm_state]", "wly_ipeds[Perm State]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[perm_zip]", "wly_ipeds[Perm Zip]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[county]", "wly_ipeds[County]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[country]", "wly_ipeds[Country]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[phone]", "wly_ipeds[Phone]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[class_cde]", "wly_ipeds[Class Code]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[f_p_time]", "wly_ipeds[F P Time]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[hrs_enrld]", "wly_ipeds[Hrs Enrld]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[cum_gpa]", "wly_ipeds[Cum GPA]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[major1]", "wly_ipeds[Major1]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[major2]", "wly_ipeds[Major2]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[expct_grad_dte]", "wly_ipeds[Expct Grad Dte]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[cand_type]", "wly_ipeds[Cand Type]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[hs_grad_yr]", "wly_ipeds[Hs Grad Year]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[hs_rank]", "wly_ipeds[Hs Rank]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[resid_commuter_sts]", "wly_ipeds[Resid Commuter Sts]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[dorm_loc_cde]", "wly_ipeds[Dorm Loc Code]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[dorm_bldg_cde]", "wly_ipeds[Dorm Bldg Code]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[dorm_room_cde]", "wly_ipeds[Dorm Room Code]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[add_date]", "wly_ipeds[Add Date]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[tuition_cde]", "wly_ipeds[Tuition Code]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[career_hrs_att]", "wly_ipeds[Career Hrs Att]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[career_hrs_earned]", "wly_ipeds[Career Hrs Earned]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[career_hrs_gpa]", "wly_ipeds[Career Hrs GPA]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[career_qual_points]", "wly_ipeds[Career Qual Points]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[career_gpa]", "wly_ipeds[Career GPA]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[local_city]", "wly_ipeds[Local City]");
    updatedDAX = updatedDAX.Replace("wly_ipeds[local_zip]", "wly_ipeds[Local Zip]");

    // stud_term_sum_div table columns
    updatedDAX = updatedDAX.Replace("stud_term_sum_div[ID_NUM]", "stud_term_sum_div[ID Number]");
    updatedDAX = updatedDAX.Replace("stud_term_sum_div[DIV_CDE]", "stud_term_sum_div[Division Code]");
    updatedDAX = updatedDAX.Replace("stud_term_sum_div[YR_CDE]", "stud_term_sum_div[Year]");
    updatedDAX = updatedDAX.Replace("stud_term_sum_div[yr_cde]", "stud_term_sum_div[Year]");
    updatedDAX = updatedDAX.Replace("stud_term_sum_div[TRM_CDE]", "stud_term_sum_div[Term]");
    updatedDAX = updatedDAX.Replace("stud_term_sum_div[CLASS_CDE]", "stud_term_sum_div[Class Code]");
    updatedDAX = updatedDAX.Replace("stud_term_sum_div[HRS_ENROLLED]", "stud_term_sum_div[Hrs Enrolled]");
    updatedDAX = updatedDAX.Replace("stud_term_sum_div[CAREER_GPA]", "stud_term_sum_div[Career GPA]");
    updatedDAX = updatedDAX.Replace("stud_term_sum_div[MAJOR_1]", "stud_term_sum_div[Major 1]");
    updatedDAX = updatedDAX.Replace("stud_term_sum_div[MAJOR_2]", "stud_term_sum_div[Major 2]");
    updatedDAX = updatedDAX.Replace("stud_term_sum_div[MINOR_1]", "stud_term_sum_div[Minor 1]");

    // j1_degree_history table columns
    updatedDAX = updatedDAX.Replace("j1_degree_history[ID_NUM]", "j1_degree_history[ID Number]");
    updatedDAX = updatedDAX.Replace("j1_degree_history[DIV_CDE]", "j1_degree_history[Division Code]");
    updatedDAX = updatedDAX.Replace("j1_degree_history[DEGR_CDE]", "j1_degree_history[Degr Code]");
    updatedDAX = updatedDAX.Replace("j1_degree_history[DTE_DEGR_CONFERRED]", "j1_degree_history[Dte Degr Conferred]");
    updatedDAX = updatedDAX.Replace("j1_degree_history[ENTRY_DTE]", "j1_degree_history[Entry Dte]");
    updatedDAX = updatedDAX.Replace("j1_degree_history[WITHDRAWAL_DTE]", "j1_degree_history[Withdrawal Dte]");
    updatedDAX = updatedDAX.Replace("j1_degree_history[EXIT_DTE]", "j1_degree_history[Exit Dte]");
    updatedDAX = updatedDAX.Replace("j1_degree_history[MAJOR_1]", "j1_degree_history[Major 1]");
    updatedDAX = updatedDAX.Replace("j1_degree_history[MAJOR_2]", "j1_degree_history[Major 2]");
    updatedDAX = updatedDAX.Replace("j1_degree_history[MINOR_1]", "j1_degree_history[Minor 1]");

    // Year_Definition table
    updatedDAX = updatedDAX.Replace("Year_Definition[yr_cde]", "Year_Definition[Year Code]");
    updatedDAX = updatedDAX.Replace("Year_Definition[YR_CDE]", "Year_Definition[Year Code]");

    // Sections table
    updatedDAX = updatedDAX.Replace("Sections[YR_CDE]", "Sections[Year]");
    updatedDAX = updatedDAX.Replace("Sections[TRM_CDE]", "Sections[Term]");
    updatedDAX = updatedDAX.Replace("Sections[CRS_CDE]", "Sections[Course Code]");
    updatedDAX = updatedDAX.Replace("Sections[DIV_CDE]", "Sections[Division Code]");
    updatedDAX = updatedDAX.Replace("Sections[CRS_CAPACITY]", "Sections[Course Capacity]");
    updatedDAX = updatedDAX.Replace("Sections[CRS_ENROLLMENT]", "Sections[Course Enrollment]");
    updatedDAX = updatedDAX.Replace("Sections[CRS_TITLE]", "Sections[Course Title]");
    updatedDAX = updatedDAX.Replace("Sections[SECTION_STS]", "Sections[Section Sts]");
    updatedDAX = updatedDAX.Replace("Sections[CREDIT_HRS]", "Sections[Credit Hrs]");

    // Fees table
    updatedDAX = updatedDAX.Replace("Fees[ID_NUM]", "Fees[ID Number]");
    updatedDAX = updatedDAX.Replace("Fees[YR]", "Fees[Year]");
    updatedDAX = updatedDAX.Replace("Fees[TRM]", "Fees[Term]");
    updatedDAX = updatedDAX.Replace("Fees[FEE_CDE]", "Fees[Fee Code]");
    updatedDAX = updatedDAX.Replace("Fees[FEES_AMT]", "Fees[Fees Amt]");
    updatedDAX = updatedDAX.Replace("Fees[CHG_TYPE]", "Fees[Chg Type]");

    // j1_faculty_load_table
    updatedDAX = updatedDAX.Replace("j1_faculty_load_table[YR_CDE]", "j1_faculty_load_table[Year]");
    updatedDAX = updatedDAX.Replace("j1_faculty_load_table[TRM_CDE]", "j1_faculty_load_table[Term]");
    updatedDAX = updatedDAX.Replace("j1_faculty_load_table[CRS_CDE]", "j1_faculty_load_table[Course Code]");
    updatedDAX = updatedDAX.Replace("j1_faculty_load_table[INSTRCTR_ID_NUM]", "j1_faculty_load_table[Instructr ID Number]");

    // stud_crs_history
    updatedDAX = updatedDAX.Replace("stud_crs_history[ID_NUM]", "stud_crs_history[ID Number]");
    updatedDAX = updatedDAX.Replace("stud_crs_history[YR_CDE]", "stud_crs_history[Year]");
    updatedDAX = updatedDAX.Replace("stud_crs_history[TRM_CDE]", "stud_crs_history[Term]");
    updatedDAX = updatedDAX.Replace("stud_crs_history[CRS_CDE]", "stud_crs_history[Course Code]");
    updatedDAX = updatedDAX.Replace("stud_crs_history[CREDIT_HRS]", "stud_crs_history[Credit Hrs]");
    updatedDAX = updatedDAX.Replace("stud_crs_history[HRS_ATTEMPTED]", "stud_crs_history[Hrs Attempted]");
    updatedDAX = updatedDAX.Replace("stud_crs_history[HRS_EARNED]", "stud_crs_history[Hrs Earned]");

    return updatedDAX;
}

// Update all measures
foreach(Microsoft.AnalysisServices.Tabular.Table table in Model.Tables)
{
    foreach(Microsoft.AnalysisServices.Tabular.Measure measure in table.Measures)
    {
        string oldExpression = measure.Expression;
        string newExpression = UpdateDAXExpression(oldExpression);

        if (oldExpression != newExpression)
        {
            measure.Expression = newExpression;
            updateCount++;
            Info("Updated measure: " + measure.Name);
        }
    }

    // Update calculated columns
    foreach(Microsoft.AnalysisServices.Tabular.Column column in table.Columns)
    {
        if (column.Type.ToString() == "Calculated")
        {
            Microsoft.AnalysisServices.Tabular.CalculatedColumn calcCol = column as Microsoft.AnalysisServices.Tabular.CalculatedColumn;
            if (calcCol != null)
            {
                string oldExpression = calcCol.Expression;
                string newExpression = UpdateDAXExpression(oldExpression);

                if (oldExpression != newExpression)
                {
                    calcCol.Expression = newExpression;
                    updateCount++;
                    Info("Updated calculated column: " + table.Name + "[" + column.Name + "]");
                }
            }
        }
    }
}

// Summary
Info("===========================================================");
Info("DAX Update Complete! Updated " + updateCount.ToString() + " expressions");
Info("===========================================================");
Info("All measures and calculated columns now use new column names");
Info("Your visuals will work correctly after refreshing data");
Info("Save this model to apply changes");
