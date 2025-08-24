namespace MovieRecommendationApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnGetRecommendations;
        private System.Windows.Forms.ListBox listBoxMovies;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnGetRecommendations = new System.Windows.Forms.Button();
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎬 Movie Recommendation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.Location = new System.Drawing.Point(30, 65);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 19);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Genre:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRating.Location = new System.Drawing.Point(30, 105);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(54, 19);
            this.lblRating.TabIndex = 2;
            this.lblRating.Text = "Rating:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(30, 145);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 19);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year:";
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGenre.Location = new System.Drawing.Point(100, 62);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(150, 25);
            this.txtGenre.TabIndex = 4;
            // 
            // txtRating
            // 
            this.txtRating.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRating.Location = new System.Drawing.Point(100, 102);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(150, 25);
            this.txtRating.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYear.Location = new System.Drawing.Point(100, 142);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(150, 25);
            this.txtYear.TabIndex = 6;
            // 
            // btnGetRecommendations
            // 
            this.btnGetRecommendations.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGetRecommendations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetRecommendations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetRecommendations.ForeColor = System.Drawing.Color.White;
            this.btnGetRecommendations.Location = new System.Drawing.Point(280, 62);
            this.btnGetRecommendations.Name = "btnGetRecommendations";
            this.btnGetRecommendations.Size = new System.Drawing.Size(180, 50);
            this.btnGetRecommendations.TabIndex = 7;
            this.btnGetRecommendations.Text = "Get Recommendations";
            this.btnGetRecommendations.UseVisualStyleBackColor = false;
            this.btnGetRecommendations.Click += new System.EventHandler(this.btnGetRecommendations_Click);
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.ItemHeight = 17;
            this.listBoxMovies.Location = new System.Drawing.Point(30, 190);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(430, 174);
            this.listBoxMovies.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.Controls.Add(this.listBoxMovies);
            this.Controls.Add(this.btnGetRecommendations);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Recommendation System";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}