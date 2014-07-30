/*
 * Sorts.java
 */
package filesort;

/**
 * Sorts.java
 * Sorts
 * Static method that preforms a optomised quicksort on a Comparable Array
 * @version 1.0
 * @author Brandan Haertel
 * Compiler: jdk1.7.0_09
 * Tested on: Windows 8 64bit AMD A8, Windows 7 64bit Intel I7
 * History:
 *      3/4/2013: Version 1.0 released to public!
 */
public class Sorts {
    
    /**
     * faux method that calls quick sort if only the array is passed in.
     * @param array Comparable array to be sorted
     * @throws java.lang.ArrayIndexOutOfBoundsException 
     */
    public static void quickSort(Comparable[] array)
        throws java.lang.ArrayIndexOutOfBoundsException
    {
        quickSort(array, 0, array.length - 1);
    }

    /**
     * optomized quicksort, if the comparable array length is less then 8
     * an insertion sort method is called to finish the sort.
     * @param array Comparable array to be sorted.
     * @param from beggining index to sort.
     * @param to last indext to sort
     * @throws java.lang.ArrayIndexOutOfBoundsException 
     */
    public static void quickSort(Comparable[] array, int from, int to)
        throws java.lang.ArrayIndexOutOfBoundsException
    {
        int index = partition(array, from, to);

        if((to - from) > 8)
        {
            if (from < index - 1)
                quickSort(array, from, index - 1);
            if (index < to)
                quickSort(array, index, to);
        }
        else
        {
            insertionSort(array, 0, array.length - 1);
        }
        
    }

    /**
     * insertion sort of type Comparable[]
     * @param array comparable array to be sorted
     * @param from beggining index of array to be sorted
     * @param to last index of array to be sorted.
     * @throws java.lang.ArrayIndexOutOfBoundsException 
     */
    public static void insertionSort(Comparable[] array, int from, int to)
       throws java.lang.ArrayIndexOutOfBoundsException
    {
        for (int i = from; i <= to; i++) 
        {
            Comparable temp = array[i];
            int j = i;
            while (j > 0 && array[j - 1].compareTo(temp) > 0) 
            {
                  array[j] = array[j - 1];
                  j--;
            }
            array[j] = temp;
        }
    }

    /**
     * Partions Comparable[] for the quicksort method.
     * @param array comparable array to be sorted
     * @param inFrom beggining index of array to be sorted
     * @param inTo last index of array to be sorted.
     * @return int partition position.
     * @throws java.lang.ArrayIndexOutOfBoundsException 
     */
    private static int partition(Comparable[] array, int inFrom, int inTo)
       throws java.lang.ArrayIndexOutOfBoundsException
    {
        int from = inFrom;
        int to = inTo;
        Comparable pivot = array[(from + to) / 2];
        
        while (from <= to)
        {
            while (array[from].compareTo(pivot) < 0) { from++; }
            while (array[to].compareTo(pivot) > 0) { to--; }
            if(from <= to)
            {
                swap (array, from, to);
                from++;
                to--;
            }
        }
        sortFirstMiddleLast(array, inFrom, ((inFrom + to) / 2), to);
        return from;
    }
        
    /**
     * Swaps two indexes of an array
     * @param array array to be swapped.
     * @param from first position to be swapped
     * @param to second position to be swapped
     * @throws java.lang.ArrayIndexOutOfBoundsException 
     */
    private static void swap(Comparable[] array, int from, int to)
       throws java.lang.ArrayIndexOutOfBoundsException
    {
        Comparable temp = array[from];
        array[from] = array[to];
        array[to] = temp;
    }

    /**
     * sorts the array positions of first, (first + last) / 2, and last.
     * @param array array to be sorted
     * @param from first position to be sorted
     * @param mid middle position to be sorted
     * @param to last position to be sorted
     * @throws java.lang.ArrayIndexOutOfBoundsException 
     */
    private static void sortFirstMiddleLast(
            Comparable[] array, int from, int mid, int to)
       throws java.lang.ArrayIndexOutOfBoundsException
    {
        if (array[from].compareTo(array[mid]) > 0)
        {
            swap(array, from, mid);
        }
        if (array[mid].compareTo(array[to]) > 0)
        {
            swap(array, mid, to);
        }
        if (array[from].compareTo(array[mid]) > 0)
        {
            swap(array, from, mid);
        }
  }
}