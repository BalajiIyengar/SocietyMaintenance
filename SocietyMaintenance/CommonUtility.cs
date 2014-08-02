using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using System.IO;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Net.Mail;
using System.Net;

namespace SocietyMaintenance
{
    class CommonUtility
    {
        static SMEntities db;

        public static SMEntities getConnection()
        {
            if (db == null)
                db = new SMEntities();

            return db;
        }

        public static List<long> getFlatNumbers()
        {
            getConnection();
            List<long> flatNumbers = db.UserDetails.Select(x => x.FlatNumber).ToList();
           return flatNumbers;
        }

        internal static void showErrorPopUp(string message)
        {
            MessageBox.Show(message,"Error");
        }

        internal static void showSuccessPopUp(string message)
        {
            MessageBox.Show(message, "Success");
        }

        internal static void populateMonths(ComboBox comboBox)
        {
            List<string> months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames.ToList();
            comboBox.DataSource = months;

            comboBox.SelectedIndex = DateTime.Now.Month - 1;
        }

        internal static void populateYears(ComboBox comboBox)
        {
            comboBox.DataSource = Enumerable.Range(DateTime.Today.Year - 5, 25).ToList();
            comboBox.SelectedItem = DateTime.Now.Year;
        }

        static string getFilePath()
        {
            string path = "";
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = " Excel Sheet (.xlsx) | *.xlsx";
            file.RestoreDirectory = true;

            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = file.FileName;
            }
            return path;
        }

        public static void exportUserBills(UserDetail user, List<UserBill> bills, long selectedFlatId,ProgressBar progressBar)
        {
            String path = getFilePath();

            if (path.Length > 0)
            {

                if (path.Contains(".xlsx"))
                    path = path.Replace(".xlsx", ".xls");

                int i = 1;
                
                progressBar.Value = i * 10;
                ++i;

                Microsoft.Office.Interop.Excel.Application app = null;
                app = new Microsoft.Office.Interop.Excel.Application();
                app.Visible = false;

                Microsoft.Office.Interop.Excel.Application xlApp;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);


                xlWorkBook.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                progressBar.Value = i * 10;
                ++i;


                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.DisplayAlerts = false;
                Workbooks excelWorkbooks = excelApp.Workbooks;
                Workbook excelWorkbook = null;
                Sheets excelWorksheets = null;
                Worksheet excelWorksheet = null;
                Range columnRangeInExcel;
                Range usedRange;
                Range usedRangeColumns;
                PageSetup pageSetup;

                bool exists = true;
                try
                {
                    excelWorkbook = excelWorkbooks.Open(path, null, false);
                }
                catch (Exception ex)
                {
                    excelWorkbook = excelWorkbooks.Add();
                    exists = false;
                }

                progressBar.Value = i * 10;
                ++i;
                excelWorksheets = excelWorkbook.Sheets;

                String sheetName = path.Substring(path.LastIndexOf("\\") + 1, path.Length - path.LastIndexOf("\\") - 1);

                sheetName = sheetName.Substring(0, sheetName.Length - sheetName.LastIndexOf(".") + 1);

                excelWorksheet = excelWorksheets.get_Item("Sheet1");

                //Starting column index
                usedRange = excelWorksheet.UsedRange;
                usedRangeColumns = usedRange.Columns;
                int startColumnIndex = usedRangeColumns.Count == 1 ? 1 : usedRangeColumns.Count + 2;
                int endColumnIndex = startColumnIndex + 3;

                progressBar.Value = i * 10;
                ++i;
                //Customer Details at the beginning.
                excelWorksheet.Cells[1, startColumnIndex] = user.OwnerName.ToUpper() + " " + ", " + (user.OwnerDetails.Trim().Length == 0 ? " " : (user.OwnerDetails));

                //Merge 3 columns in the 1st row.
                columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[1, startColumnIndex], (Range)excelWorksheet.Cells[1, endColumnIndex]);
                columnRangeInExcel.MergeCells = true;
                columnRangeInExcel.Font.Bold = true;
                columnRangeInExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter; //Align Center
                columnRangeInExcel.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThick);

                //Green background for 1st row
                columnRangeInExcel.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.GreenYellow);

                //Header for the bill
                int columnNumberInExcel = startColumnIndex;
                excelWorksheet.Cells[2, columnNumberInExcel++] = "Bill Date";
                excelWorksheet.Cells[2, columnNumberInExcel++] = "Amount";
                excelWorksheet.Cells[2, columnNumberInExcel++] = "Bill For Month";
                excelWorksheet.Cells[2, columnNumberInExcel++] = "Bill For Year";

                progressBar.Value = i * 10;
                ++i;

                //Alignment and border
                columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[2, startColumnIndex], (Range)excelWorksheet.Cells[2, endColumnIndex]);
                columnRangeInExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter; //Align center
                columnRangeInExcel.Font.Bold = true;
                columnRangeInExcel.Borders.LineStyle = XlLineStyle.xlContinuous;
                columnRangeInExcel.Borders.Weight = XlBorderWeight.xlMedium;

                progressBar.Value = i * 10;
                ++i;

                //Entire bill for the month            
                int rowNumberInExcel = 3;
                for (int dayNumber = 0; dayNumber < bills.Count; dayNumber++) //iterate over the rows in the List.
                {
                    columnNumberInExcel = startColumnIndex;

                    UserBill dailyBill = bills.ElementAt(dayNumber);

                    excelWorksheet.Cells[rowNumberInExcel, columnNumberInExcel++] = dailyBill.BillDate.Date; //Lunch
                    excelWorksheet.Cells[rowNumberInExcel, columnNumberInExcel++] = dailyBill.Amount; //Lunch
                    excelWorksheet.Cells[rowNumberInExcel, columnNumberInExcel++] = dailyBill.BillForMonth; //Dinner
                    excelWorksheet.Cells[rowNumberInExcel, columnNumberInExcel++] = dailyBill.BillForYear; //Comments
                    //  excelWorksheet.Cells[rowNumberInExcel, columnNumberInExcel++] = dailyBill.; //DailyPayments

                    //Alignment and border
                    columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[rowNumberInExcel, startColumnIndex], (Range)excelWorksheet.Cells[rowNumberInExcel, endColumnIndex]);
                    columnRangeInExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter; //Align center  
                    columnRangeInExcel.Borders.LineStyle = XlLineStyle.xlContinuous;
                    columnRangeInExcel.Borders.Weight = XlBorderWeight.xlThin;
                    rowNumberInExcel++;
                }
                progressBar.Value = i * 10;
                ++i;

                //Below all bills, we display TOTAL(Lunch/Dinner).
                excelWorksheet.Cells[rowNumberInExcel, startColumnIndex] = "Total: ";
                excelWorksheet.Cells[rowNumberInExcel, startColumnIndex + 1] = db.UserBills.Where(x => x.FlatNumber == selectedFlatId).Sum(x => x.Amount).ToString(); //Lunch total

                //excelWorksheet.Cells[rowNumberInExcel, startColumnIndex + 2] = db.MonthlyBills.Where(x => x.CustomerId == customerId && x.DateTaken.Month == month && x.DateTaken.Year == year).Sum(x => x.DinnerAmount).ToString(); //Dinner total
                //excelWorksheet.Cells[rowNumberInExcel, endColumnIndex] = db.MonthlyBills.Where(x => x.CustomerId == customerId && x.DateTaken.Month == month && x.DateTaken.Year == year).Sum(x => x.DailyPayment).ToString(); //Daily payments total
                columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[rowNumberInExcel, startColumnIndex], (Range)excelWorksheet.Cells[rowNumberInExcel, endColumnIndex]);
                columnRangeInExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter; //Align Center
                columnRangeInExcel.Font.Bold = true;
                columnRangeInExcel.Borders.LineStyle = XlLineStyle.xlContinuous;
                columnRangeInExcel.Borders.Weight = XlBorderWeight.xlMedium;
                columnRangeInExcel.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                rowNumberInExcel++;

                progressBar.Value = i * 10;
                ++i;

                columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[rowNumberInExcel, startColumnIndex], (Range)excelWorksheet.Cells[rowNumberInExcel, endColumnIndex]);
                columnRangeInExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter; //Align Center            
                columnRangeInExcel.Borders.LineStyle = XlLineStyle.xlContinuous;
                columnRangeInExcel.Borders.Weight = XlBorderWeight.xlThin;

                rowNumberInExcel++;

                columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[rowNumberInExcel, startColumnIndex], (Range)excelWorksheet.Cells[rowNumberInExcel, endColumnIndex]);
                columnRangeInExcel.MergeCells = true;
                columnRangeInExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter; //Align Center  
                columnRangeInExcel.Font.Bold = true;
                columnRangeInExcel.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThick);
                columnRangeInExcel.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

                rowNumberInExcel++;

                progressBar.Value = i * 10;
                ++i;

                ////Formatting
                columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[1, startColumnIndex], (Range)excelWorksheet.Cells[rowNumberInExcel, endColumnIndex]);
                columnRangeInExcel.EntireColumn.AutoFit();
                columnRangeInExcel.EntireColumn.Font.Name = "Arial";
                columnRangeInExcel.EntireColumn.Font.Size = 9;

                //Set margin = 0 and landscape mode.
                pageSetup = excelWorksheet.PageSetup;
                pageSetup.LeftMargin = 0;
                pageSetup.RightMargin = 0;
                pageSetup.TopMargin = 0;
                pageSetup.BottomMargin = 0;
                pageSetup.HeaderMargin = 0;
                pageSetup.FooterMargin = 0;
                pageSetup.Orientation = XlPageOrientation.xlLandscape;

                progressBar.Value = i * 10;
                

                //Save Excel file.
                if (exists)
                    excelWorkbook.Save();
                else
                    excelWorkbook.SaveAs(path);

                progressBar.Value = i * 10;
                
                excelWorkbook.Close();
                excelApp.Quit();

                CommonUtility.showSuccessPopUp("Successfully Exported the Bills");



                //Clean-up tasks.
                Marshal.ReleaseComObject(pageSetup);
                Marshal.ReleaseComObject(usedRangeColumns);
                Marshal.ReleaseComObject(usedRange);
                Marshal.ReleaseComObject(columnRangeInExcel);
                Marshal.ReleaseComObject(excelWorksheet);
                Marshal.ReleaseComObject(excelWorksheets);
                Marshal.ReleaseComObject(excelWorkbook);
                Marshal.ReleaseComObject(excelWorkbooks);
                Marshal.ReleaseComObject(excelApp);
                pageSetup = null;
                usedRangeColumns = null;
                usedRange = null;
                columnRangeInExcel = null;
                excelWorksheet = null;
                excelWorksheets = null;
                excelWorkbook = null;
                excelWorkbooks = null;
                excelApp = null;

                cleanUp();
            }
        }

        private static void cleanUp()
        {

            GC.Collect();
            GC.WaitForPendingFinalizers();

            //throw new NotImplementedException();
        }

        public static void exportUserPayments( UserDetail user, List<UserPayment> payments, long selectedFlatId, ProgressBar progressBar)
        {
            String path = getFilePath();

            if (path.Length > 0)
            {
                if (path.Contains(".xlsx"))
                    path = path.Replace(".xlsx", ".xls");

                int i = 1;
                progressBar.Value = i * 10;
                ++i;

                Microsoft.Office.Interop.Excel.Application app = null;
                app = new Microsoft.Office.Interop.Excel.Application();
                app.Visible = false;

                Microsoft.Office.Interop.Excel.Application xlApp;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);


                xlWorkBook.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkBook);
                releaseObject(xlApp);


                progressBar.Value = i * 10;
                ++i;

                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.DisplayAlerts = false;
                Workbooks excelWorkbooks = excelApp.Workbooks;
                Workbook excelWorkbook = null;
                Sheets excelWorksheets = null;
                Worksheet excelWorksheet = null;
                Range columnRangeInExcel;
                Range usedRange;
                Range usedRangeColumns;
                PageSetup pageSetup;

                progressBar.Value = i * 10;
                ++i;

                bool exists = true;
                try
                {
                    excelWorkbook = excelWorkbooks.Open(path, null, false);
                }
                catch (Exception ex)
                {
                    excelWorkbook = excelWorkbooks.Add();
                    exists = false;
                }

                progressBar.Value = i * 10;
                ++i;

                excelWorksheets = excelWorkbook.Sheets;

                excelWorksheet = excelWorksheets.get_Item(1);

                progressBar.Value = i * 10;
                ++i;

                //Starting column index
                usedRange = excelWorksheet.UsedRange;
                usedRangeColumns = usedRange.Columns;
                int startColumnIndex = usedRangeColumns.Count == 1 ? 1 : usedRangeColumns.Count + 2;
                int endColumnIndex = startColumnIndex + 3;

                //Customer Details at the beginning.
                excelWorksheet.Cells[1, startColumnIndex] = user.OwnerName.ToUpper() + " " + ", " + (user.OwnerDetails.Trim().Length == 0 ? " " : (user.OwnerDetails));

                //Merge 3 columns in the 1st row.
                columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[1, startColumnIndex], (Range)excelWorksheet.Cells[1, endColumnIndex]);
                columnRangeInExcel.MergeCells = true;
                columnRangeInExcel.Font.Bold = true;
                columnRangeInExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter; //Align Center
                columnRangeInExcel.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThick);

                //Green background for 1st row
                columnRangeInExcel.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.GreenYellow);

                //Header for the bill
                int columnNumberInExcel = startColumnIndex;
                excelWorksheet.Cells[2, columnNumberInExcel++] = "Paid Date";
                excelWorksheet.Cells[2, columnNumberInExcel++] = "Amount";
                excelWorksheet.Cells[2, columnNumberInExcel++] = "Paid For Month";
                excelWorksheet.Cells[2, columnNumberInExcel++] = "Paid For Year";

                progressBar.Value = i * 10;
                ++i;

                //Alignment and border
                columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[2, startColumnIndex], (Range)excelWorksheet.Cells[2, endColumnIndex]);
                columnRangeInExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter; //Align center
                columnRangeInExcel.Font.Bold = true;
                columnRangeInExcel.Borders.LineStyle = XlLineStyle.xlContinuous;
                columnRangeInExcel.Borders.Weight = XlBorderWeight.xlMedium;

                //Entire bill for the month            
                int rowNumberInExcel = 3;

                progressBar.Value = i * 10;
                ++i;

                for (int dayNumber = 0; dayNumber < payments.Count; dayNumber++) //iterate over the rows in the List.
                {
                    columnNumberInExcel = startColumnIndex;

                    UserPayment dailyBill = payments.ElementAt(dayNumber);

                    excelWorksheet.Cells[rowNumberInExcel, columnNumberInExcel++] = dailyBill.PaidDate.Date; //Paid Date
                    excelWorksheet.Cells[rowNumberInExcel, columnNumberInExcel++] = dailyBill.AmountPaid; //Amount Paid

                    string paidMonth = "";
                    string paidYear = "";

                    int last = dailyBill.PaidForTheMonthOf.LastIndexOf(",") + 1;
                    int length = dailyBill.PaidForTheMonthOf.Length - 1;

                    if (dailyBill.PaidForTheMonthOf.Contains(","))
                    {
                        paidMonth = dailyBill.PaidForTheMonthOf.Substring(0, dailyBill.PaidForTheMonthOf.Trim().LastIndexOf(","));
                        paidYear = dailyBill.PaidForTheMonthOf.Substring(last, length - last + 1);
                    }

                    excelWorksheet.Cells[rowNumberInExcel, columnNumberInExcel++] = paidMonth; //Month


                    excelWorksheet.Cells[rowNumberInExcel, columnNumberInExcel++] = paidYear;
                    //  excelWorksheet.Cells[rowNumberInExcel, columnNumberInExcel++] = dailyBill.; //DailyPayments

                    //Alignment and border
                    columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[rowNumberInExcel, startColumnIndex], (Range)excelWorksheet.Cells[rowNumberInExcel, endColumnIndex]);
                    columnRangeInExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter; //Align center  
                    columnRangeInExcel.Borders.LineStyle = XlLineStyle.xlContinuous;
                    columnRangeInExcel.Borders.Weight = XlBorderWeight.xlThin;
                    rowNumberInExcel++;
                }

                progressBar.Value = i * 10;
                ++i;

                //Below all bills, we display TOTAL(Lunch/Dinner).
                excelWorksheet.Cells[rowNumberInExcel, startColumnIndex] = "Total: ";
                excelWorksheet.Cells[rowNumberInExcel, startColumnIndex + 1] = db.UserPayments.Where(x => x.FlatNumber == selectedFlatId).Sum(x => x.AmountPaid).ToString(); //Lunch total

                //excelWorksheet.Cells[rowNumberInExcel, startColumnIndex + 2] = db.MonthlyBills.Where(x => x.CustomerId == customerId && x.DateTaken.Month == month && x.DateTaken.Year == year).Sum(x => x.DinnerAmount).ToString(); //Dinner total
                //excelWorksheet.Cells[rowNumberInExcel, endColumnIndex] = db.MonthlyBills.Where(x => x.CustomerId == customerId && x.DateTaken.Month == month && x.DateTaken.Year == year).Sum(x => x.DailyPayment).ToString(); //Daily payments total
                columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[rowNumberInExcel, startColumnIndex], (Range)excelWorksheet.Cells[rowNumberInExcel, endColumnIndex]);
                columnRangeInExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter; //Align Center
                columnRangeInExcel.Font.Bold = true;
                columnRangeInExcel.Borders.LineStyle = XlLineStyle.xlContinuous;
                columnRangeInExcel.Borders.Weight = XlBorderWeight.xlMedium;
                columnRangeInExcel.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                rowNumberInExcel++;

                columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[rowNumberInExcel, startColumnIndex], (Range)excelWorksheet.Cells[rowNumberInExcel, endColumnIndex]);
                columnRangeInExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter; //Align Center            
                columnRangeInExcel.Borders.LineStyle = XlLineStyle.xlContinuous;
                columnRangeInExcel.Borders.Weight = XlBorderWeight.xlThin;

                rowNumberInExcel++;

                columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[rowNumberInExcel, startColumnIndex], (Range)excelWorksheet.Cells[rowNumberInExcel, endColumnIndex]);
                columnRangeInExcel.MergeCells = true;
                columnRangeInExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter; //Align Center  
                columnRangeInExcel.Font.Bold = true;
                columnRangeInExcel.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThick);
                columnRangeInExcel.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

                rowNumberInExcel++;


                ////Formatting
                columnRangeInExcel = excelWorksheet.get_Range((Range)excelWorksheet.Cells[1, startColumnIndex], (Range)excelWorksheet.Cells[rowNumberInExcel, endColumnIndex]);
                columnRangeInExcel.EntireColumn.AutoFit();
                columnRangeInExcel.EntireColumn.Font.Name = "Arial";
                columnRangeInExcel.EntireColumn.Font.Size = 9;

                progressBar.Value = i * 10;
                ++i;

                //Set margin = 0 and landscape mode.
                pageSetup = excelWorksheet.PageSetup;
                pageSetup.LeftMargin = 0;
                pageSetup.RightMargin = 0;
                pageSetup.TopMargin = 0;
                pageSetup.BottomMargin = 0;
                pageSetup.HeaderMargin = 0;
                pageSetup.FooterMargin = 0;
                pageSetup.Orientation = XlPageOrientation.xlLandscape;

                //Save Excel file.
                if (exists)
                    excelWorkbook.Save();
                else
                    excelWorkbook.SaveAs(path);

                excelWorkbook.Close();
                excelApp.Quit();

                progressBar.Value = i * 10;

                i = 0;


                //Clean-up tasks.
                Marshal.ReleaseComObject(pageSetup);
                Marshal.ReleaseComObject(usedRangeColumns);
                Marshal.ReleaseComObject(usedRange);
                Marshal.ReleaseComObject(columnRangeInExcel);
                Marshal.ReleaseComObject(excelWorksheet);
                Marshal.ReleaseComObject(excelWorksheets);
                Marshal.ReleaseComObject(excelWorkbook);
                Marshal.ReleaseComObject(excelWorkbooks);
                Marshal.ReleaseComObject(excelApp);
                pageSetup = null;
                usedRangeColumns = null;
                usedRange = null;
                columnRangeInExcel = null;
                excelWorksheet = null;
                excelWorksheets = null;
                excelWorkbook = null;
                excelWorkbooks = null;
                excelApp = null;

                cleanUp();

                CommonUtility.showSuccessPopUp("Successfully Exported the Bills");


            }
        
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public static bool writeToFile(String ToSaveFileTo,byte[] fileData)
        {
            bool success = false;
            try
            {
                using (System.IO.FileStream fs = new System.IO.FileStream(ToSaveFileTo, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
                {
                    using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs))
                    {
                        bw.Write(fileData);
                        bw.Close();
                    }
                }
                success = true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
            return success;
        }

        internal static string getFileExtension(String fileName)
        {
            return fileName.Substring(fileName.LastIndexOf(".") + 1, fileName.Length - fileName.LastIndexOf(".") - 1);
        }

        internal static bool uploadFile(String filePath, long flatId, long tenantId, String fileName)
        {
            bool success = false;
            try
            {
                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(stream);
                byte[] file = reader.ReadBytes((int)stream.Length);

                UserDocument documents = new UserDocument();
                documents.DocumentData = file;
                documents.DocumentName = fileName;
                documents.FlatNumber = flatId;
                documents.TenantId = tenantId;

                db.UserDocuments.Add(documents);
                reader.Close();
                stream.Close();

                db.SaveChanges();

                success = true;
            }
            catch (DbUpdateException ex)
            {
                CommonUtility.showErrorPopUp("This File Exists with the same user");
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }

            return success;
        }
 
        public static string getFilePathWithoutExtension()
        {
            string path = "";
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = " All files (*.*)|*.* ";
            file.RestoreDirectory = true;

            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = file.FileName;
            }
            return path;
        }

        public static void setDropDownSearchable(ComboBox comboBox)
        {
            comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        
        }

        internal static Image getImageFromByteArray(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);

            return returnImage;
        }

        internal static byte[] getByteArrayFromImage(Image employeeImage)
        {
            MemoryStream ms = new MemoryStream();
            employeeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        internal static bool sendMail(MailAddress fromEmailId,MailAddress toEmailId,string subject,string body,List<string> attachemnts,ProgressBar progressBar)
        {
            string fromPassword = "pinksyde";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmailId.Address, fromPassword)
            };
            progressBar.Value = 40;

            MailMessage mail = new MailMessage(fromEmailId,toEmailId);
            mail.Body = body;
            mail.Subject = subject;

            progressBar.Value = 60;
            foreach (string attachment in attachemnts)
                mail.Attachments.Add(new System.Net.Mail.Attachment(attachment));


            progressBar.Value = 80;

            smtp.Send(mail);
            progressBar.Value = 100;
            return true;
        }

        internal static List<string> openFileDialog()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Files|*.*";
            fileDialog.Multiselect = true;

            DialogResult result = fileDialog.ShowDialog();

            List<string> attachments = new List<string>();

            if (result == DialogResult.OK)
            {
              attachments = new List<string>( fileDialog.FileNames);
            }

            return attachments;
        }
    }
}
