import Blogo10
import os

#this program will take a wall length and divid it equally between
#as many panels as the user wants, taking into account panel
#joint spaces or panel lap spaces.

def choose():
    print ("This program produces equal panel distances.\n\nSelect one of the following options to continue...\n\nA.Equal Module Panels.\nB.Equal Lapped Panels\n\n")
    choice = input(">>>")
    os.system('cls')

    if choice == "A":
        emp()
    elif choice == "a":
        emp()
    elif choice == "B":
        elp()
    elif choice == "b":
        elp()
    else:
        os.system('cls')
        choose()

def emp():
    print ("*******************************************")
    print ("Equal Module Panels")
    print ("Enter the total span of the panels")
    print ("Enter how many equal panels you need")
    print ("Enter the joint size (in decimal inches)")
    print ("*******************************************\n\n")

    len_feet = int(input("Span of panels (Feet)..."))
    len_inch = float(input("Span of panels (Inches)..."))
    os.system('cls')
    num_pnls = int(input("How many panels?..."))
    os.system('cls')
    jt_size = float(input("What is the joint size?..."))
    os.system('cls')

    pre_wall = len_feet * 12 + len_inch
    joints = num_pnls - 1
    tot_jt = jt_size*joints
    wall = pre_wall - tot_jt
    panels = wall/num_pnls

    print (num_pnls, "Equally spaced is ", panels, "a panel")
    input("Press any key to restart...")
    os.system('cls')
    emp()

def elp():
    print ("*******************************************")
    print ("Equal Lapped Panels")
    print ("Enter the total span of the panels")
    print ("Enter how many equal panels you need")
    print ("Enter the lap distance")
    print ("*******************************************\n\n")

    len_feet = int(input("Span of panels (Feet)..."))
    len_inch = float(input("Span of panels (Inches)..."))
    os.system('cls')
    num_pnls = int(input("How many panels?..."))
    os.system('cls')
    lap_size = float(input("What is the lap distance?..."))
    os.system('cls')

    pre_wall = len_feet * 12 + len_inch
    num_laps = num_pnls - 1
    lap = num_laps * lap_size
    wall = pre_wall + lap
    panels = wall/num_pnls

    print (num_pnls, "Equally Spaced Is ", panels, "a panel")
    input("Press any key to restart...")
    os.system('cls')
    elp()
    
Blogo10.logo10()
choose()
