namespace JobSystem
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label warrentyLabel;
            System.Windows.Forms.Label squaresLabel;
            System.Windows.Forms.Label time_TookLabel;
            System.Windows.Forms.Label time_EstimatedLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label job_NameLabel;
            this.btnView = new System.Windows.Forms.Button();
            this.cmbWarranty = new System.Windows.Forms.ComboBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.squaresTextBox = new System.Windows.Forms.TextBox();
            this.time_TookTextBox = new System.Windows.Forms.TextBox();
            this.time_EstimatedTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.job_NameTextBox = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            dateLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            warrentyLabel = new System.Windows.Forms.Label();
            squaresLabel = new System.Windows.Forms.Label();
            time_TookLabel = new System.Windows.Forms.Label();
            time_EstimatedLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            job_NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(141, 83);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(53, 24);
            dateLabel.TabIndex = 33;
            dateLabel.Text = "Date:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costLabel.Location = new System.Drawing.Point(139, 411);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(52, 24);
            costLabel.TabIndex = 31;
            costLabel.Text = "Cost:";
            // 
            // warrentyLabel
            // 
            warrentyLabel.AutoSize = true;
            warrentyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            warrentyLabel.Location = new System.Drawing.Point(101, 377);
            warrentyLabel.Name = "warrentyLabel";
            warrentyLabel.Size = new System.Drawing.Size(90, 24);
            warrentyLabel.TabIndex = 30;
            warrentyLabel.Text = "Warrenty:";
            // 
            // squaresLabel
            // 
            squaresLabel.AutoSize = true;
            squaresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            squaresLabel.Location = new System.Drawing.Point(106, 339);
            squaresLabel.Name = "squaresLabel";
            squaresLabel.Size = new System.Drawing.Size(85, 24);
            squaresLabel.TabIndex = 28;
            squaresLabel.Text = "Squares:";
            // 
            // time_TookLabel
            // 
            time_TookLabel.AutoSize = true;
            time_TookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            time_TookLabel.Location = new System.Drawing.Point(85, 300);
            time_TookLabel.Name = "time_TookLabel";
            time_TookLabel.Size = new System.Drawing.Size(106, 24);
            time_TookLabel.TabIndex = 26;
            time_TookLabel.Text = "Time Took:";
            // 
            // time_EstimatedLabel
            // 
            time_EstimatedLabel.AutoSize = true;
            time_EstimatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            time_EstimatedLabel.Location = new System.Drawing.Point(46, 265);
            time_EstimatedLabel.Name = "time_EstimatedLabel";
            time_EstimatedLabel.Size = new System.Drawing.Size(145, 24);
            time_EstimatedLabel.TabIndex = 24;
            time_EstimatedLabel.Text = "Time Estimated:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(85, 191);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(109, 24);
            descriptionLabel.TabIndex = 22;
            descriptionLabel.Text = "Description:";
            // 
            // job_NameLabel
            // 
            job_NameLabel.AutoSize = true;
            job_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            job_NameLabel.Location = new System.Drawing.Point(92, 122);
            job_NameLabel.Name = "job_NameLabel";
            job_NameLabel.Size = new System.Drawing.Size(102, 24);
            job_NameLabel.TabIndex = 20;
            job_NameLabel.Text = "Job Name:";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(12, 530);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(94, 33);
            this.btnView.TabIndex = 36;
            this.btnView.Text = "Table Viewer";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // cmbWarranty
            // 
            this.cmbWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWarranty.FormattingEnabled = true;
            this.cmbWarranty.Location = new System.Drawing.Point(226, 369);
            this.cmbWarranty.Name = "cmbWarranty";
            this.cmbWarranty.Size = new System.Drawing.Size(272, 32);
            this.cmbWarranty.TabIndex = 35;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(226, 83);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(145, 29);
            this.dateTextBox.TabIndex = 34;
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTextBox.Location = new System.Drawing.Point(226, 406);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 29);
            this.costTextBox.TabIndex = 32;
            // 
            // squaresTextBox
            // 
            this.squaresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squaresTextBox.Location = new System.Drawing.Point(226, 334);
            this.squaresTextBox.Name = "squaresTextBox";
            this.squaresTextBox.Size = new System.Drawing.Size(100, 29);
            this.squaresTextBox.TabIndex = 29;
            // 
            // time_TookTextBox
            // 
            this.time_TookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_TookTextBox.Location = new System.Drawing.Point(226, 295);
            this.time_TookTextBox.Name = "time_TookTextBox";
            this.time_TookTextBox.Size = new System.Drawing.Size(100, 29);
            this.time_TookTextBox.TabIndex = 27;
            // 
            // time_EstimatedTextBox
            // 
            this.time_EstimatedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_EstimatedTextBox.Location = new System.Drawing.Point(226, 260);
            this.time_EstimatedTextBox.Name = "time_EstimatedTextBox";
            this.time_EstimatedTextBox.Size = new System.Drawing.Size(100, 29);
            this.time_EstimatedTextBox.TabIndex = 25;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(226, 157);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(443, 93);
            this.descriptionTextBox.TabIndex = 23;
            this.descriptionTextBox.Text = "ffffffff";
            // 
            // job_NameTextBox
            // 
            this.job_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_NameTextBox.Location = new System.Drawing.Point(226, 122);
            this.job_NameTextBox.Name = "job_NameTextBox";
            this.job_NameTextBox.Size = new System.Drawing.Size(323, 29);
            this.job_NameTextBox.TabIndex = 21;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(802, 530);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 33);
            this.btnNext.TabIndex = 37;
            this.btnNext.Text = "Next Record";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(659, 530);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(114, 33);
            this.btnPrev.TabIndex = 38;
            this.btnPrev.Text = "Previous Record";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(212, 530);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 33);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(309, 530);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 33);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(112, 530);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 33);
            this.btnNew.TabIndex = 41;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(185, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 24);
            this.lblID.TabIndex = 43;
            this.lblID.Text = "~";
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(659, 36);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(91, 34);
            this.btnprint.TabIndex = 44;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 575);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.cmbWarranty);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(warrentyLabel);
            this.Controls.Add(squaresLabel);
            this.Controls.Add(this.squaresTextBox);
            this.Controls.Add(time_TookLabel);
            this.Controls.Add(this.time_TookTextBox);
            this.Controls.Add(time_EstimatedLabel);
            this.Controls.Add(this.time_EstimatedTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(job_NameLabel);
            this.Controls.Add(this.job_NameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cmbWarranty;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox squaresTextBox;
        private System.Windows.Forms.TextBox time_TookTextBox;
        private System.Windows.Forms.TextBox time_EstimatedTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox job_NameTextBox;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnprint;
    }
}

