﻿using System;
using System.Collections.Generic;
using System.Drawing;
using static System.Math;

namespace TagCloud
{
    public class Spiral : PointsSequence
    {
        private double alpha;
        private double stepLength;

        public Spiral() : base(Point.Empty)
        {
            SetStepLength(1);
        }

        public override void Reset()
        {
            alpha = 0;
        }

        public void SetStepLength(double stepLength)
        {
            if (stepLength <= 0)
                throw new ArgumentException("step can't be negative or zero");
            this.stepLength = stepLength;
        }

        protected override IEnumerable<Point> Sequence()
        {
            while (true)
            {
                yield return new Point
                {
                    X = (int)(stepLength / (PI * 2) * alpha * Cos(alpha)),
                    Y = (int)(stepLength / (PI * 2) * alpha * Sin(alpha))
                };
                alpha++;
            }
        }

        public static SpiralBuilder Create()
        {
            return new SpiralBuilder(new Spiral());
        }
    }
}