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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bHit = new System.Windows.Forms.Button();
            this.bStay = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblPlayerTotal = new System.Windows.Forms.Label();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.lvDealer = new System.Windows.Forms.ListView();
            this.lvPlayer = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEALER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLAYER";
            // 
            // bHit
            // 
            this.bHit.Location = new System.Drawing.Point(12, 718);
            this.bHit.Name = "bHit";
            this.bHit.Size = new System.Drawing.Size(75, 23);
            this.bHit.TabIndex = 2;
            this.bHit.Text = "HIT";
            this.bHit.UseVisualStyleBackColor = true;
            this.bHit.Click += new System.EventHandler(this.bHit_Click);
            // 
            // bStay
            // 
            this.bStay.Location = new System.Drawing.Point(93, 718);
            this.bStay.Name = "bStay";
            this.bStay.Size = new System.Drawing.Size(75, 23);
            this.bStay.TabIndex = 3;
            this.bStay.Text = "STAY";
            this.bStay.UseVisualStyleBackColor = true;
            this.bStay.Click += new System.EventHandler(this.bStay_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(15, 390);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(35, 13);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "label3";
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(13, 58);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(35, 13);
            this.lblDealer.TabIndex = 5;
            this.lblDealer.Text = "label4";
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.AutoSize = true;
            this.lblPlayerTotal.Location = new System.Drawing.Point(88, 367);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerTotal.TabIndex = 6;
            this.lblPlayerTotal.Text = "label3";
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Location = new System.Drawing.Point(87, 27);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(35, 13);
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
            listViewItem1});
            this.lvPlayer.Location = new System.Drawing.Point(12, 406);
            this.lvPlayer.Name = "lvPlayer";
            this.lvPlayer.Size = new System.Drawing.Size(1127, 274);
            this.lvPlayer.TabIndex = 9;
            this.lvPlayer.UseCompatibleStateImageBehavior = false;
            // 
            // BlackJackTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1169, 788);
            this.Controls.Add(this.lvPlayer);
            this.Controls.Add(this.lvDealer);
            this.Controls.Add(this.lblDealerTotal);
            this.Controls.Add(this.lblPlayerTotal);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.lblPlayer);
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
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Label lblDealerTotal;
        private System.Windows.Forms.ListView lvDealer;
        private System.Windows.Forms.ListView lvPlayer;
    }
}

