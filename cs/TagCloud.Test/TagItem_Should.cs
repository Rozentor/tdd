﻿using System;
using System.Drawing;
using FluentAssertions;
using NUnit.Framework;
using TagCloud.Models;

namespace TagCloud.Tests
{
    [TestFixture]
    class TagItem_Should
    {
        [TestCase(0,0,TestName = "Then size is zero")]
        [TestCase(-1, -1, TestName = "Then size is negative")]
        public void ConstructorThrowsArgumentException(int width,int height)
        {
            Action constructor = () => new TagItem(null, new Size(width, height));

            constructor.Should().Throw<ArgumentException>();
        }
    }
}