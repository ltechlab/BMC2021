using DGVPrinterHelper;
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
    public partial class PointOfSales : Form
    {
        DataTable cart = new DataTable();
        //DateTime dateToday = DateTime.UtcNow.Date;
        DateTime dateToday = DateTime.Now.Date;
     
        int discount;
        POSDBEntities2 db = new POSDBEntities2();

        public PointOfSales()
        {
            InitializeComponent();
            var query =
          from ord in db.current_user
          where ord.id == 1
          select ord;
            foreach (current_user ord in query)
            {
                lb_cuser.Text = ord.username;
            }
            PopulateCart();

            //INITIALIZE DATATABLE
            cart.Clear();
            cart.Columns.Add("brand");
            cart.Columns.Add("itemname");
            cart.Columns.Add("barcode");
            cart.Columns.Add("qty", typeof(Double));
            cart.Columns.Add("price");
            cart.Columns.Add("discount");
            cart.Columns.Add("finalprice");
        }

        private void InputOption_Barcode()
        {
            string bcodeinput = tb_barcode.Text;
            if (bcodeinput == null)
            {
                MessageBox.Show("PLEASE USE THE MANUAL INPUT OPTION", "PLEASE USE MANUAL INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var query =
               from ord in db.Inv_Summary
               where ord.barcode == bcodeinput
               select ord;

                foreach (Inv_Summary ord in query)
                {
                   string  selectedBrand = ord.brand;
                   string  selectedItem = ord.itemname;

                }

            }


        }

      public void clearFields()
        {
            tb_barcode.Text = "";
            cb_brand.Text = "";
            cb_item.Text = "";
            tb_discount.Text = "";
            tb_qty.Text = "";
          
        }



   

        private void btn_addtocart_Click(object sender, EventArgs e)
        {

          
            string bcodeinput = tb_barcode.Text;
            if (bcodeinput == "")
            {
                string selectedBrand = Convert.ToString(this.cb_brand.GetItemText(this.cb_brand.SelectedItem));
                string selectedItem = Convert.ToString(this.cb_item.GetItemText(this.cb_item.SelectedItem));
                if (selectedItem == "")
                {
                    MessageBox.Show("Please select item to put to cart", "PLEASE INPUT ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    if (tb_qty.Text == "")
                    {
                        MessageBox.Show("Please input quantity", "PLEASE INPUT QUANTITY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                     //   int discount;
                        if (tb_discount.Text == "") {                         
                            discount = 0;
                        }
                        else {
                           try
                            {
                                discount = (int)tb_discount.Value;
                            }
                            catch (Exception ee) {
                                MessageBox.Show("Please input VALID INTEGER", "INVALID INTEGER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                discount = 0;                       
                            }
                        } 
                        int quantity = Convert.ToInt32(tb_qty.Text);

                    

                        //SWITCH
                        var query =
                        from ord in db.Inv_Summary
                        where ord.brand == selectedBrand && ord.itemname == selectedItem
                        select ord;

                        foreach (Inv_Summary ord in query)
                        {
                            string barcodez = Convert.ToString(ord.barcode);
                            double itemprice = ord.saleprice.Value;
                            double discounted = discount * itemprice / 100;
                            double Fprice = (itemprice - discounted) * quantity;

                            var count = db.Inv_Peritem.Count(me => me.itembrand == selectedBrand && me.itemname == selectedItem);
                            if (quantity > count)
                            {
                                MessageBox.Show("PLEASE SELECT LOWER QUANTITY.");
                            }
                            else
                            {


                                //Add to Datagrid
                                DataRow _ravi = cart.NewRow();
                                _ravi["brand"] = selectedBrand;
                                _ravi["itemname"] = selectedItem;
                                _ravi["barcode"] = barcodez;
                                _ravi["qty"] = quantity;
                                _ravi["price"] = itemprice;
                                _ravi["discount"] = discount;
                                _ravi["finalprice"] = Fprice;
                                cart.Rows.Add(_ravi);


                           

                            }
                        }

                            clearFields();
                        
                    }
                }
            }
            //IF BARCODE ANG GINAMIT
            else
            {
                var query =
                from ord in db.Inv_Summary
                where ord.barcode == bcodeinput
                select ord;

                foreach (Inv_Summary ord in query)
                {
                    string selectedBrand = Convert.ToString(ord.brand);
                    string selectedItem = Convert.ToString(ord.itemname);
                    string barcodez = Convert.ToString(ord.barcode);
                    //GET OTHER VALUES EXCEPT FROM BCODE, BRAND AND ITEMNAME
               
                    if (tb_qty.Text == "")
                    {
                        MessageBox.Show("Please input quantity", "PLEASE INPUT QUANTITY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (tb_discount.Text == "")
                        {
                            discount = 0;
                        }
                        else
                        {
                            try
                            {
                                discount = (int)tb_discount.Value;

                            }
                            catch (Exception ee)
                            {
                                MessageBox.Show("Please input VALID INTEGER", "INVALID INTEGER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                discount = 0;
                            }
                        }


                      
                         int quantity = Convert.ToInt32(tb_qty.Text);
                        double itemprice = ord.saleprice.Value;
                        double discounted = discount * itemprice / 100;
                        double Fprice = (itemprice - discounted)*quantity;



                        var count = db.Inv_Peritem.Count(me => me.barcode == barcodez);
                        if (quantity > count)
                        {
                            MessageBox.Show("PLEASE SELECT LOWER QUANTITY.");
                        }
                        else
                        {


                            //Add to Datagrid
                            DataRow _ravi = cart.NewRow();
                            _ravi["brand"] = selectedBrand;
                            _ravi["itemname"] = selectedItem;
                            _ravi["barcode"] = barcodez;
                            _ravi["qty"] = quantity;
                            _ravi["price"] = itemprice;
                            _ravi["discount"] = discount;
                            _ravi["finalprice"] = Fprice;
                            cart.Rows.Add(_ravi);
                        }

                    }

                    clearFields();
                }
            }
      
            refreshTotal();
        }

        private void refreshTotal()
        {

            grid_cart.DataSource = cart;
            var result = cart.AsEnumerable()
                    .Sum(x => Convert.ToDouble(x["finalprice"]));

            lb_totalprice.Text = result.ToString();
        }



        protected void DeleteFromCart()
        {  
            DataGridViewRow dr = grid_cart.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (dr != null)
            {
                var rowToRemove = cart.Rows.Cast<DataRow>().FirstOrDefault(row => row[0] == dr.Cells[0].Value);
                if (rowToRemove != null)
                {
                    cart.Rows.Remove(rowToRemove);
                    
                }
                


            }

        }
          
        private void PopulateCart()
        {

            //populate BRAND
            var meronba = db.Inv_Summary.Select(c => c.brand).Distinct().ToList();
            cb_brand.DataSource = meronba;

                //populate ITEMNAME (INITIALIZE)
                cb_brand.SelectedIndexChanged += new EventHandler(cb_brand_selectedIndexChanged);
             
    }
        protected void cb_brand_selectedIndexChanged(object sender, EventArgs e)
        {

            string selected = this.cb_brand.GetItemText(this.cb_brand.SelectedItem);
            DataTable dt = new DataTable();
            
            dt.Clear();
            dt.Columns.Add("id");
            dt.Columns.Add("brand");
            dt.Columns.Add("itemname");
            dt.Columns.Add("unitsinstock");
            dt.Columns.Add("unitsavailableforsale");
            dt.Columns.Add("stockvalue");
            dt.Columns.Add("saleprice");

            var query =
           from ord in db.Inv_Summary
           where ord.brand == selected
           select ord;

            foreach (Inv_Summary ord in query)
            {
                DataRow _ravi = dt.NewRow();
                _ravi["brand"] = ord.brand;
                _ravi["itemname"] = ord.itemname;
                _ravi["unitsinstock"] = ord.unitsinstock;
                _ravi["unitsavailableforsale"] = ord.unitsavailableforsale;
                _ravi["stockvalue"] = ord.stockvalue;
                _ravi["saleprice"] = ord.saleprice;
                dt.Rows.Add(_ravi);
 
            }

            cb_item.DataSource = dt;
            cb_item.ValueMember = "itemname";
            cb_item.DisplayMember = "itemname";
        }

        private void lb_totalprice_Click(object sender, EventArgs e)
        {
           
        }

        private void printInvoice()
        {
            var getrecord = db.bprofile.Where(a => a.id == 1).SingleOrDefault();
            string bname = getrecord.bname;
            string badd = getrecord.baddress;

            string customer_name = tb_cname.Text;
            string totaldue = lb_totalprice.Text;
     
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "SALES INVOICE";//HEADER
            printer.SubTitle = bname + " " + badd;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
           // printer.ProportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "  SOLD TO: " + customer_name + " TOTAL AMT DUE:  " + totaldue;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(grid_cart);

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            string name = tb_cname.Text;
            if (name == ""){
                MessageBox.Show("Please input customer name for the issuance of Official Receipt.", "PLEASE INPUT NAME", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                CheckOut();
               
            }
        }

        private int CheckUnitsAvailable(String bcode)
        {
            var report = (from d in db.Inv_Summary
                          where d.barcode == bcode
                          select d.unitsavailableforsale).FirstOrDefault();

            return (int)report;
        }

        private bool OkayTosell(List<string> bcodes) //get input of array of unique bcodes in list
        {
            int counter = 0;
            int totalcount = 0;
         foreach(var bcode in bcodes)
            {
                //check total quantity in datatable
            //decimal totalqty = decimal.Parse(cart.Compute("SUM(qty)", "barcode=="+bcode).ToString());
                var totalqty = cart.AsEnumerable()
                            .Where(r => r.Field<String>("barcode") == bcode)
                            .Sum(r => r.Field<Double>("qty"));


                //check units available
                int available = CheckUnitsAvailable(bcode);

                if (totalqty <= available)
                {
                    counter++;
                    totalcount++;
                }
                else
                {
                    totalcount++;
                }
            }
            //if counter is greater than or equal to the number of unique bcodes in the array, everything good
            if (counter >= totalcount) {
                return true;
            }
            else {
                return false;
            }


        }

        private void CheckOut()
        {
            DialogResult result = MessageBox.Show("CONFIRM PURCHASE", "CONFIRM PURCHASE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<string> vv = cart.AsEnumerable().Select(x => x["barcode"].ToString()).Distinct().ToList();
                bool okayba = OkayTosell(vv);
                if (okayba == true)
                {

                    try
                    {
                        //UPDATE INVENTORY  AND UPDATE SALES MONITORING
                        //FOREACH ROW IN DATATABLE CART           
                        foreach (DataRow row in cart.Rows)
                        {
                            //ADD ROW TO SALE_PERITEM
                            string sdate = dateToday.ToString("dd-MM-yyyy");
                            string sbarcode = row.Field<string>("barcode");
                            string sbrand = row.Field<string>("brand");
                            string siname = row.Field<string>("itemname");
                            string cname = Convert.ToString(tb_cname.Text);
                            string loggedBy = lb_cuser.Text;

                            //int qty = int.Parse(row.Field<string>("qty"));
                            double qty = row.Field<Double>("qty");
                            double sfprice = double.Parse(row.Field<string>("finalprice"));
                            int sdisc = int.Parse(row.Field<string>("discount"));
                            double spprice = double.Parse(row.Field<string>("price"));
                            string bcode = row.Field<string>("barcode");


                            for (int i = 0; i < qty; i++)
                            {
                                //GET ROW FROM INVENTORY ITEM
                                var report = (from d in db.Inv_Peritem
                                              where d.barcode == bcode
                                              select d).FirstOrDefault();


                                //DELETE FROM INVENTORY PERITEM
                                db.Inv_Peritem.Remove(report);
                                db.SaveChanges();

                                double pprice = Convert.ToDouble(report.purchaseprice);

                                sales_peritem sper = new sales_peritem()
                                {
                                    purchasedate = sdate,
                                    barcode = sbarcode,
                                    saleprice = spprice,
                                    itembrand = sbrand,
                                    itemname = siname,
                                    purchaseprice = pprice,
                                    finalsaleprice = sfprice,
                                    discount = sdisc,
                                    customername = cname,
                                    cashier = loggedBy,
                                };

                                db.sales_peritem.Add(sper);


                            }

                        }
                        //CLEAR DATATABLE
                      
                        db.SaveChanges();

                        //PRINT INVOICE?
                        if (MessageBox.Show("Print INVOICE? ", "CHECKOUT SUCCESS!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            printInvoice();
                            lb_totalprice.Text = "";
                            tb_cname.Text = "";
                            cart.Clear();
                        }
                        else
                        {
                            lb_totalprice.Text = "";
                            tb_cname.Text = "";
                            cart.Clear();
                        }
                    }
                    catch
                    {

                        MessageBox.Show("Error checking out items. Please close this window and try again. ", "INVALID CHECKOUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
            else {
                MessageBox.Show("Invalid attempt to check out item. Make sure you did not double-checkout items, or your inventory has enough supply. ", "INVALID CHECKOUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }

            }
    
        }

     

        private void btn_removecart_Click(object sender, EventArgs e)
        {
            DeleteFromCart();
            refreshTotal();
            grid_cart.DataSource = cart;
          
        }
    }
        

    }
    


 
