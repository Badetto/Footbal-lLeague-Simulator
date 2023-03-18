
namespace Atestat2021
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.echipeFavoriteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.echipeFavoriteTableAdapter = new Atestat2021.bazedateUseriDataSetTableAdapters.EchipeFavoriteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bazedateUseriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echipeFavoriteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echipeFavoriteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(66, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 20;
            this.button2.Text = "Anulare";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(272, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 19;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 30);
            this.textBox2.TabIndex = 18;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(282, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 30);
            this.textBox1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(61, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 14;
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
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(119, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 176);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(282, 318);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 29);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Afisati Parola";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(532, 533);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazedateUseriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echipeFavoriteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echipeFavoriteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource echipeFavoriteBindingSource1;
        private bazedateUseriDataSetTableAdapters.EchipeFavoriteTableAdapter echipeFavoriteTableAdapter;
    }
}