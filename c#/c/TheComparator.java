package test2;

import java.util.Comparator;

public class TheComparator implements Comparator {
    /** ソート対象のカラムの位置 */
    private int index = 0;

    /** ソートするためのカラム位置をセット */
    public void setIndex( int index ) {
        this.index = index;
    }

    public int compare( Object a, Object b ) {
        String[] strA = ( String[] ) a;
        String[] strB = ( String[] ) b;

        return ( strA[ index ].compareTo( strB[ index ] ) );
    }
}
