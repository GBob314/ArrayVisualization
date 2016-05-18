namespace ArrayVisualization
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
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.insertSortBtn = new System.Windows.Forms.Button();
            this.drawArray = new System.Windows.Forms.Button();
            this.shuffleArrayBtn = new System.Windows.Forms.Button();
            this.selectSortBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingArea
            // 
            this.drawingArea.Location = new System.Drawing.Point(139, 12);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(793, 478);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.TabStop = false;
            // 
            // insertSortBtn
            // 
            this.insertSortBtn.Location = new System.Drawing.Point(12, 150);
            this.insertSortBtn.Name = "insertSortBtn";
            this.insertSortBtn.Size = new System.Drawing.Size(120, 63);
            this.insertSortBtn.TabIndex = 1;
            this.insertSortBtn.Text = "Insertion Sort!";
            this.insertSortBtn.UseVisualStyleBackColor = true;
            this.insertSortBtn.Click += new System.EventHandler(this.insertSortBtn_Click);
            // 
            // drawArray
            // 
            this.drawArray.Location = new System.Drawing.Point(12, 12);
            this.drawArray.Name = "drawArray";
            this.drawArray.Size = new System.Drawing.Size(121, 63);
            this.drawArray.TabIndex = 2;
            this.drawArray.Text = "Draw Array!";
            this.drawArray.UseVisualStyleBackColor = true;
            this.drawArray.Click += new System.EventHandler(this.drawArray_Click);
            // 
            // shuffleArrayBtn
            // 
            this.shuffleArrayBtn.Location = new System.Drawing.Point(12, 81);
            this.shuffleArrayBtn.Name = "shuffleArrayBtn";
            this.shuffleArrayBtn.Size = new System.Drawing.Size(121, 63);
            this.shuffleArrayBtn.TabIndex = 3;
            this.shuffleArrayBtn.Text = "Shuffle Array!";
            this.shuffleArrayBtn.UseVisualStyleBackColor = true;
            this.shuffleArrayBtn.Click += new System.EventHandler(this.shuffleArrayBtn_Click);
            // 
            // selectSortBtn
            // 
            this.selectSortBtn.Location = new System.Drawing.Point(12, 219);
            this.selectSortBtn.Name = "selectSortBtn";
            this.selectSortBtn.Size = new System.Drawing.Size(120, 63);
            this.selectSortBtn.TabIndex = 4;
            this.selectSortBtn.Text = "Selection Sort!";
            this.selectSortBtn.UseVisualStyleBackColor = true;
            this.selectSortBtn.Click += new System.EventHandler(this.selectSortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 498);
            this.Controls.Add(this.selectSortBtn);
            this.Controls.Add(this.shuffleArrayBtn);
            this.Controls.Add(this.drawArray);
            this.Controls.Add(this.insertSortBtn);
            this.Controls.Add(this.drawingArea);
            this.Name = "Form1";
            this.Text = "Sorting Visualization";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.Button insertSortBtn;
        private System.Windows.Forms.Button drawArray;
        private System.Windows.Forms.Button shuffleArrayBtn;
        private System.Windows.Forms.Button selectSortBtn;
    }
}

