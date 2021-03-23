using System.Drawing;
namespace SRC_System_Standalone
{
    partial class SRCWindow
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
            this.routeDesignatorInput = new System.Windows.Forms.TextBox();
            this.routingInput = new System.Windows.Forms.TextBox();
            this.routeRemarks = new System.Windows.Forms.Label();
            this.routing = new System.Windows.Forms.Label();
            this.routeDesignator = new System.Windows.Forms.Label();
            this.fromInput = new System.Windows.Forms.TextBox();
            this.toInput = new System.Windows.Forms.TextBox();
            this.SRCOptions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // routeDesignatorInput
            // 
            this.routeDesignatorInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.routeDesignatorInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.routeDesignatorInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routeDesignatorInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routeDesignatorInput.Location = new System.Drawing.Point(20, 20);
            this.routeDesignatorInput.Name = "routeDesignatorInput";
            this.routeDesignatorInput.Size = new System.Drawing.Size(300, 27);
            this.routeDesignatorInput.TabIndex = 0;
            this.routeDesignatorInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.routeDesignatorInput.TextChanged += new System.EventHandler(this.RouteDesignator_Change);
            // 
            // routingInput
            // 
            this.routingInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.routingInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.routingInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.routingInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routingInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routingInput.Location = new System.Drawing.Point(375, 20);
            this.routingInput.Name = "routingInput";
            this.routingInput.Size = new System.Drawing.Size(300, 27);
            this.routingInput.TabIndex = 1;
            this.routingInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.routingInput.TextChanged += new System.EventHandler(this.Routing_Change);
            // 
            // routeRemarks
            // 
            this.routeRemarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.routeRemarks.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routeRemarks.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routeRemarks.Location = new System.Drawing.Point(-2, 125);
            this.routeRemarks.Name = "routeRemarks";
            this.routeRemarks.Size = new System.Drawing.Size(700, 25);
            this.routeRemarks.TabIndex = 2;
            this.routeRemarks.Text = "Remarks: NONE";
            this.routeRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.routeRemarks.Click += new System.EventHandler(this.routeRemarks_Click);
            // 
            // routing
            // 
            this.routing.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routing.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routing.Location = new System.Drawing.Point(20, 50);
            this.routing.Name = "routing";
            this.routing.Size = new System.Drawing.Size(300, 75);
            this.routing.TabIndex = 3;
            this.routing.Text = "Route: NONE";
            this.routing.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.routing.Click += new System.EventHandler(this.routing_Click);
            // 
            // routeDesignator
            // 
            this.routeDesignator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.routeDesignator.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routeDesignator.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routeDesignator.Location = new System.Drawing.Point(375, 50);
            this.routeDesignator.Name = "routeDesignator";
            this.routeDesignator.Size = new System.Drawing.Size(300, 75);
            this.routeDesignator.TabIndex = 4;
            this.routeDesignator.Text = "Designator: NONE";
            this.routeDesignator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.routeDesignator.Click += new System.EventHandler(this.routeDesignator_Click);
            // 
            // fromInput
            // 
            this.fromInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fromInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fromInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.fromInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.fromInput.Location = new System.Drawing.Point(23, 173);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(80, 27);
            this.fromInput.TabIndex = 5;
            this.fromInput.TextChanged += new System.EventHandler(this.FromTo_Change);
            // 
            // toInput
            // 
            this.toInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.toInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.toInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toInput.Location = new System.Drawing.Point(123, 173);
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(80, 27);
            this.toInput.TabIndex = 6;
            this.toInput.TextChanged += new System.EventHandler(this.FromTo_Change);
            // 
            // SRCOptions
            // 
            this.SRCOptions.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SRCOptions.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SRCOptions.Location = new System.Drawing.Point(250, 150);
            this.SRCOptions.Name = "SRCOptions";
            this.SRCOptions.Size = new System.Drawing.Size(460, 300);
            this.SRCOptions.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(20, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Route Designator Input";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(375, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Routing Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(23, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(120, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Terminus (TTF)", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(12, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Click on The Route, Remarks, or Designator to Copy it";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Standard Route Library Location";
            // 
            // SRCWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(750, 350);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SRCOptions);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.routeDesignator);
            this.Controls.Add(this.routing);
            this.Controls.Add(this.routeRemarks);
            this.Controls.Add(this.routingInput);
            this.Controls.Add(this.routeDesignatorInput);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(492, 227);
            this.Name = "SRCWindow";
            this.Text = "Standard Route Tool";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox routeDesignatorInput;
        private System.Windows.Forms.TextBox routingInput;
        private System.Windows.Forms.Label routeRemarks;
        private System.Windows.Forms.Label routing;
        private System.Windows.Forms.Label routeDesignator;
        private System.Windows.Forms.TextBox fromInput;
        private System.Windows.Forms.TextBox toInput;
        private System.Windows.Forms.Label SRCOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}