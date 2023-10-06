namespace Catalog
{
    public partial class AddPopUpWindow
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
            OkButton = new Button();
            label1 = new Label();
            BookTitle = new TextBox();
            SageName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Location = new Point(254, 207);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 0;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 22);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // BookTitle
            // 
            BookTitle.Location = new Point(35, 55);
            BookTitle.Name = "BookTitle";
            BookTitle.Size = new Size(265, 27);
            BookTitle.TabIndex = 4;
            // 
            // SageName
            // 
            SageName.Location = new Point(35, 131);
            SageName.Name = "SageName";
            SageName.Size = new Size(265, 27);
            SageName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 95);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 7;
            label2.Text = "Sage";
            // 
            // AddPopUpWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 288);
            Controls.Add(label2);
            Controls.Add(SageName);
            Controls.Add(BookTitle);
            Controls.Add(label1);
            Controls.Add(OkButton);
            Name = "AddPopUpWindow";
            Text = "AddPopUpWindow";
            Load += AddPopUpWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private Label label1;
        private Label label3;
        private TextBox BookTitle;
        private TextBox SageName;
        private TextBox Price;
        private Label label2;
    }
}