namespace Q2
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.resultLabelQ2 = new System.Windows.Forms.Label();
			this.resultButtonQ2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// resultLabelQ2
			// 
			this.resultLabelQ2.AutoSize = true;
			this.resultLabelQ2.Location = new System.Drawing.Point(384, 116);
			this.resultLabelQ2.Name = "resultLabelQ2";
			this.resultLabelQ2.Size = new System.Drawing.Size(33, 12);
			this.resultLabelQ2.TabIndex = 0;
			this.resultLabelQ2.Text = "label1";
			// 
			// resultButtonQ2
			// 
			this.resultButtonQ2.Location = new System.Drawing.Point(228, 111);
			this.resultButtonQ2.Name = "resultButtonQ2";
			this.resultButtonQ2.Size = new System.Drawing.Size(75, 23);
			this.resultButtonQ2.TabIndex = 1;
			this.resultButtonQ2.Text = "顯示";
			this.resultButtonQ2.UseVisualStyleBackColor = true;
			this.resultButtonQ2.Click += new System.EventHandler(this.resultButtonQ2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.resultButtonQ2);
			this.Controls.Add(this.resultLabelQ2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label resultLabelQ2;
		private System.Windows.Forms.Button resultButtonQ2;
	}
}

