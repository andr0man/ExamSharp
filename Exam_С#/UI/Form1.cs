using Core.Entities;
using System.Windows.Forms;
using UI.HttpServices;

namespace UI
{
    public partial class Form1 : Form
    {
        private readonly DictionaryService _dictionaryHttpService;

        public Form1(DictionaryService DictionaryService)
        {
            _dictionaryHttpService = DictionaryService;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var data = (await _dictionaryHttpService.GetAllAsync()).Select(x => new { x.Type }).ToList();
            dataGridViewDict.DataSource = data;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = await _dictionaryHttpService.GetAllAsync();
        }
    }
}
