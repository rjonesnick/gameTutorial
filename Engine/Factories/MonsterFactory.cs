using System;
using Engine.Models;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster snake =
                        new Monster("Snake", "Snake.png", 4, 4, 5, 1)

                    AddLootItem(snake, 9001, 25);
                    AddLootItem(snake, 9002, 75);

                    return snake;
                case 2:
                    Monster rat =
                        new Monster("Rat", "Rat.png", 5, 5, 5, 1);

                    AddLootItem(rat, 9003, 25);
            }
        }
    }
}
