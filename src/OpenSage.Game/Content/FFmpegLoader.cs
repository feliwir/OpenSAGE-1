using System;
using System.Collections.Generic;
using System.Text;
using OpenSage.Audio;
using OpenSage.Data;
using OpenSage.FFmpeg;

namespace OpenSage.Content
{
    internal sealed class FFmpegAudioLoader : ContentLoader<AudioStream>
    {
        protected override AudioStream LoadEntry(FileSystemEntry entry, ContentManager contentManager, Game game, LoadOptions loadOptions)
        {
            var handler = new AudioHandler();
            var source = new Source(entry.Open(),null,handler);           

            return new AudioStream(source);
        }
    }
}
