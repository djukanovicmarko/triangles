namespace Domaci2
{
    partial class Form1
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
            this.rbJednakostranicni = new System.Windows.Forms.RadioButton();
            this.rbJednakokraki = new System.Windows.Forms.RadioButton();
            this.rbRaznostranicni = new System.Windows.Forms.RadioButton();
            this.StranicaAlbl = new System.Windows.Forms.Label();
            this.StranicaBlbl = new System.Windows.Forms.Label();
            this.StranicaClbl = new System.Windows.Forms.Label();
            this.StranicaAtxt = new System.Windows.Forms.TextBox();
            this.StranicaBtxt = new System.Windows.Forms.TextBox();
            this.StranicaCtxt = new System.Windows.Forms.TextBox();
            this.Visinahlbl = new System.Windows.Forms.Label();
            this.Visinahtxt = new System.Windows.Forms.TextBox();
            this.Izracunajbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbJednakostranicni
            // 
            this.rbJednakostranicni.AutoSize = true;
            this.rbJednakostranicni.Checked = true;
            this.rbJednakostranicni.Location = new System.Drawing.Point(60, 13);
            this.rbJednakostranicni.Name = "rbJednakostranicni";
            this.rbJednakostranicni.Size = new System.Drawing.Size(144, 17);
            this.rbJednakostranicni.TabIndex = 0;
            this.rbJednakostranicni.TabStop = true;
            this.rbJednakostranicni.Text = "Jednakostranicni trougao";
            this.rbJednakostranicni.UseVisualStyleBackColor = true;
            this.rbJednakostranicni.CheckedChanged += new System.EventHandler(this.rbJednakostranicni_CheckedChanged);
            // 
            // rbJednakokraki
            // 
            this.rbJednakokraki.AutoSize = true;
            this.rbJednakokraki.Location = new System.Drawing.Point(60, 37);
            this.rbJednakokraki.Name = "rbJednakokraki";
            this.rbJednakokraki.Size = new System.Drawing.Size(128, 17);
            this.rbJednakokraki.TabIndex = 1;
            this.rbJednakokraki.Text = "Jednakokraki trougao";
            this.rbJednakokraki.UseVisualStyleBackColor = true;
            this.rbJednakokraki.CheckedChanged += new System.EventHandler(this.rbJednakokraki_CheckedChanged);
            // 
            // rbRaznostranicni
            // 
            this.rbRaznostranicni.AutoSize = true;
            this.rbRaznostranicni.Location = new System.Drawing.Point(60, 61);
            this.rbRaznostranicni.Name = "rbRaznostranicni";
            this.rbRaznostranicni.Size = new System.Drawing.Size(134, 17);
            this.rbRaznostranicni.TabIndex = 2;
            this.rbRaznostranicni.Text = "Raznostranicni trougao";
            this.rbRaznostranicni.UseVisualStyleBackColor = true;
            this.rbRaznostranicni.CheckedChanged += new System.EventHandler(this.rbRaznostranicni_CheckedChanged);
            // 
            // StranicaAlbl
            // 
            this.StranicaAlbl.AutoSize = true;
            this.StranicaAlbl.Location = new System.Drawing.Point(16, 96);
            this.StranicaAlbl.Name = "StranicaAlbl";
            this.StranicaAlbl.Size = new System.Drawing.Size(59, 13);
            this.StranicaAlbl.TabIndex = 3;
            this.StranicaAlbl.Text = "Stranica A:";
            // 
            // StranicaBlbl
            // 
            this.StranicaBlbl.AutoSize = true;
            this.StranicaBlbl.Location = new System.Drawing.Point(16, 131);
            this.StranicaBlbl.Name = "StranicaBlbl";
            this.StranicaBlbl.Size = new System.Drawing.Size(59, 13);
            this.StranicaBlbl.TabIndex = 4;
            this.StranicaBlbl.Text = "Stranica B:";
            // 
            // StranicaClbl
            // 
            this.StranicaClbl.AutoSize = true;
            this.StranicaClbl.Location = new System.Drawing.Point(16, 166);
            this.StranicaClbl.Name = "StranicaClbl";
            this.StranicaClbl.Size = new System.Drawing.Size(59, 13);
            this.StranicaClbl.TabIndex = 5;
            this.StranicaClbl.Text = "Stranica C:";
            // 
            // StranicaAtxt
            // 
            this.StranicaAtxt.Location = new System.Drawing.Point(104, 96);
            this.StranicaAtxt.Name = "StranicaAtxt";
            this.StranicaAtxt.Size = new System.Drawing.Size(100, 20);
            this.StranicaAtxt.TabIndex = 6;
            // 
            // StranicaBtxt
            // 
            this.StranicaBtxt.Location = new System.Drawing.Point(104, 131);
            this.StranicaBtxt.Name = "StranicaBtxt";
            this.StranicaBtxt.Size = new System.Drawing.Size(100, 20);
            this.StranicaBtxt.TabIndex = 7;
            // 
            // StranicaCtxt
            // 
            this.StranicaCtxt.Location = new System.Drawing.Point(104, 166);
            this.StranicaCtxt.Name = "StranicaCtxt";
            this.StranicaCtxt.Size = new System.Drawing.Size(100, 20);
            this.StranicaCtxt.TabIndex = 8;
            // 
            // Visinahlbl
            // 
            this.Visinahlbl.AutoSize = true;
            this.Visinahlbl.Location = new System.Drawing.Point(19, 207);
            this.Visinahlbl.Name = "Visinahlbl";
            this.Visinahlbl.Size = new System.Drawing.Size(47, 13);
            this.Visinahlbl.TabIndex = 12;
            this.Visinahlbl.Text = "Visina h:";
            // 
            // Visinahtxt
            // 
            this.Visinahtxt.Location = new System.Drawing.Point(104, 200);
            this.Visinahtxt.Name = "Visinahtxt";
            this.Visinahtxt.Size = new System.Drawing.Size(100, 20);
            this.Visinahtxt.TabIndex = 13;
            // 
            // Izracunajbtn
            // 
            this.Izracunajbtn.Location = new System.Drawing.Point(89, 252);
            this.Izracunajbtn.Name = "Izracunajbtn";
            this.Izracunajbtn.Size = new System.Drawing.Size(75, 23);
            this.Izracunajbtn.TabIndex = 14;
            this.Izracunajbtn.Text = "Izracunaj";
            this.Izracunajbtn.UseVisualStyleBackColor = true;
            this.Izracunajbtn.Click += new System.EventHandler(this.Izracunajbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 297);
            this.Controls.Add(this.Izracunajbtn);
            this.Controls.Add(this.Visinahtxt);
            this.Controls.Add(this.Visinahlbl);
            this.Controls.Add(this.StranicaCtxt);
            this.Controls.Add(this.StranicaBtxt);
            this.Controls.Add(this.StranicaAtxt);
            this.Controls.Add(this.StranicaClbl);
            this.Controls.Add(this.StranicaBlbl);
            this.Controls.Add(this.StranicaAlbl);
            this.Controls.Add(this.rbRaznostranicni);
            this.Controls.Add(this.rbJednakokraki);
            this.Controls.Add(this.rbJednakostranicni);
            this.Name = "Form1";
            this.Text = "Izracunavanje povrsine i obima trouglova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbJednakostranicni;
        private System.Windows.Forms.RadioButton rbJednakokraki;
        private System.Windows.Forms.RadioButton rbRaznostranicni;
        private System.Windows.Forms.Label StranicaAlbl;
        private System.Windows.Forms.Label StranicaBlbl;
        private System.Windows.Forms.Label StranicaClbl;
        private System.Windows.Forms.TextBox StranicaAtxt;
        private System.Windows.Forms.TextBox StranicaBtxt;
        private System.Windows.Forms.TextBox StranicaCtxt;
        private System.Windows.Forms.Label Visinahlbl;
        private System.Windows.Forms.TextBox Visinahtxt;
        private System.Windows.Forms.Button Izracunajbtn;
    }
}

