namespace GeneratorTeste
{
    partial class SingIn
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
            this.signin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordSignin = new System.Windows.Forms.TextBox();
            this.usernameSignin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.Location = new System.Drawing.Point(67, 128);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(75, 26);
            this.signin.TabIndex = 0;
            this.signin.Text = "Sign in ";
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.Signin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
          
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
           
            // 
            // passwordSignin
            // 
            this.passwordSignin.Location = new System.Drawing.Point(91, 67);
            this.passwordSignin.Name = "passwordSignin";
            this.passwordSignin.PasswordChar = '*';
            this.passwordSignin.Size = new System.Drawing.Size(124, 20);
            this.passwordSignin.TabIndex = 3;
 
            // 
            // usernameSignin
            // 
            this.usernameSignin.Location = new System.Drawing.Point(91, 32);
            this.usernameSignin.Name = "usernameSignin";
            this.usernameSignin.Size = new System.Drawing.Size(124, 20);
            this.usernameSignin.TabIndex = 4;

            // 
            // SingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 177);
            this.Controls.Add(this.usernameSignin);
            this.Controls.Add(this.passwordSignin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signin);
            this.Name = "SingIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordSignin;
        private System.Windows.Forms.TextBox usernameSignin;
    }
}