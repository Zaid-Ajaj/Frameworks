﻿using Bridge.Html5;

namespace Bridge.ChartJs
{
    using NumberOrNumbers = Union<int, double, int[], double[]>;

    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;

    [ObjectLiteral]
    [External]
    public class PieOrDoughnutDataset : Dataset
    {
        public Union<int[], double[], decimal[]> Data;
        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips
        /// </summary>
        public string Label;
        /// <summary>
        /// The fill color under the line
        /// </summary>
        public Color BackgroundColor;
        /// <summary>
        /// The color of the line.
        /// </summary>
        public Color BorderColor;
        /// <summary>
        /// Point background color when hovered
        /// </summary>
        public Color HoverBackgroundColor;

        /// <summary>
        /// Border width of bar in pixels
        /// </summary>
        public NumberOrNumbers BorderWidth;
        /// <summary>
        /// border color when hovered
        /// </summary>
        public Color HoverBorderColor;
        /// <summary>
        /// Border width when hovered
        /// </summary>
        public NumberOrNumbers HoverBorderWidth;
    }
}