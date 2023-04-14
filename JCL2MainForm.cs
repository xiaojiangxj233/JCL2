using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCL2
{
    public partial class JCL2MainForm : Form
    {
        public JCL2MainForm()
        {
            InitializeComponent();
            // 设置ComboBox的DropDownStyle为DropDownList以确保只能从下拉列表中选择
            VersionList.DropDownStyle = ComboBoxStyle.DropDownList;

            // 检查.minecraft\versions目录是否存在，如果不存在则创建它
            string versionsDir = Path.Combine(Application.StartupPath, ".minecraft", "versions");
            if (!Directory.Exists(versionsDir))
            {
                Directory.CreateDirectory(versionsDir);
            }

            // 读取.minecraft\versions下的所有子目录并将它们添加到ComboBox中
            string[] versionDirs = Directory.GetDirectories(versionsDir);
            foreach (string versionDir in versionDirs)
            {
                string versionName = new DirectoryInfo(versionDir).Name;
                VersionList.Items.Add(versionName);
            }
        }
    }
}
