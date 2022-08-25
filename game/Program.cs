using System.Collections.Generic;

namespace game
{
    internal class Program
    {

        // string[,] game_field = new string[10, 8];
         public class game
       {
            
            private bool player=true;
            string[][] win_field_mass = {
                new string[] {"           " ,  " X | X | X ","___________",
                                "           ", " 4 | 5 | 6 ","___________",
                                "           ", " 1 | 2 | 3 " },
                new string[] {"           " ,  " 7 | 8 | 9 ","___________",
                                "           ", " X | X | X ","___________",
                                "           ", " 1 | 2 | 3 " },
                new string[] {"           " ,  " 7 | 8 | 9 ","___________",
                                "           ", " 4 | 5 | 6 ","___________",
                                "           ", " X | X | X " },
                new string[] { "           " ,  " X | 8 | 9 ","___________",
                                "           ", " X | 5 | 6 ","___________",
                                "           ", " X | 2 | 3 " },
                new string[] {"           " ,  " 7 | X | 9 ","___________",
                                "           ", " 4 | X | 6 ","___________",
                                "           ", " 1 | X | 3 " },
                new string[] { "           " ,  " 7 | 8 | X ","___________",
                                "           ", " 4 | 5 | X ","___________",
                                "           ", " 1 | 2 | X " },
                new string[] {  "           " ,  " X | 8 | 9 ","___________",
                                "           ", " 4 | X | 6 ","___________",
                                "           ", " 1 | 2 | X "},
                new string[] { "           " ,  " 7 | 8 | X ","___________",
                                "           ", " 4 | X | 6 ","___________",
                                "           ", " X | 2 | 3 " },
                 new string[8],
                 new string[8],
                 new string[8],
                 new string[8],
                 new string[8],
                 new string[8],
                 new string[8],
                 new string[8],


                };

           public string[][] win_field_mass_gen(string[] field_mass_gen)
            {
                for(int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            this.win_field_mass[i + 8][j] = this.win_field_mass[i][j].Replace('X','O');
                        }
                    }
                return(win_field_mass);   
            }
            // lisr.Add(win_0);

            public bool Player
            {
                get { return player; }
                set { player = value; } 
            }
        public string[] Step(ConsoleKey Key, string[] game_field, ConsoleKey[] consoleKeys)
        {
            
           // player = (!player);
            if (player == true) { Console.WriteLine(" Хорошо, первые ходят X "); }
            if (player == false) { Console.WriteLine(" Хорошо, теперь ходят O "); }
            foreach (ConsoleKey consoleKey in consoleKeys)
            {
                if (Console.ReadKey().Key == consoleKey)
                {
                    foreach (string s in game_field)
                    {
                        if (player == true) s.Replace((char)consoleKey, 'X');
                        if (player == false) s.Replace((char)consoleKey, 'O');
                            
                          
                        else
                        {
                            Console.WriteLine("Поле занято. Выбирете другое поле");
                               
                        }
                            for (int i = 0; i < game_field.Length; i++)
                            {
                                Console.WriteLine(game_field[i] + "\n");
                            }
                    }
                }

            }
            return (game_field);
        }
        public string winner_verify(string[] game_field)
            {
                
                return ("победил игрок Х");
            }
        }
    
    
        static void Main(string[] args)
            {
           game game = new game();
          //  game.win_field_mass_gen(args);
            string[] game_field ={"           " ," 7 | 8 | 9 ","___________",
                                "           ", " 4 | 5 | 6 ","___________",
                                "           ", " 1 | 2 | 3 "};


                ConsoleKey[] consoleKeys = { ConsoleKey.D0, ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3,
                                        ConsoleKey.D4, ConsoleKey.D5, ConsoleKey.D6, ConsoleKey.D7,
                                        ConsoleKey.D8, ConsoleKey.D9,};
                while (true)
                {
                    Console.WriteLine(" Господин, не хотите сыграть в игру?(y/n) ");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {

                        for (int i = 0; i < game_field.Length; i++)
                        {
                            Console.WriteLine(game_field[i] + "\n");
                        }


                        Console.WriteLine(" C кем будем играть?(h/c) ");
                        if (Console.ReadKey().Key == ConsoleKey.H)
                        {
                        for (int i = 0; i < consoleKeys.Length; i++)
                        {

                            if (game_field == game.Step(Console.ReadKey().Key, game_field, consoleKeys))
                            {
                                ;
                            }
                            else
                            {
                               
                                game.Player = !game.Player;
                            }

                        }
                        Console.WriteLine(" Игра окончена в ничью");
                        break;
                    }
                        if (Console.ReadKey().Key == ConsoleKey.C)
                        {
                            Console.WriteLine(" Хорошо,  будете ходить первым? (y/n) ");
                            if (Console.ReadKey().Key == ConsoleKey.Y)
                            { }
                            if (Console.ReadKey().Key == ConsoleKey.N)
                            { }
                        }

                    }
                    if (Console.ReadKey().Key == ConsoleKey.N)
                    {
                        Console.WriteLine(" В другой раз ");
                        break;
                    }
                }
            }
        }
    }