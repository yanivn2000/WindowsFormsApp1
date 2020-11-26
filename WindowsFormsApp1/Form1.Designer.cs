
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this._background = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            _gameBoard = new GameBoard();
   
            ((System.ComponentModel.ISupportInitialize)(this._background)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // baddy1
            // 
            _gameBoard.BuildBadies();
            _gameBoard.BuildGoody();
            // gameBoard
            // 
            this._background.Image = global::WindowsFormsApp1.Properties.Resources.agario_white_background;
            this._background.Location = new System.Drawing.Point(2, 13);
            this._background.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._background.Name = "gameBoard";
            this._background.Size = new System.Drawing.Size(1557, 820);
            this._background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._background.TabIndex = 0;
            this._background.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(107, 852);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 100);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 74);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1568, 1079);
            this.Controls.Add(this.panel1);
            _gameBoard.Add(Controls);

            this.Controls.Add(this._background);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            _gameBoard.EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._background)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);




        }

#endregion

        private System.Windows.Forms.PictureBox _background;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;

        private GameBoard _gameBoard;
    }
}

