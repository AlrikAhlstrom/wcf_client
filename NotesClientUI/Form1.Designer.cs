namespace NotesClientUI
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
            this.lblNoteID = new System.Windows.Forms.Label();
            this.lblNoteDetails = new System.Windows.Forms.Label();
            this.txtNoteDetails = new System.Windows.Forms.TextBox();
            this.lblUpdateNote = new System.Windows.Forms.Label();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numNoteID = new System.Windows.Forms.NumericUpDown();
            this.lblDelete = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewGetNote = new System.Windows.Forms.Button();
            this.btnCreateNote = new System.Windows.Forms.Button();
            this.lblCreateNote = new System.Windows.Forms.Label();
            this.lblCreateTitle = new System.Windows.Forms.Label();
            this.txtCreateTitle = new System.Windows.Forms.TextBox();
            this.txtCreateDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListAllNotes = new System.Windows.Forms.Button();
            this.numDelete = new System.Windows.Forms.NumericUpDown();
            this.numUpdateId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNoteID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoteID
            // 
            this.lblNoteID.AutoSize = true;
            this.lblNoteID.Location = new System.Drawing.Point(12, 26);
            this.lblNoteID.Name = "lblNoteID";
            this.lblNoteID.Size = new System.Drawing.Size(44, 13);
            this.lblNoteID.TabIndex = 0;
            this.lblNoteID.Text = "Note ID";
            // 
            // lblNoteDetails
            // 
            this.lblNoteDetails.AutoSize = true;
            this.lblNoteDetails.Location = new System.Drawing.Point(12, 60);
            this.lblNoteDetails.Name = "lblNoteDetails";
            this.lblNoteDetails.Size = new System.Drawing.Size(65, 13);
            this.lblNoteDetails.TabIndex = 3;
            this.lblNoteDetails.Text = "Note Details";
            // 
            // txtNoteDetails
            // 
            this.txtNoteDetails.AcceptsReturn = true;
            this.txtNoteDetails.Location = new System.Drawing.Point(15, 76);
            this.txtNoteDetails.Multiline = true;
            this.txtNoteDetails.Name = "txtNoteDetails";
            this.txtNoteDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoteDetails.Size = new System.Drawing.Size(360, 160);
            this.txtNoteDetails.TabIndex = 4;
            // 
            // lblUpdateNote
            // 
            this.lblUpdateNote.AutoSize = true;
            this.lblUpdateNote.Location = new System.Drawing.Point(160, 256);
            this.lblUpdateNote.Name = "lblUpdateNote";
            this.lblUpdateNote.Size = new System.Drawing.Size(68, 13);
            this.lblUpdateNote.TabIndex = 5;
            this.lblUpdateNote.Text = "Update Note";
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(160, 323);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(52, 13);
            this.lblUpdateTitle.TabIndex = 6;
            this.lblUpdateTitle.Text = "New Title";
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(163, 339);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateTitle.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(163, 404);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Note";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(163, 378);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateDescription.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "New Description";
            // 
            // numNoteID
            // 
            this.numNoteID.Location = new System.Drawing.Point(66, 24);
            this.numNoteID.Name = "numNoteID";
            this.numNoteID.Size = new System.Drawing.Size(49, 20);
            this.numNoteID.TabIndex = 11;
            this.numNoteID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(297, 256);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(64, 13);
            this.lblDelete.TabIndex = 13;
            this.lblDelete.Text = "Delete Note";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(300, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Note";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewGetNote
            // 
            this.btnNewGetNote.Location = new System.Drawing.Point(128, 21);
            this.btnNewGetNote.Name = "btnNewGetNote";
            this.btnNewGetNote.Size = new System.Drawing.Size(75, 23);
            this.btnNewGetNote.TabIndex = 15;
            this.btnNewGetNote.Text = "Get Note";
            this.btnNewGetNote.UseVisualStyleBackColor = true;
            this.btnNewGetNote.Click += new System.EventHandler(this.btnNewGetNote_Click);
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.Location = new System.Drawing.Point(15, 403);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(100, 23);
            this.btnCreateNote.TabIndex = 16;
            this.btnCreateNote.Text = "Create Note";
            this.btnCreateNote.UseVisualStyleBackColor = true;
            this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click);
            // 
            // lblCreateNote
            // 
            this.lblCreateNote.AutoSize = true;
            this.lblCreateNote.Location = new System.Drawing.Point(12, 256);
            this.lblCreateNote.Name = "lblCreateNote";
            this.lblCreateNote.Size = new System.Drawing.Size(61, 13);
            this.lblCreateNote.TabIndex = 17;
            this.lblCreateNote.Text = "CreateNote";
            // 
            // lblCreateTitle
            // 
            this.lblCreateTitle.AutoSize = true;
            this.lblCreateTitle.Location = new System.Drawing.Point(12, 319);
            this.lblCreateTitle.Name = "lblCreateTitle";
            this.lblCreateTitle.Size = new System.Drawing.Size(27, 13);
            this.lblCreateTitle.TabIndex = 18;
            this.lblCreateTitle.Text = "Title";
            // 
            // txtCreateTitle
            // 
            this.txtCreateTitle.Location = new System.Drawing.Point(15, 338);
            this.txtCreateTitle.Name = "txtCreateTitle";
            this.txtCreateTitle.Size = new System.Drawing.Size(100, 20);
            this.txtCreateTitle.TabIndex = 19;
            // 
            // txtCreateDescription
            // 
            this.txtCreateDescription.Location = new System.Drawing.Point(15, 377);
            this.txtCreateDescription.Name = "txtCreateDescription";
            this.txtCreateDescription.Size = new System.Drawing.Size(100, 20);
            this.txtCreateDescription.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Description";
            // 
            // btnListAllNotes
            // 
            this.btnListAllNotes.Location = new System.Drawing.Point(209, 21);
            this.btnListAllNotes.Name = "btnListAllNotes";
            this.btnListAllNotes.Size = new System.Drawing.Size(132, 23);
            this.btnListAllNotes.TabIndex = 22;
            this.btnListAllNotes.Text = "Get All Notes";
            this.btnListAllNotes.UseVisualStyleBackColor = true;
            this.btnListAllNotes.Click += new System.EventHandler(this.btnListAllNotes_Click);
            // 
            // numDelete
            // 
            this.numDelete.Location = new System.Drawing.Point(300, 300);
            this.numDelete.Name = "numDelete";
            this.numDelete.Size = new System.Drawing.Size(41, 20);
            this.numDelete.TabIndex = 23;
            this.numDelete.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpdateId
            // 
            this.numUpdateId.Location = new System.Drawing.Point(163, 300);
            this.numUpdateId.Name = "numUpdateId";
            this.numUpdateId.Size = new System.Drawing.Size(41, 20);
            this.numUpdateId.TabIndex = 24;
            this.numUpdateId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Note ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Note ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUpdateId);
            this.Controls.Add(this.numDelete);
            this.Controls.Add(this.btnListAllNotes);
            this.Controls.Add(this.txtCreateDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCreateTitle);
            this.Controls.Add(this.lblCreateTitle);
            this.Controls.Add(this.lblCreateNote);
            this.Controls.Add(this.btnCreateNote);
            this.Controls.Add(this.btnNewGetNote);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.numNoteID);
            this.Controls.Add(this.txtUpdateDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUpdateTitle);
            this.Controls.Add(this.lblUpdateTitle);
            this.Controls.Add(this.lblUpdateNote);
            this.Controls.Add(this.txtNoteDetails);
            this.Controls.Add(this.lblNoteDetails);
            this.Controls.Add(this.lblNoteID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numNoteID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoteID;
        private System.Windows.Forms.Label lblNoteDetails;
        private System.Windows.Forms.TextBox txtNoteDetails;
        private System.Windows.Forms.Label lblUpdateNote;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numNoteID;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewGetNote;
        private System.Windows.Forms.Button btnCreateNote;
        private System.Windows.Forms.Label lblCreateNote;
        private System.Windows.Forms.Label lblCreateTitle;
        private System.Windows.Forms.TextBox txtCreateTitle;
        private System.Windows.Forms.TextBox txtCreateDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListAllNotes;
        private System.Windows.Forms.NumericUpDown numDelete;
        private System.Windows.Forms.NumericUpDown numUpdateId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

