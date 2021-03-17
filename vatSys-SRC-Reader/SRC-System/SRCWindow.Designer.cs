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
            this.routeDesignatorInput = new vatsys.TextField();
            this.routingInput = new vatsys.TextField();
            this.routeDesignator = new vatsys.TextLabel();
            this.routing = new vatsys.TextLabel();
            this.routeRemarks = new vatsys.TextLabel();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Standard Route Detector";


            this.routeDesignatorInput.TextChanged += new System.EventHandler(this.RouteDesignator_Change);
            this.routingInput.TextChanged += new System.EventHandler(this.Routing_Change);

            //Route DesignatorInput
            this.routeDesignatorInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routeDesignatorInput.Location = new System.Drawing.Point(20, 20);
            this.routeDesignatorInput.Name = "Route Designator Input";
            this.routeDesignatorInput.Size = new System.Drawing.Size(300, 50);
            this.routeDesignatorInput.TabIndex = 0;
            this.routeDesignatorInput.Text = "Route Designator Input";


            //RoutingInput
            this.routingInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routingInput.Location = new System.Drawing.Point(400, 20);
            this.routingInput.Name = "Routing Input";
            this.routingInput.Size = new System.Drawing.Size(300, 50);
            this.routingInput.TabIndex = 0;
            this.routingInput.Text = "Routing Input";

            //Route
            this.routing.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routing.Location = new System.Drawing.Point(20, 50);
            this.routing.Name = "Routing";
            this.routing.Size = new System.Drawing.Size(300, 50);
            this.routing.TabIndex = 0;
            this.routing.Text = "Routing: NONE";

            //Route Designator
            this.routeDesignator.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routeDesignator.Location = new System.Drawing.Point(400, 50);
            this.routeDesignator.Name = "RouteDesignator";
            this.routeDesignator.Size = new System.Drawing.Size(300, 50);
            this.routeDesignator.TabIndex = 0;
            this.routeDesignator.Text = "Designator: NONE";

            //Route Remarks
            this.routeRemarks.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routeRemarks.Location = new System.Drawing.Point(210, 100);
            this.routeRemarks.Name = "RouteDesignator";
            this.routeRemarks.Size = new System.Drawing.Size(300, 50);
            this.routeRemarks.TabIndex = 0;
            this.routeRemarks.Text = "Remarks: NONE";

            this.Controls.Add(this.routeDesignator);
            this.Controls.Add(this.routing);
            this.Controls.Add(this.routingInput);
            this.Controls.Add(this.routeDesignatorInput);
            this.Controls.Add(this.routeRemarks);

        }

        private vatsys.TextField routeDesignatorInput;
        private vatsys.TextField routingInput;

        private vatsys.TextLabel routing;
        private vatsys.TextLabel routeDesignator;
        private vatsys.TextLabel routeRemarks;
    }
}