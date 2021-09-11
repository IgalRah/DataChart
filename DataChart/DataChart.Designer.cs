
namespace DataChart
{
    partial class DataChart
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
            this.dataGridViewUpper = new System.Windows.Forms.DataGridView();
            this.dataGridViewLower = new System.Windows.Forms.DataGridView();
            this.boxFirstName = new System.Windows.Forms.TextBox();
            this.boxLastName = new System.Windows.Forms.TextBox();
            this.boxId = new System.Windows.Forms.TextBox();
            this.boxGetPerson = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelIdDeleteData = new System.Windows.Forms.Label();
            this.buttInsertData = new System.Windows.Forms.Button();
            this.buttGetPerson = new System.Windows.Forms.Button();
            this.buttDeleteData = new System.Windows.Forms.Button();
            this.buttRefresh = new System.Windows.Forms.Button();
            this.labelIdGetData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLower)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUpper
            // 
            this.dataGridViewUpper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpper.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUpper.Name = "dataGridViewUpper";
            this.dataGridViewUpper.RowTemplate.Height = 25;
            this.dataGridViewUpper.Size = new System.Drawing.Size(387, 150);
            this.dataGridViewUpper.TabIndex = 0;
            // 
            // dataGridViewLower
            // 
            this.dataGridViewLower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLower.Location = new System.Drawing.Point(12, 168);
            this.dataGridViewLower.Name = "dataGridViewLower";
            this.dataGridViewLower.RowTemplate.Height = 25;
            this.dataGridViewLower.Size = new System.Drawing.Size(387, 125);
            this.dataGridViewLower.TabIndex = 1;
            // 
            // boxFirstName
            // 
            this.boxFirstName.Location = new System.Drawing.Point(421, 35);
            this.boxFirstName.Name = "boxFirstName";
            this.boxFirstName.Size = new System.Drawing.Size(92, 23);
            this.boxFirstName.TabIndex = 2;
            // 
            // boxLastName
            // 
            this.boxLastName.Location = new System.Drawing.Point(421, 79);
            this.boxLastName.Name = "boxLastName";
            this.boxLastName.Size = new System.Drawing.Size(92, 23);
            this.boxLastName.TabIndex = 3;
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(544, 81);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(49, 23);
            this.boxId.TabIndex = 4;
            // 
            // boxGetPerson
            // 
            this.boxGetPerson.Location = new System.Drawing.Point(421, 238);
            this.boxGetPerson.Name = "boxGetPerson";
            this.boxGetPerson.Size = new System.Drawing.Size(49, 23);
            this.boxGetPerson.TabIndex = 5;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.Location = new System.Drawing.Point(421, 14);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(70, 18);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.Location = new System.Drawing.Point(421, 59);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(67, 18);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Last Name";
            // 
            // labelIdDeleteData
            // 
            this.labelIdDeleteData.AutoSize = true;
            this.labelIdDeleteData.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdDeleteData.Location = new System.Drawing.Point(544, 61);
            this.labelIdDeleteData.Name = "labelIdDeleteData";
            this.labelIdDeleteData.Size = new System.Drawing.Size(19, 18);
            this.labelIdDeleteData.TabIndex = 8;
            this.labelIdDeleteData.Text = "Id";
            // 
            // buttInsertData
            // 
            this.buttInsertData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttInsertData.Location = new System.Drawing.Point(421, 108);
            this.buttInsertData.Name = "buttInsertData";
            this.buttInsertData.Size = new System.Drawing.Size(92, 22);
            this.buttInsertData.TabIndex = 9;
            this.buttInsertData.Text = "Insert Data";
            this.buttInsertData.UseVisualStyleBackColor = true;
            this.buttInsertData.Click += new System.EventHandler(this.addButton);
            // 
            // buttGetPerson
            // 
            this.buttGetPerson.Location = new System.Drawing.Point(421, 266);
            this.buttGetPerson.Name = "buttGetPerson";
            this.buttGetPerson.Size = new System.Drawing.Size(92, 22);
            this.buttGetPerson.TabIndex = 10;
            this.buttGetPerson.Text = "Get Data";
            this.buttGetPerson.UseVisualStyleBackColor = true;
            this.buttGetPerson.Click += new System.EventHandler(this.getPersonButton);
            // 
            // buttDeleteData
            // 
            this.buttDeleteData.Location = new System.Drawing.Point(544, 108);
            this.buttDeleteData.Name = "buttDeleteData";
            this.buttDeleteData.Size = new System.Drawing.Size(92, 22);
            this.buttDeleteData.TabIndex = 11;
            this.buttDeleteData.Text = "Delete Data";
            this.buttDeleteData.UseVisualStyleBackColor = true;
            this.buttDeleteData.Click += new System.EventHandler(this.deleteButton);
            // 
            // buttRefresh
            // 
            this.buttRefresh.Location = new System.Drawing.Point(580, 266);
            this.buttRefresh.Name = "buttRefresh";
            this.buttRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttRefresh.TabIndex = 12;
            this.buttRefresh.Text = "Refresh";
            this.buttRefresh.UseVisualStyleBackColor = true;
            this.buttRefresh.Click += new System.EventHandler(this.refreshButton);
            // 
            // labelIdGetData
            // 
            this.labelIdGetData.AutoSize = true;
            this.labelIdGetData.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdGetData.Location = new System.Drawing.Point(421, 220);
            this.labelIdGetData.Name = "labelIdGetData";
            this.labelIdGetData.Size = new System.Drawing.Size(19, 18);
            this.labelIdGetData.TabIndex = 13;
            this.labelIdGetData.Text = "Id";
            // 
            // DataChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(667, 301);
            this.Controls.Add(this.labelIdGetData);
            this.Controls.Add(this.buttRefresh);
            this.Controls.Add(this.buttDeleteData);
            this.Controls.Add(this.buttGetPerson);
            this.Controls.Add(this.buttInsertData);
            this.Controls.Add(this.labelIdDeleteData);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.boxGetPerson);
            this.Controls.Add(this.boxId);
            this.Controls.Add(this.boxLastName);
            this.Controls.Add(this.boxFirstName);
            this.Controls.Add(this.dataGridViewLower);
            this.Controls.Add(this.dataGridViewUpper);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "DataChart";
            this.Text = "Data Chart";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Menu_Screen);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUpper;
        private System.Windows.Forms.DataGridView dataGridViewLower;
        private System.Windows.Forms.TextBox boxFirstName;
        private System.Windows.Forms.TextBox boxLastName;
        private System.Windows.Forms.TextBox boxId;
        private System.Windows.Forms.TextBox boxGetPerson;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelIdDeleteData;
        private System.Windows.Forms.Button buttInsertData;
        private System.Windows.Forms.Button buttGetPerson;
        private System.Windows.Forms.Button buttDeleteData;
        private System.Windows.Forms.Button buttRefresh;
        private System.Windows.Forms.Label labelIdGetData;
    }
}

