namespace sheetDND
{
    partial class MainMenu
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
            this.button_NewCharacter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_Dices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_NewCharacter
            // 
            this.button_NewCharacter.Location = new System.Drawing.Point(106, 66);
            this.button_NewCharacter.Name = "button_NewCharacter";
            this.button_NewCharacter.Size = new System.Drawing.Size(143, 47);
            this.button_NewCharacter.TabIndex = 0;
            this.button_NewCharacter.Text = "Nuevo Personaje";
            this.button_NewCharacter.UseVisualStyleBackColor = true;
            this.button_NewCharacter.Click += new System.EventHandler(this.Button_NewCharacter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cargar Personaje";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Personaje Aleatorio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button_Dices
            // 
            this.button_Dices.Location = new System.Drawing.Point(106, 262);
            this.button_Dices.Name = "button_Dices";
            this.button_Dices.Size = new System.Drawing.Size(143, 47);
            this.button_Dices.TabIndex = 3;
            this.button_Dices.Text = "Tirar Dados";
            this.button_Dices.UseVisualStyleBackColor = true;
            this.button_Dices.Click += new System.EventHandler(this.Button_Dices_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 375);
            this.Controls.Add(this.button_Dices);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_NewCharacter);
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_NewCharacter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_Dices;
    }
}