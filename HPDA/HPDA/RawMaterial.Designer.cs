﻿namespace HPDA
{
    partial class RawMaterial
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mBc2 = new Symbol.Barcode2.Design.Barcode2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblcVendor = new System.Windows.Forms.Label();
            this.lblcInvName = new System.Windows.Forms.Label();
            this.lbldDate = new System.Windows.Forms.Label();
            this.lblcDefine2 = new System.Windows.Forms.Label();
            this.lblcLotNo = new System.Windows.Forms.Label();
            this.lblcInvCode = new System.Windows.Forms.Label();
            this.lblCompanyLot = new System.Windows.Forms.Label();
            this.lblcDefine1 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mBc2
            // 
            this.mBc2.Config.DecoderParameters.CODABAR = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.mBc2.Config.DecoderParameters.CODABARParams.NotisEditing = false;
            this.mBc2.Config.DecoderParameters.CODABARParams.Redundancy = true;
            this.mBc2.Config.DecoderParameters.CODE128 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.DecoderParameters.CODE128Params.EAN128 = true;
            this.mBc2.Config.DecoderParameters.CODE128Params.ISBT128 = true;
            this.mBc2.Config.DecoderParameters.CODE128Params.Other128 = true;
            this.mBc2.Config.DecoderParameters.CODE128Params.Redundancy = false;
            this.mBc2.Config.DecoderParameters.CODE39 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.mBc2.Config.DecoderParameters.CODE39Params.Concatenation = false;
            this.mBc2.Config.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.mBc2.Config.DecoderParameters.CODE39Params.FullAscii = false;
            this.mBc2.Config.DecoderParameters.CODE39Params.Redundancy = false;
            this.mBc2.Config.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.mBc2.Config.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.mBc2.Config.DecoderParameters.CODE93 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.DecoderParameters.CODE93Params.Redundancy = false;
            this.mBc2.Config.DecoderParameters.D2OF5 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.DecoderParameters.D2OF5Params.Redundancy = true;
            this.mBc2.Config.DecoderParameters.EAN13 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.DecoderParameters.EAN8 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.mBc2.Config.DecoderParameters.I2OF5 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.mBc2.Config.DecoderParameters.I2OF5Params.Redundancy = true;
            this.mBc2.Config.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.mBc2.Config.DecoderParameters.I2OF5Params.VerifyCheckDigit = Symbol.Barcode2.Design.I2OF5.CheckDigitSchemes.Default;
            this.mBc2.Config.DecoderParameters.KOREAN_3OF5 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.DecoderParameters.KOREAN_3OF5Params.Redundancy = true;
            this.mBc2.Config.DecoderParameters.MSI = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode2.Design.CheckDigitCounts.Default;
            this.mBc2.Config.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode2.Design.CheckDigitSchemes.Default;
            this.mBc2.Config.DecoderParameters.MSIParams.Redundancy = true;
            this.mBc2.Config.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.mBc2.Config.DecoderParameters.UPCA = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode2.Design.Preambles.Default;
            this.mBc2.Config.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.mBc2.Config.DecoderParameters.UPCE0 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.mBc2.Config.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode2.Design.Preambles.Default;
            this.mBc2.Config.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Symbol.Barcode2.Design.AIM_MODE.AIM_MODE_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Symbol.Barcode2.Design.AIM_TYPE.AIM_TYPE_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Symbol.Barcode2.Design.DPM_MODE.DPM_MODE_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Symbol.Barcode2.Design.FOCUS_MODE.FOCUS_MODE_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Symbol.Barcode2.Design.FOCUS_POSITION.FOCUS_POSITION_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Symbol.Barcode2.Design.ILLUMINATION_MODE.ILLUMINATION_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Symbol.Barcode2.Design.INVERSE1D_MODE.INVERSE_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Symbol.Barcode2.Design.LINEAR_SECURITY_LEVEL.SECURITY_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Symbol.Barcode2.Design.PICKLIST_MODE.PICKLIST_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Symbol.Barcode2.Design.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Symbol.Barcode2.Design.VIEWFINDER_MODE.VIEWFINDER_MODE_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Symbol.Barcode2.Design.AIM_MODE.AIM_MODE_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Symbol.Barcode2.Design.AIM_TYPE.AIM_TYPE_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BeamWidth = Symbol.Barcode2.Design.BEAM_WIDTH.DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Symbol.Barcode2.Design.DBP_MODE.DBP_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Symbol.Barcode2.Design.LINEAR_SECURITY_LEVEL.SECURITY_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Symbol.Barcode2.Design.RASTER_MODE.RASTER_MODE_DEFAULT;
            this.mBc2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.mBc2.Config.ScanParameters.BeepFrequency = 2670;
            this.mBc2.Config.ScanParameters.BeepTime = 200;
            this.mBc2.Config.ScanParameters.CodeIdType = Symbol.Barcode2.Design.CodeIdTypes.Default;
            this.mBc2.Config.ScanParameters.LedTime = 3000;
            this.mBc2.Config.ScanParameters.ScanType = Symbol.Barcode2.Design.SCANTYPES.Default;
            this.mBc2.Config.ScanParameters.WaveFile = "";
            this.mBc2.DeviceType = Symbol.Barcode2.DEVICETYPES.FIRSTAVAILABLE;
            this.mBc2.EnableScanner = false;
            this.mBc2.OnScan += new Symbol.Barcode2.Design.Barcode2.OnScanEventHandler(this.mBc2_OnScan);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.Text = "编码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.Text = "批次号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.Text = "名称";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(23, 67);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(76, 20);
            this.lblDate.Text = "进货日期";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.Text = "生产日期";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCompany
            // 
            this.lblCompany.Location = new System.Drawing.Point(23, 160);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(76, 20);
            this.lblCompany.Text = "供应商";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblcVendor
            // 
            this.lblcVendor.Location = new System.Drawing.Point(109, 160);
            this.lblcVendor.Name = "lblcVendor";
            this.lblcVendor.Size = new System.Drawing.Size(187, 20);
            // 
            // lblcInvName
            // 
            this.lblcInvName.Location = new System.Drawing.Point(109, 36);
            this.lblcInvName.Name = "lblcInvName";
            this.lblcInvName.Size = new System.Drawing.Size(187, 20);
            // 
            // lbldDate
            // 
            this.lbldDate.Location = new System.Drawing.Point(109, 67);
            this.lbldDate.Name = "lbldDate";
            this.lbldDate.Size = new System.Drawing.Size(187, 20);
            // 
            // lblcDefine2
            // 
            this.lblcDefine2.Location = new System.Drawing.Point(109, 98);
            this.lblcDefine2.Name = "lblcDefine2";
            this.lblcDefine2.Size = new System.Drawing.Size(187, 20);
            // 
            // lblcLotNo
            // 
            this.lblcLotNo.Location = new System.Drawing.Point(109, 129);
            this.lblcLotNo.Name = "lblcLotNo";
            this.lblcLotNo.Size = new System.Drawing.Size(187, 20);
            // 
            // lblcInvCode
            // 
            this.lblcInvCode.Location = new System.Drawing.Point(109, 5);
            this.lblcInvCode.Name = "lblcInvCode";
            this.lblcInvCode.Size = new System.Drawing.Size(187, 20);
            // 
            // lblCompanyLot
            // 
            this.lblCompanyLot.Location = new System.Drawing.Point(11, 191);
            this.lblCompanyLot.Name = "lblCompanyLot";
            this.lblCompanyLot.Size = new System.Drawing.Size(88, 20);
            this.lblCompanyLot.Text = "供应商批号";
            this.lblCompanyLot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblcDefine1
            // 
            this.lblcDefine1.Location = new System.Drawing.Point(109, 191);
            this.lblcDefine1.Name = "lblcDefine1";
            this.lblcDefine1.Size = new System.Drawing.Size(187, 20);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(109, 219);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(187, 20);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.Text = "总库存";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 269);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblcDefine1);
            this.Controls.Add(this.lblCompanyLot);
            this.Controls.Add(this.lblcVendor);
            this.Controls.Add(this.lblcInvName);
            this.Controls.Add(this.lbldDate);
            this.Controls.Add(this.lblcDefine2);
            this.Controls.Add(this.lblcLotNo);
            this.Controls.Add(this.lblcInvCode);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RawMaterial";
            this.Text = "明细及存量";
            this.Load += new System.EventHandler(this.RawMaterial_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.RawMaterial_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private Symbol.Barcode2.Design.Barcode2 mBc2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblcVendor;
        private System.Windows.Forms.Label lblcInvName;
        private System.Windows.Forms.Label lbldDate;
        private System.Windows.Forms.Label lblcDefine2;
        private System.Windows.Forms.Label lblcLotNo;
        private System.Windows.Forms.Label lblcInvCode;
        private System.Windows.Forms.Label lblCompanyLot;
        private System.Windows.Forms.Label lblcDefine1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label8;
    }
}