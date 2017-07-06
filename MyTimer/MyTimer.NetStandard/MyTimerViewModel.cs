using System;
using Reactive.Bindings;

namespace MyTimer
{
    public class MyTimerViewModel
    {
        public ReactiveProperty<int> CurrentCount { get; }
        public ReactiveCommand StartCommand { get; } = new ReactiveCommand();
        public ReactiveCommand StopCommand { get; } = new ReactiveCommand();

        public MyTimerViewModel()
        {
            var Model = new MyTimerModel();
            CurrentCount = Model.CurrentCount;
            StartCommand.Subscribe(_ => Model.Start());
            StopCommand.Subscribe(_ => Model.Stop());
        }
    }
}
