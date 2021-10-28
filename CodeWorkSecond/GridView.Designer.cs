
namespace CodeWorkSecond
{
    partial class GridView
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
            this.dgwWorkers = new System.Windows.Forms.DataGridView();
            this.dgwWorker2 = new System.Windows.Forms.DataGridView();
            this.btnUpdateTime = new System.Windows.Forms.Button();
            this.tbxUpdateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorker2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwWorkers
            // 
            this.dgwWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwWorkers.Location = new System.Drawing.Point(35, 13);
            this.dgwWorkers.Name = "dgwWorkers";
            this.dgwWorkers.Size = new System.Drawing.Size(739, 212);
            this.dgwWorkers.TabIndex = 0;
            // 
            // dgwWorker2
            // 
            this.dgwWorker2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwWorker2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwWorker2.Location = new System.Drawing.Point(35, 259);
            this.dgwWorker2.Name = "dgwWorker2";
            this.dgwWorker2.Size = new System.Drawing.Size(739, 197);
            this.dgwWorker2.TabIndex = 1;
            // 
            // btnUpdateTime
            // 
            this.btnUpdateTime.Location = new System.Drawing.Point(1052, 22);
            this.btnUpdateTime.Name = "btnUpdateTime";
            this.btnUpdateTime.Size = new System.Drawing.Size(121, 45);
            this.btnUpdateTime.TabIndex = 2;
            this.btnUpdateTime.Text = "Update Time";
            this.btnUpdateTime.UseVisualStyleBackColor = true;
            this.btnUpdateTime.Click += new System.EventHandler(this.btnUpdateTime_Click);
            // 
            // tbxUpdateTime
            // 
            this.tbxUpdateTime.Location = new System.Drawing.Point(889, 35);
            this.tbxUpdateTime.Name = "tbxUpdateTime";
            this.tbxUpdateTime.Size = new System.Drawing.Size(146, 20);
            this.tbxUpdateTime.TabIndex = 3;
            // 
            // GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 672);
            this.Controls.Add(this.tbxUpdateTime);
            this.Controls.Add(this.btnUpdateTime);
            this.Controls.Add(this.dgwWorker2);
            this.Controls.Add(this.dgwWorkers);
            this.Name = "GridView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorker2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwWorkers;
        private System.Windows.Forms.DataGridView dgwWorker2;
        private System.Windows.Forms.Button btnUpdateTime;
        private System.Windows.Forms.TextBox tbxUpdateTime;
    }
}

