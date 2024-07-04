using Core.Entities;
using UI.HttpServices;

namespace UI
{
    public partial class Form1 : Form
    {

        private readonly DictionaryHttpService _dictionaryHttpService;

        public Form1(DictionaryHttpService dictionaryHttpService)
        {
            _dictionaryHttpService = dictionaryHttpService;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var temp = await _dictionaryHttpService.GetAllAsync();
        }
    }
}
