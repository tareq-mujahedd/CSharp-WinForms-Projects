namespace trafic_light
{
    partial class Form1
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
            this.ctrlTraficLight1 = new trafic_light.ctrlTraficLight();
            this.SuspendLayout();
            // 
            // ctrlTraficLight1
            // 
            this.ctrlTraficLight1.CurrentLight = trafic_light.ctrlTraficLight.LightEnum.Red;
            this.ctrlTraficLight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTraficLight1.GreenTime = 6;
            this.ctrlTraficLight1.Location = new System.Drawing.Point(67, 32);
            this.ctrlTraficLight1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlTraficLight1.Name = "ctrlTraficLight1";
            this.ctrlTraficLight1.OrangeTime = 3;
            this.ctrlTraficLight1.RedTime = 6;
            this.ctrlTraficLight1.Size = new System.Drawing.Size(134, 334);
            this.ctrlTraficLight1.TabIndex = 0;
            this.ctrlTraficLight1.RedLightOn += new System.EventHandler<trafic_light.ctrlTraficLight.TraficLightEventArgs>(this.ctrlTraficLight1_RedLightOn);
            this.ctrlTraficLight1.OrangeLightOn += new System.EventHandler<trafic_light.ctrlTraficLight.TraficLightEventArgs>(this.ctrlTraficLight1_OrangeLightOn);
            this.ctrlTraficLight1.GreenLightOn += new System.EventHandler<trafic_light.ctrlTraficLight.TraficLightEventArgs>(this.ctrlTraficLight1_GreenLightOn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlTraficLight1);
            this.Name = "Form1";
            this.Text = "Trafic Light";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTraficLight ctrlTraficLight1;
    }
}

