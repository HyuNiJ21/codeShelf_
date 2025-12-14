namespace Main
{
    partial class SettlementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvSettlement = new System.Windows.Forms.DataGridView();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.txtAvgPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLateSum = new System.Windows.Forms.TextBox();
            this.txtSumPrice = new System.Windows.Forms.TextBox();
            this.txtTotalCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettlement)).BeginInit();
            this.groupBoxPeriod.SuspendLayout();
            this.groupBoxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSettlement
            // 
            this.dgvSettlement.AllowUserToAddRows = false;
            this.dgvSettlement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSettlement.ColumnHeadersHeight = 46;
            this.dgvSettlement.Location = new System.Drawing.Point(19, 40);
            this.dgvSettlement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSettlement.MultiSelect = false;
            this.dgvSettlement.Name = "dgvSettlement";
            this.dgvSettlement.ReadOnly = true;
            this.dgvSettlement.RowHeadersWidth = 51;
            this.dgvSettlement.RowTemplate.Height = 27;
            this.dgvSettlement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSettlement.Size = new System.Drawing.Size(691, 378);
            this.dgvSettlement.TabIndex = 0;
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.Controls.Add(this.btnSearch);
            this.groupBoxPeriod.Controls.Add(this.dtpEnd);
            this.groupBoxPeriod.Controls.Add(this.dtpStart);
            this.groupBoxPeriod.Controls.Add(this.label2);
            this.groupBoxPeriod.Controls.Add(this.label1);
            this.groupBoxPeriod.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBoxPeriod.Location = new System.Drawing.Point(729, 40);
            this.groupBoxPeriod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPeriod.Size = new System.Drawing.Size(312, 144);
            this.groupBoxPeriod.TabIndex = 1;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "기간 선택";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(205, 105);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(66, 67);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(228, 29);
            this.dtpEnd.TabIndex = 3;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(66, 34);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(228, 29);
            this.dtpStart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "종료일:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "시작일:";
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.txtAvgPrice);
            this.groupBoxSummary.Controls.Add(this.label7);
            this.groupBoxSummary.Controls.Add(this.txtTotalSum);
            this.groupBoxSummary.Controls.Add(this.label6);
            this.groupBoxSummary.Controls.Add(this.txtLateSum);
            this.groupBoxSummary.Controls.Add(this.txtSumPrice);
            this.groupBoxSummary.Controls.Add(this.txtTotalCount);
            this.groupBoxSummary.Controls.Add(this.label5);
            this.groupBoxSummary.Controls.Add(this.label4);
            this.groupBoxSummary.Controls.Add(this.label3);
            this.groupBoxSummary.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBoxSummary.Location = new System.Drawing.Point(729, 204);
            this.groupBoxSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSummary.Size = new System.Drawing.Size(358, 220);
            this.groupBoxSummary.TabIndex = 2;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "요약 정보";
            // 
            // txtAvgPrice
            // 
            this.txtAvgPrice.Location = new System.Drawing.Point(163, 177);
            this.txtAvgPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAvgPrice.Name = "txtAvgPrice";
            this.txtAvgPrice.ReadOnly = true;
            this.txtAvgPrice.Size = new System.Drawing.Size(168, 29);
            this.txtAvgPrice.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(23, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "평균 매출:";
            // 
            // txtTotalSum
            // 
            this.txtTotalSum.Location = new System.Drawing.Point(163, 140);
            this.txtTotalSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalSum.Name = "txtTotalSum";
            this.txtTotalSum.ReadOnly = true;
            this.txtTotalSum.Size = new System.Drawing.Size(168, 29);
            this.txtTotalSum.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(23, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "총 매출:";
            // 
            // txtLateSum
            // 
            this.txtLateSum.Location = new System.Drawing.Point(163, 100);
            this.txtLateSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLateSum.Name = "txtLateSum";
            this.txtLateSum.ReadOnly = true;
            this.txtLateSum.Size = new System.Drawing.Size(168, 29);
            this.txtLateSum.TabIndex = 4;
            // 
            // txtSumPrice
            // 
            this.txtSumPrice.Location = new System.Drawing.Point(163, 64);
            this.txtSumPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSumPrice.Name = "txtSumPrice";
            this.txtSumPrice.ReadOnly = true;
            this.txtSumPrice.Size = new System.Drawing.Size(168, 29);
            this.txtSumPrice.TabIndex = 5;
            // 
            // txtTotalCount
            // 
            this.txtTotalCount.Location = new System.Drawing.Point(163, 26);
            this.txtTotalCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalCount.Name = "txtTotalCount";
            this.txtTotalCount.ReadOnly = true;
            this.txtTotalCount.Size = new System.Drawing.Size(168, 29);
            this.txtTotalCount.TabIndex = 6;
            this.txtTotalCount.TextChanged += new System.EventHandler(this.txtTotalCount_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(23, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "연체요금 합:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(23, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "기본요금 합:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(23, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "총 건수:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.Location = new System.Drawing.Point(897, 434);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(189, 54);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "돌아가기";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SettlementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1036, 526);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.groupBoxPeriod);
            this.Controls.Add(this.dgvSettlement);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettlementForm";
            this.Text = "정산관리";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettlement)).EndInit();
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSettlement;
        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.TextBox txtAvgPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLateSum;
        private System.Windows.Forms.TextBox txtSumPrice;
        private System.Windows.Forms.TextBox txtTotalCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}
