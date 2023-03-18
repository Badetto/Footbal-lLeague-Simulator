
namespace Atestat2021
{
    partial class FormAutentificare
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
            this.components = new System.ComponentModel.Container();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bazedateUseriDataSet = new Atestat2021.bazedateUseriDataSet();
            this.useriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.useriTableAdapter = new Atestat2021.bazedateUseriDataSetTableAdapters.UseriTableAdapter();
            this.statisticiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statisticiTableAdapter = new Atestat2021.bazedateUseriDataSetTableAdapters.StatisticiTableAdapter();
            this.echipeFavoriteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.echipeFavoriteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.echipeFavoriteTableAdapter = new Atestat2021.bazedateUseriDataSetTableAdapters.EchipeFavoriteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bazedateUseriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echipeFavoriteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echipeFavoriteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(277, 281);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 30);
            this.textBox3.TabIndex = 24;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Confirmare Parola:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(71, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 22;
            this.button2.Text = "Anulare";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(277, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 21;
            this.button1.Text = "Inregistrare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 30);
            this.textBox2.TabIndex = 20;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 30);
            this.textBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(66, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username:";
            // 
            // bazedateUseriDataSet
            // 
            this.bazedateUseriDataSet.DataSetName = "bazedateUseriDataSet";
            this.bazedateUseriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // useriBindingSource
            // 
            this.useriBindingSource.DataMember = "Useri";
            this.useriBindingSource.DataSource = this.bazedateUseriDataSet;
            // 
            // useriTableAdapter
            // 
            this.useriTableAdapter.ClearBeforeFill = true;
            // 
            // statisticiBindingSource
            // 
            this.statisticiBindingSource.DataMember = "Statistici";
            this.statisticiBindingSource.DataSource = this.bazedateUseriDataSet;
            // 
            // statisticiTableAdapter
            // 
            this.statisticiTableAdapter.ClearBeforeFill = true;
            // 
            // echipeFavoriteBindingSource
            // 
            this.echipeFavoriteBindingSource.DataMember = "EchipeFavorite";
            this.echipeFavoriteBindingSource.DataSource = this.bazedateUseriDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(66, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "label5";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(277, 317);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 29);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Afisati Parolele";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 46);
            this.label6.TabIndex = 27;
            this.label6.Text = "Simulator Fotbal";
            // 
            // echipeFavoriteBindingSource1
            // 
            this.echipeFavoriteBindingSource1.DataMember = "EchipeFavorite";
            this.echipeFavoriteBindingSource1.DataSource = this.bazedateUseriDataSet;
            // 
            // echipeFavoriteTableAdapter
            // 
            this.echipeFavoriteTableAdapter.ClearBeforeFill = true;
            // 
            // FormAutentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(532, 533);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAutentificare";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare";
            this.Load += new System.EventHandler(this.FormAutentificare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazedateUseriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echipeFavoriteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echipeFavoriteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private bazedateUseriDataSet bazedateUseriDataSet;
        private System.Windows.Forms.BindingSource useriBindingSource;
        private bazedateUseriDataSetTableAdapters.UseriTableAdapter useriTableAdapter;
        private System.Windows.Forms.BindingSource statisticiBindingSource;
        private bazedateUseriDataSetTableAdapters.StatisticiTableAdapter statisticiTableAdapter;
        private System.Windows.Forms.BindingSource echipeFavoriteBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource echipeFavoriteBindingSource1;
        private bazedateUseriDataSetTableAdapters.EchipeFavoriteTableAdapter echipeFavoriteTableAdapter;
    }
}