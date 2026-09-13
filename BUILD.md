# Build Instructions

This will tell you what you need to build this.

## Installing .NET

For Arch users:

```
sudo pacman -S dotnet-sdk dotnet-runtime
```

For MSYS2 users: You'll be using the Windows install of .NET that you installed.
Just make sure that you add the directory to `$PATH`.

### Running the .NET compiler

Not gonna tell you the full command for this... just use the `build-linux-x64` script (if you're on Linux) or `build-win64-*` script (where `*` is the architecture of your system (`x86` for x86, `x64` for x86_64, and `arm64` for ARM), if you're on Windows using MSYS2).
