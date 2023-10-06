using System.Windows.Forms;
using DAL;
using Repository;

namespace Catalog
{
    public partial class Form1
    {
        GenericUnitOfWork unitOfWork = new GenericUnitOfWork(new ApplicationDbContext());
        public Form1()
        {
            InitializeComponent();
            GetValuesFromDB();
        }

        private void GetValuesFromDB()
        {
            IGenericRepository<Book> repositoryBook = unitOfWork.Repository<Book>();

            foreach (Book book in repositoryBook.GetAll())
            {

                var SageName = "";
                if (book.Sages.Count == 0)
                {
                    SageName = "no author";
                }
                else
                {
                    SageName = book.Sages.FirstOrDefault().Name;
                }
                AddItemToListBox($"{book.Title} Sage: {SageName}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void AddItemToListBox(string item)
        {
            ItemsBox.Items.Add(item);
        }

        public string GetSelectedTitle() 
        {
            var separator = "Sage:";
            string[] parts = ItemsBox.SelectedItem.ToString().Split(new[] { separator }, StringSplitOptions.None);
            return parts[0].Trim(); 
        }
        public string GetSelectedSage()
        {
            var separator = "Sage:";
            string[] parts = ItemsBox.SelectedItem.ToString().Split(new[] { separator }, StringSplitOptions.None);
            return parts[1].Trim();
        }

        public void EditSelectedItem(string EditString)
        {
            for (var i = 0; i < ItemsBox.Items.Count; i++)
            {
                if (i == ItemsBox.SelectedIndex)
                {
                    ItemsBox.Items[i] = EditString;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddPopUpWindow popUpWindow = new AddPopUpWindow(this, "addButton");
            popUpWindow.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
            IGenericRepository<Sage> repositorySage = unitOfWork.Repository<Sage>();
            IGenericRepository<Book> repositoryBook = unitOfWork.Repository<Book>();
            if (ItemsBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select Item");
                return;
            }

            Book book = repositoryBook.FindAll(b => b.Title == GetSelectedTitle()
             && b.Sages?.FirstOrDefault().Name == GetSelectedSage()).FirstOrDefault();
            
            ItemsBox.Items.RemoveAt(ItemsBox.SelectedIndex);
            if (book != null)
            {
                repositoryBook.Remove(book);
            }
        }

        private void ClearListBoxButton_Click(object sender, EventArgs e)
        {
            ItemsBox.Items.Clear();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ItemsBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select Item");
                return;
            }
            AddPopUpWindow popUpWindow = new AddPopUpWindow(this, "renameButton");
            popUpWindow.ShowDialog();

        }
    }
}