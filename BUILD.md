# Build Instructions

This will tell you what you need to build this.

## Mono

`mono` should be straightforward to compile with.

### Installing `mono`

For Arch users:

```
sudo pacman -S mono mono-tools
```

For Termux users:

```
pkg install mono mono-libs mono-static
```

For MSYS2 users:

```
pacman -S mingw-w64-x86_64-mono mingw-w64-x86_64-mono-basic
```

### Running `mono`'s compiler

Now for the actual building part!

To compile the calculator, just run this (for the English version; replace `en-US` with `ja-JP` for the Japanese version):

```
mcs en-US/MainProgram.cs en-US/NijiMath.cs -out:NijiCalculator
```

Windows users may have to change `-out:NijiCalculator` to `-out:NijiCalculator.exe`.

Alternatively, you could just run the `build-en-mono-linux` script (if you're on Linux or are using Termux on Android) or `build-en-mono-win64` script (if you're on Windows using MSYS2).

## .NET

This is the current way to compile.

### Installing .NET

For Arch users:

```
sudo pacman -S dotnet-sdk dotnet-runtime
```

For MSYS2 users: You'll be using the Windows install of .NET that you installed.

### Running the .NET compiler

Not gonna tell you the full command for this... just use the `build-en-dotnet-linux` script (if you're on Linux) or `build-en-dotnet-win64` script (if you're on Windows using MSYS2).
