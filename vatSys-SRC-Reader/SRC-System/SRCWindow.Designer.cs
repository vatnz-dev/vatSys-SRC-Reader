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
            this.fromInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.fromInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.fromInput.Location = new System.Drawing.Point(20, 200);
            this.fromInput.Name = "fromInput";
            this.fromInput.NumericCharOnly = false;
            this.fromInput.Size = new System.Drawing.Size(80, 27);
            this.fromInput.TabIndex = 0;
            this.fromInput.Text = "From";
            this.fromInput.TextChanged += new System.EventHandler(this.FromTo_Change);
            // 
            // toInput
            // 
            this.toInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.toInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toInput.Location = new System.Drawing.Point(120, 200);
            this.toInput.Name = "toInput";
            this.toInput.NumericCharOnly = false;
            this.toInput.Size = new System.Drawing.Size(80, 27);
            this.toInput.TabIndex = 0;
            this.toInput.Text = "To";
            this.toInput.TextChanged += new System.EventHandler(this.FromTo_Change);
            // 
            // routeDesignatorInput
            // 
            this.routeDesignatorInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.routeDesignatorInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routeDesignatorInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routeDesignatorInput.Location = new System.Drawing.Point(20, 20);
            this.routeDesignatorInput.Name = "routeDesignatorInput";
            this.routeDesignatorInput.NumericCharOnly = false;
            this.routeDesignatorInput.Size = new System.Drawing.Size(300, 27);
            this.routeDesignatorInput.TabIndex = 0;
            this.routeDesignatorInput.Text = "Route Designator Input";
            this.routeDesignatorInput.TextChanged += new System.EventHandler(this.RouteDesignator_Change);
            // 
            // routingInput
            // 
            this.routingInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.routingInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routingInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routingInput.Location = new System.Drawing.Point(400, 20);
            this.routingInput.Name = "routingInput";
            this.routingInput.NumericCharOnly = false;
            this.routingInput.Size = new System.Drawing.Size(300, 27);
            this.routingInput.TabIndex = 0;
            this.routingInput.Text = "Routing Input";
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
            this.routeDesignator.Size = new System.Drawing.Size(300, 50);
            this.routeDesignator.TabIndex = 0;
            this.routeDesignator.Text = "Designator: NONE";
            this.routeDesignator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // routing
            // 
            this.routing.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routing.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routing.HasBorder = false;
            this.routing.InteractiveText = true;
            this.routing.Location = new System.Drawing.Point(20, 50);
            this.routing.Name = "routing";
            this.routing.Size = new System.Drawing.Size(300, 50);
            this.routing.TabIndex = 0;
            this.routing.Text = "Routing: NONE";
            this.routing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // routeRemarks
            // 
            this.routeRemarks.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routeRemarks.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.routeRemarks.HasBorder = false;
            this.routeRemarks.InteractiveText = false;
            this.routeRemarks.Location = new System.Drawing.Point(210, 100);
            this.routeRemarks.Name = "routeRemarks";
            this.routeRemarks.Size = new System.Drawing.Size(300, 50);
            this.routeRemarks.TabIndex = 0;
            this.routeRemarks.Text = "Remarks: NONE";
            this.routeRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SRCOptions
            // 
            this.SRCOptions.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SRCOptions.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SRCOptions.HasBorder = false;
            this.SRCOptions.InteractiveText = true;
            this.SRCOptions.Location = new System.Drawing.Point(350, 200);
            this.SRCOptions.Name = "SRCOptions";
            this.SRCOptions.Size = new System.Drawing.Size(2000, 500);
            this.SRCOptions.TabIndex = 0;
            // 
            // SRCWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.routeDesignator);
            this.Controls.Add(this.routing);
            this.Controls.Add(this.routingInput);
            this.Controls.Add(this.routeDesignatorInput);
            this.Controls.Add(this.routeRemarks);
            this.Controls.Add(this.SRCOptions);
            this.Name = "SRCWindow";
            this.Text = "Standard Route Detector";
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