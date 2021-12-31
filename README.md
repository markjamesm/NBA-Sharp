# NBA Sharp
[![.NET](https://github.com/markjamesm/NBA-Sharp/actions/workflows/dotnet.yml/badge.svg?branch=master)](https://github.com/markjamesm/NBA-Sharp/actions/workflows/dotnet.yml) [![C#](https://img.shields.io/badge/Language-CSharp-darkgreen.svg)](https://en.wikipedia.org/wiki/C_Sharp_(programming_language)) [![License](https://img.shields.io/badge/License-MIT-red.svg)](https://opensource.org/licenses/MIT)

## About

NBA Sharp is an unofficial .NET wrapper library for the public facing MLB Stats API. Currently in an early alpha status, the project is built on .NET 6.0.

## Endpoints

#### GetPlayerBio(string playerId)

* Returns a short bio for a given player.

#### GetScoreboard(string date)

* Returns a list of scoreboard summaries for the given date. Can be used to get GameIds for making other calls.

## Todo

* Implement additional endpoints
* Setup DocFX (for API documentation)

## Copyright Notice
This package and its author are not affiliated with the NBA or any NBA team.
