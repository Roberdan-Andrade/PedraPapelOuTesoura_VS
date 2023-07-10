namespace PedraPapelOuTesoura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btn_Pedra = new Button();
            btn_Papel = new Button();
            btn_Tesoura = new Button();
            label3 = new Label();
            display_maquina = new TextBox();
            label4 = new Label();
            display_ganhador = new TextBox();
            display_jogador = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 70);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 0;
            label1.Text = "Pedra Papel ou Tesoura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 133);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 1;
            label2.Text = "Qual sua Jogada?";
            // 
            // btn_Pedra
            // 
            btn_Pedra.Location = new Point(194, 183);
            btn_Pedra.Name = "btn_Pedra";
            btn_Pedra.Size = new Size(112, 34);
            btn_Pedra.TabIndex = 2;
            btn_Pedra.Text = "Pedra";
            btn_Pedra.UseVisualStyleBackColor = true;
            btn_Pedra.Click += btn_Pedra_Click;
            // 
            // btn_Papel
            // 
            btn_Papel.Location = new Point(329, 183);
            btn_Papel.Name = "btn_Papel";
            btn_Papel.Size = new Size(112, 34);
            btn_Papel.TabIndex = 3;
            btn_Papel.Text = "Papel";
            btn_Papel.UseVisualStyleBackColor = true;
            btn_Papel.Click += btn_Papel_Click;
            // 
            // btn_Tesoura
            // 
            btn_Tesoura.Location = new Point(463, 183);
            btn_Tesoura.Name = "btn_Tesoura";
            btn_Tesoura.Size = new Size(112, 34);
            btn_Tesoura.TabIndex = 4;
            btn_Tesoura.Text = "Tesoura";
            btn_Tesoura.UseVisualStyleBackColor = true;
            btn_Tesoura.Click += btn_Tesoura_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 294);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 5;
            label3.Text = "Jogada da Maquina:";
            // 
            // display_maquina
            // 
            display_maquina.Location = new Point(268, 322);
            display_maquina.Name = "display_maquina";
            display_maquina.Size = new Size(254, 31);
            display_maquina.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 386);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 7;
            label4.Text = "Ganhador:";
            // 
            // display_ganhador
            // 
            display_ganhador.Location = new Point(268, 414);
            display_ganhador.Name = "display_ganhador";
            display_ganhador.Size = new Size(254, 31);
            display_ganhador.TabIndex = 8;
            // 
            // display_jogador
            // 
            display_jogador.Location = new Point(268, 236);
            display_jogador.Name = "display_jogador";
            display_jogador.Size = new Size(254, 31);
            display_jogador.TabIndex = 9;
            display_jogador.TextChanged += display_jogador_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 746);
            Controls.Add(display_jogador);
            Controls.Add(display_ganhador);
            Controls.Add(label4);
            Controls.Add(display_maquina);
            Controls.Add(label3);
            Controls.Add(btn_Tesoura);
            Controls.Add(btn_Papel);
            Controls.Add(btn_Pedra);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_Pedra;
        private Button btn_Papel;
        private Button btn_Tesoura;
        private Label label3;
        private TextBox display_maquina;
        private Label label4;
        private TextBox display_ganhador;
        private TextBox display_jogador;
    }
}