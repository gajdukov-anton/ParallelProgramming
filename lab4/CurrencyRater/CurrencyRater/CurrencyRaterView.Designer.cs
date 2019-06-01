namespace CurrencyRater
{
    partial class CurrencyRaterView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.avrTimeAsyncLabel = new System.Windows.Forms.Label();
            this.avrTimeLabel = new System.Windows.Forms.Label();
            this.timeWorkAsyncListBox = new System.Windows.Forms.ListBox();
            this.timeWorkListBox = new System.Windows.Forms.ListBox();
            this.performAsyncButton = new System.Windows.Forms.Button();
            this.performButton = new System.Windows.Forms.Button();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultFileErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultFileErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.avrTimeAsyncLabel);
            this.groupBox1.Controls.Add(this.avrTimeLabel);
            this.groupBox1.Controls.Add(this.timeWorkAsyncListBox);
            this.groupBox1.Controls.Add(this.timeWorkListBox);
            this.groupBox1.Controls.Add(this.performAsyncButton);
            this.groupBox1.Controls.Add(this.performButton);
            this.groupBox1.Controls.Add(this.outputFileTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputFileTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // avrTimeAsyncLabel
            // 
            this.avrTimeAsyncLabel.AutoSize = true;
            this.avrTimeAsyncLabel.Location = new System.Drawing.Point(256, 353);
            this.avrTimeAsyncLabel.Name = "avrTimeAsyncLabel";
            this.avrTimeAsyncLabel.Size = new System.Drawing.Size(109, 17);
            this.avrTimeAsyncLabel.TabIndex = 12;
            this.avrTimeAsyncLabel.Text = "Среднее время";
            // 
            // avrTimeLabel
            // 
            this.avrTimeLabel.AutoSize = true;
            this.avrTimeLabel.Location = new System.Drawing.Point(6, 353);
            this.avrTimeLabel.Name = "avrTimeLabel";
            this.avrTimeLabel.Size = new System.Drawing.Size(109, 17);
            this.avrTimeLabel.TabIndex = 11;
            this.avrTimeLabel.Text = "Среднее время";
            // 
            // timeWorkAsyncListBox
            // 
            this.timeWorkAsyncListBox.FormattingEnabled = true;
            this.timeWorkAsyncListBox.ItemHeight = 16;
            this.timeWorkAsyncListBox.Location = new System.Drawing.Point(259, 149);
            this.timeWorkAsyncListBox.Name = "timeWorkAsyncListBox";
            this.timeWorkAsyncListBox.Size = new System.Drawing.Size(225, 180);
            this.timeWorkAsyncListBox.TabIndex = 10;
            // 
            // timeWorkListBox
            // 
            this.timeWorkListBox.FormattingEnabled = true;
            this.timeWorkListBox.ItemHeight = 16;
            this.timeWorkListBox.Location = new System.Drawing.Point(6, 149);
            this.timeWorkListBox.Name = "timeWorkListBox";
            this.timeWorkListBox.Size = new System.Drawing.Size(225, 180);
            this.timeWorkListBox.TabIndex = 9;
            // 
            // performAsyncButton
            // 
            this.performAsyncButton.Location = new System.Drawing.Point(259, 392);
            this.performAsyncButton.Name = "performAsyncButton";
            this.performAsyncButton.Size = new System.Drawing.Size(225, 23);
            this.performAsyncButton.TabIndex = 8;
            this.performAsyncButton.Text = "Выполнить асинхронно";
            this.performAsyncButton.UseVisualStyleBackColor = true;
            this.performAsyncButton.Click += new System.EventHandler(this.PerformAsyncButton_Click);
            // 
            // performButton
            // 
            this.performButton.Location = new System.Drawing.Point(6, 392);
            this.performButton.Name = "performButton";
            this.performButton.Size = new System.Drawing.Size(225, 23);
            this.performButton.TabIndex = 5;
            this.performButton.Text = "Выполнить синхронно";
            this.performButton.UseVisualStyleBackColor = true;
            this.performButton.Click += new System.EventHandler(this.PerformButton_Click);
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Location = new System.Drawing.Point(259, 92);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(187, 22);
            this.outputFileTextBox.TabIndex = 3;
            this.outputFileTextBox.TextChanged += new System.EventHandler(this.outputFileTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Путь для файла с результатом";
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.Location = new System.Drawing.Point(259, 50);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.Size = new System.Drawing.Size(187, 22);
            this.inputFileTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь для файла с валютами";
            // 
            // resultFileErrorProvider
            // 
            this.resultFileErrorProvider.ContainerControl = this;
            // 
            // CurrencyRaterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 440);
            this.Controls.Add(this.groupBox1);
            this.Name = "CurrencyRaterView";
            this.Text = "CurrencyRater";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultFileErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputFileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button performButton;
        private System.Windows.Forms.Button performAsyncButton;
        private System.Windows.Forms.ListBox timeWorkListBox;
        private System.Windows.Forms.ListBox timeWorkAsyncListBox;
        private System.Windows.Forms.Label avrTimeAsyncLabel;
        private System.Windows.Forms.Label avrTimeLabel;
        private System.Windows.Forms.ErrorProvider resultFileErrorProvider;
    }
}

