# This script simply runs mono's compiler

mcs src/MainProgram.cs \
src/NijiCalculator/Calculate.cs \
src/NijiConvenience/Convenience.cs -out:test/newTest0D
