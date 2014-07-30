def choose():
    print "Which converter would you like to use?"
    print "A. feet to inch converter"
    print "B. inch to feet converter"
    print "C. arch sum"
    choice = raw_input("")

    if choice == "A" :
        Feet = int(raw_input("Feet: "))
        Inches = float(raw_input("Inches: "))
        fanswer = Feet * 12
        print "\n*************"
        print fanswer + Inches
        print "*************"
        print ""
        print ""
        print ""
        print ""
        print ""
        print ""

    elif choice == "B" :
        Inches = float(raw_input("Inches: "))
        Feet = int(Inches/12)
        Inch_rem = Inches - Feet * 12
        print "\n*************"
        print Feet, "-", Inch_rem
        print "*************"
        print ""
        print ""
        print ""
        print ""
        print ""
        print ""

    elif choice == "C" :
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
        print ""
        print ""
        print ""
        print ""
        print ""
        print ""

    else:
        print "Sorry try again"
        raw_input("")

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


