#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[ArrayHelper](KeepCoding_ArrayHelper.md 'KeepCoding.ArrayHelper')
## ArrayHelper.AsReadOnly&lt;T&gt;(T[]) Method
Returns a read-only wrapper for the specified array.  
```csharp
public static System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly<T>(this T[] array);
```
#### Type parameters
<a name='KeepCoding_ArrayHelper_AsReadOnly_T_(T__)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='KeepCoding_ArrayHelper_AsReadOnly_T_(T__)_array'></a>
`array` [T](KeepCoding_ArrayHelper_AsReadOnly_T_(T__).md#KeepCoding_ArrayHelper_AsReadOnly_T_(T__)_T 'KeepCoding.ArrayHelper.AsReadOnly&lt;T&gt;(T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based array to wrap in a read-only [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') wrapper.
  
#### Returns
[System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[T](KeepCoding_ArrayHelper_AsReadOnly_T_(T__).md#KeepCoding_ArrayHelper_AsReadOnly_T_(T__)_T 'KeepCoding.ArrayHelper.AsReadOnly&lt;T&gt;(T[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')  
A read-only [System.Collections.ObjectModel.ReadOnlyCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1') wrapper for the specified array.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/api/system.array.asreadonly?view=net-5.0](https://docs.microsoft.com/en-us/dotnet/api/system.array.asreadonly?view=net-5.0 'https://docs.microsoft.com/en-us/dotnet/api/system.array.asreadonly?view=net-5.0')
