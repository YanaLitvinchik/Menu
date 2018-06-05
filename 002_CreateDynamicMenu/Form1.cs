using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_CreateDynamicMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Первым делом создаем каждый элемент меню
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");
            //В данном случае элемент меню сразу будет "выбран" Checked = true
            ToolStripMenuItem newItem = new ToolStripMenuItem("Создать") { Checked = true, CheckOnClick = true };
            ToolStripMenuItem saveItem = new ToolStripMenuItem("Сохранить") { Checked = true, CheckOnClick = true };
            //Обработчик события при выборе пункта меню
            saveItem.CheckedChanged += menuItem_CheckedChanged;

            //Добавляем вложеные пункты меню
            fileItem.DropDownItems.Add(newItem);
            fileItem.DropDownItems.Add(saveItem);

            //Создаем главное меню 
            MenuStrip ms = new MenuStrip();
            
            
            ms.Items.Add(fileItem);
            //Добавляем как часть контролов на окне
            this.Controls.Add(ms);
            //!!! И устанавливаем его как активное меню
            this.MainMenuStrip = ms;
            
        }
        void menuItem_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem.CheckState == CheckState.Checked)
                MessageBox.Show("Отмечен");
            else if (menuItem.CheckState == CheckState.Unchecked)
                MessageBox.Show("Отметка снята");
        }
    }
}
