password = "clown"
guess = input("Enter your password: ")
if guess == password:
    route = input("")
    if route == "entry":
        my_file = open('Brandan.txt', 'a')
        entry = input("Entry... ")
        my_file.write("\n")
        my_file.write(entry)
        my_file.close()
    elif route == "read":
        my_file = open('Brandan.txt', 'r')
        lines = my_file.readlines()
        print (lines)
        input("")
    else:
        print ("Close")
else:
    print ("close")

#import pickle #importing the pickle
#my_list = ["Creat"] #stuff we are adding to the file
#pickle_file = open('Brandan.dia', 'w') #this creates the file
#pickle.dump(my_list, pickle_file) #this saves the file
#pickle_file.close() # this closes the file

#old
####################################
#import pickle
#my_file = open('Brandan.txt', 'a')
#entry = input("Entry... ")
#my_file.write("\n")
#my_file.write(entry)
#my_file.close()
#input("")
