from re import sub

__regexstring = "[^a-zA-Z0-9|@\.'\"\r\n\x00\s\-\(\)]";

def CleanUp(ifilename, ofilename):
    #open both files
    ifile = open(ifilename);
    ofile = open(ofilename, 'w');

    #iterate through the file and remove defined illegal characters
    while True:
        chunk = ifile.read(1024*1024*50)
        if chunk == '':
            break;
        new_str = sub(__regexstring, '', chunk);
        ofile.write(new_str);

    # close the files
    ifile.close();
    ofile.close();
