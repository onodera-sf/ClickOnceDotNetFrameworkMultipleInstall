namespace ClickOnceMultipleInstall
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
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.labelMode = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(491, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "ClickOnce で同一プロジェクトから発行されたプログラムを同一環境に複数インストールするサンプルです。";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "押しても意味のないボタン";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// labelMode
			// 
			this.labelMode.AutoSize = true;
			this.labelMode.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelMode.ForeColor = System.Drawing.Color.Red;
			this.labelMode.Location = new System.Drawing.Point(12, 68);
			this.labelMode.Name = "labelMode";
			this.labelMode.Size = new System.Drawing.Size(88, 33);
			this.labelMode.TabIndex = 2;
			this.labelMode.Text = "モード";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 161);
			this.Controls.Add(this.labelMode);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelMode;
	}
}

