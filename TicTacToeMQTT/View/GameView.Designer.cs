namespace TicTacToeMQTT.View
{
    partial class GameView
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.connectButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.gameBox = new System.Windows.Forms.TextBox();
            this.gameSquare0 = new TicTacToeMQTT.View.GameSquareView(0);
            this.gameSquare1 = new TicTacToeMQTT.View.GameSquareView(1);
            this.gameSquare2 = new TicTacToeMQTT.View.GameSquareView(2);
            this.gameSquare3 = new TicTacToeMQTT.View.GameSquareView(3);
            this.gameSquare4 = new TicTacToeMQTT.View.GameSquareView(4);
            this.gameSquare5 = new TicTacToeMQTT.View.GameSquareView(5);
            this.gameSquare6 = new TicTacToeMQTT.View.GameSquareView(6);
            this.gameSquare7 = new TicTacToeMQTT.View.GameSquareView(7);
            this.gameSquare8 = new TicTacToeMQTT.View.GameSquareView(8);
            this.statusLabel = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            this.MenuPanel.BackColor = System.Drawing.Color.Blue;
            this.MenuPanel.Controls.Add(this.statusLabel);
            this.MenuPanel.Controls.Add(this.connectButton);
            this.MenuPanel.Controls.Add(this.nameBox);
            this.MenuPanel.Controls.Add(this.gameBox);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuPanel.Location = new System.Drawing.Point(0, 487);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(485, 100);
            this.MenuPanel.TabIndex = 0;
            this.connectButton.Location = new System.Drawing.Point(215, 73);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.nameBox.Location = new System.Drawing.Point(3, 73);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 23);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "Tycho";
            this.gameBox.Location = new System.Drawing.Point(108, 73);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(100, 23);
            this.gameBox.TabIndex = 0;
            this.gameBox.Text = "game5";
            this.gameSquare0.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gameSquare0.Location = new System.Drawing.Point(12, 12);
            this.gameSquare0.Name = "gameSquare0";
            this.gameSquare0.Size = new System.Drawing.Size(150, 150);
            this.gameSquare0.TabIndex = 1;
            this.gameSquare0.UseVisualStyleBackColor = true;
            this.gameSquare1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gameSquare1.Location = new System.Drawing.Point(168, 12);
            this.gameSquare1.Name = "gameSquare1";
            this.gameSquare1.Size = new System.Drawing.Size(150, 150);
            this.gameSquare1.TabIndex = 2;
            this.gameSquare1.UseVisualStyleBackColor = true;
            this.gameSquare2.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gameSquare2.Location = new System.Drawing.Point(324, 12);
            this.gameSquare2.Name = "gameSquare2";
            this.gameSquare2.Size = new System.Drawing.Size(150, 150);
            this.gameSquare2.TabIndex = 3;
            this.gameSquare2.UseVisualStyleBackColor = true;
            this.gameSquare3.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gameSquare3.Location = new System.Drawing.Point(12, 168);
            this.gameSquare3.Name = "gameSquare3";
            this.gameSquare3.Size = new System.Drawing.Size(150, 150);
            this.gameSquare3.TabIndex = 4;
            this.gameSquare3.UseVisualStyleBackColor = true;
            this.gameSquare4.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gameSquare4.Location = new System.Drawing.Point(168, 168);
            this.gameSquare4.Name = "gameSquare4";
            this.gameSquare4.Size = new System.Drawing.Size(150, 150);
            this.gameSquare4.TabIndex = 5;
            this.gameSquare4.UseVisualStyleBackColor = true;
            this.gameSquare5.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gameSquare5.Location = new System.Drawing.Point(324, 168);
            this.gameSquare5.Name = "gameSquare5";
            this.gameSquare5.Size = new System.Drawing.Size(150, 150);
            this.gameSquare5.TabIndex = 6;
            this.gameSquare5.UseVisualStyleBackColor = true;
            this.gameSquare6.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gameSquare6.Location = new System.Drawing.Point(12, 324);
            this.gameSquare6.Name = "gameSquare6";
            this.gameSquare6.Size = new System.Drawing.Size(150, 150);
            this.gameSquare6.TabIndex = 7;
            this.gameSquare6.UseVisualStyleBackColor = true;
            this.gameSquare7.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gameSquare7.Location = new System.Drawing.Point(168, 324);
            this.gameSquare7.Name = "gameSquare7";
            this.gameSquare7.Size = new System.Drawing.Size(150, 150);
            this.gameSquare7.TabIndex = 8;
            this.gameSquare7.UseVisualStyleBackColor = true;
            this.gameSquare8.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gameSquare8.Location = new System.Drawing.Point(324, 324);
            this.gameSquare8.Name = "gameSquare8";
            this.gameSquare8.Size = new System.Drawing.Size(150, 150);
            this.gameSquare8.TabIndex = 9;
            this.gameSquare8.UseVisualStyleBackColor = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.statusLabel.Location = new System.Drawing.Point(12, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(462, 39);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Connect to server...";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 587);
            this.Controls.Add(this.gameSquare8);
            this.Controls.Add(this.gameSquare7);
            this.Controls.Add(this.gameSquare6);
            this.Controls.Add(this.gameSquare5);
            this.Controls.Add(this.gameSquare4);
            this.Controls.Add(this.gameSquare3);
            this.Controls.Add(this.gameSquare2);
            this.Controls.Add(this.gameSquare1);
            this.Controls.Add(this.gameSquare0);
            this.Controls.Add(this.MenuPanel);
            this.MaximizeBox = false;
            this.Name = "GameView";
            this.Text = "TicTacToe";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.TextBox gameBox;
        private System.Windows.Forms.TextBox nameBox;
        private TicTacToeMQTT.View.GameSquareView gameSquare0;
        private TicTacToeMQTT.View.GameSquareView gameSquare8;
        private TicTacToeMQTT.View.GameSquareView gameSquare7;
        private TicTacToeMQTT.View.GameSquareView gameSquare6;
        private TicTacToeMQTT.View.GameSquareView gameSquare5;
        private TicTacToeMQTT.View.GameSquareView gameSquare4;
        private TicTacToeMQTT.View.GameSquareView gameSquare3;
        private TicTacToeMQTT.View.GameSquareView gameSquare2;
        private TicTacToeMQTT.View.GameSquareView gameSquare1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button connectButton;
    }
}