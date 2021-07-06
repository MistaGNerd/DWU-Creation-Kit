namespace DWCreationKit
{
    partial class ThemeObjectBrowser
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Chrome");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Events");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Flagshapes");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Messages");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Components");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Resources");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("UI", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Theme Objects", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnFilterButton = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(-2, 29);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "chrome";
            treeNode9.Text = "Chrome";
            treeNode10.Name = "events";
            treeNode10.Text = "Events";
            treeNode11.Name = "flagshapes";
            treeNode11.Text = "Flagshapes";
            treeNode12.Name = "messages";
            treeNode12.Text = "Messages";
            treeNode13.Name = "components";
            treeNode13.Text = "Components";
            treeNode14.Name = "resources";
            treeNode14.Text = "Resources";
            treeNode15.Name = "ui";
            treeNode15.Text = "UI";
            treeNode16.Name = "themeObjects";
            treeNode16.Text = "Theme Objects";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(195, 242);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnFilterButton
            // 
            this.btnFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterButton.Location = new System.Drawing.Point(165, 1);
            this.btnFilterButton.Name = "btnFilterButton";
            this.btnFilterButton.Size = new System.Drawing.Size(20, 23);
            this.btnFilterButton.TabIndex = 3;
            this.btnFilterButton.Text = ".";
            this.btnFilterButton.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(34, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(125, 20);
            this.txtFilter.TabIndex = 4;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(3, 6);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Filter:";
            // 
            // ThemeObjectBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 271);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnFilterButton);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemeObjectBrowser";
            this.Text = "Object Browser";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnFilterButton;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
    }
}