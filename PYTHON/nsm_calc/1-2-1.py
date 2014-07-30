import Blogo10
import os
# This program is a simple calc dealing with architectual inches and feet
# user starts with a chice menu and moves into the calc
# after the calc finishes the program repeats itself approx. 20 times before closing
#
# created by Brandan Haertel March 5th 2012

# make the program repeat on a paticular letter chossen untill the user
# sends a break command. ~ request by Corey 3/6/2012

def choose():
    print ("Which converter would you like to use?\nA. Feet to Inch\nB. Inch to Feet\nC. Architectual sum\nD. Tally Inches")
    choice = input("Please choose a letter to continue... ")
    os.system('cls')

    if choice == "A":
        fti()
    elif choice == "a":
        fti()
    elif choice == "B":
        itf()
    elif choice == "b":
        itf()
    elif choice == "C":
        archsum()
    elif choice == "c":
        archsum()
    elif choice == "D":
        ti()
    elif choice == "d":
        ti()
    elif choice == "E":
        tfi()
    elif choice == "e":
        tfi()
    else:
        print ("Sorry, i do not reconize your choice!\nPlease select again:\n")

def fti():
    inchnote()
    Feet = int(input("Feet: "))
    Inches = float(input("Inches: "))
    fanswer = Feet * 12
    print ("\n*************")
    print (fanswer + Inches,"\"")
    input ("*************\n\n\n\n\n")
    os.system('cls')

def itf():
    inchnote()
    Inches = float(input("Inches: "))
    Feet = int(Inches/12)
    Inch_rem = Inches - Feet * 12
    print ("\n*************")
    print (Feet,"\'"" -",Inch_rem,"\"")
    input ("*************\n\n\n\n\n")
    os.system('cls')

def archsum():
    inchnote()
    Feet1 = int(input("Feet #1: "))
    Inches1 = float(input("Inches #1: "))
    Feet2 = int(input("Feet #2: "))
    Inches2 = float(input("Inches #2: "))
    d_fanswer1 = Feet1 * 12 + Inches1
    d_fanswer2 = Feet2 * 12 + Inches2
    print ("\n*************")
    print ("Arch: ", Feet1 + Feet2,"\'""-", Inches1 + Inches2,"\"")
    print ("Decimal: ", d_fanswer1 + d_fanswer2,"\"")
    input ("*************\n\n\n\n\n")
    os.system('cls')

def ti():
    print ("****************************************************************\n")
    print ("          Enter \"0\" to exit Tally")
    print ("\n****************************************************************\n\n")
    list_nums = []
    num = float(input("Enter a length: "))
    list_nums.append(num)
    while num:
        if num == 0:
            os.system('cls')
            break
        else:
            num = float(input("Enter a length: "))
            list_nums.append(num)
            print (sum(list_nums),"\"")
            print ("\n")

def tfi():
    constnote()

def inchnote():
    print ("****************************************************************\n")
    print ("          Decimal Inches only, no Fractional")
    print ("\n****************************************************************\n\n")

def constnote():
    print ("****************************************************************\n")
    print ("          Under construction")
    print ("          Please Check back later")
    print ("\n****************************************************************\n\n")

Blogo10.logo10()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
choose()
