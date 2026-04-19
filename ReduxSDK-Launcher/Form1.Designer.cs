using System.Drawing;

namespace ReduxSDK_Launcher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelMaps = new System.Windows.Forms.Label();
            this.textBoxArgs = new System.Windows.Forms.TextBox();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeViewMaps = new System.Windows.Forms.TreeView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.linkDiscord = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMaps
            // 
            this.labelMaps.AutoSize = true;
            this.labelMaps.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaps.ForeColor = System.Drawing.Color.White;
            this.labelMaps.Location = new System.Drawing.Point(6, 16);
            this.labelMaps.Name = "labelMaps";
            this.labelMaps.Size = new System.Drawing.Size(51, 18);
            this.labelMaps.TabIndex = 1;
            this.labelMaps.Text = "Maps:";
            // 
            // textBoxArgs
            // 
            this.textBoxArgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.textBoxArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxArgs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArgs.ForeColor = System.Drawing.Color.White;
            this.textBoxArgs.Location = new System.Drawing.Point(9, 274);
            this.textBoxArgs.Name = "textBoxArgs";
            this.textBoxArgs.Size = new System.Drawing.Size(506, 21);
            this.textBoxArgs.TabIndex = 3;
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.ForeColor = System.Drawing.Color.White;
            this.btnGame.Location = new System.Drawing.Point(9, 300);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(93, 23);
            this.btnGame.TabIndex = 4;
            this.btnGame.Text = "Launch Game";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.onGameClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(440, 300);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.onCloseClick);
            // 
            // btnEditor
            // 
            this.btnEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditor.ForeColor = System.Drawing.Color.White;
            this.btnEditor.Location = new System.Drawing.Point(341, 300);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(93, 23);
            this.btnEditor.TabIndex = 6;
            this.btnEditor.Text = "Launch Editor";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.onEditorClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeViewMaps);
            this.groupBox1.Controls.Add(this.btnEditor);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnGame);
            this.groupBox1.Controls.Add(this.textBoxArgs);
            this.groupBox1.Controls.Add(this.labelMaps);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 329);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // treeViewMaps
            // 
            this.treeViewMaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.treeViewMaps.ForeColor = System.Drawing.Color.White;
            this.treeViewMaps.FullRowSelect = true;
            this.treeViewMaps.HideSelection = false;
            this.treeViewMaps.Location = new System.Drawing.Point(9, 37);
            this.treeViewMaps.Name = "treeViewMaps";
            this.treeViewMaps.Size = new System.Drawing.Size(506, 231);
            this.treeViewMaps.TabIndex = 7;
            this.treeViewMaps.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.onMapsAfterSelect);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(241, 18);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Redux SDK | Launcher by TSNest";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            // 
            // linkDiscord
            // 
            this.linkDiscord.AutoSize = true;
            this.linkDiscord.LinkColor = System.Drawing.Color.Lavender;
            this.linkDiscord.Location = new System.Drawing.Point(290, 9);
            this.linkDiscord.Name = "linkDiscord";
            this.linkDiscord.Size = new System.Drawing.Size(243, 13);
            this.linkDiscord.TabIndex = 9;
            this.linkDiscord.TabStop = true;
            this.linkDiscord.Text = "Metro Modding - https://discord.gg/metromodding";
            this.linkDiscord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onLinkDiscordClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(545, 371);
            this.Controls.Add(this.linkDiscord);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redux SDK | Launcher by TSNest";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMaps;
        private System.Windows.Forms.TextBox textBoxArgs;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.LinkLabel linkDiscord;
        private System.Windows.Forms.TreeView treeViewMaps;
    }
}

