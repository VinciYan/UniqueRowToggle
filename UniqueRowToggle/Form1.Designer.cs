namespace UniqueRowToggle
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
            components = new System.ComponentModel.Container();
            dockManager1 = new DevExpress.XtraBars.Docking.DockManager(components);
            pathManagerDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)dockManager1).BeginInit();
            pathManagerDockPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dockManager1
            // 
            dockManager1.Form = this;
            dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] { pathManagerDockPanel });
            dockManager1.TopZIndexControls.AddRange(new string[] { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl" });
            // 
            // pathManagerDockPanel
            // 
            pathManagerDockPanel.Controls.Add(dockPanel1_Container);
            pathManagerDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            pathManagerDockPanel.ID = new System.Guid("b265bcb4-8db2-4954-83b7-dd6b5bd256d9");
            pathManagerDockPanel.Location = new System.Drawing.Point(0, 99);
            pathManagerDockPanel.Name = "pathManagerDockPanel";
            pathManagerDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            pathManagerDockPanel.Size = new System.Drawing.Size(737, 200);
            pathManagerDockPanel.Text = "路径选择";
            // 
            // dockPanel1_Container
            // 
            dockPanel1_Container.Location = new System.Drawing.Point(3, 27);
            dockPanel1_Container.Name = "dockPanel1_Container";
            dockPanel1_Container.Size = new System.Drawing.Size(731, 170);
            dockPanel1_Container.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(737, 299);
            Controls.Add(pathManagerDockPanel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dockManager1).EndInit();
            pathManagerDockPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel pathManagerDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
    }
}

