namespace Calculatrice
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calculer = new System.Windows.Forms.Button();
            this.btn_recommencer = new System.Windows.Forms.Button();
            this.lbl_operande1 = new System.Windows.Forms.Label();
            this.lbl_operande2 = new System.Windows.Forms.Label();
            this.lbl_operation = new System.Windows.Forms.Label();
            this.txt_operande1 = new System.Windows.Forms.TextBox();
            this.txt_operande2 = new System.Windows.Forms.TextBox();
            this.txt_operation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calculer
            // 
            this.btn_calculer.Location = new System.Drawing.Point(86, 286);
            this.btn_calculer.Name = "btn_calculer";
            this.btn_calculer.Size = new System.Drawing.Size(133, 34);
            this.btn_calculer.TabIndex = 0;
            this.btn_calculer.Text = "Calculer";
            this.btn_calculer.UseVisualStyleBackColor = true;
            this.btn_calculer.Click += new System.EventHandler(this.btn_calculer_Click);
            // 
            // btn_recommencer
            // 
            this.btn_recommencer.Location = new System.Drawing.Point(374, 286);
            this.btn_recommencer.Name = "btn_recommencer";
            this.btn_recommencer.Size = new System.Drawing.Size(130, 33);
            this.btn_recommencer.TabIndex = 1;
            this.btn_recommencer.Text = "Recommencer";
            this.btn_recommencer.UseVisualStyleBackColor = true;
            this.btn_recommencer.Click += new System.EventHandler(this.btn_recommencer_Click);
            // 
            // lbl_operande1
            // 
            this.lbl_operande1.AutoSize = true;
            this.lbl_operande1.Location = new System.Drawing.Point(83, 87);
            this.lbl_operande1.Name = "lbl_operande1";
            this.lbl_operande1.Size = new System.Drawing.Size(78, 16);
            this.lbl_operande1.TabIndex = 2;
            this.lbl_operande1.Text = "Opérande 1";
            // 
            // lbl_operande2
            // 
            this.lbl_operande2.AutoSize = true;
            this.lbl_operande2.Location = new System.Drawing.Point(83, 126);
            this.lbl_operande2.Name = "lbl_operande2";
            this.lbl_operande2.Size = new System.Drawing.Size(78, 16);
            this.lbl_operande2.TabIndex = 3;
            this.lbl_operande2.Text = "Opérande 2";
            // 
            // lbl_operation
            // 
            this.lbl_operation.AutoSize = true;
            this.lbl_operation.Location = new System.Drawing.Point(83, 168);
            this.lbl_operation.Name = "lbl_operation";
            this.lbl_operation.Size = new System.Drawing.Size(66, 16);
            this.lbl_operation.TabIndex = 4;
            this.lbl_operation.Text = "Opération";
            // 
            // txt_operande1
            // 
            this.txt_operande1.Location = new System.Drawing.Point(257, 84);
            this.txt_operande1.Name = "txt_operande1";
            this.txt_operande1.Size = new System.Drawing.Size(100, 22);
            this.txt_operande1.TabIndex = 5;
            // 
            // txt_operande2
            // 
            this.txt_operande2.Location = new System.Drawing.Point(257, 126);
            this.txt_operande2.Name = "txt_operande2";
            this.txt_operande2.Size = new System.Drawing.Size(100, 22);
            this.txt_operande2.TabIndex = 6;
            // 
            // txt_operation
            // 
            this.txt_operation.Location = new System.Drawing.Point(257, 168);
            this.txt_operation.Name = "txt_operation";
            this.txt_operation.Size = new System.Drawing.Size(100, 22);
            this.txt_operation.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_operation);
            this.Controls.Add(this.txt_operande2);
            this.Controls.Add(this.txt_operande1);
            this.Controls.Add(this.lbl_operation);
            this.Controls.Add(this.lbl_operande2);
            this.Controls.Add(this.lbl_operande1);
            this.Controls.Add(this.btn_recommencer);
            this.Controls.Add(this.btn_calculer);
            this.Name = "Form1";
            this.Text = "Calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculer;
        private System.Windows.Forms.Button btn_recommencer;
        private System.Windows.Forms.Label lbl_operande1;
        private System.Windows.Forms.Label lbl_operande2;
        private System.Windows.Forms.Label lbl_operation;
        private System.Windows.Forms.TextBox txt_operande1;
        private System.Windows.Forms.TextBox txt_operande2;
        private System.Windows.Forms.TextBox txt_operation;
    }
}

