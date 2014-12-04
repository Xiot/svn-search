using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvnSearchUI.Services
{
	public class EventSource
	{
		private readonly ConcurrentDictionary<string, List<EventHandler>> _subscribers;

		public EventSource()
		{
			_subscribers = new ConcurrentDictionary<string, List<EventHandler>>();
		}

		public void Publish(string eventName, EventArgs args)
		{
			List<EventHandler> eventList;
			if (!_subscribers.TryGetValue(eventName, out eventList))
				return;

			foreach (var sub in eventList.ToArray())
				sub(this, args);
		}

		public IDisposable Subscribe(string eventName, EventHandler handler)
		{
			var eventList = _subscribers.GetOrAdd(eventName, x => new List<EventHandler>());
			eventList.Add(handler);

			return new Unsubscriber(() => eventList.Remove(handler));
		}

		private class Unsubscriber : IDisposable
		{
			private readonly Action _onUnsubscribe;

			public Unsubscriber(Action onUnsubscribe)
			{
				_onUnsubscribe = onUnsubscribe;
			}

			public void Dispose()
			{
				_onUnsubscribe();
			}
		}
	}
}
