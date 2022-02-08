
namespace JMClicker
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BGW_BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTInput = new System.Windows.Forms.TextBox();
            this.NUMIntervalo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUMIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNStart
            // 
            this.BTNStart.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNStart.Location = new System.Drawing.Point(39, 88);
            this.BTNStart.Name = "BTNStart";
            this.BTNStart.Size = new System.Drawing.Size(230, 60);
            this.BTNStart.TabIndex = 1;
            this.BTNStart.Text = "Start";
            this.BTNStart.UseVisualStyleBackColor = true;
            this.BTNStart.Click += new System.EventHandler(this.BTNStart_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F);
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interval (ms)";
            // 
            // BGW_BackgroundWorker
            // 
            this.BGW_BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_BackgroundWorker_DoWork);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F);
            this.label2.Location = new System.Drawing.Point(165, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input";
            // 
            // TXTInput
            // 
            this.TXTInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXTInput.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14.25F);
            this.TXTInput.Location = new System.Drawing.Point(169, 48);
            this.TXTInput.Name = "TXTInput";
            this.TXTInput.ReadOnly = true;
            this.TXTInput.Size = new System.Drawing.Size(100, 33);
            this.TXTInput.TabIndex = 3;
            this.TXTInput.Text = "M";
            this.TXTInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTInput.Click += new System.EventHandler(this.TXTInput_Click);
            this.TXTInput.Enter += new System.EventHandler(this.TXTInput_Enter);
            this.TXTInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTInput_KeyDown);
            this.TXTInput.Leave += new System.EventHandler(this.TXTInput_Leave);
            // 
            // NUMIntervalo
            // 
            this.NUMIntervalo.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14.25F);
            this.NUMIntervalo.Location = new System.Drawing.Point(39, 49);
            this.NUMIntervalo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUMIntervalo.Name = "NUMIntervalo";
            this.NUMIntervalo.Size = new System.Drawing.Size(120, 33);
            this.NUMIntervalo.TabIndex = 2;
            this.NUMIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUMIntervalo.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.NUMIntervalo.ValueChanged += new System.EventHandler(this.NUMIntervalo_ValueChanged);
            this.NUMIntervalo.Click += new System.EventHandler(this.NUMIntervalo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 174);
            this.Controls.Add(this.NUMIntervalo);
            this.Controls.Add(this.TXTInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "JM Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUMIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNStart;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker BGW_BackgroundWorker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTInput;
        private System.Windows.Forms.NumericUpDown NUMIntervalo;
    }
}

