namespace PrjAssignment6
{
    partial class Form1
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
            this.appetizerComboBox = new System.Windows.Forms.ComboBox();
            this.bevComboBox = new System.Windows.Forms.ComboBox();
            this.dessertsComboBox = new System.Windows.Forms.ComboBox();
            this.mainsComboBox = new System.Windows.Forms.ComboBox();
            this.bevLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bevAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mainsAddButton = new System.Windows.Forms.Button();
            this.dessertAddButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.subttlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appetizerComboBox
            // 
            this.appetizerComboBox.FormattingEnabled = true;
            this.appetizerComboBox.Location = new System.Drawing.Point(146, 291);
            this.appetizerComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appetizerComboBox.Name = "appetizerComboBox";
            this.appetizerComboBox.Size = new System.Drawing.Size(183, 28);
            this.appetizerComboBox.TabIndex = 0;
            // 
            // bevComboBox
            // 
            this.bevComboBox.FormattingEnabled = true;
            this.bevComboBox.Location = new System.Drawing.Point(146, 110);
            this.bevComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bevComboBox.Name = "bevComboBox";
            this.bevComboBox.Size = new System.Drawing.Size(183, 28);
            this.bevComboBox.TabIndex = 1;
            // 
            // dessertsComboBox
            // 
            this.dessertsComboBox.FormattingEnabled = true;
            this.dessertsComboBox.Location = new System.Drawing.Point(396, 291);
            this.dessertsComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dessertsComboBox.Name = "dessertsComboBox";
            this.dessertsComboBox.Size = new System.Drawing.Size(185, 28);
            this.dessertsComboBox.TabIndex = 2;
            // 
            // mainsComboBox
            // 
            this.mainsComboBox.FormattingEnabled = true;
            this.mainsComboBox.Location = new System.Drawing.Point(396, 110);
            this.mainsComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainsComboBox.Name = "mainsComboBox";
            this.mainsComboBox.Size = new System.Drawing.Size(185, 28);
            this.mainsComboBox.TabIndex = 3;
            // 
            // bevLabel
            // 
            this.bevLabel.AutoSize = true;
            this.bevLabel.Location = new System.Drawing.Point(192, 61);
            this.bevLabel.Name = "bevLabel";
            this.bevLabel.Size = new System.Drawing.Size(85, 20);
            this.bevLabel.TabIndex = 4;
            this.bevLabel.Text = "Beverages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Appetizers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Main Courses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Desserts";
            // 
            // bevAdd
            // 
            this.bevAdd.Location = new System.Drawing.Point(146, 148);
            this.bevAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bevAdd.Name = "bevAdd";
            this.bevAdd.Size = new System.Drawing.Size(183, 48);
            this.bevAdd.TabIndex = 8;
            this.bevAdd.Text = "Add Beverage";
            this.bevAdd.UseVisualStyleBackColor = true;
            this.bevAdd.Click += new System.EventHandler(this.bevAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 329);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add Appetizer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainsAddButton
            // 
            this.mainsAddButton.Location = new System.Drawing.Point(396, 148);
            this.mainsAddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainsAddButton.Name = "mainsAddButton";
            this.mainsAddButton.Size = new System.Drawing.Size(186, 48);
            this.mainsAddButton.TabIndex = 10;
            this.mainsAddButton.Text = "Add Main Course";
            this.mainsAddButton.UseVisualStyleBackColor = true;
            this.mainsAddButton.Click += new System.EventHandler(this.mainsAddButton_Click);
            // 
            // dessertAddButton
            // 
            this.dessertAddButton.Location = new System.Drawing.Point(396, 329);
            this.dessertAddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dessertAddButton.Name = "dessertAddButton";
            this.dessertAddButton.Size = new System.Drawing.Size(186, 42);
            this.dessertAddButton.TabIndex = 11;
            this.dessertAddButton.Text = "Add Dessert";
            this.dessertAddButton.UseVisualStyleBackColor = true;
            this.dessertAddButton.Click += new System.EventHandler(this.dessertAddButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(146, 512);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(183, 29);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // subttlButton
            // 
            this.subttlButton.Location = new System.Drawing.Point(396, 512);
            this.subttlButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subttlButton.Name = "subttlButton";
            this.subttlButton.Size = new System.Drawing.Size(186, 29);
            this.subttlButton.TabIndex = 13;
            this.subttlButton.Text = "Subtotal";
            this.subttlButton.UseVisualStyleBackColor = true;
            this.subttlButton.Click += new System.EventHandler(this.subttlButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 585);
            this.Controls.Add(this.subttlButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dessertAddButton);
            this.Controls.Add(this.mainsAddButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bevAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bevLabel);
            this.Controls.Add(this.mainsComboBox);
            this.Controls.Add(this.dessertsComboBox);
            this.Controls.Add(this.bevComboBox);
            this.Controls.Add(this.appetizerComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox appetizerComboBox;
        private System.Windows.Forms.ComboBox bevComboBox;
        private System.Windows.Forms.ComboBox dessertsComboBox;
        private System.Windows.Forms.ComboBox mainsComboBox;
        private System.Windows.Forms.Label bevLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bevAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mainsAddButton;
        private System.Windows.Forms.Button dessertAddButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button subttlButton;
    }
}

