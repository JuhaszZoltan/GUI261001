namespace GUI261001;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
        btnBlueFG.Click += BtnBlueFG_Click;
        btnWhiteBG.Click += BtnWhiteBG_Click;
        btnMiddleCenter.Click += BtnMiddleCenter_Click;
        btnMiddleLeft.Click += BtnMiddleLeft_Click;
        btnMiddleRight.Click += BtnMiddleRight_Click;
        btnDelete.Click += BtnDelete_Click;
        btnUpperCase.Click += BtnUpperCase_Click;
        btnFontPlus.Click += BtnFontPlus_Click;
        btnFontMinus.Click += BtnFontMinus_Click;
        btnReset.Click += BtnReset_Click;
        btnExit.Click += BtnExit_Click;
    }

    private void BtnExit_Click(object? sender, EventArgs e)
        => Application.Exit();

    private void BtnReset_Click(object? sender, EventArgs e)
    {
        lblText.ForeColor = Color.Black;
        lblText.BackColor = Color.LightGray;
        lblText.Font = new("Segoe", 20F);
        lblText.TextAlign = ContentAlignment.TopLeft;
        lblText.Text = "Hello, World!";
    }

    private void BtnFontMinus_Click(object? sender, EventArgs e)
    {
        float emsize = lblText.Font.Size - 2;
        if (emsize <= 0) return;
        lblText.Font = new("Segoe", emsize);
    }

    private void BtnFontPlus_Click(object? sender, EventArgs e)
        => lblText.Font = new("Segoe", lblText.Font.Size + 2);

    private void BtnUpperCase_Click(object? sender, EventArgs e)
        => lblText.Text = lblText.Text.ToUpper();

    private void BtnDelete_Click(object? sender, EventArgs e)
        => lblText.Text = lblText.Text[..(lblText.Text.Length-1)];

    private void BtnMiddleRight_Click(object? sender, EventArgs e)
        => lblText.TextAlign = ContentAlignment.MiddleRight;

    private void BtnMiddleLeft_Click(object? sender, EventArgs e)
        => lblText.TextAlign = ContentAlignment.MiddleLeft;

    private void BtnMiddleCenter_Click(object? sender, EventArgs e)
        => lblText.TextAlign = ContentAlignment.MiddleCenter;

    private void BtnWhiteBG_Click(object? sender, EventArgs e)
        => lblText.BackColor = Color.White;

    private void BtnBlueFG_Click(object? sender, EventArgs e)
        => lblText.ForeColor = Color.Blue;
}

