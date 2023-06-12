namespace ZaverecnaPraceMain;

using ZaverecnaPraceBaseDLL;

abstract public class GameIcon : PictureBox {

    public Form? formInstance;

    public string autorName = "";

    public int index;

    BaseForm baseForm;
    IGameForm? gameForm;

    public GameIcon(BaseForm baseForm, int index, string autorName) {
        this.index = index;
        this.baseForm = baseForm;
        this.autorName = autorName;
        CreateUI(index);
        this.Click += IconClick;
    }

    private void IconClick(object? sender, EventArgs e)
    {
        baseForm.Hide();
        this.ShowGameForm();
    }

    private void CloseFormEvent(object? sender, EventArgs e)
    {
        baseForm.Show();
    }

    public void ShowGameForm() {
        gameForm = CreateGameForm();
        formInstance = gameForm.InitForm(baseForm);
        formInstance.FormClosed += CloseFormEvent;
        formInstance.Show();

        baseForm.activeGameIcon = this; 
    }

    void CreateUI(int index) {
        this.Width = 100;
        this.Height = 80;
        this.Location = GetPositionPoint(index, false);
        this.BackColor = Color.Red;
        this.BackgroundImage = Image.FromFile("assets/exefile.jpg");
        Label iconLabel = GameIconLabel(index);
        baseForm.Controls.Add(this);
        baseForm.Controls.Add(iconLabel); 
        iconLabel.BringToFront();
        this.BringToFront();
    }

    Label GameIconLabel(int index) {
        Label label = new Label();
        label.Text = this.autorName;
        label.Location = GetPositionPoint(index, true);
        label.ForeColor = Color.White;
        label.BackColor = Color.Black;
        label.TextAlign = ContentAlignment.MiddleCenter;
        label.Font = new Font("Arial", 14);
        return label;
    }

    Point GetPositionPoint(int index, bool isLabel) {
        int column = index % 6;
        int row = index / 6;
        if (!isLabel)
            return new Point(85 + column * 125, 40 + row * 140);
        return new Point(85 + column * 125, 140 + row * 140);
    }

    abstract public IGameForm CreateGameForm();
}


public class GameIconKroupa : GameIcon {
    public GameIconKroupa(BaseForm baseForm, int index, string autorName) : base(baseForm, index, autorName) {}

    public override IGameForm CreateGameForm() {
        return new kroupa_zaverecna.Form1();
    }
}

public class GameIconKubec : GameIcon {
    public GameIconKubec(BaseForm baseForm, int index, string autorName) : base(baseForm, index, autorName) {}
    public override IGameForm CreateGameForm()
    {
        return new Kubec.Form1();
    }
}

public class GameIconDan : GameIcon
{
    public GameIconDan(BaseForm baseForm, int index, string autorName) : base(baseForm, index, autorName) {}
    public override IGameForm CreateGameForm()
    {
        return new ZaverecnaPraceUPG_Dan.Menu();
    }
}

public class GameIconPilat : GameIcon
{
    public GameIconPilat(BaseForm baseForm, int index, string autorName) : base(baseForm, index, autorName) {}
    public override IGameForm CreateGameForm()
    {
        return new PilatZavereckaUPG.GameForm();
    }
}

public class GameIconBlazek : GameIcon
{
    public GameIconBlazek(BaseForm baseForm, int index, string autorName) : base(baseForm, index, autorName) {}
    public override IGameForm CreateGameForm()
    {
        return new blazek.Form1();
    }
}

public class GameIconSemrad : GameIcon
{
    public GameIconSemrad(BaseForm baseForm, int index, string autorName) : base(baseForm, index, autorName) {}
    public override IGameForm CreateGameForm()
    {
        return new Pincessss.Form1();
    }
}

public class GameIconJilek : GameIcon
{
    public GameIconJilek(BaseForm baseForm, int index, string autorName) : base(baseForm, index, autorName) {}
    public override IGameForm CreateGameForm()
    {
        return new Projekt.Form1();
    }
}

public class GameIconRomer : GameIcon
{
    public GameIconRomer(BaseForm baseForm, int index, string autorName) : base(baseForm, index, autorName) {}
    public override IGameForm CreateGameForm()
    {
        return new zaverecka_upg_romer.Form1();
    }
}

public class GameIconNovak : GameIcon
{
    public GameIconNovak(BaseForm baseForm, int index, string autorName) : base(baseForm, index, autorName) {}
    public override IGameForm CreateGameForm()
    {
        return new ZaverecnaPraceNovak.Form1();
    }
}

public class GameIconMargetin : GameIcon
{
    public GameIconMargetin(BaseForm baseForm, int index, string autorName) : base(baseForm, index, autorName) {}
    public override IGameForm CreateGameForm()
    {
        return new MargetinPrace.Pexeso();
    }
}

public class GameIconSmrz : GameIcon
{
    public GameIconSmrz(BaseForm baseForm, int index, string autorName) : base(baseForm, index, autorName) {}
    public override IGameForm CreateGameForm()
    {
        return new ZaverecnaPraceSmrz.Menu();
    }
}

public class GameIconVesely : GameIcon
{
    public GameIconVesely(BaseForm baseForm, int index, string autorName) : base(baseForm, index, autorName) {}
    public override IGameForm CreateGameForm()
    {
        return new SchemaPocitace.Form2();
    }
}