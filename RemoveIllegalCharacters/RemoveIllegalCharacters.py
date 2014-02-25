from sys import argv, exit
from os import path
import FileCleaner

usage = '''
Usage RemoveIllegalCharacters.exe <input file> [<output file>]
Please note that the output file name is optional if it is not provided an
<input file>_cleaned file will be created.
'''

# check that parameters are provided
if len(argv) < 2 or len(argv) > 3:
    print usage;
    exit();
	
# get the input file parameter
ifilename = argv[1];

# check that the input file exists
if not path.isfile(ifilename):
	print "the input file", ifilename, "does not exist"
	exit();

# if there is an output file parameter use it
if len(argv) == 3:
	ofilename = argv[2];
else: # else calculate the output file
	extensionIndex = ifilename.rfind('.')
	if extensionIndex > 0:
		extension = ifilename[extensionIndex:len(ifilename)]
		ofilename = ifilename.replace(extension, '')+"_cleaned" + extension;
	else:
		ofilename = ifilename+"_cleaned"
	
cleaner = FileCleaner.CleanUp(ifilename, ofilename);