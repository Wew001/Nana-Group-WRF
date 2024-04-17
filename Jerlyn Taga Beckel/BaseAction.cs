using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Jerlyn_Taga_Beckel
{
    public abstract class BaseAction
    {
        protected readonly GameItem _itemInUse;
        public event EventHandler<string> OnActionPerformed;
        protected BaseAction(GameItem itemInUse)
        {
            _itemInUse = itemInUse;
        }
        protected void ReportResult(string result)
        {
            OnActionPerformed?.Invoke(this, result);
        }
    }
}
