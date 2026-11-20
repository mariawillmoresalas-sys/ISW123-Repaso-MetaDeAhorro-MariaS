namespace ISW123_Repaso_MetaDeAhorro_MariaS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstSalida.Items.Clear();
            decimal ahorro = nudAhorro.Value;       // 1,500
            decimal meta = nudMeta.Value;           // 5,000
            decimal total = 0;
            int meses = 0;

            while (total < meta)
            {
                total += ahorro;
                meses++;
                lstSalida.Items.Add($"Mes {meses}: RD$ {total:N2}");
            }
            lstSalida.Items.Add($"Llegas a la meta en {meses} meses");

        }
    }
}
