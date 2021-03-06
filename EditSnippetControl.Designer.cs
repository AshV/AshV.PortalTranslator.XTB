
namespace AshV.PortalTranslator.XTB
{
    partial class EditSnippetControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Type = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabPageRender = new System.Windows.Forms.TabPage();
            this.wbValue = new System.Windows.Forms.WebBrowser();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.tabValue = new System.Windows.Forms.TabControl();
            this.tabPageRender.SuspendLayout();
            this.tabPageText.SuspendLayout();
            this.tabValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(936, 10);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(49, 17);
            this.Type.TabIndex = 4;
            this.Type.Text = "Type:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(1027, 10);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(54, 17);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "lblType";
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Language.Location = new System.Drawing.Point(936, 31);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(85, 17);
            this.Language.TabIndex = 6;
            this.Language.Text = "Language:";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(1027, 31);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(86, 17);
            this.lblLanguage.TabIndex = 7;
            this.lblLanguage.Text = "lblLanguage";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(939, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 30);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabPageRender
            // 
            this.tabPageRender.Controls.Add(this.wbValue);
            this.tabPageRender.Location = new System.Drawing.Point(4, 25);
            this.tabPageRender.Name = "tabPageRender";
            this.tabPageRender.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRender.Size = new System.Drawing.Size(922, 195);
            this.tabPageRender.TabIndex = 2;
            this.tabPageRender.Text = "Render";
            this.tabPageRender.UseVisualStyleBackColor = true;
            // 
            // wbValue
            // 
            this.wbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbValue.Location = new System.Drawing.Point(3, 3);
            this.wbValue.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbValue.Name = "wbValue";
            this.wbValue.Size = new System.Drawing.Size(916, 189);
            this.wbValue.TabIndex = 0;
            // 
            // tabPageText
            // 
            this.tabPageText.Controls.Add(this.txtValue);
            this.tabPageText.Location = new System.Drawing.Point(4, 25);
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageText.Size = new System.Drawing.Size(922, 102);
            this.tabPageText.TabIndex = 1;
            this.tabPageText.Text = "Text";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Location = new System.Drawing.Point(3, 3);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(916, 96);
            this.txtValue.TabIndex = 0;
            // 
            // tabValue
            // 
            this.tabValue.Controls.Add(this.tabPageText);
            this.tabValue.Controls.Add(this.tabPageRender);
            this.tabValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabValue.Location = new System.Drawing.Point(0, 0);
            this.tabValue.Name = "tabValue";
            this.tabValue.SelectedIndex = 0;
            this.tabValue.Size = new System.Drawing.Size(930, 131);
            this.tabValue.TabIndex = 8;
            // 
            // EditSnippetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tabValue);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.Type);
            this.Name = "EditSnippetControl";
            this.Size = new System.Drawing.Size(1216, 131);
            this.Load += new System.EventHandler(this.EditSnippetControl_Load);
            this.tabPageRender.ResumeLayout(false);
            this.tabPageText.ResumeLayout(false);
            this.tabPageText.PerformLayout();
            this.tabValue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabPage tabPageRender;
        private System.Windows.Forms.WebBrowser wbValue;
        private System.Windows.Forms.TabPage tabPageText;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TabControl tabValue;
    }
}
