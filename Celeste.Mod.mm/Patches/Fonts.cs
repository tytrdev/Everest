﻿#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it

using Celeste.Mod;
using Celeste.Mod.Meta;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Monocle;
using MonoMod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Celeste {
    static class patch_Fonts {

        public static extern PixelFont orig_Load(string face);
        public static PixelFont Load(string face) {
            PixelFont font = orig_Load(face);
            Emoji.Fill(font);
            return font;
        }

    }
}
