using System.Collections.Generic;

namespace OpenSage.Gui.Apt.ActionScript
{
    public sealed class Property
    {
        /// <summary>
        /// See SWF specification https://www.mobilefish.com/download/flash/swf_file_format_spec_v9.pdf
        /// page 103
        /// </summary>
        public enum Type
        {
            X = 0,
            Y,
            XScale,
            YScale,
            CurrentFrame,
            TotalFrames,
            Alpha,
            Visible,
            Width,
            Height,
            Rotation,
            Target,
            FramesLoaded,
            Name,
            DropTarget,
            Url,
            HighQuality,
            FocusRect,
            SoundBufTime,
            Quality,
            XMouse,
            YMouse,
            Size
            //TODO add rest
        }

        public static readonly Dictionary<string, Type> StringMapping = new Dictionary<string, Type>()
        {
            { "_X",         Type.X},
            { "_Y",         Type.Y},
            { "_xscale",    Type.XScale},
            { "_yscale",    Type.YScale},
            //TODO: add more
            { "_name",      Type.Name},
        };


        /// <summary>
        /// properties exclusive to textfields
        /// </summary>
        public enum TextPropertyType
        {
            TextColor
        }
    }
}
