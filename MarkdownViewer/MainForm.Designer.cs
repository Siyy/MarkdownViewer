namespace MarkdownViewer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.FileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.打印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.打印预览VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exportHTMLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.内容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.索引IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.搜索SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.撤消UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.重复RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.剪切TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.自定义CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.选项OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._splitContainer = new System.Windows.Forms.SplitContainer();
			this._edit = new System.Windows.Forms.RichTextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.打印PToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.剪切UToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.复制CToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.粘贴PToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.帮助LToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._view = new MarkdownViewer.MdBrowser();
			this.menuMain.SuspendLayout();
			this._splitContainer.Panel1.SuspendLayout();
			this._splitContainer.Panel2.SuspendLayout();
			this._splitContainer.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuMain
			// 
			this.menuMain.Dock = System.Windows.Forms.DockStyle.None;
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileFToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.帮助HToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.viewEditMenuItem,
            this.aboutMenuItem});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(792, 25);
			this.menuMain.TabIndex = 0;
			this.menuMain.Text = "menuTop";
			// 
			// FileFToolStripMenuItem
			// 
			this.FileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.toolStripSeparator4,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.toolStripSeparator5,
            this.打印PToolStripMenuItem,
            this.打印预览VToolStripMenuItem,
            this.toolStripSeparator6,
            this.ExitToolStripMenuItem});
			this.FileFToolStripMenuItem.Name = "FileFToolStripMenuItem";
			this.FileFToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
			this.FileFToolStripMenuItem.Text = "文件(&F)";
			// 
			// NewToolStripMenuItem
			// 
			this.NewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripMenuItem.Image")));
			this.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
			this.NewToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.NewToolStripMenuItem.Text = "新建(&N)";
			this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
			// 
			// OpenToolStripMenuItem
			// 
			this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
			this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
			this.OpenToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.OpenToolStripMenuItem.Text = "打开(&O)";
			this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(156, 6);
			// 
			// SaveToolStripMenuItem
			// 
			this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
			this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.SaveToolStripMenuItem.Text = "保存(&S)";
			this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
			// 
			// SaveAsToolStripMenuItem
			// 
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.SaveAsToolStripMenuItem.Text = "另存为(&A)";
			this.SaveAsToolStripMenuItem.Visible = false;
			this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(156, 6);
			this.toolStripSeparator5.Visible = false;
			// 
			// 打印PToolStripMenuItem
			// 
			this.打印PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打印PToolStripMenuItem.Image")));
			this.打印PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.打印PToolStripMenuItem.Name = "打印PToolStripMenuItem";
			this.打印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.打印PToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.打印PToolStripMenuItem.Text = "打印(&P)";
			this.打印PToolStripMenuItem.Visible = false;
			// 
			// 打印预览VToolStripMenuItem
			// 
			this.打印预览VToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打印预览VToolStripMenuItem.Image")));
			this.打印预览VToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.打印预览VToolStripMenuItem.Name = "打印预览VToolStripMenuItem";
			this.打印预览VToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.打印预览VToolStripMenuItem.Text = "打印预览(&V)";
			this.打印预览VToolStripMenuItem.Visible = false;
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(156, 6);
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.ExitToolStripMenuItem.Text = "退出(&X)";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNewMenuItem,
            this.fileOpenMenuItem,
            this.fileSaveMenuItem,
            this.toolStripSeparator2,
            this.exportHTMLMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
			this.fileToolStripMenuItem.Text = "&File";
			this.fileToolStripMenuItem.Visible = false;
			// 
			// fileNewMenuItem
			// 
			this.fileNewMenuItem.Name = "fileNewMenuItem";
			this.fileNewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.fileNewMenuItem.Size = new System.Drawing.Size(155, 22);
			this.fileNewMenuItem.Text = "&New";
			this.fileNewMenuItem.Click += new System.EventHandler(this.fileNewMenuItem_Click);
			// 
			// fileOpenMenuItem
			// 
			this.fileOpenMenuItem.Name = "fileOpenMenuItem";
			this.fileOpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.fileOpenMenuItem.Size = new System.Drawing.Size(155, 22);
			this.fileOpenMenuItem.Text = "&Open";
			this.fileOpenMenuItem.Click += new System.EventHandler(this.fileOpenMenuItem_Click);
			// 
			// fileSaveMenuItem
			// 
			this.fileSaveMenuItem.Name = "fileSaveMenuItem";
			this.fileSaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.fileSaveMenuItem.Size = new System.Drawing.Size(155, 22);
			this.fileSaveMenuItem.Text = "&Save";
			this.fileSaveMenuItem.Click += new System.EventHandler(this.fileSaveMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
			// 
			// exportHTMLMenuItem
			// 
			this.exportHTMLMenuItem.Name = "exportHTMLMenuItem";
			this.exportHTMLMenuItem.Size = new System.Drawing.Size(155, 22);
			this.exportHTMLMenuItem.Text = "Export &HTML";
			this.exportHTMLMenuItem.Click += new System.EventHandler(this.exportHTMLMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(155, 22);
			this.exitMenuItem.Text = "Exit";
			// 
			// viewEditMenuItem
			// 
			this.viewEditMenuItem.Name = "viewEditMenuItem";
			this.viewEditMenuItem.Size = new System.Drawing.Size(74, 21);
			this.viewEditMenuItem.Text = "&View/Edit";
			this.viewEditMenuItem.Visible = false;
			this.viewEditMenuItem.Click += new System.EventHandler(this.viewEditMenuItem_Click);
			// 
			// 帮助HToolStripMenuItem
			// 
			this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.内容CToolStripMenuItem,
            this.索引IToolStripMenuItem,
            this.搜索SToolStripMenuItem,
            this.toolStripSeparator9,
            this.AboutToolStripMenuItem});
			this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
			this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
			this.帮助HToolStripMenuItem.Text = "帮助(&H)";
			// 
			// 内容CToolStripMenuItem
			// 
			this.内容CToolStripMenuItem.Name = "内容CToolStripMenuItem";
			this.内容CToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.内容CToolStripMenuItem.Text = "内容(&C)";
			this.内容CToolStripMenuItem.Visible = false;
			// 
			// 索引IToolStripMenuItem
			// 
			this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
			this.索引IToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.索引IToolStripMenuItem.Text = "索引(&I)";
			this.索引IToolStripMenuItem.Visible = false;
			// 
			// 搜索SToolStripMenuItem
			// 
			this.搜索SToolStripMenuItem.Name = "搜索SToolStripMenuItem";
			this.搜索SToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.搜索SToolStripMenuItem.Text = "搜索(&S)";
			this.搜索SToolStripMenuItem.Visible = false;
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(149, 6);
			this.toolStripSeparator9.Visible = false;
			// 
			// AboutToolStripMenuItem
			// 
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.AboutToolStripMenuItem.Text = "关于(&A)...";
			this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(55, 21);
			this.aboutMenuItem.Text = "&About";
			this.aboutMenuItem.Visible = false;
			// 
			// 编辑EToolStripMenuItem
			// 
			this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤消UToolStripMenuItem,
            this.重复RToolStripMenuItem,
            this.toolStripSeparator7,
            this.剪切TToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘贴PToolStripMenuItem,
            this.toolStripSeparator8,
            this.全选AToolStripMenuItem,
            this.ViewToolStripMenuItem});
			this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
			this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.编辑EToolStripMenuItem.Text = "编辑(&E)";
			// 
			// 撤消UToolStripMenuItem
			// 
			this.撤消UToolStripMenuItem.Name = "撤消UToolStripMenuItem";
			this.撤消UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.撤消UToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.撤消UToolStripMenuItem.Text = "撤消(&U)";
			this.撤消UToolStripMenuItem.Visible = false;
			// 
			// 重复RToolStripMenuItem
			// 
			this.重复RToolStripMenuItem.Name = "重复RToolStripMenuItem";
			this.重复RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.重复RToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.重复RToolStripMenuItem.Text = "重复(&R)";
			this.重复RToolStripMenuItem.Visible = false;
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(158, 6);
			this.toolStripSeparator7.Visible = false;
			// 
			// 剪切TToolStripMenuItem
			// 
			this.剪切TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪切TToolStripMenuItem.Image")));
			this.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem";
			this.剪切TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.剪切TToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.剪切TToolStripMenuItem.Text = "剪切(&T)";
			this.剪切TToolStripMenuItem.Visible = false;
			// 
			// 复制CToolStripMenuItem
			// 
			this.复制CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripMenuItem.Image")));
			this.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
			this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.复制CToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.复制CToolStripMenuItem.Text = "复制(&C)";
			this.复制CToolStripMenuItem.Visible = false;
			// 
			// 粘贴PToolStripMenuItem
			// 
			this.粘贴PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripMenuItem.Image")));
			this.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem";
			this.粘贴PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.粘贴PToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.粘贴PToolStripMenuItem.Text = "粘贴(&P)";
			this.粘贴PToolStripMenuItem.Visible = false;
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(158, 6);
			this.toolStripSeparator8.Visible = false;
			// 
			// 全选AToolStripMenuItem
			// 
			this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
			this.全选AToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.全选AToolStripMenuItem.Text = "全选(&A)";
			this.全选AToolStripMenuItem.Visible = false;
			// 
			// 工具TToolStripMenuItem
			// 
			this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自定义CToolStripMenuItem,
            this.选项OToolStripMenuItem});
			this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
			this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.工具TToolStripMenuItem.Text = "工具(&T)";
			this.工具TToolStripMenuItem.Visible = false;
			// 
			// 自定义CToolStripMenuItem
			// 
			this.自定义CToolStripMenuItem.Name = "自定义CToolStripMenuItem";
			this.自定义CToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.自定义CToolStripMenuItem.Text = "自定义(&C)";
			// 
			// 选项OToolStripMenuItem
			// 
			this.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
			this.选项OToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.选项OToolStripMenuItem.Text = "选项(&O)";
			// 
			// _splitContainer
			// 
			this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._splitContainer.Location = new System.Drawing.Point(0, 0);
			this._splitContainer.Name = "_splitContainer";
			// 
			// _splitContainer.Panel1
			// 
			this._splitContainer.Panel1.Controls.Add(this._edit);
			// 
			// _splitContainer.Panel2
			// 
			this._splitContainer.Panel2.Controls.Add(this._view);
			this._splitContainer.Size = new System.Drawing.Size(792, 523);
			this._splitContainer.SplitterDistance = 390;
			this._splitContainer.SplitterWidth = 6;
			this._splitContainer.TabIndex = 1;
			// 
			// _edit
			// 
			this._edit.AcceptsTab = true;
			this._edit.AutoWordSelection = true;
			this._edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._edit.BulletIndent = 4;
			this._edit.Dock = System.Windows.Forms.DockStyle.Fill;
			this._edit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this._edit.Location = new System.Drawing.Point(0, 0);
			this._edit.Name = "_edit";
			this._edit.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this._edit.Size = new System.Drawing.Size(390, 523);
			this._edit.TabIndex = 0;
			this._edit.Text = "";
			this._edit.TextChanged += new System.EventHandler(this._edit_TextChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.打印PToolStripButton,
            this.toolStripSeparator,
            this.剪切UToolStripButton,
            this.复制CToolStripButton,
            this.粘贴PToolStripButton,
            this.toolStripSeparator3,
            this.帮助LToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(3, 25);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(81, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// NewToolStripButton
			// 
			this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripButton.Image")));
			this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NewToolStripButton.Name = "NewToolStripButton";
			this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.NewToolStripButton.Text = "新建(&N)";
			this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
			// 
			// OpenToolStripButton
			// 
			this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.OpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButton.Image")));
			this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenToolStripButton.Name = "OpenToolStripButton";
			this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.OpenToolStripButton.Text = "打开(&O)";
			this.OpenToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
			// 
			// SaveToolStripButton
			// 
			this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
			this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SaveToolStripButton.Name = "SaveToolStripButton";
			this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.SaveToolStripButton.Text = "保存(&S)";
			this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
			// 
			// 打印PToolStripButton
			// 
			this.打印PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.打印PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打印PToolStripButton.Image")));
			this.打印PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.打印PToolStripButton.Name = "打印PToolStripButton";
			this.打印PToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.打印PToolStripButton.Text = "打印(&P)";
			this.打印PToolStripButton.Visible = false;
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator.Visible = false;
			// 
			// 剪切UToolStripButton
			// 
			this.剪切UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.剪切UToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("剪切UToolStripButton.Image")));
			this.剪切UToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.剪切UToolStripButton.Name = "剪切UToolStripButton";
			this.剪切UToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.剪切UToolStripButton.Text = "剪切(&U)";
			this.剪切UToolStripButton.Visible = false;
			// 
			// 复制CToolStripButton
			// 
			this.复制CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.复制CToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripButton.Image")));
			this.复制CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.复制CToolStripButton.Name = "复制CToolStripButton";
			this.复制CToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.复制CToolStripButton.Text = "复制(&C)";
			this.复制CToolStripButton.Visible = false;
			// 
			// 粘贴PToolStripButton
			// 
			this.粘贴PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.粘贴PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripButton.Image")));
			this.粘贴PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.粘贴PToolStripButton.Name = "粘贴PToolStripButton";
			this.粘贴PToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.粘贴PToolStripButton.Text = "粘贴(&P)";
			this.粘贴PToolStripButton.Visible = false;
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			this.toolStripSeparator3.Visible = false;
			// 
			// 帮助LToolStripButton
			// 
			this.帮助LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.帮助LToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("帮助LToolStripButton.Image")));
			this.帮助LToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.帮助LToolStripButton.Name = "帮助LToolStripButton";
			this.帮助LToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.帮助LToolStripButton.Text = "帮助(&L)";
			this.帮助LToolStripButton.Visible = false;
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this._splitContainer);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(792, 523);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(792, 573);
			this.toolStripContainer1.TabIndex = 3;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuMain);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// ViewToolStripMenuItem
			// 
			this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
			this.ViewToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.ViewToolStripMenuItem.Text = "预览(&V)";
			this.ViewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
			// 
			// _view
			// 
			this._view.AllowWebBrowserDrop = false;
			this._view.CssText = null;
			this._view.Dock = System.Windows.Forms.DockStyle.Fill;
			this._view.Location = new System.Drawing.Point(0, 0);
			this._view.MdText = null;
			this._view.MinimumSize = new System.Drawing.Size(26, 26);
			this._view.Name = "_view";
			this._view.Size = new System.Drawing.Size(396, 523);
			this._view.TabIndex = 0;
			this._view.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this._view_Navigating);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.Add(this.toolStripContainer1);
			this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuMain;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MarkdownViewer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this._splitContainer.Panel1.ResumeLayout(false);
			this._splitContainer.Panel2.ResumeLayout(false);
			this._splitContainer.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileOpenMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportHTMLMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.SplitContainer _splitContainer;
        //private System.Windows.Forms.WebBrowser _view;
        private MdBrowser _view;
        private System.Windows.Forms.ToolStripMenuItem fileSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEditMenuItem;
        private System.Windows.Forms.RichTextBox _edit;
        private System.Windows.Forms.ToolStripMenuItem fileNewMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton NewToolStripButton;
		private System.Windows.Forms.ToolStripButton OpenToolStripButton;
		private System.Windows.Forms.ToolStripButton SaveToolStripButton;
		private System.Windows.Forms.ToolStripButton 打印PToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton 剪切UToolStripButton;
		private System.Windows.Forms.ToolStripButton 复制CToolStripButton;
		private System.Windows.Forms.ToolStripButton 粘贴PToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton 帮助LToolStripButton;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripMenuItem FileFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem 打印PToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 打印预览VToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 撤消UToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 重复RToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem 剪切TToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 粘贴PToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 自定义CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 内容CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 搜索SToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
    }
}

