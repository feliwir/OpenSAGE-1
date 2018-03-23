using System;
using OpenSage.FFmpeg;

namespace OpenSage.Audio
{
    public sealed class AudioHandler : IAudioHandler
    {
        public AudioLayout Layout => AudioLayout.Interleaved;

        public int CreateBuffer(int frequency, int channels, long sampleRate)
        {
            throw new NotImplementedException();
        }

        public void UpdateBuffer(int buffer, IntPtr data, int size)
        {
            throw new NotImplementedException();
        }
    }
}
