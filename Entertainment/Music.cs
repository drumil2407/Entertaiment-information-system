using System;
using System.Media;

namespace Entertainment
{
    class Music
    {
        public void Play1()
        {
            if (OperatingSystem.IsWindows())
            {

                SoundPlayer sound = new SoundPlayer("Warrior.wav");
                sound.Load();
                sound.Play();


            }
        }

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
