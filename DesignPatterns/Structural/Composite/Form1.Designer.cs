namespace Composite
{
    partial class Form1
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
            TreeNode treeNode1 = new TreeNode("Zeynep Mavuş");
            TreeNode treeNode2 = new TreeNode("FM", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Necati Yıldız");
            TreeNode treeNode4 = new TreeNode("TM", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("Türkay Ürkmez");
            TreeNode treeNode6 = new TreeNode("Ahmet Şaşmaz");
            TreeNode treeNode7 = new TreeNode("TS", new TreeNode[] { treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("9-C", new TreeNode[] { treeNode2, treeNode4, treeNode7 });
            treeViewSample = new TreeView();
            treeViewCategories = new TreeView();
            SuspendLayout();
            // 
            // treeViewSample
            // 
            treeViewSample.Location = new Point(43, 38);
            treeViewSample.Name = "treeViewSample";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Zeynep Mavuş";
            treeNode2.Name = "Node1";
            treeNode2.Text = "FM";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Necati Yıldız";
            treeNode4.Name = "Node2";
            treeNode4.Text = "TM";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Türkay Ürkmez";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Ahmet Şaşmaz";
            treeNode7.Name = "Node3";
            treeNode7.Text = "TS";
            treeNode8.Name = "Node0";
            treeNode8.Text = "9-C";
            treeViewSample.Nodes.AddRange(new TreeNode[] { treeNode8 });
            treeViewSample.Size = new Size(336, 342);
            treeViewSample.TabIndex = 0;
            // 
            // treeViewCategories
            // 
            treeViewCategories.Location = new Point(416, 45);
            treeViewCategories.Name = "treeViewCategories";
            treeViewCategories.Size = new Size(336, 335);
            treeViewCategories.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeViewCategories);
            Controls.Add(treeViewSample);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeViewSample;
        private TreeView treeViewCategories;
    }
}
