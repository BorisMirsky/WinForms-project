using GetStartedWinForms;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;



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

            this.dbContext = new ProductsContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Categories.Load();

            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewCategories.Refresh();
            this.dataGridViewProducts.Refresh();
        }

        private void dataGridViewCategories_SelectionChanged_1(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var category = (Category)this.dataGridViewCategories.CurrentRow.DataBoundItem;

                if (category != null)
                {
                    this.dbContext.Entry(category).Collection(e => e.Products).Load();
                }
            }
        }
    }
}
