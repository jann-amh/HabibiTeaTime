using System.Collections.Generic;
using HLE.Time;
using Timer = System.Timers;

namespace HabibiTeaTime.Twitch
{
    public class Restarter
    {

        private readonly List<Timer::Timer> _restartTimers = new();

        private List<(int Hour, int Minute)> _restartTimes;

        public Restarter()
        {
            Timer::Timer timer = new(new Hour(2).Milliseconds);
            timer.Elapsed += (sender, e) => Program.Restart();
            timer.Start();
        }

        public void InitializeResartTimer()
        {
            InitializeResartTimer(_restartTimes);
        }

        public void InitializeResartTimer(List<(int, int)> hoursOfDay)
        {
            _restartTimes = hoursOfDay;
            Stop();
            _restartTimes.ForEach(r => _restartTimers.Add(new(TimeHelper.MillisecondsUntil(r.Hour, r.Minute))));
            _restartTimers.ForEach(t =>
            {
                t.Elapsed += RestartTimer_OnElapsed;
                t.Start();
            });
        }

        public void Stop()
        {
            _restartTimers.ForEach(t =>
            {
                t.Stop();
                t.Dispose();
            });
            _restartTimers.Clear();
        }

        private void RestartTimer_OnElapsed(object sender, Timer::ElapsedEventArgs e)
        {
            (sender as Timer::Timer).Interval = new Day().Milliseconds;
            Program.Restart();
        }
    }
}
