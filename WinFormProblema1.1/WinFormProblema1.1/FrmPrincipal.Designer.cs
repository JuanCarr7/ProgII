﻿namespace WinFormProblema1._1
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesDeCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrerasToolStripMenuItem,
            this.detallesDeCarrerasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCarreraToolStripMenuItem});
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            // 
            // nuevaCarreraToolStripMenuItem
            // 
            this.nuevaCarreraToolStripMenuItem.Name = "nuevaCarreraToolStripMenuItem";
            this.nuevaCarreraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevaCarreraToolStripMenuItem.Text = "Nueva Carrera";
            this.nuevaCarreraToolStripMenuItem.Click += new System.EventHandler(this.nuevaCarreraToolStripMenuItem_Click);
            // 
            // detallesDeCarrerasToolStripMenuItem
            // 
            this.detallesDeCarrerasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDetalleToolStripMenuItem});
            this.detallesDeCarrerasToolStripMenuItem.Name = "detallesDeCarrerasToolStripMenuItem";
            this.detallesDeCarrerasToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.detallesDeCarrerasToolStripMenuItem.Text = "Detalles de Carreras";
            // 
            // nuevoDetalleToolStripMenuItem
            // 
            this.nuevoDetalleToolStripMenuItem.Name = "nuevoDetalleToolStripMenuItem";
            this.nuevoDetalleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevoDetalleToolStripMenuItem.Text = "Nuevo Detalle";
            this.nuevoDetalleToolStripMenuItem.Click += new System.EventHandler(this.nuevoDetalleToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesDeCarrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDetalleToolStripMenuItem;
    }
}