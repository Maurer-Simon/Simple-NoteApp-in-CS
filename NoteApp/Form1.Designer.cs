namespace NoteApp
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
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            txtMsg = new TextBox();
            dataGridView1 = new DataGridView();
            newMsg = new Button();
            saveMsg = new Button();
            readMsg = new Button();
            deleteMsg = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 52);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 92);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Message";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(96, 49);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(153, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtMsg
            // 
            txtMsg.Location = new Point(96, 89);
            txtMsg.Multiline = true;
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(350, 200);
            txtMsg.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(482, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(200, 200);
            dataGridView1.TabIndex = 4;
            // 
            // newMsg
            // 
            newMsg.Location = new Point(96, 295);
            newMsg.Name = "newMsg";
            newMsg.Size = new Size(75, 23);
            newMsg.TabIndex = 5;
            newMsg.Text = "New";
            newMsg.UseVisualStyleBackColor = true;
            newMsg.Click += button1_Click;
            // 
            // saveMsg
            // 
            saveMsg.Location = new Point(177, 295);
            saveMsg.Name = "saveMsg";
            saveMsg.Size = new Size(75, 23);
            saveMsg.TabIndex = 6;
            saveMsg.Text = "Save";
            saveMsg.UseVisualStyleBackColor = true;
            saveMsg.Click += saveMsg_Click;
            // 
            // readMsg
            // 
            readMsg.Location = new Point(482, 295);
            readMsg.Name = "readMsg";
            readMsg.Size = new Size(75, 23);
            readMsg.TabIndex = 7;
            readMsg.Text = "Read";
            readMsg.UseVisualStyleBackColor = true;
            readMsg.Click += readMsg_Click;
            // 
            // deleteMsg
            // 
            deleteMsg.Location = new Point(563, 295);
            deleteMsg.Name = "deleteMsg";
            deleteMsg.Size = new Size(75, 23);
            deleteMsg.TabIndex = 8;
            deleteMsg.Text = "Delete";
            deleteMsg.UseVisualStyleBackColor = true;
            deleteMsg.Click += deleteMsg_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 343);
            Controls.Add(deleteMsg);
            Controls.Add(readMsg);
            Controls.Add(saveMsg);
            Controls.Add(newMsg);
            Controls.Add(dataGridView1);
            Controls.Add(txtMsg);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtMsg;
        private DataGridView dataGridView1;
        private Button newMsg;
        private Button saveMsg;
        private Button readMsg;
        private Button deleteMsg;
    }
}