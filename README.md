# Loading Views(Razor) from Database

In 2019 I was working on this product with a very dynamic rendering engine with issues,
while working on it I understood it works with expression evaluators which had some serious issues.

Since I had some experience with MVC razor at that time while digging .net mvc's razor engine found out it has some amazing features,
In a basic .net MVC project views are stored in physical file system.
And when we have applications which require changes more frequently and need to create more dynamically we can store it in any other place
and change on demand without anyd deployments, this is one scenario there are many more when this feature can be useful.

I have read many articles and from different source I made this as sample application since I didn't find any working sample.

We just need to implement VirtualPathProvider class
https://learn.microsoft.com/en-us/dotnet/api/system.web.hosting.virtualpathprovider?view=netframework-4.8

Like views we can also load javascript, css and other content files from Database and create a more dynamic application.
