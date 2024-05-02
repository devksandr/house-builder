using house_builder.Bulders;
using house_builder.Directors;
using house_builder.Services;

namespace house_builder
{
    public partial class FormLand : Form
    {
        private List<HouseBuilderAbstract> _houseBuilders;
        private HouseUISwitcherService _houseUISwitcherService;
        private HouseDrawerService _houseDrawerService;

        public FormLand()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            InitServices();
            InitHouseBuildersList();
            InitHouseBuildersPanel();
        }

        private void InitServices()
        {
            var houseUIControls = new List<Control>
            {
                buttonBuildHouse, buttonDestroyHouse, panelHouseBuilders
            };
            _houseUISwitcherService = new HouseUISwitcherService(houseUIControls);
            _houseDrawerService = new HouseDrawerService(pictureBoxHouse);
        }

        private void InitHouseBuildersList()
        {
            _houseBuilders = new List<HouseBuilderAbstract>
            {
                new StandartHouseBuilder(),
                new IronHouseBuilder(),
                new WoodHouseBuilder(),
                new BrickHouseBuilder()
            };
        }

        private void InitHouseBuildersPanel()
        {
            for (int i = 0; i < _houseBuilders.Count; i++)
            {
                var radioButton = new RadioButton();
                radioButton.AutoSize = true;
                radioButton.Text = _houseBuilders[i].GetType().Name;
                radioButton.Location = new Point(0, radioButton.Height * i);
                radioButton.Checked = panelHouseBuilders.Controls.Count == 0;

                panelHouseBuilders.Controls.Add(radioButton);
            }
        }

        private HouseBuilderAbstract GetActiveHouseBuilder()
        {
            var checkedHouseBuilder = panelHouseBuilders.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            var houseBuilderPosition = panelHouseBuilders.Controls.IndexOf(checkedHouseBuilder);
            return _houseBuilders[houseBuilderPosition];
        }

        #region Event handlers
        private void buttonBuildHouse_Click(object sender, EventArgs e)
        {
            var houseBuilder = GetActiveHouseBuilder();
            var houseDirector = new HouseDirector(houseBuilder);
            houseDirector.Construct();
            var house = houseBuilder.GetResult();

            _houseDrawerService.Draw(house);
            _houseUISwitcherService.Switch();
        }

        private void buttonDestroyHouse_Click(object sender, EventArgs e)
        {
            _houseDrawerService.Clear();
            _houseUISwitcherService.Switch();
        }
        #endregion
    }
}
