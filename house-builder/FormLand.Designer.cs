namespace house_builder
{
    partial class FormLand
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonBuildHouse = new Button();
            buttonDestroyHouse = new Button();
            panelHouseBuilders = new Panel();
            label1 = new Label();
            pictureBoxHouse = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHouse).BeginInit();
            SuspendLayout();
            // 
            // buttonBuildHouse
            // 
            buttonBuildHouse.Location = new Point(234, 12);
            buttonBuildHouse.Name = "buttonBuildHouse";
            buttonBuildHouse.Size = new Size(116, 29);
            buttonBuildHouse.TabIndex = 0;
            buttonBuildHouse.Text = "Build house";
            buttonBuildHouse.UseVisualStyleBackColor = true;
            buttonBuildHouse.Click += buttonBuildHouse_Click;
            // 
            // buttonDestroyHouse
            // 
            buttonDestroyHouse.Enabled = false;
            buttonDestroyHouse.Location = new Point(356, 12);
            buttonDestroyHouse.Name = "buttonDestroyHouse";
            buttonDestroyHouse.Size = new Size(116, 29);
            buttonDestroyHouse.TabIndex = 1;
            buttonDestroyHouse.Text = "Destroy house";
            buttonDestroyHouse.UseVisualStyleBackColor = true;
            buttonDestroyHouse.Click += buttonDestroyHouse_Click;
            // 
            // panelHouseBuilders
            // 
            panelHouseBuilders.Location = new Point(12, 47);
            panelHouseBuilders.Name = "panelHouseBuilders";
            panelHouseBuilders.Size = new Size(216, 102);
            panelHouseBuilders.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 3;
            label1.Text = "Materials template:";
            // 
            // pictureBoxHouse
            // 
            pictureBoxHouse.BackColor = SystemColors.Control;
            pictureBoxHouse.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHouse.Location = new Point(234, 47);
            pictureBoxHouse.Name = "pictureBoxHouse";
            pictureBoxHouse.Size = new Size(238, 102);
            pictureBoxHouse.TabIndex = 4;
            pictureBoxHouse.TabStop = false;
            // 
            // FormLand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 164);
            Controls.Add(pictureBoxHouse);
            Controls.Add(label1);
            Controls.Add(panelHouseBuilders);
            Controls.Add(buttonDestroyHouse);
            Controls.Add(buttonBuildHouse);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormLand";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Land";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHouse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuildHouse;
        private Button buttonDestroyHouse;
        private Panel panelHouseBuilders;
        private Label label1;
        private PictureBox pictureBoxHouse;
    }
}
