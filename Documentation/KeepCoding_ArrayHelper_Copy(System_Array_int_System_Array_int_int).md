#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Copy(Array, int, Array, int, int) Method
Copies a range of elements from an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') starting at the specified source index and pastes them to another [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') starting at the specified destination index. The length and the indexes are specified as 32-bit integers.  
```csharp
public static System.Array Copy(this System.Array sourceArray, int sourceIndex, System.Array destinationArray, int destinationIndex, int length);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_Copy(System_Array_int_System_Array_int_int)_sourceArray'></a>
`sourceArray` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the data to copy.
  
<a name='KeepCoding_ArrayHelper_Copy(System_Array_int_System_Array_int_int)_sourceIndex'></a>
`sourceIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A 32-bit integer that represents the index in the [sourceArray](KeepCoding_ArrayHelper_Copy(System_Array_int_System_Array_int_int).md#KeepCoding_ArrayHelper_Copy(System_Array_int_System_Array_int_int)_sourceArray 'KeepCoding.ArrayHelper.Copy(System.Array, int, System.Array, int, int).sourceArray') at which copying begins.
  
<a name='KeepCoding_ArrayHelper_Copy(System_Array_int_System_Array_int_int)_destinationArray'></a>
`destinationArray` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that receives the data.
  
<a name='KeepCoding_ArrayHelper_Copy(System_Array_int_System_Array_int_int)_destinationIndex'></a>
`destinationIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A 32-bit integer that represents the index in the [destinationIndex](KeepCoding_ArrayHelper_Copy(System_Array_int_System_Array_int_int).md#KeepCoding_ArrayHelper_Copy(System_Array_int_System_Array_int_int)_destinationIndex 'KeepCoding.ArrayHelper.Copy(System.Array, int, System.Array, int, int).destinationIndex') at which storing begins.
  
<a name='KeepCoding_ArrayHelper_Copy(System_Array_int_System_Array_int_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
A 32-bit integer that represents the number of elements to copy.
  
#### Returns
[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
[destinationArray](KeepCoding_ArrayHelper_Copy(System_Array_int_System_Array_int_int).md#KeepCoding_ArrayHelper_Copy(System_Array_int_System_Array_int_int)_destinationArray 'KeepCoding.ArrayHelper.Copy(System.Array, int, System.Array, int, int).destinationArray')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArrayTypeMismatchException](https://docs.microsoft.com/en-us/dotnet/api/System.ArrayTypeMismatchException 'System.ArrayTypeMismatchException')  
[System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Int32_System_Array_System_Int32_System_Int32_](https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Int32_System_Array_System_Int32_System_Int32_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0#System_Array_Copy_System_Array_System_Int32_System_Array_System_Int32_System_Int32_')
