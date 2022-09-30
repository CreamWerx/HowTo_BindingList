namespace HowTo_BindingList
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
            this.listBoxToBindTo = new System.Windows.Forms.CheckedListBox();
            this.buttonBind = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.textBoxInt = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.labelListBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxToBindTo
            // 
            this.listBoxToBindTo.FormattingEnabled = true;
            this.listBoxToBindTo.Location = new System.Drawing.Point(113, 12);
            this.listBoxToBindTo.Name = "listBoxToBindTo";
            this.listBoxToBindTo.Size = new System.Drawing.Size(298, 349);
            this.listBoxToBindTo.TabIndex = 0;
            // 
            // buttonBind
            // 
            this.buttonBind.Location = new System.Drawing.Point(12, 12);
            this.buttonBind.Name = "buttonBind";
            this.buttonBind.Size = new System.Drawing.Size(75, 23);
            this.buttonBind.TabIndex = 1;
            this.buttonBind.Text = "Bind";
            this.buttonBind.UseVisualStyleBackColor = true;
            this.buttonBind.Click += new System.EventHandler(this.buttonBind_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(445, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(547, 12);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(100, 20);
            this.textBoxString.TabIndex = 3;
            // 
            // textBoxInt
            // 
            this.textBoxInt.Location = new System.Drawing.Point(668, 12);
            this.textBoxInt.Name = "textBoxInt";
            this.textBoxInt.Size = new System.Drawing.Size(47, 20);
            this.textBoxInt.TabIndex = 4;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(445, 56);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelList.Location = new System.Drawing.Point(445, 347);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(117, 20);
            this.labelList.TabIndex = 6;
            this.labelList.Text = "Items in List :";
            // 
            // labelListBox
            // 
            this.labelListBox.AutoSize = true;
            this.labelListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListBox.Location = new System.Drawing.Point(584, 347);
            this.labelListBox.Name = "labelListBox";
            this.labelListBox.Size = new System.Drawing.Size(147, 20);
            this.labelListBox.TabIndex = 7;
            this.labelListBox.Text = "Items in ListBox :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 372);
            this.Controls.Add(this.labelListBox);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxInt);
            this.Controls.Add(this.textBoxString);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBind);
            this.Controls.Add(this.listBoxToBindTo);
            this.Name = "Form1";
            this.Text = "Simple BindingList example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listBoxToBindTo;
        private System.Windows.Forms.Button buttonBind;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.TextBox textBoxInt;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label labelListBox;
    }
}

