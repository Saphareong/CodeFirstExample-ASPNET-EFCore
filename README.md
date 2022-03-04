# CodeFirstExample-ASPNET-EFCore
Ignore the folder say it is CodeSecond because this is my second try to make the First Code API from EF Core
If you need a sample project using Code First API then take my but remember to install some reference packet
<img src="https://user-images.githubusercontent.com/63325505/156730416-0d0981e1-804f-4fd3-b0a1-10d7e9ddf4c5.png">
<h3>Once you do it we will start explaining At first you create some Entity class like those (I named DTO because I'm testing something else)</h3>
<img src="https://user-images.githubusercontent.com/63325505/156730641-a429d478-2657-48b8-a966-15f24c5f36ac.png">
<h3>And then you create a class inheritence from Dbcontext to configure your Database like this</h3>
<img src="https://user-images.githubusercontent.com/63325505/156730820-84518460-d1e5-4139-aab6-7b2bc41f0d7c.png">
<h3>If you don't name the database it will automatically generate table into master database
Now all you have to do is open the terminal of you project and write</h3>
dotnet ef migrations add (whatever you want to name)
<h3>OR you use the packet manager console and just write</h3>
Add-Migration (whatever you want to name)


And done all you have to do is checking by your own
Contact me if you get something wrong
