# Using Undocumented Windows APIs and DLL Injection in C#
Brown bag presentation I made

Please refer to [this pdf](https://github.com/kphongagsorn/windows_api/blob/master/Windows_Exploitation_using_Windows_API%E2%80%99s.pdf) for the presentation

## Using Undocumented Window's APIs 

### Getting User Credentials
![alt text](https://github.com/kphongagsorn/windows_api/blob/master/images/windows_demo_poc1.PNG "Getting User Credentials")

### Accessing registry keys/values
![alt text](https://github.com/kphongagsorn/windows_api/blob/master/images/windows_demo_poc2.PNG "Accessing registry keys/values")

## Keylogger
### Keylogger in C#
![alt text](https://github.com/kphongagsorn/windows_api/blob/master/images/key_logger_poc.PNG "Keylogger")

## DLL Injection

### DLL Injection using LoadLibraryA()
![alt text](https://github.com/kphongagsorn/windows_api/blob/master/images/dll_injection_poc.PNG "DLL Injection using LoadLibraryA()")


## References:
* https://media.defcon.org/DEF%20CON%2025/DEF%20CON%2025%20workshops/DEFCON-25-Workshop-Chuck-Easttom-Windows-The-Undiscovered-Country.pdf
* https://www.endgame.com/blog/technical-blog/ten-process-injection-techniques-technical-survey-common-and-trending-process
* http://blog.opensecurityresearch.com/2013/01/windows-dll-injection-basics.html?m=1
* https://attack.mitre.org/wiki/Technique/T1055
* https://msdn.microsoft.com/en-us/library/system.runtime.interopservices.marshal(v=vs.110).aspx
* http://www.codingvision.net/miscellaneous/c-inject-a-dll-into-a-process-w-createremotethread
* https://www.youtube.com/watch?v=C2OtYr0EyOg
* http://winapi.systemoverflow.com/?page_id=138
* https://en.wikipedia.org/wiki/Dynamic-link_library
* https://en.wikipedia.org/wiki/Microsoft_Windows_library_files
