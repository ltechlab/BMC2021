using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BMC2021
{
    public partial class Inventory : Form
    {

        DateTime dateToday = DateTime.UtcNow.Date;
        POSDBEntities2 db = new POSDBEntities2();

        public Inventory()
        {
            InitializeComponent();
            loadGrid_Peritem();
            loadGrid_Summary();
            loadGrid_Reject();
            cb_condition.Text = "1";

            lb_date.Text = dateToday.ToString("dd-MM-yyyy");
            var query =
             from ord in db.current_user
             where ord.id == 1
             select ord;
            foreach (current_user ord in query)
            {
                lb_cuser.Text = ord.username;
            }
        }


        private void grid_summary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadGrid_Reject()
        {
    
            var query = from c in db.Inv_Peritem
                        where c.condition == 0
                        select c;
            var users = query.ToList();
            grid_reject.DataSource = users;


        }

        private void loadGrid_Peritem()
        {
       
            var query = from c in db.Inv_Peritem
                        where c.condition == 1
                        select c;
            var users = query.ToList();

            grid_peritem.DataSource = users;

            using (POSDBEntities2 db = new POSDBEntities2())
            {
                invPeritemBindingSource.DataSource = db.Inv_Peritem.ToList();
            }

        }

        private void loadGrid_Summary()
        {
            var cleara =
            from ord in db.Inv_Summary
            select ord;

            foreach (Inv_Summary ord in cleara)
            {
                db.Inv_Summary.Remove(ord);

            }
            //THEN LOAD NEW

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("id");
            dt.Columns.Add("brand");
            dt.Columns.Add("itemname");
            dt.Columns.Add("unitsinstock");
            dt.Columns.Add("unitsavailableforsale");
            dt.Columns.Add("stockvalue");
            dt.Columns.Add("saleprice");
            dt.Columns.Add("barcode");

            var query =
              from ord in db.Inv_Peritem
              select ord;

            foreach (Inv_Peritem ord in query)
            {
                string barcodez = ord.barcode;
                bool contains_barcode = dt.AsEnumerable().Any(row => barcodez == row.Field<String>("barcode"));
                if (!contains_barcode)
               {
                    string itemname = ord.itemname;
                    string brandname = ord.itembrand;

                    int count_total = (from o in db.Inv_Peritem
                                       where o.barcode == barcodez
                                       select o).Count();

                    int count_sellable = (from o in db.Inv_Peritem
                                          where o.barcode == barcodez && o.condition == 1
                                          select o).Count();

                    DataRow _ravi = dt.NewRow();
                    _ravi["brand"] = brandname;
                    _ravi["itemname"] = itemname;
                    _ravi["unitsinstock"] = count_total;
                    _ravi["unitsavailableforsale"] = count_sellable;
                    _ravi["stockvalue"] = ord.purchaseprice;
                    _ravi["saleprice"] = ord.saleprice;
                    _ravi["barcode"] = ord.barcode;
                    dt.Rows.Add(_ravi);


                    Inv_Summary summary = new Inv_Summary()
                    {
                        brand = brandname,
                        itemname = itemname,
                        unitsinstock = count_total,
                        unitsavailableforsale = count_sellable,
                        stockvalue = ord.purchaseprice,
                        saleprice = ord.saleprice,
                        barcode = ord.barcode
                    };

                    db.Inv_Summary.Add(summary);
                    db.SaveChanges();
                }
            
            }
            grid_summary.DataSource = dt;
            using (POSDBEntities2 db = new POSDBEntities2())
            {
                invSummaryBindingSource.DataSource = db.Inv_Summary.ToList();
               
            }

        }
       
        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNVENTORY_SUMMARY_NEW.Inv_Summary' table. You can move, or remove it, as needed.
            this.inv_SummaryTableAdapter.Fill(this.iNVENTORY_SUMMARY_NEW.Inv_Summary);
            // TODO: This line of code loads data into the 'pOSDBDataSet1.Inv_Peritem' table. You can move, or remove it, as needed.
            this.inv_PeritemTableAdapter.Fill(this.pOSDBDataSet1.Inv_Peritem);

            // TODO: This line of code loads data into the 'pOSDBDataSet1.Inv_Peritem' table. You can move, or remove it, as needed.
            this.inv_PeritemTableAdapter.Fill(this.pOSDBDataSet1.Inv_Peritem);
            using (POSDBEntities2 db = new POSDBEntities2())
            {
                invSummaryBindingSource.DataSource = db.Inv_Summary.ToList();
                invPeritemBindingSource.DataSource = db.Inv_Peritem.ToList();
            }

        }

        private void btn_removefrrej_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Item will be moved back to inventory. Are you sure you want to return items to inventory? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (grid_reject.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in grid_reject.SelectedRows)
                    {
                        // int rowIndex = grid_reject.CurrentCell.RowIndex;

                        //   DataGridViewRow selectedRow = grid_reject.Rows[rowIndex];

                        // int a = Convert.ToInt32(selectedRow.Cells[0].Value);
                        int a = Convert.ToInt32(row.Cells[0].Value);

                        var query =
                            from ord in db.Inv_Peritem
                            where ord.id == a
                            select ord;

                        foreach (Inv_Peritem ord in query)
                        {
                            ord.condition = 1;
                        }
                        try
                        {

                            db.SaveChanges();
                        }
                        catch (Exception ee)
                        {
                            Console.WriteLine(ee);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("PLEASE SELECT/HIGHLIGHT THE ENTIRE ROW TO RETURN TO INVENTORY. You can do this by clicking the leftmost cell of the rows you wish to return to inventory. You can also hold the 'shift button' to select multiple rows.");
                }

                loadGrid_Reject();
                loadGrid_Peritem();
                loadGrid_Summary();
            }
        }

        private bool CheckEmptyFields()
        {
            string supplier = tb_supplier.Text;
            string brand = tb_itembrand.Text;
            string item = tb_itemname.Text;
            string purch = tb_purchaseprice.Text;
            string code = tb_barcode.Text;
            string desc = tb_itemdescription.Text;
            string condition = cb_condition.Text;
            string saleprice = tb_price.Text;
 

            if(supplier == "")
            {
                MessageBox.Show("Please input SUPPLIER", "PLEASE INPUT SUPPLIER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }else if (brand == "")
            {
                MessageBox.Show("Please input BRAND.", "PLEASE INPUT BRAND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (item == "")
            {
                MessageBox.Show("Please input ITEM.", "PLEASE INPUT ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (purch == "")
            {
                MessageBox.Show("Please input PURCHASE PRICE.", "PLEASE INPUT PURCAHSE PRICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (code == "")
            {
                MessageBox.Show("Please input CODE/BARCODE.", "PLEASE INPUT BARCODE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (desc == "")
            {
                MessageBox.Show("Please input ITEM DESCRIPTION.", "PLEASE INPUT DESCRIPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (condition == "")
            {
                MessageBox.Show("Please input ITEM CONDITION. 0 = REJECT and 1 = APPROVED", "PLEASE INPUT ITEM CONDITION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }        
            else if (saleprice == "")
            {
                MessageBox.Show("Please input SALE PRICE.", "PLEASE INPUT SALE PRICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else
            {
                return true;
            }
        }

        private bool CheckForDuplicateBcode(string bcode)
        {
            int check = (from d in db.Inv_Peritem
                          where d.barcode == bcode
                          select d).Count();
            if (check>0)
            {
                //may duplicate
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void SaveItem()
        {

            string date = lb_date.Text;
            string supplierz = tb_supplier.Text;
            string brand = tb_itembrand.Text;
            string name = tb_itemname.Text;
            double pricez = (double)tb_purchaseprice.Value;
            double setprice = (double)tb_price.Value;
            string barcodez = tb_barcode.Text;
            string description = tb_itemdescription.Text;
            int conditionz = int.Parse(cb_condition.Text);
            string loggedBy = lb_cuser.Text;
            int quantity;
            string Checkquantity = tb_qty.Text;

            //check for duplicate barcode in inventory
            bool check = CheckForDuplicateBcode(barcodez);
            if (check == true)
            {
                if (MessageBox.Show("Existing item with similar barcode found. Is this the same item? Continue inserting to database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Checkquantity == "")
                    {
                        quantity = 1;
                    }
                    else
                    {
                        quantity = int.Parse(tb_qty.Text);
                    }

                    for (int i = 0; i < quantity; i++)
                    {

                        try
                        {

                            Inv_Peritem peritem = new Inv_Peritem()
                            {
                                deliverydate = date,
                                supplier = supplierz,
                                itembrand = brand,
                                itemdescription = description,
                                purchaseprice = pricez,
                                barcode = barcodez,
                                itemname = name,
                                condition = conditionz,
                                saleprice = setprice,
                                loggedby = loggedBy,
                            };
                            db.Inv_Peritem.Add(peritem);

                        }

                        catch (Exception ee)
                        {
                            Console.WriteLine(ee);
                            // Provide for exceptions.
                        }
                    }

                    db.SaveChanges();

                    MessageBox.Show("Item(s) saved successfully to database!", "DATABASE UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear fields
                    tb_supplier.Text = "";
                    tb_itembrand.Text = "";
                    tb_itemname.Text = "";
                    tb_purchaseprice.Text = "";
                    tb_barcode.Text = "";
                    tb_itemdescription.Text = "";
                    cb_condition.Text = "1";
                    tb_price.Text = "";
                    tb_qty.Text = "";

                }
                else
                {


                }

            }
            else
            {
                //insert to DB with no issues
                if (Checkquantity == "")
                {
                    quantity = 1;
                }
                else
                {
                    quantity = int.Parse(tb_qty.Text);
                }

                for (int i = 0; i < quantity; i++)
                {

                    try
                    {

                        Inv_Peritem peritem = new Inv_Peritem()
                        {
                            deliverydate = date,
                            supplier = supplierz,
                            itembrand = brand,
                            itemdescription = description,
                            purchaseprice = pricez,
                            barcode = barcodez,
                            itemname = name,
                            condition = conditionz,
                            saleprice = setprice,
                            loggedby = loggedBy,
                        };
                        db.Inv_Peritem.Add(peritem);

                    }

                    catch (Exception ee)
                    {
                        Console.WriteLine(ee);
                        // Provide for exceptions.
                    }
                }

                db.SaveChanges();

                MessageBox.Show("Item(s) saved successfully to database!", "DATABASE UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clear fields
                tb_supplier.Text = "";
                tb_itembrand.Text = "";
                tb_itemname.Text = "";
                tb_purchaseprice.Text = "";
                tb_barcode.Text = "";
                tb_itemdescription.Text = "";
                cb_condition.Text = "1";
                tb_price.Text = "";
                tb_qty.Text = "";
            }
        
        }

        protected void DeleteRow()
        {

           // if (grid_peritem.SelectedCells.Count > 0)
            if (grid_peritem.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in grid_peritem.SelectedRows)
                {

                    // int rowIndex = grid_peritem.CurrentCell.RowIndex;
                    // DataGridViewRow selectedRow = grid_peritem.Rows[rowIndex];
                    // int a = Convert.ToInt32(selectedRow.Cells[0].Value);
                    int a = Convert.ToInt32(row.Cells[0].Value);
                    //inserted a foreach for all selected rows

                    try
                    {
                        var report = (from d in db.Inv_Peritem
                                      where d.id == a
                                      select d).FirstOrDefault();
                        db.Inv_Peritem.Remove(report);
                        db.SaveChanges();
                    }
                    catch (Exception ee)
                    {
                        Console.WriteLine(ee);
                    }
                }

                MessageBox.Show("DELETED SUCCESSFULLY!");
                loadGrid_Peritem();
                loadGrid_Reject();
                loadGrid_Summary();


            }
            else {
                MessageBox.Show("PLEASE SELECT/HIGHLIGHT THE ENTIRE ROW TO DELETE. You can do this by clicking the leftmost cell of the rows you wish to delete. You can also hold the 'shift button' to select multiple rows.");
            }
        }
        
        protected void DeleteRow_Reject()
        {
            if (grid_reject.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in grid_reject.SelectedRows)
                {
                   // int rowIndex = grid_reject.CurrentCell.RowIndex;
                   // DataGridViewRow selectedRow = grid_reject.Rows[rowIndex];
                   // int a = Convert.ToInt32(selectedRow.Cells[0].Value);
                    int a = Convert.ToInt32(row.Cells[0].Value);

                    try
                    {

                        var report = (from d in db.Inv_Peritem
                                      where d.id == a
                                      //   select d).Single();
                                      select d).FirstOrDefault();
                        db.Inv_Peritem.Remove(report);
                        db.SaveChanges();
                    }
                    catch (Exception ee)
                    {
                        Console.WriteLine(ee);
                    }

                    MessageBox.Show("DELETED SUCCESSFULLY!");
                }
            }
            else
            {
                MessageBox.Show("PLEASE SELECT/HIGHLIGHT THE ENTIRE ROW TO DELETE. You can do this by clicking the leftmost cell of the rows you wish to delete. You can also hold the 'shift button' to select multiple rows.");
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Item will be added to inventory. Add items? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckEmptyFields() == true)
                {
                    //check for duplicate barcode

                    SaveItem();
                    loadGrid_Peritem();
                    loadGrid_Reject();
                    loadGrid_Summary();
                }
                else
                {
                    //do not save
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Selected items will be deleted PERMANENTLY. Are you sure you want to delete items? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                    if (grid_peritem.Rows.Count == 0)
                    {
                        MessageBox.Show("EMPTY LIST!");
                    }
                    else
                    {

                        DeleteRow();

                    
                    }
                
            }
            
        }

       

        private void MovetoReject()
        {
            if (grid_peritem.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in grid_peritem.SelectedRows)
                {
                  //  int rowIndex = grid_peritem.CurrentCell.RowIndex;
                 //   DataGridViewRow selectedRow = grid_peritem.Rows[rowIndex];
                 //   int a = Convert.ToInt32(selectedRow.Cells[0].Value);
                    int a = Convert.ToInt32(row.Cells[0].Value);
                    var query =
                        from ord in db.Inv_Peritem
                        where ord.id == a
                        select ord;

                    foreach (Inv_Peritem ord in query)
                    {
                        ord.condition = 0;
                    }
                    try
                    {

                        db.SaveChanges();
                    }
                    catch (Exception ee)
                    {
                        Console.WriteLine(ee);

                    }
                }
            }
            else
            {
                MessageBox.Show("PLEASE SELECT/HIGHLIGHT THE ENTIRE ROW TO MOVE TO REJECTS. You can do this by clicking the leftmost cell of the rows you wish to move to rejects. You can also hold the 'shift button' to select multiple rows.");
            }
            loadGrid_Reject();
            loadGrid_Peritem();


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Move item to REJECTS? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (grid_peritem.Rows.Count == 0)
                {
                    MessageBox.Show("EMPTY LIST!");
                }
                else
                {
                    MovetoReject();
                    loadGrid_Peritem();
                    loadGrid_Summary();
                }
             
            }

        }

        private void grid_peritem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(MessageBox.Show("Item will be deleted PERMANENTLY. Are you sure you want to delete items?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    invPeritemBindingSource.RemoveCurrent();
                }
            }
        }

        private void btn_deleteReject_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Item will be deleted PERMANENTLY. Are you sure you want to delete items? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (grid_peritem.Rows.Count == 0)
                {
                    MessageBox.Show("EMPTY LIST!");
                }
                else
                {

                    DeleteRow_Reject();
                    loadGrid_Peritem();
                    loadGrid_Reject();
                    loadGrid_Summary();
                }

            }
        }

        struct DataParameter
        {
            public List<Inv_Peritem> Inv_Peritem;
            public List<Inv_Summary> Inv_Summary;
            public string FileName { get; set; }
        }

        DataParameter _inputParameter;

        private void btn_exp_sum_Click(object sender, EventArgs e)
        {
            invPeritemBindingSource.ResetBindings(false);


            if (backgroundWorker2.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv*", DefaultExt = ".csv", ValidateNames = true })
            {
                sfd.OverwritePrompt = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    
                    _inputParameter.Inv_Peritem = invPeritemBindingSource.DataSource as List<Inv_Peritem>;
                    _inputParameter.FileName = sfd.FileName;
                    progressBarz.ForeColor = System.Drawing.Color.Teal;
                    progressBarz.Minimum = 0;
                    progressBarz.Value = 0;
                    backgroundWorker2.RunWorkerAsync(_inputParameter);
                }
            }
        }


    

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<Inv_Peritem> list = ((DataParameter)e.Argument).Inv_Peritem;
            string filename = ((DataParameter)e.Argument).FileName;
            int index = 1;
            int process = list.Count;
            using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("id,deliverydate,supplier,itembrand,itemname,purchaseprice,barcode,itemdescription,condition,saleprice,loggedby");
                foreach (Inv_Peritem p in list)
                {
                    if (!backgroundWorker2.CancellationPending)
                    {
                        backgroundWorker2.ReportProgress(index++ * 100 / process);
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", p.id, "\"" + p.deliverydate + "\"", "\"" +  p.supplier + "\"", "\"" + p.itembrand + "\"", "\"" + p.itemname + "\"", "\"" + p.purchaseprice + "\"", "\"" + p.barcode + "\"", "\"" + p.itemdescription + "\"", "\"" + p.condition + "\"", "\"" + p.saleprice + "\"", "\"" + p.loggedby + "\""));

                    }
                }
                sw.Write(sb.ToString());
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBarz.Value = e.ProgressPercentage;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(100);
            MessageBox.Show("Successfully Exported to File!");
            progressBarz.Value = 0;
        }

        private void backgroundWorker3_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBarz.Value = e.ProgressPercentage;
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(100);
            MessageBox.Show("Successfully Exported to File!");
            progressBarz.Value = 0;
        }

        private void btn_exp_peritem_Click(object sender, EventArgs e)
        {
            invSummaryBindingSource.ResetBindings(false);
            if (backgroundWorker3.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv*", DefaultExt = ".csv", ValidateNames = true })
            {
                sfd.OverwritePrompt = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    
                    _inputParameter.Inv_Summary = invSummaryBindingSource.DataSource as List<Inv_Summary>;
                    _inputParameter.FileName = sfd.FileName;
                    progressBarz.ForeColor = System.Drawing.Color.Teal;
                    progressBarz.Minimum = 0;
                    progressBarz.Value = 0;
                    backgroundWorker3.RunWorkerAsync(_inputParameter);
                }
            }
        }

        private void backgroundWorker3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<Inv_Summary> list = ((DataParameter)e.Argument).Inv_Summary;
            string filename = ((DataParameter)e.Argument).FileName;
            int index = 1;
            int process = list.Count;
            using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("id,brand,itemname,unitsinstock,unitsavailableforsale,stockvalue,saleprice,barcode");
                foreach (Inv_Summary p in list)
                {
                    if (!backgroundWorker3.CancellationPending)
                    {
                        backgroundWorker3.ReportProgress(index++ * 100 / process);
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", p.id, "\"" + p.brand + "\"", "\"" + p.itemname + "\"", "\"" + p.unitsinstock + "\"", "\"" + p.unitsavailableforsale + "\"", "\"" + p.stockvalue + "\"", "\"" + p.saleprice + "\"", "\"" + p.barcode + "\""));

                    }
                }
                sw.Write(sb.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void grid_peritem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_SearchName.Text == "")
            {
                MessageBox.Show("Please type a KEYWORD in the search box.");

            }
            else
            {
                var query = from c in db.Inv_Peritem
                            where
                            c.itemname.ToLower().Contains(txt_SearchName.Text.ToLower()) ||
                            c.itembrand.ToLower().Contains(txt_SearchName.Text.ToLower()) ||
                            c.itemdescription.ToLower().Contains(txt_SearchName.Text.ToLower())
                            select c;

                var query2 = from d in query
                             where
                             d.condition == 1
                             select d;

                var searchresults = query2.ToList();
                grid_peritem.DataSource = searchresults;
            }

        }

        private void btn_allitems_Click(object sender, EventArgs e)
        {
            loadGrid_Peritem();
            txt_SearchName.Text = "";
        }

        private void btn_rsearch_Click(object sender, EventArgs e)
        {
            if (txtbox_rejects.Text == "")
            {
                MessageBox.Show("Please type a KEYWORD in the search box.");

            }
            else
            {
                var query = from c in db.Inv_Peritem
                            where
                            c.itemname.ToLower().Contains(txtbox_rejects.Text.ToLower()) ||
                            c.itembrand.ToLower().Contains(txtbox_rejects.Text.ToLower()) ||
                            c.itemdescription.ToLower().Contains(txtbox_rejects.Text.ToLower())
                            select c;

                var query2 = from d in query
                             where
                             d.condition == 0
                             select d;

                var searchresults = query2.ToList();
                grid_reject.DataSource = searchresults;
            }
        }

        private void btn_rall_Click(object sender, EventArgs e)
        {
            loadGrid_Reject();
            txtbox_rejects.Text = "";

        }
    }
}
