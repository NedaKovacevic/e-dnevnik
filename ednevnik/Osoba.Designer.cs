namespace ednevnik
{
    partial class Osoba
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtJmbg = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUloga = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrez = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUloga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(55, 777);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(148, 53);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(231, 777);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(148, 53);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(422, 777);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 53);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(596, 777);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 53);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "promeni";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(778, 777);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(148, 53);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "obrisi";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(957, 777);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(148, 53);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(1141, 777);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(148, 53);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(596, 77);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(355, 38);
            this.txtId.TabIndex = 7;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(596, 145);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(355, 38);
            this.txtIme.TabIndex = 8;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(596, 222);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(355, 38);
            this.txtPrezime.TabIndex = 9;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(596, 301);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(355, 38);
            this.txtAdresa.TabIndex = 10;
            // 
            // txtJmbg
            // 
            this.txtJmbg.Location = new System.Drawing.Point(596, 383);
            this.txtJmbg.Name = "txtJmbg";
            this.txtJmbg.Size = new System.Drawing.Size(355, 38);
            this.txtJmbg.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(596, 460);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(355, 38);
            this.txtMail.TabIndex = 12;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(596, 540);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(355, 38);
            this.txtPass.TabIndex = 13;
            // 
            // txtUloga
            // 
            this.txtUloga.Location = new System.Drawing.Point(596, 627);
            this.txtUloga.Name = "txtUloga";
            this.txtUloga.Size = new System.Drawing.Size(355, 38);
            this.txtUloga.TabIndex = 14;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(416, 83);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(42, 32);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "ID";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(416, 148);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(61, 32);
            this.lblIme.TabIndex = 16;
            this.lblIme.Text = "Ime";
            // 
            // lblPrez
            // 
            this.lblPrez.AutoSize = true;
            this.lblPrez.Location = new System.Drawing.Point(416, 225);
            this.lblPrez.Name = "lblPrez";
            this.lblPrez.Size = new System.Drawing.Size(119, 32);
            this.lblPrez.TabIndex = 17;
            this.lblPrez.Text = "Prezime";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(416, 304);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(105, 32);
            this.lblAdresa.TabIndex = 18;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Location = new System.Drawing.Point(416, 389);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(93, 32);
            this.lblJmbg.TabIndex = 19;
            this.lblJmbg.Text = "JMBG";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(416, 463);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(68, 32);
            this.lblMail.TabIndex = 20;
            this.lblMail.Text = "Mail";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(416, 543);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(139, 32);
            this.lblPass.TabIndex = 21;
            this.lblPass.Text = "Password";
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Location = new System.Drawing.Point(416, 630);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(90, 32);
            this.lblUloga.TabIndex = 22;
            this.lblUloga.Text = "Uloga";
            // 
            // Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 938);
            this.Controls.Add(this.lblUloga);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblJmbg);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblPrez);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtUloga);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtJmbg);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Name = "Osoba";
            this.Text = "Osoba";
            this.Load += new System.EventHandler(this.Osoba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtJmbg;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUloga;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrez;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUloga;
    }
}

