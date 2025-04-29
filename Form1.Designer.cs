namespace es._22_26
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumero = new Label();
            txtInput = new TextBox();
            btnConverti = new Button();
            btnReset = new Button();
            lstConversioni = new ListBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblNumero.Location = new Point(12, 23);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(108, 32);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 58);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(131, 23);
            txtInput.TabIndex = 1;
            txtInput.KeyPress += txtInput_KeyPress;
            // 
            // btnConverti
            // 
            btnConverti.Location = new Point(12, 107);
            btnConverti.Name = "btnConverti";
            btnConverti.Size = new Size(131, 40);
            btnConverti.TabIndex = 2;
            btnConverti.Text = "Converti in testo";
            btnConverti.UseVisualStyleBackColor = true;
            btnConverti.Click += btnConverti_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(12, 252);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(131, 40);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lstConversioni
            // 
            lstConversioni.FormattingEnabled = true;
            lstConversioni.ItemHeight = 15;
            lstConversioni.Location = new Point(149, 33);
            lstConversioni.Name = "lstConversioni";
            lstConversioni.Size = new Size(379, 259);
            lstConversioni.TabIndex = 4;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 303);
            Controls.Add(lstConversioni);
            Controls.Add(btnReset);
            Controls.Add(btnConverti);
            Controls.Add(txtInput);
            Controls.Add(lblNumero);
            Name = "frmMain";
            Text = "Converti numeri in testo";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtInput;
        private Button btnConverti;
        private Button btnReset;
        private ListBox lstConversioni;
    }
}
