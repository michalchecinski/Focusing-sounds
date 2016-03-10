using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Focusing_sounds
{
    class Player
    {
        System.Media.SoundPlayer player = new SoundPlayer();



        public void play_sound(string sound)
        {
            player.Stop();

            switch (sound)
            {
                case "ocean":
                    player.SoundLocation = "Crisp_Ocean_Waves-Mike_Koenig-1486046376.wav";
                    break;
                case "cafe":
                    player.SoundLocation = "Restaurant Ambiance -SoundBible.com-628640170.wav";
                    break;
                case "rain":
                    player.SoundLocation = "Rain_Background-Mike_Koenig-1681389445.wav";
                    break;
            }
           
            player.PlayLooping();
        }

        public void Stop()
        {
            player.Stop();
        }

    }
}
