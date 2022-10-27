
namespace serviceManagementSystem
{
    partial class BdSelection
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
            this.btnCQL = new System.Windows.Forms.Button();
            this.btnSQL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCQL
            // 
            this.btnCQL.BackgroundImage = global::serviceManagementSystem.Properties.Resources._2560px_Cassandra_logo_svg;
            this.btnCQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCQL.FlatAppearance.BorderSize = 0;
            this.btnCQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCQL.Location = new System.Drawing.Point(424, 164);
            this.btnCQL.Name = "btnCQL";
            this.btnCQL.Size = new System.Drawing.Size(300, 250);
            this.btnCQL.TabIndex = 1;
            this.btnCQL.Text = " ";
            this.btnCQL.UseVisualStyleBackColor = true;
            this.btnCQL.Click += new System.EventHandler(this.btnCQL_Click);
            // 
            // btnSQL
            // 
            this.btnSQL.BackgroundImage = global::serviceManagementSystem.Properties.Resources.sql_server_logo;
            this.btnSQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSQL.FlatAppearance.BorderSize = 0;
            this.btnSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSQL.Location = new System.Drawing.Point(75, 164);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(300, 250);
            this.btnSQL.TabIndex = 0;
            this.btnSQL.Text = " ";
            this.btnSQL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione una base de datos";
            // 
            // BdSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCQL);
            this.Controls.Add(this.btnSQL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BdSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.Button btnCQL;
        private System.Windows.Forms.Label label1;
    }
}

