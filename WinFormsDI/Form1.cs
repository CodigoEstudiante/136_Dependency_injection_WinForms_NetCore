using Microsoft.Extensions.DependencyInjection;
using Services;

namespace WinFormsDI
{
    public partial class Form1 : Form
    {
        private readonly IMyService _myService;
        private readonly IServiceProvider _serviceProvider;
        public Form1(IMyService service, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _myService = service;
            _serviceProvider = serviceProvider;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_myService.Mensaje());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var _form2 =   _serviceProvider.GetRequiredService<Form2>();
            _form2.Show();
        }
    }
}
