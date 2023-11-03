using System;
using NAudio.Wave;

namespace AudioManager
{
    public class Pig : Animal
	{
        public override void AnimalSound()
        {
            Console.WriteLine("I'm a pig!");
            AudioFileReader audioFileReader = new AudioFileReader("Resources/pig.wav");
            WaveOutEvent waveOutEvent = new WaveOutEvent();

            waveOutEvent.Init(audioFileReader);
            waveOutEvent.Play();
            while (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);
            }
            waveOutEvent.Dispose();
            audioFileReader.Dispose();
        }
    }
}

