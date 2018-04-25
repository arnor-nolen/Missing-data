namespace Missing_data
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
            this.lblInputCompleteLoc = new System.Windows.Forms.Label();
            this.lblOutputLoc = new System.Windows.Forms.Label();
            this.tbInputCompleteLoc = new System.Windows.Forms.TextBox();
            this.tbOutputLoc = new System.Windows.Forms.TextBox();
            this.btnInputCompleteLoc = new System.Windows.Forms.Button();
            this.btnOutputLoc = new System.Windows.Forms.Button();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.rbListwise = new System.Windows.Forms.RadioButton();
            this.rbPairwise = new System.Windows.Forms.RadioButton();
            this.rbMean = new System.Windows.Forms.RadioButton();
            this.rbColdDeck = new System.Windows.Forms.RadioButton();
            this.rbHotDeck = new System.Windows.Forms.RadioButton();
            this.rbLinearRegression = new System.Windows.Forms.RadioButton();
            this.rbSpline = new System.Windows.Forms.RadioButton();
            this.rbEM = new System.Windows.Forms.RadioButton();
            this.rbMultipleImputation = new System.Windows.Forms.RadioButton();
            this.gbMethod = new System.Windows.Forms.GroupBox();
            this.gbInputOutput = new System.Windows.Forms.GroupBox();
            this.btnInputMissingLoc = new System.Windows.Forms.Button();
            this.tbInputMissingLoc = new System.Windows.Forms.TextBox();
            this.lblInputMissingLoc = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnCreateMissingFile = new System.Windows.Forms.Button();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.gbMethod.SuspendLayout();
            this.gbInputOutput.SuspendLayout();
            this.gbInput.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInputCompleteLoc
            // 
            this.lblInputCompleteLoc.AutoSize = true;
            this.lblInputCompleteLoc.Location = new System.Drawing.Point(7, 26);
            this.lblInputCompleteLoc.Name = "lblInputCompleteLoc";
            this.lblInputCompleteLoc.Size = new System.Drawing.Size(70, 13);
            this.lblInputCompleteLoc.TabIndex = 0;
            this.lblInputCompleteLoc.Text = "Complete file:";
            // 
            // lblOutputLoc
            // 
            this.lblOutputLoc.AutoSize = true;
            this.lblOutputLoc.Location = new System.Drawing.Point(6, 75);
            this.lblOutputLoc.Name = "lblOutputLoc";
            this.lblOutputLoc.Size = new System.Drawing.Size(58, 13);
            this.lblOutputLoc.TabIndex = 1;
            this.lblOutputLoc.Text = "Output file:";
            // 
            // tbInputCompleteLoc
            // 
            this.tbInputCompleteLoc.Location = new System.Drawing.Point(97, 23);
            this.tbInputCompleteLoc.Name = "tbInputCompleteLoc";
            this.tbInputCompleteLoc.Size = new System.Drawing.Size(259, 20);
            this.tbInputCompleteLoc.TabIndex = 2;
            // 
            // tbOutputLoc
            // 
            this.tbOutputLoc.Location = new System.Drawing.Point(97, 72);
            this.tbOutputLoc.Name = "tbOutputLoc";
            this.tbOutputLoc.Size = new System.Drawing.Size(259, 20);
            this.tbOutputLoc.TabIndex = 3;
            // 
            // btnInputCompleteLoc
            // 
            this.btnInputCompleteLoc.Location = new System.Drawing.Point(362, 22);
            this.btnInputCompleteLoc.Name = "btnInputCompleteLoc";
            this.btnInputCompleteLoc.Size = new System.Drawing.Size(75, 20);
            this.btnInputCompleteLoc.TabIndex = 4;
            this.btnInputCompleteLoc.Text = "Choose...";
            this.btnInputCompleteLoc.UseVisualStyleBackColor = true;
            this.btnInputCompleteLoc.Click += new System.EventHandler(this.btnInputLoc_Click);
            // 
            // btnOutputLoc
            // 
            this.btnOutputLoc.Location = new System.Drawing.Point(362, 71);
            this.btnOutputLoc.Name = "btnOutputLoc";
            this.btnOutputLoc.Size = new System.Drawing.Size(75, 20);
            this.btnOutputLoc.TabIndex = 5;
            this.btnOutputLoc.Text = "Choose...";
            this.btnOutputLoc.UseVisualStyleBackColor = true;
            this.btnOutputLoc.Click += new System.EventHandler(this.btnOutputLoc_Click);
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToAddRows = false;
            this.dgvInput.AllowUserToDeleteRows = false;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Location = new System.Drawing.Point(6, 19);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.ReadOnly = true;
            this.dgvInput.RowHeadersVisible = false;
            this.dgvInput.Size = new System.Drawing.Size(374, 415);
            this.dgvInput.TabIndex = 7;
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(6, 19);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowHeadersVisible = false;
            this.dgvOutput.Size = new System.Drawing.Size(372, 415);
            this.dgvOutput.TabIndex = 8;
            // 
            // rbListwise
            // 
            this.rbListwise.AutoSize = true;
            this.rbListwise.Checked = true;
            this.rbListwise.Location = new System.Drawing.Point(6, 49);
            this.rbListwise.Name = "rbListwise";
            this.rbListwise.Size = new System.Drawing.Size(102, 17);
            this.rbListwise.TabIndex = 12;
            this.rbListwise.TabStop = true;
            this.rbListwise.Text = "Listwise deletion";
            this.rbListwise.UseVisualStyleBackColor = true;
            // 
            // rbPairwise
            // 
            this.rbPairwise.AutoSize = true;
            this.rbPairwise.Enabled = false;
            this.rbPairwise.Location = new System.Drawing.Point(6, 72);
            this.rbPairwise.Name = "rbPairwise";
            this.rbPairwise.Size = new System.Drawing.Size(104, 17);
            this.rbPairwise.TabIndex = 13;
            this.rbPairwise.Text = "Pairwise deletion";
            this.rbPairwise.UseVisualStyleBackColor = true;
            // 
            // rbMean
            // 
            this.rbMean.AutoSize = true;
            this.rbMean.Location = new System.Drawing.Point(6, 95);
            this.rbMean.Name = "rbMean";
            this.rbMean.Size = new System.Drawing.Size(108, 17);
            this.rbMean.TabIndex = 14;
            this.rbMean.Text = "Mean substitution";
            this.rbMean.UseVisualStyleBackColor = true;
            // 
            // rbColdDeck
            // 
            this.rbColdDeck.AutoSize = true;
            this.rbColdDeck.Location = new System.Drawing.Point(6, 118);
            this.rbColdDeck.Name = "rbColdDeck";
            this.rbColdDeck.Size = new System.Drawing.Size(124, 17);
            this.rbColdDeck.TabIndex = 15;
            this.rbColdDeck.Text = "Cold deck imputation";
            this.rbColdDeck.UseVisualStyleBackColor = true;
            // 
            // rbHotDeck
            // 
            this.rbHotDeck.AutoSize = true;
            this.rbHotDeck.Location = new System.Drawing.Point(135, 26);
            this.rbHotDeck.Name = "rbHotDeck";
            this.rbHotDeck.Size = new System.Drawing.Size(120, 17);
            this.rbHotDeck.TabIndex = 16;
            this.rbHotDeck.Text = "Hot deck imputation";
            this.rbHotDeck.UseVisualStyleBackColor = true;
            // 
            // rbLinearRegression
            // 
            this.rbLinearRegression.AutoSize = true;
            this.rbLinearRegression.Location = new System.Drawing.Point(135, 49);
            this.rbLinearRegression.Name = "rbLinearRegression";
            this.rbLinearRegression.Size = new System.Drawing.Size(145, 17);
            this.rbLinearRegression.TabIndex = 17;
            this.rbLinearRegression.Text = "Linear regression analysis";
            this.rbLinearRegression.UseVisualStyleBackColor = true;
            // 
            // rbSpline
            // 
            this.rbSpline.AutoSize = true;
            this.rbSpline.Enabled = false;
            this.rbSpline.Location = new System.Drawing.Point(135, 72);
            this.rbSpline.Name = "rbSpline";
            this.rbSpline.Size = new System.Drawing.Size(114, 17);
            this.rbSpline.TabIndex = 18;
            this.rbSpline.Text = "Spline interpolation";
            this.rbSpline.UseVisualStyleBackColor = true;
            // 
            // rbEM
            // 
            this.rbEM.AutoSize = true;
            this.rbEM.Enabled = false;
            this.rbEM.Location = new System.Drawing.Point(135, 95);
            this.rbEM.Name = "rbEM";
            this.rbEM.Size = new System.Drawing.Size(186, 17);
            this.rbEM.TabIndex = 19;
            this.rbEM.Text = "Maximum likelihood (EM algorithm)";
            this.rbEM.UseVisualStyleBackColor = true;
            // 
            // rbMultipleImputation
            // 
            this.rbMultipleImputation.AutoSize = true;
            this.rbMultipleImputation.Enabled = false;
            this.rbMultipleImputation.Location = new System.Drawing.Point(135, 118);
            this.rbMultipleImputation.Name = "rbMultipleImputation";
            this.rbMultipleImputation.Size = new System.Drawing.Size(112, 17);
            this.rbMultipleImputation.TabIndex = 20;
            this.rbMultipleImputation.Text = "Multiple imputation";
            this.rbMultipleImputation.UseVisualStyleBackColor = true;
            // 
            // gbMethod
            // 
            this.gbMethod.Controls.Add(this.rbAll);
            this.gbMethod.Controls.Add(this.rbPairwise);
            this.gbMethod.Controls.Add(this.rbMultipleImputation);
            this.gbMethod.Controls.Add(this.rbListwise);
            this.gbMethod.Controls.Add(this.rbEM);
            this.gbMethod.Controls.Add(this.rbMean);
            this.gbMethod.Controls.Add(this.rbSpline);
            this.gbMethod.Controls.Add(this.rbColdDeck);
            this.gbMethod.Controls.Add(this.rbLinearRegression);
            this.gbMethod.Controls.Add(this.rbHotDeck);
            this.gbMethod.Location = new System.Drawing.Point(461, 12);
            this.gbMethod.Name = "gbMethod";
            this.gbMethod.Size = new System.Drawing.Size(327, 144);
            this.gbMethod.TabIndex = 22;
            this.gbMethod.TabStop = false;
            this.gbMethod.Text = "Choose a method:";
            // 
            // gbInputOutput
            // 
            this.gbInputOutput.Controls.Add(this.btnInputMissingLoc);
            this.gbInputOutput.Controls.Add(this.tbInputMissingLoc);
            this.gbInputOutput.Controls.Add(this.lblInputMissingLoc);
            this.gbInputOutput.Controls.Add(this.tbInputCompleteLoc);
            this.gbInputOutput.Controls.Add(this.lblInputCompleteLoc);
            this.gbInputOutput.Controls.Add(this.lblOutputLoc);
            this.gbInputOutput.Controls.Add(this.tbOutputLoc);
            this.gbInputOutput.Controls.Add(this.btnInputCompleteLoc);
            this.gbInputOutput.Controls.Add(this.btnOutputLoc);
            this.gbInputOutput.Location = new System.Drawing.Point(12, 12);
            this.gbInputOutput.Name = "gbInputOutput";
            this.gbInputOutput.Size = new System.Drawing.Size(443, 103);
            this.gbInputOutput.TabIndex = 23;
            this.gbInputOutput.TabStop = false;
            this.gbInputOutput.Text = "Specify input and output files:";
            // 
            // btnInputMissingLoc
            // 
            this.btnInputMissingLoc.Location = new System.Drawing.Point(362, 47);
            this.btnInputMissingLoc.Name = "btnInputMissingLoc";
            this.btnInputMissingLoc.Size = new System.Drawing.Size(75, 20);
            this.btnInputMissingLoc.TabIndex = 8;
            this.btnInputMissingLoc.Text = "Choose...";
            this.btnInputMissingLoc.UseVisualStyleBackColor = true;
            this.btnInputMissingLoc.Click += new System.EventHandler(this.btnInputMissingLoc_Click);
            // 
            // tbInputMissingLoc
            // 
            this.tbInputMissingLoc.Location = new System.Drawing.Point(97, 48);
            this.tbInputMissingLoc.Name = "tbInputMissingLoc";
            this.tbInputMissingLoc.Size = new System.Drawing.Size(259, 20);
            this.tbInputMissingLoc.TabIndex = 7;
            // 
            // lblInputMissingLoc
            // 
            this.lblInputMissingLoc.AutoSize = true;
            this.lblInputMissingLoc.Location = new System.Drawing.Point(6, 51);
            this.lblInputMissingLoc.Name = "lblInputMissingLoc";
            this.lblInputMissingLoc.Size = new System.Drawing.Size(85, 13);
            this.lblInputMissingLoc.TabIndex = 6;
            this.lblInputMissingLoc.Text = "Missing data file:";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(229, 121);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(204, 35);
            this.btnExecute.TabIndex = 24;
            this.btnExecute.Text = "Apply chosen method";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnCreateMissingFile
            // 
            this.btnCreateMissingFile.Location = new System.Drawing.Point(36, 121);
            this.btnCreateMissingFile.Name = "btnCreateMissingFile";
            this.btnCreateMissingFile.Size = new System.Drawing.Size(187, 35);
            this.btnCreateMissingFile.TabIndex = 25;
            this.btnCreateMissingFile.Text = "Create missing data file";
            this.btnCreateMissingFile.UseVisualStyleBackColor = true;
            this.btnCreateMissingFile.Click += new System.EventHandler(this.btnCreateMissingFile_Click);
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.dgvInput);
            this.gbInput.Location = new System.Drawing.Point(12, 170);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(386, 440);
            this.gbInput.TabIndex = 26;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input file";
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.dgvOutput);
            this.gbOutput.Location = new System.Drawing.Point(404, 170);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(384, 440);
            this.gbOutput.TabIndex = 27;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output file";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Enabled = false;
            this.rbAll.Location = new System.Drawing.Point(6, 26);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 21;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.btnCreateMissingFile);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.gbInputOutput);
            this.Controls.Add(this.gbMethod);
            this.Name = "Form1";
            this.Text = "Missing data application";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.gbMethod.ResumeLayout(false);
            this.gbMethod.PerformLayout();
            this.gbInputOutput.ResumeLayout(false);
            this.gbInputOutput.PerformLayout();
            this.gbInput.ResumeLayout(false);
            this.gbOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInputCompleteLoc;
        private System.Windows.Forms.Label lblOutputLoc;
        private System.Windows.Forms.TextBox tbInputCompleteLoc;
        private System.Windows.Forms.TextBox tbOutputLoc;
        private System.Windows.Forms.Button btnInputCompleteLoc;
        private System.Windows.Forms.Button btnOutputLoc;
        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.RadioButton rbListwise;
        private System.Windows.Forms.RadioButton rbPairwise;
        private System.Windows.Forms.RadioButton rbMean;
        private System.Windows.Forms.RadioButton rbColdDeck;
        private System.Windows.Forms.RadioButton rbHotDeck;
        private System.Windows.Forms.RadioButton rbLinearRegression;
        private System.Windows.Forms.RadioButton rbSpline;
        private System.Windows.Forms.RadioButton rbEM;
        private System.Windows.Forms.RadioButton rbMultipleImputation;
        private System.Windows.Forms.GroupBox gbMethod;
        private System.Windows.Forms.GroupBox gbInputOutput;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnInputMissingLoc;
        private System.Windows.Forms.TextBox tbInputMissingLoc;
        private System.Windows.Forms.Label lblInputMissingLoc;
        private System.Windows.Forms.Button btnCreateMissingFile;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.RadioButton rbAll;
    }
}

