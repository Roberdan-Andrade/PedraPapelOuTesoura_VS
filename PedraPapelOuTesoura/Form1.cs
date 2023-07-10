namespace PedraPapelOuTesoura
{
    public partial class Form1 : Form
    {

        public string[] opcoes =
        {
            " PEDRA ",
            " PAPEL ",
            "TESOURA"
        };

        public string[] vencedores =
        {
            "USUARIO",
            "MAQUINA",
            "EMPATE"
        };

        public int jogadaUsuario = 5;
        public int jogada_CPU = 5;

        public int ganhador = 5;

        public Form1()
        {
            InitializeComponent();
        }

        public void Jogada(int I)
        {
            jogadaUsuario = I;

            display_jogador.Text = opcoes[I];

            Jogada_CPU();

            display_maquina.Text = opcoes[jogada_CPU];

            Descobre_ganhador();

            display_ganhador.Text = vencedores[ganhador];
        }

        public void Jogada_CPU()
        {
            Random random = new Random();

            jogada_CPU = random.Next(3);
        }

        public void Descobre_ganhador()
        {
            if(jogadaUsuario == jogada_CPU)
            {
                ganhador = 2;
            } 
            else if((jogadaUsuario == 0 && jogada_CPU == 1) || (jogadaUsuario == 1 && jogada_CPU == 2) || (jogadaUsuario == 2 && jogada_CPU == 0))
            {
                ganhador = 1;
            } 
            else
            {
                ganhador = 0;
            }
        }

        private void btn_Pedra_Click(object sender, EventArgs e)
        {
            Jogada(0);
        }

        private void btn_Papel_Click(object sender, EventArgs e)
        {
            Jogada(1);
        }

        private void btn_Tesoura_Click(object sender, EventArgs e)
        {
            Jogada(2);
        }

        private void display_jogador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
