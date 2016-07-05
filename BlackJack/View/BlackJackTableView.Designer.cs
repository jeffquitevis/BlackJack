namespace BlackJack.View
{
    partial class BlackJackTableView
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bHit = new System.Windows.Forms.Button();
            this.bStay = new System.Windows.Forms.Button();
            this.lblPlayerTotal = new System.Windows.Forms.Label();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.lvDealer = new System.Windows.Forms.ListView();
            this.lvPlayer = new System.Windows.Forms.ListView();
            this.bPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEALER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLAYER";
            // 
            // bHit
            // 
            this.bHit.Location = new System.Drawing.Point(12, 706);
            this.bHit.Name = "bHit";
            this.bHit.Size = new System.Drawing.Size(75, 35);
            this.bHit.TabIndex = 2;
            this.bHit.Text = "HIT";
            this.bHit.UseVisualStyleBackColor = true;
            this.bHit.Click += new System.EventHandler(this.bHit_Click);
            // 
            // bStay
            // 
            this.bStay.Location = new System.Drawing.Point(93, 706);
            this.bStay.Name = "bStay";
            this.bStay.Size = new System.Drawing.Size(75, 35);
            this.bStay.TabIndex = 3;
            this.bStay.Text = "STAY";
            this.bStay.UseVisualStyleBackColor = true;
            this.bStay.Click += new System.EventHandler(this.bStay_Click);
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.AutoSize = true;
            this.lblPlayerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPlayerTotal.Location = new System.Drawing.Point(133, 367);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(86, 31);
            this.lblPlayerTotal.TabIndex = 6;
            this.lblPlayerTotal.Text = "label3";
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDealerTotal.Location = new System.Drawing.Point(142, 27);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(86, 31);
            this.lblDealerTotal.TabIndex = 7;
            this.lblDealerTotal.Text = "label3";
            // 
            // lvDealer
            // 
            this.lvDealer.BackColor = System.Drawing.Color.Green;
            this.lvDealer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDealer.Location = new System.Drawing.Point(12, 74);
            this.lvDealer.Name = "lvDealer";
            this.lvDealer.Size = new System.Drawing.Size(1122, 274);
            this.lvDealer.TabIndex = 8;
            this.lvDealer.UseCompatibleStateImageBehavior = false;
            // 
            // lvPlayer
            // 
            this.lvPlayer.BackColor = System.Drawing.Color.Green;
            this.lvPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPlayer.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lvPlayer.Location = new System.Drawing.Point(12, 406);
            this.lvPlayer.Name = "lvPlayer";
            this.lvPlayer.Size = new System.Drawing.Size(1127, 274);
            this.lvPlayer.TabIndex = 9;
            this.lvPlayer.UseCompatibleStateImageBehavior = false;
            // 
            // bPlay
            // 
            this.bPlay.Location = new System.Drawing.Point(174, 706);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(110, 35);
            this.bPlay.TabIndex = 10;
            this.bPlay.Text = "PLAY AGAIN";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // BlackJackTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1169, 788);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.lvPlayer);
            this.Controls.Add(this.lvDealer);
            this.Controls.Add(this.lblDealerTotal);
            this.Controls.Add(this.lblPlayerTotal);
            this.Controls.Add(this.bStay);
            this.Controls.Add(this.bHit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BlackJackTableView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bHit;
        private System.Windows.Forms.Button bStay;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Label lblDealerTotal;
        private System.Windows.Forms.ListView lvDealer;
        private System.Windows.Forms.ListView lvPlayer;
        private System.Windows.Forms.Button bPlay;
    }
}

