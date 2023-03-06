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
    public class Title : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    //title
            string titlePath = "sb/title.png";
            string title21Path = "sb/title21.png";
            string title22Path = "sb/title22.png";
            string logoPath = "sb/logo.png";
            string logo2Path = "sb/logo2.png";
            {
                //1
                var bitmap = GetMapsetBitmap(titlePath);
                var title = GetLayer("").CreateSprite(titlePath, OsbOrigin.Centre);
                title.Scale(7656, 200.0f / bitmap.Height);
                title.Fade(OsbEasing.Out, 7656, 9100, 1, 1);
                title.Fade(OsbEasing.Out, 9100, 9322, 1, 0);

                //2
                string diffname = Beatmap.Name;
                Log(diffname);
                if(diffname == "Sakura")
                {
                    var title21 = GetLayer("").CreateSprite(title21Path, OsbOrigin.Centre);
                    title21.Scale(9433, 144.0f / bitmap.Height);
                    title21.Fade(OsbEasing.Out, 9433, 10878, 1, 1);
                    title21.Fade(OsbEasing.Out, 10878, 11100, 1, 0);

                }
                if(diffname == "Madoka's Hard")
                {
                    var title22 = GetLayer("").CreateSprite(title22Path, OsbOrigin.Centre);
                    title22.Scale(9433, 144.0f / bitmap.Height);
                    title22.Fade(OsbEasing.Out, 9433, 10878, 1, 1);
                    title22.Fade(OsbEasing.Out, 10878, 11100, 1, 0);

                }

                //logo
                var bitmaplogo = GetMapsetBitmap(logoPath);
                var logo = GetLayer("").CreateSprite(logoPath, OsbOrigin.Centre);
                logo.Scale(11211, 72.0f / bitmaplogo.Height);
                logo.Fade(OsbEasing.Out, 11211, 14322, 1, 1);

                //logo2
                var logo2 = GetLayer("").CreateSprite(logo2Path, OsbOrigin.Centre);
                logo2.Scale(14322, 72.0f / bitmaplogo.Height);
                logo2.Fade(OsbEasing.Out, 14322, 14767, 1, 1);
                logo2.Fade(OsbEasing.Out, 14767, 263433, 0, 0);
                logo2.Fade(OsbEasing.Out, 263433, 265656, 1, 0);
            }
            
        }
    }
}
