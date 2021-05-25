using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApp
{
    public class Startup
    {
        public void getStarted()
        {
            MenuAppController controller = new MenuAppController();
            controller.Populate();
        }
        
    }
}
