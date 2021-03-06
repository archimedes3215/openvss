// buhp	 IMPORTANT: READ BEFORE DOWNLOADING, COPYING, INSTALLING OR USING. 
// gizk	
// lyer	 By downloading, copying, installing or using the software you agree to this license.
// yxja	 If you do not agree to this license, do not download, install,
// eseq	 copy or use the software.
// rtpk	
// edhx	                          License Agreement
// coxr	         For OpenVSS - Open Source Video Surveillance System
// optm	
// noep	Copyright (C) 2007-2010, Prince of Songkla University, All rights reserved.
// idio	
// zkss	Third party copyrights are property of their respective owners.
// ysdj	
// zohi	Redistribution and use in source and binary forms, with or without modification,
// ewld	are permitted provided that the following conditions are met:
// bchw	
// bndj	  * Redistribution's of source code must retain the above copyright notice,
// dwmp	    this list of conditions and the following disclaimer.
// npin	
// kblt	  * Redistribution's in binary form must reproduce the above copyright notice,
// kpzk	    this list of conditions and the following disclaimer in the documentation
// lorz	    and/or other materials provided with the distribution.
// iliq	
// dbnf	  * Neither the name of the copyright holders nor the names of its contributors 
// vlnm	    may not be used to endorse or promote products derived from this software 
// hjob	    without specific prior written permission.
// fowj	
// guxd	This software is provided by the copyright holders and contributors "as is" and
// lrsm	any express or implied warranties, including, but not limited to, the implied
// cxlm	warranties of merchantability and fitness for a particular purpose are disclaimed.
// wdar	In no event shall the Prince of Songkla University or contributors be liable 
// ovll	for any direct, indirect, incidental, special, exemplary, or consequential damages
// ccry	(including, but not limited to, procurement of substitute goods or services;
// nzmb	loss of use, data, or profits; or business interruption) however caused
// ayew	and on any theory of liability, whether in contract, strict liability,
// shto	or tort (including negligence or otherwise) arising in any way out of
// oefm	the use of this software, even if advised of the possibility of such damage.
// ibcy	
// aape	Intelligent Systems Laboratory (iSys Lab)
// iwmk	Faculty of Engineering, Prince of Songkla University, THAILAND
// ckhd	Project leader by Nikom SUVONVORN
// cypm	Project website at http://code.google.com/p/openvss/

namespace Vs.Monitor
{
    partial class VsTreeviewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VsTreeviewControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vsCameraTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cameraContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cameraAddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraRemoveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.channelContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.channelAddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.channelRemoveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pageContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pageAddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pageRemoveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cameraContextMenu.SuspendLayout();
            this.channelContextMenu.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.vsCameraTree, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 282);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // vsCameraTree
            // 
            this.vsCameraTree.AllowDrop = true;
            this.vsCameraTree.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vsCameraTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vsCameraTree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vsCameraTree.FullRowSelect = true;
            this.vsCameraTree.ImageIndex = 0;
            this.vsCameraTree.ImageList = this.imageList1;
            this.vsCameraTree.Location = new System.Drawing.Point(2, 22);
            this.vsCameraTree.Margin = new System.Windows.Forms.Padding(2);
            this.vsCameraTree.Name = "vsCameraTree";
            this.vsCameraTree.SelectedImageIndex = 0;
            this.vsCameraTree.Size = new System.Drawing.Size(220, 258);
            this.vsCameraTree.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "note_go.png");
            this.imageList1.Images.SetKeyName(1, "folder_camera.png");
            this.imageList1.Images.SetKeyName(2, "folder_channel.png");
            this.imageList1.Images.SetKeyName(3, "folder_table.png");
            this.imageList1.Images.SetKeyName(4, "webcam.png");
            this.imageList1.Images.SetKeyName(5, "image.png");
            this.imageList1.Images.SetKeyName(6, "images.png");
            this.imageList1.Images.SetKeyName(7, "accept.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 20);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "รายการกล้อง";
            // 
            // cameraContextMenu
            // 
            this.cameraContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraAddMenu,
            this.cameraRemoveMenu});
            this.cameraContextMenu.Name = "cameraContextMenu";
            this.cameraContextMenu.Size = new System.Drawing.Size(159, 48);
            // 
            // cameraAddMenu
            // 
            this.cameraAddMenu.Image = global::Vs.Monitor.Properties.Resources.camera_add;
            this.cameraAddMenu.Name = "cameraAddMenu";
            this.cameraAddMenu.Size = new System.Drawing.Size(158, 22);
            this.cameraAddMenu.Text = "Add Analyzer";
            this.cameraAddMenu.Click += new System.EventHandler(this.cameraAddMenu_Click);
            // 
            // cameraRemoveMenu
            // 
            this.cameraRemoveMenu.Image = global::Vs.Monitor.Properties.Resources.camera_delete;
            this.cameraRemoveMenu.Name = "cameraRemoveMenu";
            this.cameraRemoveMenu.Size = new System.Drawing.Size(158, 22);
            this.cameraRemoveMenu.Text = "Remove Analyzer";
            this.cameraRemoveMenu.Click += new System.EventHandler(this.cameraRemoveMenu_Click);
            // 
            // channelContextMenu
            // 
            this.channelContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channelAddMenu,
            this.channelRemoveMenu});
            this.channelContextMenu.Name = "channelContextMenu";
            this.channelContextMenu.Size = new System.Drawing.Size(150, 48);
            // 
            // channelAddMenu
            // 
            this.channelAddMenu.Image = global::Vs.Monitor.Properties.Resources.image_add;
            this.channelAddMenu.Name = "channelAddMenu";
            this.channelAddMenu.Size = new System.Drawing.Size(149, 22);
            this.channelAddMenu.Text = "Add Layout";
            this.channelAddMenu.Click += new System.EventHandler(this.channelAddMenu_Click);
            // 
            // channelRemoveMenu
            // 
            this.channelRemoveMenu.Image = global::Vs.Monitor.Properties.Resources.image_delete;
            this.channelRemoveMenu.Name = "channelRemoveMenu";
            this.channelRemoveMenu.Size = new System.Drawing.Size(149, 22);
            this.channelRemoveMenu.Text = "Remove Layout";
            this.channelRemoveMenu.Click += new System.EventHandler(this.channelRemoveMenu_Click);
            // 
            // pageContextMenu
            // 
            this.pageContextMenu.Name = "pageContextMenu";
            this.pageContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // pageAddMenu
            // 
            this.pageAddMenu.Name = "pageAddMenu";
            this.pageAddMenu.Size = new System.Drawing.Size(32, 19);
            // 
            // pageRemoveMenu
            // 
            this.pageRemoveMenu.Name = "pageRemoveMenu";
            this.pageRemoveMenu.Size = new System.Drawing.Size(32, 19);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Vs.Monitor.Properties.Resources.cancel;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 100);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = global::Vs.Monitor.Properties.Resources.monitor_add;
            this.button2.Location = new System.Drawing.Point(74, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 24);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // VsTreeviewControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "VsTreeviewControl";
            this.Size = new System.Drawing.Size(224, 282);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cameraContextMenu.ResumeLayout(false);
            this.channelContextMenu.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip cameraContextMenu;
        private System.Windows.Forms.ToolStripMenuItem cameraAddMenu;
        private System.Windows.Forms.ContextMenuStrip channelContextMenu;
        private System.Windows.Forms.ContextMenuStrip pageContextMenu;
        private System.Windows.Forms.ToolStripMenuItem cameraRemoveMenu;
        private System.Windows.Forms.ToolStripMenuItem channelAddMenu;
        private System.Windows.Forms.ToolStripMenuItem channelRemoveMenu;
        private System.Windows.Forms.ToolStripMenuItem pageAddMenu;
        private System.Windows.Forms.ToolStripMenuItem pageRemoveMenu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView vsCameraTree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}
