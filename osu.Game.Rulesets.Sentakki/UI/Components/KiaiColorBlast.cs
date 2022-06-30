using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osuTK;

namespace osu.Game.Rulesets.Sentakki.UI.Components
{

    public class KiaiColorBlast : Sprite
    {
        public override bool RemoveWhenNotAlive => true;

        [BackgroundDependencyLoader(true)]
        private void load(TextureStore textures)
        {
            Origin = Anchor = Anchor.Centre;
            RelativeSizeAxes = Axes.Both;
            Texture = textures.Get("blast");
            Scale = new Vector2(0, 0);
        }

        public void PerformColorBlast()
        {
            this.FadeIn().ScaleTo(0).ScaleTo(1, 300).Spin(10000, RotationDirection.Clockwise, 0).FadeOut(duration: 1000);
        }
    }
}
