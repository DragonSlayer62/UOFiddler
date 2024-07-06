/***************************************************************************
 *
 * $Author: Turley
 * 
 * "THE BEER-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with 
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer in return.
 *
 ***************************************************************************/

using System.Drawing;
using System.Windows.Forms;

namespace UoFiddler.Controls.UserControls
{
    partial class TileDataControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ToolTip toolTipComponent;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTipComponent = new System.Windows.Forms.ToolTip(components);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileDataControl));
            tabcontrol = new System.Windows.Forms.TabControl();
            tabPageItems = new System.Windows.Forms.TabPage();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            treeViewItem = new System.Windows.Forms.TreeView();
            ItemsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            selectInItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selectRadarColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            selectInGumpsTabMaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selectInGumpsTabFemaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pictureBoxItem = new System.Windows.Forms.PictureBox();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            textBoxName = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            textBoxUnk2 = new System.Windows.Forms.TextBox();
            textBoxUnk1 = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            textBoxHeigth = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            textBoxValue = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textBoxStackOff = new System.Windows.Forms.TextBox();
            textBoxHue = new System.Windows.Forms.TextBox();
            textBoxWeight = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBoxQuantity = new System.Windows.Forms.TextBox();
            textBoxQuality = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBoxUnk3 = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            textBoxAnim = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            tabPageLand = new System.Windows.Forms.TabPage();
            splitContainer5 = new System.Windows.Forms.SplitContainer();
            splitContainer6 = new System.Windows.Forms.SplitContainer();
            treeViewLand = new System.Windows.Forms.TreeView();
            LandTilesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            selectInLandtilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pictureBoxLand = new System.Windows.Forms.PictureBox();
            label23 = new System.Windows.Forms.Label();
            textBoxNameLand = new System.Windows.Forms.TextBox();
            splitContainer7 = new System.Windows.Forms.SplitContainer();
            textBoxTexID = new System.Windows.Forms.TextBox();
            label24 = new System.Windows.Forms.Label();
            checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            MainToolStrip = new System.Windows.Forms.ToolStrip();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            searchByIdToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            searchByNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            searchByNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            memorySaveWarningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveDirectlyOnChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            setFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            setTextureOnDoubleClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            setTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            tabcontrol.SuspendLayout();
            tabPageItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ItemsContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            tabPageLand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            LandTilesContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
            MainToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tabcontrol
            // 
            tabcontrol.Controls.Add(tabPageItems);
            tabcontrol.Controls.Add(tabPageLand);
            tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            tabcontrol.Location = new System.Drawing.Point(0, 25);
            tabcontrol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabcontrol.Name = "tabcontrol";
            tabcontrol.SelectedIndex = 0;
            tabcontrol.Size = new System.Drawing.Size(770, 375);
            tabcontrol.TabIndex = 0;
            // 
            // tabPageItems
            // 
            tabPageItems.Controls.Add(splitContainer1);
            tabPageItems.Location = new System.Drawing.Point(4, 24);
            tabPageItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageItems.Name = "tabPageItems";
            tabPageItems.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageItems.Size = new System.Drawing.Size(762, 347);
            tabPageItems.TabIndex = 0;
            tabPageItems.Text = "Items";
            tabPageItems.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(4, 3);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new System.Drawing.Size(754, 341);
            splitContainer1.SplitterDistance = 245;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(treeViewItem);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(pictureBoxItem);
            splitContainer2.Size = new System.Drawing.Size(245, 341);
            splitContainer2.SplitterDistance = 207;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // treeViewItem
            // 
            treeViewItem.ContextMenuStrip = ItemsContextMenuStrip;
            treeViewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            treeViewItem.HideSelection = false;
            treeViewItem.Location = new System.Drawing.Point(0, 0);
            treeViewItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            treeViewItem.Name = "treeViewItem";
            treeViewItem.Size = new System.Drawing.Size(245, 207);
            treeViewItem.TabIndex = 0;
            treeViewItem.BeforeExpand += OnItemDataNodeExpanded;
            treeViewItem.AfterSelect += AfterSelectTreeViewItem;
            // 
            // ItemsContextMenuStrip
            // 
            ItemsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { selectInItemsToolStripMenuItem, selectRadarColorToolStripMenuItem, toolStripSeparator3, selectInGumpsTabMaleToolStripMenuItem, selectInGumpsTabFemaleToolStripMenuItem });
            ItemsContextMenuStrip.Name = "contextMenuStrip1";
            ItemsContextMenuStrip.Size = new System.Drawing.Size(201, 98);
            ItemsContextMenuStrip.Opening += ItemsContextMenuStrip_Opening;
            // 
            // selectInItemsToolStripMenuItem
            // 
            selectInItemsToolStripMenuItem.Name = "selectInItemsToolStripMenuItem";
            selectInItemsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            selectInItemsToolStripMenuItem.Text = "Select In Items tab";
            selectInItemsToolStripMenuItem.Click += OnClickSelectItem;
            // 
            // selectRadarColorToolStripMenuItem
            // 
            selectRadarColorToolStripMenuItem.Name = "selectRadarColorToolStripMenuItem";
            selectRadarColorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            selectRadarColorToolStripMenuItem.Text = "Select In RadarColor tab";
            selectRadarColorToolStripMenuItem.Click += OnClickSelectRadarItem;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // selectInGumpsTabMaleToolStripMenuItem
            // 
            selectInGumpsTabMaleToolStripMenuItem.Name = "selectInGumpsTabMaleToolStripMenuItem";
            selectInGumpsTabMaleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            selectInGumpsTabMaleToolStripMenuItem.Text = "Select in Gumps (M)";
            selectInGumpsTabMaleToolStripMenuItem.Click += SelectInGumpsTabMaleToolStripMenuItem_Click;
            // 
            // selectInGumpsTabFemaleToolStripMenuItem
            // 
            selectInGumpsTabFemaleToolStripMenuItem.Name = "selectInGumpsTabFemaleToolStripMenuItem";
            selectInGumpsTabFemaleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            selectInGumpsTabFemaleToolStripMenuItem.Text = "Select in Gumps (F)";
            selectInGumpsTabFemaleToolStripMenuItem.Click += SelectInGumpsTabFemaleToolStripMenuItem_Click;
            // 
            // pictureBoxItem
            // 
            pictureBoxItem.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBoxItem.Location = new System.Drawing.Point(0, 0);
            pictureBoxItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBoxItem.Name = "pictureBoxItem";
            pictureBoxItem.Size = new System.Drawing.Size(245, 129);
            pictureBoxItem.TabIndex = 0;
            pictureBoxItem.TabStop = false;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new System.Drawing.Point(0, 0);
            splitContainer3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(textBoxName);
            splitContainer3.Panel1.Controls.Add(label9);
            splitContainer3.Panel1.Controls.Add(textBoxUnk2);
            splitContainer3.Panel1.Controls.Add(textBoxUnk1);
            splitContainer3.Panel1.Controls.Add(label10);
            splitContainer3.Panel1.Controls.Add(textBoxHeigth);
            splitContainer3.Panel1.Controls.Add(label11);
            splitContainer3.Panel1.Controls.Add(textBoxValue);
            splitContainer3.Panel1.Controls.Add(label6);
            splitContainer3.Panel1.Controls.Add(label7);
            splitContainer3.Panel1.Controls.Add(textBoxStackOff);
            splitContainer3.Panel1.Controls.Add(textBoxHue);
            splitContainer3.Panel1.Controls.Add(textBoxWeight);
            splitContainer3.Panel1.Controls.Add(label8);
            splitContainer3.Panel1.Controls.Add(label5);
            splitContainer3.Panel1.Controls.Add(textBoxQuantity);
            splitContainer3.Panel1.Controls.Add(textBoxQuality);
            splitContainer3.Panel1.Controls.Add(label4);
            splitContainer3.Panel1.Controls.Add(label3);
            splitContainer3.Panel1.Controls.Add(label1);
            splitContainer3.Panel1.Controls.Add(textBoxUnk3);
            splitContainer3.Panel1.Controls.Add(label12);
            splitContainer3.Panel1.Controls.Add(textBoxAnim);
            splitContainer3.Panel1.Controls.Add(label2);
            splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(splitContainer3_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(checkedListBox1);
            splitContainer3.Size = new System.Drawing.Size(504, 341);
            splitContainer3.SplitterDistance = 157;
            splitContainer3.SplitterWidth = 2;
            splitContainer3.TabIndex = 25;
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(51, 3);
            textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxName.MaxLength = 20;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(157, 23);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += OnTextChangedItemName;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(264, 97);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(34, 15);
            label9.TabIndex = 21;
            label9.Text = "Unk2";
            // 
            // textBoxUnk2
            // 
            textBoxUnk2.Location = new System.Drawing.Point(325, 93);
            textBoxUnk2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxUnk2.Name = "textBoxUnk2";
            textBoxUnk2.Size = new System.Drawing.Size(59, 23);
            textBoxUnk2.TabIndex = 20;
            textBoxUnk2.TextChanged += OnTextChangedItemUnk2;
            // 
            // textBoxUnk1
            // 
            textBoxUnk1.Location = new System.Drawing.Point(188, 93);
            textBoxUnk1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxUnk1.Name = "textBoxUnk1";
            textBoxUnk1.Size = new System.Drawing.Size(59, 23);
            textBoxUnk1.TabIndex = 18;
            textBoxUnk1.TextChanged += OnTextChangedItemMiscData;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(128, 97);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(56, 15);
            label10.TabIndex = 19;
            label10.Text = "MiscData";
            // 
            // textBoxHeigth
            // 
            textBoxHeigth.Location = new System.Drawing.Point(52, 93);
            textBoxHeigth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxHeigth.Name = "textBoxHeigth";
            textBoxHeigth.Size = new System.Drawing.Size(59, 23);
            textBoxHeigth.TabIndex = 16;
            textBoxHeigth.TextChanged += OnTextChangedItemHeight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(5, 97);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(43, 15);
            label11.TabIndex = 17;
            label11.Text = "Height";
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new System.Drawing.Point(325, 63);
            textBoxValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new System.Drawing.Size(59, 23);
            textBoxValue.TabIndex = 14;
            textBoxValue.TextChanged += OnTextChangedItemValue;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(264, 67);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(35, 15);
            label6.TabIndex = 15;
            label6.Text = "Value";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(128, 67);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 15);
            label7.TabIndex = 13;
            label7.Text = "StackOff";
            // 
            // textBoxStackOff
            // 
            textBoxStackOff.Location = new System.Drawing.Point(188, 63);
            textBoxStackOff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxStackOff.Name = "textBoxStackOff";
            textBoxStackOff.Size = new System.Drawing.Size(59, 23);
            textBoxStackOff.TabIndex = 12;
            textBoxStackOff.TextChanged += OnTextChangedItemStackOff;
            // 
            // textBoxHue
            // 
            textBoxHue.Location = new System.Drawing.Point(52, 63);
            textBoxHue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxHue.Name = "textBoxHue";
            textBoxHue.Size = new System.Drawing.Size(59, 23);
            textBoxHue.TabIndex = 10;
            textBoxHue.TextChanged += OnTextChangedItemHue;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new System.Drawing.Point(52, 33);
            textBoxWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new System.Drawing.Size(59, 23);
            textBoxWeight.TabIndex = 4;
            textBoxWeight.TextChanged += OnTextChangedItemWeight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(5, 67);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(29, 15);
            label8.TabIndex = 11;
            label8.Text = "Hue";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(264, 37);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 15);
            label5.TabIndex = 9;
            label5.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new System.Drawing.Point(325, 33);
            textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new System.Drawing.Size(59, 23);
            textBoxQuantity.TabIndex = 8;
            textBoxQuantity.TextChanged += OnTextChangedItemQuantity;
            // 
            // textBoxQuality
            // 
            textBoxQuality.Location = new System.Drawing.Point(188, 33);
            textBoxQuality.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxQuality.Name = "textBoxQuality";
            textBoxQuality.Size = new System.Drawing.Size(59, 23);
            textBoxQuality.TabIndex = 6;
            textBoxQuality.TextChanged += OnTextChangedItemQuality;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(128, 37);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(35, 15);
            label4.TabIndex = 7;
            label4.Text = "Layer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(5, 37);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Weight";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 7);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // textBoxUnk3
            // 
            textBoxUnk3.Location = new System.Drawing.Point(52, 123);
            textBoxUnk3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxUnk3.Name = "textBoxUnk3";
            textBoxUnk3.Size = new System.Drawing.Size(59, 23);
            textBoxUnk3.TabIndex = 22;
            textBoxUnk3.TextChanged += OnTextChangedItemUnk3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(5, 127);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(34, 15);
            label12.TabIndex = 23;
            label12.Text = "Unk3";
            // 
            // textBoxAnim
            // 
            textBoxAnim.Location = new System.Drawing.Point(268, 4);
            textBoxAnim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxAnim.Name = "textBoxAnim";
            textBoxAnim.Size = new System.Drawing.Size(116, 23);
            textBoxAnim.TabIndex = 2;
            textBoxAnim.TextChanged += OnTextChangedItemAnim;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(233, 7);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Anim";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new System.Drawing.Point(0, 0);
            checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new System.Drawing.Size(504, 182);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.ItemCheck += OnFlagItemCheckItems;
            // 
            // tabPageLand
            // 
            tabPageLand.Controls.Add(splitContainer5);
            tabPageLand.Location = new System.Drawing.Point(4, 24);
            tabPageLand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageLand.Name = "tabPageLand";
            tabPageLand.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageLand.Size = new System.Drawing.Size(762, 347);
            tabPageLand.TabIndex = 1;
            tabPageLand.Text = "Land Tiles";
            tabPageLand.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer5.Location = new System.Drawing.Point(4, 3);
            splitContainer5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(splitContainer6);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(label23);
            splitContainer5.Panel2.Controls.Add(textBoxNameLand);
            splitContainer5.Panel2.Controls.Add(splitContainer7);
            splitContainer5.Size = new System.Drawing.Size(754, 341);
            splitContainer5.SplitterDistance = 245;
            splitContainer5.SplitterWidth = 5;
            splitContainer5.TabIndex = 1;
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer6.Location = new System.Drawing.Point(0, 0);
            splitContainer6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(treeViewLand);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(pictureBoxLand);
            splitContainer6.Size = new System.Drawing.Size(245, 341);
            splitContainer6.SplitterDistance = 205;
            splitContainer6.SplitterWidth = 5;
            splitContainer6.TabIndex = 0;
            // 
            // treeViewLand
            // 
            treeViewLand.ContextMenuStrip = LandTilesContextMenuStrip;
            treeViewLand.Dock = System.Windows.Forms.DockStyle.Fill;
            treeViewLand.HideSelection = false;
            treeViewLand.Location = new System.Drawing.Point(0, 0);
            treeViewLand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            treeViewLand.Name = "treeViewLand";
            treeViewLand.Size = new System.Drawing.Size(245, 205);
            treeViewLand.TabIndex = 0;
            treeViewLand.AfterSelect += AfterSelectTreeViewLand;
            // 
            // LandTilesContextMenuStrip
            // 
            LandTilesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { selectInLandtilesToolStripMenuItem, selToolStripMenuItem });
            LandTilesContextMenuStrip.Name = "contextMenuStrip2";
            LandTilesContextMenuStrip.Size = new System.Drawing.Size(201, 48);
            // 
            // selectInLandtilesToolStripMenuItem
            // 
            selectInLandtilesToolStripMenuItem.Name = "selectInLandtilesToolStripMenuItem";
            selectInLandtilesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            selectInLandtilesToolStripMenuItem.Text = "Select In Land Tiles tab";
            selectInLandtilesToolStripMenuItem.Click += OnClickSelectInLandTiles;
            // 
            // selToolStripMenuItem
            // 
            selToolStripMenuItem.Name = "selToolStripMenuItem";
            selToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            selToolStripMenuItem.Text = "Select In RadarColor tab";
            selToolStripMenuItem.Click += OnClickSelectRadarLand;
            // 
            // pictureBoxLand
            // 
            pictureBoxLand.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBoxLand.Location = new System.Drawing.Point(0, 0);
            pictureBoxLand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBoxLand.Name = "pictureBoxLand";
            pictureBoxLand.Size = new System.Drawing.Size(245, 131);
            pictureBoxLand.TabIndex = 0;
            pictureBoxLand.TabStop = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(4, 7);
            label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(39, 15);
            label23.TabIndex = 1;
            label23.Text = "Name";
            // 
            // textBoxNameLand
            // 
            textBoxNameLand.Location = new System.Drawing.Point(51, 3);
            textBoxNameLand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxNameLand.MaxLength = 20;
            textBoxNameLand.Name = "textBoxNameLand";
            textBoxNameLand.Size = new System.Drawing.Size(143, 23);
            textBoxNameLand.TabIndex = 0;
            textBoxNameLand.TextChanged += OnTextChangedLandName;
            // 
            // splitContainer7
            // 
            splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer7.IsSplitterFixed = true;
            splitContainer7.Location = new System.Drawing.Point(0, 0);
            splitContainer7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer7.Name = "splitContainer7";
            splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.Controls.Add(textBoxTexID);
            splitContainer7.Panel1.Controls.Add(label24);
            // 
            // splitContainer7.Panel2
            // 
            splitContainer7.Panel2.Controls.Add(checkedListBox2);
            splitContainer7.Size = new System.Drawing.Size(504, 341);
            splitContainer7.SplitterDistance = 27;
            splitContainer7.SplitterWidth = 2;
            splitContainer7.TabIndex = 25;
            // 
            // textBoxTexID
            // 
            textBoxTexID.Location = new System.Drawing.Point(251, 3);
            textBoxTexID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxTexID.Name = "textBoxTexID";
            textBoxTexID.Size = new System.Drawing.Size(67, 23);
            textBoxTexID.TabIndex = 2;
            textBoxTexID.TextChanged += OnTextChangedLandTexID;
            textBoxTexID.DoubleClick += TextBoxTexID_DoubleClick;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(202, 7);
            label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(35, 15);
            label24.TabIndex = 3;
            label24.Text = "TexID";
            // 
            // checkedListBox2
            // 
            checkedListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new System.Drawing.Point(0, 0);
            checkedListBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkedListBox2.MultiColumn = true;
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new System.Drawing.Size(504, 312);
            checkedListBox2.TabIndex = 0;
            checkedListBox2.ItemCheck += OnFlagItemCheckLandTiles;
            // 
            // MainToolStrip
            // 
            MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel1, searchByIdToolStripTextBox, toolStripLabel2, searchByNameToolStripTextBox, searchByNameToolStripButton, toolStripSeparator5, toolStripDropDownButton1, toolStripSeparator1, toolStripButton1, toolStripButton5, toolStripSeparator2, toolStripButton4, toolStripButton3 });
            MainToolStrip.Location = new System.Drawing.Point(0, 0);
            MainToolStrip.Name = "MainToolStrip";
            MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            MainToolStrip.Size = new System.Drawing.Size(770, 25);
            MainToolStrip.TabIndex = 1;
            MainToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            toolStripLabel1.Text = "Index:";
            // 
            // searchByIdToolStripTextBox
            // 
            searchByIdToolStripTextBox.Name = "searchByIdToolStripTextBox";
            searchByIdToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            searchByIdToolStripTextBox.KeyUp += SearchByIdToolStripTextBox_KeyUp;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new System.Drawing.Size(42, 22);
            toolStripLabel2.Text = "Name:";
            // 
            // searchByNameToolStripTextBox
            // 
            searchByNameToolStripTextBox.Name = "searchByNameToolStripTextBox";
            searchByNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            searchByNameToolStripTextBox.KeyUp += SearchByNameToolStripTextBox_KeyUp;
            // 
            // searchByNameToolStripButton
            // 
            searchByNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            searchByNameToolStripButton.Image = (System.Drawing.Image)resources.GetObject("searchByNameToolStripButton.Image");
            searchByNameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            searchByNameToolStripButton.Name = "searchByNameToolStripButton";
            searchByNameToolStripButton.Size = new System.Drawing.Size(60, 22);
            searchByNameToolStripButton.Text = "Find next";
            searchByNameToolStripButton.Click += SearchByNameToolStripButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { memorySaveWarningToolStripMenuItem, saveDirectlyOnChangesToolStripMenuItem, setFilterToolStripMenuItem, toolStripSeparator4, setTextureOnDoubleClickToolStripMenuItem, setTexturesToolStripMenuItem });
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(45, 22);
            toolStripDropDownButton1.Text = "Misc";
            // 
            // memorySaveWarningToolStripMenuItem
            // 
            memorySaveWarningToolStripMenuItem.Checked = true;
            memorySaveWarningToolStripMenuItem.CheckOnClick = true;
            memorySaveWarningToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            memorySaveWarningToolStripMenuItem.Name = "memorySaveWarningToolStripMenuItem";
            memorySaveWarningToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            memorySaveWarningToolStripMenuItem.Text = "Memory save warning";
            // 
            // saveDirectlyOnChangesToolStripMenuItem
            // 
            saveDirectlyOnChangesToolStripMenuItem.CheckOnClick = true;
            saveDirectlyOnChangesToolStripMenuItem.Name = "saveDirectlyOnChangesToolStripMenuItem";
            saveDirectlyOnChangesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            saveDirectlyOnChangesToolStripMenuItem.Text = "Save directly on changes";
            // 
            // setFilterToolStripMenuItem
            // 
            setFilterToolStripMenuItem.Name = "setFilterToolStripMenuItem";
            setFilterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            setFilterToolStripMenuItem.Text = "Set Filter";
            setFilterToolStripMenuItem.Click += OnClickSetFilter;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(202, 6);
            // 
            // setTextureOnDoubleClickToolStripMenuItem
            // 
            setTextureOnDoubleClickToolStripMenuItem.CheckOnClick = true;
            setTextureOnDoubleClickToolStripMenuItem.Name = "setTextureOnDoubleClickToolStripMenuItem";
            setTextureOnDoubleClickToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            setTextureOnDoubleClickToolStripMenuItem.Text = "Set TexID on double click";
            // 
            // setTexturesToolStripMenuItem
            // 
            setTexturesToolStripMenuItem.Name = "setTexturesToolStripMenuItem";
            setTexturesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            setTexturesToolStripMenuItem.Text = "Set Textures";
            setTexturesToolStripMenuItem.Click += SetTextureMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(84, 22);
            toolStripButton1.Text = "Export To CSV";
            toolStripButton1.Click += OnClickExport;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new System.Drawing.Size(102, 22);
            toolStripButton5.Text = "Import From CSV";
            toolStripButton5.Click += OnClickImport;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new System.Drawing.Size(84, 22);
            toolStripButton4.Text = "Save Changes";
            toolStripButton4.Click += OnClickSaveChanges;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new System.Drawing.Size(79, 22);
            toolStripButton3.Text = "Save Tiledata";
            toolStripButton3.Click += OnClickSaveTiledata;
            // 
            // TileDataControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabcontrol);
            Controls.Add(MainToolStrip);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "TileDataControl";
            Size = new System.Drawing.Size(770, 400);
            Load += OnLoad;
            tabcontrol.ResumeLayout(false);
            tabPageItems.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ItemsContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            tabPageLand.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            LandTilesContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLand).EndInit();
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel1.PerformLayout();
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            MainToolStrip.ResumeLayout(false);
            MainToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

            // Initialize additional "?" Labels
            this.label1Info = new System.Windows.Forms.Label();
            this.label2Info = new System.Windows.Forms.Label();
            this.label3Info = new System.Windows.Forms.Label();
            this.label4Info = new System.Windows.Forms.Label();
            this.label5Info = new System.Windows.Forms.Label();
            this.label6Info = new System.Windows.Forms.Label();
            this.label7Info = new System.Windows.Forms.Label();
            this.label8Info = new System.Windows.Forms.Label();
            this.label9Info = new System.Windows.Forms.Label();
            this.label10Info = new System.Windows.Forms.Label();
            this.label11Info = new System.Windows.Forms.Label();
            this.label12Info = new System.Windows.Forms.Label();
            this.label23Info = new System.Windows.Forms.Label();
            this.label24Info = new System.Windows.Forms.Label();

            // Setup "?" Labels
            SetupInfoLabel(this.label1Info, new System.Drawing.Point(210, 8));// Name
            SetupInfoLabel(this.label2Info, new System.Drawing.Point(385, 8)); // Anim
            SetupInfoLabel(this.label3Info, new System.Drawing.Point(110, 36)); // Weight
            SetupInfoLabel(this.label4Info, new System.Drawing.Point(250, 36)); // layer
            SetupInfoLabel(this.label5Info, new System.Drawing.Point(385, 36)); // Quantity
            SetupInfoLabel(this.label6Info, new System.Drawing.Point(385, 66)); // Value
            SetupInfoLabel(this.label7Info, new System.Drawing.Point(250, 66)); // Offset
            SetupInfoLabel(this.label8Info, new System.Drawing.Point(110, 66)); // Hue
            SetupInfoLabel(this.label9Info, new System.Drawing.Point(385, 96)); // Unknown
            SetupInfoLabel(this.label10Info, new System.Drawing.Point(250, 96)); // MiscData
            SetupInfoLabel(this.label11Info, new System.Drawing.Point(110, 96)); // Height
            SetupInfoLabel(this.label12Info, new System.Drawing.Point(110, 126)); // Unknown
            SetupInfoLabel(this.label23Info, new System.Drawing.Point(170, 6)); // Name of Land
            SetupInfoLabel(this.label24Info, new System.Drawing.Point(300, 6)); // Text ID

            // Add "?" Labels to the Controls
            this.splitContainer3.Panel1.Controls.Add(this.label1Info);
            this.splitContainer3.Panel1.Controls.Add(this.label2Info);
            this.splitContainer3.Panel1.Controls.Add(this.label3Info);
            this.splitContainer3.Panel1.Controls.Add(this.label4Info);
            this.splitContainer3.Panel1.Controls.Add(this.label5Info);
            this.splitContainer3.Panel1.Controls.Add(this.label6Info);
            this.splitContainer3.Panel1.Controls.Add(this.label7Info);
            this.splitContainer3.Panel1.Controls.Add(this.label8Info);
            this.splitContainer3.Panel1.Controls.Add(this.label9Info);
            this.splitContainer3.Panel1.Controls.Add(this.label10Info);
            this.splitContainer3.Panel1.Controls.Add(this.label11Info);
            this.splitContainer3.Panel1.Controls.Add(this.label12Info);
            this.splitContainer5.Panel2.Controls.Add(this.label23Info);
            this.splitContainer7.Panel1.Controls.Add(this.label24Info);
        }

        private void SetupInfoLabel(Label label, Point location)
        {
            label.AutoSize = true;
            label.Location = location;
            label.Name = "labelInfo";
            label.Size = new Size(13, 13);
            label.TabIndex = 24;
            label.Text = "?";
            label.Cursor = Cursors.Hand;
            label.Click += new System.EventHandler(this.InfoLabel_Click);
        }


        // Method to initialize tooltips
        private void InitializeToolTips()
        {
            this.toolTipComponent.SetToolTip(this.label1Info, "Enter the name of the item (max 20 characters).");
            this.toolTipComponent.SetToolTip(this.label2Info, "Enter the animation ID for the item.");
            this.toolTipComponent.SetToolTip(this.label3Info, "Enter the weight of the item.");
            this.toolTipComponent.SetToolTip(this.label4Info, "Enter the layer of the item.");
            this.toolTipComponent.SetToolTip(this.label5Info, "Enter the quantity of the item.");
            this.toolTipComponent.SetToolTip(this.label6Info, "Enter the value of the item.");
            this.toolTipComponent.SetToolTip(this.label7Info, "Enter the stacking offset for the item.");
            this.toolTipComponent.SetToolTip(this.label8Info, "Enter the hue of the item.");
            this.toolTipComponent.SetToolTip(this.label9Info, "Enter the second unknown value.");
            this.toolTipComponent.SetToolTip(this.label10Info, "old UO Demo weapon template def");
            this.toolTipComponent.SetToolTip(this.label11Info, "Enter the height of the item.");
            this.toolTipComponent.SetToolTip(this.label12Info, "Enter the third unknown value.");
            this.toolTipComponent.SetToolTip(this.label23Info, "Enter the name of the land (max 20 characters).");
            this.toolTipComponent.SetToolTip(this.label24Info, "Enter the texture ID for the land.");
        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.ContextMenuStrip ItemsContextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip LandTilesContextMenuStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem memorySaveWarningToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.PictureBox pictureBoxLand;
        private System.Windows.Forms.ToolStripMenuItem saveDirectlyOnChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectInItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectInLandtilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectRadarColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setFilterToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPageItems;
        private System.Windows.Forms.TabPage tabPageLand;
        private System.Windows.Forms.TextBox textBoxAnim;
        private System.Windows.Forms.TextBox textBoxHeigth;
        private System.Windows.Forms.TextBox textBoxHue;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNameLand;
        private System.Windows.Forms.TextBox textBoxQuality;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxStackOff;
        private System.Windows.Forms.TextBox textBoxTexID;
        private System.Windows.Forms.TextBox textBoxUnk1;
        private System.Windows.Forms.TextBox textBoxUnk2;
        private System.Windows.Forms.TextBox textBoxUnk3;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TreeView treeViewItem;
        private System.Windows.Forms.TreeView treeViewLand;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem selectInGumpsTabMaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectInGumpsTabFemaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTexturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem setTextureOnDoubleClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchByIdToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox searchByNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchByNameToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

        // Additional Labels for "?" marks
        private System.Windows.Forms.Label label1Info;
        private System.Windows.Forms.Label label2Info;
        private System.Windows.Forms.Label label3Info;
        private System.Windows.Forms.Label label4Info;
        private System.Windows.Forms.Label label5Info;
        private System.Windows.Forms.Label label6Info;
        private System.Windows.Forms.Label label7Info;
        private System.Windows.Forms.Label label8Info;
        private System.Windows.Forms.Label label9Info;
        private System.Windows.Forms.Label label10Info;
        private System.Windows.Forms.Label label11Info;
        private System.Windows.Forms.Label label12Info;
        private System.Windows.Forms.Label label23Info;
        private System.Windows.Forms.Label label24Info;
    }
}
