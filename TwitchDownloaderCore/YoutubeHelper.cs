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
        private static HttpClient httpClient;
        private static Dictionary<string, SKBitmap> emojiCache;
        private static string emojiFolder;

        public static Dictionary<string, SKBitmap> GetYoutubeEmojis(string cacheFolder)
        {
            emojiCache = new Dictionary<string, SKBitmap>();
            emojiFolder = Path.Combine(cacheFolder, "youtubeEmojis");

            if (!Directory.Exists(emojiFolder))
                Directory.CreateDirectory(emojiFolder);

            httpClient = new HttpClient();

            // Do manually for now, not that many youtube exclusive emotes
            // Youtube emotes
            CreateEmote("yt", "https://yt3.ggpht.com/m6yqTzfmHlsoKKEZRSZCkqf6cGSeHtStY4rIeeXLAk4N9GY_yw3dizdZoxTrjLhlY4r_rkz3GA=w72-h72-c-k-nd");
            CreateEmote("oops", "https://yt3.ggpht.com/qByNS7xmuQXsb_5hxW2ggxwQZRN8-biWVnnKuL5FK1zudxIeim48zRVPk6DRq_HgaeKltHhm=w72-h72-c-k-nd");
            CreateEmote("buffering", "https://yt3.ggpht.com/foWgzjN0ggMAA0CzDPfPZGyuGwv_7D7Nf6FGLAiomW5RRXj0Fs2lDqs2U6L52Z4J2Zb-D5tCUAA=w72-h72-c-k-nd");
            CreateEmote("stayhome", "https://yt3.ggpht.com/u3QDxda8o4jrk_b01YtJYKb57l8Zw8ks8mCwGkiZ5hC5cQP_iszbsggxIWquZhuLRBzl5IEM2w=w72-h72-c-k-nd");
            CreateEmote("dothefive", "https://yt3.ggpht.com/ktU04FFgK_a6yaXCS1US-ReFkLjD22XllcIMOyBRHuYKLsrxpVxsauV1gSC2RPraMJWXpWcY=w72-h72-c-k-nd");
            CreateEmote("elbowbump", "https://yt3.ggpht.com/gt39CIfizoIAce9a8IzjfrADV5CjTbSyFKUlLMXzYILxJRjwAgYQQJ9PXXxnRvrnTec7ZpfHN4k=w72-h72-c-k-nd");
            CreateEmote("goodvibes", "https://yt3.ggpht.com/6LPOiCw9bYr3ZXe8AhUoIMpDe_0BglC4mBmi-uC4kLDqDIuPu4J3ErgV0lEhgzXiBluq-I8j=w72-h72-c-k-nd");
            CreateEmote("thanksdoc", "https://yt3.ggpht.com/Av7Vf8FxIp0_dQg4cJrPcGmmL7v9RXraOXMp0ZBDN693ewoMTHbbS7D7V3GXpbtZPSNcRLHTQw=w72-h72-c-k-nd");
            CreateEmote("videocall", "https://yt3.ggpht.com/bP-4yir3xZBWh-NKO4eGJJglr8m4dRnHrAKAXikaOJ0E5YFNkJ6IyAz3YhHMyukQ1kJNgQAo=w72-h72-c-k-nd");
            CreateEmote("virtualhug", "https://yt3.ggpht.com/-o0Di2mE5oaqf_lb_RI3igd0fptmldMWF9kyQpqKWkdAd7M4cT5ZKzDwlmSSXdcBp3zVLJ41yg=w72-h72-c-k-nd");
            CreateEmote("yougotthis", "https://yt3.ggpht.com/WxLUGtJzyLd4dcGaWnmcQnw9lTu9BW3_pEuCp6kcM2pxF5p5J28PvcYIXWh6uCm78LxGJVGn9g=w72-h72-c-k-nd");
            CreateEmote("sanitizer", "https://yt3.ggpht.com/4PaPj_5jR1lkidYakZ4EkxVqNr0Eqp4g0xvlYt_gZqjTtVeyHBszqf57nB9s6uLh7d2QtEhEWEc=w72-h72-c-k-nd");
            CreateEmote("takeout", "https://yt3.ggpht.com/ehUiXdRyvel0hba-BopQoDWTvM9ogZcMPaaAeR6IA9wkocdG21aFVN_IylxRGHtl2mE6L9jg1Do=w72-h72-c-k-nd");
            CreateEmote("hydrate", "https://yt3.ggpht.com/Plqt3RM7NBy-R_eA90cIjzMEzo8guwE0KqJ9QBeCkPEWO7FvUqKU_Vq03Lmv9XxMrG6A3Ouwpg=w72-h72-c-k-nd");
            CreateEmote("chillwcat", "https://yt3.ggpht.com/ZN5h05TnuFQmbzgGvIfk3bgrV-_Wp8bAbecOqw92s2isI6GLHbYjTyZjcqf0rKQ5t4jBtlumzw=w72-h72-c-k-nd");
            CreateEmote("chillwdog", "https://yt3.ggpht.com/jiaOCnfLX0rqed1sISxULaO7T-ktq2GEPizX9snaxvMLxQOMmWXMmAVGyIbYeFS2IvrMpxvFcQ=w72-h72-c-k-nd");
            CreateEmote("elbowcough", "https://yt3.ggpht.com/kWObU3wBMdHS43q6-ib2KJ-iC5tWqe7QcEITaNApbXEZfrik9E57_ve_BEPHO86z4Xrv8ikMdW0=w72-h72-c-k-nd");
            CreateEmote("learning", "https://yt3.ggpht.com/LiS1vw8KUXmczimKGfA-toRYXOcV1o-9aGSNRF0dGLk15Da2KTAsU-DXkIao-S7-kCkSnJwt=w72-h72-c-k-nd");
            CreateEmote("washhands", "https://yt3.ggpht.com/66Fn-0wiOmLDkoKk4FSa9vD0yymtWEulbbQK2x-kTBswQ2auer_2ftvmrJGyMMoqEGNjJtipBA=w72-h72-c-k-nd");
            CreateEmote("socialdist", "https://yt3.ggpht.com/0WD780vTqUcS0pFq423D8WRuA_T8NKdTbRztChITI9jgOqOxD2r6dthbu86P6fIggDR6omAPfnQ=w72-h72-c-k-nd");
            CreateEmote("shelterin", "https://yt3.ggpht.com/KgaktgJ3tmEFB-gMtjUcuHd6UKq50b-S3PbHEOSUbJG7UddPoJSmrIzysXA77jJp5oRNLWG84Q=w72-h72-c-k-nd");


            // TODO: make config file if these change frequently or find a way to pull channel specific emotes
            // For AS -- custom emotes
            CreateEmote("KEKW", "https://yt3.ggpht.com/esoGqAaottY7m4u3Ys8Y46RVjF8gtZAR6VCwquY-ftb7ojJyK51mv85ImjEZCYjHVmFr-VGL0w=w72-h72-c-k-nd");
            CreateEmote("monkaS", "https://yt3.ggpht.com/pu-XuTfpIWV8ebw8zGAwFG02WAJf8_sRsfKJeKuvaU7sMQtVYq76hbDq9u-58zS5PPxCagN6=w72-h72-c-k-nd");
            CreateEmote("Pepega", "https://yt3.ggpht.com/IIpPg-5chFCZz_E1778CTgCSgSUFp8Jv9HwV4S2tKy7cyLAHbA4wuSbdk5FS8QG8lXxRCqqxHA=w72-h72-c-k-nd");
            CreateEmote("PepeLaugh", "https://yt3.ggpht.com/Ax32WWS19mID48CvVNB499HXy6P3W_zzf5Qxbmlb5Xkbh9QJeQKxn6mEJpOED_YmG5vkDRAMIg=w72-h72-c-k-nd");
            CreateEmote("PogU", "https://yt3.ggpht.com/ObA7yPmbPqAaszy64RYAGXPDw8i2IMV9rOSGNwOi-tLHU_iiDs6P5yHH5b31c88EF3c0rhNV34c=w72-h72-c-k-nd");
            CreateEmote("Sadge", "https://yt3.ggpht.com/WckzVC2Vch9prnjmJt-9Za2tszyhSoxtTcE1Q2Tf5QeTXknD_aIdBBzHnMSOLKhsbsw1oqORWhg=w72-h72-c-k-nd");
            CreateEmote("PauseChamp", "https://yt3.ggpht.com/ogn1G4usuiLGNHLvF3I-p13nEDtztMxfsy8WhqSLmHWbYqf3HnDCcMlSTqU5zmjwy9W6eeR7y5M=w72-h72-c-k-nd");
            CreateEmote("3Head", "https://yt3.ggpht.com/gcI2QTNdREJsOstGDoJyUqVIoG1GqNdnUwpSq9yIFyD1mT7EsLiauRNjLQguCiDuxuaRGdOb=w72-h72-c-k-nd");
            CreateEmote("PogO", "https://yt3.ggpht.com/Ke6M03bMh4P75k4yj_tpRQpjScDgFE_-PtCrBA7XelOqk6ZcOIWCxbSc4sBb8OYs2CP1KsrH=w72-h72-c-k-nd");
            CreateEmote("5Head", "https://yt3.ggpht.com/-5yb-CjjFl6EG2-7ovZYn3hFdyVHtdQ9NJAHBmvfi216aSwuJilpE9-akronchMYqdR8hT2d=w72-h72-c-k-nd");
            CreateEmote("Prayge", "https://yt3.ggpht.com/Cu5jJwki4I95q7Liy5TD4UwJb-1ztB3S3JjeJ6u2Wj4JO7xr29aoqbQ7jPJI1-T0DKzqprHN=w72-h72-c-k-nd");
            CreateEmote("Okayge", "https://yt3.ggpht.com/OLXjqgPYl1cIUrrgbgkj2_nfK57k6nfLWqDqAFsHfKPp_R-ANey4MlSInwhr6RFveNjVydCeWw=w72-h72-c-k-nd");
            CreateEmote("Henry", "https://yt3.ggpht.com/DJ3mvv3fh4FKWReGWD-mxsbPF6LpDIQvrWyeGbSINhA8VmlKnEbjOU1RnucKPdKWklASNdT7CA=w72-h72-c-k-nd");
            CreateEmote("EZY", "https://yt3.ggpht.com/66AM07rIHLfrITEfaujEaQTXWGY36szdWCFK7UF26lAxNtvtRVOBhwxwEwoLS28OHyFoed-x=w72-h72-c-k-nd");
            CreateEmote("WeirdChamp", "https://yt3.ggpht.com/OIb8Je_KKD5wBdTNxCFiK8VnFtJzffYP3gVxafctgqsuHw3D1g5hyShMbf295qlIPH4b4OKnrog=w72-h72-c-k-nd");
            CreateEmote("BOOBA", "https://yt3.ggpht.com/VU-TAgtvBbPotNapZINBG3ogeqUVG4ZeL0qLu_AALfz8aZuFCGlVjshvCOrvJ2meQ4oOaChqOQ=w72-h72-c-k-nd");
            CreateEmote("ratJAM", "https://yt3.ggpht.com/PYqY7U1xRHT5zRMVKRYbYzBasuNcdHBPAiF_YwubJjh4bXQvh0l5VlMMXRaoWpHsdmaeVUFPSlA=w72-h72-c-k-nd");
            CreateEmote("Pog", "https://yt3.ggpht.com/4p-3kwkkIScoQltXvYDUCP-wIPmrExrN_zs0HnTYt3B84KG86T6uXTU9or9jdnDXW0DOJfM_ag=w72-h72-c-k-nd");
            CreateEmote("grossC", "https://yt3.ggpht.com/cDhj03llDpBtZAw-T1Kbu_RTfwYlam-2ZBo7TM46B9_hqgjcGNBN3gyjPhcSY9eyBTXErESDeg=w72-h72-c-k-nd");
            CreateEmote("YEP", "https://yt3.ggpht.com/FxvcWSS3nd4_iYqfkwieSxZ6rdEdGP6_E3D0hMFpaNh2XODMCoaDhpcBKKgPqa2jaYTn5teYNw=w72-h72-c-k-nd");
            CreateEmote("FEELS", "https://yt3.ggpht.com/aQmyHIVABvgS8Qq5Z4cS_XWIBXtyCtjm40baJaUjGwT6hl1FWVV2bi9KfW9cac08v3b4IY5gNg=w72-h72-c-k-nd");
            CreateEmote("HEY", "https://yt3.ggpht.com/QdWcQfODOXxgrWa2KOohPbiy3cMabKkKnlaZvPgYaH_yXpPtJ121x1gRtFWFpdOqs2m1gtbHlg=w72-h72-c-k-nd");

            return emojiCache;
        }

        private static void CreateEmote(String emoteName, String emoteLink)
        {
            SKBitmap newBitmap;

            if (File.Exists(emojiFolder + @"\" + emoteName + ".png"))
            {
                newBitmap = SKBitmap.Decode(File.ReadAllBytes(emojiFolder + @"\" + emoteName + ".png"));
            }
            else
            {
                var bytes = httpClient.GetByteArrayAsync(emoteLink);
                newBitmap = SKBitmap.Decode(bytes.Result);
                File.WriteAllBytes(emojiFolder + @"\" + emoteName + ".png", bytes.Result);
            }

            emojiCache.Add(":" + emoteName + ":", newBitmap);

            // Check if we need to add a _ TODO: only do this for channel specific emotes
            if(!emoteName[0].Equals("_"))
            {
                emojiCache.Add(":_" + emoteName + ":", newBitmap);
            }
        }
    }
}
