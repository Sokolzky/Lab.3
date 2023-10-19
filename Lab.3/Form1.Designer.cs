namespace Lab._3
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
            dishSizeLabel = new Label();
            dishSizeTB = new TextBox();
            persentageOfSpiritTB = new TextBox();
            percentageOfSpipritLabel = new Label();
            quatityOfDishesTB = new TextBox();
            quantityOfDishesLabel = new Label();
            resultTB = new TextBox();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // dishSizeLabel
            // 
            dishSizeLabel.AutoSize = true;
            dishSizeLabel.Location = new Point(18, 43);
            dishSizeLabel.Name = "dishSizeLabel";
            dishSizeLabel.Size = new Size(103, 15);
            dishSizeLabel.TabIndex = 0;
            dishSizeLabel.Text = "Wielkość naczynia";
            // 
            // dishSizeTB
            // 
            dishSizeTB.Location = new Point(127, 40);
            dishSizeTB.Name = "dishSizeTB";
            dishSizeTB.Size = new Size(100, 23);
            dishSizeTB.TabIndex = 1;
            dishSizeTB.TextChanged += dishSizeTB_TextChanged;
            // 
            // persentageOfSpiritTB
            // 
            persentageOfSpiritTB.Location = new Point(202, 114);
            persentageOfSpiritTB.Name = "persentageOfSpiritTB";
            persentageOfSpiritTB.Size = new Size(100, 23);
            persentageOfSpiritTB.TabIndex = 3;
            persentageOfSpiritTB.TextChanged += persentageOfSpiritTB_TextChanged;
            // 
            // percentageOfSpipritLabel
            // 
            percentageOfSpipritLabel.AutoSize = true;
            percentageOfSpipritLabel.Location = new Point(18, 117);
            percentageOfSpipritLabel.Name = "percentageOfSpipritLabel";
            percentageOfSpipritLabel.Size = new Size(178, 15);
            percentageOfSpipritLabel.TabIndex = 2;
            percentageOfSpipritLabel.Text = "Zawartość procentowa spirytusu";
            // 
            // quatityOfDishesTB
            // 
            quatityOfDishesTB.Location = new Point(96, 192);
            quatityOfDishesTB.Name = "quatityOfDishesTB";
            quatityOfDishesTB.Size = new Size(100, 23);
            quatityOfDishesTB.TabIndex = 5;
            quatityOfDishesTB.TextChanged += quatityOfDishesTB_TextChanged;
            // 
            // quantityOfDishesLabel
            // 
            quantityOfDishesLabel.AutoSize = true;
            quantityOfDishesLabel.Location = new Point(18, 195);
            quantityOfDishesLabel.Name = "quantityOfDishesLabel";
            quantityOfDishesLabel.Size = new Size(71, 15);
            quantityOfDishesLabel.TabIndex = 4;
            quantityOfDishesLabel.Text = "Ilość naczyń";
            // 
            // resultTB
            // 
            resultTB.Location = new Point(110, 280);
            resultTB.Name = "resultTB";
            resultTB.Size = new Size(281, 23);
            resultTB.TabIndex = 6;
            resultTB.TextChanged += resultTB_TextChanged;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(18, 279);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 7;
            confirmButton.Text = "Policz";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(confirmButton);
            Controls.Add(resultTB);
            Controls.Add(quatityOfDishesTB);
            Controls.Add(quantityOfDishesLabel);
            Controls.Add(persentageOfSpiritTB);
            Controls.Add(percentageOfSpipritLabel);
            Controls.Add(dishSizeTB);
            Controls.Add(dishSizeLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dishSizeLabel;
        private TextBox dishSizeTB;
        private TextBox persentageOfSpiritTB;
        private Label percentageOfSpipritLabel;
        private TextBox quatityOfDishesTB;
        private Label quantityOfDishesLabel;
        private TextBox resultTB;
        private Button confirmButton;
    }
}