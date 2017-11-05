﻿using System;
using VideoLAN.LibVLC;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new Instance(0, null);
            //var audiolist = instance.AudioFilterList;
            var au = instance.AudioFilters;

            var media = libvlc_media.LibvlcMediaNewLocation(instance,
                "http://www.quirksmode.org/html5/videos/big_buck_bunny.mp4");

            var mediaPlayer = libvlc_media_player.LibvlcMediaPlayerNewFromMedia(media);
            libvlc_media_player.LibvlcMediaPlayerPlay(mediaPlayer);

            Console.ReadKey();
        }
    }
}
