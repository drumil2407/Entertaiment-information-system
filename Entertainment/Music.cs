using System;
using System.Media;


//use of background music using sound library

namespace Entertainment
{
    class Music
    {

        // this method is to play batman theme song 

        //this will play when user will be seeing batman dark knight information
        public void Play1()
        {

            //to check widow has sound player engine
            if (OperatingSystem.IsWindows())
            {

                SoundPlayer sound = new SoundPlayer("Warrior.wav");
                sound.Load();
                sound.Play();


            }
        }
        // this method is to play Warrior theme song 

        //this will play when user will be seeing warrior tvseries information
        public void Play2()
        {
            if (OperatingSystem.IsWindows())
            {

                SoundPlayer sound = new SoundPlayer("dark.wav");
                sound.Load();
                sound.Play();


            }
        }

    }
}
