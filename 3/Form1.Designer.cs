namespace _3
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
            Open_Button = new Button();
            Name_TextBox = new TextBox();
            Table_DataGridView = new DataGridView();
            Info_RichTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)Table_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // Open_Button
            // 
            Open_Button.Location = new Point(44, 113);
            Open_Button.Name = "Open_Button";
            Open_Button.Size = new Size(468, 29);
            Open_Button.TabIndex = 0;
            Open_Button.Text = "Открыть файл";
            Open_Button.UseVisualStyleBackColor = true;
            // 
            // Name_TextBox
            // 
            Name_TextBox.Location = new Point(44, 54);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(468, 27);
            Name_TextBox.TabIndex = 1;
            // 
            // Table_DataGridView
            // 
            Table_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table_DataGridView.Location = new Point(44, 272);
            Table_DataGridView.Name = "Table_DataGridView";
            Table_DataGridView.RowHeadersWidth = 51;
            Table_DataGridView.RowTemplate.Height = 29;
            Table_DataGridView.Size = new Size(468, 408);
            Table_DataGridView.TabIndex = 2;
            // 
            // Info_RichTextBox
            // 
            Info_RichTextBox.Location = new Point(566, 533);
            Info_RichTextBox.Name = "Info_RichTextBox";
            Info_RichTextBox.Size = new Size(890, 147);
            Info_RichTextBox.TabIndex = 3;
            Info_RichTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 692);
            Controls.Add(Info_RichTextBox);
            Controls.Add(Table_DataGridView);
            Controls.Add(Name_TextBox);
            Controls.Add(Open_Button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Table_DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Open_Button;
        private TextBox Name_TextBox;
        private DataGridView Table_DataGridView;
        private RichTextBox Info_RichTextBox;
    }
}