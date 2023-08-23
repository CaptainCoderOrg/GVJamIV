﻿using CosmicCruiseCatastrophe;
using Spectre.Console;

// // Console.Beep(440, 2000);
IScreen location = new TitleScreen();
location = new NameEntryScreen();

while (location is not null)
{
    await location.Display();
    location = location.Next();
}
