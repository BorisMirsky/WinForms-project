
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;



namespace WinForms2
{
    public partial class MainForm : Form
    {
        private ProductsContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dbContext = new ProductsContext();
            dbContext.Categories.Load();
            categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            dbContext?.Dispose();
            dbContext = null;
        }


        private void dataGridViewCategories_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dbContext != null)
            {
                var category = (Category?)dataGridViewCategories.CurrentRow!.DataBoundItem;

                if (category != null)
                {
                    dbContext.Entry(category).Collection(e => e.Products).Load();
                }
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                dbContext!.SaveChanges();
                dataGridViewCategories.Refresh();
                dataGridViewProducts.Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(" ");
                Debug.WriteLine(" ");
                Debug.WriteLine(ex.InnerException.Message);
                Debug.WriteLine(" ");
                Debug.WriteLine(" ");
            }
        }

        //private void dataGridViewCategories_ClientSizeChanged(object sender, EventArgs e)
        //{
        //    if (dbContext != null)
        //    {
        //        var category = (Category?)dataGridViewCategories.CurrentRow!.DataBoundItem;

        //        if (category != null)
        //        {
        //            dbContext.Entry(category).Collection(e => e.Products).Load();
        //        }
        //    }

        //}

        private void dataGridViewProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //var product = (Product?)dataGridViewProducts.CurrentRow!.DataBoundItem;

            //if (product != null)
            //{
                //dbContext.Entry(category).Collection(e => e.Products).Load();
                Debug.WriteLine(" ");
                Debug.WriteLine(" ");
                Debug.WriteLine("CellValueChanged");
                Debug.WriteLine(sender.ToString());
                Debug.WriteLine(" ");
                Debug.WriteLine(" ");
            //}
        }

    }
}
