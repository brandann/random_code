# This program is a simple calc dealing with architectual inches and feet
# user starts with a chice menu and moves into the calc
# after the calc finishes the program repeats itself approx. 20 times before closing
#
# created by Brandan Haertel March 5th 2012
def choose():
    print "Which converter would you like to use?\n"
    print "A. feet to inch converter"
    print "B. inch to feet converter"
    print "C. arch sum"
    print "D. Tally Inches"
    print "E. Tally Feet and Inches\n\n"
    choice = raw_input("Please choose a letter to continue... ")
    print "\n\n"

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
        print "Sorry, i do not reconize your choice!\nPlease select again:\n"

def fti():
    inchnote()
    Feet = int(raw_input("Feet: "))
    Inches = float(raw_input("Inches: "))
    fanswer = Feet * 12
    print "\n*************"
    print fanswer + Inches,"\""
    print "*************\n\n\n\n\n"

def itf():
    inchnote()
    Inches = float(raw_input("Inches: "))
    Feet = int(Inches/12)
    Inch_rem = Inches - Feet * 12
    print "\n*************"
    print Feet,"\'"" -",Inch_rem,"\""
    print "*************\n\n\n\n\n"

def archsum():
    inchnote()
    Feet1 = int(raw_input("Feet #1: "))
    Inches1 = float(raw_input("Inches #1: "))
    Feet2 = int(raw_input("Feet #2: "))
    Inches2 = float(raw_input("Inches #2: "))
    d_fanswer1 = Feet1 * 12 + Inches1
    d_fanswer2 = Feet2 * 12 + Inches2
    print "\n*************"
    print "Arch: ", Feet1 + Feet2,"\'""-", Inches1 + Inches2,"\""
    print "Decimal: ", d_fanswer1 + d_fanswer2,"\""
    print "*************\n\n\n\n\n"

def ti():
    print "****************************************************************\n"
    print "          Enter \"0\" to exit Tally"
    print "\n****************************************************************\n\n"
    list_nums = []
    num = float(raw_input("Enter a length: "))
    list_nums.append(num)
    while num:
        if num == 0:
            break
        else:
            num = float(raw_input("Enter a length: "))
            list_nums.append(num)
            print sum(list_nums),"\""
            print "\n"

def tfi():
    constnote()

def inchnote():
    print "****************************************************************\n"
    print "          Decimal Inches only, no Fractional"
    print "\n****************************************************************\n\n"

def constnote():
    print "****************************************************************\n"
    print "          Under construction"
    print "          Please Check back later"
    print "\n****************************************************************\n\n"
    list_nums = []
    pretotal = int(raw_input("Feet: ")) * 12 + float(raw_input("Inches: "))
    list_nums.append(pretotal)
    while pretotal:
        if pretotal == "/":
            break
        else:
            pretotal = int(raw_input("Feet: ")) * 12 + float(raw_input("Inches: "))
            list_nums.append(pretotal)
            prefeet = sum(list_nums)/12
            preinch = sum(list_nums)-prefeet*12
            print "Total: ", prefeet,"\'",preinch,"\""

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
