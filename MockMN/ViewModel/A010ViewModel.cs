using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using MockMN.Model;

namespace MockMN.ViewModel;

public partial class A010ViewModel : ObservableObject
{
    /* A010カルーセルに表示するデータ*/
    readonly IList<A010Guidance> source;
    public ObservableCollection<A010Guidance> Carousels { get; set; } = new ObservableCollection<A010Guidance>();

	public A010ViewModel()
	{
        source = new List<A010Guidance>();
        Create_Carousel();
	}

    /* カルーセル表示データの作成 */
    void Create_Carousel()
    {
        source.Add(new A010Guidance() { ImageUrl = "a010_guidance01.png", ExplainText = A010_guidance01 });
        source.Add(new A010Guidance() { ImageUrl = "a010_guidance02.png", ExplainText = A010_guidance02 });
        source.Add(new A010Guidance() { ImageUrl = "a010_guidance03.png", ExplainText = A010_guidance03 });
        source.Add(new A010Guidance() { ImageUrl = "a010_guidance04.png", ExplainText = A010_guidance04 });
        source.Add(new A010Guidance() { ImageUrl = "a010_guidance05.png", ExplainText = A010_guidance05 });
        source.Add(new A010Guidance() { ImageUrl = "a010_guidance06.png", ExplainText = A010_guidance06 });
        source.Add(new A010Guidance() { ImageUrl = "a010_guidance07.png", ExplainText = A010_guidance07 });

        Carousels = new ObservableCollection<A010Guidance>(source);
    }

    /** UI表示文字列 **/
    [ObservableProperty]
	public string a010_guidance01 = "このアプリは個人番号（マイナンバー）を当行に届出いただくためのアプリです。";
    [ObservableProperty]
    public string a010_guidance02 = "以下のいずれかをご用意ください。\n①個人番号カード\n②通知カードおよび運転免許証";
    [ObservableProperty]
    public string a010_guidance03 = "キャッシュカードなど、\n店番と口座番号がわかる資料を\nご用意ください。";
    [ObservableProperty]
    public string a010_guidance04 = "ガイダンスに従い\n口座情報を入力してください。";
    [ObservableProperty]
    public string a010_guidance05 = "以下のいずれかを撮影してください。\n①個人番号カード\n②通知カードおよび運転免許証";
    [ObservableProperty]
    public string a010_guidance06 = "届出内容を確認してください。";
    [ObservableProperty]
    public string a010_guidance07 = "この画面で個人番号（マイナンバー）の届出は完了です。";
    [ObservableProperty]
    public string a010_NextButton = "次へ";

}