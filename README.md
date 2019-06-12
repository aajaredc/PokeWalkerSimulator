PokeWalkerSimulator
=====
![License](https://img.shields.io/badge/License-GPLv3-blue.svg)

This is a WIP PokeWalker simulator made around [PKHeX](https://github.com/kwsch/PKHeX). It currently features full functionality for catching all six Pokemon in each of the twenty-seven courses. All information taken about the PokeWalker is documented on [Serebii](https://serebii.net/heartgoldsoulsilver/pokewalker.shtml) and [BulbaPedia](https://bulbapedia.bulbagarden.net/wiki/Pok%C3%A9walker).

## Screenshots



## Building

This program is the same as PKHeX, in that it is a Windows Forms application which requires [.NET Framework v4.6](https://www.microsoft.com/en-us/download/details.aspx?id=48137).

Likewise, the executable can be built with any compiler that supports C# 7.

### Build Configurations

Use the Debug or Release build configurations when building using the .NET Framework. Use the Mono-Debug or Mono-Release build configurations when building using Mono.

## Dependencies

This program uses [PKHeX](https://github.com/kwsch/PKHeX), which is licensed under [the GNU General Public License v3.0](https://github.com/kwsch/PKHeX/blob/master/LICENSE.md), for managing save data.

PKHeX's QR code generation code is taken from [QRCoder](https://github.com/codebude/QRCoder), which is licensed under [the MIT license](https://github.com/codebude/QRCoder/blob/master/LICENSE.txt).

PKHeX's shiny sprite collection is taken from [pokesprite](https://github.com/msikma/pokesprite), which is licensed under [the MIT license](https://github.com/msikma/pokesprite/blob/master/LICENSE).

PK4 files are either made from scratch, or are taken from [Project Pokemon](https://projectpokemon.org/home/files/category/166-pok%C3%A9walker/).

### IDE

This program can be opened with IDEs such as [Visual Studio](https://www.visualstudio.com/) or [MonoDevelop](http://www.monodevelop.com/) by opening the .sln or .csproj file.

### GNU/Linux

Install [MonoDevelop](http://www.monodevelop.com/) and [Mono Runtime](http://www.mono-project.com/) with `flatpak install --user --from https://download.mono-project.com/repo/monodevelop.flatpakref`. GNU/Linux is not the main Operating System of developers of this program so there may be bugs; some may come from non GNU/Linux specific code of Mono (so developers using \*BSD, Windows and macOS should be able to reproduce them).
