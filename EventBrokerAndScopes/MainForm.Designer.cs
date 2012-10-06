namespace EventBrokerAndScopes
{
    partial class MainForm
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
            this.btnCreateEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateEditor
            // 
            this.btnCreateEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateEditor.Location = new System.Drawing.Point(40, 40);
            this.btnCreateEditor.Name = "btnCreateEditor";
            this.btnCreateEditor.Size = new System.Drawing.Size(204, 182);
            this.btnCreateEditor.TabIndex = 0;
            this.btnCreateEditor.Text = "Create Editor";
            this.btnCreateEditor.UseVisualStyleBackColor = true;
            this.btnCreateEditor.Click += new System.EventHandler(this.BtnCreateEditorClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCreateEditor);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEditor;
    }
}

