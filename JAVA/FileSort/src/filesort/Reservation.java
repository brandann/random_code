/*
 * Reservation.java
 */
package filesort;

import Calendar.DateAD;
import java.io.Serializable;

/**
 * Reservation.java
 * Reservation
 * Reservation class that holds a single reservation name, arrival date,
 * and check out date
 * @version 1.0
 * @author Brandan Haertel
 * Compiler: jdk1.7.0_09
 * Tested on: Windows 8 64bit AMD A8, Windows 7 64bit Intel I7
 * History:
 *      3/4/2013: Version 1.0 released to public!
 */
public class Reservation implements Serializable, Comparable {
    
    /**
     * Constructor
     * @param myName name of individual reserving a hotel room
     * @param myArrival DateAD date of arrival
     * @param myDeparture  DateAD date of departure
     */
    public Reservation(String myName, DateAD myArrival, DateAD myDeparture)
    {
        name = myName;
        arrivalDate = myArrival.clone();
        departureDate = myDeparture.clone();
    }
    
    /**
     * name accesser
     * @return String name of individual reserving a hotel room
     */
    public String getName()
    {
        return name;
    }
    
    /**
     * arrival date accessor
     * @return DateAD arrivalDate
     */
    public DateAD getArrivalDate()
    {
        return arrivalDate;
    }
    
    /**
     * departure date accessor
     * @return DateAD departureDate
     */
    public DateAD getDepartureDate()
    {
        return departureDate;
    }
    
    /**
     * reservation toString, formatted very fancy
     * @return String name + arrivalDate + departure strings 
     * with newline chars
     */
    @Override
    public String toString()
    {
        return name + "\n" +
                arrivalDate.toString() + "\n" +
                departureDate.toString() + "\n";
    }
    
    /**
     * compares two reservation files
     * @param reservationIn takse in reservation to compare to this
     * @return boolean true if equal, false if not equal.
     */
    @Override
    public boolean equals(Object reservationIn)
    {
        Reservation compReservationIn = (Reservation) reservationIn;
        if(name.equals(compReservationIn.getName()))
        {
            if(arrivalDate.equals(compReservationIn.getArrivalDate()))
            {
                if(departureDate.equals(compReservationIn.getDepartureDate()))
                {
                    return true;
                }
            }
        }
        return false;
    }
    
    /**
     * compares two reservation files
     * @param reservationIn taks in reservation to compare to this
     * @return int < 0 if before, == 0 if equal, > 0 if after
     * @throws java.lang.ClassCastException 
     */
    @Override
    public int compareTo(Object reservationIn)
            throws java.lang.ClassCastException
    {
        Reservation compReservationIn = (Reservation) reservationIn;
        
        //Quick check to see if equal:
        if(this.equals(compReservationIn))
        {
            return EQUALS;
        }
        
        //we know that it isnt equal, so what is it??
        if(name.compareTo(compReservationIn.getName()) == EQUALS)
        {
            if(arrivalDate.compareTo(
                    compReservationIn.getArrivalDate()) == EQUALS)
            {
                if(departureDate.compareTo(
                        compReservationIn.getDepartureDate()) > EQUALS)
                {
                    return AFTER;
                }
                else
                {
                    return BEFORE;
                }
            }
            else if(arrivalDate.compareTo(
                    compReservationIn.getArrivalDate()) > EQUALS)
            {
                return AFTER;
            }
            else
            {
                return BEFORE;
            }
        }
        else if(name.compareTo(compReservationIn.getName()) > EQUALS)
        {
            return AFTER;
        }
        else
        {
            return BEFORE;
        }
    }
    
    private String name;
    private DateAD arrivalDate;
    private DateAD departureDate;

    private final int BEFORE = -1;
    private final int AFTER = 1;
    private final int EQUALS = 0;
}

