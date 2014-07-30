print "Which converter would you like to use?"
print "a. feet to inch converter"
print "b. inch to feet converter"
print "c. arch sum"
choice = raw_input("")

if choice == "a" :
    Feet = int(raw_input("Feet: "))
    Inches = float(raw_input("Inches: "))
    fanswer = Feet * 12
    print "\n*************"
    print fanswer + Inches
    print "*************"
    raw_input("Press Enter to Exit...")

elif choice == "b" :
    Inches = float(raw_input("Inches: "))
    Feet = int(Inches/12)
    Inch_rem = Inches - Feet * 12
    print "\n*************"
    print Feet, "-", Inch_rem
    print "*************"
    raw_input("Press Enter to Exit...")

elif choice == "c" :
    Feet1 = int(raw_input("Feet #1: "))
    Inches1 = float(raw_input("Inches #1: "))
    Feet2 = int(raw_input("Feet #2: "))
    Inches2 = float(raw_input("Inches #2: "))
    d_fanswer1 = Feet1 * 12 + Inches1
    d_fanswer2 = Feet2 * 12 + Inches2
    print "\n*************"
    print "Arch: ", Feet1 + Feet2, "-", Inches1 + Inches2
    print "Decimal: ", d_fanswer1 + d_fanswer2
    print "*************"
    raw_input("Press Enter to Exit...")

else:
    print "Sorry try again"
    raw_input("")
