using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cue
{
    class AudioFile
    {

        public string Name;
        public readonly bool IsLoaded;

        private string Filepath;

        private IWavePlayer OutputDevice;
        private AudioFileReader InputFile;

        public AudioFile(string name, string filepath, bool loadOnInit, IWavePlayer outDevice)
        {
            Name = name;
            Filepath = filepath;
            IsLoaded = false;
            OutputDevice = outDevice;
            if (loadOnInit)
            {
                Load();
            }
        }

        public async void Load()
        {
            if (!IsLoaded)
            {
                //InputFile = new AudioFileReader(Filepath);
            }
        }
    }
}
