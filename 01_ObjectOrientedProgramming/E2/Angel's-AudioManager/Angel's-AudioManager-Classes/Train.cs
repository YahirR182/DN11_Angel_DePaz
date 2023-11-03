using System;
using NAudio.Wave;

namespace Angel_s_AudioManager_Classes
{
	public class Train : Vehicle
	{
        public override void VehicleSound()
        {
            Console.WriteLine("This is a train!");
            AudioFileReader audioFile = new AudioFileReader("Resources/Train.wav");
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

