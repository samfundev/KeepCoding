#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.Sort(Array, Array, IComparer) Method
Sorts a pair of one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') using the specified [System.Collections.IComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IComparer 'System.Collections.IComparer').  
```csharp
public static KeepCoding.Tuple<System.Array,System.Array> Sort(this System.Array keys, System.Array items, System.Collections.IComparer comparer);
```
#### Parameters
<a name='KeepCoding_ArrayHelper_Sort(System_Array_System_Array_System_Collections_IComparer)_keys'></a>
`keys` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the keys to sort.
  
<a name='KeepCoding_ArrayHelper_Sort(System_Array_System_Array_System_Collections_IComparer)_items'></a>
`items` [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') that contains the items that correspond to each of the keys in the [keys](KeepCoding_ArrayHelper_Sort(System_Array_System_Array_System_Collections_IComparer).md#KeepCoding_ArrayHelper_Sort(System_Array_System_Array_System_Collections_IComparer)_keys 'KeepCoding.ArrayHelper.Sort(System.Array, System.Array, System.Collections.IComparer).keys')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') or `null` to sort only the [keys](KeepCoding_ArrayHelper_Sort(System_Array_System_Array_System_Collections_IComparer).md#KeepCoding_ArrayHelper_Sort(System_Array_System_Array_System_Collections_IComparer)_keys 'KeepCoding.ArrayHelper.Sort(System.Array, System.Array, System.Collections.IComparer).keys')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').
  
<a name='KeepCoding_ArrayHelper_Sort(System_Array_System_Array_System_Collections_IComparer)_comparer'></a>
`comparer` [System.Collections.IComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IComparer 'System.Collections.IComparer')  
The implementation to use when comparing elements or `null` to use the [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') implementation of each element.
  
#### Returns
[KeepCoding.Tuple&lt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[,](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
[keys](KeepCoding_ArrayHelper_Sort(System_Array_System_Array_System_Collections_IComparer).md#KeepCoding_ArrayHelper_Sort(System_Array_System_Array_System_Collections_IComparer)_keys 'KeepCoding.ArrayHelper.Sort(System.Array, System.Array, System.Collections.IComparer).keys') and [items](KeepCoding_ArrayHelper_Sort(System_Array_System_Array_System_Collections_IComparer).md#KeepCoding_ArrayHelper_Sort(System_Array_System_Array_System_Collections_IComparer)_items 'KeepCoding.ArrayHelper.Sort(System.Array, System.Array, System.Collections.IComparer).items')
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Array_System_Collections_IComparer_](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Array_System_Collections_IComparer_ 'https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Array_System_Collections_IComparer_')
