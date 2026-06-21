namespace PoolTabele
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
            this.poolTable8 = new PoolTabele.PoolTable();
            this.poolTable7 = new PoolTabele.PoolTable();
            this.poolTable6 = new PoolTabele.PoolTable();
            this.poolTable2 = new PoolTabele.PoolTable();
            this.poolTable1 = new PoolTabele.PoolTable();
            this.poolTable5 = new PoolTabele.PoolTable();
            this.poolTable4 = new PoolTabele.PoolTable();
            this.poolTable3 = new PoolTabele.PoolTable();
            this.SuspendLayout();
            // 
            // poolTable8
            // 
            this.poolTable8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.poolTable8.HourlyRate = 10F;
            this.poolTable8.Location = new System.Drawing.Point(1249, 330);
            this.poolTable8.Name = "poolTable8";
            this.poolTable8.Size = new System.Drawing.Size(382, 271);
            this.poolTable8.TabIndex = 9;
            this.poolTable8.TablePlayer = "Player";
            this.poolTable8.TableTitle = "Table 8";
            this.poolTable8.OnTableComplete += new System.EventHandler<PoolTabele.PoolTable.TableCompletedEventArgs>(this.poolTable_OnTableComplete);
            // 
            // poolTable7
            // 
            this.poolTable7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.poolTable7.HourlyRate = 10F;
            this.poolTable7.Location = new System.Drawing.Point(23, 26);
            this.poolTable7.Name = "poolTable7";
            this.poolTable7.Size = new System.Drawing.Size(382, 271);
            this.poolTable7.TabIndex = 8;
            this.poolTable7.TablePlayer = "Player";
            this.poolTable7.TableTitle = "Table 1";
            this.poolTable7.OnTableComplete += new System.EventHandler<PoolTabele.PoolTable.TableCompletedEventArgs>(this.poolTable_OnTableComplete);
            // 
            // poolTable6
            // 
            this.poolTable6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.poolTable6.HourlyRate = 10F;
            this.poolTable6.Location = new System.Drawing.Point(841, 330);
            this.poolTable6.Name = "poolTable6";
            this.poolTable6.Size = new System.Drawing.Size(382, 271);
            this.poolTable6.TabIndex = 7;
            this.poolTable6.TablePlayer = "Player";
            this.poolTable6.TableTitle = "Table 7";
            this.poolTable6.OnTableComplete += new System.EventHandler<PoolTabele.PoolTable.TableCompletedEventArgs>(this.poolTable_OnTableComplete);
            // 
            // poolTable2
            // 
            this.poolTable2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.poolTable2.HourlyRate = 10F;
            this.poolTable2.Location = new System.Drawing.Point(433, 330);
            this.poolTable2.Name = "poolTable2";
            this.poolTable2.Size = new System.Drawing.Size(382, 271);
            this.poolTable2.TabIndex = 6;
            this.poolTable2.TablePlayer = "Player";
            this.poolTable2.TableTitle = "Table 6";
            this.poolTable2.OnTableComplete += new System.EventHandler<PoolTabele.PoolTable.TableCompletedEventArgs>(this.poolTable_OnTableComplete);
            // 
            // poolTable1
            // 
            this.poolTable1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.poolTable1.HourlyRate = 10F;
            this.poolTable1.Location = new System.Drawing.Point(23, 330);
            this.poolTable1.Name = "poolTable1";
            this.poolTable1.Size = new System.Drawing.Size(382, 271);
            this.poolTable1.TabIndex = 5;
            this.poolTable1.TablePlayer = "Player";
            this.poolTable1.TableTitle = "Table 5";
            this.poolTable1.OnTableComplete += new System.EventHandler<PoolTabele.PoolTable.TableCompletedEventArgs>(this.poolTable_OnTableComplete);
            // 
            // poolTable5
            // 
            this.poolTable5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.poolTable5.HourlyRate = 10F;
            this.poolTable5.Location = new System.Drawing.Point(841, 26);
            this.poolTable5.Name = "poolTable5";
            this.poolTable5.Size = new System.Drawing.Size(382, 271);
            this.poolTable5.TabIndex = 4;
            this.poolTable5.TablePlayer = "Player";
            this.poolTable5.TableTitle = "Table 3";
            this.poolTable5.OnTableComplete += new System.EventHandler<PoolTabele.PoolTable.TableCompletedEventArgs>(this.poolTable_OnTableComplete);
            // 
            // poolTable4
            // 
            this.poolTable4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.poolTable4.HourlyRate = 10F;
            this.poolTable4.Location = new System.Drawing.Point(433, 26);
            this.poolTable4.Name = "poolTable4";
            this.poolTable4.Size = new System.Drawing.Size(382, 271);
            this.poolTable4.TabIndex = 3;
            this.poolTable4.TablePlayer = "Player";
            this.poolTable4.TableTitle = "Table 2";
            this.poolTable4.OnTableComplete += new System.EventHandler<PoolTabele.PoolTable.TableCompletedEventArgs>(this.poolTable_OnTableComplete);
            // 
            // poolTable3
            // 
            this.poolTable3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.poolTable3.HourlyRate = 10F;
            this.poolTable3.Location = new System.Drawing.Point(1249, 26);
            this.poolTable3.Name = "poolTable3";
            this.poolTable3.Size = new System.Drawing.Size(382, 271);
            this.poolTable3.TabIndex = 2;
            this.poolTable3.TablePlayer = "Player";
            this.poolTable3.TableTitle = "Table 4";
            this.poolTable3.OnTableComplete += new System.EventHandler<PoolTabele.PoolTable.TableCompletedEventArgs>(this.poolTable_OnTableComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1661, 631);
            this.Controls.Add(this.poolTable8);
            this.Controls.Add(this.poolTable7);
            this.Controls.Add(this.poolTable6);
            this.Controls.Add(this.poolTable2);
            this.Controls.Add(this.poolTable1);
            this.Controls.Add(this.poolTable5);
            this.Controls.Add(this.poolTable4);
            this.Controls.Add(this.poolTable3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private PoolTable poolTable3;
        private PoolTable poolTable4;
        private PoolTable poolTable5;
        private PoolTable poolTable1;
        private PoolTable poolTable2;
        private PoolTable poolTable6;
        private PoolTable poolTable7;
        private PoolTable poolTable8;
    }
}

