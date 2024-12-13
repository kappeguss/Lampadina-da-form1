namespace es_pre_interrogazioni
{
    public partial class Form1 : Form
    {
        Label label1 = new Label();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label1.Text = "lampadina";
            label1.Location = new Point(370, 100);
            this.Controls.Add(label1);

            Button accendi = new Button();
            Button spegni = new Button();
            accendi.Text = "ACCENDI";
            spegni.Text = "SPEGNI";
            accendi.Size = new Size(200, 100);
            spegni.Size = new Size(200, 100);
            accendi.Location = new Point((ClientSize.Width / 2 - accendi.Size.Width / 2), (ClientSize.Height / 2 - spegni.Size.Height / 2));
            spegni.Location = new Point((ClientSize.Width / 2 - accendi.Size.Width / 2), (ClientSize.Height / 2 - spegni.Size.Height / 2 + 150));
            this.Controls.Add(accendi);
            this.Controls.Add(spegni);

            accendi.Click += accendi_Click;
            spegni.Click += spegni_Click;
        }

        private void spegni_Click(object sender, EventArgs e )
        {
            
            label1.Visible = false;
       
        }

        private void accendi_Click(object sender, EventArgs e)
        {
            label1.Show();

        }

    }
}
