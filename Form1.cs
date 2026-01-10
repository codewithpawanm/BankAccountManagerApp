namespace AccountManageApp
{
    public partial class Form1 : Form //Form1 is also a class
    {
        public Form1() //This is special type of method called constructor
        {
            InitializeComponent();
            //BankAccount bankAccount = new BankAccount("Pawan", Guid.NewGuid(), 0); //remove guid, 0 because it is constant, will handle from constructot
            BankAccount bankAccount = new BankAccount("Pawan"); //remove guid, 0 because it is constant, will handle from constructot
            //bankAccount.Owner = "Pawan";
            //bankAccount.AccountNumber = Guid.NewGuid();
            //bankAccount.Balance = 300;
            BankAccount bankAccount2 = new BankAccount("Pandey");

            //BankAccount bankAccount2 = new BankAccount();
            //bankAccount2.Owner = "Pandey";
            //bankAccount2.AccountNumber = Guid.NewGuid();
            //bankAccount2.Balance = 304;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);

            BankAccountsGrid.DataSource = bankAccounts;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
