using System;
using NAudio.Wave;

namespace AudioManager
{
    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("I'm a dog!");
            AudioFileReader audioFileReader = new AudioFileReader("Resources/dog.wav");
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

