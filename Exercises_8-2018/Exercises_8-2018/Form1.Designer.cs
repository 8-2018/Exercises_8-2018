namespace Exercises_8_2018
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
            this.listBoxExerciseResults = new System.Windows.Forms.ListBox();
            this.labelExerciseResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxExerciseResults
            // 
            this.listBoxExerciseResults.FormattingEnabled = true;
            this.listBoxExerciseResults.ItemHeight = 20;
            this.listBoxExerciseResults.Location = new System.Drawing.Point(208, 40);
            this.listBoxExerciseResults.Name = "listBoxExerciseResults";
            this.listBoxExerciseResults.Size = new System.Drawing.Size(555, 364);
            this.listBoxExerciseResults.TabIndex = 0;
            // 
            // labelExerciseResult
            // 
            this.labelExerciseResult.AutoSize = true;
            this.labelExerciseResult.Location = new System.Drawing.Point(91, 40);
            this.labelExerciseResult.Name = "labelExerciseResult";
            this.labelExerciseResult.Size = new System.Drawing.Size(111, 20);
            this.labelExerciseResult.TabIndex = 1;
            this.labelExerciseResult.Text = "Exercise results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelExerciseResult);
            this.Controls.Add(this.listBoxExerciseResults);
            this.Name = "Form1";
            this.Text = "Exercise Results";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxExerciseResults;
        private System.Windows.Forms.Label labelExerciseResult;
    }
}

