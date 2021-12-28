﻿using System.Linq;
using osu.Framework.Graphics;
using osu.Game.Rulesets.Objects.Types;
using osu.Game.Rulesets.Sentakki.Objects.Drawables.Pieces.Slides;

namespace osu.Game.Rulesets.Sentakki.Objects.Drawables
{
    public class DrawableSlideTap : DrawableTap
    {
        protected override Drawable CreateTapRepresentation() => new SlideTapPiece();

        public DrawableSlideTap() : this(null) { }
        public DrawableSlideTap(SlideTap hitObject)
            : base(hitObject) { }

        protected override void OnApply()
        {
            base.OnApply();
            AccentColour.BindTo(ParentHitObject.AccentColour);
        }

        protected override void OnFree()
        {
            base.OnFree();
            AccentColour.UnbindFrom(ParentHitObject.AccentColour);
        }

        protected override void UpdateInitialTransforms()
        {
            base.UpdateInitialTransforms();

            var note = TapVisual as SlideTapPiece;

            double spinDuration = 0;

            if (ParentHitObject is DrawableSlide slide)
            {
                spinDuration = ((Slide)slide.HitObject).SlideInfoList.FirstOrDefault().Duration;
                if (slide.SlideBodies.Count > 1)
                    note.SecondStar.Alpha = 1;
                else
                    note.SecondStar.Alpha = 0;
            }
            else if (ParentHitObject is DrawableSlideFan fanSlide)
            {
                spinDuration = fanSlide.HitObject.Duration;
                note.SecondStar.Alpha = 0;
            }

            note.Stars.Spin(spinDuration, RotationDirection.Counterclockwise, 0).Loop();
        }
    }
}
