namespace EFsamples
{
    partial class Form1
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
            this.btnCodeFirstMigrationos = new System.Windows.Forms.Button();
            this.btnAutoMigrations = new System.Windows.Forms.Button();
            this.btnEagerlyLoading = new System.Windows.Forms.Button();
            this.btnLazy = new System.Windows.Forms.Button();
            this.btnExplicitlyLoading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCodeFirstMigrationos
            // 
            this.btnCodeFirstMigrationos.Location = new System.Drawing.Point(42, 30);
            this.btnCodeFirstMigrationos.Name = "btnCodeFirstMigrationos";
            this.btnCodeFirstMigrationos.Size = new System.Drawing.Size(180, 23);
            this.btnCodeFirstMigrationos.TabIndex = 0;
            this.btnCodeFirstMigrationos.Text = "CodeFirstMigrationos";
            this.btnCodeFirstMigrationos.UseVisualStyleBackColor = true;
            this.btnCodeFirstMigrationos.Click += new System.EventHandler(this.btnCodeFirstMigrationos_Click);
            // 
            // btnAutoMigrations
            // 
            this.btnAutoMigrations.Location = new System.Drawing.Point(42, 88);
            this.btnAutoMigrations.Name = "btnAutoMigrations";
            this.btnAutoMigrations.Size = new System.Drawing.Size(180, 23);
            this.btnAutoMigrations.TabIndex = 1;
            this.btnAutoMigrations.Text = "AutoMigrations";
            this.btnAutoMigrations.UseVisualStyleBackColor = true;
            this.btnAutoMigrations.Click += new System.EventHandler(this.btnAutoMigrations_Click);
            // 
            // btnEagerlyLoading
            // 
            this.btnEagerlyLoading.Location = new System.Drawing.Point(42, 153);
            this.btnEagerlyLoading.Name = "btnEagerlyLoading";
            this.btnEagerlyLoading.Size = new System.Drawing.Size(180, 23);
            this.btnEagerlyLoading.TabIndex = 2;
            this.btnEagerlyLoading.Text = "EagerlyLoading";
            this.btnEagerlyLoading.UseVisualStyleBackColor = true;
            this.btnEagerlyLoading.Click += new System.EventHandler(this.btnEagerlyLoading_Click);
            // 
            // btnLazy
            // 
            this.btnLazy.Location = new System.Drawing.Point(42, 222);
            this.btnLazy.Name = "btnLazy";
            this.btnLazy.Size = new System.Drawing.Size(180, 23);
            this.btnLazy.TabIndex = 3;
            this.btnLazy.Text = "LazyLoading";
            this.btnLazy.UseVisualStyleBackColor = true;
            this.btnLazy.Click += new System.EventHandler(this.btnLazy_Click);
            // 
            // btnExplicitlyLoading
            // 
            this.btnExplicitlyLoading.Location = new System.Drawing.Point(42, 283);
            this.btnExplicitlyLoading.Name = "btnExplicitlyLoading";
            this.btnExplicitlyLoading.Size = new System.Drawing.Size(180, 23);
            this.btnExplicitlyLoading.TabIndex = 4;
            this.btnExplicitlyLoading.Text = "ExplicitlyLoading";
            this.btnExplicitlyLoading.UseVisualStyleBackColor = true;
            this.btnExplicitlyLoading.Click += new System.EventHandler(this.btnExplicitlyLoading_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExplicitlyLoading);
            this.Controls.Add(this.btnLazy);
            this.Controls.Add(this.btnEagerlyLoading);
            this.Controls.Add(this.btnAutoMigrations);
            this.Controls.Add(this.btnCodeFirstMigrationos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCodeFirstMigrationos;
        private System.Windows.Forms.Button btnAutoMigrations;
        private System.Windows.Forms.Button btnEagerlyLoading;
        private System.Windows.Forms.Button btnLazy;
        private System.Windows.Forms.Button btnExplicitlyLoading;
    }
}

