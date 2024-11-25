using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using APP_FRAMEWORK;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;

public sealed class frmDebitCard : Form
{
	private IContainer icontainer_0;

	private BunifuTransition bunifuTransition_0;

	private BunifuTransition bunifuTransition_1;

	private BunifuElipse bunifuElipse_0;

	private Panel pnlHeader;

	private BunifuImageButton bunifuImageButton1;

	private BunifuImageButton btnClose;

	private Label label5;

	private Panel BAAAA;

	private tabNetBanking CAAA0;

	private tabDebitCard tabDebitCard;

	private IContainer components;

	private BunifuImageButton bunifuImageButton2;

	private tabCreditCard tabCreditCard;

	public frmDebitCard()
	{
		InitializeComponent();
		pnlHeader.MouseDown += StatClass.Header_MouseDown;
		pnlHeader.MouseMove += StatClass.Header_MouseMove;
		pnlHeader.MouseUp += StatClass.Header_MouseUp;
		tabDebitCard.Visible = true;
		tabDebitCard.BringToFront();
	}

	private void frmCombine_FormClosing(object sender, FormClosingEventArgs e)
	{
		StatClass.method_35();
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		BunifuAnimatorNS.Animation animation = new BunifuAnimatorNS.Animation();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebitCard));
		BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
		this.bunifuTransition_0 = new BunifuAnimatorNS.BunifuTransition(this.components);
		this.BAAAA = new System.Windows.Forms.Panel();
		this.tabDebitCard = new APP_FRAMEWORK.tabDebitCard();
		this.tabCreditCard = new APP_FRAMEWORK.tabCreditCard();
		this.CAAA0 = new APP_FRAMEWORK.tabNetBanking();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
		this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
		this.label5 = new System.Windows.Forms.Label();
		this.bunifuTransition_1 = new BunifuAnimatorNS.BunifuTransition(this.components);
		this.bunifuElipse_0 = new Bunifu.Framework.UI.BunifuElipse(this.components);
		this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
		this.BAAAA.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.bunifuImageButton1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.btnClose).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.bunifuImageButton2).BeginInit();
		base.SuspendLayout();
		this.bunifuTransition_0.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
		this.bunifuTransition_0.Cursor = null;
		animation.AnimateOnlyDifferences = true;
		animation.BlindCoeff = (System.Drawing.PointF)resources.GetObject("animation1.BlindCoeff");
		animation.LeafCoeff = 1f;
		animation.MaxTime = 1f;
		animation.MinTime = 0f;
		animation.MosaicCoeff = (System.Drawing.PointF)resources.GetObject("animation1.MosaicCoeff");
		animation.MosaicShift = (System.Drawing.PointF)resources.GetObject("animation1.MosaicShift");
		animation.MosaicSize = 0;
		animation.Padding = new System.Windows.Forms.Padding(0);
		animation.RotateCoeff = 0f;
		animation.RotateLimit = 0f;
		animation.ScaleCoeff = (System.Drawing.PointF)resources.GetObject("animation1.ScaleCoeff");
		animation.SlideCoeff = (System.Drawing.PointF)resources.GetObject("animation1.SlideCoeff");
		animation.TimeCoeff = 0f;
		animation.TransparencyCoeff = 0f;
		this.bunifuTransition_0.DefaultAnimation = animation;
		this.BAAAA.BackColor = System.Drawing.Color.Transparent;
		this.BAAAA.Controls.Add(this.tabDebitCard);
		this.BAAAA.Controls.Add(this.tabCreditCard);
		this.BAAAA.Controls.Add(this.CAAA0);
		this.bunifuTransition_1.SetDecoration(this.BAAAA, BunifuAnimatorNS.DecorationType.None);
		this.bunifuTransition_0.SetDecoration(this.BAAAA, BunifuAnimatorNS.DecorationType.None);
		this.BAAAA.Location = new System.Drawing.Point(1, 38);
		this.BAAAA.Margin = new System.Windows.Forms.Padding(4);
		this.BAAAA.Name = "BAAAA";
		this.BAAAA.Size = new System.Drawing.Size(971, 399);
		this.BAAAA.TabIndex = 1217;
		this.tabDebitCard.BackColor = System.Drawing.Color.Transparent;
		this.bunifuTransition_0.SetDecoration(this.tabDebitCard, BunifuAnimatorNS.DecorationType.None);
		this.bunifuTransition_1.SetDecoration(this.tabDebitCard, BunifuAnimatorNS.DecorationType.None);
		this.tabDebitCard.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tabDebitCard.Location = new System.Drawing.Point(0, 0);
		this.tabDebitCard.Margin = new System.Windows.Forms.Padding(0);
		this.tabDebitCard.Name = "tabDebitCard";
		this.tabDebitCard.Size = new System.Drawing.Size(971, 399);
		this.tabDebitCard.TabIndex = 2;
		this.tabCreditCard.BackColor = System.Drawing.Color.Transparent;
		this.bunifuTransition_0.SetDecoration(this.tabCreditCard, BunifuAnimatorNS.DecorationType.None);
		this.bunifuTransition_1.SetDecoration(this.tabCreditCard, BunifuAnimatorNS.DecorationType.None);
		this.tabCreditCard.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tabCreditCard.Location = new System.Drawing.Point(0, 0);
		this.tabCreditCard.Margin = new System.Windows.Forms.Padding(0);
		this.tabCreditCard.Name = "tabCreditCard";
		this.tabCreditCard.Size = new System.Drawing.Size(971, 399);
		this.tabCreditCard.TabIndex = 3;
		this.CAAA0.BackColor = System.Drawing.Color.Transparent;
		this.bunifuTransition_0.SetDecoration(this.CAAA0, BunifuAnimatorNS.DecorationType.None);
		this.bunifuTransition_1.SetDecoration(this.CAAA0, BunifuAnimatorNS.DecorationType.None);
		this.CAAA0.Location = new System.Drawing.Point(0, 0);
		this.CAAA0.Margin = new System.Windows.Forms.Padding(0);
		this.CAAA0.Name = "CAAA0";
		this.CAAA0.Size = new System.Drawing.Size(989, 382);
		this.CAAA0.TabIndex = 1;
		this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
		this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.pnlHeader.Controls.Add(this.bunifuImageButton2);
		this.pnlHeader.Controls.Add(this.bunifuImageButton1);
		this.pnlHeader.Controls.Add(this.btnClose);
		this.pnlHeader.Controls.Add(this.label5);
		this.bunifuTransition_1.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
		this.bunifuTransition_0.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
		this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
		this.pnlHeader.ForeColor = System.Drawing.Color.Black;
		this.pnlHeader.Location = new System.Drawing.Point(0, 0);
		this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(978, 38);
		this.pnlHeader.TabIndex = 1210;
		this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
		this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.bunifuTransition_1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
		this.bunifuTransition_0.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
		this.bunifuImageButton1.Image = (System.Drawing.Image)resources.GetObject("bunifuImageButton1.Image");
		this.bunifuImageButton1.ImageActive = null;
		this.bunifuImageButton1.Location = new System.Drawing.Point(-73, 54);
		this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
		this.bunifuImageButton1.Name = "bunifuImageButton1";
		this.bunifuImageButton1.Size = new System.Drawing.Size(35, 25);
		this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.bunifuImageButton1.TabIndex = 208;
		this.bunifuImageButton1.TabStop = false;
		this.bunifuImageButton1.Zoom = 10;
		this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnClose.BackColor = System.Drawing.Color.Transparent;
		this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
		this.bunifuTransition_1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
		this.bunifuTransition_0.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
		this.btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
		this.btnClose.ImageActive = null;
		this.btnClose.Location = new System.Drawing.Point(933, 2);
		this.btnClose.Margin = new System.Windows.Forms.Padding(4);
		this.btnClose.Name = "btnClose";
		this.btnClose.Size = new System.Drawing.Size(41, 32);
		this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.btnClose.TabIndex = 1;
		this.btnClose.TabStop = false;
		this.btnClose.Zoom = 10;
		this.btnClose.Click += new System.EventHandler(btnClose_Click);
		this.label5.AutoSize = true;
		this.label5.BackColor = System.Drawing.Color.Transparent;
		this.bunifuTransition_0.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
		this.bunifuTransition_1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
		this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
		this.label5.ForeColor = System.Drawing.Color.Black;
		this.label5.Location = new System.Drawing.Point(439, 4);
		this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(104, 25);
		this.label5.TabIndex = 0;
		this.label5.Text = "Debit Card";
		this.bunifuTransition_1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
		this.bunifuTransition_1.Cursor = null;
		animation2.AnimateOnlyDifferences = true;
		animation2.BlindCoeff = (System.Drawing.PointF)resources.GetObject("animation2.BlindCoeff");
		animation2.LeafCoeff = 0f;
		animation2.MaxTime = 1f;
		animation2.MinTime = 0f;
		animation2.MosaicCoeff = (System.Drawing.PointF)resources.GetObject("animation2.MosaicCoeff");
		animation2.MosaicShift = (System.Drawing.PointF)resources.GetObject("animation2.MosaicShift");
		animation2.MosaicSize = 0;
		animation2.Padding = new System.Windows.Forms.Padding(0);
		animation2.RotateCoeff = 0f;
		animation2.RotateLimit = 0f;
		animation2.ScaleCoeff = (System.Drawing.PointF)resources.GetObject("animation2.ScaleCoeff");
		animation2.SlideCoeff = (System.Drawing.PointF)resources.GetObject("animation2.SlideCoeff");
		animation2.TimeCoeff = 0f;
		animation2.TransparencyCoeff = 0f;
		this.bunifuTransition_1.DefaultAnimation = animation2;
		this.bunifuElipse_0.ElipseRadius = 5;
		this.bunifuElipse_0.TargetControl = this;
		this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
		this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.bunifuTransition_1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
		this.bunifuTransition_0.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
		this.bunifuImageButton2.Image = (System.Drawing.Image)resources.GetObject("bunifuImageButton2.Image");
		this.bunifuImageButton2.ImageActive = null;
		this.bunifuImageButton2.Location = new System.Drawing.Point(928, 3);
		this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.bunifuImageButton2.Name = "bunifuImageButton2";
		this.bunifuImageButton2.Size = new System.Drawing.Size(49, 34);
		this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.bunifuImageButton2.TabIndex = 209;
		this.bunifuImageButton2.TabStop = false;
		this.bunifuImageButton2.Zoom = 10;
		this.bunifuImageButton2.Click += new System.EventHandler(btnClose_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		base.ClientSize = new System.Drawing.Size(978, 428);
		base.Controls.Add(this.BAAAA);
		base.Controls.Add(this.pnlHeader);
		this.bunifuTransition_1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
		this.bunifuTransition_0.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "frmDebitCard";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Debit Card";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frmCombine_FormClosing);
		this.BAAAA.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		this.pnlHeader.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.bunifuImageButton1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.btnClose).EndInit();
		((System.ComponentModel.ISupportInitialize)this.bunifuImageButton2).EndInit();
		base.ResumeLayout(false);
	}
}
