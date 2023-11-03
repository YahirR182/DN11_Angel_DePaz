using System;
using NAudio.Wave;

namespace Angel_s_AudioManager_Classes
{
	public class Car : Vehicle
    {
        public override void VehicleSound()
        {
            Console.WriteLine("This is a car!");
            AudioFileReader audioFile = new AudioFileReader("Resources/Car.wav");
            WaveOutEvent waveOutEvent = new WaveOutEvent();

            waveOutEvent.Init(audioFile);
            waveOutEvent.Play();
            while (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);
            }
            waveOutEvent.Dispose();
            audioFile.Dispose();
        }
    }
}

