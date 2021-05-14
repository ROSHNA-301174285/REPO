
namespace RoshnaR_301174285_A4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clubsFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadClubs = new System.Windows.Forms.Button();
            this.btnSaveClubs = new System.Windows.Forms.Button();
            this.listClubs = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.swimmersFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadSwimmers = new System.Windows.Forms.Button();
            this.btnSaveSwimmers = new System.Windows.Forms.Button();
            this.listSwimmers = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clubsFilePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLoadClubs);
            this.groupBox1.Controls.Add(this.btnSaveClubs);
            this.groupBox1.Controls.Add(this.listClubs);
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clubs";
            //this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // clubsFilePath
            // 
            this.clubsFilePath.Location = new System.Drawing.Point(80, 39);
            this.clubsFilePath.Name = "clubsFilePath";
            this.clubsFilePath.Size = new System.Drawing.Size(159, 22);
            this.clubsFilePath.TabIndex = 4;
           // this.clubsFilePath.TextChanged += new System.EventHandler(this.clubsFilePath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Path";
            // 
            // btnLoadClubs
            // 
            this.btnLoadClubs.Location = new System.Drawing.Point(14, 89);
            this.btnLoadClubs.Name = "btnLoadClubs";
            this.btnLoadClubs.Size = new System.Drawing.Size(101, 28);
            this.btnLoadClubs.TabIndex = 2;
            this.btnLoadClubs.Text = "Load Clubs";
            this.btnLoadClubs.UseVisualStyleBackColor = true;
            this.btnLoadClubs.Click += new System.EventHandler(this.btnLoadClubs_Click);
            // 
            // btnSaveClubs
            // 
            this.btnSaveClubs.Location = new System.Drawing.Point(152, 89);
            this.btnSaveClubs.Name = "btnSaveClubs";
            this.btnSaveClubs.Size = new System.Drawing.Size(101, 28);
            this.btnSaveClubs.TabIndex = 1;
            this.btnSaveClubs.Text = "Save Clubs";
            this.btnSaveClubs.UseVisualStyleBackColor = true;
            this.btnSaveClubs.Click += new System.EventHandler(this.btnSaveClubs_Click);
            // 
            // listClubs
            // 
            this.listClubs.FormattingEnabled = true;
            this.listClubs.ItemHeight = 16;
            this.listClubs.Location = new System.Drawing.Point(14, 141);
            this.listClubs.Name = "listClubs";
            this.listClubs.Size = new System.Drawing.Size(248, 148);
            this.listClubs.TabIndex = 0;
            //this.listClubs.SelectedIndexChanged += new System.EventHandler(this.listClubs_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.swimmersFilePath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnLoadSwimmers);
            this.groupBox2.Controls.Add(this.btnSaveSwimmers);
            this.groupBox2.Controls.Add(this.listSwimmers);
            this.groupBox2.Location = new System.Drawing.Point(326, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Swimmers";
            //this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // swimmersFilePath
            // 
            this.swimmersFilePath.Location = new System.Drawing.Point(84, 42);
            this.swimmersFilePath.Name = "swimmersFilePath";
            this.swimmersFilePath.Size = new System.Drawing.Size(165, 22);
            this.swimmersFilePath.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Path";
            // 
            // btnLoadSwimmers
            // 
            this.btnLoadSwimmers.Location = new System.Drawing.Point(18, 89);
            this.btnLoadSwimmers.Name = "btnLoadSwimmers";
            this.btnLoadSwimmers.Size = new System.Drawing.Size(130, 28);
            this.btnLoadSwimmers.TabIndex = 3;
            this.btnLoadSwimmers.Text = "Load Swimmers";
            this.btnLoadSwimmers.UseVisualStyleBackColor = true;
            this.btnLoadSwimmers.Click += new System.EventHandler(this.btnLoadSwimmers_Click);
            // 
            // btnSaveSwimmers
            // 
            this.btnSaveSwimmers.Location = new System.Drawing.Point(172, 89);
            this.btnSaveSwimmers.Name = "btnSaveSwimmers";
            this.btnSaveSwimmers.Size = new System.Drawing.Size(130, 28);
            this.btnSaveSwimmers.TabIndex = 1;
            this.btnSaveSwimmers.Text = "Save Swimmers";
            this.btnSaveSwimmers.UseVisualStyleBackColor = true;
            this.btnSaveSwimmers.Click += new System.EventHandler(this.btnSaveSwimmers_Click);
            // 
            // listSwimmers
            // 
            this.listSwimmers.FormattingEnabled = true;
            this.listSwimmers.ItemHeight = 16;
            this.listSwimmers.Location = new System.Drawing.Point(18, 140);
            this.listSwimmers.Name = "listSwimmers";
            this.listSwimmers.Size = new System.Drawing.Size(284, 148);
            this.listSwimmers.TabIndex = 0;
            //this.listSwimmers.SelectedIndexChanged += new System.EventHandler(this.listSwimmers_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 745);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listClubs;
        private System.Windows.Forms.ListBox listSwimmers;
        private System.Windows.Forms.Button btnSaveSwimmers;
        private System.Windows.Forms.Button btnSaveClubs;
        private System.Windows.Forms.Button btnLoadClubs;
        private System.Windows.Forms.Button btnLoadSwimmers;
        private System.Windows.Forms.TextBox clubsFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox swimmersFilePath;
        private System.Windows.Forms.Label label2;
    }
}

