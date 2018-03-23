using System;
using System.Collections.Generic;
using System.Text;
using OpenSage.Audio;
using OpenSage.Data;
using OpenSage.DataViewer.Controls;

namespace OpenSage.DataViewer.UI.Viewers
{
    public sealed class Mp3View : GameControl
    {
        AudioStream _stream;
        Game _game;

        public Mp3View(FileSystemEntry entry, Func<IntPtr, Game> createGame)
        {
            CreateGame = h =>
            {
                _game = createGame(h);

                var source = _game.Audio.PlayStream(entry.FilePath, true);

                return _game;
            };
        }
    }
}
