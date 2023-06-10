using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Othello
{
	public class MainForm : System.Windows.Forms.Form
	{
		public Board board;
		public System.Windows.Forms.StatusBarPanel statusBarTurn;
		public System.Windows.Forms.StatusBarPanel statusBarBlackScore;
		public System.Windows.Forms.StatusBarPanel statusBarWhiteScore;

		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem leaglMovesItem;
		private System.Windows.Forms.MenuItem newGameItem;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem humanPlayerItem;
		private System.Windows.Forms.MenuItem intermediateItem1;
		private System.Windows.Forms.MenuItem beginnerItem1;
		private System.Windows.Forms.MenuItem undoItem;
        private MenuItem menuItem2;
        private MenuItem Human_2;
        private MenuItem Ai_beginner_2;
        private MenuItem AI_intermediate_2;
        private MenuItem AdvancedItem1;
        private MenuItem AI_Advanced_2;
        private IContainer components;

        public MainForm()
		{
			InitializeComponent();

			board = new Board(this);
			board.UpdateBoardSize(ClientSize.Width, ClientSize.Height - statusBar.Height);
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.statusBarTurn = new System.Windows.Forms.StatusBarPanel();
            this.statusBarBlackScore = new System.Windows.Forms.StatusBarPanel();
            this.statusBarWhiteScore = new System.Windows.Forms.StatusBarPanel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.newGameItem = new System.Windows.Forms.MenuItem();
            this.leaglMovesItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.humanPlayerItem = new System.Windows.Forms.MenuItem();
            this.beginnerItem1 = new System.Windows.Forms.MenuItem();
            this.intermediateItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.Human_2 = new System.Windows.Forms.MenuItem();
            this.Ai_beginner_2 = new System.Windows.Forms.MenuItem();
            this.AI_intermediate_2 = new System.Windows.Forms.MenuItem();
            this.undoItem = new System.Windows.Forms.MenuItem();
            this.AdvancedItem1 = new System.Windows.Forms.MenuItem();
            this.AI_Advanced_2 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarBlackScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarWhiteScore)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 303);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarTurn,
            this.statusBarBlackScore,
            this.statusBarWhiteScore});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(515, 25);
            this.statusBar.TabIndex = 0;
            // 
            // statusBarTurn
            // 
            this.statusBarTurn.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarTurn.Name = "statusBarTurn";
            this.statusBarTurn.Text = "Turn";
            this.statusBarTurn.Width = 390;
            // 
            // statusBarBlackScore
            // 
            this.statusBarBlackScore.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarBlackScore.Name = "statusBarBlackScore";
            this.statusBarBlackScore.Text = "Black:";
            this.statusBarBlackScore.Width = 51;
            // 
            // statusBarWhiteScore
            // 
            this.statusBarWhiteScore.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarWhiteScore.Name = "statusBarWhiteScore";
            this.statusBarWhiteScore.Text = "White:";
            this.statusBarWhiteScore.Width = 53;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.newGameItem,
            this.leaglMovesItem,
            this.menuItem1,
            this.menuItem2,
            this.undoItem});
            // 
            // newGameItem
            // 
            this.newGameItem.Index = 0;
            this.newGameItem.Text = "&New Game";
            this.newGameItem.Click += new System.EventHandler(this.newGameItem_Click);
            // 
            // leaglMovesItem
            // 
            this.leaglMovesItem.Index = 1;
            this.leaglMovesItem.Text = "Show Legal &Moves";
            this.leaglMovesItem.Click += new System.EventHandler(this.leaglMovesItem_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.humanPlayerItem,
            this.beginnerItem1,
            this.intermediateItem1,
            this.AdvancedItem1});
            this.menuItem1.Text = "&White Player";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // humanPlayerItem
            // 
            this.humanPlayerItem.Checked = true;
            this.humanPlayerItem.Index = 0;
            this.humanPlayerItem.Text = "&Human";
            this.humanPlayerItem.Click += new System.EventHandler(this.humanPlayerItem_Click);
            // 
            // beginnerItem1
            // 
            this.beginnerItem1.Index = 1;
            this.beginnerItem1.Text = "&AI - Beginner";
            this.beginnerItem1.Click += new System.EventHandler(this.beginerItem_Click);
            // 
            // intermediateItem1
            // 
            this.intermediateItem1.Index = 2;
            this.intermediateItem1.Text = "&AI - Intermediate";
            this.intermediateItem1.Click += new System.EventHandler(this.intermediateItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Human_2,
            this.Ai_beginner_2,
            this.AI_intermediate_2,
            this.AI_Advanced_2});
            this.menuItem2.Text = "&Black Player";
            // 
            // Human_2
            // 
            this.Human_2.Index = 0;
            this.Human_2.Text = "&Human";
            this.Human_2.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // Ai_beginner_2
            // 
            this.Ai_beginner_2.Index = 1;
            this.Ai_beginner_2.Text = "&AI - Beginner";
            this.Ai_beginner_2.Click += new System.EventHandler(this.Ai_beginner_2_Click);
            // 
            // AI_intermediate_2
            // 
            this.AI_intermediate_2.Index = 2;
            this.AI_intermediate_2.Text = "&AI - Intermediate";
            this.AI_intermediate_2.Click += new System.EventHandler(this.AI_intermediate_2_Click);
            // 
            // undoItem
            // 
            this.undoItem.Index = 4;
            this.undoItem.Text = "&Undo";
            this.undoItem.Click += new System.EventHandler(this.undoItem_Click);
            // 
            // AdvancedItem1
            // 
            this.AdvancedItem1.Index = 3;
            this.AdvancedItem1.Text = "&AI - Advanced";
            this.AdvancedItem1.Click += new System.EventHandler(this.AdvancedItem1_Click);
            // 
            // AI_Advanced_2
            // 
            this.AI_Advanced_2.Index = 3;
            this.AI_Advanced_2.Text = "&Ai - Advanced";
            this.AI_Advanced_2.Click += new System.EventHandler(this.AI_Advanced_2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(515, 328);
            this.Controls.Add(this.statusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "Othello";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.Resize += new System.EventHandler(this.OnResize);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarBlackScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarWhiteScore)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			board.Draw(e.Graphics);
		}

		private void OnResize(object sender, System.EventArgs e)
		{
			board.UpdateBoardSize(ClientSize.Width, ClientSize.Height - statusBar.Height);
			Invalidate();
		}

		private void MainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			board.Click(e);
			statusBar.Invalidate();
		}

		private void leaglMovesItem_Click(object sender, System.EventArgs e)
		{
			board.ShowLegalMoves();
			Invalidate();
		}

		private void newGameItem_Click(object sender, System.EventArgs e)
		{
            board.ComputerPlayer = null;
            board.ComputerPlayer_black = null;
            board.WhitesTurn = false;
            board.cancelFlipping = false;
            board.flipDelay = 50;
            board.previousWhitesTurn = false;

            humanPlayerItem.Checked = true;
            beginnerItem1.Checked = false;
            intermediateItem1.Checked = false;
            AdvancedItem1.Checked = false;

            Human_2.Checked = true;
            Ai_beginner_2.Checked = false;
            AI_intermediate_2.Checked = false;
            AI_Advanced_2.Checked = false;

            board.NewGame();
			Invalidate();
		}

		private void beginerItem_Click(object sender, System.EventArgs e)
		{
			board.ComputerPlayer = new ComputerPlayer();
			board.ComputerPlayer.Level = LevelEnum.Beginner;
			board.ComputerPlayer.AmIWhite = true;
			board.ComputerPlayer.Board = board;

			humanPlayerItem.Checked = false;
			beginnerItem1.Checked = true;
			intermediateItem1.Checked = false;
            AdvancedItem1.Checked = false;

            board.NewGame();
			Invalidate();
		}

		private void intermediateItem_Click(object sender, System.EventArgs e)
		{
			board.ComputerPlayer = new ComputerPlayer();
			board.ComputerPlayer.Level = LevelEnum.Intermediate;
			board.ComputerPlayer.AmIWhite = true;
			board.ComputerPlayer.Board = board;

			humanPlayerItem.Checked = false;
			beginnerItem1.Checked = false;
			intermediateItem1.Checked = true;
            AdvancedItem1.Checked = false;

            board.NewGame();
			Invalidate();
		}

		private void humanPlayerItem_Click(object sender, System.EventArgs e)
		{
			board.ComputerPlayer = null;

            humanPlayerItem.Checked = true;
			beginnerItem1.Checked = false;
			intermediateItem1.Checked = false;
            AdvancedItem1.Checked = false;

            board.NewGame();
            Invalidate();
        }

		private void undoItem_Click(object sender, System.EventArgs e)
		{
			board.Undo();
			Invalidate();
		}

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuItem3_Click(object sender, EventArgs e) //human_2 black
        {
            board.ComputerPlayer_black = null;

            Human_2.Checked = true;
            Ai_beginner_2.Checked = false;
            AI_intermediate_2.Checked = false;
            AI_Advanced_2.Checked = false;

            board.NewGame();
            Invalidate();

        }

        private void Ai_beginner_2_Click(object sender, EventArgs e)
        {
            board.ComputerPlayer_black = new ComputerPlayer();
            board.ComputerPlayer_black.Level = LevelEnum.Beginner;
            board.ComputerPlayer_black.AmIWhite = false;
            board.ComputerPlayer_black.Board = board;

            Human_2.Checked = false;
            Ai_beginner_2.Checked = true;
            AI_intermediate_2.Checked = false;
            AI_Advanced_2.Checked = false;

            board.NewGame();
            Invalidate();

        }

        private void AI_intermediate_2_Click(object sender, EventArgs e)
        {
            board.ComputerPlayer_black = new ComputerPlayer();
            board.ComputerPlayer_black.Level = LevelEnum.Intermediate;
            board.ComputerPlayer_black.AmIWhite = false;
            board.ComputerPlayer_black.Board = board;

            Human_2.Checked = false;
            Ai_beginner_2.Checked = false;
            AI_intermediate_2.Checked = true;
            AI_Advanced_2.Checked = false;

            board.NewGame();
            Invalidate();
        }

        private void AdvancedItem1_Click(object sender, EventArgs e) // white advanced
        {
            board.ComputerPlayer = new ComputerPlayer();
            board.ComputerPlayer.Level = LevelEnum.Advanced;
            board.ComputerPlayer.AmIWhite = true;
            board.ComputerPlayer.Board = board;

            humanPlayerItem.Checked = false;
            beginnerItem1.Checked = false;
            intermediateItem1.Checked = false;
            AdvancedItem1.Checked = true;

            board.NewGame();
            Invalidate();

        }

        private void AI_Advanced_2_Click(object sender, EventArgs e) // Black advanced
        {
            board.ComputerPlayer_black = new ComputerPlayer();
            board.ComputerPlayer_black.Level = LevelEnum.Advanced;
            board.ComputerPlayer_black.AmIWhite = false;
            board.ComputerPlayer_black.Board = board;

            Human_2.Checked = false;
            Ai_beginner_2.Checked = false;
            AI_intermediate_2.Checked = false;
            AI_Advanced_2.Checked = true;

            board.NewGame();
            Invalidate();
        }
    }
}
