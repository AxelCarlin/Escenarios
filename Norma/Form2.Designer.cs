namespace Norma
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            lblTitle = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            lblControles = new Label();
            checkBox1 = new CheckBox();
            progressBar1 = new ProgressBar();
            groupBox1 = new GroupBox();
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            gpbEncenderApagar = new GroupBox();
            chlEncendidoApagado = new CheckedListBox();
            panel2 = new Panel();
            pnlHabitacionCuatroUno = new Panel();
            pnlHabitacionCinco = new Panel();
            pnlHabitacionSeis = new Panel();
            pnlHabitacionCuatroDos = new Panel();
            pnlHabitacionTres = new Panel();
            pnlHabitacionDos = new Panel();
            pnlHabitacionUno = new Panel();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            lblControles2 = new Label();
            checkBox2 = new CheckBox();
            progressBar2 = new ProgressBar();
            groupBox4 = new GroupBox();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            button4 = new Button();
            groupBox5 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            panel3 = new Panel();
            pnlE2H41 = new Panel();
            pnlE2H5 = new Panel();
            pnlE2H6 = new Panel();
            pnlE2H42 = new Panel();
            pnlE2H3 = new Panel();
            pnlE2H2 = new Panel();
            pnlE2H1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            gpbEncenderApagar.SuspendLayout();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 683);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe Print", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(11, 46);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(291, 57);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Panel de control";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(306, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1231, 683);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkGray;
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(gpbEncenderApagar);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1223, 655);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(lblControles);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(827, 427);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(289, 202);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controladores";
            // 
            // lblControles
            // 
            lblControles.AutoSize = true;
            lblControles.Location = new Point(95, 130);
            lblControles.Name = "lblControles";
            lblControles.Size = new Size(103, 23);
            lblControles.TabIndex = 4;
            lblControles.Text = "Desactivados";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(106, 71);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 27);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "on / off";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(26, 104);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(239, 23);
            progressBar1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(827, 251);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 152);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Indicadores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 100);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 3;
            label2.Text = "Encendido";
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(26, 97);
            button2.Name = "button2";
            button2.Size = new Size(31, 28);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 48);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 1;
            label1.Text = "Apagado";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(26, 45);
            button1.Name = "button1";
            button1.Size = new Size(31, 28);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // gpbEncenderApagar
            // 
            gpbEncenderApagar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gpbEncenderApagar.BackColor = Color.White;
            gpbEncenderApagar.Controls.Add(chlEncendidoApagado);
            gpbEncenderApagar.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbEncenderApagar.Location = new Point(827, 25);
            gpbEncenderApagar.Name = "gpbEncenderApagar";
            gpbEncenderApagar.Size = new Size(289, 202);
            gpbEncenderApagar.TabIndex = 1;
            gpbEncenderApagar.TabStop = false;
            gpbEncenderApagar.Text = "Encender/Apagar Luz";
            // 
            // chlEncendidoApagado
            // 
            chlEncendidoApagado.FormattingEnabled = true;
            chlEncendidoApagado.Items.AddRange(new object[] { "Habitacion 1", "Habitacion 2", "Habitacion 3", "Habitacion 4", "Habitacion 5", "Habitacion 6" });
            chlEncendidoApagado.Location = new Point(6, 32);
            chlEncendidoApagado.Name = "chlEncendidoApagado";
            chlEncendidoApagado.Size = new Size(277, 148);
            chlEncendidoApagado.TabIndex = 0;
            chlEncendidoApagado.ItemCheck += chlEncendidoApagado_ItemCheck;
            chlEncendidoApagado.SelectedIndexChanged += chlEncendidoApagado_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pnlHabitacionCuatroUno);
            panel2.Controls.Add(pnlHabitacionCinco);
            panel2.Controls.Add(pnlHabitacionSeis);
            panel2.Controls.Add(pnlHabitacionCuatroDos);
            panel2.Controls.Add(pnlHabitacionTres);
            panel2.Controls.Add(pnlHabitacionDos);
            panel2.Controls.Add(pnlHabitacionUno);
            panel2.Location = new Point(2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(718, 649);
            panel2.TabIndex = 0;
            // 
            // pnlHabitacionCuatroUno
            // 
            pnlHabitacionCuatroUno.BackColor = Color.Black;
            pnlHabitacionCuatroUno.Location = new Point(38, 311);
            pnlHabitacionCuatroUno.Name = "pnlHabitacionCuatroUno";
            pnlHabitacionCuatroUno.Size = new Size(210, 121);
            pnlHabitacionCuatroUno.TabIndex = 5;
            // 
            // pnlHabitacionCinco
            // 
            pnlHabitacionCinco.BackColor = Color.Black;
            pnlHabitacionCinco.Location = new Point(38, 438);
            pnlHabitacionCinco.Name = "pnlHabitacionCinco";
            pnlHabitacionCinco.Size = new Size(100, 177);
            pnlHabitacionCinco.TabIndex = 5;
            // 
            // pnlHabitacionSeis
            // 
            pnlHabitacionSeis.BackColor = Color.Black;
            pnlHabitacionSeis.Location = new Point(144, 438);
            pnlHabitacionSeis.Name = "pnlHabitacionSeis";
            pnlHabitacionSeis.Size = new Size(97, 177);
            pnlHabitacionSeis.TabIndex = 4;
            // 
            // pnlHabitacionCuatroDos
            // 
            pnlHabitacionCuatroDos.BackColor = Color.Black;
            pnlHabitacionCuatroDos.Location = new Point(247, 311);
            pnlHabitacionCuatroDos.Name = "pnlHabitacionCuatroDos";
            pnlHabitacionCuatroDos.Size = new Size(446, 304);
            pnlHabitacionCuatroDos.TabIndex = 3;
            // 
            // pnlHabitacionTres
            // 
            pnlHabitacionTres.BackColor = Color.Black;
            pnlHabitacionTres.Location = new Point(435, 33);
            pnlHabitacionTres.Name = "pnlHabitacionTres";
            pnlHabitacionTres.Size = new Size(218, 272);
            pnlHabitacionTres.TabIndex = 2;
            // 
            // pnlHabitacionDos
            // 
            pnlHabitacionDos.BackColor = Color.Black;
            pnlHabitacionDos.Location = new Point(248, 33);
            pnlHabitacionDos.Name = "pnlHabitacionDos";
            pnlHabitacionDos.Size = new Size(182, 272);
            pnlHabitacionDos.TabIndex = 1;
            // 
            // pnlHabitacionUno
            // 
            pnlHabitacionUno.BackColor = Color.Black;
            pnlHabitacionUno.Location = new Point(38, 33);
            pnlHabitacionUno.Name = "pnlHabitacionUno";
            pnlHabitacionUno.Size = new Size(206, 272);
            pnlHabitacionUno.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1223, 655);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lblControles2);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(progressBar2);
            groupBox3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(825, 424);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(289, 202);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Controladores";
            // 
            // lblControles2
            // 
            lblControles2.AutoSize = true;
            lblControles2.Location = new Point(95, 130);
            lblControles2.Name = "lblControles2";
            lblControles2.Size = new Size(103, 23);
            lblControles2.TabIndex = 4;
            lblControles2.Text = "Desactivados";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(106, 71);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(74, 27);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "on / off";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(26, 104);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(239, 23);
            progressBar2.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(button4);
            groupBox4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(825, 248);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(289, 152);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Indicadores";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 100);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 3;
            label4.Text = "Encendido";
            // 
            // button3
            // 
            button3.BackColor = Color.BlueViolet;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(26, 97);
            button3.Name = "button3";
            button3.Size = new Size(31, 28);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 48);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 1;
            label5.Text = "Apagado";
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(26, 45);
            button4.Name = "button4";
            button4.Size = new Size(31, 28);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(checkedListBox1);
            groupBox5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(825, 22);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(289, 202);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Encender/Apagar Clima";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Habitacion 1", "Habitacion 2", "Habitacion 3", "Habitacion 4", "Habitacion 5", "Habitacion 6" });
            checkedListBox1.Location = new Point(6, 32);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(277, 148);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(pnlE2H41);
            panel3.Controls.Add(pnlE2H5);
            panel3.Controls.Add(pnlE2H6);
            panel3.Controls.Add(pnlE2H42);
            panel3.Controls.Add(pnlE2H3);
            panel3.Controls.Add(pnlE2H2);
            panel3.Controls.Add(pnlE2H1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(718, 649);
            panel3.TabIndex = 5;
            // 
            // pnlE2H41
            // 
            pnlE2H41.BackColor = Color.OrangeRed;
            pnlE2H41.Location = new Point(38, 311);
            pnlE2H41.Name = "pnlE2H41";
            pnlE2H41.Size = new Size(210, 121);
            pnlE2H41.TabIndex = 5;
            // 
            // pnlE2H5
            // 
            pnlE2H5.BackColor = Color.OrangeRed;
            pnlE2H5.Location = new Point(38, 438);
            pnlE2H5.Name = "pnlE2H5";
            pnlE2H5.Size = new Size(100, 177);
            pnlE2H5.TabIndex = 5;
            // 
            // pnlE2H6
            // 
            pnlE2H6.BackColor = Color.OrangeRed;
            pnlE2H6.Location = new Point(144, 438);
            pnlE2H6.Name = "pnlE2H6";
            pnlE2H6.Size = new Size(97, 177);
            pnlE2H6.TabIndex = 4;
            // 
            // pnlE2H42
            // 
            pnlE2H42.BackColor = Color.OrangeRed;
            pnlE2H42.Location = new Point(247, 311);
            pnlE2H42.Name = "pnlE2H42";
            pnlE2H42.Size = new Size(446, 304);
            pnlE2H42.TabIndex = 3;
            // 
            // pnlE2H3
            // 
            pnlE2H3.BackColor = Color.OrangeRed;
            pnlE2H3.Location = new Point(435, 33);
            pnlE2H3.Name = "pnlE2H3";
            pnlE2H3.Size = new Size(218, 272);
            pnlE2H3.TabIndex = 2;
            // 
            // pnlE2H2
            // 
            pnlE2H2.BackColor = Color.OrangeRed;
            pnlE2H2.Location = new Point(248, 33);
            pnlE2H2.Name = "pnlE2H2";
            pnlE2H2.Size = new Size(182, 272);
            pnlE2H2.TabIndex = 1;
            // 
            // pnlE2H1
            // 
            pnlE2H1.BackColor = Color.OrangeRed;
            pnlE2H1.Location = new Point(38, 33);
            pnlE2H1.Name = "pnlE2H1";
            pnlE2H1.Size = new Size(206, 272);
            pnlE2H1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 679);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gpbEncenderApagar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblTitle;
        private Panel panel2;
        private Panel pnlHabitacionCuatroUno;
        private Panel pnlHabitacionCinco;
        private Panel pnlHabitacionSeis;
        private Panel pnlHabitacionCuatroDos;
        private Panel pnlHabitacionTres;
        private Panel pnlHabitacionDos;
        private Panel pnlHabitacionUno;
        private GroupBox gpbEncenderApagar;
        private CheckedListBox chlEncendidoApagado;
        private GroupBox groupBox1;
        private Label label2;
        private Button button2;
        private Label label1;
        private Button button1;
        private GroupBox groupBox2;
        private Label lblControles;
        private CheckBox checkBox1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox3;
        private Label lblControles2;
        private CheckBox checkBox2;
        private ProgressBar progressBar2;
        private GroupBox groupBox4;
        private Label label4;
        private Button button3;
        private Label label5;
        private Button button4;
        private GroupBox groupBox5;
        private CheckedListBox checkedListBox1;
        private Panel panel3;
        private Panel pnlE2H41;
        private Panel pnlE2H5;
        private Panel pnlE2H6;
        private Panel pnlE2H42;
        private Panel pnlE2H3;
        private Panel pnlE2H2;
        private Panel pnlE2H1;
        private System.Windows.Forms.Timer timer2;
    }
}