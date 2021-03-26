
namespace TesteSyncFusion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.sfDataGrid2 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 77);
            this.panel1.TabIndex = 1;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AddNewRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Bottom;
            this.sfDataGrid1.AllowDeleting = true;
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.AllowGrouping = false;
            this.sfDataGrid1.AllowSorting = false;
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(10, 69);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.ShowSortNumbers = true;
            this.sfDataGrid1.Size = new System.Drawing.Size(518, 337);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // ofd1
            // 
            this.ofd1.DefaultExt = "xlsx";
            this.ofd1.FileName = "openFileDialog";
            this.ofd1.Filter = "\"Excel Files|*.xls;*.xlsx;*.xlsm\"";
            this.ofd1.FilterIndex = 2;
            this.ofd1.RestoreDirectory = true;
            this.ofd1.Title = "Localizar Arquivo";
            // 
            // sfDataGrid2
            // 
            this.sfDataGrid2.AccessibleName = "Table";
            this.sfDataGrid2.AllowDeleting = true;
            this.sfDataGrid2.AllowDrop = true;
            this.sfDataGrid2.AllowFiltering = true;
            this.sfDataGrid2.AllowSelectionOnMouseDown = true;
            this.sfDataGrid2.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid2.Location = new System.Drawing.Point(12, 69);
            this.sfDataGrid2.Name = "sfDataGrid2";
            this.sfDataGrid2.ShowGroupDropArea = true;
            this.sfDataGrid2.ShowSortNumbers = true;
            this.sfDataGrid2.ShowValidationErrorToolTip = false;
            this.sfDataGrid2.Size = new System.Drawing.Size(516, 332);
            this.sfDataGrid2.TabIndex = 0;
            this.sfDataGrid2.Text = "sfDataGrid2";
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(516, 57);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)(((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom) 
            | System.Windows.Forms.Border3DSide.Middle)));
            this.gradientLabel1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(12, 9);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(516, 57);
            this.gradientLabel1.TabIndex = 1;
            this.gradientLabel1.Text = "  TESTE SYNCFUSION";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(467, 17);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(52, 41);
            this.BtnSelectFile.TabIndex = 2;
            this.BtnSelectFile.Text = "Abrir EXCEL";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(540, 411);
            this.Controls.Add(this.BtnSelectFile);
            this.Controls.Add(this.gradientLabel1);
            this.Controls.Add(this.sfDataGrid2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid2;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private System.Windows.Forms.Button BtnSelectFile;
    }
}

