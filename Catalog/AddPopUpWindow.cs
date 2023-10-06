using DAL;
using Repository;


namespace Catalog
{
    public partial class AddPopUpWindow : Form
    {
        private Form1 Form1 { get; set; }
        private string TypeOfCallOut { get; set; }

        public AddPopUpWindow(Form1 form1, string typeOfCallOut = "")
        {
            InitializeComponent();
            Form1 = form1;
            TypeOfCallOut = typeOfCallOut;
            if (typeOfCallOut == "renameButton")
            {
                BookTitle.Text = Form1.GetSelectedTitle();
                SageName.Text = Form1.GetSelectedSage();
            }
        }

        private void AddPopUpWindow_Load(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            GenericUnitOfWork unitOfWork = new GenericUnitOfWork(new ApplicationDbContext());
            IGenericRepository<Sage> repositorySage = unitOfWork.Repository<Sage>();
            IGenericRepository<Book> repositoryBook = unitOfWork.Repository<Book>();

            if (BookTitle.Text.Length == 0 || SageName.Text.Length == 0)
            {
                MessageBox.Show("Fill all fields");
                return;
            }
            var input = $"{BookTitle.Text} Sage: {SageName.Text}";

            if (TypeOfCallOut == "renameButton")
            {
                Form1.EditSelectedItem(input);

                var book = repositoryBook.FindAll(b => b.Title == BookTitle.Text && b.Sages?.FirstOrDefault().Name == SageName.Text).FirstOrDefault();
                book.Title = BookTitle.Text.ToString();
                //book.Sages.FirstOrDefault().Name = SageName.Text.ToString();
                repositoryBook.Update(book);

            }
            else
            {
                Form1.AddItemToListBox(input);
                var book = new Book { Title = BookTitle.Text };
                Sage sage;
                try
                {
                    sage = repositorySage.FindAll(s => s.Name == SageName.Text).First();
                }
                catch (Exception ex) 
                {
                    repositorySage.Add(new Sage { Name = SageName.Text });
                    sage = repositorySage.FindAll(s => s.Name == SageName.Text).First();
                }
                book.Sages.Add(sage);
                repositoryBook.Add(book);
            }
           
            this.Close();
        }

    }
}
