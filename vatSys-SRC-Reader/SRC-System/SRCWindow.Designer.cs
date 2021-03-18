namespace SRC_System
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

        private void InitializeComponent()
        {
            this.fromInput = new vatsys.TextField();
            this.toInput = new vatsys.TextField();
            this.routeDesignatorInput = new vatsys.TextField();
            this.routingInput = new vatsys.TextField();
            this.routeDesignator = new vatsys.TextLabel();
            this.routing = new vatsys.TextLabel();
            this.routeRemarks = new vatsys.TextLabel();
            this.SRCOptions = new vatsys.TextLabel();
            this.SuspendLayout();
            // 
            // fromInput
            // 
            this.fromInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fromInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fromInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.fromInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.fromInput.Location = new System.Drawing.Point(20, 150);
            this.fromInput.Name = "fromInput";
            this.fromInput.NumericCharOnly = false;
            this.fromInput.Size = new System.Drawing.Size(80, 27);
            this.fromInput.TabIndex = 0;
            this.fromInput.Text = "FROM";
            this.fromInput.TextChanged += new System.EventHandler(this.FromTo_Change);
            // 
            // toInput
            // 
            this.toInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.toInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.toInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toInput.Location = new System.Drawing.Point(120, 150);
            this.toInput.Name = "toInput";
            this.toInput.NumericCharOnly = false;
            this.toInput.Size = new System.Drawing.Size(80, 27);
            this.toInput.TabIndex = 0;
            this.toInput.Text = "TO";
            this.toInput.TextChanged += new System.EventHandler(this.FromTo_Change);
            // 
            // routeDesignatorInput
            // 
            this.routeDesignatorInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.routeDesignatorInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.routeDesignatorInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routeDesignatorInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routeDesignatorInput.Location = new System.Drawing.Point(20, 20);
            this.routeDesignatorInput.Name = "routeDesignatorInput";
            this.routeDesignatorInput.NumericCharOnly = false;
            this.routeDesignatorInput.Size = new System.Drawing.Size(300, 27);
            this.routeDesignatorInput.TabIndex = 0;
            this.routeDesignatorInput.Text = "ROUTE DESIGNATOR INPUT";
            this.routeDesignatorInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.routeDesignatorInput.TextChanged += new System.EventHandler(this.RouteDesignator_Change);
            // 
            // routingInput
            // 
            this.routingInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.routingInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.routingInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routingInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routingInput.Location = new System.Drawing.Point(400, 20);
            this.routingInput.Name = "routingInput";
            this.routingInput.NumericCharOnly = false;
            this.routingInput.Size = new System.Drawing.Size(300, 27);
            this.routingInput.TabIndex = 0;
            this.routingInput.Text = "ROUTING INPUT";
            this.routingInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.routingInput.TextChanged += new System.EventHandler(this.Routing_Change);
            // 
            // routeDesignator
            // 
            this.routeDesignator.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routeDesignator.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routeDesignator.HasBorder = false;
            this.routeDesignator.InteractiveText = true;
            this.routeDesignator.Location = new System.Drawing.Point(400, 50);
            this.routeDesignator.Name = "routeDesignator";
            this.routeDesignator.Size = new System.Drawing.Size(300, 75);
            this.routeDesignator.TabIndex = 0;
            this.routeDesignator.Text = "Designator: NONE";
            this.routeDesignator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // routing
            // 
            this.routing.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routing.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routing.HasBorder = false;
            this.routing.InteractiveText = true;
            this.routing.Location = new System.Drawing.Point(20, 50);
            this.routing.Name = "routing";
            this.routing.Size = new System.Drawing.Size(300, 75);
            this.routing.TabIndex = 0;
            this.routing.Text = "Route: NONE";
            this.routing.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // routeRemarks
            // 
            this.routeRemarks.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routeRemarks.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routeRemarks.HasBorder = false;
            this.routeRemarks.InteractiveText = false;
            this.routeRemarks.Location = new System.Drawing.Point(10, 125);
            this.routeRemarks.Name = "routeRemarks";
            this.routeRemarks.Size = new System.Drawing.Size(700, 25);
            this.routeRemarks.TabIndex = 0;
            this.routeRemarks.Text = "Remarks: NONE";
            this.routeRemarks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SRCOptions
            // 
            this.SRCOptions.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SRCOptions.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SRCOptions.HasBorder = false;
            this.SRCOptions.InteractiveText = true;
            this.SRCOptions.Location = new System.Drawing.Point(250, 150);
            this.SRCOptions.Name = "SRCOptions";
            this.SRCOptions.Size = new System.Drawing.Size(2000, 500);
            this.SRCOptions.TabIndex = 0;
            // 
            // SRCWindow
            // 
            this.ClientSize = new System.Drawing.Size(725, 300);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.routeDesignator);
            this.Controls.Add(this.routing);
            this.Controls.Add(this.routingInput);
            this.Controls.Add(this.routeDesignatorInput);
            this.Controls.Add(this.routeRemarks);
            this.Controls.Add(this.SRCOptions);
            this.MinimumSize = new System.Drawing.Size(725, 300);
            this.Name = "SRCWindow";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Standard Route Tool";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private vatsys.TextField routeDesignatorInput;
        private vatsys.TextField routingInput;
        private vatsys.TextField fromInput;
        private vatsys.TextField toInput;


        private vatsys.TextLabel SRCOptions;
        private vatsys.TextLabel routing;
        private vatsys.TextLabel routeDesignator;
        private vatsys.TextLabel routeRemarks;
    }
}