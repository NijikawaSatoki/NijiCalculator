# NOTICE: THIS BUILD SCRIPT IS ONLY FOR 64-BIT WINDOWS!

# This script simply runs mono's compiler

mcs src/MainProgram.cs \
src/NijiCalculator/Calculate.cs \
src/NijiConvenience/Convenience.cs -out:NijiCalculator.exe
