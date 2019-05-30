﻿using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Unicord.Universal.Controls.Embeds
{
    public sealed partial class EmbedFieldControl : UserControl
    {
        private DiscordChannel _channel;

        public EmbedFieldControl(DiscordChannel channel, DiscordEmbedField field)
        {
            InitializeComponent();
            _channel = channel;
            DataContext = field;
        }
    }
}