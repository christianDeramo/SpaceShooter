﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast2Da
{
    static class DrawManager
    {
        public enum Layer { Background, Middleground, Playground, Foreground, GUI}
        static List<IDrawable>[] itemsList;

        public static void Init()
        {
            itemsList = new List<IDrawable>[(int)Layer.GUI + 1];

            for (int i = 0; i < itemsList.Length; i++)
            {
                itemsList[i] = new List<IDrawable>();
            }
        }

        public static void AddItem(IDrawable item)
        {
            itemsList[(int)item.Layer].Add(item);
        }

        public static void RemoveItem(IDrawable item)
        {
            itemsList[(int)item.Layer].Remove(item);
        }

        public static void RemoveAll()
        {
            for (int i = 0; i < itemsList.Length; i++)
            {
                itemsList[i].Clear();
            }
        }

        public static void Draw()
        {
            for (int i = 0; i < itemsList.Length; i++)
            {
                for (int j = 0; j < itemsList[i].Count; j++)
                {
                    itemsList[i][j].Draw();
                }
            }
        }
    }
}
