namespace house_builder.Services
{
    public class HouseUISwitcherService
    {
        List<Control> _controls; 

        public HouseUISwitcherService(List<Control> controls)
        {
            _controls = controls;
        }

        public void Switch() 
            => _controls.ForEach(c => c.Enabled = !c.Enabled);
    }
}
