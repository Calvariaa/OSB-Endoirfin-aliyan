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
    public class BackGround : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    //Main
            string BackgroundPath = Beatmap.BackgroundPath;
            {
                var bitmap = GetMapsetBitmap(BackgroundPath);
                var bg = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.Centre);
                bg.Scale(14767, 480.0f / bitmap.Height);
                //
                bg.Fade(14767, 60544, 1, 1);
                bg.Fade(60544, 60989, 1, 0.2);
                bg.Fade(60989, 89433, 1, 1);
                


                //break
                bg.Fade(89433, 91211, 1, 0.8);
                bg.Fade(91211, 92544, 0.8, 0.2);
                bg.Fade(92544, 92989, 0.2, 0);
                bg.Fade(92989, 105211, 1, 1);

                //brehj 105211 105433 107211
                bg.Fade(105211, 105433, 1, 0);
                bg.Fade(105433, 107211, 0, 0);
                bg.Fade(107211, 120989, 1, 1);


                //breajk 60100 60544 120989 121433
                bg.Fade(120989, 121433, 1, 0.2);
                bg.Fade(121433, 135656, 0.2, 0.2);
                bg.Fade(135656, 190544, 1, 1);

                //break 190544
                bg.Fade(190544, 191433, 1, 0.6);
                bg.Fade(191433, 191544, 0.6, 0);
                bg.Fade(191544, 191878, 0, 0);
 
                //break 218767 218989 218989 219433
                bg.Fade(220989, 263433, 1, 1);

            }
            
            //高斯模糊
            string vaguePath = "sb/extra1.jpg";
            {
                var bitmap = GetMapsetBitmap(vaguePath);
                var vague = GetLayer("").CreateSprite(vaguePath, OsbOrigin.Centre);
                vague.Scale(433, 480.0f / bitmap.Height);
                vague.Fade(433, 544, 0, 1);
                vague.Fade(544, 14322, 1, 1);
                vague.Fade(14322, 14322, 0, 0);

                //asd
                vague.Fade(191878, 192544, 0, 1);
                vague.Fade(192544, 218989, 1, 1);
                vague.Fade(218989, 220989, 1, 0);

            }
            //whitemood
            string whitemoodPath = "sb/whitemood.png";
            {
                var bitmap = GetMapsetBitmap(whitemoodPath);
                var whitemood = GetLayer("").CreateSprite(whitemoodPath, OsbOrigin.Centre);
                whitemood.Scale(120989, 480.0f / bitmap.Height);
                whitemood.Fade(120989, 121433, 0, 1);
                whitemood.Fade(121433, 135211, 1, 1);
                whitemood.Fade(135211, 135656, 1, 0);

            }



            //黑色框框
            string maskPath = "sb/mask.png";
            {
                var bitmap = GetMapsetBitmap(maskPath);
                var mask = GetLayer("").CreateSprite(maskPath, OsbOrigin.Centre);
                mask.Scale(544, 480.0f / bitmap.Height);
                mask.Fade(544, 989, 0, 1);
                mask.Fade(7656, 8100, 0, 1);
                mask.Fade(11211, 11656, 0, 1);
                mask.Fade(13211, 14100, 1, 0.4);
                mask.Fade(14100, 14322, 0.4, 0);
                
                //2nd 192433 192989, 199656 201433 202989 204322 205656
                mask.Fade(192433, 192989, 0, 1);
                mask.Fade(192989, 217433, 1, 1);
                mask.Fade(217433, 218544, 1, 0.4);
                mask.Fade(218544, 218767, 0.4, 0);

            }
            
            string circlesbPath = "sb/circlesb.png";
            string circleswPath = "sb/circlesw.png";
            {
                var bitmap = GetMapsetBitmap(circlesbPath);

                //1 220100 220989
                var circlesw = GetLayer("").CreateSprite(circleswPath, OsbOrigin.Centre);
                circlesw.Fade(220100, 220989, 0.6, 0.6);
                circlesw.Scale(220100, 220544, 0 , 720.0f / bitmap.Height);
                circlesw.Scale(220544, 220989, 720.0f / bitmap.Height , 1080.0f / bitmap.Height);



                //2 220544 220989
                var circlesb = GetLayer("").CreateSprite(circlesbPath, OsbOrigin.Centre);
                //circlesb.Fade(220100, 220989, 0.6, 0.6);
                circlesb.Scale(220544, 220767, 0 , 480.0f / bitmap.Height);
                circlesb.Scale(220767, 220989, 480.0f / bitmap.Height , 1080.0f / bitmap.Height);
            }

            //white 39656 53878 100100 114322
            string whitePath = "sb/white.jpg";
            {
                var bitmap = GetMapsetBitmap(whitePath);
                var White = GetLayer("").CreateSprite(whitePath, OsbOrigin.Centre);
                White.Scale(14767, 480.0f / bitmap.Height);
                for(int i=14767;i<=263433;i++)
                {
                    if(i == 14767 || i == 32544 || i == 39656 || i == 46767 || i == 53878 || i == 60989 || i == 75211 ||
                     i == 92989 || i == 107211 || i == 100100 || i == 114322 || i == 135656 || i == 149878 || i == 164100 ||
                     i == 178322 || i == 220989 || i == 235211 || i == 249433  )
                    
                    White.Fade(OsbEasing.Out, i, i + 888, 0.8, 0);
                }
            }

            


        }
    }
}
