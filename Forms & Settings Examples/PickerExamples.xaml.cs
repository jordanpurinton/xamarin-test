using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;

namespace HelloWorld
{

	public class Pie
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public partial class PickerExamples : ContentPage
	{

		private IList<Pie> _pieList;

		public PickerExamples()
		{
			InitializeComponent();

			_pieList = getPieList();

			foreach (var pie in _pieList)
			{
				piePicker.Items.Add(pie.Name);

			}
		}

		void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			var currentPie = piePicker.Items[piePicker.SelectedIndex];
			_pieList.Single(pie => pie.Name == currentPie);

			DisplayAlert("Current pie", currentPie, "Dismiss");
		}

		private IList<Pie> getPieList()
		{
			return new List<Pie>
			{
				new Pie{Id = 1, Name = "Apple"},
				new Pie{Id = 2, Name = "Cherry"}
			};
		}
	}
}
