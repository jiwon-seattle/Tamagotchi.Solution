# Tamagotchi C

![LastCommit](https://img.shields.io/github/last-commit/seschwartz8/Tamagotchi.Solution)
![Languages](https://img.shields.io/github/languages/top/seschwartz8/Tamagotchi.Solution)
![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)

#### A C#/.NET Core MVC website where you can play with your Tamagotchi, Current Version: 02.20.2020

#### By Sarah "Sasa" Schwartz

---

## Table of Contents

1. [Description](#description)
2. [Setup/Installation Requirements](#installation-requirements)
3. [Specifications](#specs)
4. [Known Bugs](#known-bugs)
5. [Technologies Used](#technologies-used)
6. [License](#license)

---

## Description

A C#/.NET Core MVC website where you can play with your Tamagotchi. You can name your Tamagotchi, feed it, play with it, put it to sleep, etc. As time passes, your Tamagotchi's stats will lower if you don't take good care of it.

## Installation Requirements

- Clone the repository to your desktop
- Open the terminal
- Make sure you are inside the Tamagotchi directory, within the Tamagotchi.Solution directory
- \$dotnet restore
- \$dotnet run
- The app should be hosted on http://localhost:5000/
- Use the app at this URL in the browser!

## Specs

- User can create a Tamagotchi with custom name.
  - Sample input: User inputs Tamagotchi name of "cutiepie"
  - Expected output: Tamagotchi with name "cutiepie" appears on screen.
- User can feed Tamagotchi
  - Sample input: User clicks "feed" button
  - Expected output: Tamagotchi's food number increases
- User can play with Tamagotchi
  - Sample input: User clicks "play" button
  - Expected output: Tamagotchi's happiness number increases
- User can play with Tamagotchi
  - Sample input: User clicks "nap" button
  - Expected output: Tamagotchi's sleep number increases
- User can pass the time
  - Sample input: User clicks "pass time" button
  - Expected output: All of Tamagotchi's stats decrease

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
