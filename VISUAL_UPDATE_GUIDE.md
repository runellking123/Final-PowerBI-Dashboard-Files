# Guide: Update Power BI Visuals After CSV Column Rename

## Overview
Your CSV files now use Title Case column names (ID Number, Year, Term, etc.), but your Power BI model still references the old snake_case names (id_num, yr_cde, trm_cde). This guide will update your Power BI model to match the new CSV names **without breaking any visuals**.

---

## ⚠️ CRITICAL: Do This BEFORE Refreshing Data

**You MUST run the Update_Column_References.csx script BEFORE you refresh your Power BI data.** If you refresh first, all your visuals will break because the column names won't match.

---

## Step-by-Step Instructions

### Step 1: Backup Your Power BI File

1. Navigate to your Power BI file location
2. **Copy** your `.pbix` file and create a backup
3. Name it something like `Dashboard - BACKUP.pbix`

---

### Step 2: Open in Tabular Editor 2

1. **Close Power BI Desktop** (if open)
2. Launch **Tabular Editor 2**
3. Go to: **File → Open → From File**
4. Select your Power BI `.pbix` file
5. Click **Open**

---

### Step 3: Run the Column Update Script

1. In Tabular Editor, click **Advanced Scripting** (or press `Ctrl + Shift + A`)
2. Open the file: `Update_Column_References.csx` (in this repo folder)
3. **Copy ALL** the contents
4. **Paste** into the Advanced Scripting window in Tabular Editor
5. Click the **Run** button (green play icon or press `F5`)

**What happens:**
- The script will automatically rename all columns in your model
- You'll see messages showing: `Renaming: wly_ipeds[id_num] -> [ID Number]`
- At the end: `Column update complete! Updated X columns`
- **All your DAX formulas will automatically update**
- **All your visual references will automatically update**

---

### Step 4: Save the Changes

1. In Tabular Editor: **File → Save**
2. Wait for the save to complete
3. **Close Tabular Editor**

---

### Step 5: Update Data Source Path (If Needed)

Now open your `.pbix` file in Power BI Desktop:

1. Open Power BI Desktop
2. Open your `.pbix` file
3. Go to: **Home → Transform Data → Data Source Settings**
4. Update the file path to point to your updated CSV files in:
   - `Final-PowerBI-Dashboard-Files/Main Tables/`

---

### Step 6: Refresh Your Data

1. In Power BI Desktop, click **Home → Refresh**
2. Power BI will reload data from the CSV files with new column names
3. **Your visuals will stay intact** because the model now expects the new names!

---

### Step 7: Verify Everything Works

Check your dashboard:
- ✅ All visuals should display correctly
- ✅ All slicers should work
- ✅ All measures should calculate correctly
- ✅ No errors in the formula bar

---

## What the Script Does

The `Update_Column_References.csx` script:

1. **Renames columns** in your Power BI model to match CSV files:
   - `id_num` → `ID Number`
   - `yr_cde` → `Year`
   - `trm_cde` → `Term`
   - `div_cde` → `Division Code`
   - And 70+ more...

2. **Automatically updates** all references:
   - DAX measures
   - Calculated columns
   - Visual field wells
   - Filters and slicers
   - Relationships

3. **Preserves everything**:
   - All your visuals
   - All your formatting
   - All your layouts
   - All your measures

---

## Column Mappings

Here are all the column renames that will happen:

### Common Across Tables:
| Old Name | New Name |
|----------|----------|
| `id_num`, `ID_NUM` | ID Number |
| `yr_cde`, `YR_CDE` | Year |
| `trm_cde`, `TRM_CDE` | Term |
| `div_cde`, `DIV_CDE` | Division Code |
| `class_cde`, `CLASS_CDE` | Class Code |
| `crs_cde`, `CRS_CDE` | Course Code |

### Personal Info:
| Old Name | New Name |
|----------|----------|
| `first_name` | First Name |
| `last_name` | Last Name |
| `mid_name` | Mid Name |
| `ssn` | Ssn |

### Academic Fields:
| Old Name | New Name |
|----------|----------|
| `cum_gpa` | Cum GPA |
| `career_gpa`, `CAREER_GPA` | Career GPA |
| `hrs_enrld` | Hrs Enrld |
| `HRS_ENROLLED` | Hrs Enrolled |
| `HRS_ATTEMPTED` | Hrs Attempted |
| `HRS_EARNED` | Hrs Earned |

### And many more... (70+ total mappings)

---

## Troubleshooting

### Issue: "Column not found" error after refresh
**Solution:** You probably refreshed before running the script. Restore your backup and follow the steps in order.

### Issue: Visuals show "Field not found"
**Solution:** The script wasn't run correctly. Restore backup and run the script again, making sure to copy ALL contents.

### Issue: Some columns didn't update
**Solution:** Check the Messages panel in Tabular Editor to see which columns were updated. You may need to manually rename columns that weren't in the mapping.

---

## Important Notes

- ⚠️ **Order matters**: Script FIRST, refresh SECOND
- ✅ **Backup first**: Always have a backup before making changes
- ✅ **Test first**: Test on the backup before updating your main file
- ✅ **One-time operation**: You only need to run this script once

---

## After Completion

Once you've successfully updated and refreshed:

1. ✅ Your Power BI model uses Title Case column names
2. ✅ Your CSV files use Title Case column names
3. ✅ Everything matches and works perfectly
4. ✅ Your visuals are preserved
5. ✅ Future refreshes will work automatically

---

**Created:** 2025-11-17
**Script Location:** `Final-PowerBI-Dashboard-Files/Update_Column_References.csx`
**CSV Files Location:** `Final-PowerBI-Dashboard-Files/Main Tables/`
