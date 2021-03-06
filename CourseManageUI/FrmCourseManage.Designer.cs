﻿namespace CourseManageUI
{
    partial class FrmCourseManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourseManage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.dgvCourseList = new System.Windows.Forms.DataGridView();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnModifyCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.panelModify = new System.Windows.Forms.Panel();
            this.btnCloseModify = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCourseContent_Modify = new System.Windows.Forms.TextBox();
            this.txtCourseCredit_Modify = new System.Windows.Forms.TextBox();
            this.txtCourseHour_Modify = new System.Windows.Forms.TextBox();
            this.txtCourseName_Modify = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbCategory_Modify = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).BeginInit();
            this.panelModify.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前位置：课程管理";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(0, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(690, 1);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "课程分类：";
            // 
            // cbbCategory
            // 
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(72, 64);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(121, 20);
            this.cbbCategory.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "课程名称：";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(277, 64);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(100, 21);
            this.txtCourseName.TabIndex = 4;
            // 
            // dgvCourseList
            // 
            this.dgvCourseList.AllowUserToAddRows = false;
            this.dgvCourseList.AllowUserToDeleteRows = false;
            this.dgvCourseList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCourseList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCourseList.ColumnHeadersHeight = 30;
            this.dgvCourseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.ClassHour,
            this.Credit,
            this.CourseContent,
            this.TeacherName,
            this.CourseId});
            this.dgvCourseList.EnableHeadersVisualStyles = false;
            this.dgvCourseList.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgvCourseList.Location = new System.Drawing.Point(12, 101);
            this.dgvCourseList.Name = "dgvCourseList";
            this.dgvCourseList.ReadOnly = true;
            this.dgvCourseList.RowTemplate.Height = 23;
            this.dgvCourseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseList.Size = new System.Drawing.Size(664, 367);
            this.dgvCourseList.TabIndex = 5;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnAddCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Image")));
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourse.Location = new System.Drawing.Point(296, 9);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnAddCourse.Size = new System.Drawing.Size(90, 30);
            this.btnAddCourse.TabIndex = 6;
            this.btnAddCourse.Text = "添加课程";
            this.btnAddCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCourse.UseVisualStyleBackColor = false;
            // 
            // btnModifyCourse
            // 
            this.btnModifyCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnModifyCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnModifyCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifyCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyCourse.Image")));
            this.btnModifyCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyCourse.Location = new System.Drawing.Point(392, 9);
            this.btnModifyCourse.Name = "btnModifyCourse";
            this.btnModifyCourse.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnModifyCourse.Size = new System.Drawing.Size(90, 30);
            this.btnModifyCourse.TabIndex = 6;
            this.btnModifyCourse.Text = "修改课程";
            this.btnModifyCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyCourse.UseVisualStyleBackColor = false;
            this.btnModifyCourse.Click += new System.EventHandler(this.btnModifyCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnDeleteCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCourse.Image")));
            this.btnDeleteCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCourse.Location = new System.Drawing.Point(488, 9);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDeleteCourse.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteCourse.TabIndex = 6;
            this.btnDeleteCourse.Text = "删除课程";
            this.btnDeleteCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(584, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnQuery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(383, 59);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnQuery.Size = new System.Drawing.Size(90, 30);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "提交查询";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "课程查询总数：";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.Location = new System.Drawing.Point(642, 67);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 15);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "0";
            // 
            // panelModify
            // 
            this.panelModify.Controls.Add(this.btnCloseModify);
            this.panelModify.Controls.Add(this.groupBox1);
            this.panelModify.Controls.Add(this.label6);
            this.panelModify.Controls.Add(this.textBox7);
            this.panelModify.Controls.Add(this.textBox6);
            this.panelModify.Controls.Add(this.lblCourseId);
            this.panelModify.Controls.Add(this.btnSaveToDB);
            this.panelModify.Controls.Add(this.textBox5);
            this.panelModify.Controls.Add(this.label13);
            this.panelModify.Controls.Add(this.label14);
            this.panelModify.Controls.Add(this.label15);
            this.panelModify.Location = new System.Drawing.Point(1, 288);
            this.panelModify.Name = "panelModify";
            this.panelModify.Size = new System.Drawing.Size(690, 189);
            this.panelModify.TabIndex = 8;
            // 
            // btnCloseModify
            // 
            this.btnCloseModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnCloseModify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnCloseModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseModify.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCloseModify.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseModify.Image")));
            this.btnCloseModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseModify.Location = new System.Drawing.Point(584, 13);
            this.btnCloseModify.Name = "btnCloseModify";
            this.btnCloseModify.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnCloseModify.Size = new System.Drawing.Size(90, 30);
            this.btnCloseModify.TabIndex = 9;
            this.btnCloseModify.Text = "取消修改";
            this.btnCloseModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseModify.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbCategory_Modify);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCourseContent_Modify);
            this.groupBox1.Controls.Add(this.txtCourseCredit_Modify);
            this.groupBox1.Controls.Add(this.txtCourseHour_Modify);
            this.groupBox1.Controls.Add(this.txtCourseName_Modify);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(17, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[课程信息]";
            // 
            // txtCourseContent_Modify
            // 
            this.txtCourseContent_Modify.Location = new System.Drawing.Point(79, 76);
            this.txtCourseContent_Modify.Name = "txtCourseContent_Modify";
            this.txtCourseContent_Modify.Size = new System.Drawing.Size(412, 21);
            this.txtCourseContent_Modify.TabIndex = 8;
            // 
            // txtCourseCredit_Modify
            // 
            this.txtCourseCredit_Modify.Location = new System.Drawing.Point(555, 31);
            this.txtCourseCredit_Modify.Name = "txtCourseCredit_Modify";
            this.txtCourseCredit_Modify.Size = new System.Drawing.Size(92, 21);
            this.txtCourseCredit_Modify.TabIndex = 7;
            // 
            // txtCourseHour_Modify
            // 
            this.txtCourseHour_Modify.Location = new System.Drawing.Point(429, 31);
            this.txtCourseHour_Modify.Name = "txtCourseHour_Modify";
            this.txtCourseHour_Modify.Size = new System.Drawing.Size(62, 21);
            this.txtCourseHour_Modify.TabIndex = 6;
            // 
            // txtCourseName_Modify
            // 
            this.txtCourseName_Modify.Location = new System.Drawing.Point(80, 31);
            this.txtCourseName_Modify.Name = "txtCourseName_Modify";
            this.txtCourseName_Modify.Size = new System.Drawing.Size(276, 21);
            this.txtCourseName_Modify.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(497, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "课程学分：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "内容概述：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "课时总数：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "课程名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "课程编号:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(566, 347);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(92, 21);
            this.textBox7.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(440, 347);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(62, 21);
            this.textBox6.TabIndex = 6;
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCourseId.Location = new System.Drawing.Point(80, 15);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(16, 15);
            this.lblCourseId.TabIndex = 7;
            this.lblCourseId.Text = "0";
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnSaveToDB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnSaveToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToDB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveToDB.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveToDB.Image")));
            this.btnSaveToDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveToDB.Location = new System.Drawing.Point(488, 13);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSaveToDB.Size = new System.Drawing.Size(90, 30);
            this.btnSaveToDB.TabIndex = 6;
            this.btnSaveToDB.Text = "保存修改";
            this.btnSaveToDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveToDB.UseVisualStyleBackColor = false;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(91, 347);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(276, 21);
            this.textBox5.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "课程名称：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(380, 351);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "课时总数：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(508, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "课程学分：";
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.FillWeight = 150F;
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 150;
            // 
            // ClassHour
            // 
            this.ClassHour.DataPropertyName = "ClassHour";
            this.ClassHour.FillWeight = 80F;
            this.ClassHour.HeaderText = "课时";
            this.ClassHour.Name = "ClassHour";
            this.ClassHour.ReadOnly = true;
            this.ClassHour.Width = 80;
            // 
            // Credit
            // 
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "学分";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Width = 80;
            // 
            // CourseContent
            // 
            this.CourseContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseContent.DataPropertyName = "CourseContent";
            this.CourseContent.HeaderText = "内容概述";
            this.CourseContent.Name = "CourseContent";
            this.CourseContent.ReadOnly = true;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "课程讲师";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // CourseId
            // 
            this.CourseId.DataPropertyName = "CourseId";
            this.CourseId.HeaderText = "CourseId";
            this.CourseId.Name = "CourseId";
            this.CourseId.ReadOnly = true;
            this.CourseId.Visible = false;
            // 
            // cbbCategory_Modify
            // 
            this.cbbCategory_Modify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory_Modify.FormattingEnabled = true;
            this.cbbCategory_Modify.Location = new System.Drawing.Point(555, 76);
            this.cbbCategory_Modify.Name = "cbbCategory_Modify";
            this.cbbCategory_Modify.Size = new System.Drawing.Size(92, 20);
            this.cbbCategory_Modify.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "课程分类：";
            // 
            // FrmCourseManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(690, 480);
            this.Controls.Add(this.panelModify);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnModifyCourse);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.dgvCourseList);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCourseManage";
            this.Text = "FrmCourseManage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).EndInit();
            this.panelModify.ResumeLayout(false);
            this.panelModify.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.DataGridView dgvCourseList;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnModifyCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel panelModify;
        private System.Windows.Forms.Button btnCloseModify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCourseContent_Modify;
        private System.Windows.Forms.TextBox txtCourseCredit_Modify;
        private System.Windows.Forms.TextBox txtCourseHour_Modify;
        private System.Windows.Forms.TextBox txtCourseName_Modify;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.ComboBox cbbCategory_Modify;
        private System.Windows.Forms.Label label7;
    }
}