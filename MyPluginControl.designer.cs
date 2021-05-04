
namespace AshV.PortalTranslator.XTB
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSample = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flLeftPane = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flpRightMain = new System.Windows.Forms.FlowLayoutPanel();
            this.grpTranlate = new System.Windows.Forms.GroupBox();
            this.tabBaseTranslate = new System.Windows.Forms.TabControl();
            this.tabPageValue = new System.Windows.Forms.TabPage();
            this.tabPageRender = new System.Windows.Forms.TabPage();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grpTranlate.SuspendLayout();
            this.tabBaseTranslate.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSample});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1209, 31);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbSample
            // 
            this.tsbSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(94, 28);
            this.tsbSample.Text = "Load Portals";
            this.tsbSample.Click += new System.EventHandler(this.tsbSample_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flLeftPane);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1209, 686);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 5;
            // 
            // flLeftPane
            // 
            this.flLeftPane.AutoScroll = true;
            this.flLeftPane.AutoSize = true;
            this.flLeftPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flLeftPane.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flLeftPane.Location = new System.Drawing.Point(0, 0);
            this.flLeftPane.Name = "flLeftPane";
            this.flLeftPane.Size = new System.Drawing.Size(369, 686);
            this.flLeftPane.TabIndex = 0;
            this.flLeftPane.WrapContents = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grpTranlate);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flpRightMain);
            this.splitContainer2.Size = new System.Drawing.Size(836, 686);
            this.splitContainer2.SplitterDistance = 204;
            this.splitContainer2.TabIndex = 0;
            // 
            // flpRightMain
            // 
            this.flpRightMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRightMain.Location = new System.Drawing.Point(0, 0);
            this.flpRightMain.Name = "flpRightMain";
            this.flpRightMain.Size = new System.Drawing.Size(836, 478);
            this.flpRightMain.TabIndex = 0;
            // 
            // grpTranlate
            // 
            this.grpTranlate.Controls.Add(this.btnTranslate);
            this.grpTranlate.Controls.Add(this.tabBaseTranslate);
            this.grpTranlate.Location = new System.Drawing.Point(12, 3);
            this.grpTranlate.Name = "grpTranlate";
            this.grpTranlate.Size = new System.Drawing.Size(805, 189);
            this.grpTranlate.TabIndex = 0;
            this.grpTranlate.TabStop = false;
            this.grpTranlate.Text = "Portal Translator";
            // 
            // tabBaseTranslate
            // 
            this.tabBaseTranslate.Controls.Add(this.tabPageValue);
            this.tabBaseTranslate.Controls.Add(this.tabPageRender);
            this.tabBaseTranslate.Location = new System.Drawing.Point(6, 21);
            this.tabBaseTranslate.Name = "tabBaseTranslate";
            this.tabBaseTranslate.SelectedIndex = 0;
            this.tabBaseTranslate.Size = new System.Drawing.Size(494, 138);
            this.tabBaseTranslate.TabIndex = 0;
            // 
            // tabPageValue
            // 
            this.tabPageValue.Location = new System.Drawing.Point(4, 25);
            this.tabPageValue.Name = "tabPageValue";
            this.tabPageValue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageValue.Size = new System.Drawing.Size(192, 71);
            this.tabPageValue.TabIndex = 0;
            this.tabPageValue.Text = "tabPage1";
            this.tabPageValue.UseVisualStyleBackColor = true;
            // 
            // tabPageRender
            // 
            this.tabPageRender.Location = new System.Drawing.Point(4, 25);
            this.tabPageRender.Name = "tabPageRender";
            this.tabPageRender.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRender.Size = new System.Drawing.Size(486, 109);
            this.tabPageRender.TabIndex = 1;
            this.tabPageRender.Text = "tabPage2";
            this.tabPageRender.UseVisualStyleBackColor = true;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(571, 72);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(90, 23);
            this.btnTranslate.TabIndex = 1;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1209, 717);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grpTranlate.ResumeLayout(false);
            this.tabBaseTranslate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flLeftPane;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flpRightMain;
        private System.Windows.Forms.GroupBox grpTranlate;
        private System.Windows.Forms.TabControl tabBaseTranslate;
        private System.Windows.Forms.TabPage tabPageValue;
        private System.Windows.Forms.TabPage tabPageRender;
        private System.Windows.Forms.Button btnTranslate;
    }
}
