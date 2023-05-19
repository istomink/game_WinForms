using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreetRacer
{
	public enum GameState
	{
		MainMenu,
		Shopping,
		Records,
		Playing,
		Paused,
		GameOver
	}
	
	public partial class GameForm : Form
	{
		public Game game;
		public string directoryPath;

		private class CarInfo
		{
			public string name;
			public int price;
			public string ShopImageFilepath;
			public string GameImageFilePath;
		}

		public class PlayerInfo
		{
			public int money;
			public string activeCar;
			private List<string> boughtCars;
			public PlayerInfo(int _money, string _activeCar, List<string> _boughtCars)
			{
				money = _money;
				activeCar = _activeCar;
				boughtCars = _boughtCars;
			}

			public string CheckCar(string carName)
			{
				if (carName == activeCar)
					return "Выбрано";
				else if (boughtCars.Contains(carName))
					return "Выбрать";
				else
					return "Купить";
			}
			
			public void AddBoughtCar(string carName, int carPrice)
            {
				money -= carPrice;
				boughtCars.Add(carName);
            }
			public void SavePlayerInfo()
            {
				string filePath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Saves\\PlayerInfo.txt";
				string[] info = new string[3];
				info[0] = money.ToString();
				info[1] = activeCar;
				int k = 0;
				foreach (var i in boughtCars)
				{
					if (k != boughtCars.Count - 1)
						info[2] += i + "|";
					else
						info[2] += i;
					k++;
				}
				File.WriteAllLines(filePath, info);
			}
        }

		private List<CarInfo> cars;
		private int currentCarInShop;
		public PlayerInfo playerInfo;

		public GameForm()
		{
			InitializeComponent();
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			directoryPath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

			game = new Game(this, GameOverLabel2, MoneyLabel);
			SetGameState(GameState.MainMenu);

			for (int i = 0; i < 10; i++)
			{
				RecordPanel.Controls.Find("RecordsLabel" + i, false)[0].Text = "";
				RecordPanel.Controls.Find("RecordsLabel" + i, false)[0].Hide();
			}

			// Получение информации о цен машин
			string carsPricefilePath = directoryPath + "\\Saves\\CarsPrice.txt";
			List<(string name, int price)> carNameAndPrice = new List<(string name, int price)>();
			string[] temp = File.ReadAllLines(carsPricefilePath);
			foreach (var s in temp)
			{
				string[] carRecord = s.Split('|');
				carNameAndPrice.Add((carRecord[0], int.Parse(carRecord[1])));
			}

			// Получение путей до картинок с машинами
			string carsImagesfilePath = directoryPath + "\\Resources\\Cars";
			string[] files = Directory.GetFiles(carsImagesfilePath);
			cars = new List<CarInfo>();
			foreach (var s in files)
			{
				if (s.IndexOf("Game") == -1)
				{
					cars.Add(new CarInfo());
					cars.Last().name = s.Replace(carsImagesfilePath + "\\", "").Replace(".png", "");
					cars.Last().price = carNameAndPrice.Find(a => a.name == cars.Last().name).price;
					cars.Last().ShopImageFilepath = s;
					cars.Last().GameImageFilePath = carsImagesfilePath + "\\" + cars.Last().name + "Game.png";
				}
			}

			// Получение информации об игроке (деньги, активная машина, купленные машины)
			string playerInfofilePath = directoryPath + "\\Saves\\PlayerInfo.txt";
			string[] info = File.ReadAllLines(playerInfofilePath);
			playerInfo = new PlayerInfo(int.Parse(info[0]), info[1], info[2].Split('|').ToList());
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if (game.state == GameState.Playing)
				Refresh();

			game.Update();
		}
		private void spawnTimer_Tick(object sender, EventArgs e) { }
		private void GameForm_KeyDown(object sender, KeyEventArgs e)
		{
			for (int i = 0; i < game.pressedKeys.Count; i++)
				if (game.pressedKeys[i].key == e.KeyCode)
				{
					game.pressedKeys[i].repeat = true;
					return;
				}
			game.pressedKeys.Add(new PressedKey(e.KeyCode));
		}
		private void GameForm_KeyUp(object sender, KeyEventArgs e)
		{
			for (int i = 0; i < game.pressedKeys.Count; i++)
				if (game.pressedKeys[i].key == e.KeyCode)
				{
					game.pressedKeys.RemoveAt(i);
					return;
				}
		}
		private void GameForm_Paint(object sender, PaintEventArgs e)
		{
			game.Draw(sender, e);
		}
		public void SetGameState(GameState state)
        {
			switch (state)
			{
				case GameState.Playing:
					{
						PausePanel.Enabled = false;
						GameOverPanel.Enabled = false;
						MenuPanel.Enabled = false;
						ShopPanel.Enabled = false;
						RecordPanel.Enabled = false;

						PausePanel.Hide();
						GameOverPanel.Hide();
						MenuPanel.Hide();
						ShopPanel.Hide();
						RecordPanel.Hide();
						break;
					}
				case GameState.Paused:
					{
						PausePanel.Enabled = true;
						PausePanel.Show();

						SpawnTimer.Stop();
						break;
					}
				case GameState.MainMenu:
					{
						PausePanel.Enabled = false;
						GameOverPanel.Enabled = false;
						ShopPanel.Enabled = false;
						RecordPanel.Enabled = false;
						MenuPanel.Enabled = true;

						PausePanel.Hide();
						GameOverPanel.Hide();
						ShopPanel.Hide();
						RecordPanel.Hide();
						MenuPanel.Show();
						break;
					}
				case GameState.Records:
					{
						MenuPanel.Enabled = false;
						RecordPanel.Enabled = true;

						MenuPanel.Hide();
						RecordPanel.Show();
						break;
					}
				case GameState.Shopping:
                    {
						MenuPanel.Enabled = false;
						ShopPanel.Enabled = true;

						MenuPanel.Hide();
						ShopPanel.Show();
						break;
					}
				case GameState.GameOver:
					{
						GameOverPanel.Enabled = true;
						GameOverPanel.Show();

						break;
					}
			}
			game.state = state;
			Refresh();
		}

		// Менюшка
		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void RecordsButton_Click(object sender, EventArgs e)
		{
			string filePath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Saves\\records.txt";
			int i = 0;

			if (File.Exists(filePath))
			{
				foreach (var record in File.ReadAllLines(filePath))
				{
					string info = record.Replace("|", "  ");
					RecordPanel.Controls.Find("RecordsLabel" + i, false)[0].Text = info;
					RecordPanel.Controls.Find("RecordsLabel" + i, false)[0].Show();
					i++;
				}
			}

			SetGameState(GameState.Records);
		}
		private void ShopButton_Click(object sender, EventArgs e)
		{
			currentCarInShop = 0;
			LoadCarInfo();
			SetGameState(GameState.Shopping);

		}
		private void PlayButton_Click(object sender, EventArgs e)
		{
			Timer.Start();
			game.StartGame(cars.Find(a => a.name == playerInfo.activeCar).GameImageFilePath, playerInfo.activeCar);
			SetGameState(GameState.Playing);
		}

		// Рекордики
		private void FromRecordsToMenuButton_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 10; i++)
			{
				RecordPanel.Controls.Find("RecordsLabel" + i, false)[0].Text = "";
				RecordPanel.Controls.Find("RecordsLabel" + i, false)[0].Hide();
			}

			SetGameState(GameState.MainMenu);
		}
		private void LoadCarInfo()
        {
			MoneyCountLabel.Text = playerInfo.money.ToString();

			CarPictureBox.Load(cars[currentCarInShop].ShopImageFilepath);
			CarNameLabel.Text = cars[currentCarInShop].name;

			ShopMainButtton.Text = playerInfo.CheckCar(CarNameLabel.Text);
			CarPriceLabel.Text = string.Empty;

			if (ShopMainButtton.Text == "Купить")
			{
				if (cars[currentCarInShop].price <= playerInfo.money)
					ShopMainButtton.Enabled = true;
				else
					ShopMainButtton.Enabled = false;

				CarPriceLabel.Text = "Цена: " + cars[currentCarInShop].price.ToString();
			}
			else if (ShopMainButtton.Text == "Выбрать")
				ShopMainButtton.Enabled = true;
			else
				ShopMainButtton.Enabled = false;

		}
		// Магазин
		private void FromShopToMenuButton_Click(object sender, EventArgs e)
		{
			SetGameState(GameState.MainMenu);
		}
		private void PrevCarButton_Click(object sender, EventArgs e)
		{
			if (currentCarInShop > 0)
            {
				currentCarInShop--;
				LoadCarInfo();
			}
		}
		private void NextCarButton_Click(object sender, EventArgs e)
		{
			if (currentCarInShop + 1 < cars.Count)
            {
				currentCarInShop++;
				LoadCarInfo();
			}
		}
        private void ShopMainButtton_Click(object sender, EventArgs e)
        {
			if (ShopMainButtton.Text == "Выбрать")
			{
				playerInfo.activeCar = CarNameLabel.Text;
				playerInfo.SavePlayerInfo();
			}
			else if (ShopMainButtton.Text == "Купить")
			{
				playerInfo.AddBoughtCar(CarNameLabel.Text, int.Parse(CarPriceLabel.Text.Replace("Цена: ", "")));
				playerInfo.activeCar = CarNameLabel.Text;
				playerInfo.SavePlayerInfo();
			}

			LoadCarInfo();
        }
		// Гамовер
        private void FromGameOverToMenu_Click(object sender, EventArgs e)
        {
			SetGameState(GameState.MainMenu);
        }
		// Пауза
        private void ContinueGameButton_Click(object sender, EventArgs e)
        {
			SetGameState(GameState.Playing);
			game.stopwatch.Start();
			SpawnTimer.Start();
		}
        private void FromPauseToMenuButton_Click(object sender, EventArgs e)
        {
			game.EndGame();
			SetGameState(GameState.MainMenu);
        }
    }
}
