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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.routeDesignatorInput = new vatsys.TextField();
            this.routingInput = new vatsys.TextField();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Standard Route Detector";
            this.routeDesignatorInput.TextChanged += new System.EventHandler(this.RouteDesignator_Change);
            this.routingInput.TextChanged += new System.EventHandler(this.Routing_Change);

            //Route DesignatorInput
            this.routeDesignatorInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routeDesignatorInput.Location = new System.Drawing.Point(20, 20);
            this.routeDesignatorInput.Name = "Route Designator";
            this.routeDesignatorInput.Size = new System.Drawing.Size(200, 50);
            this.routeDesignatorInput.TabIndex = 0;
            this.routeDesignatorInput.Text = "Route Designator";



            //RoutingInput
            this.routingInput.Font = new System.Drawing.Font("Terminus (TTF)", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.routingInput.Location = new System.Drawing.Point(20, 100);
            this.routingInput.Name = "Routing";
            this.routingInput.Size = new System.Drawing.Size(200, 50);
            this.routingInput.TabIndex = 0;
            this.routingInput.Text = "Routing";

            this.Controls.Add(this.routingInput);
            this.Controls.Add(this.routingInput);
        }

        #endregion
        private vatsys.TextField routeDesignatorInput;
        private vatsys.TextField routingInput;
    }
}