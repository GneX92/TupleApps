﻿int [] array = [ 9 , 42 , 60 , 33 , 38 , 7 , 7 , 11 ];
int [] array2 = [ 21 , 65 , 6 , 1 , 14 , 58 , 56 , 38 , 18 , 2 ];
int [] array3 = [ 95 , 1 , 86 , 32 , 66 , 27 , 67 , 10 , 54 , 55 ];

var out1 = SimplePair( array );
var out2 = MergedPair( array2 , array3 );

foreach ( var i in out1 )
    Console.WriteLine( i );

Console.WriteLine();

foreach ( var i in out2 )
    Console.WriteLine( i );

Console.ReadLine();

static (T, T) [] SimplePair<T>( T [] arr )
{
    List<(T, T)> result = new();

    for ( int i = 0 ; i < arr.Length ; i++ )
    {
        if ( i % 2 == 0 && i + 1 < arr.Length )
        {
            var temp = (arr [ i ], arr [ i + 1 ]);
            result.Add( temp );
        }
    }
    return result.ToArray();
}

static (T1, T2) [] MergedPair<T1, T2>( T1 [] arr1 , T2 [] arr2 )
{
    int length = arr1.Length <= arr2.Length ? arr1.Length : arr2.Length;

    List<(T1, T2)> result = new();

    for ( int i = 0 ; i < length ; i++ )
    {
        var temp = (arr1 [ i ], arr2 [ i ]);
        result.Add( temp );
    }
    return result.ToArray();
}