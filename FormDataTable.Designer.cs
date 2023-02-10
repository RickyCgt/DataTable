namespace DataTable
{
    partial class FormDataTable
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
            this.ButtonFillDisplay = new System.Windows.Forms.Button();
            this.ListViewData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonSort = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UX_Feedback = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonFillDisplay
            // 
            this.ButtonFillDisplay.Location = new System.Drawing.Point(15, 12);
            this.ButtonFillDisplay.Name = "ButtonFillDisplay";
            this.ButtonFillDisplay.Size = new System.Drawing.Size(96, 23);
            this.ButtonFillDisplay.TabIndex = 0;
            this.ButtonFillDisplay.Text = "Fill and Display";
            this.ButtonFillDisplay.UseVisualStyleBackColor = true;
            this.ButtonFillDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonFillDisplay_MouseClick);
            // 
            // ListViewData
            // 
            this.ListViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListViewData.HideSelection = false;
            this.ListViewData.Location = new System.Drawing.Point(15, 51);
            this.ListViewData.Name = "ListViewData";
            this.ListViewData.Size = new System.Drawing.Size(312, 362);
            this.ListViewData.TabIndex = 4;
            this.ListViewData.UseCompatibleStateImageBehavior = false;
            this.ListViewData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Col_1";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Col_2";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Col_3";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Col_4";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Col_5";
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(117, 12);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(106, 23);
            this.ButtonSort.TabIndex = 5;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UX_Feedback});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(364, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UX_Feedback
            // 
            this.UX_Feedback.Name = "UX_Feedback";
            this.UX_Feedback.Size = new System.Drawing.Size(0, 17);
            // 
            // FormDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 469);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ListViewData);
            this.Controls.Add(this.ButtonFillDisplay);
            this.Name = "FormDataTable";
            this.Text = "My Data Table";
            this.Load += new System.EventHandler(this.FormDataTable_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFillDisplay;
        private System.Windows.Forms.ListView ListViewData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UX_Feedback;
    }
}

