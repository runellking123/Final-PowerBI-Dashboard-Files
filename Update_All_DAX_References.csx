// Tabular Editor 2 C# Script - Update ALL DAX References
// Updates all DAX formulas to use new column names
// Simple inline approach - no functions

int updateCount = 0;

// Update all measures in all tables
foreach(var table in Model.Tables)
{
    foreach(var measure in table.Measures)
    {
        string oldExpr = measure.Expression;
        string newExpr = oldExpr;

        // wly_ipeds table columns
        newExpr = newExpr.Replace("wly_ipeds[id_num]", "wly_ipeds[ID Number]");
        newExpr = newExpr.Replace("wly_ipeds[yr_cde]", "wly_ipeds[Year]");
        newExpr = newExpr.Replace("wly_ipeds[trm_cde]", "wly_ipeds[Term]");
        newExpr = newExpr.Replace("wly_ipeds[div_cde]", "wly_ipeds[Division Code]");
        newExpr = newExpr.Replace("wly_ipeds[ssn]", "wly_ipeds[Ssn]");
        newExpr = newExpr.Replace("wly_ipeds[last_name]", "wly_ipeds[Last Name]");
        newExpr = newExpr.Replace("wly_ipeds[first_name]", "wly_ipeds[First Name]");
        newExpr = newExpr.Replace("wly_ipeds[mid_name]", "wly_ipeds[Mid Name]");
        newExpr = newExpr.Replace("wly_ipeds[ethnic_grp]", "wly_ipeds[Ethnic Group]");
        newExpr = newExpr.Replace("wly_ipeds[race_grp]", "wly_ipeds[Race Group]");
        newExpr = newExpr.Replace("wly_ipeds[gender]", "wly_ipeds[Gender]");
        newExpr = newExpr.Replace("wly_ipeds[citizen_of]", "wly_ipeds[Citizen Of]");
        newExpr = newExpr.Replace("wly_ipeds[religion]", "wly_ipeds[Religion]");
        newExpr = newExpr.Replace("wly_ipeds[birth_dte]", "wly_ipeds[Birth Dte]");
        newExpr = newExpr.Replace("wly_ipeds[age]", "wly_ipeds[Age]");
        newExpr = newExpr.Replace("wly_ipeds[addr1]", "wly_ipeds[Addr1]");
        newExpr = newExpr.Replace("wly_ipeds[perm_city]", "wly_ipeds[Perm City]");
        newExpr = newExpr.Replace("wly_ipeds[perm_state]", "wly_ipeds[Perm State]");
        newExpr = newExpr.Replace("wly_ipeds[perm_zip]", "wly_ipeds[Perm Zip]");
        newExpr = newExpr.Replace("wly_ipeds[county]", "wly_ipeds[County]");
        newExpr = newExpr.Replace("wly_ipeds[country]", "wly_ipeds[Country]");
        newExpr = newExpr.Replace("wly_ipeds[phone]", "wly_ipeds[Phone]");
        newExpr = newExpr.Replace("wly_ipeds[class_cde]", "wly_ipeds[Class Code]");
        newExpr = newExpr.Replace("wly_ipeds[f_p_time]", "wly_ipeds[F P Time]");
        newExpr = newExpr.Replace("wly_ipeds[hrs_enrld]", "wly_ipeds[Hrs Enrld]");
        newExpr = newExpr.Replace("wly_ipeds[cum_gpa]", "wly_ipeds[Cum GPA]");
        newExpr = newExpr.Replace("wly_ipeds[major1]", "wly_ipeds[Major1]");
        newExpr = newExpr.Replace("wly_ipeds[major2]", "wly_ipeds[Major2]");
        newExpr = newExpr.Replace("wly_ipeds[expct_grad_dte]", "wly_ipeds[Expct Grad Dte]");
        newExpr = newExpr.Replace("wly_ipeds[cand_type]", "wly_ipeds[Cand Type]");
        newExpr = newExpr.Replace("wly_ipeds[hs_grad_yr]", "wly_ipeds[Hs Grad Year]");
        newExpr = newExpr.Replace("wly_ipeds[hs_rank]", "wly_ipeds[Hs Rank]");
        newExpr = newExpr.Replace("wly_ipeds[resid_commuter_sts]", "wly_ipeds[Resid Commuter Sts]");
        newExpr = newExpr.Replace("wly_ipeds[dorm_loc_cde]", "wly_ipeds[Dorm Loc Code]");
        newExpr = newExpr.Replace("wly_ipeds[dorm_bldg_cde]", "wly_ipeds[Dorm Bldg Code]");
        newExpr = newExpr.Replace("wly_ipeds[dorm_room_cde]", "wly_ipeds[Dorm Room Code]");
        newExpr = newExpr.Replace("wly_ipeds[add_date]", "wly_ipeds[Add Date]");
        newExpr = newExpr.Replace("wly_ipeds[tuition_cde]", "wly_ipeds[Tuition Code]");
        newExpr = newExpr.Replace("wly_ipeds[career_hrs_att]", "wly_ipeds[Career Hrs Att]");
        newExpr = newExpr.Replace("wly_ipeds[career_hrs_earned]", "wly_ipeds[Career Hrs Earned]");
        newExpr = newExpr.Replace("wly_ipeds[career_hrs_gpa]", "wly_ipeds[Career Hrs GPA]");
        newExpr = newExpr.Replace("wly_ipeds[career_qual_points]", "wly_ipeds[Career Qual Points]");
        newExpr = newExpr.Replace("wly_ipeds[career_gpa]", "wly_ipeds[Career GPA]");
        newExpr = newExpr.Replace("wly_ipeds[local_city]", "wly_ipeds[Local City]");
        newExpr = newExpr.Replace("wly_ipeds[local_zip]", "wly_ipeds[Local Zip]");

        // stud_term_sum_div table columns
        newExpr = newExpr.Replace("stud_term_sum_div[ID_NUM]", "stud_term_sum_div[ID Number]");
        newExpr = newExpr.Replace("stud_term_sum_div[DIV_CDE]", "stud_term_sum_div[Division Code]");
        newExpr = newExpr.Replace("stud_term_sum_div[YR_CDE]", "stud_term_sum_div[Year]");
        newExpr = newExpr.Replace("stud_term_sum_div[yr_cde]", "stud_term_sum_div[Year]");
        newExpr = newExpr.Replace("stud_term_sum_div[TRM_CDE]", "stud_term_sum_div[Term]");
        newExpr = newExpr.Replace("stud_term_sum_div[CLASS_CDE]", "stud_term_sum_div[Class Code]");
        newExpr = newExpr.Replace("stud_term_sum_div[HRS_ENROLLED]", "stud_term_sum_div[Hrs Enrolled]");
        newExpr = newExpr.Replace("stud_term_sum_div[CAREER_GPA]", "stud_term_sum_div[Career GPA]");
        newExpr = newExpr.Replace("stud_term_sum_div[MAJOR_1]", "stud_term_sum_div[Major 1]");
        newExpr = newExpr.Replace("stud_term_sum_div[MAJOR_2]", "stud_term_sum_div[Major 2]");
        newExpr = newExpr.Replace("stud_term_sum_div[MINOR_1]", "stud_term_sum_div[Minor 1]");

        // j1_degree_history table columns
        newExpr = newExpr.Replace("j1_degree_history[ID_NUM]", "j1_degree_history[ID Number]");
        newExpr = newExpr.Replace("j1_degree_history[DIV_CDE]", "j1_degree_history[Division Code]");
        newExpr = newExpr.Replace("j1_degree_history[DEGR_CDE]", "j1_degree_history[Degr Code]");
        newExpr = newExpr.Replace("j1_degree_history[DTE_DEGR_CONFERRED]", "j1_degree_history[Dte Degr Conferred]");
        newExpr = newExpr.Replace("j1_degree_history[ENTRY_DTE]", "j1_degree_history[Entry Dte]");
        newExpr = newExpr.Replace("j1_degree_history[WITHDRAWAL_DTE]", "j1_degree_history[Withdrawal Dte]");
        newExpr = newExpr.Replace("j1_degree_history[EXIT_DTE]", "j1_degree_history[Exit Dte]");
        newExpr = newExpr.Replace("j1_degree_history[REENTRY_DTE]", "j1_degree_history[Reentry Dte]");
        newExpr = newExpr.Replace("j1_degree_history[MAJOR_1]", "j1_degree_history[Major 1]");
        newExpr = newExpr.Replace("j1_degree_history[MAJOR_2]", "j1_degree_history[Major 2]");
        newExpr = newExpr.Replace("j1_degree_history[MINOR_1]", "j1_degree_history[Minor 1]");
        newExpr = newExpr.Replace("j1_degree_history[MINOR_2]", "j1_degree_history[Minor 2]");
        newExpr = newExpr.Replace("j1_degree_history[DEGR_HONORS_1]", "j1_degree_history[Degr Honors 1]");
        newExpr = newExpr.Replace("j1_degree_history[ACTIVE]", "j1_degree_history[Active]");
        newExpr = newExpr.Replace("j1_degree_history[CUR_DEGREE]", "j1_degree_history[Cur Degree]");
        newExpr = newExpr.Replace("j1_degree_history[NON_DEGREE_SEEKING]", "j1_degree_history[Non Degree Seeking]");
        newExpr = newExpr.Replace("j1_degree_history[EXPECT_GRAD_YR]", "j1_degree_history[Expect Grad Yr]");

        // Year_Definition table
        newExpr = newExpr.Replace("Year_Definition[yr_cde]", "Year_Definition[Year Code]");
        newExpr = newExpr.Replace("Year_Definition[YR_CDE]", "Year_Definition[Year Code]");

        // Sections table
        newExpr = newExpr.Replace("'Sections'[YR_CDE]", "'Sections'[Year]");
        newExpr = newExpr.Replace("'Sections'[TRM_CDE]", "'Sections'[Term]");
        newExpr = newExpr.Replace("'Sections'[CRS_CDE]", "'Sections'[Course Code]");
        newExpr = newExpr.Replace("'Sections'[CRS_CAPACITY]", "'Sections'[Course Capacity]");
        newExpr = newExpr.Replace("'Sections'[CRS_ENROLLMENT]", "'Sections'[Course Enrollment]");
        newExpr = newExpr.Replace("'Sections'[CRS_TITLE]", "'Sections'[Course Title]");
        newExpr = newExpr.Replace("'Sections'[SECTION_STS]", "'Sections'[Section Sts]");
        newExpr = newExpr.Replace("'Sections'[CREDIT_HRS]", "'Sections'[Credit Hrs]");
        newExpr = newExpr.Replace("'Sections'[MIN_ENROLLMENT]", "'Sections'[Min Enrollment]");
        newExpr = newExpr.Replace("'Sections'[CRS_CANCEL_FLG]", "'Sections'[Course Cancel Flg]");
        newExpr = newExpr.Replace("'Sections'[CRS_DISTANCE_LEARN]", "'Sections'[Course Distance Learn]");
        newExpr = newExpr.Replace("'Sections'[DISTANCE_EDUCATION]", "'Sections'[Distance Education]");
        newExpr = newExpr.Replace("'Sections'[CRS_ALLOW_WAITLIST]", "'Sections'[Course Allow Waitlist]");
        newExpr = newExpr.Replace("'Sections'[GRADES_ENTERED]", "'Sections'[Grades Entered]");

        // Fees table
        newExpr = newExpr.Replace("Fees[ID_NUM]", "Fees[ID Number]");
        newExpr = newExpr.Replace("Fees[FEES_AMT]", "Fees[Fees Amt]");
        newExpr = newExpr.Replace("Fees[FEE_CDE]", "Fees[Fee Code]");
        newExpr = newExpr.Replace("Fees[CHG_TYPE]", "Fees[Chg Type]");
        newExpr = newExpr.Replace("Fees[SUBSID_CDE]", "Fees[Subsid Code]");

        // j1_faculty_load_table
        newExpr = newExpr.Replace("j1_faculty_load_table[YR_CDE]", "j1_faculty_load_table[Year]");
        newExpr = newExpr.Replace("j1_faculty_load_table[TRM_CDE]", "j1_faculty_load_table[Term]");
        newExpr = newExpr.Replace("j1_faculty_load_table[CRS_CDE]", "j1_faculty_load_table[Course Code]");
        newExpr = newExpr.Replace("j1_faculty_load_table[INSTRCTR_ID_NUM]", "j1_faculty_load_table[Instructr ID Number]");
        newExpr = newExpr.Replace("j1_faculty_load_table[LOAD_PERCENTAGE]", "j1_faculty_load_table[Load Percentage]");
        newExpr = newExpr.Replace("j1_faculty_load_table[LEAD_INSTRCTR_FLG]", "j1_faculty_load_table[Lead Instrctr Flg]");
        newExpr = newExpr.Replace("j1_faculty_load_table[WEB_GRADING]", "j1_faculty_load_table[Web Grading]");
        newExpr = newExpr.Replace("j1_faculty_load_table[INSTRUCTOR_APPROVED]", "j1_faculty_load_table[Instructor Approved]");
        newExpr = newExpr.Replace("j1_faculty_load_table[LOAD_PERCENTAGE_LAB]", "j1_faculty_load_table[Load Percentage Lab]");
        newExpr = newExpr.Replace("j1_faculty_load_table[AUTHORIZE_CAPACITY]", "j1_faculty_load_table[Authorize Capacity]");
        newExpr = newExpr.Replace("j1_faculty_load_table[AUTHORIZE_SCHED_CONFLICT]", "j1_faculty_load_table[Authorize Sched Conflict]");
        newExpr = newExpr.Replace("j1_faculty_load_table[SHOW_ON_WEB]", "j1_faculty_load_table[Show On Web]");

        // stud_crs_history
        newExpr = newExpr.Replace("stud_crs_history[ID_NUM]", "stud_crs_history[ID Number]");
        newExpr = newExpr.Replace("stud_crs_history[YR_CDE]", "stud_crs_history[Year]");
        newExpr = newExpr.Replace("stud_crs_history[TRM_CDE]", "stud_crs_history[Term]");
        newExpr = newExpr.Replace("stud_crs_history[CRS_CDE]", "stud_crs_history[Course Code]");
        newExpr = newExpr.Replace("stud_crs_history[CREDIT_HRS]", "stud_crs_history[Credit Hrs]");
        newExpr = newExpr.Replace("stud_crs_history[HRS_ATTEMPTED]", "stud_crs_history[Hrs Attempted]");
        newExpr = newExpr.Replace("stud_crs_history[HRS_EARNED]", "stud_crs_history[Hrs Earned]");

        // LineItemAmount
        newExpr = newExpr.Replace("LineItemAmount[OriginalAmount]", "LineItemAmount[Original Amount]");
        newExpr = newExpr.Replace("LineItemAmount[CurrentAmount]", "LineItemAmount[Current Amount]");
        newExpr = newExpr.Replace("LineItemAmount[InitialAmount]", "LineItemAmount[Initial Amount]");
        newExpr = newExpr.Replace("LineItemAmount[IsInitialLocked]", "LineItemAmount[Is Initial Locked]");
        newExpr = newExpr.Replace("LineItemAmount[IsApprovedLocked]", "LineItemAmount[Is Approved Locked]");
        newExpr = newExpr.Replace("LineItemAmount[LineItemID]", "LineItemAmount[Line Item ID]");

        // Catalog
        newExpr = newExpr.Replace("Catalog[CRS_CDE]", "Catalog[Course Code]");

        if (oldExpr != newExpr)
        {
            measure.Expression = newExpr;
            updateCount++;
        }
    }
}

Info("DAX Update Complete! Updated " + updateCount.ToString() + " measures");
