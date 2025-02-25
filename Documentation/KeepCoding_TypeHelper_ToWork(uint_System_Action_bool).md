#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[TypeHelper](KeepCoding_TypeHelper.md 'KeepCoding.TypeHelper')
## TypeHelper.ToWork(uint, Action, bool) Method
Converts argument to a new [Work](KeepCoding_Work.md 'KeepCoding.Work')
```csharp
public static KeepCoding.Work ToWork(this uint maximumThreadsActive, System.Action action, bool allowSimultaneousActive=false);
```
#### Parameters
<a name='KeepCoding_TypeHelper_ToWork(uint_System_Action_bool)_maximumThreadsActive'></a>
`maximumThreadsActive` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The amount of threads this class, and all of its overloads can run at once.
  
<a name='KeepCoding_TypeHelper_ToWork(uint_System_Action_bool)_action'></a>
`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to run when the thread is active.
  
<a name='KeepCoding_TypeHelper_ToWork(uint_System_Action_bool)_allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
#### Returns
[Work](KeepCoding_Work.md 'KeepCoding.Work')  
A new [Work](KeepCoding_Work.md 'KeepCoding.Work') consisting of the arguments provided.
