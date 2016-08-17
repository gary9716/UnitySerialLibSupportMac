This serial port transimission test should be able to use on Mac.
Just put the libMonoPosixHelper.dylib under the path ~/lib/

You may get the following error:

error CS0234: The type or namespace name `Ports' does not exist in the namespace `System.IO'. Are you missing an assembly reference?
Solution:

First make sure the correct platform is selected in File | Build Settings. It should be "PC, Mac & Linux standalone". Other platforms are not supported. In some circonstances, the setting switches back to another platform.

Then go to Edit | Project Settings | Player | PC, Mac & Linux Standalone settings | Other Settings | Optimization | API Compatibility Level and select ".Net 2.0". The other option does not contain the Ports namespace.

In some older version of Unity, you would find this option in: File | Build Settings | Optimization | API Compatibility Level: .Net 2.0