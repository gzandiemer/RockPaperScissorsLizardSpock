namespace RockPaperScissorsLizardSpock
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
            this.btn_rock = new System.Windows.Forms.Button();
            this.btn_paper = new System.Windows.Forms.Button();
            this.btn_scissors = new System.Windows.Forms.Button();
            this.btn_lizard = new System.Windows.Forms.Button();
            this.btn_spock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_scoreboard = new System.Windows.Forms.Label();
            this.label_Score1 = new System.Windows.Forms.Label();
            this.lbl_humScore = new System.Windows.Forms.Label();
            this.label_Score2 = new System.Windows.Forms.Label();
            this.lbl_comScore = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.Panel_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.panel_computer = new System.Windows.Forms.Panel();
            this.pictureBox_Qmark = new System.Windows.Forms.PictureBox();
            this.pictureBox_comProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox_comMove = new System.Windows.Forms.PictureBox();
            this.panel_human = new System.Windows.Forms.Panel();
            this.pictureBox_Comics = new System.Windows.Forms.PictureBox();
            this.pictureBox_humProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox_humMove = new System.Windows.Forms.PictureBox();
            this.panel_poster = new System.Windows.Forms.Panel();
            this.pictureBox_poster = new System.Windows.Forms.PictureBox();
            this.lbl_GameName = new System.Windows.Forms.Label();
            this.Panel_buttons.SuspendLayout();
            this.panel_computer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Qmark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_comProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_comMove)).BeginInit();
            this.panel_human.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Comics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_humProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_humMove)).BeginInit();
            this.panel_poster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_poster)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rock
            // 
            this.btn_rock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rock.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_rock.Font = new System.Drawing.Font("Poor Richard", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_rock.Location = new System.Drawing.Point(13, 7);
            this.btn_rock.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rock.Name = "btn_rock";
            this.btn_rock.Size = new System.Drawing.Size(80, 39);
            this.btn_rock.TabIndex = 0;
            this.btn_rock.Text = "rock";
            this.btn_rock.UseVisualStyleBackColor = false;
            this.btn_rock.Click += new System.EventHandler(this.btn_rock_Click);
            // 
            // btn_paper
            // 
            this.btn_paper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_paper.BackColor = System.Drawing.Color.Salmon;
            this.btn_paper.Font = new System.Drawing.Font("Poor Richard", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paper.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_paper.Location = new System.Drawing.Point(119, 7);
            this.btn_paper.Margin = new System.Windows.Forms.Padding(2);
            this.btn_paper.Name = "btn_paper";
            this.btn_paper.Size = new System.Drawing.Size(80, 39);
            this.btn_paper.TabIndex = 1;
            this.btn_paper.Text = "paper";
            this.btn_paper.UseVisualStyleBackColor = false;
            this.btn_paper.Click += new System.EventHandler(this.btn_paper_Click);
            // 
            // btn_scissors
            // 
            this.btn_scissors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_scissors.BackColor = System.Drawing.Color.Indigo;
            this.btn_scissors.Font = new System.Drawing.Font("Poor Richard", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scissors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_scissors.Location = new System.Drawing.Point(225, 7);
            this.btn_scissors.Margin = new System.Windows.Forms.Padding(2);
            this.btn_scissors.Name = "btn_scissors";
            this.btn_scissors.Size = new System.Drawing.Size(80, 39);
            this.btn_scissors.TabIndex = 2;
            this.btn_scissors.Text = "scissors";
            this.btn_scissors.UseVisualStyleBackColor = false;
            this.btn_scissors.Click += new System.EventHandler(this.btn_scissors_Click);
            // 
            // btn_lizard
            // 
            this.btn_lizard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lizard.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_lizard.Font = new System.Drawing.Font("Poor Richard", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lizard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_lizard.Location = new System.Drawing.Point(331, 7);
            this.btn_lizard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_lizard.Name = "btn_lizard";
            this.btn_lizard.Size = new System.Drawing.Size(80, 39);
            this.btn_lizard.TabIndex = 3;
            this.btn_lizard.Text = "lizard";
            this.btn_lizard.UseVisualStyleBackColor = false;
            this.btn_lizard.Click += new System.EventHandler(this.btn_lizard_Click);
            // 
            // btn_spock
            // 
            this.btn_spock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_spock.BackColor = System.Drawing.Color.Navy;
            this.btn_spock.Font = new System.Drawing.Font("Poor Richard", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_spock.Location = new System.Drawing.Point(439, 7);
            this.btn_spock.Margin = new System.Windows.Forms.Padding(2);
            this.btn_spock.Name = "btn_spock";
            this.btn_spock.Size = new System.Drawing.Size(80, 39);
            this.btn_spock.TabIndex = 4;
            this.btn_spock.Text = "spock";
            this.btn_spock.UseVisualStyleBackColor = false;
            this.btn_spock.Click += new System.EventHandler(this.btn_spock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "human";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "computer";
            // 
            // lbl_scoreboard
            // 
            this.lbl_scoreboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_scoreboard.BackColor = System.Drawing.Color.Transparent;
            this.lbl_scoreboard.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreboard.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_scoreboard.Location = new System.Drawing.Point(504, 514);
            this.lbl_scoreboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_scoreboard.Name = "lbl_scoreboard";
            this.lbl_scoreboard.Size = new System.Drawing.Size(467, 60);
            this.lbl_scoreboard.TabIndex = 10;
            this.lbl_scoreboard.Text = "Challenge yourself!";
            this.lbl_scoreboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Score1
            // 
            this.label_Score1.AutoSize = true;
            this.label_Score1.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score1.Location = new System.Drawing.Point(66, 315);
            this.label_Score1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Score1.Name = "label_Score1";
            this.label_Score1.Size = new System.Drawing.Size(74, 22);
            this.label_Score1.TabIndex = 11;
            this.label_Score1.Text = "Score:";
            // 
            // lbl_humScore
            // 
            this.lbl_humScore.AutoSize = true;
            this.lbl_humScore.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_humScore.Location = new System.Drawing.Point(143, 315);
            this.lbl_humScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_humScore.Name = "lbl_humScore";
            this.lbl_humScore.Size = new System.Drawing.Size(21, 22);
            this.lbl_humScore.TabIndex = 12;
            this.lbl_humScore.Text = "0";
            // 
            // label_Score2
            // 
            this.label_Score2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Score2.AutoSize = true;
            this.label_Score2.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score2.Location = new System.Drawing.Point(76, 315);
            this.label_Score2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Score2.Name = "label_Score2";
            this.label_Score2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Score2.Size = new System.Drawing.Size(74, 22);
            this.label_Score2.TabIndex = 13;
            this.label_Score2.Text = "Score:";
            this.label_Score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_comScore
            // 
            this.lbl_comScore.AutoSize = true;
            this.lbl_comScore.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comScore.Location = new System.Drawing.Point(153, 315);
            this.lbl_comScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_comScore.Name = "lbl_comScore";
            this.lbl_comScore.Size = new System.Drawing.Size(21, 22);
            this.lbl_comScore.TabIndex = 14;
            this.lbl_comScore.Text = "0";
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_reset.BackColor = System.Drawing.Color.Azure;
            this.btn_reset.Font = new System.Drawing.Font("Poor Richard", 20F);
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_reset.Location = new System.Drawing.Point(684, 553);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(101, 51);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Visible = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Panel_buttons
            // 
            this.Panel_buttons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Panel_buttons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_buttons.ColumnCount = 5;
            this.Panel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel_buttons.Controls.Add(this.btn_scissors, 2, 0);
            this.Panel_buttons.Controls.Add(this.btn_spock, 4, 0);
            this.Panel_buttons.Controls.Add(this.btn_rock, 0, 0);
            this.Panel_buttons.Controls.Add(this.btn_lizard, 3, 0);
            this.Panel_buttons.Controls.Add(this.btn_paper, 1, 0);
            this.Panel_buttons.Location = new System.Drawing.Point(470, 601);
            this.Panel_buttons.Name = "Panel_buttons";
            this.Panel_buttons.RowCount = 1;
            this.Panel_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.Panel_buttons.Size = new System.Drawing.Size(534, 53);
            this.Panel_buttons.TabIndex = 18;
            // 
            // panel_computer
            // 
            this.panel_computer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel_computer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_computer.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel_computer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_computer.Controls.Add(this.pictureBox_Qmark);
            this.panel_computer.Controls.Add(this.pictureBox_comProfile);
            this.panel_computer.Controls.Add(this.label2);
            this.panel_computer.Controls.Add(this.pictureBox_comMove);
            this.panel_computer.Controls.Add(this.label_Score2);
            this.panel_computer.Controls.Add(this.lbl_comScore);
            this.panel_computer.Location = new System.Drawing.Point(1139, 149);
            this.panel_computer.Name = "panel_computer";
            this.panel_computer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_computer.Size = new System.Drawing.Size(268, 391);
            this.panel_computer.TabIndex = 20;
            // 
            // pictureBox_Qmark
            // 
            this.pictureBox_Qmark.Image = global::RockPaperScissorsLizardSpock.Properties.Resources.question_mark;
            this.pictureBox_Qmark.Location = new System.Drawing.Point(36, 115);
            this.pictureBox_Qmark.Name = "pictureBox_Qmark";
            this.pictureBox_Qmark.Size = new System.Drawing.Size(200, 195);
            this.pictureBox_Qmark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Qmark.TabIndex = 17;
            this.pictureBox_Qmark.TabStop = false;
            // 
            // pictureBox_comProfile
            // 
            this.pictureBox_comProfile.Image = global::RockPaperScissorsLizardSpock.Properties.Resources.H_algorithm;
            this.pictureBox_comProfile.Location = new System.Drawing.Point(187, 11);
            this.pictureBox_comProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_comProfile.Name = "pictureBox_comProfile";
            this.pictureBox_comProfile.Size = new System.Drawing.Size(60, 58);
            this.pictureBox_comProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_comProfile.TabIndex = 16;
            this.pictureBox_comProfile.TabStop = false;
            // 
            // pictureBox_comMove
            // 
            this.pictureBox_comMove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_comMove.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox_comMove.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox_comMove.ErrorImage = global::RockPaperScissorsLizardSpock.Properties.Resources.H_spock;
            this.pictureBox_comMove.Location = new System.Drawing.Point(36, 115);
            this.pictureBox_comMove.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_comMove.Name = "pictureBox_comMove";
            this.pictureBox_comMove.Size = new System.Drawing.Size(200, 195);
            this.pictureBox_comMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_comMove.TabIndex = 7;
            this.pictureBox_comMove.TabStop = false;
            // 
            // panel_human
            // 
            this.panel_human.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_human.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_human.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel_human.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_human.Controls.Add(this.pictureBox_Comics);
            this.panel_human.Controls.Add(this.pictureBox_humProfile);
            this.panel_human.Controls.Add(this.label1);
            this.panel_human.Controls.Add(this.pictureBox_humMove);
            this.panel_human.Controls.Add(this.label_Score1);
            this.panel_human.Controls.Add(this.lbl_humScore);
            this.panel_human.Location = new System.Drawing.Point(57, 162);
            this.panel_human.Name = "panel_human";
            this.panel_human.Size = new System.Drawing.Size(268, 391);
            this.panel_human.TabIndex = 20;
            // 
            // pictureBox_Comics
            // 
            this.pictureBox_Comics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_Comics.Image = global::RockPaperScissorsLizardSpock.Properties.Resources.Rock_Paper_Scissors;
            this.pictureBox_Comics.Location = new System.Drawing.Point(29, 102);
            this.pictureBox_Comics.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Comics.Name = "pictureBox_Comics";
            this.pictureBox_Comics.Size = new System.Drawing.Size(200, 195);
            this.pictureBox_Comics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Comics.TabIndex = 22;
            this.pictureBox_Comics.TabStop = false;
            // 
            // pictureBox_humProfile
            // 
            this.pictureBox_humProfile.Image = global::RockPaperScissorsLizardSpock.Properties.Resources.H_brain;
            this.pictureBox_humProfile.Location = new System.Drawing.Point(12, 11);
            this.pictureBox_humProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_humProfile.Name = "pictureBox_humProfile";
            this.pictureBox_humProfile.Size = new System.Drawing.Size(60, 58);
            this.pictureBox_humProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_humProfile.TabIndex = 15;
            this.pictureBox_humProfile.TabStop = false;
            // 
            // pictureBox_humMove
            // 
            this.pictureBox_humMove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_humMove.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox_humMove.ErrorImage = global::RockPaperScissorsLizardSpock.Properties.Resources.H_spock;
            this.pictureBox_humMove.Location = new System.Drawing.Point(29, 102);
            this.pictureBox_humMove.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_humMove.Name = "pictureBox_humMove";
            this.pictureBox_humMove.Size = new System.Drawing.Size(200, 195);
            this.pictureBox_humMove.TabIndex = 5;
            this.pictureBox_humMove.TabStop = false;
            // 
            // panel_poster
            // 
            this.panel_poster.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_poster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_poster.BackColor = System.Drawing.Color.Transparent;
            this.panel_poster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_poster.Controls.Add(this.pictureBox_poster);
            this.panel_poster.Controls.Add(this.lbl_GameName);
            this.panel_poster.Location = new System.Drawing.Point(470, 12);
            this.panel_poster.Name = "panel_poster";
            this.panel_poster.Size = new System.Drawing.Size(534, 515);
            this.panel_poster.TabIndex = 21;
            // 
            // pictureBox_poster
            // 
            this.pictureBox_poster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_poster.ErrorImage = global::RockPaperScissorsLizardSpock.Properties.Resources.H_poster;
            this.pictureBox_poster.Image = global::RockPaperScissorsLizardSpock.Properties.Resources.H_poster;
            this.pictureBox_poster.InitialImage = global::RockPaperScissorsLizardSpock.Properties.Resources.H_poster;
            this.pictureBox_poster.Location = new System.Drawing.Point(18, 41);
            this.pictureBox_poster.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_poster.Name = "pictureBox_poster";
            this.pictureBox_poster.Size = new System.Drawing.Size(494, 459);
            this.pictureBox_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_poster.TabIndex = 6;
            this.pictureBox_poster.TabStop = false;
            // 
            // lbl_GameName
            // 
            this.lbl_GameName.AutoSize = true;
            this.lbl_GameName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_GameName.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_GameName.Location = new System.Drawing.Point(86, 9);
            this.lbl_GameName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GameName.Name = "lbl_GameName";
            this.lbl_GameName.Size = new System.Drawing.Size(342, 30);
            this.lbl_GameName.TabIndex = 7;
            this.lbl_GameName.Text = "Rock-Paper-Scissors-Lizard-Spock  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1474, 678);
            this.Controls.Add(this.panel_poster);
            this.Controls.Add(this.panel_computer);
            this.Controls.Add(this.lbl_scoreboard);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.panel_human);
            this.Controls.Add(this.Panel_buttons);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rock-Paper-Scissors-Lizard-Spock  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Panel_buttons.ResumeLayout(false);
            this.panel_computer.ResumeLayout(false);
            this.panel_computer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Qmark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_comProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_comMove)).EndInit();
            this.panel_human.ResumeLayout(false);
            this.panel_human.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Comics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_humProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_humMove)).EndInit();
            this.panel_poster.ResumeLayout(false);
            this.panel_poster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_poster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_rock;
        private System.Windows.Forms.Button btn_paper;
        private System.Windows.Forms.Button btn_scissors;
        private System.Windows.Forms.Button btn_lizard;
        private System.Windows.Forms.Button btn_spock;
        private System.Windows.Forms.PictureBox pictureBox_humMove;
        private System.Windows.Forms.PictureBox pictureBox_poster;
        private System.Windows.Forms.PictureBox pictureBox_comMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_scoreboard;
        private System.Windows.Forms.Label label_Score1;
        private System.Windows.Forms.Label lbl_humScore;
        private System.Windows.Forms.Label label_Score2;
        private System.Windows.Forms.Label lbl_comScore;
        private System.Windows.Forms.PictureBox pictureBox_humProfile;
        private System.Windows.Forms.PictureBox pictureBox_comProfile;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TableLayoutPanel Panel_buttons;
        private System.Windows.Forms.Panel panel_computer;
        private System.Windows.Forms.Panel panel_human;
        private System.Windows.Forms.Panel panel_poster;
        private System.Windows.Forms.Label lbl_GameName;
        private System.Windows.Forms.PictureBox pictureBox_Comics;
        private System.Windows.Forms.PictureBox pictureBox_Qmark;
    }
}

