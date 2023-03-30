using Prometheus;
using System.Diagnostics.Metrics;

namespace HungryGame
{
    public class HungryMetrics
    {
        private UpDownCounter<int> pillsFeltOnBorad;
        public HungryMetrics()
        {
            /*m = new Meter("meter");
            pillsFeltOnBorad= m.CreateUpDownCounter<int>("Pills_total", "The total pills left on the board", null);*/
        }
        static Meter m { get; set; }

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
        public Counter winningPlayerScore = Metrics.CreateCounter("Winning_Playyer_Score_total", "The highest winning score", new CounterConfiguration
        {
            LabelNames = new[] { "player" , "score"}

        });
        public Counter pillTotal = Metrics.CreateCounter("Pills_total", "The total pills eaten");
        public Counter playersDead = Metrics.CreateCounter("Dead_or_removed_player_total", "The cound of players that are dead or removed");
        /* public void changePillCount(int count)
         {
             pillTotal =+ count;
         }*/

    }
}
