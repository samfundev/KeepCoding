#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Helper](KeepCoding_Helper.md 'KeepCoding.Helper')
## Helper.SplitBy&lt;T&gt;(IEnumerable&lt;T&gt;, Predicate&lt;T&gt;) Method
Splits an [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable') in two based on a method provided.  
```csharp
public static KeepCoding.Tuple<System.Collections.Generic.IEnumerable<T>,System.Collections.Generic.IEnumerable<T>> SplitBy<T>(this System.Collections.Generic.IEnumerable<T> source, System.Predicate<T> predicate);
```
#### Type parameters
<a name='KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_T'></a>
`T`  
The type of the collection.
  
#### Parameters
<a name='KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_).md#KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_T 'KeepCoding.Helper.SplitBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The collection to split.
  
<a name='KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_predicate'></a>
`predicate` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_).md#KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_T 'KeepCoding.Helper.SplitBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')  
The method that decides where the item ends up.
  
#### Returns
[KeepCoding.Tuple&lt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_).md#KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_T 'KeepCoding.Helper.SplitBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[,](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_).md#KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_T 'KeepCoding.Helper.SplitBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;')  
A [Tuple&lt;T1,T2&gt;](KeepCoding_Tuple_T1_T2_.md 'KeepCoding.Tuple&lt;T1,T2&gt;') consisting of items from [source](KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_).md#KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_source 'KeepCoding.Helper.SplitBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).source') where [Item1](KeepCoding_Tuple_T__Item1.md 'KeepCoding.Tuple&lt;T&gt;.Item1') contains items that returned true in [predicate](KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_).md#KeepCoding_Helper_SplitBy_T_(System_Collections_Generic_IEnumerable_T__System_Predicate_T_)_predicate 'KeepCoding.Helper.SplitBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Predicate&lt;T&gt;).predicate'), and [Item2](KeepCoding_Tuple_T1_T2__Item2.md 'KeepCoding.Tuple&lt;T1,T2&gt;.Item2') otherwise.
