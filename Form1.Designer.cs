namespace topoyunu
{
    partial class playground
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playground));
            this.raket = new System.Windows.Forms.PictureBox();
            this.kontroltimer = new System.Windows.Forms.Timer(this.components);
            this.top = new System.Windows.Forms.PictureBox();
            this.tophareket = new System.Windows.Forms.Timer(this.components);
            this.pg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            this.pg.SuspendLayout();
            this.SuspendLayout();
            // 
            // raket
            // 
            this.raket.BackColor = System.Drawing.Color.DarkRed;
            this.raket.Location = new System.Drawing.Point(346, 458);
            this.raket.Name = "raket";
            this.raket.Size = new System.Drawing.Size(100, 21);
            this.raket.TabIndex = 0;
            this.raket.TabStop = false;
            // 
            // kontroltimer
            // 
            this.kontroltimer.Enabled = true;
            this.kontroltimer.Interval = 10;
            this.kontroltimer.Tick += new System.EventHandler(this.kontroltimer_Tick);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.top.Image = ((System.Drawing.Image)(resources.GetObject("top.Image")));
            this.top.Location = new System.Drawing.Point(51, 115);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(10, 10);
            this.top.TabIndex = 1;
            this.top.TabStop = false;
            // 
            // tophareket
            // 
            this.tophareket.Enabled = true;
            this.tophareket.Interval = 10;
            this.tophareket.Tick += new System.EventHandler(this.tophareket_Tick);
            // 
            // pg
            // 
            this.pg.Controls.Add(this.label1);
            this.pg.Controls.Add(this.top);
            this.pg.Controls.Add(this.raket);
            this.pg.Location = new System.Drawing.Point(3, 0);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(896, 502);
            this.pg.TabIndex = 2;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(859, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // playground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 503);
            this.Controls.Add(this.pg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "playground";
            this.Text = "playground";
            this.Load += new System.EventHandler(this.playground_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playground_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.raket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            this.pg.ResumeLayout(false);
            this.pg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox raket;
        private System.Windows.Forms.Timer kontroltimer;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.Timer tophareket;
        private System.Windows.Forms.Panel pg;
        private System.Windows.Forms.Label label1;
    }
}

