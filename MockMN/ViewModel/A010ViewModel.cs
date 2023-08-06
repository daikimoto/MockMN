using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Collections;
using MockMN.Model;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MockMN.ViewModel;

public partial class A010ViewModel : ObservableObject
{
	readonly IList<A010Carousel> source;
	public ObservableCollection<A010Carousel> Carousels { get; set; } = new ObservableCollection<A010Carousel>();

	// 固定テキスト
	[ObservableProperty]
	public string a010_attention01 = "以下、すべての条件を満たすことを確認してチェックしてください。すべてにチェックが出来ない場合、本アプリで個人番号（マイナンバー）を届け出ることができません。";
	[ObservableProperty]
	public string a010_attention02 = "既に個人番号（マイナンバー）を届け出ている場合、届出は不要です。";
	[ObservableProperty]
	public string a010_checkBoxLabel01 = "以下のいずれかが手元にある¥n①個人番号カード¥n②通知カードおよび運転免許証";
    [ObservableProperty]
    public string a010_checkBoxLabel02 = "キャッシュカードなど、店番と口座番号がわかる資料が手元にある";
    [ObservableProperty]
    public string a010_checkBoxLabel03 = "届出の氏名・住所に変更がない";
    [ObservableProperty]
    public string a010_selectButton01 = "個人番号カードで届け出る";
    [ObservableProperty]
    public string a010_selectButton02 = "通知カードで届け出る";

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