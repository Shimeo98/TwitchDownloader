using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace TwitchDownloaderCore
{
    class YoutubeHelper
    {
        public static Dictionary<string, SKBitmap> GetYoutubeEmojis(string cacheFolder)
        {
            Dictionary<string, SKBitmap> emojiCache = new Dictionary<string, SKBitmap>();

            string emojiFolder = Path.Combine(cacheFolder, "youtubeEmojis");

            if (!Directory.Exists(emojiFolder))
                Directory.CreateDirectory(emojiFolder);

            HttpClient httpClient = new HttpClient();

            // Do manually for now, not that many youtube exclusive emotes
            
            SKBitmap ytEmoji;
            if (File.Exists(emojiFolder + @"\yt.png"))
            {
                ytEmoji = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\yt.png"));
            }  
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/m6yqTzfmHlsoKKEZRSZCkqf6cGSeHtStY4rIeeXLAk4N9GY_yw3dizdZoxTrjLhlY4r_rkz3GA=w72-h72-c-k-nd");
                ytEmoji = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\yt.png", bytes.Result);
            }
            emojiCache.Add(":yt:", ytEmoji);

            SKBitmap oopsEmoji;
            if (File.Exists(emojiFolder + @"\oops.png"))
            {
                oopsEmoji = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\oops.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/qByNS7xmuQXsb_5hxW2ggxwQZRN8-biWVnnKuL5FK1zudxIeim48zRVPk6DRq_HgaeKltHhm=w72-h72-c-k-nd");
                oopsEmoji = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\oops.png", bytes.Result);
            }
            emojiCache.Add(":oops:", oopsEmoji);

            SKBitmap bufferingEmoji;
            if (File.Exists(emojiFolder + @"\buffering.png"))
            {
                bufferingEmoji = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\buffering.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/foWgzjN0ggMAA0CzDPfPZGyuGwv_7D7Nf6FGLAiomW5RRXj0Fs2lDqs2U6L52Z4J2Zb-D5tCUAA=w72-h72-c-k-nd");
                bufferingEmoji = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\buffering.png", bytes.Result);
            }
            emojiCache.Add(":buffering:", bufferingEmoji);

            SKBitmap stayHomeEmoji;
            if (File.Exists(emojiFolder + @"\stayHome.png"))
            {
                stayHomeEmoji = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\stayHome.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/u3QDxda8o4jrk_b01YtJYKb57l8Zw8ks8mCwGkiZ5hC5cQP_iszbsggxIWquZhuLRBzl5IEM2w=w72-h72-c-k-nd");
                stayHomeEmoji = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\stayHome.png", bytes.Result);
            }
            emojiCache.Add(":stayhome:", stayHomeEmoji);

            SKBitmap doTheFiveEmoji;
            if (File.Exists(emojiFolder + @"\doTheFive.png"))
            {
                doTheFiveEmoji = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\doTheFive.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/ktU04FFgK_a6yaXCS1US-ReFkLjD22XllcIMOyBRHuYKLsrxpVxsauV1gSC2RPraMJWXpWcY=w72-h72-c-k-nd");
                doTheFiveEmoji = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\doTheFive.png", bytes.Result);
            }
            emojiCache.Add(":dothefive:", doTheFiveEmoji);

            SKBitmap elbowbump;//
            if (File.Exists(emojiFolder + @"\elbowbump.png"))
            {
                elbowbump = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\elbowbump.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/gt39CIfizoIAce9a8IzjfrADV5CjTbSyFKUlLMXzYILxJRjwAgYQQJ9PXXxnRvrnTec7ZpfHN4k=w72-h72-c-k-nd");
                elbowbump = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\elbowbump.png", bytes.Result);
            }
            emojiCache.Add(":elbowbump:", elbowbump);

            SKBitmap goodvibes;//
            if (File.Exists(emojiFolder + @"\goodvibes.png"))
            {
                goodvibes = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\goodvibes.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/6LPOiCw9bYr3ZXe8AhUoIMpDe_0BglC4mBmi-uC4kLDqDIuPu4J3ErgV0lEhgzXiBluq-I8j=w72-h72-c-k-nd");
                goodvibes = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\goodvibes.png", bytes.Result);
            }
            emojiCache.Add(":goodvibes:", goodvibes);

            SKBitmap thanksdoc;//
            if (File.Exists(emojiFolder + @"\thanksdoc.png"))
            {
                thanksdoc = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\thanksdoc.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/Av7Vf8FxIp0_dQg4cJrPcGmmL7v9RXraOXMp0ZBDN693ewoMTHbbS7D7V3GXpbtZPSNcRLHTQw=w72-h72-c-k-nd");
                thanksdoc = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\thanksdoc.png", bytes.Result);
            }
            emojiCache.Add(":thanksdoc:", thanksdoc);

            SKBitmap videocall;//
            if (File.Exists(emojiFolder + @"\videocall.png"))
            {
                videocall = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\videocall.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/bP-4yir3xZBWh-NKO4eGJJglr8m4dRnHrAKAXikaOJ0E5YFNkJ6IyAz3YhHMyukQ1kJNgQAo=w72-h72-c-k-nd");
                videocall = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\videocall.png", bytes.Result);
            }
            emojiCache.Add(":videocall:", videocall);

            SKBitmap virtualhug;//
            if (File.Exists(emojiFolder + @"\virtualhug.png"))
            {
                virtualhug = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\virtualhug.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/-o0Di2mE5oaqf_lb_RI3igd0fptmldMWF9kyQpqKWkdAd7M4cT5ZKzDwlmSSXdcBp3zVLJ41yg=w72-h72-c-k-nd");
                virtualhug = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\virtualhug.png", bytes.Result);
            }
            emojiCache.Add(":virtualhug:", virtualhug);

            SKBitmap yougotthis;//
            if (File.Exists(emojiFolder + @"\yougotthis.png"))
            {
                yougotthis = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\yougotthis.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/WxLUGtJzyLd4dcGaWnmcQnw9lTu9BW3_pEuCp6kcM2pxF5p5J28PvcYIXWh6uCm78LxGJVGn9g=w72-h72-c-k-nd");
                yougotthis = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\yougotthis.png", bytes.Result);
            }
            emojiCache.Add(":yougotthis:", yougotthis);

            SKBitmap sanitizer;//
            if (File.Exists(emojiFolder + @"\sanitizer.png"))
            {
                sanitizer = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\sanitizer.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/4PaPj_5jR1lkidYakZ4EkxVqNr0Eqp4g0xvlYt_gZqjTtVeyHBszqf57nB9s6uLh7d2QtEhEWEc=w72-h72-c-k-nd");
                sanitizer = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\sanitizer.png", bytes.Result);
            }
            emojiCache.Add(":sanitizer:", sanitizer);

            SKBitmap takeout;//
            if (File.Exists(emojiFolder + @"\takeout.png"))
            {
                takeout = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\takeout.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/ehUiXdRyvel0hba-BopQoDWTvM9ogZcMPaaAeR6IA9wkocdG21aFVN_IylxRGHtl2mE6L9jg1Do=w72-h72-c-k-nd");
                takeout = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\takeout.png", bytes.Result);
            }
            emojiCache.Add(":takeout:", takeout);

            SKBitmap hydrate;//
            if (File.Exists(emojiFolder + @"\hydrate.png"))
            {
                hydrate = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\hydrate.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/Plqt3RM7NBy-R_eA90cIjzMEzo8guwE0KqJ9QBeCkPEWO7FvUqKU_Vq03Lmv9XxMrG6A3Ouwpg=w72-h72-c-k-nd");
                hydrate = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\hydrate.png", bytes.Result);
            }
            emojiCache.Add(":hydrate:", hydrate);

            SKBitmap chillwcat;//
            if (File.Exists(emojiFolder + @"\chillwcat.png"))
            {
                chillwcat = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\chillwcat.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/ZN5h05TnuFQmbzgGvIfk3bgrV-_Wp8bAbecOqw92s2isI6GLHbYjTyZjcqf0rKQ5t4jBtlumzw=w72-h72-c-k-nd");
                chillwcat = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\chillwcat.png", bytes.Result);
            }
            emojiCache.Add(":chillwcat:", doTheFiveEmoji);

            SKBitmap chillwdog;//
            if (File.Exists(emojiFolder + @"\chillwdog.png"))
            {
                chillwdog = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\chillwdog.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/jiaOCnfLX0rqed1sISxULaO7T-ktq2GEPizX9snaxvMLxQOMmWXMmAVGyIbYeFS2IvrMpxvFcQ=w72-h72-c-k-nd");
                chillwdog = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\chillwdog.png", bytes.Result);
            }
            emojiCache.Add(":chillwdog:", chillwdog);

            SKBitmap elbowcough;//
            if (File.Exists(emojiFolder + @"\elbowcough.png"))
            {
                elbowcough = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\elbowcough.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/kWObU3wBMdHS43q6-ib2KJ-iC5tWqe7QcEITaNApbXEZfrik9E57_ve_BEPHO86z4Xrv8ikMdW0=w72-h72-c-k-nd");
                elbowcough = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\elbowcough.png", bytes.Result);
            }
            emojiCache.Add(":elbowcough:", elbowcough);

            SKBitmap learning;//
            if (File.Exists(emojiFolder + @"\learning.png"))
            {
                learning = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\learning.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/LiS1vw8KUXmczimKGfA-toRYXOcV1o-9aGSNRF0dGLk15Da2KTAsU-DXkIao-S7-kCkSnJwt=w72-h72-c-k-nd");
                learning = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\learning.png", bytes.Result);
            }
            emojiCache.Add(":learning:", learning);

            SKBitmap washhands;//
            if (File.Exists(emojiFolder + @"\washhands.png"))
            {
                washhands = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\washhands.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/66Fn-0wiOmLDkoKk4FSa9vD0yymtWEulbbQK2x-kTBswQ2auer_2ftvmrJGyMMoqEGNjJtipBA=w72-h72-c-k-nd");
                washhands = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\washhands.png", bytes.Result);
            }
            emojiCache.Add(":washhands:", washhands);

            SKBitmap socialdist;//
            if (File.Exists(emojiFolder + @"\socialdist.png"))
            {
                socialdist = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\socialdist.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/0WD780vTqUcS0pFq423D8WRuA_T8NKdTbRztChITI9jgOqOxD2r6dthbu86P6fIggDR6omAPfnQ=w72-h72-c-k-nd");
                socialdist = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\socialdist.png", bytes.Result);
            }
            emojiCache.Add(":socialdist:", socialdist);

            SKBitmap shelterin;//
            if (File.Exists(emojiFolder + @"\shelterin.png"))
            {
                shelterin = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\shelterin.png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync("https://yt3.ggpht.com/KgaktgJ3tmEFB-gMtjUcuHd6UKq50b-S3PbHEOSUbJG7UddPoJSmrIzysXA77jJp5oRNLWG84Q=w72-h72-c-k-nd");
                shelterin = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\shelterin.png", bytes.Result);
            }
            emojiCache.Add(":shelterin:", shelterin);

            return emojiCache;
        }
    }
}
