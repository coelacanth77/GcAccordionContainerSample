namespace GcAccordionContainerSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.gcAccordionContainer1 = new GrapeCity.Win.Containers.GcAccordionContainer();
            this.gcAccordionItem1 = new GrapeCity.Win.Containers.GcAccordionItem();
            this.gcAccordionItem2 = new GrapeCity.Win.Containers.GcAccordionItem();
            this.gcAccordionItem3 = new GrapeCity.Win.Containers.GcAccordionItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcAccordionContainer1)).BeginInit();
            this.gcAccordionContainer1.SuspendLayout();
            this.gcAccordionItem1.Panel.SuspendLayout();
            this.gcAccordionItem1.SuspendLayout();
            this.gcAccordionItem2.Panel.SuspendLayout();
            this.gcAccordionItem2.SuspendLayout();
            this.gcAccordionItem3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcAccordionContainer1
            // 
            this.gcAccordionContainer1.ExpandMode = GrapeCity.Win.Containers.ExpandMode.Single;
            this.gcAccordionContainer1.Items.Add(this.gcAccordionItem1);
            this.gcAccordionContainer1.Items.Add(this.gcAccordionItem2);
            this.gcAccordionContainer1.Items.Add(this.gcAccordionItem3);
            this.gcAccordionContainer1.Location = new System.Drawing.Point(12, 12);
            this.gcAccordionContainer1.Name = "gcAccordionContainer1";
            this.gcAccordionContainer1.Size = new System.Drawing.Size(268, 340);
            this.gcAccordionContainer1.TabIndex = 0;
            // 
            // gcAccordionItem1
            // 
            this.gcAccordionItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gcAccordionItem1.DesignSize = new System.Drawing.Size(248, 240);
            this.gcAccordionItem1.IsExpanded = false;
            this.gcAccordionItem1.Location = new System.Drawing.Point(10, 10);
            this.gcAccordionItem1.Name = "gcAccordionItem1";
            // 
            // gcAccordionItem1.InnerPannel
            // 
            this.gcAccordionItem1.Panel.Controls.Add(this.button1);
            this.gcAccordionItem1.Panel.Name = "InnerPannel";
            this.gcAccordionItem1.Panel.TabIndex = 0;
            this.gcAccordionItem1.Size = new System.Drawing.Size(248, 30);
            this.gcAccordionItem1.TabIndex = 2;
            this.gcAccordionItem1.Text = "アコーディオン1";
            // 
            // gcAccordionItem2
            // 
            this.gcAccordionItem2.BackColor = System.Drawing.Color.LightCoral;
            this.gcAccordionItem2.DesignSize = new System.Drawing.Size(248, 240);
            this.gcAccordionItem2.IsExpanded = false;
            this.gcAccordionItem2.Location = new System.Drawing.Point(10, 50);
            this.gcAccordionItem2.Name = "gcAccordionItem2";
            // 
            // gcAccordionItem2.InnerPannel
            // 
            this.gcAccordionItem2.Panel.Controls.Add(this.textBox1);
            this.gcAccordionItem2.Panel.Name = "InnerPannel";
            this.gcAccordionItem2.Panel.TabIndex = 0;
            this.gcAccordionItem2.Size = new System.Drawing.Size(248, 30);
            this.gcAccordionItem2.TabIndex = 3;
            this.gcAccordionItem2.Text = "アコーディオン2";
            // 
            // gcAccordionItem3
            // 
            this.gcAccordionItem3.BackColor = System.Drawing.Color.Khaki;
            this.gcAccordionItem3.DesignSize = new System.Drawing.Size(248, 240);
            this.gcAccordionItem3.Location = new System.Drawing.Point(10, 90);
            this.gcAccordionItem3.Name = "gcAccordionItem3";
            // 
            // gcAccordionItem3.InnerPannel
            // 
            this.gcAccordionItem3.Panel.Name = "InnerPannel";
            this.gcAccordionItem3.Panel.TabIndex = 0;
            this.gcAccordionItem3.Size = new System.Drawing.Size(248, 240);
            this.gcAccordionItem3.TabIndex = 4;
            this.gcAccordionItem3.Text = "アコーディオン3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "アコーディオン2の情報を読み取ります";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "テスト";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 367);
            this.Controls.Add(this.gcAccordionContainer1);
            this.Name = "Form1";
            this.Text = "ca";
            ((System.ComponentModel.ISupportInitialize)(this.gcAccordionContainer1)).EndInit();
            this.gcAccordionContainer1.ResumeLayout(false);
            this.gcAccordionItem1.Panel.ResumeLayout(false);
            this.gcAccordionItem1.ResumeLayout(false);
            this.gcAccordionItem2.Panel.ResumeLayout(false);
            this.gcAccordionItem2.Panel.PerformLayout();
            this.gcAccordionItem2.ResumeLayout(false);
            this.gcAccordionItem3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GrapeCity.Win.Containers.GcAccordionContainer gcAccordionContainer1;
        private GrapeCity.Win.Containers.GcAccordionItem gcAccordionItem1;
        private GrapeCity.Win.Containers.GcAccordionItem gcAccordionItem2;
        private GrapeCity.Win.Containers.GcAccordionItem gcAccordionItem3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

