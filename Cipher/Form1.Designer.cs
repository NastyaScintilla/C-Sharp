namespace ib_lab
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
            this.input_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.method = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encrypted_text = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.keylabel = new System.Windows.Forms.Label();
            this.ab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методПростойПодстановкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методБлочнойПерестановкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методЦезаряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методXORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_text
            // 
            this.input_text.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_text.Location = new System.Drawing.Point(514, 48);
            this.input_text.Multiline = true;
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(267, 114);
            this.input_text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Входящий текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Исходный алфавит:";
            // 
            // key
            // 
            this.key.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key.Location = new System.Drawing.Point(12, 142);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(300, 20);
            this.key.TabIndex = 3;
            // 
            // method
            // 
            this.method.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.method.FormattingEnabled = true;
            this.method.Items.AddRange(new object[] {
            "Простая подстановка",
            "Блочная перестановка",
            "Шифр Цезаря",
            "XOR"});
            this.method.Location = new System.Drawing.Point(12, 92);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(300, 22);
            this.method.TabIndex = 4;
            this.method.SelectedIndexChanged += new System.EventHandler(this.method_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Алгоритм шифрования:";
            // 
            // encrypted_text
            // 
            this.encrypted_text.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrypted_text.Location = new System.Drawing.Point(514, 181);
            this.encrypted_text.Multiline = true;
            this.encrypted_text.Name = "encrypted_text";
            this.encrypted_text.Size = new System.Drawing.Size(267, 140);
            this.encrypted_text.TabIndex = 6;
            // 
            // encrypt
            // 
            this.encrypt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrypt.Location = new System.Drawing.Point(6, 217);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(204, 103);
            this.encrypt.TabIndex = 7;
            this.encrypt.Text = "Зашифровать";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(230, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 104);
            this.button2.TabIndex = 8;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // keylabel
            // 
            this.keylabel.AutoSize = true;
            this.keylabel.Location = new System.Drawing.Point(12, 126);
            this.keylabel.Name = "keylabel";
            this.keylabel.Size = new System.Drawing.Size(36, 13);
            this.keylabel.TabIndex = 11;
            this.keylabel.Text = "Ключ:";
            // 
            // ab
            // 
            this.ab.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ab.Location = new System.Drawing.Point(6, 48);
            this.ab.Name = "ab";
            this.ab.Size = new System.Drawing.Size(300, 20);
            this.ab.TabIndex = 12;
            this.ab.Text = "абвгдежзиклмнопрстуфхцчшщъыьэюя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(511, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Зашифрованный текст:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методПростойПодстановкиToolStripMenuItem,
            this.методБлочнойПерестановкиToolStripMenuItem,
            this.методЦезаряToolStripMenuItem,
            this.методXORToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // методПростойПодстановкиToolStripMenuItem
            // 
            this.методПростойПодстановкиToolStripMenuItem.Name = "методПростойПодстановкиToolStripMenuItem";
            this.методПростойПодстановкиToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.методПростойПодстановкиToolStripMenuItem.Text = "Метод простой подстановки";
            this.методПростойПодстановкиToolStripMenuItem.Click += new System.EventHandler(this.методПростойПодстановкиToolStripMenuItem_Click);
            // 
            // методБлочнойПерестановкиToolStripMenuItem
            // 
            this.методБлочнойПерестановкиToolStripMenuItem.Name = "методБлочнойПерестановкиToolStripMenuItem";
            this.методБлочнойПерестановкиToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.методБлочнойПерестановкиToolStripMenuItem.Text = "Метод блочной перестановки";
            this.методБлочнойПерестановкиToolStripMenuItem.Click += new System.EventHandler(this.методБлочнойПерестановкиToolStripMenuItem_Click);
            // 
            // методЦезаряToolStripMenuItem
            // 
            this.методЦезаряToolStripMenuItem.Name = "методЦезаряToolStripMenuItem";
            this.методЦезаряToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.методЦезаряToolStripMenuItem.Text = "Метод Цезаря";
            this.методЦезаряToolStripMenuItem.Click += new System.EventHandler(this.методЦезаряToolStripMenuItem_Click);
            // 
            // методXORToolStripMenuItem
            // 
            this.методXORToolStripMenuItem.Name = "методXORToolStripMenuItem";
            this.методXORToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.методXORToolStripMenuItem.Text = "Метод XOR";
            this.методXORToolStripMenuItem.Click += new System.EventHandler(this.методXORToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(793, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ab);
            this.Controls.Add(this.keylabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.encrypted_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.method);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_text);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ШВП";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.ComboBox method;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encrypted_text;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label keylabel;
        private System.Windows.Forms.TextBox ab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методПростойПодстановкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методБлочнойПерестановкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методЦезаряToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методXORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

