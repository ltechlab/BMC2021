using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMC2021
{
    public partial class Import : Form
    {
        POSDBEntities2 db = new POSDBEntities2();
        DataTable dtNew = new DataTable();

        public Import()
        {
            InitializeComponent();
            
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
           

                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.ShowDialog();
                    int ImportedRecord = 0, inValidItem = 0;
                    string SourceURl = "";

                    if (dialog.FileName != "")
                    {
                        if (dialog.FileName.EndsWith(".csv"))
                        {

                            dtNew.Clear();
                            dtNew = GetDataTabletFromCSVFile(dialog.FileName);

                            if (Convert.ToString(dtNew.Columns[0]).ToLower() != "id")
                            {
                                MessageBox.Show("Please follow the proper column order in your CSV file.");
                                btn_save.Enabled = false;
                                return;
                            }

                            txtFile.Text = dialog.SafeFileName;
                            SourceURl = dialog.FileName;
                            if (dtNew.Rows != null && dtNew.Rows.ToString() != String.Empty)
                            {
                                dgItems.DataSource = dtNew;
                            }
                            foreach (DataGridViewRow row in dgItems.Rows)
                            {
                                if (Convert.ToString(row.Cells["deliverydate"].Value) == "" || row.Cells["deliverydate"].Value == null
                                    || Convert.ToString(row.Cells["supplier"].Value) == "" || row.Cells["supplier"].Value == null
                                    || Convert.ToString(row.Cells["itembrand"].Value) == "" || row.Cells["itembrand"].Value == null
                                    || Convert.ToString(row.Cells["itemname"].Value) == "" || row.Cells["itemname"].Value == null
                                    || Convert.ToString(row.Cells["purchaseprice"].Value) == "" || row.Cells["purchaseprice"].Value == null
                                    || Convert.ToString(row.Cells["barcode"].Value) == "" || row.Cells["barcode"].Value == null
                                    || Convert.ToString(row.Cells["itemdescription"].Value) == "" || row.Cells["itemdescription"].Value == null
                                    || Convert.ToString(row.Cells["condition"].Value) == "" || row.Cells["condition"].Value == null
                                    || Convert.ToString(row.Cells["saleprice"].Value) == "" || row.Cells["saleprice"].Value == null
                                     || Convert.ToString(row.Cells["loggedby"].Value) == "" || row.Cells["loggedby"].Value == null)
                                {
                                    // row.DefaultCellStyle.BackColor = Color.Red;
                                    inValidItem += 1;
                                }
                                else
                                {
                                    ImportedRecord += 1;
                                }
                            }
                            if (dgItems.Rows.Count == 0)
                            {
                                btn_save.Enabled = false;
                                MessageBox.Show("No data in file selected.", "BMC MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid CSV file. ", "BMC MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                // MessageBox.Show("Exception " + ex);
                MessageBox.Show("Please follow the correct file and format when importing data.", "BMC MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }


        public static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {

                if (csv_file_path.EndsWith(".csv"))
                {
                    using (Microsoft.VisualBasic.FileIO.TextFieldParser csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csv_file_path))
                    {
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        csvReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                        csvReader.SetDelimiters(new string[] { ",", "\t" });


                        //read column
                        string[] colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }
                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }
                            csvData.Rows.Add(fieldData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting table from CSV. Make sure you don't have invalid elements in your file.");
            }
            return csvData;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Insert rows to database?", "CONFIRM INSERT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgItems.Rows.Count == 0)
                {
                    MessageBox.Show("Please loead a valid CSV file first!");

                }
                else
                {

                    SaveItem();
                    dtNew.Clear();
                }
            
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void SaveItem()
        {
            try
            {
                DataTable dtItem = (DataTable)(dgItems.DataSource);
                string deliverydate1, supplier1, itembrand1, itemname1, barcode1, itemdescription1, condition1, loggedby1;
                Double purchaseprice1, salesprice2;
             
                foreach (DataRow dr in dtItem.Rows)
                {
                    if (dr["deliverydate"] != null && dr["supplier"] != null && dr["itembrand"] != null && dr["itemname"] != null && dr["purchaseprice"] != null && dr["barcode"] != null && dr["itemdescription"] != null && dr["condition"] != null && dr["saleprice"] != null && dr["loggedby"] != null)      
                    {
                        deliverydate1 = Convert.ToString(dr["deliverydate"]);
                        supplier1 = Convert.ToString(dr["supplier"]);
                        itembrand1 = Convert.ToString(dr["itembrand"]);
                        itemname1 = Convert.ToString(dr["itemname"]);
                        purchaseprice1 = Convert.ToDouble(dr["purchaseprice"]);
                        barcode1 = Convert.ToString(dr["barcode"]);
                        itemdescription1 = Convert.ToString(dr["itemdescription"]);
                        condition1 = Convert.ToString(dr["condition"]);
                        salesprice2 = Convert.ToDouble(dr["saleprice"]);
                        loggedby1 = Convert.ToString(dr["loggedby"]);


                        int condition2 = int.Parse(condition1);



                            try
                            {

                                Inv_Peritem peritem = new Inv_Peritem()
                                {
                                    deliverydate = deliverydate1,
                                    supplier = supplier1,
                                    itembrand = itembrand1,
                                    itemdescription = itemdescription1,
                                    purchaseprice = purchaseprice1,
                                    barcode = barcode1,
                                    itemname = itemname1,
                                    condition = condition2,
                                    saleprice = salesprice2,
                                    loggedby = loggedby1,
                                };

                                db.Inv_Peritem.Add(peritem);

                            }

                            catch (Exception ee)
                            {
                                Console.WriteLine(ee);
                                // Provide for exceptions.
                            }
                      //  count++;
                      //  }
                    }
                    else
                    {
                        //skip row
                    }
 
                    db.SaveChanges();
                   

                }

                txtFile.Text = "Saved to Database! Check your Inventory list!";
                MessageBox.Show("Item(s) saved successfully to database!", "DATABASE UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                txtFile.Text = "INVALID OR EMPTY FILE!";
                MessageBox.Show("Please do NOT import a blank or invalid CSV file!");
                
            }
        }
}}

    
