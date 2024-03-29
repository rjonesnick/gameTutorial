﻿using System;
using System.Collections.Generic;
using System.Linq;
using Engine.Models;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            // Declare necessary items to complete the quest and quest reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(9001, 5));
            rewardItems.Add(new ItemQuantity(1002, 1));

            // Creates the quest
            _quests.Add(new Quest(1,
                                  "Clear the herb garden",
                                  "Deveat the snakes in the Herbalist's garden",
                                  itemsToComplete,
                                  25, 10,
                                  rewardItems));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
