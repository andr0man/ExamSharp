using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.HttpServices;

namespace UI
{
    public partial class DictionatyView : Form
    {
        private readonly DictionaryService _dictionaryHttpService;
        public DictionatyView(DictionaryService DictionaryService)
        {
            _dictionaryHttpService = DictionaryService;
            InitializeComponent();
        }


    }
}
