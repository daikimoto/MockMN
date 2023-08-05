using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Collections;
using MockMN.Model;

namespace MockMN.ViewModel;

public partial class A010ViewModel : ObservableObject
{
	readonly IList<A010Carousel> source;
	public ObservableCollection<A010Carousel> Carousels { get; set; } = new ObservableCollection<A010Carousel>();
	
	public A010ViewModel()
	{
		source = new List<A010Carousel>();
		Create_A010Carousels();
	}

	public void Create_A010Carousels()
	{
		source.Add(new A010Carousel() { ImageUrl = "a010_carousel01.png", ExplainText = "a010_carousel01.png" });
        source.Add(new A010Carousel() { ImageUrl = "a010_carousel02.png", ExplainText = "a010_carousel02.png" });
        source.Add(new A010Carousel() { ImageUrl = "a010_carousel03.png", ExplainText = "a010_carousel03.png" });
        source.Add(new A010Carousel() { ImageUrl = "a010_carousel04.png", ExplainText = "a010_carousel04.png" });

		Carousels = new ObservableCollection<A010Carousel>(source);
	}
}