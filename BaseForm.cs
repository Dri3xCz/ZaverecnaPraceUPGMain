using ZaverecnaPraceBaseDLL;

namespace ZaverecnaPraceMain
{
    public partial class BaseForm : Form, IMainForm
    {
        public GameIcon? activeGameIcon;

        char[] password;
        int charactersFound = 0;

        GameIcon[] allGameIcons;

        public BaseForm()
        {
            InitializeComponent();
            allGameIcons = InitializeGameIconArray();
            password = new char[allGameIcons.Count()];
        }

        GameIcon[] InitializeGameIconArray()
        {
            GameIcon[] gameIconArray = {
                new GameIconKubec(this, 0, "Kubec"),
                new GameIconKroupa(this, 1, "Kroupa"),
                new GameIconPilat(this, 2, "Pilát"),
                new GameIconDan(this, 3, "Brix"),
                new GameIconBlazek(this, 4, "Blažek"),
                new GameIconSemrad(this, 5, "Semrád"),
                new GameIconJilek(this, 6, "Jílek"),
                new GameIconRomer(this, 7, "Romer"), 
                new GameIconNovak(this, 8, "Novák"),
                new GameIconMargetin(this, 9, "Margetin"),
                new GameIconSmrz(this, 10, "Smrž"),
                new GameIconVesely(this, 11, "Veselý"),
            };
            return gameIconArray;
        }

        public void SendData(char c)
        {
            if (activeGameIcon == null)
                return;
            if (activeGameIcon.formInstance == null)
                return;

            activeGameIcon.formInstance.Close();
            SetPasswordChar(c, activeGameIcon.index);
            MessageBox.Show("Charakter: " + c + ", Na Indexu: " + activeGameIcon.index);
        }

        void SetPasswordChar(char c, int index)
        {
            if (password[index] == c)
                return;
            password[index] = c;
            charactersFound++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(charactersFound != allGameIcons.Count())
                return;
            if(passwordBox.Text == string.Empty)
                return;
            if(passwordBox.Text.Count() != allGameIcons.Count())
            {
                MessageBox.Show("Špatné heslo");
                return;
            }


            for (int i = 0; i < password.Length; i++) {
                if (passwordBox.Text[i] != password[i]) {
                    MessageBox.Show("Špatné heslo");
                    return;
                }
            }
            MessageBox.Show("Správné heslo! Gratuluji k vítěztví, nyní okno můžete zavřít nebo si hry zopakovat");
        }
    }
}