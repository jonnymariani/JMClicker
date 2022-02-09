
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTNStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BGW_BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTInput = new System.Windows.Forms.TextBox();
            this.BTNCloseForm = new System.Windows.Forms.Button();
            this.BTNMinimizeForm = new System.Windows.Forms.Button();
            this.NUMIntervalo = new JMClicker.CleanNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUMIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNStart
            // 
            this.BTNStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BTNStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.BTNStart.FlatAppearance.BorderSize = 0;
            this.BTNStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BTNStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.BTNStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNStart.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.BTNStart.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNStart.Location = new System.Drawing.Point(50, 124);
            this.BTNStart.Name = "BTNStart";
            this.BTNStart.Size = new System.Drawing.Size(246, 60);
            this.BTNStart.TabIndex = 1;
            this.BTNStart.Text = "Start";
            this.BTNStart.UseVisualStyleBackColor = false;
            this.BTNStart.Click += new System.EventHandler(this.BTNStart_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
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
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(172, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input";
            // 
            // TXTInput
            // 
            this.TXTInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TXTInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXTInput.Font = new System.Drawing.Font("Malgun Gothic", 19.5F, System.Drawing.FontStyle.Bold);
            this.TXTInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXTInput.Location = new System.Drawing.Point(176, 71);
            this.TXTInput.Name = "TXTInput";
            this.TXTInput.ReadOnly = true;
            this.TXTInput.Size = new System.Drawing.Size(120, 35);
            this.TXTInput.TabIndex = 3;
            this.TXTInput.Text = "M";
            this.TXTInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTInput.Click += new System.EventHandler(this.TXTInput_Click);
            this.TXTInput.TextChanged += new System.EventHandler(this.TXTInput_TextChanged);
            this.TXTInput.Enter += new System.EventHandler(this.TXTInput_Enter);
            this.TXTInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTInput_KeyDown);
            this.TXTInput.Leave += new System.EventHandler(this.TXTInput_Leave);
            // 
            // BTNCloseForm
            // 
            this.BTNCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.BTNCloseForm.FlatAppearance.BorderSize = 0;
            this.BTNCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BTNCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCloseForm.Font = new System.Drawing.Font("Miriam Libre", 10F, System.Drawing.FontStyle.Italic);
            this.BTNCloseForm.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNCloseForm.Location = new System.Drawing.Point(301, 12);
            this.BTNCloseForm.Name = "BTNCloseForm";
            this.BTNCloseForm.Size = new System.Drawing.Size(30, 30);
            this.BTNCloseForm.TabIndex = 4;
            this.BTNCloseForm.Text = "x";
            this.BTNCloseForm.UseVisualStyleBackColor = false;
            this.BTNCloseForm.Click += new System.EventHandler(this.BTNCloseForm_Click);
            // 
            // BTNMinimizeForm
            // 
            this.BTNMinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.BTNMinimizeForm.FlatAppearance.BorderSize = 0;
            this.BTNMinimizeForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BTNMinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMinimizeForm.Font = new System.Drawing.Font("Miriam Libre", 10F, System.Drawing.FontStyle.Italic);
            this.BTNMinimizeForm.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNMinimizeForm.Location = new System.Drawing.Point(265, 12);
            this.BTNMinimizeForm.Name = "BTNMinimizeForm";
            this.BTNMinimizeForm.Size = new System.Drawing.Size(30, 30);
            this.BTNMinimizeForm.TabIndex = 5;
            this.BTNMinimizeForm.Text = "-";
            this.BTNMinimizeForm.UseVisualStyleBackColor = false;
            this.BTNMinimizeForm.Click += new System.EventHandler(this.BTNMinimizeForm_Click);
            // 
            // NUMIntervalo
            // 
            this.NUMIntervalo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.NUMIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NUMIntervalo.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUMIntervalo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NUMIntervalo.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUMIntervalo.Location = new System.Drawing.Point(50, 71);
            this.NUMIntervalo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUMIntervalo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUMIntervalo.Name = "NUMIntervalo";
            this.NUMIntervalo.Size = new System.Drawing.Size(120, 35);
            this.NUMIntervalo.TabIndex = 2;
            this.NUMIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUMIntervalo.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.NUMIntervalo.ValueChanged += new System.EventHandler(this.NUMIntervalo_ValueChanged);
            this.NUMIntervalo.Click += new System.EventHandler(this.NUMIntervalo_Click);
            this.NUMIntervalo.Resize += new System.EventHandler(this.NUMIntervalo_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(343, 200);
            this.Controls.Add(this.BTNMinimizeForm);
            this.Controls.Add(this.BTNCloseForm);
            this.Controls.Add(this.NUMIntervalo);
            this.Controls.Add(this.TXTInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "JM Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
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
        private CleanNumericUpDown NUMIntervalo;
        private System.Windows.Forms.Button BTNCloseForm;
        private System.Windows.Forms.Button BTNMinimizeForm;
    }
}

