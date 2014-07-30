#-------------------------------------------------------------------------------
# CopyCoreyFiles.py
#
# Brandan Haertel
# Program to copy all the Library and block files from
# northshore server to dropbox linked to coreys acct for
# up to date access. Readme logs cp and rm actions & time
#-------------------------------------------------------------------------------
import os, shutil, datetime

#Open file for logging
file = open("C:\\Users\\brandan.NSSM\\Dropbox\\Brandan\\CoreyAutocad" + "\\Readme.txt", "w")

def main():
    destination_folder = "C:\\Users\\brandan.NSSM\\Dropbox\\Brandan\\CoreyAutocad"

    #SERVER
    libray_folder = "P:\\Northshore Time Sheet\\Tools\\LIBRARY"
    libray_name = destination_folder + "\\" + "Library"

    blocks_folder = "Z:\\Blocks"
    blocks_name = destination_folder + "\\" + "Blocks"

    cleanTemp_folder = "Z:\\Northshore Job Templates"
    cleanTemp_name = destination_folder + "\\" + "Clean Template"
    '''
    #TESTING
    libray_folder = "C:\\Users\\brandan.NSSM\\Documents\\LIBRARY"
    libray_name = destination_folder + "\\" + "Library"

    blocks_folder = "C:\\Users\\brandan.NSSM\\Documents\\Blocks"
    blocks_name = destination_folder + "\\" + "Blocks"

    cleanTemp_folder = "C:\\Users\\brandan.NSSM\\Documents\\Northshore Job Templates"
    cleanTemp_name = destination_folder + "\\" + "Clean Template"
    '''

    #Program run title
    print "COPY FILES FOR COREY, IT MAY TAKE A FEW MINUTES....\n\n"

    #remove existing items
    removefolder(libray_name)
    removefolder(blocks_name)
    removefolder(cleanTemp_name)

    #copy librarys
    copyfolder(libray_folder, libray_name)
    copyfolder(blocks_folder, blocks_name)
    copyfolder(cleanTemp_folder, cleanTemp_name)

    #remove dirs not needed
    removefolder(cleanTemp_name + "\\Back-up")
    removefolder(cleanTemp_name + "\\Testing")

    #finalize logging
    print "\nWrite Readme..."
    #file = open(destination_folder + "\\Readme.txt", "w")
    time_now = datetime.datetime.now()
    time_now = time_now.strftime("%I:%M%p on %B %d, %Y")
    file.write("\n\nUpdated: " + time_now)
    file.close()

    #exit sequence
    print "Done!\a"
    time.sleep(3)

def removefolder(folder):
    # uses shutil library to remove dir, wrapped in try block
    # logs success or failure

    print "\tRemove:\t..." + folder
    file.write("\tRemove:\t..." + folder + "\n")
    try:
        shutil.rmtree(folder)
        file.write("OK\n")
        print "OK"
    except Exception:
        file.write("Failed\n")
        print "Failed"
        pass

def copyfolder(src, des):
    # uses shutil library to copy dir, wrapped in try block
    # logs success or failure

    print "\tCopy:\t..." + src
    file.write("\tCopy:\t..." + src + "\n")
    try:
        shutil.copytree(src, des)
        file.write("OK\n")
        print "OK"
    except Exception:
        file.write("Failed\n")
        print "Failed"
        pass

if __name__ == '__main__':
    main()
