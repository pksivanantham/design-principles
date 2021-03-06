# Design principles

[![SonarCloud](https://sonarcloud.io/images/project_badges/sonarcloud-black.svg)](https://sonarcloud.io/dashboard?id=pksivanantham_design-principles)

[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=pksivanantham_design-principles&metric=bugs)](https://sonarcloud.io/dashboard?id=pksivanantham_design-principles)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=pksivanantham_design-principles&metric=code_smells)](https://sonarcloud.io/dashboard?id=pksivanantham_design-principles)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=pksivanantham_design-principles&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=pksivanantham_design-principles)


# Dependency Inversion Principle:

	Depend upon abstraction and do not depend on implementation(concrete classes)
	Highlevel modules should not depend on low level modules.Both should depend on abstractions
		High level components example:Controller,orchestration layer
		Lower level components example:logger,mail(concrete classes)
		
	We can also say program to an interface not an implementation
	
	
	
### Factory Method Pattern:

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


### Decorator:
Adds new responsibility to the existing class without modifying it.

### Adapter:
Converts one interface to another.
It implements the adapter interface and allows passing of adaptee using composition

### Facade:
It simplifies the multiple subsystem by prodiving one simple interface.

Principle of least knowledge:Talk only to your immediate friends
example:
we should call the other methods if its from 
	same object
	passed arugument's object method
	new objects created inside the method
We should not call the method if its returned from other method



