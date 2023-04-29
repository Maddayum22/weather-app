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
            weatherOutput = new TextBox();
            getWeather = new Button();
            label1 = new Label();
            weatherInput = new TextBox();
            SuspendLayout();
            // 
            // weatherOutput
            // 
            weatherOutput.Location = new Point(44, 83);
            weatherOutput.Multiline = true;
            weatherOutput.Name = "weatherOutput";
            weatherOutput.Size = new Size(567, 284);
            weatherOutput.TabIndex = 0;
            // 
            // getWeather
            // 
            getWeather.Location = new Point(473, 38);
            getWeather.Name = "getWeather";
            getWeather.Size = new Size(138, 29);
            getWeather.TabIndex = 1;
            getWeather.Text = "Get Weather";
            getWeather.UseVisualStyleBackColor = true;
            getWeather.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 43);
            label1.Name = "label1";
            label1.Size = new Size(112, 18);
            label1.TabIndex = 2;
            label1.Text = "Enter a City:";
            label1.Click += label1_Click;
            // 
            // weatherInput
            // 
            weatherInput.Location = new Point(162, 40);
            weatherInput.Name = "weatherInput";
            weatherInput.Size = new Size(305, 25);
            weatherInput.TabIndex = 3;
            weatherInput.TextChanged += weatherInput_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(664, 441);
            Controls.Add(weatherInput);
            Controls.Add(label1);
            Controls.Add(getWeather);
            Controls.Add(weatherOutput);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Weather App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox weatherOutput;
        private Button getWeather;
        private Label label1;
        private TextBox weatherInput;
    }
}