using System.Collections.Generic;

namespace MediatorObserver
{
    public abstract class UIControl
    {
        private List<IEventHandler> eventHandlers = new List<IEventHandler>();

        public void AddEventHAndler(IEventHandler eventHandler)
        {
            eventHandlers.Add(eventHandler);
        }

        protected void NotifyEventHandlers()
        {
            foreach (var eventHandler in eventHandlers)
            {
                eventHandler.Handle();
            }
        }
    }
}
