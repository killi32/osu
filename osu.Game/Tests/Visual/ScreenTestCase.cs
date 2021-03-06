﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Graphics;
using osu.Game.Screens;

namespace osu.Game.Tests.Visual
{
    /// <summary>
    /// A test case which can be used to test a screen (that relies on OnEntering being called to execute startup instructions).
    /// </summary>
    public abstract class ScreenTestCase : OsuTestCase
    {
        private readonly OsuScreenStack stack;

        protected ScreenTestCase()
        {
            Child = stack = new OsuScreenStack { RelativeSizeAxes = Axes.Both };
        }

        protected void LoadScreen(OsuScreen screen)
        {
            if (stack.CurrentScreen != null)
                stack.Exit();
            stack.Push(screen);
        }
    }
}
