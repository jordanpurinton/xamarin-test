﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class GridPage : ContentPage
	{
		public GridPage()
		{
			InitializeComponent();

			//	var grid = new Grid
			//	{
			//		RowSpacing = 20,
			//		ColumnSpacing = 40
			//	};

			//	var label = new Label { Text = "Code Behind Grid" };
			//	grid.Children.Add(label, 0, 0);
			//	Grid.SetRowSpan(label, 2);
			//	Grid.SetColumnSpan(label, 2);
			//	Grid.SetRow(label, 0);
			//	Grid.SetColumn(label, 0);

			//	grid.RowDefinitions.Add(new RowDefinition
			//	{
			//		Height = new GridLength(100, GridUnitType.Absolute)	
			//	});

			//	grid.RowDefinitions.Add(new RowDefinition
			//	{
			//		Height = new GridLength(2, GridUnitType.Star) // makes it proportional like in the XAML
			//	});

			//	grid.RowDefinitions.Add(new RowDefinition
			//	{
			//		Height = new GridLength(1, GridUnitType.Auto) // height of row calculated based on children
			//	});

			//}
		}
	}
}