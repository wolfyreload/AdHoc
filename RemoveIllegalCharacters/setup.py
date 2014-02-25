import sys
from cx_Freeze import setup, Executable

setup(
    name = "Remove Illegal Characters",
    version = "0.1",
    description = "Remove invalid characters from file.",
    executables = [Executable("RemoveIllegalCharacters.py", base = "Console")])