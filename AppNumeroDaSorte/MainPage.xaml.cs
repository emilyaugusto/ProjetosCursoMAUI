namespace AppNumeroDaSorte
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGenerateLuckNum(object sender, EventArgs e)
        {
            NameApp.IsVisible = false;
            ContainerLuckNum.IsVisible = true;


            var set = GenerateLuckNum();

            LuckNum01.Text = set.ElementAt(0).ToString("D2");
            LuckNum02.Text = set.ElementAt(1).ToString("D2");
            LuckNum03.Text = set.ElementAt(2).ToString("D2");
            LuckNum04.Text = set.ElementAt(3).ToString("D2");
            LuckNum05.Text = set.ElementAt(4).ToString("D2");
            LuckNum06.Text = set.ElementAt(5).ToString("D2");
        }

        private SortedSet<int> GenerateLuckNum()
        {
            
            var set = new SortedSet<int>();
            while (set.Count < 6) 
            {
                var randon = new Random();
                var luckNumber = randon.Next(1, 60);

                    set.Add(luckNumber);
            }
                return set;
            
        }
    }
}
