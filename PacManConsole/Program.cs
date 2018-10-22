using Edibles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManConsole
{
	public class Program
	{

		
		static void Main(string[] args)
		{

			using (StreamReader sr = new StreamReader("C:\\Users\\ZachN\\Downloads\\data.csv"))
			{
				string line = sr.ReadToEnd();
				string[] values = line.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

				Pacman pacman = new Pacman();
				var points = pacman.Points;
				var lives = pacman.Lives;
				points = 5000;
				lives = 3;

				int dot = 10;
				int cherry = 100;
				int strawberry = 300;
				int orange = 500;
				int apple = 700;
				int melon = 1000;
				int galaxian = 2000;
				int bell = 3000;
				int key = 5000;

				int invincibleGhost = -1;
				int vulnerableGhost = 200;
				int numVulGhosts = 0;

					foreach (var item in values)
					{
					//if (points == (points += 10000))
					//	lives += 1;
					//if(lives > 0)
						switch (item)
						{
							case "InvincibleGhost":
								lives += invincibleGhost;
								break;
							case "Dot":
								points += dot;
								break;
							case "Cherry":
								points += cherry;
								break;
							case "Strawberry":
								points += strawberry;
								break;
							case "Orange":
								points += orange;
								break;
							case "Apple":
								points += apple;
								break;
							case "Melon":
								points += melon;
								break;
							case "Galaxian":
								points += galaxian;
								break;
							case "Bell":
								points += bell;
								break;
							case "Key":
								points += key;
								break;
							case "VulnerableGhost":
								if(numVulGhosts < 4)
								for (var ghost = vulnerableGhost; ghost <= 1600 && numVulGhosts <= 4; ghost += ghost)
								{
									points += ghost;
									numVulGhosts += 1;
								}
								break;
						}

					}
				
				Console.WriteLine($"You scored {points} and had {lives} lives leftover!");
			}
		}
	}
}
