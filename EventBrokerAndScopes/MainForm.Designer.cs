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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateEditor
            // 
            this.btnCreateEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateEditor.Location = new System.Drawing.Point(40, 40);
            this.btnCreateEditor.Name = "btnCreateEditor";
            this.btnCreateEditor.Size = new System.Drawing.Size(204, 165);
            this.btnCreateEditor.TabIndex = 0;
            this.btnCreateEditor.Text = "Create Editor";
            this.btnCreateEditor.UseVisualStyleBackColor = true;
            this.btnCreateEditor.Click += new System.EventHandler(this.BtnCreateEditorClick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(40, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "GC_Collect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnGCCollect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateEditor);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEditor;
        private System.Windows.Forms.Button button1;
    }
}

