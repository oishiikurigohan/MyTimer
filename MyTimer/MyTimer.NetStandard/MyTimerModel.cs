using System.Threading;
using Reactive.Bindings;

namespace MyTimer
{
    public class MyTimerModel
    {
        public ReactiveProperty<int> CurrentCount { get; } = new ReactiveProperty<int>(0);
        private Timer timer;

        public MyTimerModel()
        {
            var callBack = new TimerCallback((o) => { CurrentCount.Value++; });
            timer = new Timer(callBack, null, Timeout.Infinite, Timeout.Infinite);
        }

        public void Start() => timer.Change(0, 1000);
        public void Stop() => timer.Change(Timeout.Infinite, Timeout.Infinite);
    }
}
