// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using Xunit;

namespace SixLabors.Fonts.Tests.Issues
{
    public class Issues_180
    {
        [Fact]
        public void CorrectlySetsHeightMetrics()
        {
            // Whitney-book has invalid hhea values.
            Font font = new FontCollection().Install(TestFonts.WhitneyBookFile).CreateFont(25);

            FontRectangle size = TextMeasurer.Measure("H", new RendererOptions(font));

            Assert.Equal(17.6, size.Width, 1);
            Assert.Equal(25, size.Height, 1);
        }
    }
}