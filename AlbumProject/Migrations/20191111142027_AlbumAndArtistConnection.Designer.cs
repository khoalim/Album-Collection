﻿// <auto-generated />
using AlbumProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumProject.Migrations
{
    [DbContext(typeof(ArtistContext))]
    [Migration("20191111142027_AlbumAndArtistConnection")]
    partial class AlbumAndArtistConnection
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumProject.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId");

                    b.Property<string>("ArtistName");

                    b.Property<string>("Image");

                    b.Property<string>("Label");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums");

                    b.HasData(
                        new { Id = 1, ArtistId = 1, Image = "/images/MotM1.jpg", Label = "Universal Records", Title = "Man On The Moon" },
                        new { Id = 2, ArtistId = 1, Image = "/images/MotM2.jpg", Label = "Universal Motown Records", Title = "Man On The Moon 2" },
                        new { Id = 3, ArtistId = 1, Image = "/images/Indicud.jpg", Label = "Republic Records", Title = "Indicud" },
                        new { Id = 4, ArtistId = 1, Image = "/images/satellite.jpg", Label = "Kid Cudi P/S", Title = "Satellite Flight: The Journey to Mother Moon" },
                        new { Id = 5, ArtistId = 1, Image = "/images/SB2H.jpg", Label = "Republic Records", Title = "Speedin' Bullet 2 Heaven" },
                        new { Id = 6, ArtistId = 1, Image = "/images/PP&DS.jpg", Label = "Republic Records", Title = "Passion, Pain & Demon Slayin" },
                        new { Id = 7, ArtistId = 2, Image = "/images/nightvisions.jpg", Label = " Kidinakorner and Interscope Records", Title = "Night Visions" },
                        new { Id = 8, ArtistId = 2, Image = "/images/smokemirrors_720.jpg", Label = " Kidinakorner and Interscope Records", Title = "Smoke + Mirrors" },
                        new { Id = 9, ArtistId = 2, Image = "/images/evolve.jpg", Label = " Kidinakorner and Interscope Records", Title = "Evolve" },
                        new { Id = 10, ArtistId = 2, Image = "/images/origins.jfif", Label = " Kidinakorner and Interscope Records", Title = "Origins" },
                        new { Id = 11, ArtistId = 3, Image = "/images/The-Division-Bell.jpg", Label = "EMI Records", Title = "The Division Bell" },
                        new { Id = 12, ArtistId = 3, Image = "/images/Atom-Heart-Mother.jpg", Label = "Harvest Records", Title = "Atom Heart Mother" },
                        new { Id = 13, ArtistId = 3, Image = "/images/The-Final-Cut.jpg", Label = "Harvest Records", Title = "The Final Cut" },
                        new { Id = 14, ArtistId = 3, Image = "/images/dark-side-of-moon.jpg", Label = "Harvest Records", Title = "The Dark Side of the Moon" },
                        new { Id = 15, ArtistId = 4, Image = "/images/songsinaminor.jpg", Label = "J", Title = "Songs in A Minor" },
                        new { Id = 16, ArtistId = 4, Image = "/images/diaryofakeys.jpg", Label = "J", Title = "The Diary of Alicia Keys" },
                        new { Id = 17, ArtistId = 4, Image = "/images/asiam.png", Label = "J", Title = "As I Am" },
                        new { Id = 18, ArtistId = 4, Image = "/images/elementoffreedom.png", Label = "J", Title = "The Element of Freedom" },
                        new { Id = 19, ArtistId = 4, Image = "/images/girlonfire.png", Label = "RCA", Title = "Girl on Fire" },
                        new { Id = 20, ArtistId = 4, Image = "/images/here.png", Label = "RCA", Title = "Here" }
                    );
                });

            modelBuilder.Entity("AlbumProject.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Hometown");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new { Id = 1, Age = 35, Hometown = "Cleveland, Ohio", Image = "/images/kidcudi.jpg", Name = "Kid Cudi" },
                        new { Id = 2, Age = 32, Hometown = "Las Vegas, Nevada", Image = "/images/imaginedragons.jpg", Name = "Imagine Dragons" },
                        new { Id = 3, Age = 54, Hometown = "London, England", Image = "/images/pinkfloyd.jpg", Name = "Pink Floyd" },
                        new { Id = 4, Age = 38, Hometown = "New York, New York", Image = "/images/alicia_keys.jpg", Name = "Alicia Keys" }
                    );
                });

            modelBuilder.Entity("AlbumProject.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("AlbumTitle");

                    b.Property<string>("Duration");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new { Id = 1, AlbumId = 1, Duration = "3:15", Title = "In My Dreams(Cudder Anthem)" },
                        new { Id = 2, AlbumId = 1, Duration = "3:56", Title = "Soundtrack 2 My Life" },
                        new { Id = 3, AlbumId = 1, Duration = "2:32", Title = "Simple As…" },
                        new { Id = 4, AlbumId = 1, Duration = "4:26", Title = "Solo Dolo (Nightmare)" },
                        new { Id = 5, AlbumId = 1, Duration = "4:21", Title = "Heart Of A Lion" },
                        new { Id = 6, AlbumId = 1, Duration = "4:03", Title = "My World" },
                        new { Id = 7, AlbumId = 1, Duration = "3:42", Title = "Day ‘N’ Nite (nightmare)" },
                        new { Id = 8, AlbumId = 1, Duration = "3:41", Title = "Sky Might Fall" },
                        new { Id = 9, AlbumId = 1, Duration = "4:20", Title = "Enter Galactic (Love Connection Part 1)" },
                        new { Id = 10, AlbumId = 1, Duration = "4:06", Title = "Alive (Nightmare)" },
                        new { Id = 11, AlbumId = 1, Duration = "3:36", Title = "Make Her Say" },
                        new { Id = 12, AlbumId = 1, Duration = "4:55", Title = "Pursuit Of Happiness (Nightmare)" },
                        new { Id = 13, AlbumId = 1, Duration = "3:32", Title = "Hyyerr" },
                        new { Id = 14, AlbumId = 1, Duration = "3:46", Title = "Up Up & Away" },
                        new { Id = 15, AlbumId = 1, Duration = "3:46", Title = "In My Dreams(Cudder Anthem)" },
                        new { Id = 16, AlbumId = 2, Duration = "3:55", Title = "Scott Mesucdi Vs The World" },
                        new { Id = 17, AlbumId = 2, Duration = "3:03", Title = "REVOFEV" },
                        new { Id = 18, AlbumId = 2, Duration = "3:43", Title = "Don’t Play This Song" },
                        new { Id = 19, AlbumId = 2, Duration = "1:27", Title = "We Aite (Wake Your Mind Up)" },
                        new { Id = 20, AlbumId = 2, Duration = "4:20", Title = "Marijuana" },
                        new { Id = 21, AlbumId = 2, Duration = "3:31", Title = "Mojo So Dope" },
                        new { Id = 22, AlbumId = 2, Duration = "3:48", Title = "Ashin’ Kusher" },
                        new { Id = 23, AlbumId = 2, Duration = "3:12", Title = "Erase Me" },
                        new { Id = 24, AlbumId = 2, Duration = "4:14", Title = "Wild’n Cuz I’m Young" },
                        new { Id = 25, AlbumId = 2, Duration = "2:36", Title = "The Mood" },
                        new { Id = 26, AlbumId = 2, Duration = "2:58", Title = "MANIAC" },
                        new { Id = 27, AlbumId = 2, Duration = "4:54", Title = "Mr. Rager" },
                        new { Id = 28, AlbumId = 2, Duration = "4:16", Title = "These Worries" },
                        new { Id = 29, AlbumId = 2, Duration = "4:20", Title = "The End" },
                        new { Id = 30, AlbumId = 2, Duration = "3:23", Title = "All Along" },
                        new { Id = 31, AlbumId = 2, Duration = "4:49", Title = "GHOST!" },
                        new { Id = 32, AlbumId = 2, Duration = "3:33", Title = "Trapped In My Mind" },
                        new { Id = 33, AlbumId = 3, Duration = "2:41", Title = "The Resurrection Of Scott Mescudi" },
                        new { Id = 34, AlbumId = 3, Duration = "4:36", Title = "Unfuckwittable" },
                        new { Id = 35, AlbumId = 3, Duration = "3:48", Title = "Just What I Am" },
                        new { Id = 36, AlbumId = 3, Duration = "4:24", Title = "Young Lady" },
                        new { Id = 37, AlbumId = 3, Duration = "4:16", Title = "King Wizard" },
                        new { Id = 38, AlbumId = 3, Duration = "5:02", Title = "Immortal" },
                        new { Id = 39, AlbumId = 3, Duration = "3:34", Title = "Solo Dolo Part II " },
                        new { Id = 40, AlbumId = 3, Duration = "4:28", Title = "Girls" },
                        new { Id = 41, AlbumId = 3, Duration = "1:53", Title = "New York City Rage Fest" },
                        new { Id = 42, AlbumId = 3, Duration = "3:55", Title = "Red Eye" },
                        new { Id = 43, AlbumId = 3, Duration = "4:09", Title = "Mad Solar" },
                        new { Id = 44, AlbumId = 3, Duration = "3:13", Title = "Beez" },
                        new { Id = 45, AlbumId = 3, Duration = "4:41", Title = "Brothers" },
                        new { Id = 46, AlbumId = 3, Duration = "2:58", Title = "Burn Baby Burn" },
                        new { Id = 47, AlbumId = 3, Duration = "2:47", Title = "Lord Of The Sad And Lonely" },
                        new { Id = 48, AlbumId = 3, Duration = "2:32", Title = "Cold Blooded" },
                        new { Id = 49, AlbumId = 3, Duration = "9:03", Title = "Afterwards (Bring Yo Friends)" },
                        new { Id = 50, AlbumId = 3, Duration = "2:51", Title = "The Flight Of The Moon Man" },
                        new { Id = 51, AlbumId = 4, Duration = "1:50", Title = "Destination: Mother Moon" },
                        new { Id = 52, AlbumId = 4, Duration = "3:48", Title = "Going To The Ceremony" },
                        new { Id = 53, AlbumId = 4, Duration = "4:35", Title = "SATELLITE FLIGHT" },
                        new { Id = 54, AlbumId = 4, Duration = "4:34", Title = "Copernicus Landing" },
                        new { Id = 55, AlbumId = 4, Duration = "5:27", Title = "Balmain Jeans" },
                        new { Id = 56, AlbumId = 4, Duration = "6:18", Title = "Too Bad I Have To Destroy You Now" },
                        new { Id = 57, AlbumId = 4, Duration = "4:16", Title = "Internal Bleeding" },
                        new { Id = 58, AlbumId = 4, Duration = "1:46", Title = "In My Dreams 2015" },
                        new { Id = 59, AlbumId = 4, Duration = "5:15", Title = "Return Of The Moon Man" },
                        new { Id = 60, AlbumId = 5, Duration = "3:21", Title = "Troubled Boy" },
                        new { Id = 61, AlbumId = 5, Duration = "4:43", Title = "Edge Of The Earth/Post Mortem Boredom" },
                        new { Id = 62, AlbumId = 5, Duration = "3:56", Title = "CONFUSED!" },
                        new { Id = 63, AlbumId = 5, Duration = "3:50", Title = "Man In The Night" },
                        new { Id = 64, AlbumId = 5, Duration = "2:28", Title = "Screwed" },
                        new { Id = 65, AlbumId = 5, Duration = "2:58", Title = "Fade 2 Red" },
                        new { Id = 66, AlbumId = 5, Duration = "6:10", Title = "Adventures" },
                        new { Id = 67, AlbumId = 5, Duration = "3:31", Title = "The Nothing" },
                        new { Id = 68, AlbumId = 5, Duration = "3:04", Title = "AMEN" },
                        new { Id = 69, AlbumId = 5, Duration = "3:45", Title = "Handle With Care" },
                        new { Id = 70, AlbumId = 5, Duration = "3:05", Title = "Judgemental C**t" },
                        new { Id = 71, AlbumId = 5, Duration = "1:54", Title = "Seance Chaos" },
                        new { Id = 72, AlbumId = 5, Duration = "3:06", Title = "Fairy Tale Remains" },
                        new { Id = 73, AlbumId = 5, Duration = "2:32", Title = "Wedding Tux" },
                        new { Id = 74, AlbumId = 5, Duration = "3:30", Title = "Angered Kids" },
                        new { Id = 75, AlbumId = 5, Duration = "4:38", Title = "Red Sabbath" },
                        new { Id = 76, AlbumId = 5, Duration = "2:45", Title = "Fuchsia Butterflies" },
                        new { Id = 77, AlbumId = 5, Duration = "4:35", Title = "Speedin Bullet 2 Heaven" },
                        new { Id = 78, AlbumId = 5, Duration = "3:01", Title = "Embers" },
                        new { Id = 79, AlbumId = 5, Duration = "4:35", Title = "Anomaly" },
                        new { Id = 80, AlbumId = 5, Duration = "4:15", Title = "The Return of Chip Douglas" },
                        new { Id = 81, AlbumId = 5, Duration = "2:44", Title = "Trauma" },
                        new { Id = 82, AlbumId = 5, Duration = "1:58", Title = "WAIT" },
                        new { Id = 83, AlbumId = 5, Duration = "3:07", Title = "Insides Out" },
                        new { Id = 84, AlbumId = 5, Duration = "3:24", Title = "Speedin’ Bullet 2 Heaven" },
                        new { Id = 85, AlbumId = 5, Duration = "5:17", Title = "Worth" },
                        new { Id = 86, AlbumId = 5, Duration = "4:58", Title = "Frequency" },
                        new { Id = 87, AlbumId = 6, Duration = "4:29", Title = "Swim In The Light" },
                        new { Id = 88, AlbumId = 6, Duration = "5:28", Title = "Releaser" },
                        new { Id = 89, AlbumId = 6, Duration = "4:17", Title = "By Design" },
                        new { Id = 90, AlbumId = 6, Duration = "4:11", Title = "All In" },
                        new { Id = 91, AlbumId = 6, Duration = "4:16", Title = "ILLusions" },
                        new { Id = 92, AlbumId = 6, Duration = "4:38", Title = "Rose Golden" },
                        new { Id = 93, AlbumId = 6, Duration = "4:45", Title = "Baptized In Fire" },
                        new { Id = 94, AlbumId = 6, Duration = "3:57", Title = "Flight At First Sight/Advanced" },
                        new { Id = 95, AlbumId = 6, Duration = "4:23", Title = "Does It" },
                        new { Id = 96, AlbumId = 6, Duration = "4:43", Title = "Dance 4 Eternity" },
                        new { Id = 97, AlbumId = 6, Duration = "4:47", Title = "Distant Fantasies" },
                        new { Id = 98, AlbumId = 6, Duration = "4:03", Title = "Wounds" },
                        new { Id = 99, AlbumId = 6, Duration = "3:55", Title = "Mature Nature" },
                        new { Id = 100, AlbumId = 6, Duration = "4:29", Title = "Kitchen" },
                        new { Id = 101, AlbumId = 6, Duration = "4:01", Title = "Cosmic Warrior" },
                        new { Id = 102, AlbumId = 6, Duration = "5:06", Title = "The Guide" },
                        new { Id = 103, AlbumId = 6, Duration = "4:16", Title = "The Commander" },
                        new { Id = 104, AlbumId = 6, Duration = "6:15", Title = "Surfin’" },
                        new { Id = 105, AlbumId = 7, Duration = "3:07", Title = "Radioactive" },
                        new { Id = 106, AlbumId = 7, Duration = "3:14", Title = "Tiptoe" },
                        new { Id = 107, AlbumId = 7, Duration = "4:01", Title = "It's Time" },
                        new { Id = 108, AlbumId = 7, Duration = "2:58", Title = "Demons" },
                        new { Id = 109, AlbumId = 7, Duration = "3:10", Title = "On Top Of The World" },
                        new { Id = 110, AlbumId = 7, Duration = "4:02", Title = "Amsterdam" },
                        new { Id = 111, AlbumId = 7, Duration = "3:53", Title = "Hear Me" },
                        new { Id = 112, AlbumId = 7, Duration = "3:36", Title = "Every Night" },
                        new { Id = 113, AlbumId = 7, Duration = "3:42", Title = "Bleeding Out" },
                        new { Id = 114, AlbumId = 7, Duration = "3:27", Title = "Underdog" },
                        new { Id = 115, AlbumId = 7, Duration = "8:57", Title = "Nothing Left To Say/Rocks" },
                        new { Id = 116, AlbumId = 8, Duration = "3:53", Title = "Shots" },
                        new { Id = 117, AlbumId = 8, Duration = "3:37", Title = "Gold" },
                        new { Id = 118, AlbumId = 8, Duration = "4:21", Title = "Smoke And Mirrors" },
                        new { Id = 119, AlbumId = 8, Duration = "3:51", Title = "I'm So Sorry" },
                        new { Id = 120, AlbumId = 8, Duration = "3:12", Title = "I Bet My Life" },
                        new { Id = 121, AlbumId = 8, Duration = "3:52", Title = "Polaroid" },
                        new { Id = 122, AlbumId = 8, Duration = "3:22", Title = "Friction" },
                        new { Id = 123, AlbumId = 8, Duration = "3:38", Title = "It Comes Back To You" },
                        new { Id = 124, AlbumId = 8, Duration = "4:19", Title = "Dream" },
                        new { Id = 125, AlbumId = 8, Duration = "3:13", Title = "Trouble" },
                        new { Id = 126, AlbumId = 8, Duration = "3:39", Title = "Summer" },
                        new { Id = 127, AlbumId = 8, Duration = "4:02", Title = "Hopeless Opus" },
                        new { Id = 128, AlbumId = 8, Duration = "6:03", Title = "The Fall" },
                        new { Id = 129, AlbumId = 9, Duration = "3:11", Title = "I Don't Know Why" },
                        new { Id = 130, AlbumId = 9, Duration = "3:22", Title = "Whatever It Takes" },
                        new { Id = 131, AlbumId = 9, Duration = "3:25", Title = "Believer" },
                        new { Id = 132, AlbumId = 9, Duration = "3:53", Title = "Walking The Wire" },
                        new { Id = 133, AlbumId = 9, Duration = "3:52", Title = "Rise Up" },
                        new { Id = 134, AlbumId = 9, Duration = "4:23", Title = "I'll Make It Up To You" },
                        new { Id = 135, AlbumId = 9, Duration = "3:26", Title = "Yesturday" },
                        new { Id = 136, AlbumId = 9, Duration = "3:42", Title = "Mouth Of The River" },
                        new { Id = 137, AlbumId = 9, Duration = "3:08", Title = "Thunder" },
                        new { Id = 138, AlbumId = 9, Duration = "3:27", Title = "Star Over" },
                        new { Id = 139, AlbumId = 9, Duration = "3:54", Title = "Dancing In The Dark" },
                        new { Id = 140, AlbumId = 10, Duration = "3:10", Title = "Natural" },
                        new { Id = 141, AlbumId = 10, Duration = "3:08", Title = "Boomerang" },
                        new { Id = 142, AlbumId = 10, Duration = "3:02", Title = "Machine" },
                        new { Id = 143, AlbumId = 10, Duration = "3:38", Title = "Cool Out" },
                        new { Id = 144, AlbumId = 10, Duration = "4:21", Title = "Bad Liar" },
                        new { Id = 145, AlbumId = 10, Duration = "3:38", Title = "West Coast" },
                        new { Id = 146, AlbumId = 10, Duration = "3:31", Title = "Zero" },
                        new { Id = 147, AlbumId = 10, Duration = "3:25", Title = "Bullet In A Gun" },
                        new { Id = 148, AlbumId = 10, Duration = "3:21", Title = "Digital" },
                        new { Id = 149, AlbumId = 10, Duration = "3:01", Title = "Only" },
                        new { Id = 150, AlbumId = 10, Duration = "3:11", Title = "Stuck" },
                        new { Id = 151, AlbumId = 10, Duration = "2:47", Title = "Love" },
                        new { Id = 152, AlbumId = 11, Duration = "5:56", Title = "Cluster One" },
                        new { Id = 153, AlbumId = 11, Duration = "4:22", Title = "What Do You Want From Me" },
                        new { Id = 154, AlbumId = 11, Duration = "7:03", Title = "Poles Apart" },
                        new { Id = 155, AlbumId = 11, Duration = "5:30", Title = "Marooned" },
                        new { Id = 156, AlbumId = 11, Duration = "4:17", Title = "A Great Day For Freedom" },
                        new { Id = 157, AlbumId = 11, Duration = "6:49", Title = "Wearing The Inside Out" },
                        new { Id = 158, AlbumId = 11, Duration = "6:12", Title = "Take It Back" },
                        new { Id = 159, AlbumId = 11, Duration = "6:19", Title = "Coming Back To Life" },
                        new { Id = 160, AlbumId = 11, Duration = "6:11", Title = "Keep Talking" },
                        new { Id = 161, AlbumId = 11, Duration = "5:15", Title = "Lost For Words" },
                        new { Id = 162, AlbumId = 11, Duration = "8:31", Title = "High Hopes" },
                        new { Id = 163, AlbumId = 12, Duration = "23:41", Title = "Atom Heart Mother" },
                        new { Id = 164, AlbumId = 12, Duration = "4:31", Title = "If" },
                        new { Id = 165, AlbumId = 12, Duration = "5:29", Title = "Summer '68" },
                        new { Id = 166, AlbumId = 12, Duration = "5:24", Title = "Fat Old Sun" },
                        new { Id = 167, AlbumId = 12, Duration = "12:59", Title = "Alan's Psychedelic Breakfast" },
                        new { Id = 168, AlbumId = 13, Duration = "2:59", Title = "The Post War Dream" },
                        new { Id = 169, AlbumId = 13, Duration = "4:26", Title = "Your Possible Pasts" },
                        new { Id = 170, AlbumId = 13, Duration = "1:17", Title = "One of the Few" },
                        new { Id = 171, AlbumId = 13, Duration = "3:12", Title = "When the Tigers Broke Free" },
                        new { Id = 172, AlbumId = 13, Duration = "2:43", Title = "The Hero's Return" },
                        new { Id = 173, AlbumId = 13, Duration = "5:18", Title = "The Gunner's Dream" },
                        new { Id = 174, AlbumId = 13, Duration = "3:42", Title = "Paranoid Eyes" },
                        new { Id = 175, AlbumId = 13, Duration = "1:17", Title = "Get Your Filthy Hands Off My Desert" },
                        new { Id = 176, AlbumId = 13, Duration = "4:09", Title = "The Fletcher Memorial Home" },
                        new { Id = 177, AlbumId = 13, Duration = "2:13", Title = "Southampton Dock" },
                        new { Id = 178, AlbumId = 13, Duration = "4:43", Title = "The Final Cut" },
                        new { Id = 179, AlbumId = 13, Duration = "5:01", Title = "Not Now John [Explicit]" },
                        new { Id = 180, AlbumId = 13, Duration = "5:15", Title = "Two Suns in the Sunset" },
                        new { Id = 181, AlbumId = 14, Duration = "1:05", Title = "Speak To Me/Breathe" },
                        new { Id = 182, AlbumId = 14, Duration = "3:45", Title = "On The Run" },
                        new { Id = 183, AlbumId = 14, Duration = "6:54", Title = "Time" },
                        new { Id = 184, AlbumId = 14, Duration = "4:44", Title = "The Great Gig In The Sky" },
                        new { Id = 185, AlbumId = 14, Duration = "6:23", Title = "Money" },
                        new { Id = 186, AlbumId = 14, Duration = "7:49", Title = "Us And Them" },
                        new { Id = 187, AlbumId = 14, Duration = "3:26", Title = "Any Colour You Like" },
                        new { Id = 188, AlbumId = 14, Duration = "3:47", Title = "Brain Damage" },
                        new { Id = 189, AlbumId = 14, Duration = "2:10", Title = "Eclipse" },
                        new { Id = 190, AlbumId = 15, Duration = "1:52", Title = "Piano & I" },
                        new { Id = 191, AlbumId = 15, Duration = "3:34", Title = "Girlfriend" },
                        new { Id = 192, AlbumId = 15, Duration = "3:57", Title = "How Come You Don't Call Me" },
                        new { Id = 193, AlbumId = 15, Duration = "3:30", Title = "Fallin" },
                        new { Id = 194, AlbumId = 15, Duration = "4:28", Title = "Troubles" },
                        new { Id = 195, AlbumId = 15, Duration = "5:36", Title = "Rock wit U" },
                        new { Id = 196, AlbumId = 15, Duration = "5:03", Title = "A Woman's Worth" },
                        new { Id = 197, AlbumId = 15, Duration = "3:48", Title = "Jane Doe" },
                        new { Id = 198, AlbumId = 15, Duration = "4:20", Title = "Goodbye" },
                        new { Id = 199, AlbumId = 15, Duration = "5:25", Title = "The Life" },
                        new { Id = 200, AlbumId = 15, Duration = "4:09", Title = "Mr. Man" },
                        new { Id = 201, AlbumId = 15, Duration = "2:01", Title = "Never Felt This Way" },
                        new { Id = 202, AlbumId = 15, Duration = "4:08", Title = "Butterflyz" },
                        new { Id = 203, AlbumId = 15, Duration = "4:25", Title = "Why Do I Feel So Sad" },
                        new { Id = 204, AlbumId = 15, Duration = "3:02", Title = "Caged Bird" },
                        new { Id = 205, AlbumId = 15, Duration = "3:49", Title = "Lovin U" },
                        new { Id = 206, AlbumId = 16, Duration = "1:43", Title = "Harlem's Nocturne" },
                        new { Id = 207, AlbumId = 16, Duration = "4:16", Title = "Karma" },
                        new { Id = 208, AlbumId = 16, Duration = "3:28", Title = "Heartburn" },
                        new { Id = 209, AlbumId = 16, Duration = "3:06", Title = "If I Was Your Woman / Walk On By" },
                        new { Id = 210, AlbumId = 16, Duration = "6:06", Title = "You Don't Know My Name" },
                        new { Id = 211, AlbumId = 16, Duration = "3:48", Title = "If I Ain't Got You" },
                        new { Id = 212, AlbumId = 16, Duration = "4:45", Title = "Diary" },
                        new { Id = 213, AlbumId = 16, Duration = "4:36", Title = "Dragon Days" },
                        new { Id = 214, AlbumId = 16, Duration = "4:27", Title = "Wake Up" },
                        new { Id = 215, AlbumId = 16, Duration = "3:49", Title = "So Simple" },
                        new { Id = 216, AlbumId = 16, Duration = "4:09", Title = "When You Really Love Someone" },
                        new { Id = 217, AlbumId = 16, Duration = "2:07", Title = "Feeling U, Feeling Me" },
                        new { Id = 218, AlbumId = 16, Duration = "4:18", Title = "Slow Down" },
                        new { Id = 219, AlbumId = 16, Duration = "4:12", Title = "Samsonite Man" },
                        new { Id = 220, AlbumId = 16, Duration = "2:56", Title = "Nobody Not Really" },
                        new { Id = 221, AlbumId = 17, Duration = "1:52", Title = "As I Am (Intro)" },
                        new { Id = 222, AlbumId = 17, Duration = "4:36", Title = "Go Ahead" },
                        new { Id = 223, AlbumId = 17, Duration = "4:34", Title = "Superwoman" },
                        new { Id = 224, AlbumId = 17, Duration = "4:12", Title = "No One" },
                        new { Id = 225, AlbumId = 17, Duration = "5:15", Title = "Like You'll Never See Me Again" },
                        new { Id = 226, AlbumId = 17, Duration = "4:14", Title = "Lesson Learned" },
                        new { Id = 227, AlbumId = 17, Duration = "3:53", Title = "Wreckless Love" },
                        new { Id = 228, AlbumId = 17, Duration = "3:50", Title = "The Thing About Love" },
                        new { Id = 229, AlbumId = 17, Duration = "3:10", Title = "Teenage Love Affair" },
                        new { Id = 230, AlbumId = 17, Duration = "5:10", Title = "I Need You" },
                        new { Id = 231, AlbumId = 17, Duration = "4:11", Title = "Where Do We Go from Here" },
                        new { Id = 232, AlbumId = 17, Duration = "2:08", Title = "Prelude to a Kiss" },
                        new { Id = 233, AlbumId = 17, Duration = "4:28", Title = "Tell You Something (Nana's Reprise)" },
                        new { Id = 234, AlbumId = 17, Duration = "4:31", Title = "Sure Looks Good to Me" },
                        new { Id = 235, AlbumId = 18, Duration = "0:12", Title = "The Element of Freedom (Intro)" },
                        new { Id = 236, AlbumId = 18, Duration = "3:49", Title = "Love is Blind" },
                        new { Id = 237, AlbumId = 18, Duration = "4:32", Title = "Doesn't Mean Anything" },
                        new { Id = 238, AlbumId = 18, Duration = "4:09", Title = "Try Sleeping with a Broken Heart" },
                        new { Id = 239, AlbumId = 18, Duration = "4:01", Title = "Wait Til You See My Smile" },
                        new { Id = 240, AlbumId = 18, Duration = "4:04", Title = "That's How Strong My Love Is" },
                        new { Id = 241, AlbumId = 18, Duration = "4:09", Title = "Un-Thinkable (I'm Ready)" },
                        new { Id = 242, AlbumId = 18, Duration = "4:01", Title = "Love Is My Disease" },
                        new { Id = 243, AlbumId = 18, Duration = "4:13", Title = "Like the Sea" },
                        new { Id = 244, AlbumId = 18, Duration = "3:15", Title = "Put It in a Love Song" },
                        new { Id = 245, AlbumId = 18, Duration = "3:45", Title = "This Bed" },
                        new { Id = 246, AlbumId = 18, Duration = "4:27", Title = "Distance and Time" },
                        new { Id = 247, AlbumId = 18, Duration = "4:42", Title = "How It Feels to Fly" },
                        new { Id = 248, AlbumId = 18, Duration = "3:36", Title = "Empire State of Mind (Part II) Broken Down" },
                        new { Id = 249, AlbumId = 19, Duration = "1:19", Title = "De Novo Adagio (Intro)" },
                        new { Id = 250, AlbumId = 19, Duration = "3:53", Title = "Brand New Me" },
                        new { Id = 251, AlbumId = 19, Duration = "4:34", Title = "When It's All Over" },
                        new { Id = 252, AlbumId = 19, Duration = "3:46", Title = "Listen to Your Heart" },
                        new { Id = 253, AlbumId = 19, Duration = "4:02", Title = "New Day" },
                        new { Id = 254, AlbumId = 19, Duration = "4:30", Title = "Girl on Fire" },
                        new { Id = 255, AlbumId = 19, Duration = "5:21", Title = "Fire We Make" },
                        new { Id = 256, AlbumId = 19, Duration = "3:59", Title = "Tears Always Win" },
                        new { Id = 257, AlbumId = 19, Duration = "3:07", Title = "Not Even the King" },
                        new { Id = 258, AlbumId = 19, Duration = "4:05", Title = "That's When I Knew" },
                        new { Id = 259, AlbumId = 19, Duration = "3:57", Title = "Limitedless" },
                        new { Id = 260, AlbumId = 19, Duration = "4:08", Title = "One Thing" },
                        new { Id = 261, AlbumId = 19, Duration = "6:29", Title = "101" },
                        new { Id = 262, AlbumId = 20, Duration = "1:04", Title = "The Beginning" },
                        new { Id = 263, AlbumId = 20, Duration = "3:01", Title = "The Gospel" },
                        new { Id = 264, AlbumId = 20, Duration = "3:10", Title = "Pawn It All" },
                        new { Id = 265, AlbumId = 20, Duration = "0:50", Title = "Elain Brown (interlude)" },
                        new { Id = 266, AlbumId = 20, Duration = "2:40", Title = "Kill Your Mama" },
                        new { Id = 267, AlbumId = 20, Duration = "6:07", Title = "She Don't Really Care/1 Luv" },
                        new { Id = 268, AlbumId = 20, Duration = "0:48", Title = "Elevate (interlude)" },
                        new { Id = 269, AlbumId = 20, Duration = "5:23", Title = "Illusion of Bliss" },
                        new { Id = 270, AlbumId = 20, Duration = "3:31", Title = "Blended Family (What You Do for Love)" },
                        new { Id = 271, AlbumId = 20, Duration = "3:34", Title = "Work on It" },
                        new { Id = 272, AlbumId = 20, Duration = "0:59", Title = "Cocoa Butter (Cross & Pic Interlude)" },
                        new { Id = 273, AlbumId = 20, Duration = "2:39", Title = "Girl Can't Be Herself" },
                        new { Id = 274, AlbumId = 20, Duration = "0:25", Title = "You Glow (interlude)" },
                        new { Id = 275, AlbumId = 20, Duration = "4:35", Title = "More than We Know" },
                        new { Id = 276, AlbumId = 20, Duration = "2:47", Title = "Where Do We Begin Now" },
                        new { Id = 277, AlbumId = 20, Duration = "4:22", Title = "Holy War" }
                    );
                });

            modelBuilder.Entity("AlbumProject.Models.Album", b =>
                {
                    b.HasOne("AlbumProject.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AlbumProject.Models.Song", b =>
                {
                    b.HasOne("AlbumProject.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}