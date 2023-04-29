namespace weather_app
{
    partial class Form1
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
            getWeather = new Button();
            label1 = new Label();
            weatherInput = new TextBox();
            weatherPic = new PictureBox();
            label2 = new Label();
            temperatureOutput = new Label();
            errorText = new Label();
            weatherTypeOutput = new Label();
            weatherType = new Label();
            city = new Label();
            ((System.ComponentModel.ISupportInitialize)weatherPic).BeginInit();
            SuspendLayout();
            // 
            // getWeather
            // 
            getWeather.FlatStyle = FlatStyle.System;
            getWeather.ForeColor = Color.FromArgb(11, 49, 66);
            getWeather.Location = new Point(592, 40);
            getWeather.Margin = new Padding(4, 3, 4, 3);
            getWeather.Name = "getWeather";
            getWeather.Size = new Size(173, 31);
            getWeather.TabIndex = 1;
            getWeather.Text = "Get Weather";
            getWeather.UseVisualStyleBackColor = true;
            getWeather.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 2;
            label1.Text = "Enter a City:";
            label1.Click += label1_Click;
            // 
            // weatherInput
            // 
            weatherInput.Location = new Point(203, 42);
            weatherInput.Margin = new Padding(4, 3, 4, 3);
            weatherInput.Name = "weatherInput";
            weatherInput.Size = new Size(380, 27);
            weatherInput.TabIndex = 3;
            weatherInput.TextChanged += weatherInput_TextChanged;
            // 
            // weatherPic
            // 
            weatherPic.BorderStyle = BorderStyle.Fixed3D;
            weatherPic.Location = new Point(55, 131);
            weatherPic.Margin = new Padding(4, 3, 4, 3);
            weatherPic.Name = "weatherPic";
            weatherPic.Size = new Size(70, 70);
            weatherPic.TabIndex = 4;
            weatherPic.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 216);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 19);
            label2.TabIndex = 5;
            label2.Text = "Temperature:";
            label2.Click += label2_Click;
            // 
            // temperatureOutput
            // 
            temperatureOutput.AutoSize = true;
            temperatureOutput.Location = new Point(183, 216);
            temperatureOutput.Margin = new Padding(4, 0, 4, 0);
            temperatureOutput.Name = "temperatureOutput";
            temperatureOutput.Size = new Size(0, 19);
            temperatureOutput.TabIndex = 6;
            // 
            // errorText
            // 
            errorText.AutoSize = true;
            errorText.ForeColor = Color.Red;
            errorText.Location = new Point(55, 86);
            errorText.Margin = new Padding(4, 0, 4, 0);
            errorText.Name = "errorText";
            errorText.Size = new Size(0, 19);
            errorText.TabIndex = 7;
            // 
            // weatherTypeOutput
            // 
            weatherTypeOutput.AutoSize = true;
            weatherTypeOutput.Location = new Point(183, 257);
            weatherTypeOutput.Margin = new Padding(4, 0, 4, 0);
            weatherTypeOutput.Name = "weatherTypeOutput";
            weatherTypeOutput.Size = new Size(0, 19);
            weatherTypeOutput.TabIndex = 9;
            weatherTypeOutput.Click += label3_Click;
            // 
            // weatherType
            // 
            weatherType.AutoSize = true;
            weatherType.Location = new Point(55, 257);
            weatherType.Margin = new Padding(4, 0, 4, 0);
            weatherType.Name = "weatherType";
            weatherType.Size = new Size(78, 19);
            weatherType.TabIndex = 8;
            weatherType.Text = "Weather:";
            weatherType.Click += label4_Click;
            // 
            // city
            // 
            city.AutoSize = true;
            city.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            city.Location = new Point(392, 86);
            city.Name = "city";
            city.Size = new Size(50, 27);
            city.TabIndex = 10;
            city.Text = "City";
            city.Click += city_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 49, 66);
            ClientSize = new Size(830, 466);
            Controls.Add(city);
            Controls.Add(weatherTypeOutput);
            Controls.Add(weatherType);
            Controls.Add(errorText);
            Controls.Add(temperatureOutput);
            Controls.Add(label2);
            Controls.Add(weatherPic);
            Controls.Add(weatherInput);
            Controls.Add(label1);
            Controls.Add(getWeather);
            Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Weather App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)weatherPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button getWeather;
        private Label label1;
        private TextBox weatherInput;
        private PictureBox weatherPic;
        private Label label2;
        private Label temperatureOutput;
        private Label errorText;
        private Label weatherTypeOutput;
        private Label weatherType;
        private Label city;
    }
}