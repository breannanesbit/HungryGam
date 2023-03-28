using Prometheus;
using System.Diagnostics.Metrics;

namespace HungryGame
{
    public class HungryMetrics
    {
        public Counter moveUp = Metrics.CreateCounter("Move_Up_total", "all movements that are up", new CounterConfiguration
        {
            LabelNames = new[] {"player"}
        });
        public Counter moveDown = Metrics.CreateCounter("Move_Down_total", "all movements that are Down", new CounterConfiguration
        {
            LabelNames = new[] { "player" }
        });
        public Counter moveLeft = Metrics.CreateCounter("Move_Left_total", "all movements that are Left", new CounterConfiguration
        {
            LabelNames = new[] { "player" }
        });
        public Counter moveRight = Metrics.CreateCounter("Move_Right_total", "all movements that are Right", new CounterConfiguration
        {
            LabelNames = new[] { "player" }
        });

    }
}
