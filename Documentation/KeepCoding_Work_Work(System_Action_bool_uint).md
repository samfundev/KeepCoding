#### [KeepCoding](index.md 'index')
### [KeepCoding](KeepCoding.md 'KeepCoding').[Work](KeepCoding_Work.md 'KeepCoding.Work')
## Work.Work(Action, bool, uint) Constructor
Stores the method so that it can later be called when a new thread starts.  
```csharp
public Work(System.Action work, bool allowSimultaneousActive, uint maximumThreadsActive);
```
#### Parameters
<a name='KeepCoding_Work_Work(System_Action_bool_uint)_work'></a>
`work` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The method to call when thread starts.
  
<a name='KeepCoding_Work_Work(System_Action_bool_uint)_allowSimultaneousActive'></a>
`allowSimultaneousActive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether it should allow multiple of itself to be running at once.
  
<a name='KeepCoding_Work_Work(System_Action_bool_uint)_maximumThreadsActive'></a>
`maximumThreadsActive` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The amount of threads this class, and all of its overloads can run at once.
  
