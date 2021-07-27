using PS.GlavnoOkno.UI.Base.Kontrole;


namespace WfProjekt
{
    partial class FrmTest
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.txtOznakaValute = new PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS();
            this.btnInsertInfo = new System.Windows.Forms.Button();
            this.btnSendInfo = new System.Windows.Forms.Button();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.txtNamen = new PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS();
            this.txtHisnaStevilka = new PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS();
            this.txtIme = new PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS();
            this.txtZnesekPostnine = new PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS();
            this.txtVrednost = new PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS();
            this.txtDelovnoMestoID = new PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS();
            this.txtPostaID = new PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS();
            this.txtStevilkaRacuna = new PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS();
            this.lblNamen = new PS.GlavnoOkno.UI.Base.Kontrole.LabelPS();
            this.lblHisnaStevilka = new PS.GlavnoOkno.UI.Base.Kontrole.LabelPS();
            this.lblIme = new PS.GlavnoOkno.UI.Base.Kontrole.LabelPS();
            this.lblZnesekPostnine = new PS.GlavnoOkno.UI.Base.Kontrole.LabelPS();
            this.lblVrednost = new PS.GlavnoOkno.UI.Base.Kontrole.LabelPS();
            this.lblUporabnikID = new PS.GlavnoOkno.UI.Base.Kontrole.LabelPS();
            this.lblDelovnoMestoID = new PS.GlavnoOkno.UI.Base.Kontrole.LabelPS();
            this.lblPostaID = new PS.GlavnoOkno.UI.Base.Kontrole.LabelPS();
            this.lblStevilkaRacuna = new PS.GlavnoOkno.UI.Base.Kontrole.LabelPS();
            this.txtUporabnikID = new PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContent.Controls.Add(this.txtOznakaValute);
            this.pnlContent.Controls.Add(this.btnInsertInfo);
            this.pnlContent.Controls.Add(this.btnSendInfo);
            this.pnlContent.Controls.Add(this.btnGetInfo);
            this.pnlContent.Controls.Add(this.txtNamen);
            this.pnlContent.Controls.Add(this.txtHisnaStevilka);
            this.pnlContent.Controls.Add(this.txtIme);
            this.pnlContent.Controls.Add(this.txtZnesekPostnine);
            this.pnlContent.Controls.Add(this.txtVrednost);
            this.pnlContent.Controls.Add(this.txtUporabnikID);
            this.pnlContent.Controls.Add(this.txtDelovnoMestoID);
            this.pnlContent.Controls.Add(this.txtPostaID);
            this.pnlContent.Controls.Add(this.txtStevilkaRacuna);
            this.pnlContent.Controls.Add(this.lblNamen);
            this.pnlContent.Controls.Add(this.lblHisnaStevilka);
            this.pnlContent.Controls.Add(this.lblIme);
            this.pnlContent.Controls.Add(this.lblZnesekPostnine);
            this.pnlContent.Controls.Add(this.lblVrednost);
            this.pnlContent.Controls.Add(this.lblUporabnikID);
            this.pnlContent.Controls.Add(this.lblDelovnoMestoID);
            this.pnlContent.Controls.Add(this.lblPostaID);
            this.pnlContent.Controls.Add(this.lblStevilkaRacuna);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 299);
            this.pnlContent.TabIndex = 0;
            // 
            // txtOznakaValute
            // 
            this.txtOznakaValute.BackColor = System.Drawing.SystemColors.Window;
            this.txtOznakaValute.DisplayMode = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputDisplayMode.Undefined;
            this.txtOznakaValute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOznakaValute.Location = new System.Drawing.Point(510, 132);
            this.txtOznakaValute.MaxLength = 16;
            this.txtOznakaValute.Name = "txtOznakaValute";
            this.txtOznakaValute.Obvezno = false;
            this.txtOznakaValute.PaddingLength = 5;
            this.txtOznakaValute.Size = new System.Drawing.Size(88, 28);
            this.txtOznakaValute.TabIndex = 21;
            this.txtOznakaValute.TrueMultiline = false;
            this.txtOznakaValute.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputValueType.Undefined;
            // 
            // btnInsertInfo
            // 
            this.btnInsertInfo.Location = new System.Drawing.Point(659, 213);
            this.btnInsertInfo.Name = "btnInsertInfo";
            this.btnInsertInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInsertInfo.TabIndex = 20;
            this.btnInsertInfo.Text = "Insert info";
            this.btnInsertInfo.UseVisualStyleBackColor = true;
            this.btnInsertInfo.Click += new System.EventHandler(this.btnInsertInfo_Click);
            // 
            // btnSendInfo
            // 
            this.btnSendInfo.Location = new System.Drawing.Point(659, 137);
            this.btnSendInfo.Name = "btnSendInfo";
            this.btnSendInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSendInfo.TabIndex = 19;
            this.btnSendInfo.Text = "Update info";
            this.btnSendInfo.UseVisualStyleBackColor = true;
            this.btnSendInfo.Click += new System.EventHandler(this.btnSendInfo_Click);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(659, 68);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetInfo.TabIndex = 18;
            this.btnGetInfo.Text = "Get info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // txtNamen
            // 
            this.txtNamen.BackColor = System.Drawing.SystemColors.Window;
            this.txtNamen.DisplayMode = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputDisplayMode.Undefined;
            this.txtNamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNamen.Location = new System.Drawing.Point(171, 232);
            this.txtNamen.MaxLength = 16;
            this.txtNamen.Name = "txtNamen";
            this.txtNamen.Obvezno = false;
            this.txtNamen.PaddingLength = 5;
            this.txtNamen.Size = new System.Drawing.Size(427, 28);
            this.txtNamen.TabIndex = 17;
            this.txtNamen.TrueMultiline = false;
            this.txtNamen.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputValueType.Undefined;
            // 
            // txtHisnaStevilka
            // 
            this.txtHisnaStevilka.BackColor = System.Drawing.SystemColors.Window;
            this.txtHisnaStevilka.DisplayMode = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputDisplayMode.Undefined;
            this.txtHisnaStevilka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHisnaStevilka.Location = new System.Drawing.Point(171, 199);
            this.txtHisnaStevilka.MaxLength = 16;
            this.txtHisnaStevilka.Name = "txtHisnaStevilka";
            this.txtHisnaStevilka.Obvezno = false;
            this.txtHisnaStevilka.PaddingLength = 5;
            this.txtHisnaStevilka.Size = new System.Drawing.Size(427, 28);
            this.txtHisnaStevilka.TabIndex = 16;
            this.txtHisnaStevilka.TrueMultiline = false;
            this.txtHisnaStevilka.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputValueType.Undefined;
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.SystemColors.Window;
            this.txtIme.DisplayMode = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputDisplayMode.Undefined;
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIme.Location = new System.Drawing.Point(171, 166);
            this.txtIme.MaxLength = 16;
            this.txtIme.Name = "txtIme";
            this.txtIme.Obvezno = false;
            this.txtIme.PaddingLength = 5;
            this.txtIme.Size = new System.Drawing.Size(427, 28);
            this.txtIme.TabIndex = 15;
            this.txtIme.TrueMultiline = false;
            this.txtIme.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputValueType.Undefined;
            // 
            // txtZnesekPostnine
            // 
            this.txtZnesekPostnine.BackColor = System.Drawing.SystemColors.Window;
            this.txtZnesekPostnine.DisplayMode = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputDisplayMode.Undefined;
            this.txtZnesekPostnine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtZnesekPostnine.Location = new System.Drawing.Point(418, 132);
            this.txtZnesekPostnine.MaxLength = 16;
            this.txtZnesekPostnine.Name = "txtZnesekPostnine";
            this.txtZnesekPostnine.Obvezno = false;
            this.txtZnesekPostnine.PaddingLength = 5;
            this.txtZnesekPostnine.Size = new System.Drawing.Size(88, 28);
            this.txtZnesekPostnine.TabIndex = 14;
            this.txtZnesekPostnine.TrueMultiline = false;
            this.txtZnesekPostnine.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputValueType.Undefined;
            // 
            // txtVrednost
            // 
            this.txtVrednost.BackColor = System.Drawing.SystemColors.Window;
            this.txtVrednost.DisplayMode = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputDisplayMode.Undefined;
            this.txtVrednost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVrednost.Location = new System.Drawing.Point(171, 132);
            this.txtVrednost.MaxLength = 16;
            this.txtVrednost.Name = "txtVrednost";
            this.txtVrednost.Obvezno = false;
            this.txtVrednost.PaddingLength = 5;
            this.txtVrednost.Size = new System.Drawing.Size(88, 28);
            this.txtVrednost.TabIndex = 13;
            this.txtVrednost.TrueMultiline = false;
            this.txtVrednost.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputValueType.Undefined;
            // 
            // txtDelovnoMestoID
            // 
            this.txtDelovnoMestoID.BackColor = System.Drawing.SystemColors.Window;
            this.txtDelovnoMestoID.DisplayMode = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputDisplayMode.Undefined;
            this.txtDelovnoMestoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDelovnoMestoID.Location = new System.Drawing.Point(439, 64);
            this.txtDelovnoMestoID.MaxLength = 16;
            this.txtDelovnoMestoID.Name = "txtDelovnoMestoID";
            this.txtDelovnoMestoID.Obvezno = false;
            this.txtDelovnoMestoID.PaddingLength = 5;
            this.txtDelovnoMestoID.Size = new System.Drawing.Size(159, 28);
            this.txtDelovnoMestoID.TabIndex = 11;
            this.txtDelovnoMestoID.TrueMultiline = false;
            this.txtDelovnoMestoID.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputValueType.Undefined;
            // 
            // txtPostaID
            // 
            this.txtPostaID.BackColor = System.Drawing.SystemColors.Window;
            this.txtPostaID.DisplayMode = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputDisplayMode.Undefined;
            this.txtPostaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPostaID.Location = new System.Drawing.Point(171, 62);
            this.txtPostaID.MaxLength = 16;
            this.txtPostaID.Name = "txtPostaID";
            this.txtPostaID.Obvezno = false;
            this.txtPostaID.PaddingLength = 5;
            this.txtPostaID.Size = new System.Drawing.Size(88, 28);
            this.txtPostaID.TabIndex = 10;
            this.txtPostaID.TrueMultiline = false;
            this.txtPostaID.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputValueType.Undefined;
            // 
            // txtStevilkaRacuna
            // 
            this.txtStevilkaRacuna.BackColor = System.Drawing.SystemColors.Window;
            this.txtStevilkaRacuna.DisplayMode = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputDisplayMode.Undefined;
            this.txtStevilkaRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStevilkaRacuna.Location = new System.Drawing.Point(171, 29);
            this.txtStevilkaRacuna.MaxLength = 16;
            this.txtStevilkaRacuna.Name = "txtStevilkaRacuna";
            this.txtStevilkaRacuna.Obvezno = false;
            this.txtStevilkaRacuna.PaddingLength = 5;
            this.txtStevilkaRacuna.Size = new System.Drawing.Size(427, 28);
            this.txtStevilkaRacuna.TabIndex = 9;
            this.txtStevilkaRacuna.TrueMultiline = false;
            this.txtStevilkaRacuna.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputValueType.Undefined;
            // 
            // lblNamen
            // 
            this.lblNamen.AutoSize = true;
            this.lblNamen.DecimalValue = null;
            this.lblNamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNamen.Location = new System.Drawing.Point(96, 235);
            this.lblNamen.Name = "lblNamen";
            this.lblNamen.Size = new System.Drawing.Size(64, 20);
            this.lblNamen.TabIndex = 8;
            this.lblNamen.Text = "Namen:";
            this.lblNamen.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.LabelPS.TextValueType.Undefined;
            // 
            // lblHisnaStevilka
            // 
            this.lblHisnaStevilka.AutoSize = true;
            this.lblHisnaStevilka.DecimalValue = null;
            this.lblHisnaStevilka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHisnaStevilka.Location = new System.Drawing.Point(50, 202);
            this.lblHisnaStevilka.Name = "lblHisnaStevilka";
            this.lblHisnaStevilka.Size = new System.Drawing.Size(110, 20);
            this.lblHisnaStevilka.TabIndex = 7;
            this.lblHisnaStevilka.Text = "Hišna številka:";
            this.lblHisnaStevilka.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.LabelPS.TextValueType.Undefined;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.DecimalValue = null;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIme.Location = new System.Drawing.Point(120, 169);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(40, 20);
            this.lblIme.TabIndex = 6;
            this.lblIme.Text = "Ime:";
            this.lblIme.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.LabelPS.TextValueType.Undefined;
            // 
            // lblZnesekPostnine
            // 
            this.lblZnesekPostnine.AutoSize = true;
            this.lblZnesekPostnine.DecimalValue = null;
            this.lblZnesekPostnine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZnesekPostnine.Location = new System.Drawing.Point(275, 135);
            this.lblZnesekPostnine.Name = "lblZnesekPostnine";
            this.lblZnesekPostnine.Size = new System.Drawing.Size(132, 20);
            this.lblZnesekPostnine.TabIndex = 5;
            this.lblZnesekPostnine.Text = "Znesek Poštnine:";
            this.lblZnesekPostnine.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.LabelPS.TextValueType.Undefined;
            // 
            // lblVrednost
            // 
            this.lblVrednost.AutoSize = true;
            this.lblVrednost.DecimalValue = null;
            this.lblVrednost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVrednost.Location = new System.Drawing.Point(82, 135);
            this.lblVrednost.Name = "lblVrednost";
            this.lblVrednost.Size = new System.Drawing.Size(78, 20);
            this.lblVrednost.TabIndex = 4;
            this.lblVrednost.Text = "Vrednost:";
            this.lblVrednost.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.LabelPS.TextValueType.Undefined;
            // 
            // lblUporabnikID
            // 
            this.lblUporabnikID.AutoSize = true;
            this.lblUporabnikID.DecimalValue = null;
            this.lblUporabnikID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUporabnikID.Location = new System.Drawing.Point(44, 98);
            this.lblUporabnikID.Name = "lblUporabnikID";
            this.lblUporabnikID.Size = new System.Drawing.Size(116, 20);
            this.lblUporabnikID.TabIndex = 3;
            this.lblUporabnikID.Text = "ID Uporabnika:";
            this.lblUporabnikID.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.LabelPS.TextValueType.Undefined;
            // 
            // lblDelovnoMestoID
            // 
            this.lblDelovnoMestoID.AutoSize = true;
            this.lblDelovnoMestoID.DecimalValue = null;
            this.lblDelovnoMestoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDelovnoMestoID.Location = new System.Drawing.Point(275, 65);
            this.lblDelovnoMestoID.Name = "lblDelovnoMestoID";
            this.lblDelovnoMestoID.Size = new System.Drawing.Size(158, 20);
            this.lblDelovnoMestoID.TabIndex = 2;
            this.lblDelovnoMestoID.Text = "ID Delovnega mesta:";
            this.lblDelovnoMestoID.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.LabelPS.TextValueType.Undefined;
            // 
            // lblPostaID
            // 
            this.lblPostaID.AutoSize = true;
            this.lblPostaID.DecimalValue = null;
            this.lblPostaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPostaID.Location = new System.Drawing.Point(90, 65);
            this.lblPostaID.Name = "lblPostaID";
            this.lblPostaID.Size = new System.Drawing.Size(75, 20);
            this.lblPostaID.TabIndex = 1;
            this.lblPostaID.Text = "ID Pošte:";
            this.lblPostaID.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.LabelPS.TextValueType.Undefined;
            // 
            // lblStevilkaRacuna
            // 
            this.lblStevilkaRacuna.AutoSize = true;
            this.lblStevilkaRacuna.DecimalValue = null;
            this.lblStevilkaRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStevilkaRacuna.Location = new System.Drawing.Point(44, 32);
            this.lblStevilkaRacuna.Name = "lblStevilkaRacuna";
            this.lblStevilkaRacuna.Size = new System.Drawing.Size(121, 20);
            this.lblStevilkaRacuna.TabIndex = 0;
            this.lblStevilkaRacuna.Text = "Številka računa:";
            this.lblStevilkaRacuna.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.LabelPS.TextValueType.Undefined;
            // 
            // txtUporabnikID
            // 
            this.txtUporabnikID.BackColor = System.Drawing.SystemColors.Window;
            this.txtUporabnikID.DisplayMode = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputDisplayMode.Undefined;
            this.txtUporabnikID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUporabnikID.Location = new System.Drawing.Point(171, 98);
            this.txtUporabnikID.MaxLength = 16;
            this.txtUporabnikID.Name = "txtUporabnikID";
            this.txtUporabnikID.Obvezno = false;
            this.txtUporabnikID.PaddingLength = 5;
            this.txtUporabnikID.Size = new System.Drawing.Size(427, 28);
            this.txtUporabnikID.TabIndex = 12;
            this.txtUporabnikID.TrueMultiline = false;
            this.txtUporabnikID.ValueType = PS.GlavnoOkno.UI.Base.Kontrole.TextBoxPS.InputValueType.Undefined;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.pnlContent);
            this.Name = "FrmTest";
            this.Text = "Form1";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlContent;
        private LabelPS lblZnesekPostnine;
        private LabelPS lblVrednost;
        private LabelPS lblUporabnikID;
        private LabelPS lblDelovnoMestoID;
        private LabelPS lblPostaID;
        private LabelPS lblStevilkaRacuna;
        private LabelPS lblNamen;
        private LabelPS lblHisnaStevilka;
        private LabelPS lblIme;
        private TextBoxPS txtStevilkaRacuna;
        private System.Windows.Forms.Button button1;
        private TextBoxPS txtNamen;
        private TextBoxPS txtHisnaStevilka;
        private TextBoxPS txtIme;
        private TextBoxPS txtZnesekPostnine;
        private TextBoxPS txtVrednost;
        private TextBoxPS txtDelovnoMestoID;
        private TextBoxPS txtPostaID;
        private System.Windows.Forms.Button btnSendInfo;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Button btnInsertInfo;
        private TextBoxPS txtOznakaValute;
        private TextBoxPS txtUporabnikID;
    }
}

