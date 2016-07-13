# Holmes
Interview Puzzle example

## Notes
This project should build and run on Visual Studio 2013. It was build using VS2013 Update 5.

## Design
I have built this using as many good practices as possible, paying particular attention to code style and consistentcy, i.e. each file is 100% StyleCop compliant.
The solution is split into 3 projects, a Core project, an Infrastructure project and finally a "Main" project to tie it all together. This design is based on the "onion architecture" and is a good, simple example of N-tier design.

The solution makes heavy use of Dependency injection, which should make it easy to extend and update in future. Data comes from simple repository classes that could be swapped out for an XML file loading class, Entity Framework, etc.
Composition is used in favour of inheritance, though there is a trivial example used just to show that I understand the difference.

Unit testing was not performed due to time constraints, however thanks to DI it would be very straightforward to add.

The design lends itself well to being extended if necessary. It doesn't have to be a console application, it could easily become a forms application or be used as part of a web service with minimal refactoring.
