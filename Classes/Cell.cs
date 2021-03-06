﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOLSource
{
    class Cell
    {
        public bool Active { get; set; }
        public uint AdjacentCount { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public PointF[] hexPoly { get; set; }
        public PointF hexPoint { get; set; }

        public Cell()
        {
            Active = false;
        }

        internal void CountAdjacent(int argX, int argY, uint gridShape, int argWidth, int argHeight)
        {
            int adjX;
            int adjY;

            for (int i = 0; i < 9; i++)
            {
                adjX = argX + (i / 3) - 1;
                adjY = argY + (i % 3) - 1;

                // Wrap around the universe when toroidal.
                if (!Program.form.isFinite)
                {
                    if (adjX >= argWidth)
                    {
                        adjX = 0;
                    }
                    else if (adjX < 0)
                    {
                        adjX = argWidth - 1;
                    }
                    if (adjY >= argHeight)
                    {
                        adjY = 0;
                    }
                    else if (adjY < 0)
                    {
                        adjY = argHeight - 1;
                    }
                }

                if (
                    i == 4 // Exclude this cell.
                    || (Program.form.isFinite // Skip these exclusions when toroidal.
                    && (adjX >= argWidth
                        || adjY >= argHeight
                        || adjX < 0
                        || adjY < 0)
                    )
                    )
                {
                    continue;
                }

                // Exclude additional cells from the hex grid.
                if (gridShape == 1
                    && (
                        (
                        (argY % 2 == 0)
                        && (i == 6 || i == 8)
                        )
                        || (
                        (argY % 2 == 1)
                        && (i == 0 || i == 2)
                        )
                    )
                    )
                {
                    continue;
                }

                if (Program.universe[argX, argY].Active)
                {
                    Program.universe[adjX, adjY].AdjacentCount++;
                }
                else
                {
                    Program.universe[adjX, adjY].AdjacentCount--;
                }
            }
        }
    }
}
