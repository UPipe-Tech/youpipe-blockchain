using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTech.Model;
using UTech.Properties;
using UTech.Util;
using UTech.View;

/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: UTech.Controller
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author		: 
 * │CreatTime	: 2019/6/20 14:18:02													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © UTech Team 2015-2019. All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */


namespace UTech.Controller
{
    public class MenuViewController
    {
        private MainServiceController ctxController;

        private NotifyIcon _notifyIcon;
        private Bitmap icon_baseBitmap;
        private Icon icon_base;

        #region
        /// <summary>
        /// 
        /// </summary>
        private ContextMenu contextMenu;

        private MenuItem OnOffItem;
        private MenuItem AutoModeItem;
        private MenuItem GlobalModeItem;
        #region Account Group
        private MenuItem AccountGrpItem;
        private MenuItem CreateAccItem;
        private MenuItem AccountInfoItem;
        private MenuItem ImportAccItem;
        private MenuItem ExportAccItem;
        private MenuItem DeleteAccItem;
        #endregion
        private MenuItem LicenseItem;
        private MenuItem UpdateItem;
        private MenuItem HelpItem;
        private MenuItem AboutUsItem;

        private MenuItem QuitItem;
        #endregion

        #region Forms Begin
        private CreateAccountForm accForm;
        #endregion

        #region Construct
        public MenuViewController(MainServiceController controller)
        {
            this.ctxController = controller;
            this.LoadMenu();
            this.updateMenuStatus(controller.GetCurrentConfiguration());
            //註冊事件
            ctxController.EnableStatusChanged += CtxController_EnableStatusChanged;
            ctxController.GlobalStatusChanged += CtxController_GlobalStatusChanged;

            //Task Icon
            _notifyIcon = new NotifyIcon();
            UpdateTrayIcon();
            _notifyIcon.Visible = true;
            _notifyIcon.ContextMenu = contextMenu;

            _notifyIcon.MouseClick += notifyIcon_Clicked;



            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CtxController_GlobalStatusChanged(object sender, EventArgs e)
        {
            Configuration cfg = ctxController.GetCurrentConfiguration();
            if (cfg.IsNoneAccount()) return;
            if(cfg.ProxyMode == ProxyMode.Global)
            {
                this.GlobalModeItem.Checked = true;
                this.AutoModeItem.Checked = false;
            }
            else
            {
                this.GlobalModeItem.Checked = false;
                this.AutoModeItem.Checked = true;
            }
        }

        private void CtxController_EnableStatusChanged(object sender, EventArgs e)
        {
            this.OnOffItem.Text = ctxController.GetCurrentConfiguration().Enable ? I18N.GetString("Off") : I18N.GetString("On");
        }

        #endregion


        #region Menu Helper Functions
        /// <summary>
        /// 創建MenuItem
        /// </summary>
        /// <param name="text"></param>
        /// <param name="click"></param>
        /// <returns></returns>
        private MenuItem CreateMenuItem(string text,EventHandler click)
        {
            return new MenuItem(I18N.GetString(text), click);
        }

        private MenuItem CreateMenuGroup(string text,MenuItem[] items)
        {
            return new MenuItem(I18N.GetString(text), items);
        }
        
        /// <summary>
        /// 加載按鈕
        /// </summary>
        private void LoadMenu()
        {
            this.contextMenu = new ContextMenu(new MenuItem[] {
                this.OnOffItem = CreateMenuItem("On",new EventHandler(OnOffItem_Click)),
                new MenuItem("-"),
                this.AutoModeItem = CreateMenuItem("Auto Mode",new EventHandler(UnImplemented_Event)),
                this.GlobalModeItem = CreateMenuItem("Global Mode",new EventHandler(UnImplemented_Event)),
                new MenuItem("-"),
                this.AccountGrpItem = CreateMenuGroup("Account(None)",new MenuItem[]{
                    this.CreateAccItem = CreateMenuItem("Initial Account File",new EventHandler(CreateAccountItem_Click)),
                    this.AccountInfoItem = CreateMenuItem("Account Information",new EventHandler(UnImplemented_Event)),
                    this.ImportAccItem = CreateMenuItem("Import Account",new EventHandler(UnImplemented_Event)),
                    this.ExportAccItem = CreateMenuItem("Export Account",new EventHandler(UnImplemented_Event)),
                    this.DeleteAccItem = CreateMenuItem("Delete Account File",new EventHandler(UnImplemented_Event))
                }),
                this.LicenseItem = new MenuItem("No License"),
                new MenuItem("-"),
                this.UpdateItem = CreateMenuItem("Update Client",new EventHandler(UnImplemented_Event)),
                this.HelpItem = CreateMenuItem("Help",new EventHandler(UnImplemented_Event)),
                this.AboutUsItem = CreateMenuItem("About Us",new EventHandler(UnImplemented_Event)),
                new MenuItem("-"),
                this.QuitItem = CreateMenuItem("Quit",new EventHandler(Quit_EventClick))

            });
        }
        
        private void updateMenuStatus(Configuration cfg)
        {
            this.AboutUsItem.Enabled = false;
            ChangedItemEnable(cfg.IsNoneAccount());
        }

        private void ChangedItemEnable(bool HasAccount)
        {
            if (HasAccount)
            {
                this.CreateAccItem.Enabled = true;
                this.OnOffItem.Enabled = false;
                this.DeleteAccItem.Enabled = false;
                this.ExportAccItem.Enabled = false;
                this.GlobalModeItem.Checked = false;
                this.GlobalModeItem.Enabled = false;
                this.AutoModeItem.Checked = false;
                this.AutoModeItem.Enabled = false;
            }
            else
            {
                this.OnOffItem.Enabled = true;
                this.DeleteAccItem.Enabled = true;
                this.ExportAccItem.Enabled = true;
                this.CreateAccItem.Enabled = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="text"></param>
        private void UpdateMenuItemText(MenuItem item,string text)
        {
            string tx = I18N.GetString(text);
            item.Text = tx;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnImplemented_Event(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem m = (MenuItem)sender;
                MessageBox.Show(String.Format("{0} Feature come soon.", m.Text), I18N.GetString("Info"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


        #region Form Handler

        private void OnOffItem_Click(object sender,EventArgs e)
        {
            bool enableState = ctxController.GetCurrentConfiguration().Enable;
            ctxController.ToggleEnable(!enableState);
        }

        private void AutoModeItem_Click(object sender, EventArgs e)
        {
            Configuration cfg = ctxController.GetCurrentConfiguration();
            if (cfg.ProxyMode == ProxyMode.Global)
            {
                ctxController.ToggleGlobalStatus(ProxyMode.Auto);
            }
                
        }

        private void GlobalModeItem_Click(object sender, EventArgs e)
        {
            Configuration cfg = ctxController.GetCurrentConfiguration();
            if (cfg.ProxyMode == ProxyMode.Global)
            {
                ctxController.ToggleGlobalStatus(ProxyMode.Global);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateAccountItem_Click(object sender, EventArgs e)
        {
            ShowAccForm();
        }
        #region Create Account Form
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isCreating"></param>
        private void ShowAccForm(bool isCreating = true)
        {
            if(this.accForm != null)
            {
                this.accForm.Activate();
            }
            else
            {
                this.accForm = new CreateAccountForm(ctxController);
                this.accForm.Show();
                this.accForm.Activate();
                this.accForm.FormClosed += AccForm_FormClosed;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.accForm.Dispose();
            this.accForm = null;
            Utils.ReleaseMemory(true);
        }
        #endregion

        #endregion


        #region NotifyIcon Handler
        private void UpdateTrayIcon()
        {
            int dpi;
            Graphics graphics = Graphics.FromHwnd(IntPtr.Zero);
            dpi = (int)graphics.DpiX;
            graphics.Dispose();
            icon_baseBitmap = null;

            if(dpi < 97)
            {
                icon_baseBitmap = Resources.up16;
            }else if(dpi < 121)
            {
                icon_baseBitmap = Resources.up20;
            }
            else
            {
                icon_baseBitmap = Resources.up24;
            }

            icon_base = Icon.FromHandle(icon_baseBitmap.GetHicon());
            _notifyIcon.Icon = icon_base;

            //
            string tipInfo = null;
            string text = I18N.GetString($"{Resources.ClientName} {Utils.GetAssemblyVersion()}");
            Logging.Debug(text);

            if(text.Length > 127)
            {
                text = text.Substring(0, 126 - 3) + "...";
            }
            ViewUtils.SetNotifyIconTray(_notifyIcon, text);
        }


        private void notifyIcon_Clicked(object sender,MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right )
            {
                _notifyIcon.Visible = true;
            }
        }
        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quit_EventClick(object sender,EventArgs e)
        {
            //TODO
            Application.Exit();
        }
    }
}
