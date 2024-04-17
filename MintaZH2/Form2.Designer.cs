namespace MintaZH2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            versenyzoBindingSource = new BindingSource(components);
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)versenyzoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("DataContext", versenyzoBindingSource, "VersenyzoID", true));
            textBox1.DataBindings.Add(new Binding("Text", versenyzoBindingSource, "VersenyzoID", true));
            textBox1.Location = new Point(40, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(448, 39);
            textBox1.TabIndex = 0;
            // 
            // versenyzoBindingSource
            // 
            versenyzoBindingSource.DataSource = typeof(Versenyzo);
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(201, 671);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "&OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 78);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 2;
            label1.Text = "Azonosító";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 177);
            label2.Name = "label2";
            label2.Size = new Size(57, 32);
            label2.TabIndex = 3;
            label2.Text = "Név";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", versenyzoBindingSource, "Nev", true));
            textBox2.Location = new Point(40, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(448, 39);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 283);
            label3.Name = "label3";
            label3.Size = new Size(141, 32);
            label3.TabIndex = 5;
            label3.Text = "Nemzetiség";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", versenyzoBindingSource, "Nemzetiseg", true));
            textBox3.Location = new Point(40, 318);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(448, 39);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 386);
            label4.Name = "label4";
            label4.Size = new Size(121, 32);
            label4.TabIndex = 7;
            label4.Text = "Eredmény";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", versenyzoBindingSource, "EredmenyPerc", true));
            textBox4.Location = new Point(40, 421);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(448, 39);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", versenyzoBindingSource, "Kategoria", true));
            textBox5.Location = new Point(40, 528);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(448, 39);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 493);
            label5.Name = "label5";
            label5.Size = new Size(115, 32);
            label5.TabIndex = 10;
            label5.Text = "Kategória";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 729);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Új sor";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)versenyzoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private BindingSource versenyzoBindingSource;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
    }
}