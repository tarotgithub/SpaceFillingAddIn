namespace SpaceFillingAddIn
{
    partial class SpaceFillingRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SpaceFillingRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.buttonRecorder = this.Factory.CreateRibbonButton();
            this.buttonFiller = this.Factory.CreateRibbonButton();
            this.labelLength = this.Factory.CreateRibbonLabel();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.buttonRecorder);
            this.group1.Items.Add(this.buttonFiller);
            this.group1.Items.Add(this.labelLength);
            this.group1.Label = "空格填补工具";
            this.group1.Name = "group1";
            // 
            // buttonRecorder
            // 
            this.buttonRecorder.Label = "记录文本";
            this.buttonRecorder.Name = "buttonRecorder";
            this.buttonRecorder.ScreenTip = "记录所选文本长度";
            this.buttonRecorder.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonRecorder_Click);
            // 
            // buttonFiller
            // 
            this.buttonFiller.Label = "填充空格";
            this.buttonFiller.Name = "buttonFiller";
            this.buttonFiller.ScreenTip = "填充空格，使所选文本长度等于记录文本长度";
            this.buttonFiller.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonFiller_Click);
            // 
            // labelLength
            // 
            this.labelLength.Label = "记录长度：0";
            this.labelLength.Name = "labelLength";
            this.labelLength.ScreenTip = "当前记录的文本长度";
            this.labelLength.Tag = "记录长度：";
            // 
            // SpaceFillingRibbon
            // 
            this.Name = "SpaceFillingRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.SpaceFillingRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonRecorder;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonFiller;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel labelLength;
    }

    partial class ThisRibbonCollection
    {
        internal SpaceFillingRibbon SpaceFillingRibbon
        {
            get { return this.GetRibbon<SpaceFillingRibbon>(); }
        }
    }
}
