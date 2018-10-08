﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using QuanLyThuVien.DAO;

namespace QuanLyThuVien
{
    public partial class fTableManage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private fLogin fLg;
        private string tdn;
        public fTableManage(fLogin _flg, string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
            fLg = _flg;
            DataProvider _dt = new DataProvider();
            DataTable dt = _dt.GetData("select * from ACCOUNT where ACCOUNT.TenDangNhap = '" + tdn + "'");
            string gt = dt.Rows[0]["Quyen"].ToString();
            if (gt == "1")
            {
                ribbonTrangChu.Visible = false;
                ribbonThongKe.Visible = false;
                barBtnQLSach.Enabled = false;
                barBtnQLPM.Enabled = false;
                barBtnQLPT.Enabled = false;
                nBG_QL.Visible = false;
                nBG_TK.Visible = false;
            }
            else
            {
                bar_SachDangMuon.Enabled = false;
                bar_LichSu.Enabled = false;
                nBG_LSMS.Visible = false;
                rbpG_TK.Visible = false;
            }
           
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1, true);

            panelCha.Controls.Clear();
            ucFrmGioiThieu frm = new ucFrmGioiThieu();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }
        

        private void barBtnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLThanhVien frm = new ucFrmQLThanhVien();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

       
        private void barBtnQLSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLSach frm = new ucFrmQLSach();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLPhieuMuon frm = new ucFrmQLPhieuMuon();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLPhieuTra frm = new ucFrmQLPhieuTra();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barBtbDXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            fLg.Show();
        }

        private void fTableManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            fLg.Close();
        }

        private void barBtnTimKiemSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmTimKiemSach frm = new ucFrmTimKiemSach();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barbtnThanhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmThanhVien frm = new ucFrmThanhVien(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barBtnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmDoiMatKhau frm = new ucFrmDoiMatKhau(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }
        private void bar_SachDangMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmSachDangMuon frm = new ucFrmSachDangMuon(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void bar_LichSu_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmSachDaTra frm = new ucFrmSachDaTra(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }
        private void barBtnDangMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmDangMuon frm = new ucFrmDangMuon();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barBtnDaMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmDaTra frm = new ucFrmDaTra();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }
        private int i = 1;
        private bool ck = true;
       
        private void timer_Tick(object sender, EventArgs e)
        {
            //if (ck == true)
            //    lb_ChayChu.Top += i;
            //else
            //    lb_ChayChu.Top -= i;
            //if (lb_ChayChu.Top > 400 || lb_ChayChu.Top <= 0)
            //    ck = !ck;


        }

        private void nBI_TTCN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmThanhVien frm = new ucFrmThanhVien(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_DMK_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmDoiMatKhau frm = new ucFrmDoiMatKhau(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_SDM_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmSachDangMuon frm = new ucFrmSachDangMuon(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_SDT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmSachDaTra frm = new ucFrmSachDaTra(tdn);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_QLTV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLThanhVien frm = new ucFrmQLThanhVien();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_QLS_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLSach frm = new ucFrmQLSach();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_QLPM_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLPhieuMuon frm = new ucFrmQLPhieuMuon();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_QLPT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmQLPhieuTra frm = new ucFrmQLPhieuTra();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_TKDM_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmDangMuon frm = new ucFrmDangMuon();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void nBI_TKDT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmDaTra frm = new ucFrmDaTra();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barbtn_About_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmGioiThieu frm = new ucFrmGioiThieu();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void barBtnHDSD_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelCha.Controls.Clear();
            ucFrmHuongDanSuDung frm = new ucFrmHuongDanSuDung();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCha.Controls.Add(frm);
        }

        private void fTableManage_Load(object sender, EventArgs e)
        {
            barTextHello.Caption = "Xin Chào " + tdn;
        }

      
        

      

        

        

       

        

        

        


    }
}
