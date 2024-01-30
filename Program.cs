namespace jeuDeplacement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Niveau 3 : Faire un jeu sur lequel on peut déplacer un personnage sur une grille");
            Console.WriteLine();

            /* On déclare les éléments du plateau */
            int xPositionEnd = 17;
            int yPositionEnd = 0;
            char character = '0';
            char previousMove = '-';

            /* On déclare une map(tableau) de 20x20
             * la map est entouré de mur que le personnage ne peut pas franchir*/

            char verticalWall = '║';
            char horizontallWall = '═';
            char cornerUpRight = '╗';
            char cornerUpLeft = '╔';
            char cornerBottomRight = '╝';
            char cornerBottomLeft = '╚';

            char[,] carte = {
                { cornerUpLeft, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, cornerUpRight },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { verticalWall, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', verticalWall },
                { cornerBottomLeft, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, horizontallWall, cornerBottomRight } };


            //drawMap(20, 20);
            displayMap(20,20, 3, 20, xPositionEnd, yPositionEnd, character);
            



            Console.ReadKey();
        }

        public static void displayMap(int width, int height, int xPositionPlayer, int yPositionPlayer, int xPositionEnd, int yPositionEnd, char player )
        {
            bool play = true;
            while (play)
            {

            //drawMap(width, height);
                char[,] map =  drawMap(width, height);

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (yPositionPlayer == i && xPositionPlayer == j)
                        {
                            Console.Write(player);
                        } else if (yPositionEnd == i && xPositionEnd == j)
                        {
                            Console.Write(' ');
                        }
                    //    else
                    //{
                    //Console.Write(tableau[i, j]);
                    //}
                }
                    //Console.WriteLine();
                }
                int direction = characterMovement();
                switch (direction)
                {
                    case 1:
                        yPositionPlayer -= 1;
                        break;
                    case 2:
                        xPositionPlayer += 1;
                        break;
                    case 3:
                        yPositionPlayer += 1;
                        break;
                    case 4:
                        xPositionPlayer -= 1;
                        break;
                }
            }
        }



        public static int characterMovement()
        {
            int Movement = 0;
            bool choice = false;

            while (!choice)
            {
                Console.WriteLine("Dans quelle direction voulez-vous aller ?\nEcrivez droite, gauche, bas ou haut.");
                string direction = Console.ReadLine();

                switch (direction)
                {
                    case "haut":
                        Movement = 1;
                        choice = true;
                        break;
                    case "droite":
                        Movement = 2;
                        choice = true;
                        break;
                    case "bas":
                        Movement =3;
                        choice = true;
                        break;
                    case "gauche":
                        Movement =4;
                        choice = true;
                        break;
                }
            }

            return Movement;
        }

        public static char[,] drawMap(int width, int height)
        {
            char verticalWall = '║';
            char horizontallWall = '═';
            char cornerUpRight = '╗';
            char cornerUpLeft = '╔';
            char cornerBottomRight = '╝';
            char cornerBottomLeft = '╚';

            char[,] map = new char[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write(cornerUpLeft);} 
                    else if ( i==0 && j == width -1)
                    {
                        Console.Write(cornerUpRight);
                    } 
                    else if (i == height -1 && j == 0)
                    {
                        Console.Write(cornerBottomLeft);
                    } 
                    else if ( i == height -1 && j == width -1)
                    {
                        Console.Write(cornerBottomRight);
                    } 
                    else if (i == 0 || i == height -1)
                    {
                        Console.Write(horizontallWall);
                    }
                    else if (j == 0 || j == width -1)
                    {
                        Console.Write(verticalWall);
                    } 
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            return map;
        }

    }
}
