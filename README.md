# design-principles
Design principles
[![SonarCloud](https://sonarcloud.io/images/project_badges/sonarcloud-orange.svg)](https://sonarcloud.io/dashboard?id=pksivanantham_design-principles)

Dependency Inversion Principle:

	Depend upon abstraction and do not depend on implementation(concrete classes)
	Highlevel modules should not depend on low level modules.Both should depend on abstractions
		High level components example:Controller,orchestration layer
		Lower level components example:logger,mail(concrete classes)
		
	We can also say program to an interface not an implementation
	
	
	
Factory Method Pattern:

It defines the interface for creating the object,and allow sub classes to decide which object to create. It defers the object creation to sub classes
Creator class no need to know about the implementation.Sub class will decide the object creation

We can acheive DSP using this pattern.

It will use classes to create the required objects.
It will do it through inheritance.

Abstarct Factory Pattern:

Provides an interface to create dependendable or related objects without specifying concrete classes.
Abstarct factory can containg list of factory methods.

```
interface IFactory
{
 Product1 CreateProduct1();
 
 Product2 CreateProduct2();
} 

```
It will uses the objects to create required product. In the above example instances of IFactory is used to create the required objects.
It will do it using object composition(IFactory can be replaced by any of the IFactory implemented classes)
