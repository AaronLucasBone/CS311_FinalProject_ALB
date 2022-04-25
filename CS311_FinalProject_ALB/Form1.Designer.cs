namespace CS311_FinalProject_ALB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbMetersToFeet = new System.Windows.Forms.RadioButton();
            this.grpbConversionType = new System.Windows.Forms.GroupBox();
            this.rbOuncesToGrams = new System.Windows.Forms.RadioButton();
            this.rbPoundsToKilograms = new System.Windows.Forms.RadioButton();
            this.rbFahrenheitToCelsius = new System.Windows.Forms.RadioButton();
            this.rbMilesToKilometers = new System.Windows.Forms.RadioButton();
            this.rbFeetToMeters = new System.Windows.Forms.RadioButton();
            this.rbGramsToOunces = new System.Windows.Forms.RadioButton();
            this.rbKilogramsToPounds = new System.Windows.Forms.RadioButton();
            this.rbCelsiusToFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbKilometersToMiles = new System.Windows.Forms.RadioButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblNumOutput = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grpbConversionType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(520, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "C R A Z Y Conversions";
            // 
            // rbMetersToFeet
            // 
            this.rbMetersToFeet.AutoSize = true;
            this.rbMetersToFeet.Checked = true;
            this.rbMetersToFeet.Location = new System.Drawing.Point(19, 19);
            this.rbMetersToFeet.Name = "rbMetersToFeet";
            this.rbMetersToFeet.Size = new System.Drawing.Size(93, 17);
            this.rbMetersToFeet.TabIndex = 1;
            this.rbMetersToFeet.TabStop = true;
            this.rbMetersToFeet.Text = "Meters to Feet";
            this.rbMetersToFeet.UseVisualStyleBackColor = true;
            this.rbMetersToFeet.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grpbConversionType
            // 
            this.grpbConversionType.Controls.Add(this.rbOuncesToGrams);
            this.grpbConversionType.Controls.Add(this.rbPoundsToKilograms);
            this.grpbConversionType.Controls.Add(this.rbFahrenheitToCelsius);
            this.grpbConversionType.Controls.Add(this.rbMilesToKilometers);
            this.grpbConversionType.Controls.Add(this.rbFeetToMeters);
            this.grpbConversionType.Controls.Add(this.rbGramsToOunces);
            this.grpbConversionType.Controls.Add(this.rbKilogramsToPounds);
            this.grpbConversionType.Controls.Add(this.rbCelsiusToFahrenheit);
            this.grpbConversionType.Controls.Add(this.rbKilometersToMiles);
            this.grpbConversionType.Controls.Add(this.rbMetersToFeet);
            this.grpbConversionType.Location = new System.Drawing.Point(22, 67);
            this.grpbConversionType.Name = "grpbConversionType";
            this.grpbConversionType.Size = new System.Drawing.Size(335, 151);
            this.grpbConversionType.TabIndex = 2;
            this.grpbConversionType.TabStop = false;
            this.grpbConversionType.Text = "Conversion Type";
            // 
            // rbOuncesToGrams
            // 
            this.rbOuncesToGrams.AutoSize = true;
            this.rbOuncesToGrams.Location = new System.Drawing.Point(200, 115);
            this.rbOuncesToGrams.Name = "rbOuncesToGrams";
            this.rbOuncesToGrams.Size = new System.Drawing.Size(107, 17);
            this.rbOuncesToGrams.TabIndex = 10;
            this.rbOuncesToGrams.Text = "Ounces to Grams";
            this.rbOuncesToGrams.UseVisualStyleBackColor = true;
            this.rbOuncesToGrams.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbPoundsToKilograms
            // 
            this.rbPoundsToKilograms.AutoSize = true;
            this.rbPoundsToKilograms.Location = new System.Drawing.Point(200, 91);
            this.rbPoundsToKilograms.Name = "rbPoundsToKilograms";
            this.rbPoundsToKilograms.Size = new System.Drawing.Size(121, 17);
            this.rbPoundsToKilograms.TabIndex = 9;
            this.rbPoundsToKilograms.Text = "Pounds to Kilograms";
            this.rbPoundsToKilograms.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheitToCelsius
            // 
            this.rbFahrenheitToCelsius.AutoSize = true;
            this.rbFahrenheitToCelsius.Location = new System.Drawing.Point(200, 67);
            this.rbFahrenheitToCelsius.Name = "rbFahrenheitToCelsius";
            this.rbFahrenheitToCelsius.Size = new System.Drawing.Size(123, 17);
            this.rbFahrenheitToCelsius.TabIndex = 8;
            this.rbFahrenheitToCelsius.Text = "Fahrenheit to Celsius";
            this.rbFahrenheitToCelsius.UseVisualStyleBackColor = true;
            // 
            // rbMilesToKilometers
            // 
            this.rbMilesToKilometers.AutoSize = true;
            this.rbMilesToKilometers.Location = new System.Drawing.Point(200, 43);
            this.rbMilesToKilometers.Name = "rbMilesToKilometers";
            this.rbMilesToKilometers.Size = new System.Drawing.Size(112, 17);
            this.rbMilesToKilometers.TabIndex = 7;
            this.rbMilesToKilometers.Text = "Miles to Kilometers";
            this.rbMilesToKilometers.UseVisualStyleBackColor = true;
            // 
            // rbFeetToMeters
            // 
            this.rbFeetToMeters.AutoSize = true;
            this.rbFeetToMeters.Location = new System.Drawing.Point(200, 20);
            this.rbFeetToMeters.Name = "rbFeetToMeters";
            this.rbFeetToMeters.Size = new System.Drawing.Size(93, 17);
            this.rbFeetToMeters.TabIndex = 6;
            this.rbFeetToMeters.Text = "Feet to Meters";
            this.rbFeetToMeters.UseVisualStyleBackColor = true;
            this.rbFeetToMeters.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_2);
            // 
            // rbGramsToOunces
            // 
            this.rbGramsToOunces.AutoSize = true;
            this.rbGramsToOunces.Location = new System.Drawing.Point(19, 115);
            this.rbGramsToOunces.Name = "rbGramsToOunces";
            this.rbGramsToOunces.Size = new System.Drawing.Size(107, 17);
            this.rbGramsToOunces.TabIndex = 5;
            this.rbGramsToOunces.Text = "Grams to Ounces";
            this.rbGramsToOunces.UseVisualStyleBackColor = true;
            // 
            // rbKilogramsToPounds
            // 
            this.rbKilogramsToPounds.AutoSize = true;
            this.rbKilogramsToPounds.Location = new System.Drawing.Point(19, 91);
            this.rbKilogramsToPounds.Name = "rbKilogramsToPounds";
            this.rbKilogramsToPounds.Size = new System.Drawing.Size(121, 17);
            this.rbKilogramsToPounds.TabIndex = 4;
            this.rbKilogramsToPounds.Text = "Kilograms to Pounds";
            this.rbKilogramsToPounds.UseVisualStyleBackColor = true;
            // 
            // rbCelsiusToFahrenheit
            // 
            this.rbCelsiusToFahrenheit.AutoSize = true;
            this.rbCelsiusToFahrenheit.Location = new System.Drawing.Point(19, 67);
            this.rbCelsiusToFahrenheit.Name = "rbCelsiusToFahrenheit";
            this.rbCelsiusToFahrenheit.Size = new System.Drawing.Size(123, 17);
            this.rbCelsiusToFahrenheit.TabIndex = 3;
            this.rbCelsiusToFahrenheit.Text = "Celsius to Fahrenheit";
            this.rbCelsiusToFahrenheit.UseVisualStyleBackColor = true;
            this.rbCelsiusToFahrenheit.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // rbKilometersToMiles
            // 
            this.rbKilometersToMiles.AutoSize = true;
            this.rbKilometersToMiles.Location = new System.Drawing.Point(19, 43);
            this.rbKilometersToMiles.Name = "rbKilometersToMiles";
            this.rbKilometersToMiles.Size = new System.Drawing.Size(112, 17);
            this.rbKilometersToMiles.TabIndex = 2;
            this.rbKilometersToMiles.Text = "Kilometers to Miles";
            this.rbKilometersToMiles.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(258, 271);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(99, 31);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(255, 255);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 5;
            this.lblInput.Text = "Input";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(437, 255);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Output";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(323, 319);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 41);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblNumOutput
            // 
            this.lblNumOutput.AutoSize = true;
            this.lblNumOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOutput.Location = new System.Drawing.Point(435, 274);
            this.lblNumOutput.Name = "lblNumOutput";
            this.lblNumOutput.Size = new System.Drawing.Size(76, 25);
            this.lblNumOutput.TabIndex = 8;
            this.lblNumOutput.Text = "Output";
            this.lblNumOutput.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(397, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(367, 113);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblNumOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.grpbConversionType);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbConversionType.ResumeLayout(false);
            this.grpbConversionType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbMetersToFeet;
        private System.Windows.Forms.GroupBox grpbConversionType;
        private System.Windows.Forms.RadioButton rbCelsiusToFahrenheit;
        private System.Windows.Forms.RadioButton rbKilometersToMiles;
        private System.Windows.Forms.RadioButton rbGramsToOunces;
        private System.Windows.Forms.RadioButton rbKilogramsToPounds;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton rbFeetToMeters;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RadioButton rbOuncesToGrams;
        private System.Windows.Forms.RadioButton rbPoundsToKilograms;
        private System.Windows.Forms.RadioButton rbFahrenheitToCelsius;
        private System.Windows.Forms.RadioButton rbMilesToKilometers;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblNumOutput;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

