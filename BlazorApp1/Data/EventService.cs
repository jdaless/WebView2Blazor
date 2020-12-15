using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class EventService
    {
        public event EventHandler Event;

        public void TriggerEvent() => Event.Invoke(this, null);

        public int Handled = 0;
    }
}
