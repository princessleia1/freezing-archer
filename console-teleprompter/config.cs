using static System.Math;

namespace TeleprompterConsole
{
    internal class TelePrompterConfig
    {
        private object lockHandle = new object();

        public int DelayInMilliseconds { get; private set; } = 250; 

        public void UpdateDelay(int increment) // Negative for speeding up
        {
            var newDelay = Min(DelayInMilliseconds + increment, 1000);
            newDelay = Max(newDelay, 20);
            lock (lockHandle)
            {
                DelayInMilliseconds = newDelay;
            }
        }

        public bool Done { get; private set; }

        public void SetDone()
        {
            Done = true;
        }
    }
}