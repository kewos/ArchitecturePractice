using System;
using System.Collections.Generic;
using System.ComponentModel;
using DragonQuestWFA.Common;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.Xml.Serialization;
using System.IO;


namespace DragonQuestWFA.Client
{
    public partial class DragonQuestForm : Form, IView
    {
        private DragonQuestPresenter _presenter;

        public DragonQuestForm()
        {
            _presenter = DragonQuestPresenter.GetInstance();
            _presenter.RegistView<DragonQuestForm>(this);

            InitializeComponent();

            //始使角色下拉選單
            InitialCmbCharactorNames();
            //初始地圖下拉選單
            InitialCmbMapNames();
        }

        #region 內部設定
        //始使角色下拉選單
        private void InitialCmbCharactorNames()
        {
            cmbCharactorNames.Items.Clear();
            //設定角色名稱
            _presenter.GetCharactorNames().ForEach(_charactorName => cmbCharactorNames.Items.Add(_charactorName));

            cmbCharactorNames.SelectedIndex = (cmbCharactorNames.Items.Count >= 1) ? 0 : -1;
        }

        //初始地圖下拉選單
        private void InitialCmbMapNames()
        {
            cmbMapNames.Items.Clear();
            //設定地圖名稱
            _presenter.GetMapNames().ForEach(_mapName => cmbMapNames.Items.Add(_mapName));

            cmbMapNames.SelectedIndex = (cmbMapNames.Items.Count >= 1) ? 0 : -1;
        }
        #endregion

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (cmbCharactorNames.SelectedItem != null)
            {
                int _index = cmbCharactorNames.SelectedIndex;
                _presenter.Attack<DragonQuestForm>(_index);
            }
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            if (cmbCharactorNames.SelectedItem != null)
            {
                int _index = cmbCharactorNames.SelectedIndex;
                _presenter.DisplayState<DragonQuestForm>(_index);
            }
        }

        private void btnInitial_Click(object sender, EventArgs e)
        {
            _presenter.Initial<DragonQuestForm>();
        }

        private void btnExpedition_Click(object sender, EventArgs e)
        {
            if (cmbMapNames.SelectedItem != null)
            {
                rtbScreen.Clear();

                int _Index = cmbMapNames.SelectedIndex;
                _presenter.Expedition<DragonQuestForm>(_Index);
            }
        }

        public void Show(string result)
        {
            rtbScreen.Clear();
            rtbScreen.AppendText(result);
            InitialCmbMapNames();
            InitialCmbCharactorNames();
        }
    }
}
