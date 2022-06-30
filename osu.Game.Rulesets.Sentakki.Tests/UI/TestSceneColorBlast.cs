using NUnit.Framework;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Game.Rulesets.Sentakki.UI.Components;
using osu.Game.Tests.Visual;
using osuTK;

namespace osu.Game.Rulesets.Sentakki.Tests.UI
{
    [TestFixture]
    public class TestSceneColorBlast : OsuTestScene
    {
        protected override Ruleset CreateRuleset() => new SentakkiRuleset();
        private readonly KiaiColorBlast explosion;
        public TestSceneColorBlast()
        {
            Add(new Container
            {
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                RelativeSizeAxes = Axes.None,
                Size = new Vector2(600, 600),
                Children = new Drawable[]{
                    explosion = new KiaiColorBlast()
                }
            });

            AddStep("Blast", () =>
            {
                explosion.PerformColorBlast();
            });
        }
    }
}
