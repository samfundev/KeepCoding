#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[KeyHelper](KeepCoding_KeyHelper.md 'KeepCoding.KeyHelper')
## KeyHelper.Catch&lt;T1,T2&gt;(Action, Action&lt;Exception&gt;, Action) Method
The try-catch statement consists of a [try](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try') block followed by one or more [catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/catch') clauses, which specify handlers for different exceptions.  
```csharp
public static void Catch<T1,T2>(this System.Action action, System.Action<System.Exception> caught=null, System.Action final=null)
    where T1 : System.Exception
    where T2 : System.Exception;
```
#### Type parameters
<a name='KeepCoding_KeyHelper_Catch_T1_T2_(System_Action_System_Action_System_Exception__System_Action)_T1'></a>
`T1`  
The first type to catch.
  
<a name='KeepCoding_KeyHelper_Catch_T1_T2_(System_Action_System_Action_System_Exception__System_Action)_T2'></a>
`T2`  
The second type to catch.
  
#### Parameters
<a name='KeepCoding_KeyHelper_Catch_T1_T2_(System_Action_System_Action_System_Exception__System_Action)_action'></a>
`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to try.
  
<a name='KeepCoding_KeyHelper_Catch_T1_T2_(System_Action_System_Action_System_Exception__System_Action)_caught'></a>
`caught` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action to run when an exception is caught.
  
<a name='KeepCoding_KeyHelper_Catch_T1_T2_(System_Action_System_Action_System_Exception__System_Action)_final'></a>
`final` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to run on either clause.
  
#### Exceptions
[System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
### Remarks
#### See Also
- [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch')
