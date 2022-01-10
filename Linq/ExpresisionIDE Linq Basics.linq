<Query Kind="Expression">
  <Connection>
    <ID>ae415203-0c51-4c3a-bce3-bfc67d8ca0f8</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>Chinook</Database>
  </Connection>
</Query>

//Our code is using C# grammer/syntax

//hotkey make line comment ctrl+k, ctrl+c
//				uncomment ctrl+k, ctrl+u
//alternate is to use ctrl + / as the toggle

//expressions 
//singlw linq query statements without a semi colon
// you can have mutiple statemnets in your file BUT
//	if you do, you must highlight th4e staement to execute

//execuge using F5 or the green triangle on the query menu

// to toggle your results on and off (visible) use ctrl +R

// query syntax
// uses a "sql like" syntax
// view the Student Notes for examples under
//			Demo/eRestaurant/Linq Query and Method syntax
//	or Notes/Linq Intro@

// rember to set your database usage connection

// query: Find all albums released in 2000. Display the entire album record
//		album record

from therowinstanceplaceholder in Albums
where therowinstanceplaceholder.ReleaseYear == 2000
select therowinstanceplaceholder

// method syntax
// uses C# method syntax OOP language grammer
// collection: Albums
// to excute a method on the collection you need to use 
// access operator (dot operator)
// results a resulting collection from the method !!!!****
// method name starts with a capital
// method contain contents with a delegate
// a delegate describes the action to be done

Albums
	.Where(therowinstanceplaceholder => therowinstanceplaceholder.ReleaseYear == 2000)
	.Select(therowinstanceplaceholder => therowinstanceplaceholder)