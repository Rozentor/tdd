﻿using System.Collections.Generic;
using System.Drawing;

namespace TagCloud
{
    public abstract class PointsSequence : IPointsSequence
    {
        protected Point center;
        protected readonly IEnumerator<Point> enumerator;

        protected PointsSequence(Point center)
        {
            SetCenter(center);
            enumerator = Sequence().GetEnumerator();
        }

        public void SetCenter(Point center)
        {
            this.center = center;
        }

        public Point GetNextPoint()
        {
            enumerator.MoveNext();
            return enumerator.Current.WithTranslation(center);
        }

        public abstract void Reset();

        protected abstract IEnumerable<Point> Sequence();
    }
}