using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Sotarks : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    string  CirclesPath = "sb/circlesw.png";
            {
                var bitmap = GetMapsetBitmap(CirclesPath);
                var Circles = GetLayer("").CreateSprite(CirclesPath, OsbOrigin.Centre);
                Circles.Scale(105433, 120.0f / bitmap.Height);
                Circles.Color(105433, 106433, 0.5, 0.5, 0.8, 0.5, 0.5, 0.8);
                Circles.Move(105433, 106433, new Vector2(320, 180) ,new Vector2(320, 180));
                Circles.Fade(105433, 105656, 0, 1);
                Circles.Fade(105656, 105767, 1, 1);
                Circles.Fade(105767, 105878, 1, 0);

            }
            {
                var bitmap = GetMapsetBitmap(CirclesPath);
                var Circles = GetLayer("").CreateSprite(CirclesPath, OsbOrigin.Centre);
                Circles.Scale(105767, 120.0f / bitmap.Height);
                Circles.Color(105767, 106433, 0.5, 0.8, 0.5, 0.5, 0.8, 0.5);
                Circles.Move(105767, 106433, new Vector2(160, 180) ,new Vector2(160, 180));
                Circles.Fade(105767, 105989, 0, 1);
                Circles.Fade(105989, 106100, 1, 1);
                Circles.Fade(106100, 106211, 1, 0);

            }
            {
                var bitmap = GetMapsetBitmap(CirclesPath);
                var Circles = GetLayer("").CreateSprite(CirclesPath, OsbOrigin.Centre);
                Circles.Scale(106100, 120.0f / bitmap.Height);
                Circles.Color(106100, 106433, 0.8, 0.5, 0.5, 0.8, 0.5, 0.5);
                Circles.Move(106100, 106433, new Vector2(480, 180) ,new Vector2(480, 180));
                Circles.Fade(106100, 106322, 0, 1);
                Circles.Fade(106322, 106433, 1, 1);
                Circles.Fade(106433, 106544, 1, 0);

            }
            string whitePath = "sb/white.jpg";
            {
                var bitmap = GetMapsetBitmap(whitePath);
                var White = GetLayer("").CreateSprite(whitePath, OsbOrigin.Centre);
                White.Scale(14767, 480.0f / bitmap.Height);
                White.Fade(OsbEasing.Out, 106433, 107211, 0, 1);
                
            }
            
        }
    }
}
