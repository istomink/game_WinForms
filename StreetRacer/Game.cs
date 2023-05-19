using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreetRacer
{
	public class PressedKey
	{
		public Keys key;
		public bool repeat;

		public PressedKey(Keys k)
		{
			key = k;
		}
	}

	public class Background
    {
		public Icon roadFragment1, roadFragment2;


    }

	public class Game
	{
		public GameForm form;

		private Image playerTexture;
		private Image roadTexture;

		public List<GameObj> objects;
		public Player player;
		//public int bestScore = 0;
		public GameState state;
		public List<PressedKey> pressedKeys;
		private Label moneyLabel;
		private Label timeLabel;
		private Font regularFont = new Font("Comic Sans MS", 14, FontStyle.Bold);
		private Brush fontBrush = new SolidBrush(Color.Black);
		string activeCarName;

		public Stopwatch stopwatch;

		private Background background;

		public Game(GameForm _gameForm, Label _timeLabel, Label _moneyLabel)
		{
			timeLabel = _timeLabel;
			moneyLabel = _moneyLabel;
			form = _gameForm;
			objects = new List<GameObj>();
			pressedKeys = new List<PressedKey>();
			CarsSpawner.InitializeSpawner();
		}
		public void StartGame(string activeCarPath, string _activeCarName)
		{
			stopwatch = new Stopwatch();
			activeCarName = _activeCarName;
			
			roadTexture = new Bitmap(form.directoryPath + "\\Resources\\road.jpg");
			playerTexture = new Bitmap(activeCarPath);
			
			player = new Player(
				playerTexture,
				new Rectangle(0, 0, playerTexture.Width, playerTexture.Height),
				new RectangleF(form.Width / 2, form.Height - 128 - 30, 80, 745f / 400f * 80f));
			objects.Add(player);

			background = new Background();
			background.roadFragment1 = new Icon(roadTexture, new Rectangle(0, 0, 167, 280), new Rectangle(0, 0, form.Width, form.Height + 20));
			background.roadFragment2 = new Icon(roadTexture, new Rectangle(0, 0, 167, 280), new Rectangle(0, -form.Height, form.Width, form.Height + 20));

			form.SpawnTimer.Interval = 1500;
			form.SpawnTimer.Tick += SpawnObject;
			
			double t = stopwatch.ElapsedMilliseconds / 1000;

			stopwatch.Start();
			form.SpawnTimer.Start();
		}
		private void SaveRecords()
		{
			string filePath = form.directoryPath + "\\Saves\\Records.txt";
			long min = stopwatch.ElapsedMilliseconds / 1000 / 60;
			long sec = stopwatch.ElapsedMilliseconds / 1000 % 60;

			if (File.Exists(filePath))
			{
				List<(string carName, int min, int sec)> temp = new List<(string, int, int)>();

				foreach (var record in File.ReadAllLines(filePath))
				{
					string[] info = record.Split('|');
					string[] time = info[1].Split(':');
					temp.Add((info[0], int.Parse(time[0]), int.Parse(time[1])));
				}
				temp.Add((activeCarName, (int)min, (int)sec));
				temp.Sort((a, b) => (b.min * 60 + b.sec).CompareTo(a.min * 60 + a.sec));

				File.WriteAllText(filePath, string.Empty);

				int j = 0;
				foreach (var r in temp)
				{
					if (j == 10)
						break;
					File.AppendAllText(filePath, $"{r.carName}|{r.min}:{r.sec}\n");
					j++;
				}
			}
			else
			{
				File.Create(filePath).Close();
				File.AppendAllText(filePath, $"{activeCarName}|{min}:{sec}\n");
			}
		}

		public void EndGame()
		{
			stopwatch.Stop();
			SaveRecords();
			player = null;
			objects.Clear();
			form.SpawnTimer.Tick -= SpawnObject;
			form.SpawnTimer.Stop();
			long min = stopwatch.ElapsedMilliseconds / 1000 / 60;
			long sec = stopwatch.ElapsedMilliseconds / 1000 % 60;
			timeLabel.Text = $"Ваше время: {min}:{sec}";
			moneyLabel.Text = $"Получено монет: {(min * 60 + sec) * 2}";

			form.playerInfo.money += (int)(min * 60 + sec) * 2;
			form.playerInfo.SavePlayerInfo();
		}
		
		private void SpawnObject(object sender, EventArgs e)
		{
			Random rand = new Random(DateTime.Now.Millisecond);

			objects.Add(CarsSpawner.SpawnCar(rand.Next((int)(150 - player.pos.Width), form.Width - 150)));
			if (form.SpawnTimer.Interval < 1000)
				objects.Add(CarsSpawner.SpawnCar(rand.Next((int)(150 - player.pos.Width), form.Width - 150)));

			if (form.SpawnTimer.Interval > 700)
				form.SpawnTimer.Interval -= 15;
		}
		
		public void Update()
		{
			if (state != GameState.Playing)
				return;

			background.roadFragment1.pos.Y += 6f;
			background.roadFragment2.pos.Y += 6f;

			if (background.roadFragment1.pos.Y >= form.Height)
				background.roadFragment1.pos.Y = -form.Height;
			if (background.roadFragment2.pos.Y >= form.Height)
				background.roadFragment2.pos.Y = -form.Height;

			for (int i = 0; i < pressedKeys.Count; i++)
				switch (pressedKeys[i].key)
				{
					case Keys.Right:
						if (player.coordX < form.Width - 150)
							player.coordX += player.movementSpeed * 0.7f;
						break;
					case Keys.Left:
						if (player.coordX > 150 - player.pos.Width)
							player.coordX -= player.movementSpeed * 0.7f;
						break;
					case Keys.Down:
						if (player.coordY < form.Height - player.pos.Height * 1.25f)
							player.coordY += player.movementSpeed * 0.4f;
						break;
					case Keys.Up:
						if (player.coordY > 0)
							player.coordY -= player.movementSpeed;
						break;
					case Keys.Escape:
						if (pressedKeys[i].repeat)
							break;
						stopwatch.Stop();
						form.SetGameState(GameState.Paused);
						pressedKeys[i].repeat = true;
						break;
				}
			for (int i = 0; i < objects.Count;)
			{
				Car cur = objects[i] as Car;
				if (cur != null)
				{
					if (cur.collider.IntersectsWith(player.pos))
					{
						Thread.Sleep(500);
						EndGame();
						form.SetGameState(GameState.GameOver);
						break;
					}
					else if (cur.pos.Y > form.Height)
                    {
						objects.RemoveAt(i);
						continue;
					}
				}
				objects[i].Update();
				i++;
			}
		}
		public void Draw(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
			e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
			if ((state == GameState.Playing) && player != null)
			{
				background.roadFragment1.Draw(sender, e);
				background.roadFragment2.Draw(sender, e);
				for (int i = 0; i < objects.Count; i++)
					objects[i].Draw(sender, e);

				long min = stopwatch.ElapsedMilliseconds / 1000 / 60;
				long sec = stopwatch.ElapsedMilliseconds / 1000 % 60;
				e.Graphics.DrawString($"Время: {min}:{sec}", regularFont, fontBrush, 15, 10);
			}
		}
	}
}