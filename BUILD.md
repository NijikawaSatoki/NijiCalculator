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

To compile the calculator, just run this:

```
mcs src/MainProgram.cs src/NijiCalculator/*.cs src/NijiConvenience/*.cs -out:NijiCalculator
```

Windows users may have to change `-out:NijiCalculator` to `-out:NijiCalculator.exe`.

Alternatively, you could just run the `build-linux.sh` script (if you're on Linux or are using Termux on Android) or `build-win64.sh` script (if you're on Windows).
