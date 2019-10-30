using SMARTgestion.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMARTgestion.Infrastructure
{
    public class InstanceLocator
    {
        #region propiertes
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
