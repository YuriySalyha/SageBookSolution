namespace Catalog
{
    partial class Form1 : Form
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
            addButton = new Button();
            EditButton = new Button();
            ClearListBoxButton = new Button();
            ItemsBox = new ListBox();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 288);
            addButton.Name = "addButton";
            addButton.Size = new Size(579, 29);
            addButton.TabIndex = 1;
            addButton.Text = "Add Item";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(12, 323);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(579, 29);
            EditButton.TabIndex = 2;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // ClearListBoxButton
            // 
            ClearListBoxButton.Location = new Point(12, 393);
            ClearListBoxButton.Name = "ClearListBoxButton";
            ClearListBoxButton.Size = new Size(579, 29);
            ClearListBoxButton.TabIndex = 4;
            ClearListBoxButton.Text = "Clear Box";
            ClearListBoxButton.UseVisualStyleBackColor = true;
            ClearListBoxButton.Click += ClearListBoxButton_Click;
            // 
            // ItemsBox
            // 
            ItemsBox.FormattingEnabled = true;
            ItemsBox.ItemHeight = 20;
            ItemsBox.Location = new Point(12, 12);
            ItemsBox.Name = "ItemsBox";
            ItemsBox.Size = new Size(579, 184);
            ItemsBox.TabIndex = 6;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(12, 358);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(579, 29);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Delete Item";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(DeleteButton);
            Controls.Add(ItemsBox);
            Controls.Add(ClearListBoxButton);
            Controls.Add(EditButton);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button addButton;
        private Button EditButton;
        private Button ClearListBoxButton;
        private ListBox ItemsBox;
        private Button DeleteButton;
    }
}